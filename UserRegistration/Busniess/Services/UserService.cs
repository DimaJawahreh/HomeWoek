using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Busniess.Services
{
  public  class UserService: IUserService
    {
        UserContext context;
        public UserService(UserContext user)
        {
            context = user;
        }

        public void Insert(User user)
        {
            IGenericService<User> generic = new GenericService<User>();
            generic.Insert(user);
        }
     public bool IsValid(User user)
      {
           var user1 = context.users.SingleOrDefault(e => e.Name == user.Name && e.Password == user.Password);
            if(user1 != null)
            {

                return true;
            
            }
            else
            {

                return false;
             }
                 
              }
    }
}
