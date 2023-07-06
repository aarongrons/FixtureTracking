using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_3
{
    public class Barcode
    {
        public string partNum { get; set; }
        public string blueLight { get; set; }

        public Barcode()
        {
            this.partNum = "0";
            this.blueLight = "";
        }
        public Barcode(string part, string bl)
        {
            partNum = part;
            blueLight = bl;
        }
        public Barcode(int part, string bl)
        {
            partNum = part.ToString();
            blueLight = bl;

 
        }
    }
}
