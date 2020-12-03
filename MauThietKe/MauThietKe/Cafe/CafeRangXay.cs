using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.Cafe
{
    public class CafeRangXay : Cafe, ICloneable
    {
        public override double GetGiá()
        {
            return 15000;
            throw new NotImplementedException();
        }

        public CafeRangXay()
        {
            this.MôTả = "Cafe rang xay";
        }
        public object Clone()
        {
            return this.MemberwiseClone();
            throw new NotImplementedException();
        }
    }
}
