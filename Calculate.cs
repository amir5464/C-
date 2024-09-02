using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    class Calculate
    {
        private decimal surfaceArea;
        private decimal volume;
        private decimal circumference;
        private string calculation;
        public string thiscalculation
        {
            get
            {
                return this.calculation;
            }
            set
            {
                this.calculation = value;
            }
        }
        public decimal thissurfaceArea
        {
            get
            {
                return this.surfaceArea;
            }
            set
            {
                this.surfaceArea = value;
            }
        }
        public decimal thisvolume
        {
            get
            {
                return this.volume;
            }
            set
            {
                this.volume = value;
            }
        }
        public decimal thiscircumference
        {
            get
            {
                return this.circumference;
            }
            set
            {
                this.circumference = value;
            }
        }
    }

}
