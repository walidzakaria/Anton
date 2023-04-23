Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports System.Text
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.UI
Public Class GV
    'Public Shared myConn As String = "Data Source=DESKTOP-9I7UUFN\MASTER;Initial Catalog=AntonNew;User ID=sa;Password=wwzzaa"
    'Public Shared myConn As String = "Data Source=192.168.1.6\Master;Initial Catalog=MasterPro;Persist Security Info=True;User ID=walid;Password=wwzzaa"
    'Public Shared myConn As String = $"Data Source={Environment.MachineName}\Master;Initial Catalog=AntonNew;User ID=sa;Password=wwzzaa"
    'Public Shared myConn As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True"
    'Public Shared myConn As String = "Data Source=Walid-PC\Master;Initial Catalog=Anton;User ID=UserConnect;Password=wwzzaa"

    'Public Shared myConn As String = "Data Source=Server-PC\MASTER;Initial Catalog=MasterPro;Persist Security Info=True;User ID=walid;Password=wwzzaa"

    ''Anton1
    'Public Shared myConn As String = "Data Source=192.168.1.10;Initial Catalog=MasterPro;Persist Security Info=True;User ID=sa;Password=Anton@21"

    ''Anton 1 local dummy
    Public Shared myConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;"


    ''Anton2 server dummy
    'Public Shared myConn As String = "Data Source=Server-PC\MASTER;Initial Catalog=MasterPro;Persist Security Info=True;User ID=walid;Password=wwzzaa"

    ''For Sheraton server
    'Public Shared myConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;"

    ''Anton2 server real
    'Public Shared myConn As String = "Data Source=Server-PC\MASTER;Initial Catalog=MasterProSR;Persist Security Info=True;User ID=walid;Password=wwzzaa"

    ''Anton Smile real
    'Public Shared myConn As String = "Data Source=Server-PC\MASTER;Initial Catalog=MasterPro;Persist Security Info=True;User ID=sa;Password=wwzzaa"

    ''Anton 3 Emad -> both real and fake and Saint Maria
    'Public Shared myConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;"



    Public Shared MarketName As String = "Anton Shopping Center"
    Public Shared appDemo As Boolean = False
    Public Shared deadLine As Date = #5/7/2027#
    Public Shared Invoices As Long = 30000000
    Public Shared CheckQnty As Boolean = True
    Public Shared dualBarcode As Boolean = True
    Public Shared OptionalDate As Boolean = False
    ''Adjust if Sheraton or Smile = True if not = False
    Public Shared PrintCost As Boolean = False

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

