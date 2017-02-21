using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Data;

namespace BusinessLogic
{
    public class bl_Menu
    {
        public bool InserMenu(MenuItem _objMenuData)
        {
            try
            {
                da_Menu _objdaMenu = new da_Menu();

                return _objdaMenu.InsertMenu(_objMenuData);
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public List<MenuItem> ReadMenu(string UserName, string RoleId)
        {
            try
            {
                da_Menu _objdaMenu = new da_Menu();

                List<MenuItem> _lstMenuData = new List<MenuItem>();

                _lstMenuData = _objdaMenu.ReadMenu(UserName, RoleId);

               return _lstMenuData;
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
    }
}
