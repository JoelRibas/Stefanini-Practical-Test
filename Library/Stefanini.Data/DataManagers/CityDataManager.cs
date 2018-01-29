using System;
using System.Collections.Generic;
using System.Linq;

using Stefanini.Domain.Entities;

namespace Stefanini.Data
{
    public class CityDataManager
    {

        #region Constructors and Context Reference

        public readonly StefaniniContext Context;
        public CityDataManager(StefaniniContext context)
        {
            this.Context = context;
        }

        #endregion

        #region List

        public List<City> List()
        {
            IQueryable<City> found = Context.City;
            return found.ToList();
        }

        #endregion

    }
}
