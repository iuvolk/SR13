using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR13_1
{
    sealed class MultiBuilding:Building
    {
        int floor;

        int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < -100)
                    floor = -100;
                else if (value > 200)
                    floor = 200;
                else
                    floor = value;
            }
        }

        public MultiBuilding(string address, double length, double width, double height, int floor)
            : base(address, length, width, height)
        {
            this.Floor = floor;
        }
        public string Print()
        {
            string result = base.Print();
            result += $", этажность-{floor}";
            return result;
        }
    }
}
