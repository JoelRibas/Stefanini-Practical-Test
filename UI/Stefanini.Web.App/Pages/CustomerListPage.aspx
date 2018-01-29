<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage1.Master" AutoEventWireup="true" CodeBehind="CustomerListPage.aspx.cs" Inherits="Stefanini.Web.App.Pages.CustomerListPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="margin-top: 10px;"></div>
<div class="container-fluid" style="text-align: left;">

    <!-- Pesquisar -->
    <section class="panel panel-default" runat="server" id="SearchPanel">
        <article class="panel-heading">
            <p class="panel-title">Customer Search</p>
        </article>
        <article class="panel-body">
            <div class="form-horizontal">
                
                <!-- Campos de Filtro -->
                <div>
                    
                    <div class="form-group">
                        <label class="control-label col-lg-2" for="NameFilter">Name</label>
                        <div class="col-lg-10">
                            <asp:TextBox ID="NameFilter" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-2" for="GenderIdFilter">Gender</label>
                        <div class="col-lg-10">
                            <asp:DropDownList ID="GenderIdFilter" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Description" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-2" for="RegionIdFilter">Region</label>
                        <div class="col-lg-10">
                            <asp:DropDownList ID="RegionIdFilter" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Description" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-2" for="CityIdFilter">City</label>
                        <div class="col-lg-10">
                            <asp:DropDownList ID="CityIdFilter" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Description" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-2" for="LastPurchaseFilter">Last Purchase Start</label>
                        <div class="col-lg-10">
                            <asp:TextBox ID="LastPurchaseStartFilter" runat="server" CssClass="form-control" />
                            <ajaxToolkit:CalendarExtender ID="LastPurchaseStartFilterCalendarExtender" runat="server" Enabled="True" TargetControlID="LastPurchaseStartFilter" Format="dd/MM/yyyy" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-2" for="LastPurchaseFilter">Last Purchace End</label>
                        <div class="col-lg-10">
                            <asp:TextBox ID="LastPurchaseEndFilter" runat="server" CssClass="form-control" />
                            <ajaxToolkit:CalendarExtender ID="LastPurchaseEndFilterCalendarExtender" runat="server" Enabled="True" TargetControlID="LastPurchaseEndFilter" Format="dd/MM/yyyy" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-2" for="ClassificationIdFilter">Classification</label>
                        <div class="col-lg-10">
                            <asp:DropDownList ID="ClassificationIdFilter" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Description" />
                        </div>
                    </div>

                    <asp:Panel runat="server" ID="SellerFilterPanel">

                        <div class="form-group">
                            <label class="control-label col-lg-2" for="UserIdFilter">Seller</label>
                            <div class="col-lg-10">
                                <asp:DropDownList ID="UserIdFilter" runat="server" CssClass="form-control" DataValueField="Id" DataTextField="Description" />
                            </div>
                        </div>

                    </asp:Panel>



                </div>

                <hr />

                <div class="form-group">
                    <div class="col-sm-12 text-center"> 
                        <div class="col-sm-4">
                        </div>
                        <div class="col-sm-2 text-right">
                            <asp:Button ID="SearchButton" runat="server" Text="Search" CssClass="btn btn-primary btn-block" OnClick="SearchButton_Click" />
                        </div>
                        <div class="col-sm-2 text-left">
                            <asp:Button ID="CleanButton" runat="server" Text="Clear Fields" CssClass="btn btn-secondary btn-block" OnClick="CleanButton_Click" />
                        </div>
                        <div class="col-sm-4">
                        </div>
                    </div>
                </div>


            </div>
        </article>
    </section>

    <!-- Resultado da Pesquisa -->
    <section class="panel panel-default" runat="server" id="ResultPanel">
        <article class="panel-heading">
            <p class="panel-title">Search Result</p>
        </article>
        <article class="panel-body">
            <asp:Panel ID="CustomerSearchResultPanel" runat="server" class="form-horizontal">
                <h4 runat="server" id="CustomerRegistrosEncontradosMessage">Records Found</h4>
                <hr />

                <asp:Panel id="CustomerSearchResultNoRecordsPanel" runat="server" CssClass="alert alert-warning">
                    <div>No records found</div>
                </asp:Panel>
                
                <!-- Grid -->
                <asp:GridView
                    ID="CustomerSearchResultGridView"
                    runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-striped table-bordered"

                    AllowPaging="True"
                    AllowSorting="true"                           

                    DataKeyNames="CustomerId, Customer"
                    >

                    <PagerStyle HorizontalAlign = "Center" CssClass = "pagination-bs" />

                    <Columns>
		                <asp:TemplateField HeaderText="#">
			                <ItemTemplate>
				                <%# Container.DataItemIndex  + 1 %>
			                </ItemTemplate>
		                </asp:TemplateField>

                        
                        <asp:BoundField HeaderText="Id" DataField="CustomerId" />
                        <asp:BoundField HeaderText="Classification" DataField="Classification" />
                        <asp:BoundField HeaderText="Name" DataField="Customer" />
                        <asp:BoundField HeaderText="Phone" DataField="Phone" />
                        <asp:BoundField HeaderText="Gender" DataField="Gender" />
                        <asp:BoundField HeaderText="City" DataField="City" />
                        <asp:BoundField HeaderText="Region" DataField="Region" />
                        <asp:BoundField HeaderText="LastPurchase" DataField="LastPurchase" />
                        <asp:BoundField HeaderText="Seller" DataField="Seller" />

                    </Columns>
                </asp:GridView>

            </asp:Panel>
        </article>
        <article class="panel-footer">
            <asp:Button runat="server" ID="NewSearchButton" class="btn btn-primary" Text="New Search" OnClick="NewSearchButton_Click" />
        </article>
    </section>

</div>


</asp:Content>
