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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(276, 67)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(421, 72)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(51, 17)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Label1"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(226, 126)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 22)
        Me.txt1.TabIndex = 2
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(378, 124)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "Button2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(546, 126)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(51, 17)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Label2"
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(235, 215)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 5
        Me.btn3.Text = "Button3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(390, 220)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(51, 17)
        Me.lbl3.TabIndex = 6
        Me.lbl3.Text = "Label3"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(235, 278)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 22)
        Me.txt2.TabIndex = 7
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(409, 278)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 23)
        Me.btn4.TabIndex = 8
        Me.btn4.Text = "Button4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(545, 283)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(51, 17)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents btn2 As Button
    Friend WithEvents lbl2 As Label
    Friend WithEvents btn3 As Button
    Friend WithEvents lbl3 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btn4 As Button
    Friend WithEvents lbl4 As Label
End Class
