using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Stefanini.Domain.Entities;
using Stefanini.Domain.QueryParameter;
using Stefanini.Domain.Views;

namespace Stefanini.Web.App.Pages
{
    public partial class CustomerListPage : StefaniniSecurePage
    {

        int sellerIdFilterDefault = int.MaxValue;

        #region Page_Load

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                togglePanelVisibility(true, false);
                fillCombosForSearch();
                if (CurrentUser.UserRoleId != 1) // Administrator
                {
                    SellerFilterPanel.Visible = false;
                    sellerIdFilterDefault = CurrentUser.Id;
                    UserIdFilter.SelectedValue = sellerIdFilterDefault.ToString();
                    CustomerSearchResultGridView.Columns[9].Visible = false;
                }
            }
        }

        #endregion

        #region User Interface Events

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            search();
        }
        protected void NewSearchButton_Click(object sender, EventArgs e)
        {
            newSearch();
        }
        protected void CleanButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        #endregion

        #region fillCombosForSearch

        private void fillCombosForSearch()
        {
            GenderIdFilter.DataSource = GenderComboListWithMaxValue();
            GenderIdFilter.DataBind();
            RegionIdFilter.DataSource = RegionComboListWithMaxValue();
            RegionIdFilter.DataBind();
            CityIdFilter.DataSource = CityComboListWithMaxValue();
            CityIdFilter.DataBind();
            ClassificationIdFilter.DataSource = ClassificationComboListWithMaxValue();
            ClassificationIdFilter.DataBind();
            UserIdFilter.DataSource = SellerComboListWithMaxValue();
            UserIdFilter.DataBind();
        }

        #endregion

        #region search

        private void search()
        {

            CustomerQueryParameter parameter = new CustomerQueryParameter();

            parameter.Name = string.IsNullOrEmpty(NameFilter.Text) ? null : NameFilter.Text;
            parameter.GenderId = int.Parse(GenderIdFilter.SelectedValue);
            parameter.CityId = int.Parse(CityIdFilter.SelectedValue);
            parameter.RegionId = int.Parse(RegionIdFilter.SelectedValue);
            parameter.ClassificationId = int.Parse(ClassificationIdFilter.SelectedValue);
            parameter.UserId = int.Parse(UserIdFilter.SelectedValue);

            parameter.LastPurchaseStart = string.IsNullOrEmpty(LastPurchaseStartFilter.Text) ? (DateTime?)null : DateTime.Parse(LastPurchaseStartFilter.Text) ;
            parameter.LastPurchaseEnd = string.IsNullOrEmpty(LastPurchaseEndFilter.Text) ? (DateTime?)null : DateTime.Parse(LastPurchaseEndFilter.Text);

            int skip = 0;
            int take = int.MaxValue;

            CustomerSearchResultGridView.PageSize = 10;

            List<View_Customer> list = StefaniniManager.CustomerManager.List(parameter, skip, take);

            Session["customerSearchResultList"] = list;
            this.showCustomerGridFromSession();

        }

        #endregion

        #region newSearch

        private void newSearch()
        {
            togglePanelVisibility(true, false);
        }
        #endregion

        #region clearFields

        private void clearFields()
        {
            NameFilter.Text = null;
            GenderIdFilter.SelectedValue = int.MaxValue.ToString();
            RegionIdFilter.SelectedValue = int.MaxValue.ToString();
            CityIdFilter.SelectedValue = int.MaxValue.ToString();
            ClassificationIdFilter.SelectedValue = int.MaxValue.ToString();
            UserIdFilter.SelectedValue = this.sellerIdFilterDefault.ToString();
            LastPurchaseStartFilter.Text = null;
            LastPurchaseEndFilter.Text = null;
        }


        #endregion

        #region showCustomerGridFromSession

        private void showCustomerGridFromSession()
        {
            List<View_Customer> list = (List<View_Customer>)Session["customerSearchResultList"];
            if (list != null && list.Count > 0)
            {

                this.CustomerSearchResultGridView.DataSource = list;
                this.CustomerSearchResultGridView.DataBind();

                this.CustomerSearchResultNoRecordsPanel.Visible = false;
                this.CustomerSearchResultGridView.Visible = true;

                this.CustomerRegistrosEncontradosMessage.InnerText = string.Format("{0} Records Found", list.Count);

            }
            else
            {
                this.CustomerSearchResultNoRecordsPanel.Visible = true;
                this.CustomerSearchResultGridView.Visible = false;
                this.CustomerRegistrosEncontradosMessage.InnerText = "Records Found";
            }

            togglePanelVisibility(false, true);
        }

        #endregion

        #region togglePanelVisibility

        private void togglePanelVisibility(bool searchPanel, bool resultPanel)
        {
            SearchPanel.Visible = searchPanel;
            ResultPanel.Visible = resultPanel;

        }


        #endregion

    }
}