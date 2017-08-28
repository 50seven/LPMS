<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loading0
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
        Me.pgb_programload = New System.Windows.Forms.ProgressBar()
        Me.lbl_loading = New System.Windows.Forms.Label()
        Me.tmr_load = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pgb_programload
        '
        Me.pgb_programload.Location = New System.Drawing.Point(474, 423)
        Me.pgb_programload.Name = "pgb_programload"
        Me.pgb_programload.Size = New System.Drawing.Size(417, 23)
        Me.pgb_programload.TabIndex = 0
        '
        'lbl_loading
        '
        Me.lbl_loading.AutoSize = True
        Me.lbl_loading.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_loading.Location = New System.Drawing.Point(653, 404)
        Me.lbl_loading.Name = "lbl_loading"
        Me.lbl_loading.Size = New System.Drawing.Size(59, 17)
        Me.lbl_loading.TabIndex = 1
        Me.lbl_loading.Text = "Loading"
        '
        'tmr_load
        '
        '
        'loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 786)
        Me.Controls.Add(Me.lbl_loading)
        Me.Controls.Add(Me.pgb_programload)
        Me.Name = "loading"
        Me.Text = "League Prediction & Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pgb_programload As ProgressBar
    Friend WithEvents lbl_loading As Label
    Friend WithEvents tmr_load As Timer
End Class
