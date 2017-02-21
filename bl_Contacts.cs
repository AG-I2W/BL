using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DAL;

namespace BusinessLogic
{
    public class bl_Contacts
    {
        public bool InsertContacts(Contacts _objContactsData)
        {
            try
            {
                da_Contacts _objdaContact = new da_Contacts();

                return _objdaContact.InsertContact(_objContactsData);
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public List<Contacts> ReadContacts(string ContactId, string ContactOf)
        {
            try
            {
                da_Contacts _objdaContact = new da_Contacts();

                return _objdaContact.ReadContact(ContactId, ContactOf);
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
    }
}
