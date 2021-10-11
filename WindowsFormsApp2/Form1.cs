using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<PartLocation> locations = new List<PartLocation>();
        List<string> y_parts = new List<string>();//移液器部件列表
        List<string> x_parts = new List<string>();//旋转电爪部件列表
        List<string> modes1 = new List<string>();//校准方式1--上下校准
        List<string> modes2 = new List<string>();//校准方式2--水平校准和下探校准
        public Form1()
        {
            InitializeComponent();
            LoadParts();//加载不同类型的部件
            com_Type.SelectedIndex = 0;//类型--移液器或者旋转电爪
            LoadPartLoc();//展示部件的坐标
            LoadDataGridView();
        }

        private void LoadParts()
        {
            modes1.Add("上下校准");
            modes2.Add("原点校准");
            modes2.Add("下探校准");
            string parts = ConfigurationManager.AppSettings["部件列表"];
            foreach (string item in parts.Split(','))
            {
                if (item.EndsWith("X"))
                {
                    x_parts.Add(item.Substring(0, item.Length - 1));
                }
                if (item.EndsWith("Y"))
                {
                    y_parts.Add(item.Substring(0, item.Length - 1));
                }
            }
        }
        private void LoadPartLoc()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "parts.json");
            if (File.Exists(path))
            {
                string loc = File.ReadAllText(path);
                locations = JsonConvert.DeserializeObject<List<PartLocation>>(loc);
            }
            foreach (PartLocation item in locations)
            {
                if ((item.Type == com_Type.Text) && (item.Name == com_Parts.Text))
                {
                    txt_X.Text = item.X.ToString();
                    txt_Y.Text = item.Y.ToString();
                    txt_Z.Text = item.Z.ToString();
                    x = Convert.ToDouble(item.X);
                    y = Convert.ToDouble(item.Y);
                    z = Convert.ToDouble(item.Z);
                }
            }
        }

        private void LoadDataGridView()
        {
            for (int ii = 1; ii <= 14; ii++)
            {
                DataGridViewImageColumn dvic3 = new DataGridViewImageColumn(valuesAreIcons: false);
                dvic3.Image = imageList1.Images[1];
                dvic3.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridView3.Columns.Add(dvic3);
                if (ii == 1)
                {
                    dataGridView3.Rows.Add(5);
                }
                for (int jj2 = 1; jj2 <= 6; jj2++)
                {
                    dataGridView3.Rows[jj2 - 1].Cells[ii - 1].Value = dvic3.Image;
                }
                if (ii <= 6)
                {
                    dataGridView3.Rows[ii - 1].Height = 22;
                }
                dataGridView3.Columns[ii - 1].Width = 22;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            PartLocation location = new PartLocation();
            location.Type = com_Type.Text;
            location.Name = com_Parts.Text;
            location.Pid = Convert.ToInt32(com_Parts.Text.Split('号')[0]);
            location.X = Convert.ToInt32(txt_X.Text);
            location.Y = Convert.ToInt32(txt_Y.Text);
            location.Z = Convert.ToInt32(txt_Z.Text);
            if (!CheckLoac(location))
                locations.Add(location);
            string loc = JsonConvert.SerializeObject(locations);
            string path = Path.Combine(Environment.CurrentDirectory, "parts.json");
            File.WriteAllText(path, loc);
            MessageBox.Show("保存完成");
        }
        /// <summary>
        /// 检查当前坐标是否存在，存在则修改，不存在就新加
        /// </summary>
        /// <param name="location">部件坐标</param>
        /// <returns>true或false</returns>
        private bool CheckLoac(PartLocation location)
        {
            foreach (PartLocation item in locations)
            {
                if ((item.Type == location.Type) && (item.Name == location.Name))
                {
                    item.Pid = location.Pid;
                    item.X = location.X;
                    item.Y = location.Y;
                    item.Z = location.Z;
                    return true;
                }
            }
            return false;
        }

        private void com_Parts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_Parts.Text.Contains("Z运动平面校准"))
            {
                com_Mode.DataSource = modes1;
                txt_X.Text = "0";
                txt_Y.Text = "0";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                com_Mode.DataSource = modes2;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            foreach (PartLocation item in locations)
            {
                if (com_Type.Text == item.Type && com_Parts.Text == item.Name)
                {
                    txt_X.Text = item.X.ToString();
                    txt_Y.Text = item.Y.ToString();
                    txt_Z.Text = item.Z.ToString();
                    x = Convert.ToDouble(item.X);
                    y = Convert.ToDouble(item.Y);
                    z = Convert.ToDouble(item.Z);
                }
            }
        }

        private void com_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (com_Type.Text)
            {
                case "移液器":
                    com_Parts.DataSource = y_parts;
                    break;
                case "旋转电爪":
                    com_Parts.DataSource = x_parts;
                    break;
            }
        }

        double x = 0.0;//x轴坐标值
        double y = 0.0;//y轴坐标值
        double z = 0.0;//z轴坐标值
        private void button1_Click(object sender, EventArgs e)
        {
            int re = Convert.ToInt32(com_Parts.Text.Split('号')[0]);
            int indx = com_Mode.SelectedIndex;

            double nm = Convert.ToDouble(num_X.Value);
            x += nm;
            txt_X.Text = x.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int re = Convert.ToInt32(com_Parts.Text.Split('号')[0]);
            double nm = Convert.ToDouble(num_X.Value);
            x -= nm;
            txt_X.Text = x.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double nm = Convert.ToDouble(num_Y.Value);
            y += nm;
            txt_Y.Text = y.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double nm = Convert.ToDouble(num_Y.Value);
            y -= nm;
            txt_Y.Text = y.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double nm = Convert.ToDouble(num_Z.Value);
            z += nm;
            txt_Z.Text = z.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double nm = Convert.ToDouble(num_Z.Value);
            z -= nm;
            txt_Z.Text = z.ToString();
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(5);
            list.Add(3);
            list.Add(7);
            list.Add(1);
            testsss<int> testsss = new testsss<int>();
            int res = testsss.Cal(list);
            res = testsss.IsC(list, 9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            Type dgvType = this.dataGridView2.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridView2, true, null);
        }

        int rows;
        int cells;

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < testuu.arr.Count(); i++)
            {
                if (testuu.arr[i] == 1)
                {
                    continue;
                }
                Thread.Sleep(50);
                dataGridView2.Rows[i / dataGridView2.Columns.Count].Cells[i % dataGridView2.Columns.Count].Value = imageList1.Images[1];
                dataGridView2.Refresh();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= rows && e.ColumnIndex <= cells)
            {
                dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                ChangeDgv(e.RowIndex, e.ColumnIndex, dataGridView2);
            }
            else
            {
                rows = e.RowIndex;
                cells = e.ColumnIndex;
                testuu.arr = new int[(rows + 1) * (cells + 1)];
                for (int i = 0; i <= cells; i++)
                {
                    for (int j = 0; j <= rows; j++)
                    {
                        dataGridView3.Rows[j].Cells[i].Style.BackColor = Color.Green;
                    }
                }
                Cal(rows, cells, dataGridView2);
            }
        }
        private void Cal(int row, int cell, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.Width = 22 * (cell + 1) + 3;
            dgv.Height = 22 * (row + 1) + 3;
            for (int i = 1; i <= cell + 1; i++)
            {
                DataGridViewImageColumn dvic3 = new DataGridViewImageColumn(valuesAreIcons: false);
                dvic3.Image = imageList1.Images[0];
                dvic3.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv.Columns.Add(dvic3);
                if (i == 1)
                {
                    dgv.Rows.Add(row);
                }
                for (int j = 1; j <= row + 1; j++)
                {
                    dgv.Rows[j - 1].Cells[i - 1].Value = dvic3.Image;
                }
                if (i <= rows + 1)
                {
                    dgv.Rows[i - 1].Height = 22;
                }
                dgv.Columns[i - 1].Width = 22;
            }
            dgv.ClearSelection();
        }
        private void ChangeDgv(int row, int cell, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                for (int j = 0; j < dgv.Rows.Count; j++)
                {
                    if (i == cell && j == row)
                    {
                        dgv.Rows[j].Cells[i].Value = imageList1.Images[2];
                        testuu.arr[dgv.Columns.Count * row + cell] = 1;
                    }
                }
            }
        }
    }
}
