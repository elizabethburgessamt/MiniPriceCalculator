using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using MiniPriceCalculator.WebUI.Infrastructure.Abstract;

namespace MiniPriceCalculator.WebUI.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            //this is depreciated due to using static details; find another method
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}