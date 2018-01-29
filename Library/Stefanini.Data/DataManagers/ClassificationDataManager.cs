using System;
using System.Collections.Generic;
using System.Linq;

using Stefanini.Domain.Entities;

namespace Stefanini.Data
{
    public class ClassificationDataManager
    {

        #region Constructors and Context Reference

        public readonly StefaniniContext Context;
        public ClassificationDataManager(StefaniniContext context)
        {
            this.Context = context;
        }

        #endregion

        #region List

        public List<Classification> List()
        {
            IQueryable<Classification> found = Context.Classification;
            return found.ToList();
        }

        #endregion

    }
}
