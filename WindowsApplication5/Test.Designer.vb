<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Me.txtTestDisplay = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtTestDisplay2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtTestDisplay
        '
        Me.txtTestDisplay.Location = New System.Drawing.Point(34, 21)
        Me.txtTestDisplay.Name = "txtTestDisplay"
        Me.txtTestDisplay.Size = New System.Drawing.Size(212, 20)
        Me.txtTestDisplay.TabIndex = 0
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(109, 86)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(76, 31)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtTestDisplay2
        '
        Me.txtTestDisplay2.Location = New System.Drawing.Point(34, 158)
        Me.txtTestDisplay2.Name = "txtTestDisplay2"
        Me.txtTestDisplay2.Size = New System.Drawing.Size(212, 20)
        Me.txtTestDisplay2.TabIndex = 2
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtTestDisplay2)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtTestDisplay)
        Me.Name = "Test"
        Me.Text = "Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTestDisplay As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtTestDisplay2 As TextBox
End Class
