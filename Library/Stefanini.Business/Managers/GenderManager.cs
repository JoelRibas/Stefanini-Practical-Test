using System;
using System.Collections.Generic;

using Stefanini.Data;
using Stefanini.Domain.Entities;
using Stefanini.Domain.Views;
using Stefanini.Domain.QueryParameter;

namespace Stefanini.Business
{
    public class GenderManager : BusinessManager
    {

        #region Constructor and DataManager

        public GenderManager()
        {
        }

        public StefaniniDataManager StefaniniDataManager = null;

        #endregion

        #region List

        public List<Gender> List()
        {
            return StefaniniDataManager.GenderDataManager.List();
        }

        #endregion

    }
}


