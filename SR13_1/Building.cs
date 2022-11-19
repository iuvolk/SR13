using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR13_1
{
    internal class Building
    {
        string address;
        double length;
        double width;
        double height;

        double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                    length = 0.1;
                else
                    length = value;
            }
        }
             double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    width = 0.1;
                else
                    width = value;
            }
        }
        double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = 0.1;
                else
                    height = value;
            }
        }
        public Building(string address, double length, double width, double height)
        {
            this.address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"Адрес:{address}, длина-{length}, ширина-{width},высота-{height}";
        }
    }
    
}
