using System;
using System.Collections.Generic;

using Stefanini.Data;
using Stefanini.Domain.Entities;
using Stefanini.Domain.Views;
using Stefanini.Domain.QueryParameter;

namespace Stefanini.Business
{
    public class CityManager : BusinessManager
    {

        #region Constructor and DataManager

        public CityManager()
        {
        }

        public StefaniniDataManager StefaniniDataManager = null;

        #endregion

        #region List

        public List<City> List()
        {
            return StefaniniDataManager.CityDataManager.List();
        }

        #endregion

    }
}


