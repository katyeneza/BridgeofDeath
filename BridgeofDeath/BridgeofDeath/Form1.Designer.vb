<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAnswer2 = New System.Windows.Forms.TextBox()
        Me.lbl4Answer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAnswer3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl6Answer = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What is your name?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(102, 179)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(98, 38)
        Me.btnAnswer.TabIndex = 2
        Me.btnAnswer.Text = "Enter Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(152, 45)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(120, 20)
        Me.txtanswer.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "What is your quest?"
        '
        'txtAnswer2
        '
        Me.txtAnswer2.Location = New System.Drawing.Point(152, 97)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.Size = New System.Drawing.Size(120, 20)
        Me.txtAnswer2.TabIndex = 5
        '
        'lbl4Answer
        '
        Me.lbl4Answer.AutoSize = True
        Me.lbl4Answer.Location = New System.Drawing.Point(61, 217)
        Me.lbl4Answer.Name = "lbl4Answer"
        Me.lbl4Answer.Size = New System.Drawing.Size(0, 13)
        Me.lbl4Answer.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "What is your favorite color?"
        '
        'txtAnswer3
        '
        Me.txtAnswer3.Location = New System.Drawing.Point(152, 142)
        Me.txtAnswer3.Name = "txtAnswer3"
        Me.txtAnswer3.Size = New System.Drawing.Size(120, 20)
        Me.txtAnswer3.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 9
        '
        'lbl6Answer
        '
        Me.lbl6Answer.AutoSize = True
        Me.lbl6Answer.Location = New System.Drawing.Point(22, 193)
        Me.lbl6Answer.Name = "lbl6Answer"
        Me.lbl6Answer.Size = New System.Drawing.Size(0, 13)
        Me.lbl6Answer.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bridge of Death"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl6Answer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAnswer3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl4Answer)
        Me.Controls.Add(Me.txtAnswer2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Bridge of Death"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl4Answer As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl6Answer As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
