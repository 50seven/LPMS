<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainmenu))
        Me.pbx_logo = New System.Windows.Forms.PictureBox()
        Me.btn_continue = New System.Windows.Forms.Button()
        Me.btn_newleague = New System.Windows.Forms.Button()
        Me.btn_loadleague = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_options = New System.Windows.Forms.Button()
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbx_logo
        '
        Me.pbx_logo.Image = CType(resources.GetObject("pbx_logo.Image"), System.Drawing.Image)
        Me.pbx_logo.Location = New System.Drawing.Point(586, 180)
        Me.pbx_logo.Name = "pbx_logo"
        Me.pbx_logo.Size = New System.Drawing.Size(333, 343)
        Me.pbx_logo.TabIndex = 0
        Me.pbx_logo.TabStop = False
        '
        'btn_continue
        '
        Me.btn_continue.Location = New System.Drawing.Point(587, 367)
        Me.btn_continue.Name = "btn_continue"
        Me.btn_continue.Size = New System.Drawing.Size(191, 40)
        Me.btn_continue.TabIndex = 1
        Me.btn_continue.Text = "Continue"
        Me.btn_continue.UseVisualStyleBackColor = True
        '
        'btn_newleague
        '
        Me.btn_newleague.Location = New System.Drawing.Point(587, 413)
        Me.btn_newleague.Name = "btn_newleague"
        Me.btn_newleague.Size = New System.Drawing.Size(191, 40)
        Me.btn_newleague.TabIndex = 2
        Me.btn_newleague.Text = "Create New League"
        Me.btn_newleague.UseVisualStyleBackColor = True
        '
        'btn_loadleague
        '
        Me.btn_loadleague.Location = New System.Drawing.Point(587, 459)
        Me.btn_loadleague.Name = "btn_loadleague"
        Me.btn_loadleague.Size = New System.Drawing.Size(191, 40)
        Me.btn_loadleague.TabIndex = 3
        Me.btn_loadleague.Text = "Load League"
        Me.btn_loadleague.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(587, 596)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(191, 40)
        Me.btn_exit.TabIndex = 4
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_options
        '
        Me.btn_options.Location = New System.Drawing.Point(587, 505)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Size = New System.Drawing.Size(191, 40)
        Me.btn_options.TabIndex = 5
        Me.btn_options.Text = "Options"
        Me.btn_options.UseVisualStyleBackColor = True
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 786)
        Me.Controls.Add(Me.btn_options)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_loadleague)
        Me.Controls.Add(Me.btn_newleague)
        Me.Controls.Add(Me.btn_continue)
        Me.Controls.Add(Me.pbx_logo)
        Me.Name = "mainmenu"
        Me.Text = "League Prediction & Management System"
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbx_logo As PictureBox
    Friend WithEvents btn_continue As Button
    Friend WithEvents btn_newleague As Button
    Friend WithEvents btn_loadleague As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_options As Button
End Class
