<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.BtnCart = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.SideBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SideBar
        '
        Me.SideBar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SideBar.Controls.Add(Me.BtnLogout)
        Me.SideBar.Controls.Add(Me.BtnConfec)
        Me.SideBar.Controls.Add(Me.BtnStation)
        Me.SideBar.Controls.Add(Me.BtnHomepage)
        Me.SideBar.Controls.Add(Me.BtnAccount)
        Me.SideBar.Controls.Add(Me.Panel1)
        Me.SideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBar.Location = New System.Drawing.Point(0, 0)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.Size = New System.Drawing.Size(220, 749)
        Me.SideBar.TabIndex = 14
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
        Me.BtnSlide.Location = New System.Drawing.Point(171, 30)
        Me.BtnSlide.Name = "BtnSlide"
        Me.BtnSlide.Size = New System.Drawing.Size(49, 59)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(220, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFontColorToolStripMenuItem, Me.ChangeBackgroundColorToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(63, 26)
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
        Me.Panel3.Controls.Add(Me.Picture1)
        Me.Panel3.Controls.Add(Me.BtnCart)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(220, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1113, 89)
        Me.Panel3.TabIndex = 15
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Picture1.Image = Global.Project2.My.Resources.Resources.Logo_Coop
        Me.Picture1.Location = New System.Drawing.Point(491, 25)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(728, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 28)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Your Cart"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(394, 183)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(783, 308)
        Me.ListBox1.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project2.My.Resources.Resources.your_cart1
        Me.PictureBox1.Location = New System.Drawing.Point(675, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
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
        Me.BtnLogout.Location = New System.Drawing.Point(49, 551)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(108, 35)
        Me.BtnLogout.TabIndex = 23
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 749)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SideBar)
        Me.MaximumSize = New System.Drawing.Size(1351, 796)
        Me.MinimumSize = New System.Drawing.Size(1351, 796)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.SideBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents SideBar As Panel
    Friend WithEvents BtnConfec As Button
    Friend WithEvents BtnStation As Button
    Friend WithEvents BtnHomepage As Button
    Friend WithEvents BtnAccount As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSlide As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeFontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Picture1 As PictureBox
    Friend WithEvents BtnCart As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnLogout As Button
End Class
