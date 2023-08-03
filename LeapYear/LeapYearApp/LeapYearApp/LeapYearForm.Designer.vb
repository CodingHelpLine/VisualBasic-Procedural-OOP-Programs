<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LeapYearForm
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
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(11, 16)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(65, 15)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Enter Year: "
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(88, 12)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 23)
        Me.txtYear.TabIndex = 1
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(211, 3)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(75, 40)
        Me.BtnCheck.TabIndex = 2
        Me.BtnCheck.Text = "Check"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(9, 62)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(296, 376)
        Me.txtDisplay.TabIndex = 3
        '
        'LeapYearForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 450)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Name = "LeapYearForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leap Year Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblYear As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents BtnCheck As Button
    Friend WithEvents txtDisplay As TextBox
End Class
