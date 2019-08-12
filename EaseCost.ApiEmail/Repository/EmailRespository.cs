using EaseCost.ApiEmail.Data;
using EaseCost.ApiEmail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EaseCost.ApiEmail.Repository
{
    public class EmailRespository
    {
        private ECcontext _ECcontext;

        public EmailRespository(ECcontext toECcontext)
        {
            _ECcontext = toECcontext;
        }


        public bool AddEmail(string toEmail)
        {
            try
            {
                var loEmail = new Email { Id = Guid.NewGuid(), email = toEmail };
                _ECcontext.emails.Add(loEmail);
                _ECcontext.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
