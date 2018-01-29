using System;
using System.Collections.Generic;
using System.Linq;

using Stefanini.Domain.Entities;
using Stefanini.Domain.Views;
using Stefanini.Domain.QueryParameter;

namespace Stefanini.Data
{
    public class CustomerDataManager
    {

        #region Constructors and Context Reference

        public readonly StefaniniContext Context;
        public CustomerDataManager(StefaniniContext context)
        {
            this.Context = context;
        }

        #endregion

        #region CRUD Operations

        public Customer Create(Customer customer)
        {
            this.Context.Customer.Add(customer);
            this.Context.SaveChanges();
            return customer;
        }

        public Customer Read(int id)
        {
            Customer result = null;
            var query =
                from consultor in this.Context.Customer
                where consultor.Id == id
                select consultor;
            if (query.Count() > 0)
            {
                result = query.First();
            }
            return result;
        }

        public void Update(Customer customer)
        {
            this.Context.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            this.Context.Customer.Remove(customer);
            this.Context.SaveChanges();
        }

        #endregion

        #region List

        public List<View_Customer> List(CustomerQueryParameter parameter, int skipN, int takeN)
        {
            IQueryable<View_Customer> found = Context.View_Customer;

            if (!string.IsNullOrEmpty(parameter.Name))
            {
                found = found.Where(customer => customer.Customer.Contains(parameter.Name));
            }
            if (parameter.GenderId.HasValue && parameter.GenderId != int.MaxValue)
            {
                found = found.Where(customer => customer.GenderId == parameter.GenderId);
            }
            if (parameter.CityId.HasValue && parameter.CityId != int.MaxValue)
            {
                found = found.Where(customer => customer.CityId == parameter.CityId);
            }
            if (parameter.RegionId.HasValue && parameter.RegionId != int.MaxValue)
            {
                found = found.Where(customer => customer.RegionId == parameter.RegionId);
            }
            if (parameter.ClassificationId.HasValue && parameter.ClassificationId != int.MaxValue)
            {
                found = found.Where(customer => customer.ClassificationId == parameter.ClassificationId);
            }
            if (parameter.UserId.HasValue && parameter.UserId != int.MaxValue)
            {
                found = found.Where(customer => customer.SellerId == parameter.UserId);
            }

            if (parameter.LastPurchaseStart.HasValue && parameter.LastPurchaseEnd.HasValue)
            {
                found = found.Where(customer => customer.LastPurchase >= parameter.LastPurchaseStart.Value && customer.LastPurchase <= parameter.LastPurchaseEnd.Value);
            }

            return found.ToList();
        }

        #endregion

    }
}
