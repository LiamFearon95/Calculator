<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculatorV4
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
        Me.txtDisp = New System.Windows.Forms.TextBox()
        Me.btnNumber1 = New System.Windows.Forms.Button()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.btnNumber2 = New System.Windows.Forms.Button()
        Me.btnNumber3 = New System.Windows.Forms.Button()
        Me.btnNumber4 = New System.Windows.Forms.Button()
        Me.btnNumber5 = New System.Windows.Forms.Button()
        Me.btnNumber6 = New System.Windows.Forms.Button()
        Me.btnNumber7 = New System.Windows.Forms.Button()
        Me.btnNumber8 = New System.Windows.Forms.Button()
        Me.btnNumber9 = New System.Windows.Forms.Button()
        Me.btnNumber0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisp
        '
        Me.txtDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisp.Location = New System.Drawing.Point(12, 12)
        Me.txtDisp.Multiline = True
        Me.txtDisp.Name = "txtDisp"
        Me.txtDisp.Size = New System.Drawing.Size(378, 46)
        Me.txtDisp.TabIndex = 0
        '
        'btnNumber1
        '
        Me.btnNumber1.Location = New System.Drawing.Point(17, 179)
        Me.btnNumber1.Name = "btnNumber1"
        Me.btnNumber1.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber1.TabIndex = 1
        Me.btnNumber1.Text = "1"
        Me.btnNumber1.UseVisualStyleBackColor = True
        '
        'lblDisp
        '
        Me.lblDisp.AutoSize = True
        Me.lblDisp.BackColor = System.Drawing.Color.White
        Me.lblDisp.Location = New System.Drawing.Point(14, 15)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(0, 13)
        Me.lblDisp.TabIndex = 2
        '
        'btnNumber2
        '
        Me.btnNumber2.Location = New System.Drawing.Point(77, 179)
        Me.btnNumber2.Name = "btnNumber2"
        Me.btnNumber2.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber2.TabIndex = 3
        Me.btnNumber2.Text = "2"
        Me.btnNumber2.UseVisualStyleBackColor = True
        '
        'btnNumber3
        '
        Me.btnNumber3.Location = New System.Drawing.Point(137, 179)
        Me.btnNumber3.Name = "btnNumber3"
        Me.btnNumber3.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber3.TabIndex = 4
        Me.btnNumber3.Text = "3"
        Me.btnNumber3.UseVisualStyleBackColor = True
        '
        'btnNumber4
        '
        Me.btnNumber4.Location = New System.Drawing.Point(18, 153)
        Me.btnNumber4.Name = "btnNumber4"
        Me.btnNumber4.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber4.TabIndex = 5
        Me.btnNumber4.Text = "4"
        Me.btnNumber4.UseVisualStyleBackColor = True
        '
        'btnNumber5
        '
        Me.btnNumber5.Location = New System.Drawing.Point(78, 153)
        Me.btnNumber5.Name = "btnNumber5"
        Me.btnNumber5.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber5.TabIndex = 6
        Me.btnNumber5.Text = "5"
        Me.btnNumber5.UseVisualStyleBackColor = True
        '
        'btnNumber6
        '
        Me.btnNumber6.Location = New System.Drawing.Point(138, 153)
        Me.btnNumber6.Name = "btnNumber6"
        Me.btnNumber6.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber6.TabIndex = 7
        Me.btnNumber6.Text = "6"
        Me.btnNumber6.UseVisualStyleBackColor = True
        '
        'btnNumber7
        '
        Me.btnNumber7.Location = New System.Drawing.Point(17, 127)
        Me.btnNumber7.Name = "btnNumber7"
        Me.btnNumber7.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber7.TabIndex = 8
        Me.btnNumber7.Text = "7"
        Me.btnNumber7.UseVisualStyleBackColor = True
        '
        'btnNumber8
        '
        Me.btnNumber8.Location = New System.Drawing.Point(78, 127)
        Me.btnNumber8.Name = "btnNumber8"
        Me.btnNumber8.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber8.TabIndex = 9
        Me.btnNumber8.Text = "8"
        Me.btnNumber8.UseVisualStyleBackColor = True
        '
        'btnNumber9
        '
        Me.btnNumber9.Location = New System.Drawing.Point(138, 127)
        Me.btnNumber9.Name = "btnNumber9"
        Me.btnNumber9.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber9.TabIndex = 10
        Me.btnNumber9.Text = "9"
        Me.btnNumber9.UseVisualStyleBackColor = True
        '
        'btnNumber0
        '
        Me.btnNumber0.Location = New System.Drawing.Point(17, 205)
        Me.btnNumber0.Name = "btnNumber0"
        Me.btnNumber0.Size = New System.Drawing.Size(54, 20)
        Me.btnNumber0.TabIndex = 11
        Me.btnNumber0.Text = "0"
        Me.btnNumber0.UseVisualStyleBackColor = True
        '
        'frmCalculatorV4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 345)
        Me.Controls.Add(Me.btnNumber0)
        Me.Controls.Add(Me.btnNumber9)
        Me.Controls.Add(Me.btnNumber8)
        Me.Controls.Add(Me.btnNumber7)
        Me.Controls.Add(Me.btnNumber6)
        Me.Controls.Add(Me.btnNumber5)
        Me.Controls.Add(Me.btnNumber4)
        Me.Controls.Add(Me.btnNumber3)
        Me.Controls.Add(Me.btnNumber2)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.btnNumber1)
        Me.Controls.Add(Me.txtDisp)
        Me.Name = "frmCalculatorV4"
        Me.Text = "Calculator V4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisp As TextBox
    Friend WithEvents btnNumber1 As Button
    Friend WithEvents lblDisp As Label
    Friend WithEvents btnNumber2 As Button
    Friend WithEvents btnNumber3 As Button
    Friend WithEvents btnNumber4 As Button
    Friend WithEvents btnNumber5 As Button
    Friend WithEvents btnNumber6 As Button
    Friend WithEvents btnNumber7 As Button
    Friend WithEvents btnNumber8 As Button
    Friend WithEvents btnNumber9 As Button
    Friend WithEvents btnNumber0 As Button
End Class
