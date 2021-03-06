﻿<%@ Page Theme="MetropolisBlue" Title="" Language="C#" MasterPageFile="~/_Masters/AdminMain.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Administrator.Content.Articles.Default" %>
<%@ Register Src="~/Dashboard/Controls/Content/TotalArticlesWidgetItem.ascx" TagName="TotalArticlesControl" TagPrefix="jareeda" %>
<%@ Register Src="~/Dashboard/Controls/Content/TotalArticlesTodayWidgetItem.ascx" TagName="TotalArticlesTodayControl" TagPrefix="jareeda" %>
<%@ Register Src="~/Dashboard/Controls/Content/LastArticleModifiedWidgetItem.ascx" TagName="LastModifiedArticleControl" TagPrefix="jareeda" %>
<%@ Register Src="~/Dashboard/Controls/Content/TotalSectionsWidgetItem.ascx" TagName="TotalSectionsControl" TagPrefix="jareeda" %>

<%@ Register Src="~/Dashboard/Controls/GoogleAnalytics/TotalVisitsWidgetITem.ascx" TagName="TotalVisitsControl" TagPrefix="jareeda" %>
<%@ Register Src="~/Dashboard/Controls/GoogleAnalytics/TopArticleTodayWidgetItem.ascx" TagName="TopArticlesTodayControl" TagPrefix="jareeda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TitlePlaceHolder" runat="server">
   <div class="col-md-4">
        <h1>
            <asp:Literal ID="AFTitle" runat="server" Text="<%$Resources:ContentManagement, ARTitle %>"></asp:Literal>
        </h1>

    </div>
      <div class="col-md-7 control-box pull-right">
        <ul>
            <li>
                <dx:ASPxButton ID="btnAddNew" runat="server" Text="<%$Resources:ContentManagement, AddNew %>"
                    OnClick="btnAddNew_Click">
                    <Image Url="~/images/icons/plus_32.png" Height="24px" Width="24px">
                    </Image>
                </dx:ASPxButton>
            </li>
        </ul>

    </div>
   


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="LeftPlaceHolder" runat="server">
    
    <jareeda:TotalVisitsControl runat="server" />
    <jareeda:TopArticlesTodayControl runat="server" />
    <jareeda:LastModifiedArticleControl runat="server" />
    <jareeda:TotalArticlesControl runat="server" />
    <jareeda:TotalArticlesTodayControl runat="server" />
    
    
    
    
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
        
               
            <dx:ASPxGridView  ID="SitePageGrid" ClientInstanceName="SitePageGrid" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SitePagesObjectDS" KeyFieldName="ArticleId" 
                    oncelleditorinitialize="SitePageGrid_CellEditorInitialize" Width="100%">

<SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True"></SettingsBehavior>

<SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px"></SettingsEditing>

<Settings ShowFilterRow="True" ShowGroupPanel="True"></Settings>

<SettingsText ConfirmDelete="Are you sure you want to delete this record?"></SettingsText>
                <ClientSideEvents CustomButtonClick="function(s, e) {
	window.location.href ='Save.aspx?Code=' + s.GetRowKey(s.GetFocusedRowIndex());
}" />
                <Columns>
                    <dx:GridViewCommandColumn ButtonType="Image" VisibleIndex="0" Width="60px" Caption=" ">
                        <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>
                        <EditButton>
                            <Image Height="16px" Url="~/images/editgrid.png" Width="16px">
                            </Image>
                        </EditButton>
                        <NewButton>
                            <Image Height="16px" Url="~/images/newgrid.png" Width="16px">
                            </Image>
                        </NewButton>
                        <CancelButton>
                            <Image Height="32px" Url="~/images/cancelsave32.png" Width="32px">
                            </Image>
                        </CancelButton>
                        <UpdateButton>
                            <Image Height="32px" Url="~/images/filesave32.png" Width="32px">
                            </Image>
                        </UpdateButton>
                        <ClearFilterButton Visible="True">
                        </ClearFilterButton>
                        <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton Text="Edit">
                                <Image AlternateText="Edit" Height="16px" Url="~/images/editgrid.png" 
                                    Width="16px">
                                </Image>
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="SitePageId" 
                        ReadOnly="True" VisibleIndex="1" Caption="<%$Resources:ContentManagement, ARTitle %>" Visible="false" Width="50px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="<%$Resources:ContentManagement, ARArticleName %>" FieldName="ArticleName" 
                        VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="<%$Resources:ContentManagement, ARSiteID %>" FieldName="SiteId" 
                        VisibleIndex="3" Width="120px">
                        <PropertiesComboBox DataSourceID="SiteObjectDS" TextField="Name" 
                            ValueField="SiteId" ValueType="System.Int32">
                             <ClientSideEvents SelectedIndexChanged="function(s, e) { OnSiteChanged(s); }"></ClientSideEvents>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn Caption="<%$ Resources:ContentManagement, ARSection %>" FieldName="SectionName" VisibleIndex="4" Width="120px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="<%$Resources:ContentManagement, ARStatus %>" FieldName="ArticleStatusId" 
                        VisibleIndex="5" Width="80px">
                        <PropertiesComboBox DataSourceID="StatusObjectDS" TextField="Name" 
                            ValueField="ArticleStatusId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn Caption="<%$Resources:ContentManagement, ARCreator %>" FieldName="AuthorName" 
                        VisibleIndex="6" Width="120px">
                        
                        <Settings FilterMode="DisplayText" />
                        
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataDateColumn FieldName="ModifiedDate" Caption="<%$Resources:ContentManagement, ARModifiedDate %>" VisibleIndex="7" Width="80px" SortIndex="0" SortOrder="Descending">
                        <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy hh:mm:ss tt">
                        </PropertiesDateEdit>
                    </dx:GridViewDataDateColumn>
                </Columns>
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" ShowGroupPanel="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />

    </dx:ASPxGridView>
                
                <asp:ObjectDataSource ID="SitePagesObjectDS" runat="server" 
                    DeleteMethod="Delete" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllArticles" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.ArticleLogic">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_ArticleId" Type="Int32" />
                    </DeleteParameters>
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="2" Name="LanguageID" 
                            SessionField="CurrentLanguageID" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                
                <asp:ObjectDataSource ID="SiteObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SectionObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllBySiteId" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.SiteSectionLogic">
                    <SelectParameters>
                        <asp:Parameter Name="SiteId" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                
                <asp:ObjectDataSource ID="StatusObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.ArticleStatusLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="SecurityAccessObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.RoleSecurity.SecurityAccessTypeLogic">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="PersonObjectDS" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.Persons.PersonLogic">
                </asp:ObjectDataSource>
                
    
    
</asp:Content>
