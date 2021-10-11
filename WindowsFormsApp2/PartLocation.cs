using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
   public class PartLocation//部件坐标类
    {
        public string Type { get; set; }//类型---移液器或旋转电爪
        public string Name { get; set; }//部件名称
        public int Pid { get; set; }//部件编号
        public int X { get; set; }//X坐标
        public int Y { get; set; }//Y坐标
        public int Z { get; set; }//Z坐标
    }
}
