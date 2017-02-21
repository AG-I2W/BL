using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DAL;

namespace BusinessLogic
{
    public class bl_SocialLinks
    {

        public bool InsertSocialLinks(SocialLinks objSocialLink)
        {
            try
            {
                da_SocialLinks _objSocialLinks = new da_SocialLinks();
                return _objSocialLinks.InsertSocialLinks(objSocialLink);
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public List<SocialLinks> ReadSocialLinks()
        {
            try
            {
                da_SocialLinks _objSocialLinks = new da_SocialLinks();
                return _objSocialLinks.ReadSocialLinks();
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
    }
}
