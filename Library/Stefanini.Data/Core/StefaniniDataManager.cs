using System;
using System.Data.Common;

using Stefanini.Types;
using Stefanini.Domain.Entities;

namespace Stefanini.Data
{
    public class StefaniniDataManager
    {
        
        #region Constructors and Context

        public StefaniniContext StefaniniContext = null;

        public StefaniniDataManager(DatabaseConnectionSettings settings)
        {
            this.StefaniniContext = StefaniniContext.Create(settings);
        }

        #endregion

        #region Table Data Managers

        #region UserSysDataManager

        private UserSysDataManager userSysDataManager;
        public UserSysDataManager UserSysDataManager
        {
            get
            {
                if (this.userSysDataManager == null)
                {
                    this.userSysDataManager = new UserSysDataManager(this.StefaniniContext);
                }
                return this.userSysDataManager;
            }
        }

        #endregion

        #region CustomerDataManager

        private CustomerDataManager customerDataManager;
        public CustomerDataManager CustomerDataManager
        {
            get
            {
                if (this.customerDataManager == null)
                {
                    this.customerDataManager = new CustomerDataManager(this.StefaniniContext);
                }
                return this.customerDataManager;
            }
        }

        #endregion

        #region GenderDataManager

        private GenderDataManager genderDataManager;
        public GenderDataManager GenderDataManager
        {
            get
            {
                if (this.genderDataManager == null)
                {
                    this.genderDataManager = new GenderDataManager(this.StefaniniContext);
                }
                return this.genderDataManager;
            }
        }

        #endregion

        #region CityDataManager

        private CityDataManager cityDataManager;
        public CityDataManager CityDataManager
        {
            get
            {
                if (this.cityDataManager == null)
                {
                    this.cityDataManager = new CityDataManager(this.StefaniniContext);
                }
                return this.cityDataManager;
            }
        }

        #endregion

        #region RegionDataManager

        private RegionDataManager regionDataManager;
        public RegionDataManager RegionDataManager
        {
            get
            {
                if (this.regionDataManager == null)
                {
                    this.regionDataManager = new RegionDataManager(this.StefaniniContext);
                }
                return this.regionDataManager;
            }
        }

        #endregion

        #region ClassificationDataManager

        private ClassificationDataManager classificationDataManager;
        public ClassificationDataManager ClassificationDataManager
        {
            get
            {
                if (this.classificationDataManager == null)
                {
                    this.classificationDataManager = new ClassificationDataManager(this.StefaniniContext);
                }
                return this.classificationDataManager;
            }
        }

        #endregion

        #region SellerDataManager

        private SellerDataManager sellerDataManager;
        public SellerDataManager SellerDataManager
        {
            get
            {
                if (this.sellerDataManager == null)
                {
                    this.sellerDataManager = new SellerDataManager(this.StefaniniContext);
                }
                return this.sellerDataManager;
            }
        }

        #endregion

        #endregion

    }
}
