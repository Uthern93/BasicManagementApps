<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ItemNameLabel As System.Windows.Forms.Label
        Dim ItemCodeLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeFontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSlide = New System.Windows.Forms.Button()
        Me.SideBar = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnStock = New System.Windows.Forms.Button()
        Me.BtnHomepage = New System.Windows.Forms.Button()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoopMartDataSet = New Project2.CoopMartDataSet()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.TblProductTableAdapter = New Project2.CoopMartDataSetTableAdapters.tblProductTableAdapter()
        Me.TableAdapterManager = New Project2.CoopMartDataSetTableAdapters.TableAdapterManager()
        Me.TblProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        ItemNameLabel = New System.Windows.Forms.Label()
        ItemCodeLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SideBar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoopMartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblProductBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemNameLabel
        '
        ItemNameLabel.AutoSize = True
        ItemNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemNameLabel.Location = New System.Drawing.Point(48, 44)
        ItemNameLabel.Name = "ItemNameLabel"
        ItemNameLabel.Size = New System.Drawing.Size(105, 20)
        ItemNameLabel.TabIndex = 0
        ItemNameLabel.Text = "Item Name:"
        '
        'ItemCodeLabel
        '
        ItemCodeLabel.AutoSize = True
        ItemCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        ItemCodeLabel.Location = New System.Drawing.Point(48, 80)
        ItemCodeLabel.Name = "ItemCodeLabel"
        ItemCodeLabel.Size = New System.Drawing.Size(100, 20)
        ItemCodeLabel.TabIndex = 2
        ItemCodeLabel.Text = "Item Code:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        PriceLabel.Location = New System.Drawing.Point(48, 121)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(59, 20)
        PriceLabel.TabIndex = 4
        PriceLabel.Text = "Price:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        QtyLabel.Location = New System.Drawing.Point(48, 162)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(44, 20)
        QtyLabel.TabIndex = 6
        QtyLabel.Text = "Qty:"
        '
        'Timer1
        '
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Picture1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(220, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1112, 89)
        Me.Panel3.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1020, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ADMIN"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Project2.My.Resources.Resources.AdminS
        Me.PictureBox2.Location = New System.Drawing.Point(965, 33)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 57)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "ADMIN"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Picture1.Image = Global.Project2.My.Resources.Resources.Logo_Coop
        Me.Picture1.Location = New System.Drawing.Point(71, 33)
        Me.Picture1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(108, 49)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture1.TabIndex = 0
        Me.Picture1.TabStop = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ChangeBackgroundColorToolStripMenuItem
        '
        Me.ChangeBackgroundColorToolStripMenuItem.Name = "ChangeBackgroundColorToolStripMenuItem"
        Me.ChangeBackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ChangeBackgroundColorToolStripMenuItem.Text = "Change Background Color"
        '
        'ChangeFontColorToolStripMenuItem
        '
        Me.ChangeFontColorToolStripMenuItem.Name = "ChangeFontColorToolStripMenuItem"
        Me.ChangeFontColorToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ChangeFontColorToolStripMenuItem.Text = "Change Font Color"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFontColorToolStripMenuItem, Me.ChangeBackgroundColorToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(220, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tomato
        Me.Panel1.Controls.Add(Me.BtnSlide)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 89)
        Me.Panel1.TabIndex = 0
        '
        'BtnSlide
        '
        Me.BtnSlide.BackColor = System.Drawing.Color.Transparent
        Me.BtnSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSlide.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSlide.FlatAppearance.BorderSize = 0
        Me.BtnSlide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose
        Me.BtnSlide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.BtnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSlide.Image = Global.Project2.My.Resources.Resources.list
        Me.BtnSlide.Location = New System.Drawing.Point(171, 28)
        Me.BtnSlide.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSlide.Name = "BtnSlide"
        Me.BtnSlide.Size = New System.Drawing.Size(49, 61)
        Me.BtnSlide.TabIndex = 0
        Me.BtnSlide.UseVisualStyleBackColor = False
        '
        'SideBar
        '
        Me.SideBar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SideBar.Controls.Add(Me.BtnLogout)
        Me.SideBar.Controls.Add(Me.BtnStock)
        Me.SideBar.Controls.Add(Me.BtnHomepage)
        Me.SideBar.Controls.Add(Me.BtnAccount)
        Me.SideBar.Controls.Add(Me.Panel1)
        Me.SideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBar.Location = New System.Drawing.Point(0, 0)
        Me.SideBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.Size = New System.Drawing.Size(220, 747)
        Me.SideBar.TabIndex = 16
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Silver
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.Location = New System.Drawing.Point(43, 638)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(108, 34)
        Me.BtnLogout.TabIndex = 4
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnStock
        '
        Me.BtnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStock.FlatAppearance.BorderSize = 0
        Me.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStock.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStock.ForeColor = System.Drawing.Color.DarkSalmon
        Me.BtnStock.Image = Global.Project2.My.Resources.Resources.Stocks
        Me.BtnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStock.Location = New System.Drawing.Point(11, 338)
        Me.BtnStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStock.Name = "BtnStock"
        Me.BtnStock.Size = New System.Drawing.Size(197, 71)
        Me.BtnStock.TabIndex = 3
        Me.BtnStock.Text = "      Werehouse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Stocks"
        Me.BtnStock.UseVisualStyleBackColor = True
        '
        'BtnHomepage
        '
        Me.BtnHomepage.BackColor = System.Drawing.Color.Transparent
        Me.BtnHomepage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHomepage.FlatAppearance.BorderSize = 0
        Me.BtnHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHomepage.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHomepage.ForeColor = System.Drawing.Color.DarkSalmon
        Me.BtnHomepage.Image = Global.Project2.My.Resources.Resources.home
        Me.BtnHomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHomepage.Location = New System.Drawing.Point(11, 250)
        Me.BtnHomepage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHomepage.Name = "BtnHomepage"
        Me.BtnHomepage.Size = New System.Drawing.Size(197, 71)
        Me.BtnHomepage.TabIndex = 2
        Me.BtnHomepage.Text = "     Home Page"
        Me.BtnHomepage.UseVisualStyleBackColor = False
        '
        'BtnAccount
        '
        Me.BtnAccount.BackColor = System.Drawing.Color.Transparent
        Me.BtnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAccount.FlatAppearance.BorderSize = 0
        Me.BtnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccount.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccount.ForeColor = System.Drawing.Color.DarkSalmon
        Me.BtnAccount.Image = Global.Project2.My.Resources.Resources.user
        Me.BtnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAccount.Location = New System.Drawing.Point(11, 160)
        Me.BtnAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(200, 71)
        Me.BtnAccount.TabIndex = 1
        Me.BtnAccount.Text = "     Manage User Account"
        Me.BtnAccount.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(414, 160)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(717, 362)
        Me.DataGridView1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(684, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Werehouse Stocks"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources.Stocks
        Me.PictureBox1.Location = New System.Drawing.Point(629, 111)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 45)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.BtnLoad)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1332, 747)
        Me.Panel2.TabIndex = 21
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Silver
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(988, 667)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(144, 34)
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "Delete Item"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Silver
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUpdate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(988, 612)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(144, 34)
        Me.BtnUpdate.TabIndex = 21
        Me.BtnUpdate.Text = "Update Item"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Silver
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(988, 557)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 34)
        Me.BtnSave.TabIndex = 20
        Me.BtnSave.Text = "Save Item"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(QtyLabel)
        Me.GroupBox1.Controls.Add(Me.QtyTextBox)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(ItemCodeLabel)
        Me.GroupBox1.Controls.Add(Me.ItemCodeTextBox)
        Me.GroupBox1.Controls.Add(ItemNameLabel)
        Me.GroupBox1.Controls.Add(Me.ItemNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(414, 528)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(564, 193)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Detail"
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(188, 161)
        Me.QtyTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 22)
        Me.QtyTextBox.TabIndex = 7
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.CoopMartDataSet
        '
        'CoopMartDataSet
        '
        Me.CoopMartDataSet.DataSetName = "CoopMartDataSet"
        Me.CoopMartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(188, 119)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(155, 22)
        Me.PriceTextBox.TabIndex = 5
        '
        'ItemCodeTextBox
        '
        Me.ItemCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductBindingSource, "ItemCode", True))
        Me.ItemCodeTextBox.Location = New System.Drawing.Point(188, 80)
        Me.ItemCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ItemCodeTextBox.Name = "ItemCodeTextBox"
        Me.ItemCodeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ItemCodeTextBox.TabIndex = 3
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductBindingSource, "ItemName", True))
        Me.ItemNameTextBox.Location = New System.Drawing.Point(188, 44)
        Me.ItemNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(348, 22)
        Me.ItemNameTextBox.TabIndex = 1
        '
        'BtnLoad
        '
        Me.BtnLoad.BackColor = System.Drawing.Color.Silver
        Me.BtnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoad.FlatAppearance.BorderSize = 0
        Me.BtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLoad.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLoad.Location = New System.Drawing.Point(1160, 338)
        Me.BtnLoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(151, 34)
        Me.BtnLoad.TabIndex = 5
        Me.BtnLoad.Text = "Load Record"
        Me.BtnLoad.UseVisualStyleBackColor = False
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAdminTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblProductTableAdapter = Me.TblProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project2.CoopMartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblProductBindingNavigator
        '
        Me.TblProductBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblProductBindingNavigator.BindingSource = Me.TblProductBindingSource
        Me.TblProductBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblProductBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblProductBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TblProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblProductBindingNavigatorSaveItem})
        Me.TblProductBindingNavigator.Location = New System.Drawing.Point(220, 89)
        Me.TblProductBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblProductBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblProductBindingNavigator.Name = "TblProductBindingNavigator"
        Me.TblProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblProductBindingNavigator.Size = New System.Drawing.Size(1112, 27)
        Me.TblProductBindingNavigator.TabIndex = 22
        Me.TblProductBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TblProductBindingNavigatorSaveItem
        '
        Me.TblProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblProductBindingNavigatorSaveItem.Name = "TblProductBindingNavigatorSaveItem"
        Me.TblProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.TblProductBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1332, 747)
        Me.Controls.Add(Me.TblProductBindingNavigator)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SideBar)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1350, 794)
        Me.MinimumSize = New System.Drawing.Size(1350, 794)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SideBar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoopMartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblProductBindingNavigator.ResumeLayout(False)
        Me.TblProductBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSlide As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnStock As Button
    Friend WithEvents BtnHomepage As Button
    Friend WithEvents Picture1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Panel3 As Panel
    Public WithEvents SideBar As Panel
    Friend WithEvents BtnAccount As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeFontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnLoad As Button
    Friend WithEvents TblProductBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents TblProductBindingSource As BindingSource
    Friend WithEvents CoopMartDataSet As CoopMartDataSet
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblProductBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TblProductTableAdapter As CoopMartDataSetTableAdapters.tblProductTableAdapter
    Friend WithEvents TableAdapterManager As CoopMartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents QtyTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ItemCodeTextBox As TextBox
    Friend WithEvents ItemNameTextBox As TextBox
End Class
