﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Administrator.ContentManagement.Home.HomePage.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSplitter" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxImageSlider" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxClasses" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" Width="200px"></dx:ASPxCallbackPanel>
        <dx:ASPxGridView ID="ASPxGridView1" runat="server"></dx:ASPxGridView>
        <dx:ASPxDataView ID="ASPxDataView1" runat="server"></dx:ASPxDataView>
        <dx:ASPxHtmlEditor ID="ASPxHtmlEditor1" runat="server"></dx:ASPxHtmlEditor>
        <dx:ASPxImageSlider ID="ASPxImageSlider1" runat="server" BinaryImageCacheFolder="~\Thumb\"></dx:ASPxImageSlider>
        <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" RenderMode="Lightweight" ActiveTabIndex="0">
            <TabPages>
                <dx:TabPage>
                    <ContentCollection>
                        <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage>
                    <ContentCollection>
                        <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage>
                    <ContentCollection>
                        <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
        </dx:ASPxPageControl>
        <dx:ASPxNavBar ID="ASPxNavBar1" runat="server" RenderMode="Lightweight"></dx:ASPxNavBar>
        <dx:WebChartControl ID="WebChartControl1" runat="server" CrosshairEnabled="True" Height="200px" SideBySideEqualBarWidth="True" Width="300px">
            <diagramserializable>
                <dx:XYDiagram>
                    <axisx visibleinpanesserializable="-1">
                        <range alwaysshowzerolevel="True" sidemarginsenabled="True" />
                    </axisx>
                    <axisy visibleinpanesserializable="-1">
                        <range alwaysshowzerolevel="True" sidemarginsenabled="True" />
                    </axisy>
                </dx:XYDiagram>
            </diagramserializable>
<FillStyle><OptionsSerializable>
<dx:SolidFillOptions></dx:SolidFillOptions>
</OptionsSerializable>
</FillStyle>

            <seriesserializable>
                <dx:Series Name="Series 1">
                    <viewserializable>
                        <dx:SideBySideBarSeriesView>
                        </dx:SideBySideBarSeriesView>
                    </viewserializable>
                    <labelserializable>
                        <dx:SideBySideBarSeriesLabel LineVisible="True">
                            <fillstyle>
                                <optionsserializable>
                                    <dx:SolidFillOptions />
                                </optionsserializable>
                            </fillstyle>
                            <pointoptionsserializable>
                                <dx:PointOptions>
                                </dx:PointOptions>
                            </pointoptionsserializable>
                        </dx:SideBySideBarSeriesLabel>
                    </labelserializable>
                    <legendpointoptionsserializable>
                        <dx:PointOptions>
                        </dx:PointOptions>
                    </legendpointoptionsserializable>
                </dx:Series>
                <dx:Series Name="Series 2">
                    <viewserializable>
                        <dx:SideBySideBarSeriesView>
                        </dx:SideBySideBarSeriesView>
                    </viewserializable>
                    <labelserializable>
                        <dx:SideBySideBarSeriesLabel LineVisible="True">
                            <fillstyle>
                                <optionsserializable>
                                    <dx:SolidFillOptions />
                                </optionsserializable>
                            </fillstyle>
                            <pointoptionsserializable>
                                <dx:PointOptions>
                                </dx:PointOptions>
                            </pointoptionsserializable>
                        </dx:SideBySideBarSeriesLabel>
                    </labelserializable>
                    <legendpointoptionsserializable>
                        <dx:PointOptions>
                        </dx:PointOptions>
                    </legendpointoptionsserializable>
                </dx:Series>
            </seriesserializable>

<SeriesTemplate><ViewSerializable>
<dx:SideBySideBarSeriesView></dx:SideBySideBarSeriesView>
</ViewSerializable>
<LabelSerializable>
<dx:SideBySideBarSeriesLabel LineVisible="True">
<FillStyle><OptionsSerializable>
<dx:SolidFillOptions></dx:SolidFillOptions>
</OptionsSerializable>
</FillStyle>
<PointOptionsSerializable>
<dx:PointOptions></dx:PointOptions>
</PointOptionsSerializable>
</dx:SideBySideBarSeriesLabel>
</LabelSerializable>
<LegendPointOptionsSerializable>
<dx:PointOptions></dx:PointOptions>
</LegendPointOptionsSerializable>
</SeriesTemplate>

<CrosshairOptions><CommonLabelPositionSerializable>
<dx:CrosshairMousePosition></dx:CrosshairMousePosition>
</CommonLabelPositionSerializable>
</CrosshairOptions>

<ToolTipOptions><ToolTipPositionSerializable>
<dx:ToolTipMousePosition></dx:ToolTipMousePosition>
</ToolTipPositionSerializable>
</ToolTipOptions>
        </dx:WebChartControl>
        <dx:ASPxSplitter ID="ASPxSplitter1" runat="server">
            <Panes>
                <dx:SplitterPane></dx:SplitterPane>
                <dx:SplitterPane></dx:SplitterPane>
            </Panes>
        </dx:ASPxSplitter>
        <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" RenderMode="Lightweight"></dx:ASPxPopupControl>
    </form>
</body>
</html>
