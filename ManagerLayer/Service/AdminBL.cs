﻿using BussinessLayer.Interface;
using CommonLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Service
{
    public class AdminBL : IAdminBL
    {
        private readonly IAdminRL iAdminRL;

        public AdminBL(IAdminRL iAdminRL)
        {
            this.iAdminRL = iAdminRL;
        }
        public bool AdminLogin(LoginModel loginModel)
        {
            try
            {
                return iAdminRL.AdminLogin(loginModel);
            }
            catch
            {
                throw;
            }
        }

        
    }
}
