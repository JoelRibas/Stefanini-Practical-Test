using System;
using System.Collections.Generic;

using Stefanini.Data;
using Stefanini.Domain.Entities;
using Stefanini.Domain.Views;
using Stefanini.Domain.QueryParameter;

namespace Stefanini.Business
{
    public class SellerManager : BusinessManager
    {

        #region Constructor and DataManager

        public SellerManager()
        {
        }

        public StefaniniDataManager StefaniniDataManager = null;

        #endregion

        #region List

        public List<UserSys> List()
        {
            return StefaniniDataManager.SellerDataManager.List();
        }

        #endregion

    }
}
