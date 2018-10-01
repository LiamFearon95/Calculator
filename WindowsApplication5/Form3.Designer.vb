<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtDispl = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDispl2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtDispl
        '
        Me.txtDispl.Location = New System.Drawing.Point(48, 40)
        Me.txtDispl.Name = "txtDispl"
        Me.txtDispl.Size = New System.Drawing.Size(173, 20)
        Me.txtDispl.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "="
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDispl2
        '
        Me.txtDispl2.Location = New System.Drawing.Point(48, 72)
        Me.txtDispl2.Name = "txtDispl2"
        Me.txtDispl2.Size = New System.Drawing.Size(173, 20)
        Me.txtDispl2.TabIndex = 2
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtDispl2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDispl)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDispl As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDispl2 As TextBox
End Class
