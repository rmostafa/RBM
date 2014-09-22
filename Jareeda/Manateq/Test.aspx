﻿<%@ Page Title=""  Language="C#" MasterPageFile="~/_Masters/Master.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="ManatiqFrontEnd.Test" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxDataView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register Src="~/Controls/General/Weather.ascx" TagName="WeatherControl" TagPrefix="natiq" %>
<%@ Register Src="~/Controls/News/MostReadCommented.ascx" TagName="MostReadControl" TagPrefix="natiq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div style="width:300px;">
    <natiq:WeatherControl runat="server" />
        <br /><br />
    <natiq:MostReadControl runat="server" />
 </div>


    <div id="more_news" ></div>
            <div class="clear clearfix clear-fix"></div>
            <div class="readMoreList">
                <img id="loadingMore" style="display:none;" src="~/images/DXR.gif" runat="server" />
                <a href="javascript:void(0);" onclick="cb2.PerformCallback();" >تحميل أكثر</a>
            </div>

    <dx:ASPxCallback ID="callBackList" ClientInstanceName="callBackList"  runat="server" OnCallback="callBackList_Callback" ClientIDMode="Static">
    <ClientSideEvents BeginCallback="function(s, e) {
        alert('test');
	$('#loadingMore').show();
}" EndCallback="function(s, e) {
		$('#loadingMore').hide();
        #('#more_news').append(e.result);
}" />
</dx:ASPxCallback>


     <dx:ASPxCallback ID="ASPxCallback1" ClientInstanceName="cb2" OnCallback="cb2_Callback" runat="server">
            <ClientSideEvents BeginCallback="function(s, e) {
	alert('test');
}" Init="function(s, e) {
	alert('init');
}" />
            
        </dx:ASPxCallback>
    <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px"></dx:ASPxTextBox>
    <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Callback" AutoPostBack=false>
        <ClientSideEvents Click="function (s, e) {  cb2.PerformCallback(); }" />
        </dx:ASPxButton>
</asp:Content>
