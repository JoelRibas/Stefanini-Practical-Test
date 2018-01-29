using System;
using System.Collections.Generic;

using Stefanini.Data;
using Stefanini.Domain.Entities;
using Stefanini.Domain.Views;
using Stefanini.Domain.QueryParameter;

namespace Stefanini.Business
{
    public class CustomerManager : BusinessManager
    {

        #region Constructor and DataManager

        public CustomerManager()
        {
        }

        public StefaniniDataManager StefaniniDataManager = null;

        #endregion

        #region CRUD Operations

        public Customer Create(Customer customer)
        {
            try
            {
                this.ResetStatus(true);
                this.StefaniniDataManager.CustomerDataManager.Create(customer);
                return customer;
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
                return null;
            }
        }

        public Customer Read(int id)
        {
            try
            {
                this.ResetStatus(true);
                return this.StefaniniDataManager.CustomerDataManager.Read(id);
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
                return null;
            }
        }

        public void Update(Customer customer)
        {
            try
            {
                this.ResetStatus(true);
                this.StefaniniDataManager.CustomerDataManager.Update(customer);
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
            }
        }

        public void Delete(Customer customer)
        {
            try
            {
                this.ResetStatus(true);
                this.StefaniniDataManager.CustomerDataManager.Delete(customer);
            }
            catch (Exception ex)
            {
                this.ResetStatus(false);
                this.Status.Exception = ex;
            }
        }

        #endregion

        public List<View_Customer> List(CustomerQueryParameter parameter, int skipN, int takeN)
        {
            return StefaniniDataManager.CustomerDataManager.List(parameter, skipN, takeN);
        }


    }
}

