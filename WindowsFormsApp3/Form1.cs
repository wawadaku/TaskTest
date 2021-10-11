using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            ss();
            for (int i = 0; i < 96; i++)
            {
                m_EnzymeVulList.Add(2);
            }
        }
        private void ss()
        {
            short i = -540;
            short aa = 540;
            byte[] b = new byte[2];
            b[0] = (byte)((0xff00 & i) >> 8);
            b[1] = (byte)(0xff & i);
            //b[0] = (byte)(i >> 8);
            //b[1] = (byte)(i & 0x00ff);
            //Console.WriteLine(b[0]);
            //Console.WriteLine(b[1]);
            //Console.WriteLine(BitConverter.ToString(b));

            byte[] c = BitConverter.GetBytes(i);
            byte[] d = BitConverter.GetBytes(aa);
            Console.WriteLine(i);
            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
            Console.WriteLine("-----------");
            Console.WriteLine(aa);
            Console.WriteLine(d[0]);
            Console.WriteLine(d[1]);
            //Console.WriteLine(BitConverter.ToString(c));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BitConverter(textBox1.Text);
            //ByteConverter
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Excel文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.ReadFromExcelFileDF(textBox1.Text);
        }
        public List<int> m_EnzymeVulList = new List<int>();//酶标
        int m_EnzymeZSYY = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (m_EnzymeZSYY == 0)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Judge(i, j);
                            richTextBox1.AppendText($"{i}加水{j}\r\n");
                            //Thread.Sleep(50);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < m_EnzymeVulList.Count; i++)
                    {
                        richTextBox1.AppendText($"{i / 12}加原液{i % 12}\r\n");
                    }
                    break;
                }
            }
        }
        private void Judge(int row, int cell)
        {
            if (row == 19 && cell == 7)
            {
                m_EnzymeZSYY = 1;
            }
        }
    }
}
