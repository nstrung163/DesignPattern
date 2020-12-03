using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.Cafe
{
    public class CafePhin : Cafe, ICloneable
    {
        public override double GetGiá()
        {
            return 8000;
            throw new NotImplementedException();
        }
        public CafePhin()
        {
            this.MôTả = "Cafe Phin";
        }
        public object Clone()
        {
            return this.MemberwiseClone();
            throw new NotImplementedException();
        }
    }
}
