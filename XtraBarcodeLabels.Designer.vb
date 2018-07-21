<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraBarcodeLabels
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim Code128Generator2 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarcode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrlbItemName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1, Me.XrLabel1, Me.XrLabel3, Me.XrLabel5, Me.XrBarcode, Me.XrlbItemName, Me.XrLabel4, Me.XrLabel2})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 286.8825!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 13.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 46.72274!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblBarcode.PrKey")})
        Me.XrBarCode1.Dpi = 254.0!
        Me.XrBarCode1.Font = New System.Drawing.Font("Times New Roman", 5.0!)
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(48.99997!, 124.8513!)
        Me.XrBarCode1.Module = 5.08!
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(379.92!, 71.3985!)
        Me.XrBarCode1.StylePriority.UseFont = False
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Me.XrBarCode1.Symbology = Code128Generator1
        Me.XrBarCode1.Text = "8690757202509"
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrLabel1
        '
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblBarcode.Item")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(170.1343!, 196.2498!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(258.7857!, 33.46595!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(136.2339!, 199.2499!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(33.9004!, 26.12187!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.Text = "LE"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblBarcode.Price")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(48.99997!, 177.0193!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(87.23391!, 51.69647!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrBarcode
        '
        Me.XrBarcode.AutoModule = True
        Me.XrBarcode.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblBarcode.PrKey")})
        Me.XrBarcode.Dpi = 254.0!
        Me.XrBarcode.Font = New System.Drawing.Font("Times New Roman", 5.0!)
        Me.XrBarcode.LocationFloat = New DevExpress.Utils.PointFloat(49.00002!, 2.986889!)
        Me.XrBarcode.Module = 5.08!
        Me.XrBarcode.Name = "XrBarcode"
        Me.XrBarcode.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254.0!)
        Me.XrBarcode.SizeF = New System.Drawing.SizeF(379.92!, 71.3985!)
        Me.XrBarcode.StylePriority.UseFont = False
        Me.XrBarcode.StylePriority.UseTextAlignment = False
        Me.XrBarcode.Symbology = Code128Generator2
        Me.XrBarcode.Text = "8690757202509"
        Me.XrBarcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrlbItemName
        '
        Me.XrlbItemName.CanGrow = False
        Me.XrlbItemName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblBarcode.Item")})
        Me.XrlbItemName.Dpi = 254.0!
        Me.XrlbItemName.Font = New System.Drawing.Font("Times New Roman", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrlbItemName.LocationFloat = New DevExpress.Utils.PointFloat(170.1343!, 74.38541!)
        Me.XrlbItemName.Name = "XrlbItemName"
        Me.XrlbItemName.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrlbItemName.SizeF = New System.Drawing.SizeF(258.7857!, 33.46595!)
        Me.XrlbItemName.StylePriority.UseFont = False
        Me.XrlbItemName.StylePriority.UsePadding = False
        Me.XrlbItemName.StylePriority.UseTextAlignment = False
        Me.XrlbItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(136.2339!, 76.38541!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(33.9004!, 26.12188!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.Text = "LE"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblBarcode.Price")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(49.0!, 56.15485!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(87.23391!, 51.69647!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XtraBarcodeLabels
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter})
        Me.DataMember = "tblBarcode"
        Me.DefaultPrinterSettingsUsing.UsePaperKind = True
        Me.DisplayName = "Receipt"
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(28, 13, 0, 13)
        Me.PageHeight = 800
        Me.PageWidth = 484
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PaperName = "80 x 297 mm (48 column)"
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RollPaper = True
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 31.75!
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarcode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrlbItemName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
End Class
