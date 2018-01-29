using System;
using System.Collections.Generic;

using Stefanini.Domain.Entities;

namespace Stefanini.Web
{
    public partial class StefaniniPage
    {

        #region Gender

        public List<ComboItem> GenderComboList()
        {
            List<ComboItem> result = new List<ComboItem>();
            List<Gender> list = StefaniniManager.GenderManager.List();
            if (list.Count > 0)
            {
                result = new List<ComboItem>();
                foreach (var item in list)
                {
                    result.Add(new ComboItem(item.Id.ToString(), item.Name));
                }
            }
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> GenderComboListWithZero()
        {
            List<ComboItem> result = this.GenderComboList();
            result.Add(new ComboItem("0", "(None)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> GenderComboListWithMinValue()
        {
            List<ComboItem> result = this.GenderComboList();
            result.Add(new ComboItem(int.MinValue.ToString(), "(Select)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> GenderComboListWithMaxValue()
        {
            List<ComboItem> result = this.GenderComboList();
            result.Add(new ComboItem(int.MaxValue.ToString(), "(All)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }

        #endregion

        #region Region

        public List<ComboItem> RegionComboList()
        {
            List<ComboItem> result = new List<ComboItem>();
            List<Region> list = StefaniniManager.RegionManager.List();
            if (list.Count > 0)
            {
                result = new List<ComboItem>();
                foreach (var item in list)
                {
                    result.Add(new ComboItem(item.Id.ToString(), item.Name));
                }
            }
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> RegionComboListWithZero()
        {
            List<ComboItem> result = this.RegionComboList();
            result.Add(new ComboItem("0", "(None)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> RegionComboListWithMinValue()
        {
            List<ComboItem> result = this.RegionComboList();
            result.Add(new ComboItem(int.MinValue.ToString(), "(Select)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> RegionComboListWithMaxValue()
        {
            List<ComboItem> result = this.RegionComboList();
            result.Add(new ComboItem(int.MaxValue.ToString(), "(All)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }

        #endregion

        #region City

        public List<ComboItem> CityComboList()
        {
            List<ComboItem> result = new List<ComboItem>();
            List<City> list = StefaniniManager.CityManager.List();
            if (list.Count > 0)
            {
                result = new List<ComboItem>();
                foreach (var item in list)
                {
                    result.Add(new ComboItem(item.Id.ToString(), item.Name));
                }
            }
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> CityComboListWithZero()
        {
            List<ComboItem> result = this.CityComboList();
            result.Add(new ComboItem("0", "(None)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> CityComboListWithMinValue()
        {
            List<ComboItem> result = this.CityComboList();
            result.Add(new ComboItem(int.MinValue.ToString(), "(Select)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> CityComboListWithMaxValue()
        {
            List<ComboItem> result = this.CityComboList();
            result.Add(new ComboItem(int.MaxValue.ToString(), "(All)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }

        #endregion

        #region Classification

        public List<ComboItem> ClassificationComboList()
        {
            List<ComboItem> result = new List<ComboItem>();
            List<Classification> list = StefaniniManager.ClassificationManager.List();
            if (list.Count > 0)
            {
                result = new List<ComboItem>();
                foreach (var item in list)
                {
                    result.Add(new ComboItem(item.Id.ToString(), item.Name));
                }
            }
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> ClassificationComboListWithZero()
        {
            List<ComboItem> result = this.ClassificationComboList();
            result.Add(new ComboItem("0", "(None)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> ClassificationComboListWithMinValue()
        {
            List<ComboItem> result = this.ClassificationComboList();
            result.Add(new ComboItem(int.MinValue.ToString(), "(Select)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> ClassificationComboListWithMaxValue()
        {
            List<ComboItem> result = this.ClassificationComboList();
            result.Add(new ComboItem(int.MaxValue.ToString(), "(All)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }

        #endregion

        #region Seller

        public List<ComboItem> SellerComboList()
        {
            List<ComboItem> result = new List<ComboItem>();
            List<UserSys> list = StefaniniManager.SellerManager.List();
            if (list.Count > 0)
            {
                result = new List<ComboItem>();
                foreach (var item in list)
                {
                    result.Add(new ComboItem(item.Id.ToString(), item.Login));
                }
            }
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> SellerComboListWithZero()
        {
            List<ComboItem> result = this.SellerComboList();
            result.Add(new ComboItem("0", "(None)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> SellerComboListWithMinValue()
        {
            List<ComboItem> result = this.SellerComboList();
            result.Add(new ComboItem(int.MinValue.ToString(), "(Select)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }
        public List<ComboItem> SellerComboListWithMaxValue()
        {
            List<ComboItem> result = this.SellerComboList();
            result.Add(new ComboItem(int.MaxValue.ToString(), "(All)"));
            result.Sort(ComboItem.ByDescription);
            return result;
        }

        #endregion


    }
}