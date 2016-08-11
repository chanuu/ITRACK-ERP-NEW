﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace XtraSchedulerEFTest
{
    #region #efresource
   public class EFResource
    {
        [Key]
        public int UniqueID { get; set; }
        public int ResourceID { get; set; }
        public string ResourceName { get; set; }
        public byte[] Image { get; set; }
        public int Color
        {
            get
            {
                return ColorEx.ToArgb();
            }
            set
            {
                ColorEx = new MyColor(value);
            }
        }
        public MyColor ColorEx { get; set; }

    }

  public  class MyColor
    {
        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public MyColor() { }
        public MyColor(byte a, byte r, byte g, byte b) { A = a; R = r; G = g; B = b; }
        public MyColor(Color color) { A = color.A; R = color.R; G = color.G; B = color.B; }
        public MyColor(int argb)
        {
            byte[] bytes = BitConverter.GetBytes(argb);
            A = bytes[0];
            R = bytes[1];
            G = bytes[2];
            B = bytes[3];
        }

        public Color ToColor() { return Color.FromArgb(A, R, G, B); }
        public static MyColor FromColor(Color color) { return new MyColor(color.A, color.R, color.G, color.B); }
        public int ToArgb()
        {
            byte[] bytes = new byte[] { A, R, G, B };
            return BitConverter.ToInt32(bytes, 0);
        }

    }
#endregion #efresource

}
