using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CheckPassword
{
    public class ChkPswrd
    {
        public int CheckPswrd(string pswrd)
        {
            int balls = 0;

            if (Regex.IsMatch(pswrd, @"\d"))
            {
                balls++;
            }

            if (Regex.IsMatch(pswrd, "[a-z]"))
            {
                balls++;
            }
                
            if (Regex.IsMatch(pswrd, "[A-Z]"))
            {
                balls++;
            }

            if (Regex.IsMatch(pswrd, @"[!@#\$%\^&\*\(\)_\+\-=\[\]\{\};':""\\|,.<>\/?]"))
            {
                balls++;
            }

            if (pswrd.Length > 10)
            {
                balls++;
            }

            return balls;
        }
    }
}
