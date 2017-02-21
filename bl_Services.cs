using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DAL;

namespace BusinessLogic
{
    public class bl_Services
    {
        public bool InsertServices(Services _objServiceData)
        {
            try
            {
                da_Services _objServices = new da_Services();
                
                return _objServices.InsertService(_objServiceData);
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public List<Services> ReadServices()
        {
            try
            {
                da_Services _objServices = new da_Services();

                List<Services> _lstServices = new List<Services>();

                _lstServices = _objServices.ReadServices();

                return _lstServices;
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

    }
}
