<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IssueToolStripMenuItem, Me.RetrunToolStripMenuItem, Me.SearchBookToolStripMenuItem, Me.StudentsToolStripMenuItem, Me.RegistationToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 95)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IssueToolStripMenuItem
        '
        Me.IssueToolStripMenuItem.Image = CType(resources.GetObject("IssueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IssueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem"
        Me.IssueToolStripMenuItem.Size = New System.Drawing.Size(76, 91)
        Me.IssueToolStripMenuItem.Text = "Issue"
        Me.IssueToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IssueToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RetrunToolStripMenuItem
        '
        Me.RetrunToolStripMenuItem.Image = Global.RAD_Assigment___Library_Managment_System.My.Resources.Resources.clipart2743840
        Me.RetrunToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RetrunToolStripMenuItem.Name = "RetrunToolStripMenuItem"
        Me.RetrunToolStripMenuItem.Size = New System.Drawing.Size(76, 91)
        Me.RetrunToolStripMenuItem.Text = "Retrun"
        Me.RetrunToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RetrunToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SearchBookToolStripMenuItem
        '
        Me.SearchBookToolStripMenuItem.Image = Global.RAD_Assigment___Library_Managment_System.My.Resources.Resources.clipart1271036
        Me.SearchBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchBookToolStripMenuItem.Name = "SearchBookToolStripMenuItem"
        Me.SearchBookToolStripMenuItem.Size = New System.Drawing.Size(84, 91)
        Me.SearchBookToolStripMenuItem.Text = "Search Book"
        Me.SearchBookToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SearchBookToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.BackgroundImage = Global.RAD_Assigment___Library_Managment_System.My.Resources.Resources.student
        Me.StudentsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StudentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(65, 91)
        Me.StudentsToolStripMenuItem.Text = "Students"
        Me.StudentsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StudentsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RegistationToolStripMenuItem
        '
        Me.RegistationToolStripMenuItem.BackgroundImage = Global.RAD_Assigment___Library_Managment_System.My.Resources.Resources.add_user
        Me.RegistationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RegistationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistationToolStripMenuItem.Name = "RegistationToolStripMenuItem"
        Me.RegistationToolStripMenuItem.Size = New System.Drawing.Size(78, 91)
        Me.RegistationToolStripMenuItem.Text = "Registation"
        Me.RegistationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RegistationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.RAD_Assigment___Library_Managment_System.My.Resources.Resources.logout__1_
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(76, 91)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 478)
        Me.Panel1.TabIndex = 3
        '
        'MDI_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 573)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Managment System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IssueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetrunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
