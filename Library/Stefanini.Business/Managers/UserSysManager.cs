using System;
using System.Collections.Generic;

using Stefanini.Data;
using Stefanini.Domain.Entities;
using Stefanini.Domain;

namespace Stefanini.Business
{
    public class UserSysManager : BusinessManager
    {

        #region Constructor and DataManager

        public UserSysManager()
        {
        }

        public StefaniniDataManager StefaniniDataManager = null;

        #endregion

        #region CRUD Operations

        public UserSys Create(UserSys customer)
        {
            try
            {
                this.ResetStatus(true);
                this.StefaniniDataManager.UserSysDataManager.Create(customer);
                return customer;
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
                return null;
            }
        }

        public UserSys Read(int id)
        {
            try
            {
                this.ResetStatus(true);
                return this.StefaniniDataManager.UserSysDataManager.Read(id);
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
                return null;
            }
        }
        public UserSys Read(string userName)
        {
            try
            {
                this.ResetStatus(true);
                return this.StefaniniDataManager.UserSysDataManager.Read(userName);
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
                return null;
            }
        }
        public void Update(UserSys customer)
        {
            try
            {
                this.ResetStatus(true);
                this.StefaniniDataManager.UserSysDataManager.Update(customer);
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
            }
        }

        public void Delete(UserSys customer)
        {
            try
            {
                this.ResetStatus(true);
                this.StefaniniDataManager.UserSysDataManager.Delete(customer);
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
            }
        }

        #endregion

    }
}

