using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTest
{
    public partial class Form1 : Form
    {
        private string[] redNums = new string[33];
        private string[] blueNums = new string[16];
        private static readonly object objlock = new object();//锁
        private bool flag = true;
        private List<Task> listtask = new List<Task>();
        public Form1()
        {
            InitializeComponent();
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            flag = true;
            AddNums();
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
            CreateRandomNum();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            flag = false;
            Task.Factory.ContinueWhenAll
                (
                    listtask.ToArray(), t =>
                    {
                        MessageBox.Show($"本期双色球结果：{label1.Text},{label2.Text},{label3.Text},{label4.Text},{label5.Text},{label6.Text}   {label7.Text}");
                    }
                );
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
        }
        /// <summary>
        /// 添加红色和蓝色数字
        /// </summary>
        private void AddNums()
        {
            for (int i = 1; i < 34; i++)
            {
                if (i < 10)
                {
                    redNums[i - 1] = "0" + i;
                }
                else
                {
                    redNums[i - 1] = "" + i;
                }
            }
            for (int i = 1; i < 17; i++)
            {
                if (i < 10)
                {
                    blueNums[i - 1] = "0" + i;
                }
                else
                {
                    blueNums[i - 1] = "" + i;
                }
            }
        }
        /// <summary>
        /// 随机生成号码
        /// </summary>
        private void CreateRandomNum()
        {
            try
            {
                string tmp;
                foreach (Control item in this.Controls)
                {
                    if (item is Label)
                    {
                        if (item.Name == "label7")
                        {
                            listtask.Add(Task.Run(() =>
                            {
                                while (flag)
                                {
                                    tmp = blueNums[GetRandomNumberTherad(0, 16)];
                                    item.Text = tmp;
                                }
                            }));
                        }
                        else
                        {
                            listtask.Add(Task.Run(()=> {
                                while (flag)
                                {
                                    tmp = redNums[GetRandomNumberTherad(0, 33)];
                                    lock (objlock)
                                    {
                                        List <string> list= GetLabRedNum();
                                        if (!list.Contains(tmp))
                                        {
                                            this.Invoke(new Action(()=> {
                                                item.Text = tmp;
                                            }));
                                        }
                                    }
                                }
                            }));
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 红球的集合
        /// </summary>
        /// <returns></returns>
        private List<string> GetLabRedNum()
        {
            List<string> result = new List<string>();
            foreach (Control item in this.Controls)
            {
                if (item is Label && item.Name!= "label7")
                {
                    result.Add(item.Text);
                }
            }
            return result;
        }
        /// <summary>
        /// 休息多少秒，刷新产生新的号码
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private int GetRandomNumberTherad(int min,int max)
        {
            Thread.Sleep(GetRandomNumber(500, 1000));
            return GetRandomNumber(min, max);

        }
        /// <summary>
        /// 随机产生一个号码
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns></returns>
        private int GetRandomNumber(int min,int max)
        {
            string guid = Guid.NewGuid().ToString();
            int seed = DateTime.Now.Millisecond;
            //字符串默认，就是字符数组
            for (int i = 0; i < guid.Length; i++)
            {
                switch (guid[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                        seed = seed + 1;
                        break;
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                        seed = seed + 2;
                        break;
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                        seed = seed + 3;
                        break;
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        seed = seed + 4;
                        break;
                    default:
                        break;
                }
            }
            //由于guid字符串不同，最终的seed被多次循环添加后，数字肯定也不同
            Random random = new Random(seed);
            return random.Next(min, max);
        }
    }
}
