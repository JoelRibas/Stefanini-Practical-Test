using System;
using System.Collections.Generic;
using System.Linq;

using Stefanini.Domain.Entities;

namespace Stefanini.Data
{
    public class UserSysDataManager
    {

        #region Constructors and Context Reference

        public readonly StefaniniContext Context;
        public UserSysDataManager(StefaniniContext context)
        {
            this.Context = context;
        }

        #endregion

        #region CRUD Operations

        public UserSys Create(UserSys user)
        {
            this.Context.UserSys.Add(user);
            this.Context.SaveChanges();
            return user;
        }

        public UserSys Read(int id)
        {
            UserSys result = null;
            var query =
                from user in this.Context.UserSys
                where user.Id == id
                select user;
            if (query.Count() > 0)
            {
                result = query.First();
            }
            return result;
        }

        public UserSys Read(string userName)
        {
            UserSys result = null;
            var query =
                from user in this.Context.UserSys
                where user.Email == userName
                select user;

            if (query.Count() > 0)
            {
                result = query.First();
            }
            return result;
        }

        public void Update(UserSys user)
        {
            this.Context.SaveChanges();
        }

        public void Delete(UserSys user)
        {
            this.Context.UserSys.Remove(user);
            this.Context.SaveChanges();
        }

        #endregion

    }
}
