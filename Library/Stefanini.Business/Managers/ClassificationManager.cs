using System;
using System.Collections.Generic;

using Stefanini.Data;
using Stefanini.Domain.Entities;
using Stefanini.Domain.Views;
using Stefanini.Domain.QueryParameter;

namespace Stefanini.Business
{
    public class ClassificationManager : BusinessManager
    {

        #region Constructor and DataManager

        public ClassificationManager()
        {
        }

        public StefaniniDataManager StefaniniDataManager = null;

        #endregion

        #region List

        public List<Classification> List()
        {
            return StefaniniDataManager.ClassificationDataManager.List();
        }

        #endregion

    }
}


