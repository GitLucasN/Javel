using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Validator
    {
        public virtual Boolean NullCheck(string Input)
        {
            if (Input == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
