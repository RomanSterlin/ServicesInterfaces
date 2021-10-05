﻿using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.Facades
{
    public interface IUserFacade
    {
        Task<UserCredentials> GetUserInfo(string id);
        Task SeenTutorial(Data data);
    }
}
