using System;
using System.Collections.Generic;
using System.Linq;

using Stefanini.Domain.Entities;

namespace Stefanini.Data
{
    public class RegionDataManager
    {

        #region Constructors and Context Reference

        public readonly StefaniniContext Context;
        public RegionDataManager(StefaniniContext context)
        {
            this.Context = context;
        }

        #endregion

        #region List

        public List<Region> List()
        {
            IQueryable<Region> found = Context.Region;
            return found.ToList();
        }

        #endregion

    }
}
