<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SideBar = New System.Windows.Forms.Panel()
        Me.BtnConfec = New System.Windows.Forms.Button()
        Me.BtnStation = New System.Windows.Forms.Button()
        Me.BtnHomepage = New System.Windows.Forms.Button()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSlide = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeFontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.BtnCart = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SideBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SideBar
        '
        Me.SideBar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SideBar.Controls.Add(Me.BtnConfec)
        Me.SideBar.Controls.Add(Me.BtnStation)
        Me.SideBar.Controls.Add(Me.BtnHomepage)
        Me.SideBar.Controls.Add(Me.BtnAccount)
        Me.SideBar.Controls.Add(Me.Panel1)
        Me.SideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBar.Location = New System.Drawing.Point(0, 0)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.Size = New System.Drawing.Size(220, 749)
        Me.SideBar.TabIndex = 12
        '
        'BtnConfec
        '
        Me.BtnConfec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfec.FlatAppearance.BorderSize = 0
        Me.BtnConfec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfec.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfec.ForeColor = System.Drawing.Color.DarkSalmon
        Me.BtnConfec.Image = Global.Project2.My.Resources.Resources.confectionery
        Me.BtnConfec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfec.Location = New System.Drawing.Point(10, 427)
        Me.BtnConfec.Name = "BtnConfec"
        Me.BtnConfec.Size = New System.Drawing.Size(197, 72)
        Me.BtnConfec.TabIndex = 4
        Me.BtnConfec.Text = "        Confectionery"
        Me.BtnConfec.UseVisualStyleBackColor = True
        '
        'BtnStation
        '
        Me.BtnStation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStation.FlatAppearance.BorderSize = 0
        Me.BtnStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStation.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStation.ForeColor = System.Drawing.Color.DarkSalmon
        Me.BtnStation.Image = Global.Project2.My.Resources.Resources.stationery
        Me.BtnStation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStation.Location = New System.Drawing.Point(10, 339)
        Me.BtnStation.Name = "BtnStation"
        Me.BtnStation.Size = New System.Drawing.Size(197, 72)
        Me.BtnStation.TabIndex = 3
        Me.BtnStation.Text = "Stationery"
        Me.BtnStation.UseVisualStyleBackColor = True
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
        Me.BtnAccount.Text = "  Account"
        Me.BtnAccount.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(568, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 39)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SELAMAT DATANG"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 473)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(959, 128)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1333, 749)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel3.Controls.Add(Me.Picture1)
        Me.Panel3.Controls.Add(Me.BtnCart)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1333, 89)
        Me.Panel3.TabIndex = 3
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Picture1.Image = Global.Project2.My.Resources.Resources.Logo_Coop
        Me.Picture1.Location = New System.Drawing.Point(263, 28)
        Me.Picture1.Margin = New System.Windows.Forms.Padding(4)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(108, 49)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture1.TabIndex = 0
        Me.Picture1.TabStop = False
        '
        'BtnCart
        '
        Me.BtnCart.BackColor = System.Drawing.Color.DarkSalmon
        Me.BtnCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCart.FlatAppearance.BorderSize = 0
        Me.BtnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCart.Image = Global.Project2.My.Resources.Resources.shopping_bag
        Me.BtnCart.Location = New System.Drawing.Point(1225, 25)
        Me.BtnCart.Name = "BtnCart"
        Me.BtnCart.Size = New System.Drawing.Size(61, 52)
        Me.BtnCart.TabIndex = 2
        Me.BtnCart.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Project2.My.Resources.Resources.coop_polimas
        Me.PictureBox2.Location = New System.Drawing.Point(263, 167)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(965, 475)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1333, 749)
        Me.Controls.Add(Me.SideBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1351, 796)
        Me.MinimumSize = New System.Drawing.Size(1351, 796)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        Me.SideBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCart As Button
    Friend WithEvents Picture1 As PictureBox
    Friend WithEvents BtnAccount As Button
    Friend WithEvents BtnConfec As Button
    Friend WithEvents BtnStation As Button
    Friend WithEvents BtnHomepage As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSlide As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeFontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Public WithEvents SideBar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
