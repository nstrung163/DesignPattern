using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauThietKe.Cafe
{
    public abstract class Cafe 
    {
        protected String MôTả;
        public String GetMôTả()
        {
            return this.MôTả;
        }
        public abstract double GetGiá();
    }
}
