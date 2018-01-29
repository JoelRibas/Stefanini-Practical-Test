using System;
using System.Collections.Generic;
using System.Linq;

using Stefanini.Domain.Entities;

namespace Stefanini.Data
{
    public class SellerDataManager
    {

        #region Constructors and Context Reference

        public readonly StefaniniContext Context;
        public SellerDataManager(StefaniniContext context)
        {
            this.Context = context;
        }

        #endregion

        #region List

        public List<UserSys> List()
        {
            IQueryable<UserSys> found = Context.UserSys;
            return found.ToList();
        }

        #endregion

    }
}
