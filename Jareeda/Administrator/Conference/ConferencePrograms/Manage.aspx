﻿<%@ Page Title="" Language="C#" MasterPageFile="~/_MasterPages/AdminMain.master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="Administrator.Conference.ConferencePrograms.Manage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LeftPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <div class="g12 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Manage Conference Programs</h3>
				<div class="inner-content">
            <dx:ASPxGridView ID="ConferenceProgramGrid" runat="server" 
                AutoGenerateColumns="False" DataSourceID="ConferenceProgramsObjectDS" 
                KeyFieldName="ConferenceProgramId" Width="100%">
                <Columns>
                    <dx:GridViewCommandColumn VisibleIndex="0" ButtonType="Image" Caption=" " Width="60px">
                        <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>
                        <EditButton Visible="True">
                            <Image Height="16px" Url="~/images/editgrid.png" Width="16px">
                            </Image>
                        </EditButton>
                        <NewButton Visible="True">
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
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="ConferenceProgramId" ReadOnly="True" Visible="false"
                        VisibleIndex="1" Caption="Id" Width="50px">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ProgramName" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Conference" FieldName="ConferenceId" 
                        VisibleIndex="3" Width="120px">
                        <PropertiesComboBox DataSourceID="ConferenceObjectDS" 
                            TextField="ConferenceName" ValueField="ConferenceId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                      <dx:GridViewDataTextColumn Caption=" " VisibleIndex="3" Width="120px">
                        <DataItemTemplate>
                            <asp:HyperLink ID="hlSchedules" runat="server" NavigateUrl='<%#"ManageConferenceSchedule.aspx?ProgramID="+Eval("ConferenceProgramId").ToString()%>'
                                Text="Program Schedules"></asp:HyperLink>
                        </DataItemTemplate>
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                </Columns>
                <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" EnableRowHotTrack="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                <Templates>
                    <DetailRow>
                        <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" 
                            DataSourceID="dsProgramLanguage" KeyFieldName="ConferenceProgramId" OnBeforePerformDataSelect="ASPxGridView1_BeforePerformDataSelect">
                            <Columns>
                    <dx:GridViewCommandColumn VisibleIndex="0" ButtonType="Image">
                         <DeleteButton Visible="True">
                            <Image Height="16px" Url="~/images/griddelete.png" Width="16px">
                            </Image>
                        </DeleteButton>
                        <EditButton Visible="True">
                            <Image Height="16px" Url="~/images/editgrid.png" Width="16px">
                            </Image>
                        </EditButton>
                        <NewButton Visible="True">
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
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="ConferenceProgramId" ReadOnly="True" Visible="false"
                        VisibleIndex="1">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ProgramName" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>    
                    <dx:GridViewDataComboBoxColumn Caption="Conference" FieldName="ConferenceId" Visible="false"
                        VisibleIndex="3">
                        <PropertiesComboBox DataSourceID="ConferenceObjectDS" 
                            TextField="ConferenceName" ValueField="ConferenceId" ValueType="System.Int32">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>                
                                <dx:GridViewDataComboBoxColumn Caption="Language" FieldName="LanguageID" 
                        VisibleIndex="22">
                        <PropertiesComboBox DataSourceID="dsLanguages" TextField="Name" ValueField="LanguageId"></PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn FieldName="ConferenceProgramParentID" 
                                    VisibleIndex="4" Visible="false">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn FieldName="NewRecord" VisibleIndex="5"   Visible="false">
                                </dx:GridViewDataCheckColumn>
                            </Columns>
                            <SettingsBehavior AllowFocusedRow="True" ConfirmDelete="True" EnableRowHotTrack="True" />
                <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="450px" />
                <Settings ShowFilterRow="True" />
                <SettingsText ConfirmDelete="Are you sure you want to delete this record?" />
                        </dx:ASPxGridView>
                          <asp:ObjectDataSource ID="dsLanguages" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic">
            </asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="dsProgramLanguage" runat="server" 
                            DeleteMethod="Delete" InsertMethod="Insert" 
                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                            TypeName="BusinessLogicLayer.Components.Conference.ConferenceProgramsLanguageLogic" 
                            UpdateMethod="Update">
                            <DeleteParameters>
                                <asp:Parameter Name="Original_ConferenceProgramId" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="ProgramName" Type="String" />
                                <asp:Parameter Name="ConferenceId" Type="Int32" />
                                <asp:Parameter Name="LanguageID" Type="Int32" />                                
                                 <asp:SessionParameter Name="ConferenceProgramParentID" SessionField="ParentID" Type="Int32" />
                            </InsertParameters>
                            <SelectParameters>
                                <asp:SessionParameter Name="parentID" SessionField="ParentID" Type="Int32" />
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="ProgramName" Type="String" />
                                <asp:Parameter Name="ConferenceId" Type="Int32" />
                                <asp:Parameter Name="LanguageID" Type="Int32" />
                                 <asp:SessionParameter Name="ConferenceProgramParentID" SessionField="ParentID" Type="Int32" />
                                <asp:Parameter Name="Original_ConferenceProgramId" Type="Int32" />
                            </UpdateParameters>
                        </asp:ObjectDataSource>
                    </DetailRow>
                </Templates>
            </dx:ASPxGridView>
            </div>
            <asp:ObjectDataSource ID="ConferenceProgramsObjectDS" runat="server" 
                DeleteMethod="Delete" InsertMethod="Insert" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                TypeName="BusinessLogicLayer.Components.Conference.ConferenceProgramsLogic" 
                UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_ConferenceProgramId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProgramName" Type="String" />
                    <asp:Parameter Name="ConferenceId" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProgramName" Type="String" />
                    <asp:Parameter Name="ConferenceId" Type="Int32" />
                    <asp:Parameter Name="Original_ConferenceProgramId" Type="Int32" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ConferenceObjectDS" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                TypeName="BusinessLogicLayer.Components.Conference.ConferencesLogic">
            </asp:ObjectDataSource>
        </div>
        </div>
</asp:Content>
