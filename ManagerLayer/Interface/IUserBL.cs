﻿using CommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Interface
{
    public interface IUserBL
    {
        public bool Registration(RegisterModel userRegistrationModel);
    }
}
