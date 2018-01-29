using System;
using System.Collections.Generic;

using Stefanini.Data;
using Stefanini.Domain.Entities;
using Stefanini.Domain.Views;
using Stefanini.Domain.QueryParameter;

namespace Stefanini.Business
{
    public class RegionManager : BusinessManager
    {

        #region Constructor and DataManager

        public RegionManager()
        {
        }

        public StefaniniDataManager StefaniniDataManager = null;

        #endregion

        #region List

        public List<Region> List()
        {
            return StefaniniDataManager.RegionDataManager.List();
        }

        #endregion

    }
}


