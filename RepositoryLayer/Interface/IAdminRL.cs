using CommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IAdminRL
    { 
        public bool AdminLogin(LoginModel loginModel);
    }
}
