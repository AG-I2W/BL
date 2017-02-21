using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Data;

namespace BusinessLogic
{
    public class bl_Portfolio
    {
        public bool InsertPortfolio(Portfolio objPortfolio)
        {
            try
            {
                da_Portfolio _objPortfolio = new da_Portfolio();
                return _objPortfolio.InsertPortfolio(objPortfolio);
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public List<Portfolio> ReadExistingPortfolio()
        {
            try
            {
                da_Portfolio _objPortfolio = new da_Portfolio();

                List<Portfolio> _lstPortfolio = _objPortfolio.ReadPortfolio().FindAll(r => r.IsExists == true);

                return _lstPortfolio;
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public List<Portfolio> ReadCompletePortfolio()
        {
            try
            {
                da_Portfolio _objPortfolio = new da_Portfolio();

                return _objPortfolio.ReadPortfolio();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
    }
}
