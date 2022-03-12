using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniess.Services
{
   public interface IUserService
    {
        void Insert(User user);
        bool IsValid(User user);   }
}
