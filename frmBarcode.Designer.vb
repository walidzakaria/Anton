<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarcode
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBarcode))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonPanel13 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.iDgv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qnty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonPanel10 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.iVendor = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel55 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.iSerial = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPrintBadge = New DevExpress.XtraEditors.SimpleButton()
        Me.cbPrinters = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClearQnty = New DevExpress.XtraEditors.SimpleButton()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.FlowLayoutPanel26 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPrintA41 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintA42 = New DevExpress.XtraEditors.SimpleButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPrintLabels1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintLabels2 = New DevExpress.XtraEditors.SimpleButton()
        Me.iCode = New System.Windows.Forms.ComboBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel13.SuspendLayout()
        CType(Me.iDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel10.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel26.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel13)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel10)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.KryptonPanel.Size = New System.Drawing.Size(874, 443)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel13
        '
        Me.KryptonPanel13.Controls.Add(Me.iDgv)
        Me.KryptonPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel13.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel13.Name = "KryptonPanel13"
        Me.KryptonPanel13.Padding = New System.Windows.Forms.Padding(10, 14, 10, 10)
        Me.KryptonPanel13.Size = New System.Drawing.Size(578, 443)
        Me.KryptonPanel13.TabIndex = 7
        '
        'iDgv
        '
        Me.iDgv.AllowUserToAddRows = False
        Me.iDgv.AllowUserToDeleteRows = False
        Me.iDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.iDgv.ColumnHeadersHeight = 40
        Me.iDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.ItemName, Me.Qnty, Me.Column1})
        Me.iDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iDgv.Location = New System.Drawing.Point(10, 14)
        Me.iDgv.Name = "iDgv"
        Me.iDgv.Size = New System.Drawing.Size(558, 419)
        Me.iDgv.TabIndex = 15
        Me.iDgv.TabStop = False
        '
        'Item
        '
        Me.Item.HeaderText = "�����"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 75
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "��� �����"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 87
        '
        'Qnty
        '
        Me.Qnty.HeaderText = "������"
        Me.Qnty.Name = "Qnty"
        Me.Qnty.Width = 66
        '
        'Column1
        '
        Me.Column1.HeaderText = "�����"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 65
        '
        'KryptonPanel10
        '
        Me.KryptonPanel10.Controls.Add(Me.TableLayoutPanel2)
        Me.KryptonPanel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.KryptonPanel10.Location = New System.Drawing.Point(578, 0)
        Me.KryptonPanel10.Name = "KryptonPanel10"
        Me.KryptonPanel10.Padding = New System.Windows.Forms.Padding(10, 14, 10, 10)
        Me.KryptonPanel10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.KryptonPanel10.Size = New System.Drawing.Size(296, 443)
        Me.KryptonPanel10.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.KryptonLabel3, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.KryptonLabel2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.KryptonLabel1, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.iVendor, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.KryptonLabel36, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.KryptonLabel55, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel3, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.iSerial, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDown1, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDown2, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 1, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.cbPrinters, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel4, 1, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.KryptonLabel4, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel26, 1, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.iCode, 1, 10)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 14)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 14
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(279, 419)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel3.Location = New System.Drawing.Point(225, 126)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(51, 20)
        Me.KryptonLabel3.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonLabel3.TabIndex = 14
        Me.KryptonLabel3.Values.Text = "�������:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(225, 63)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(46, 23)
        Me.KryptonLabel2.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonLabel2.TabIndex = 10
        Me.KryptonLabel2.Values.Text = "�����:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel1.Location = New System.Drawing.Point(225, 92)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(47, 24)
        Me.KryptonLabel1.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonLabel1.TabIndex = 8
        Me.KryptonLabel1.Values.Text = "������:"
        '
        'iVendor
        '
        Me.iVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.iVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.iVendor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.iVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVendor.FormattingEnabled = True
        Me.iVendor.Location = New System.Drawing.Point(30, 3)
        Me.iVendor.Name = "iVendor"
        Me.iVendor.Size = New System.Drawing.Size(189, 24)
        Me.iVendor.TabIndex = 0
        Me.iVendor.TabStop = False
        '
        'KryptonLabel36
        '
        Me.KryptonLabel36.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonLabel36.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel36.Location = New System.Drawing.Point(225, 7)
        Me.KryptonLabel36.Name = "KryptonLabel36"
        Me.KryptonLabel36.Size = New System.Drawing.Size(51, 20)
        Me.KryptonLabel36.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonLabel36.TabIndex = 6
        Me.KryptonLabel36.Values.Text = "������:"
        '
        'KryptonLabel55
        '
        Me.KryptonLabel55.Dock = System.Windows.Forms.DockStyle.Right
        Me.KryptonLabel55.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel55.Location = New System.Drawing.Point(225, 33)
        Me.KryptonLabel55.Name = "KryptonLabel55"
        Me.KryptonLabel55.Size = New System.Drawing.Size(50, 24)
        Me.KryptonLabel55.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonLabel55.TabIndex = 4
        Me.KryptonLabel55.Values.Text = "��������:"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(222, 89)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel3.TabIndex = 5
        '
        'iSerial
        '
        Me.iSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.iSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.iSerial.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.iSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iSerial.FormattingEnabled = True
        Me.iSerial.Location = New System.Drawing.Point(30, 33)
        Me.iSerial.Name = "iSerial"
        Me.iSerial.Size = New System.Drawing.Size(189, 24)
        Me.iSerial.TabIndex = 1
        Me.iSerial.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(99, 63)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDown1.TabIndex = 2
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown2.Location = New System.Drawing.Point(99, 92)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDown2.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.btnPrintBadge)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(27, 292)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(195, 50)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'btnPrintBadge
        '
        Me.btnPrintBadge.ImageOptions.Image = CType(resources.GetObject("btnPrintBadge.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintBadge.Location = New System.Drawing.Point(3, 16)
        Me.btnPrintBadge.Name = "btnPrintBadge"
        Me.btnPrintBadge.Size = New System.Drawing.Size(189, 31)
        Me.btnPrintBadge.TabIndex = 0
        Me.btnPrintBadge.Text = "�����  ����"
        '
        'cbPrinters
        '
        Me.cbPrinters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPrinters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrinters.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbPrinters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPrinters.FormattingEnabled = True
        Me.cbPrinters.Location = New System.Drawing.Point(3, 122)
        Me.cbPrinters.Name = "cbPrinters"
        Me.cbPrinters.Size = New System.Drawing.Size(216, 24)
        Me.cbPrinters.TabIndex = 13
        Me.cbPrinters.TabStop = False
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.Controls.Add(Me.btnClearQnty)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(27, 346)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(195, 50)
        Me.FlowLayoutPanel4.TabIndex = 12
        '
        'btnClearQnty
        '
        Me.btnClearQnty.ImageOptions.Image = CType(resources.GetObject("btnClearQnty.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClearQnty.Location = New System.Drawing.Point(3, 16)
        Me.btnClearQnty.Name = "btnClearQnty"
        Me.btnClearQnty.Size = New System.Drawing.Size(189, 31)
        Me.btnClearQnty.TabIndex = 0
        Me.btnClearQnty.Text = "��� �������"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel4.Location = New System.Drawing.Point(227, 152)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(49, 20)
        Me.KryptonLabel4.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonLabel4.TabIndex = 16
        Me.KryptonLabel4.Values.Text = "�����:"
        '
        'FlowLayoutPanel26
        '
        Me.FlowLayoutPanel26.AutoSize = True
        Me.FlowLayoutPanel26.Controls.Add(Me.btnPrintA41)
        Me.FlowLayoutPanel26.Controls.Add(Me.btnPrintA42)
        Me.FlowLayoutPanel26.Location = New System.Drawing.Point(20, 239)
        Me.FlowLayoutPanel26.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel26.Name = "FlowLayoutPanel26"
        Me.FlowLayoutPanel26.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.FlowLayoutPanel26.Size = New System.Drawing.Size(202, 50)
        Me.FlowLayoutPanel26.TabIndex = 5
        '
        'btnPrintA41
        '
        Me.btnPrintA41.ImageOptions.Image = CType(resources.GetObject("btnPrintA41.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintA41.Location = New System.Drawing.Point(104, 16)
        Me.btnPrintA41.Name = "btnPrintA41"
        Me.btnPrintA41.Size = New System.Drawing.Size(95, 31)
        Me.btnPrintA41.TabIndex = 0
        Me.btnPrintA41.Text = "1"
        '
        'btnPrintA42
        '
        Me.btnPrintA42.ImageOptions.Image = CType(resources.GetObject("btnPrintA42.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintA42.Location = New System.Drawing.Point(3, 16)
        Me.btnPrintA42.Name = "btnPrintA42"
        Me.btnPrintA42.Size = New System.Drawing.Size(95, 31)
        Me.btnPrintA42.TabIndex = 1
        Me.btnPrintA42.Text = "2"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPrintLabels1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPrintLabels2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(20, 184)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(202, 50)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'btnPrintLabels1
        '
        Me.btnPrintLabels1.ImageOptions.Image = CType(resources.GetObject("btnPrintLabels1.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintLabels1.Location = New System.Drawing.Point(104, 16)
        Me.btnPrintLabels1.Name = "btnPrintLabels1"
        Me.btnPrintLabels1.Size = New System.Drawing.Size(95, 31)
        Me.btnPrintLabels1.TabIndex = 0
        Me.btnPrintLabels1.Text = "��� 1"
        '
        'btnPrintLabels2
        '
        Me.btnPrintLabels2.ImageOptions.Image = CType(resources.GetObject("btnPrintLabels2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintLabels2.Location = New System.Drawing.Point(3, 16)
        Me.btnPrintLabels2.Name = "btnPrintLabels2"
        Me.btnPrintLabels2.Size = New System.Drawing.Size(95, 31)
        Me.btnPrintLabels2.TabIndex = 1
        Me.btnPrintLabels2.Text = "��� 2"
        '
        'iCode
        '
        Me.iCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.iCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.iCode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.iCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iCode.FormattingEnabled = True
        Me.iCode.Location = New System.Drawing.Point(30, 152)
        Me.iCode.Name = "iCode"
        Me.iCode.Size = New System.Drawing.Size(189, 24)
        Me.iCode.TabIndex = 17
        Me.iCode.TabStop = False
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver
        '
        'frmBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 443)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel13.ResumeLayout(False)
        CType(Me.iDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel10.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel26.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private WithEvents KryptonPanel10 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel55 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents FlowLayoutPanel26 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnPrintA41 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents KryptonPanel13 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents iVendor As System.Windows.Forms.ComboBox
    Friend WithEvents iSerial As System.Windows.Forms.ComboBox
    Private WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnPrintLabels1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents iDgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qnty As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Private WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnPrintBadge As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrintA42 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClearQnty As DevExpress.XtraEditors.SimpleButton
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbPrinters As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrintLabels2 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents iCode As ComboBox
End Class
