﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports System.Text
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.UI
Public Class GV
    'Public Shared myConn As String = "Data Source=192.168.1.6\Master;Initial Catalog=MasterPro;Persist Security Info=True;User ID=walid;Password=wwzzaa"
    'Public Shared myConn As String = "Data Source=Walid-PC\Master;Initial Catalog=Anton;User ID=UserConnect;Password=wwzzaa"
    'Public Shared myConn As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True"
    'Public Shared myConn As String = "Data Source=Walid-PC\Master;Initial Catalog=Anton;User ID=UserConnect;Password=wwzzaa"

    Public Shared myConn As String = "Data Source=Server-PC\MASTER;Initial Catalog=MasterPro;Persist Security Info=True;User ID=walid;Password=wwzzaa"
    Public Shared MarketName As String = "Anton Shopping Center"
    Public Shared appDemo As Boolean = False
    Public Shared deadLine As Date = #5/7/2024#
    Public Shared Invoices As Long = 30000000
    Public Shared CheckQnty As Boolean = True
    Public Shared dualBarcode As Boolean = True

    ''''to reset db
    ''    --dbcc checkident ('tblOut1', reseed)

    ''delete from tblcash;
    ''delete from tblCompounds;
    ''delete from tblDebit;
    ''delete from tblIn2;
    ''delete from tblin1;
    ''delete from tblOut2;
    ''delete from tblOut1;
    ''delete from tblInInvoice;
    ''delete from tblRate;
    ''delete from tblVendors;
    ''delete from tblLogin;

    Public Shared Sub GenerateSignlePageReport(ByVal report As XtraReport)
        'Dim sumHeight As Single = 0
        'report.CreateDocument()
        'Dim pageSettings As XtraPageSettingsBase = report.PrintingSystem.PageSettings
        '    XtraPageSettingsBase.ApplyPageSettings(pageSettings, PaperKind.Custom, New Size(pageSettings.Bounds.Width,
        ''                                                                                    dim ))
    End Sub

End Class

