using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FrekvensValidator : Validator
    {
        public static Boolean FrekvensValidation(string Input)
        {
            switch (Input)
            {
                case "Var 5:e minut":
                    return true;
                case "Var 10:e minut":
                    return true;
                case "Var 15:e minut":
                    return true;
                case "Var 20:e minut":
                    return true;
                default:
                    return false;

            }




        }
    }
}
