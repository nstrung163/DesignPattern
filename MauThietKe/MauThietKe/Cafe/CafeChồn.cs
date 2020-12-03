using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.Cafe
{
    public class CafeChồn : Cafe, ICloneable
    {
        public override double GetGiá()
        {
            return 5000;
            throw new NotImplementedException();
        }
        public CafeChồn()
        {
            this.MôTả = "Cafe Chồn";
        }
        public object Clone()
        {
            return this.MemberwiseClone();
            throw new NotImplementedException();
        }
    }
}
