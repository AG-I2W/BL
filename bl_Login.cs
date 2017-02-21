using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Data;

namespace BusinessLogic
{
    public class bl_Login
    {
        public bool LoginCheck(Login _objLoginData)
        {
            try
            {
                da_Login _objLogin = new da_Login();


                if (_objLogin.LoginCheck(_objLoginData))
                {
                    return true;
                }
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
            return false;            
        }
    }
}
