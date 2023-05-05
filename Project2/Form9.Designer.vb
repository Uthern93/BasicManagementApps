<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSlide = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeFontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SideBar = New System.Windows.Forms.Panel()
        Me.BtnStock = New System.Windows.Forms.Button()
        Me.BtnHomepage = New System.Windows.Forms.Button()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CoopMartDataSet = New Project2.CoopMartDataSet()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomerTableAdapter = New Project2.CoopMartDataSetTableAdapters.tblCustomerTableAdapter()
        Me.TableAdapterManager = New Project2.CoopMartDataSetTableAdapters.TableAdapterManager()
        Me.TblCustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblCustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoopMartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblCustomerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1030, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ADMIN"
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
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(108, 35)
        Me.BtnLogout.TabIndex = 4
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(683, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Manage User Account"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tomato
        Me.Panel1.Controls.Add(Me.BtnSlide)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
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
        Me.BtnSlide.Name = "BtnSlide"
        Me.BtnSlide.Size = New System.Drawing.Size(49, 61)
        Me.BtnSlide.TabIndex = 0
        Me.BtnSlide.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(220, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'ChangeFontColorToolStripMenuItem
        '
        Me.ChangeFontColorToolStripMenuItem.Name = "ChangeFontColorToolStripMenuItem"
        Me.ChangeFontColorToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ChangeFontColorToolStripMenuItem.Text = "Change Font Color"
        '
        'ChangeBackgroundColorToolStripMenuItem
        '
        Me.ChangeBackgroundColorToolStripMenuItem.Name = "ChangeBackgroundColorToolStripMenuItem"
        Me.ChangeBackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ChangeBackgroundColorToolStripMenuItem.Text = "Change Background Color"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Picture1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(220, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1113, 89)
        Me.Panel3.TabIndex = 22
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Project2.My.Resources.Resources.AdminS
        Me.PictureBox2.Location = New System.Drawing.Point(976, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 49)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "ADMIN"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Picture1.Image = Global.Project2.My.Resources.Resources.Logo_Coop
        Me.Picture1.Location = New System.Drawing.Point(81, 33)
        Me.Picture1.Margin = New System.Windows.Forms.Padding(4)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(108, 49)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture1.TabIndex = 0
        Me.Picture1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
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
        Me.SideBar.Name = "SideBar"
        Me.SideBar.Size = New System.Drawing.Size(220, 749)
        Me.SideBar.TabIndex = 21
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
        Me.BtnStock.Location = New System.Drawing.Point(10, 339)
        Me.BtnStock.Name = "BtnStock"
        Me.BtnStock.Size = New System.Drawing.Size(197, 72)
        Me.BtnStock.TabIndex = 3
        Me.BtnStock.Text = "   Werehouse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Stocks"
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
        Me.BtnHomepage.Location = New System.Drawing.Point(10, 250)
        Me.BtnHomepage.Name = "BtnHomepage"
        Me.BtnHomepage.Size = New System.Drawing.Size(197, 72)
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
        Me.BtnAccount.Location = New System.Drawing.Point(10, 160)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(200, 72)
        Me.BtnAccount.TabIndex = 1
        Me.BtnAccount.Text = "  Manage User Account"
        Me.BtnAccount.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(642, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.BtnLoad)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1333, 749)
        Me.Panel2.TabIndex = 27
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
        Me.BtnDelete.Location = New System.Drawing.Point(968, 667)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(144, 34)
        Me.BtnDelete.TabIndex = 28
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
        Me.BtnUpdate.Location = New System.Drawing.Point(968, 612)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(144, 34)
        Me.BtnUpdate.TabIndex = 27
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
        Me.BtnSave.Location = New System.Drawing.Point(968, 557)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 34)
        Me.BtnSave.TabIndex = 26
        Me.BtnSave.Text = "Save Item"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(394, 528)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(564, 212)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Detail"
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
        Me.BtnLoad.Location = New System.Drawing.Point(1140, 338)
        Me.BtnLoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(151, 34)
        Me.BtnLoad.TabIndex = 23
        Me.BtnLoad.Text = "Load Record"
        Me.BtnLoad.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(394, 160)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(717, 362)
        Me.DataGridView1.TabIndex = 24
        '
        'CoopMartDataSet
        '
        Me.CoopMartDataSet.DataSetName = "CoopMartDataSet"
        Me.CoopMartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "tblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.CoopMartDataSet
        '
        'TblCustomerTableAdapter
        '
        Me.TblCustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAdminTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Me.TblCustomerTableAdapter
        Me.TableAdapterManager.tblProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project2.CoopMartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCustomerBindingNavigator
        '
        Me.TblCustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblCustomerBindingNavigator.BindingSource = Me.TblCustomerBindingSource
        Me.TblCustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblCustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblCustomerBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TblCustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblCustomerBindingNavigatorSaveItem})
        Me.TblCustomerBindingNavigator.Location = New System.Drawing.Point(220, 89)
        Me.TblCustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblCustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblCustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblCustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblCustomerBindingNavigator.Name = "TblCustomerBindingNavigator"
        Me.TblCustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblCustomerBindingNavigator.Size = New System.Drawing.Size(1113, 29)
        Me.TblCustomerBindingNavigator.TabIndex = 28
        Me.TblCustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'TblCustomerBindingNavigatorSaveItem
        '
        Me.TblCustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblCustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblCustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblCustomerBindingNavigatorSaveItem.Name = "TblCustomerBindingNavigatorSaveItem"
        Me.TblCustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblCustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(62, 40)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(108, 20)
        FirstNameLabel.TabIndex = 0
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(202, 41)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(296, 22)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        LastNameLabel.Location = New System.Drawing.Point(64, 73)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(106, 20)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(204, 73)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(294, 22)
        Me.LastNameTextBox.TabIndex = 3
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        EmailLabel.Location = New System.Drawing.Point(64, 114)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(62, 20)
        EmailLabel.TabIndex = 4
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(204, 114)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(294, 22)
        Me.EmailTextBox.TabIndex = 5
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        PasswordLabel.Location = New System.Drawing.Point(64, 151)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(97, 20)
        PasswordLabel.TabIndex = 6
        PasswordLabel.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(204, 149)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(294, 22)
        Me.PasswordTextBox.TabIndex = 7
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 749)
        Me.Controls.Add(Me.TblCustomerBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SideBar)
        Me.Controls.Add(Me.Panel2)
        Me.MaximumSize = New System.Drawing.Size(1351, 796)
        Me.MinimumSize = New System.Drawing.Size(1351, 796)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoopMartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblCustomerBindingNavigator.ResumeLayout(False)
        Me.TblCustomerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnSlide As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnStock As Button
    Friend WithEvents BtnHomepage As Button
    Friend WithEvents BtnAccount As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Picture1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeFontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Public WithEvents SideBar As Panel
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TblCustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents TblCustomerBindingSource As BindingSource
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
    Friend WithEvents TblCustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnLoad As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblCustomerTableAdapter As CoopMartDataSetTableAdapters.tblCustomerTableAdapter
    Friend WithEvents TableAdapterManager As CoopMartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
End Class
