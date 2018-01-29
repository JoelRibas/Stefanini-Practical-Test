using System;
using System.Data.Common;

using Stefanini.Data;
using Stefanini.Types;

namespace Stefanini.Business
{
    public class StefaniniManager
    {
        
        #region Constructor

        public StefaniniManager(DatabaseConnectionSettings settings)
        {
            this.stefaniniDataManager = new StefaniniDataManager(settings);
        }

        #endregion

        #region DataManager

        private StefaniniDataManager stefaniniDataManager;
        public StefaniniDataManager StefaniniDataManager
        {
            get
            {
                return this.stefaniniDataManager;
            }
        }

        #endregion

        #region CustomerManager

        private CustomerManager customerManager;
        public CustomerManager CustomerManager
        {
            get
            {
                if (this.customerManager == null)
                {
                    this.customerManager = new CustomerManager();
                    this.customerManager.StefaniniDataManager = this.StefaniniDataManager;
                }
                return this.customerManager;
            }
        }

        #endregion

        #region UserSysManager

        private UserSysManager userSysManager;
        public UserSysManager UserSysManager
        {
            get
            {
                if (this.userSysManager == null)
                {
                    this.userSysManager = new UserSysManager();
                    this.userSysManager.StefaniniDataManager = this.StefaniniDataManager;
                }
                return this.userSysManager;
            }
        }

        #endregion

        #region GenderManager

        private GenderManager genderManager;
        public GenderManager GenderManager
        {
            get
            {
                if (this.genderManager == null)
                {
                    this.genderManager = new GenderManager();
                    this.genderManager.StefaniniDataManager = this.StefaniniDataManager;
                }
                return this.genderManager;
            }
        }

        #endregion

        #region CityManager

        private CityManager cityManager;
        public CityManager CityManager
        {
            get
            {
                if (this.cityManager == null)
                {
                    this.cityManager = new CityManager();
                    this.cityManager.StefaniniDataManager = this.StefaniniDataManager;
                }
                return this.cityManager;
            }
        }

        #endregion

        #region RegionManager

        private RegionManager regionManager;
        public RegionManager RegionManager
        {
            get
            {
                if (this.regionManager == null)
                {
                    this.regionManager = new RegionManager();
                    this.regionManager.StefaniniDataManager = this.StefaniniDataManager;
                }
                return this.regionManager;
            }
        }

        #endregion

        #region ClassificationManager

        private ClassificationManager classificationManager;
        public ClassificationManager ClassificationManager
        {
            get
            {
                if (this.classificationManager == null)
                {
                    this.classificationManager = new ClassificationManager();
                    this.classificationManager.StefaniniDataManager = this.StefaniniDataManager;
                }
                return this.classificationManager;
            }
        }

        #endregion

        #region SellerManager

        private SellerManager sellerManager;
        public SellerManager SellerManager
        {
            get
            {
                if (this.sellerManager == null)
                {
                    this.sellerManager = new SellerManager();
                    this.sellerManager.StefaniniDataManager = this.StefaniniDataManager;
                }
                return this.sellerManager;
            }
        }

        #endregion

    }
}
