using System;
using System.Collections.Generic;
using System.Linq;

using Stefanini.Domain.Entities;

namespace Stefanini.Data
{
    public class GenderDataManager
    {

        #region Constructors and Context Reference

        public readonly StefaniniContext Context;
        public GenderDataManager(StefaniniContext context)
        {
            this.Context = context;
        }

        #endregion

        #region List

        public List<Gender> List()
        {
            IQueryable<Gender> found = Context.Gender;
            return found.ToList();
        }

        #endregion

    }
}
