using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort serial;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial = new SerialPort();
            serial.BaudRate = Convert.ToInt32(txt_BaudRate.Text);
            serial.PortName = txt_PortName.Text;
            serial.DataBits = 8;
            serial.Parity = Parity.None;
            serial.StopBits = StopBits.One;
            Initi();
        }

        Byte[] m_receivedData = new Byte[4096];//接收指令数组
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Initi()
        {
            if (JiaZhuaIniti())
            {
                Thread.Sleep(50);
                if (XuanZhuanIniti2())
                {
                    //Thread.Sleep(3500);
                    //FuWei();
                    textBox1.Text = "初始化完成";
                }
            }
            else
            {
                textBox1.Text = "初始化失败";
            }
        }
        private void btn_XuanZhuan_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 50 50 01 68 01 01 8D 77
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x01,0x68, 0x50,0x50,0x01,0x68, 0x01,0x01, 0x8D, 0x77 };
            if (!serial.IsOpen)
                serial.Open();
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            serial.Read(m_receivedData, 0, serial.BytesToRead);
            serial.Close();
            //09 10 03 EC 00 04 01 33
            if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10 && m_receivedData[2] == 0x03 && m_receivedData[3] == 0xEC
            && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x04 && m_receivedData[6] == 0x01
            && m_receivedData[7] == 0x33)
            {
                Thread.Sleep(80);
                textBox1.Text = "复位完成";
            }
            else
            {
                textBox1.Text = "复位失败";
            }
        }
        private void FuWei()
        {
            //09 10 03 EC 00 04 08 02 D0 64 64 02 D0 01 02 80 B9
            //09 10 03 EC 00 04 08 01 68 50 50 01 68 01 02 CD 76

            //09 10 03 EC 00 04 08 01 68 50 50 01 68 01 01 8D 77
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x02,0xD0, 0x64,0x64,0x02,0xD0, 0x01,0x02, 0x80, 0xB9 };
            if (!serial.IsOpen)
                serial.Open();
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            serial.Read(m_receivedData, 0, serial.BytesToRead);
            serial.Close();
            //09 10 03 EC 00 04 01 33
            if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10 && m_receivedData[2] == 0x03 && m_receivedData[3] == 0xEC
            && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x04 && m_receivedData[6] == 0x01
            && m_receivedData[7] == 0x33)
            {
                Thread.Sleep(80);
                textBox1.Text = "复位完成";
            }
            else
            {
                textBox1.Text = "复位失败";
            }
        }

        /// <summary>
        /// 电爪初始化
        /// </summary>
        /// <returns>成功返回：ture失败返回：false</returns>
        private bool JiaZhuaIniti()
        {
            if (!serial.IsOpen)
                serial.Open();
            //09 10 03 E8 00 01 02 00 00 E5 B8
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xE8,0x00, 0x01, 0x02,
                0x00,0x00, 0xE5, 0xB8 };
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            //09 10 03 E8 00 01 02 00 01 24 78
            send_Data[8] = 0x01;
            send_Data[9] = 0x24;  //校验和高字节
            send_Data[10] = 0x78; //校验和低字节
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            serial.Read(m_receivedData, 0, serial.BytesToRead);
            serial.Close();
            //09 10 03 E8 00 01 80 F1
            if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10
                && m_receivedData[2] == 0x03 && m_receivedData[3] == 0xE8
                && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x01
                && m_receivedData[6] == 0x80 && m_receivedData[7] == 0xF1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 初始化旋转
        /// </summary>
        /// <returns>成功返回：ture失败返回：false</returns>
        private bool XuanZhuanIniti()
        {
            if (!serial.IsOpen)
                serial.Open();
            //09 10 03 E9 00 01 02 00 00 E4 69
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xE9,0x00, 0x01, 0x02,
                0x00,0x00, 0xE4, 0x69 };
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            //09 10 03 E9 00 01 02 00 01 25 A9
            send_Data[8] = 0x01;
            send_Data[9] = 0x25;
            send_Data[10] = 0xA9;
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            serial.Read(m_receivedData, 0, serial.BytesToRead);
            serial.Close();
            //09 10 03 E9 00 01 D1 31
            if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10
                && m_receivedData[2] == 0x03 && m_receivedData[3] == 0xE9
                && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x01
                && m_receivedData[6] == 0xD1 && m_receivedData[7] == 0x31)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool XuanZhuanIniti2()
        {
            if (!serial.IsOpen)
                serial.Open();
            //09 10 03 E9 00 01 02 00 00 E4 69
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xE9,0x00, 0x01, 0x02,
                0x00,0x00, 0xE4, 0x69 };
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            //09 10 03 E9 00 01 02 00 03 A4 68
            send_Data[8] = 0x03;
            send_Data[9] = 0xA4;
            send_Data[10] = 0x68;
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            serial.Read(m_receivedData, 0, serial.BytesToRead);
            serial.Close();
            //09 10 03 E9 00 01 D1 31
            if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10
                && m_receivedData[2] == 0x03 && m_receivedData[3] == 0xE9
                && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x01
                && m_receivedData[6] == 0xD1 && m_receivedData[7] == 0x31)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //开盖4速度10
        private void button7_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 0A 0A 01 68 01 01 D9 80
            byte[] arr = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x01,0x68, 0x0A,0x0A,0x01,0x68, 0x01,0x01, 0xD9, 0x80 };
            string strtmp = "";
            XuanZhuan(arr, ref strtmp);
            textBox1.Text = strtmp;
        }
        //拧盖4速度10
        private void button8_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 0A 0A 01 68 01 02 99 81
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x01,0x68, 0x0A,0x0A,0x01,0x68, 0x01,0x02, 0x99, 0x81 };
            string strtmp = "";
            XuanZhuan(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }

        //开盖1速度20
        private void btn_XuanZ3_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 14 14 01 68 01 01 72 3C
            byte[] arr = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x01,0x68, 0x14,0x14,0x01,0x68, 0x01,0x01, 0x72, 0x3C };
            string strtmp = "";
            XuanZhuan(arr, ref strtmp);
            textBox1.Text = strtmp;
        }
        //拧盖1速度20(720度)
        private void button2_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 14 14 01 68 01 02 32 3D
            //byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
            //    0x01,0x68, 0x14,0x14,0x01,0x68, 0x01,0x02, 0x32, 0x3D };
            //09 10 03 EC 00 04 08 02 D0 14 14 02 D0 01 02 CA 42
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
               0x02, 0xD0, 0x14,0x14,0x02,0xD0, 0x01,0x02, 0xCA, 0x42 };
            string strtmp = "";
            XuanZhuan(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //开盖2速度60
        private void button3_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 3C 3C 01 68 01 01 14 12 
            byte[] arr = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x01,0x68, 0x3C,0x3C,0x01,0x68, 0x01,0x01, 0x14, 0x12 };
            string strtmp = "";
            XuanZhuan(arr, ref strtmp);
            textBox1.Text = strtmp;
        }
        //拧盖2速度60
        private void button4_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 3C 3C 01 68 01 02 54 13 
            //byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
            //    0x01,0x68, 0x3C,0x3C,0x01,0x68, 0x01,0x02, 0x54, 0x13 };
            //09 10 03 EC 00 04 08 02 1C 3C 3C 02 1C 01 02 60 5F 
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x02,0x1C, 0x3C,0x3C,0x02,0x1C, 0x01,0x02, 0x60, 0x5F };
            string strtmp = "";
            XuanZhuan(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //开盖3速度100
        private void button5_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 64 64 01 68 01 01 38 C7
            byte[] arr = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x01,0x68, 0x64,0x64,0x01,0x68, 0x01,0x01, 0x38, 0xC7 };
            string strtmp = "";
            XuanZhuan(arr, ref strtmp);
            textBox1.Text = strtmp;
        }
        //拧盖3速度100
        private void button6_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 00 B4 64 64 00 B4 01 02 64 C1===180°
            //09 10 03 EC 00 04 08 02 1C 64 64 02 1C 01 02 4C 8A===540°
            //09 10 03 EC 00 04 08 02 D0 64 64 02 D0 01 02 80 B9===720°
            //09 10 03 EC 00 04 08 01 68 64 64 01 68 01 02 78 C6
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
               0x00, 0xB4, 0x64,0x64,0x00,0xB4, 0x01,0x02, 0x64, 0xC1 };
            string strtmp = "";
            XuanZhuan(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }

        public bool XuanZhuan(byte[] arr, ref string strerr)
        {
            bool rt = false;
            try
            {
                if (serial.IsOpen)
                {
                    serial.Close();
                }
                serial.Open();
                serial.Write(arr, 0, arr.Length);
                Thread.Sleep(100);
                serial.Read(m_receivedData, 0, serial.BytesToRead);
                serial.Close();
                //09 10 03 EC 00 04 01 33
                if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10 && m_receivedData[2] == 0x03 && m_receivedData[3] == 0xEC
                && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x04 && m_receivedData[6] == 0x01
                && m_receivedData[7] == 0x33)
                {
                    Thread.Sleep(50);
                    strerr = "旋转完成";
                    rt = true;
                }
                else
                {
                    strerr = "旋转失败";
                }
            }
            catch (Exception ex)
            {
                strerr = ex.Message;
            }
            return rt;

        }

        //夹爪打开速度10
        private void btn_OpenJiaZ1_Click(object sender, EventArgs e)
        {
            //09 10 03 EA 00 02 04 0A 7F 0A 01 B6 68
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x0A,0x7F, 0x0A,0x01, 0xB6, 0x68 };
            string strtmp = "";
            JiaZhua(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //夹爪关闭速度10
        private void btn_CloseJiazhua_Click(object sender, EventArgs e)
        {
            //09 10 03 EA 00 02 04 0A FF 0A 01 B7 80
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x0A,0xFF, 0x0A,0x01, 0xB7, 0x80 };
            string strtmp = "";
            JiaZhua(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //夹爪打开速度20
        private void button10_Click(object sender, EventArgs e)
        {
            //09 10 03 EA 00 02 04 14 7F 14 01 B9 E0
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x14,0x7F, 0x14,0x01, 0xB9, 0xE0 };
            string strtmp = "";
            JiaZhua(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //夹爪关闭速度20
        private void button9_Click(object sender, EventArgs e)
        {
            //09 10 03 EA 00 02 04 14 FF 14 01 B8 08
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x14,0xFF, 0x14,0x01, 0xB8, 0x08 };
            string strtmp = "";
            JiaZhua(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //夹爪打开速度60
        private void button12_Click(object sender, EventArgs e)
        {
            //09 10 03 EA 00 02 04 3C 7F 3C 01 AE 40
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x3C,0x7F, 0x3C,0x01, 0xAE, 0x40 };
            string strtmp = "";
            JiaZhua(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //夹爪关闭速度60
        private void button11_Click(object sender, EventArgs e)
        {
            //09 10 03 EA 00 02 04 3C FF 3C 01 AF A8
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x3C,0xFF, 0x3C,0x01, 0xAF, 0xA8 };
            string strtmp = "";
            JiaZhua(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //夹爪打开速度100
        private void button14_Click(object sender, EventArgs e)
        {
            //09 10 03 EA 00 02 04 64 7F 64 01 86 E0
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x64,0x7F, 0x64,0x01, 0x86, 0xE0 };
            string strtmp = "";
            JiaZhua(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        //夹爪关闭速度100
        private void button13_Click(object sender, EventArgs e)
        {
            //09 10 03 EA 00 02 04 64 FF 64 01 87 08
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x64,0xFF, 0x64,0x01, 0x87, 0x08 };
            string strtmp = "";
            JiaZhua(send_Data, ref strtmp);
            textBox1.Text = strtmp;
        }
        public bool JiaZhua(byte[] arr, ref string strerr)
        {
            bool rt = false;
            try
            {
                if (serial.IsOpen)
                {
                    serial.Close();
                }
                serial.Open();
                serial.Write(arr, 0, arr.Length);
                Thread.Sleep(100);
                serial.Read(m_receivedData, 0, serial.BytesToRead);
                serial.Close();
                //09 10 03 EA 00 02 61 30
                if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10
                    && m_receivedData[2] == 0x03 && m_receivedData[3] == 0xEA
                    && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x02
                    && m_receivedData[6] == 0x61 && m_receivedData[7] == 0x30)
                {
                    Thread.Sleep(50);
                    strerr = "夹爪完成";
                    rt = true;
                }
                else
                {
                    strerr = "夹爪失败";
                }
            }
            catch (Exception ex)
            {
                strerr = ex.Message;
            }
            return rt;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x02,0x1C, 0x3C,0x3C,0x02,0x1C, 0x01,0x02, 0x60, 0x5F };
            byte[] arr = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x02,0x1C, 0x3C,0x3C,0x02,0x1C, 0x01,0x02};

            byte[] send_Data1 = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x3C,0x7F, 0x3C,0x01, 0xAE, 0x40 };
            byte[] send_Data2 = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x3C,0x7F, 0x3C,0x01 };


            int a = Convert.ToInt32(textBox2.Text);
            var y = a & 0xFF;
            var y2 = (a - y) >> 8;
            //textBox2.Text = y.ToString() + "@@" + y2.ToString();
            //send_Data[0] = Convert.ToByte(y);

            string sss = NegativeToHexString(a);//01,E4

            byte[] res = CRC16LH(send_Data2);
        }
        /// <summary>
        /// CRC校验
        /// </summary>
        /// <param name="pDataBytes">需要校验的指令</param>
        /// <returns>返回检验完成的指令</returns>
        private byte[] CRC16LH(byte[] pDataBytes)
        {
            ushort crc = 0xffff;
            ushort polynom = 0xA001;
            for (int i = 0; i < pDataBytes.Length; i++)
            {
                crc ^= pDataBytes[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) == 0x01)
                    {
                        crc >>= 1;
                        crc ^= polynom;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            byte[] result = BitConverter.GetBytes(crc);
            List<byte> s = pDataBytes.ToList();
            s.Add(result[0]);
            s.Add(result[1]);
            return s.ToArray();
        }

        static byte[] CRC16HL(byte[] pDataBytes)
        {
            ushort crc = 0xffff;
            ushort polynom = 0xA001;

            for (int i = 0; i < pDataBytes.Length; i++)
            {
                crc ^= pDataBytes[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) == 0x01)
                    {
                        crc >>= 1;
                        crc ^= polynom;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            byte[] result = BitConverter.GetBytes(crc).Reverse().ToArray();
            return result;
        }

        #region 旋转
        //09 10 03 EC 00 04 08 01 68 0A 0A 01 68 01 02 99 81

        //09 10 03 EC 00 04 08 01 68 0A 0A 01 68 01 01 D9 80


        //09 10 03 EC 00 04 08 02 D0 14 14 02 D0 01 02 CA 42

        //09 10 03 EC 00 04 08 01 68 14 14 01 68 01 01 72 3C


        //09 10 03 EC 00 04 08 02 1C 3C 3C 02 1C 01 02 60 5F 


        #endregion
        #region 夹爪
        //09 10 03 EA 00 02 04 0A 7F 0A 01 B6 68
        byte[] send_Data1 = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x0A,0x7F, 0x0A,0x01, 0xB6, 0x68 };
        //09 10 03 EA 00 02 04 0A FF 0A 01 B7 80
        byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x0A,0xFF, 0x0A,0x01, 0xB7, 0x80 };

        //09 10 03 EA 00 02 04 64 7F 64 01 86 E0
        byte[] send_Data2 = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0x64,0x7F, 0x64,0x01, 0x86, 0xE0 };

        #endregion
        Byte[] x_SendData = new Byte[15];//旋转发送指令数组
        Byte[] j_SendData = new Byte[11];//夹爪发送指令数组
        Byte[] receivedData = new Byte[4096];//接收指令数组
        private void btn_X_Click(object sender, EventArgs e)
        {
            string ss = "";
            //09 10 03 EC 00 04 08 01 68 64 64 01 68 01 02 78 C6
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
               0x00, 0xB4, 0x64,0x64,0x00,0xB4, 0x01,0x02, 0x64, 0xC1 };
            byte[] nn = XuanZhuan11(txt_XDegrees.Text, txt_XSpeed.Text, Convert.ToInt32(btn_X.Tag));
            XuanZhuan(nn, ref ss);
        }

        private void btn_FX_Click(object sender, EventArgs e)
        {
            //09 10 03 EC 00 04 08 01 68 64 64 01 68 01 01 38 C7
            byte[] arr = { 0x09, 0x10, 0x03, 0xEC, 0x00, 0x04, 0x08,
                0x01,0x68, 0x64,0x64,0x01,0x68, 0x01,0x01, 0x38, 0xC7 };
            string strtmp = "";
            byte[] nn = XuanZhuan11(txt_XDegrees.Text, txt_XSpeed.Text, Convert.ToInt32(btn_FX.Tag));
            XuanZhuan(nn, ref strtmp);
        }
        byte[] XuanZhuan11(string deg, string speed, int flag)
        {
            byte[] degs = Degrees(deg);
            x_SendData[0] = 0x09;
            x_SendData[1] = 0x10;
            x_SendData[2] = 0x03;
            x_SendData[3] = 0xEC;
            x_SendData[4] = 0x00;
            x_SendData[5] = 0x04;
            x_SendData[6] = 0x08;
            x_SendData[7] = degs[0];
            x_SendData[8] = degs[1];
            x_SendData[9] = Convert.ToByte(Speed(speed));
            x_SendData[10] = x_SendData[9];
            x_SendData[11] = x_SendData[7];
            x_SendData[12] = x_SendData[8];
            x_SendData[13] = 0x01;
            switch (flag)
            {
                case 1:
                    x_SendData[14] = 0x01;
                    break;
                case 2:
                    x_SendData[14] = 0x02;
                    break;
            }
            return CRC16LH(x_SendData);
        }
        byte[] JiaZhua11(string speed, string loc, int flag)
        {
            //全速全力关闭夹爪
            //09 10 03 EA 00 02 04 FF FF FF 01 C3 1C
            //全速全力打开夹爪
            //09 10 03 EA 00 02 04 FF 00 FF 01 F3 2C
            j_SendData[0] = 0x09;
            j_SendData[1] = 0x10;
            j_SendData[2] = 0x03;
            j_SendData[3] = 0xEA;
            j_SendData[4] = 0x00;
            j_SendData[5] = 0x02;
            j_SendData[6] = 0x04;
            j_SendData[7] = Convert.ToByte(Speed(speed));
            switch (flag)
            {
                case 1:
                    j_SendData[8] = Convert.ToByte(Speed(loc));
                    break;
                case 2:
                    j_SendData[8] = 0xFF;
                    break;
            }
            j_SendData[9] = j_SendData[7];
            j_SendData[10] = 0x01;
            return CRC16LH(j_SendData);
        }
        int Speed(string speed)
        {
            int num = Convert.ToInt32(speed);
            int res = num & 0xFF;
            return res;
        }
        byte[] Degrees(string deg)
        {
            byte[] res = new byte[2];
            int num = Convert.ToInt32(deg);
            int a1 = num & 0xFF;
            var a2 = (num - a1) >> 8;
            res[0] = Convert.ToByte(a2);
            res[1] = Convert.ToByte(a1);
            return res;
        }
        private void btn_Open_Click(object sender, EventArgs e)
        {
            //全速全力打开夹爪
            //09 10 03 EA 00 02 04 FF 00 FF 01 F3 2C
            string strres = "";
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0xFF,0x00, 0xFF,0x01, 0xF3, 0x2C };
            byte[] send_Data1 = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0xFF,0x00, 0xFF,0x01 };
            byte[] res = JiaZhua11(txt_JSpeed.Text, txt_Loc.Text, Convert.ToInt32(btn_Open.Tag));
            jiaZhua2(res, ref strres);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //全速全力关闭夹爪
            //09 10 03 EA 00 02 04 FF FF FF 01 C3 1C
            string strres = "";
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0xFF,0xFF, 0xFF,0x01, 0xC3, 0x1C };
            byte[] send_Data1 = { 0x09, 0x10, 0x03, 0xEA, 0x00, 0x02, 0x04,
                0xFF,0xFF, 0xFF,0x01 };

            byte[] res = JiaZhua11(txt_JSpeed.Text, txt_Loc.Text, Convert.ToInt32(btn_Close.Tag));
            jiaZhua2(res, ref strres);
        }
        private bool jiaZhua2(byte[] arr, ref string strerr)
        {
            bool rt = false;
            try
            {
                if (serial.IsOpen)
                {
                    serial.Close();
                }
                serial.Open();
                serial.Write(arr, 0, arr.Length);
                Thread.Sleep(100);
                serial.Read(m_receivedData, 0, serial.BytesToRead);
                serial.Close();
                //09 10 03 EA 00 02 61 30
                if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10
                    && m_receivedData[2] == 0x03 && m_receivedData[3] == 0xEA
                    && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x02
                    && m_receivedData[6] == 0x61 && m_receivedData[7] == 0x30)
                {
                    Thread.Sleep(50);
                    strerr = "夹爪完成";
                    rt = true;
                }
                else
                {
                    strerr = "夹爪失败";
                }
            }
            catch (Exception ex)
            {
                strerr = ex.Message;
            }
            return rt;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //09 10 03 E9 00 01 02 08 0B A7 6E---逆时针360
            //09 10 03 E9 00 01 02 09 0B A3 FE
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xE9, 0x00, 0x01, 0x02,
                0x09,0x0B, 0xA3, 0xFE };
            if (!serial.IsOpen)
                serial.Open();
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            serial.Read(m_receivedData, 0, serial.BytesToRead);
            serial.Close();
            //09 10 03 E9 00 01 D1 31
            if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10 && m_receivedData[2] == 0x03
                && m_receivedData[3] == 0xE9 && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x01
                && m_receivedData[6] == 0xD1 && m_receivedData[7] == 0x31)
            {
                Thread.Sleep(80);
                textBox1.Text = "复位完成";
            }
            else
            {
                textBox1.Text = "复位失败";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            byte[] send_Data = { 0x09, 0x10, 0x03, 0xE9, 0x00, 0x01, 0x02,
                0x08,0x0B, 0xA2, 0x6E };
            if (!serial.IsOpen)
                serial.Open();
            serial.Write(send_Data, 0, send_Data.Length);
            Thread.Sleep(100);
            serial.Read(m_receivedData, 0, serial.BytesToRead);
            serial.Close();
            //09 10 03 E9 00 01 D1 31
            if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10 && m_receivedData[2] == 0x03
                && m_receivedData[3] == 0xE9 && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x01
                && m_receivedData[6] == 0xD1 && m_receivedData[7] == 0x31)
            {
                Thread.Sleep(80);
                textBox1.Text = "复位完成";
            }
            else
            {
                textBox1.Text = "复位失败";
            }
        }
        private byte[] Zssd(short i)
        {
            return BitConverter.GetBytes(i);
        }
        private int MyAbs(int num)
        {
            return -num;
        }
        private void btn_Setaa_Click(object sender, EventArgs e)
        {
            //09 10 04 00 00 10 20 xx xx ss ss xx xx ss ss CRC1 CRC2
            short a = Convert.ToInt16(txt_sLocaa.Text); 
            short b = Convert.ToInt16(MyAbs(Convert.ToInt16(txt_nLocaa.Text)));
            
            byte[] send_Data = new byte[15];
            send_Data[0] = 0x09;
            send_Data[1] = 0x10;
            send_Data[2] = 0x04;
            send_Data[3] = 0x00;
            send_Data[4] = 0x00;
            send_Data[5] = 0x10;
            send_Data[6] = 0x20;
            //顺时针参数
            send_Data[7] = Zssd(a)[1];//度数
            send_Data[8] = Zssd(a)[0];//度数
            send_Data[9] = Convert.ToByte(SpeedOrPower(txt_sSpeedaa.Text));//速度
            send_Data[10] = send_Data[9];//力度
            //逆时针参数
            send_Data[11] = Zssd(b)[1];
            send_Data[12] = Zssd(b)[0];
            send_Data[13] = Convert.ToByte(SpeedOrPower(txt_nSpeedaa.Text));//速度
            send_Data[14] = send_Data[13];//力度
            byte[] arr = CRC16LH(send_Data);//CRC校验之后的结果
            if (!serial.IsOpen)
                serial.Open();
            serial.Write(arr, 0, arr.Length);
            Thread.Sleep(200);
            serial.Read(m_receivedData, 0, serial.BytesToRead);
            serial.Close();
            //09 10 04 00 00 10 C1 BD
            if (m_receivedData[0] == 0x09 && m_receivedData[1] == 0x10 && m_receivedData[2] == 0x04
                && m_receivedData[3] == 0x00 && m_receivedData[4] == 0x00 && m_receivedData[5] == 0x10
                && m_receivedData[6] == 0xC1 && m_receivedData[7] == 0xBD)
            {
                Thread.Sleep(80);
                textBox1.Text = "设置完成";
            }
            else
            {
                textBox1.Text = "设置失败";
            }

        }
        int SpeedOrPower(string num)
        {
            int set = Convert.ToInt32(num);
            int res = set & 0xFF;
            return res;
        }

        private string NegativeToHexString(int iNumber)
        {
            string strResult = string.Empty;

            if (iNumber < 0)
            {
                iNumber = -iNumber;

                string strNegate = string.Empty;

                char[] binChar = Convert.ToString(iNumber, 2).PadLeft(8, '0').ToArray();

                foreach (char ch in binChar)
                {
                    if (Convert.ToInt32(ch) == 48)
                    {
                        strNegate += "1";
                    }
                    else
                    {
                        strNegate += "0";
                    }
                }

                int iComplement = Convert.ToInt32(strNegate, 2) + 1;

                strResult = Convert.ToString(iComplement, 16).ToUpper();
            }

            return strResult;
        }
    }
}
