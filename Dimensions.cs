using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    class Dimensions
    {
        private decimal dimensionX;
        private decimal dimensionY;
        private decimal dimensionZ;
        public decimal thisdimensionX
        {
            get
            {
                return this.dimensionX;
            }
            set
            {
                this.dimensionX = value;
            }
        }
        public decimal thisdimensionY
        {
            get
            {
                return this.dimensionY;
            }
            set
            {
                this.dimensionY = value;
            }
        }
        public decimal thisdimensionZ
        {
            get
            {
                return this.dimensionZ;
            }
            set
            {
                this.dimensionZ = value;
            }
        }
    }
}
