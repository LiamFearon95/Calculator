<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txtTextBox = New System.Windows.Forms.TextBox()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.txtTextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtTextBox
        '
        Me.txtTextBox.Location = New System.Drawing.Point(12, 12)
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.Size = New System.Drawing.Size(216, 20)
        Me.txtTextBox.TabIndex = 1
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(76, 66)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(88, 27)
        Me.btnPush.TabIndex = 2
        Me.btnPush.Text = "="
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'txtTextBox2
        '
        Me.txtTextBox2.Location = New System.Drawing.Point(12, 38)
        Me.txtTextBox2.Name = "txtTextBox2"
        Me.txtTextBox2.Size = New System.Drawing.Size(216, 20)
        Me.txtTextBox2.TabIndex = 4
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 98)
        Me.Controls.Add(Me.txtTextBox2)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.txtTextBox)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTextBox As TextBox
    Friend WithEvents btnPush As Button
    Friend WithEvents txtTextBox2 As TextBox
End Class
