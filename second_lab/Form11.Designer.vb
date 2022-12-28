<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProfileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMemberStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.DepartmentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.ViewProfileToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem1, Me.ViewProfileToolStripMenuItem1, Me.ViewMemberStaffToolStripMenuItem})
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewToolStripMenuItem.Text = "Add new"
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewProfileToolStripMenuItem.Text = "View profile"
        '
        'AddNewToolStripMenuItem1
        '
        Me.AddNewToolStripMenuItem1.Name = "AddNewToolStripMenuItem1"
        Me.AddNewToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AddNewToolStripMenuItem1.Text = "Add new"
        '
        'ViewProfileToolStripMenuItem1
        '
        Me.ViewProfileToolStripMenuItem1.Name = "ViewProfileToolStripMenuItem1"
        Me.ViewProfileToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ViewProfileToolStripMenuItem1.Text = "View profile"
        '
        'ViewMemberStaffToolStripMenuItem
        '
        Me.ViewMemberStaffToolStripMenuItem.Name = "ViewMemberStaffToolStripMenuItem"
        Me.ViewMemberStaffToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewMemberStaffToolStripMenuItem.Text = "View member staff"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form11"
        Me.Text = "Form11"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewProfileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewMemberStaffToolStripMenuItem As ToolStripMenuItem
End Class
