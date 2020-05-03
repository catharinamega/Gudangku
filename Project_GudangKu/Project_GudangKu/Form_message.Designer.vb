<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_message
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.l_mess = New System.Windows.Forms.Label()
        Me.btn_yes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Capture
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_yes)
        Me.Panel1.Controls.Add(Me.l_mess)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 156)
        Me.Panel1.TabIndex = 0
        '
        'l_mess
        '
        Me.l_mess.BackColor = System.Drawing.Color.Transparent
        Me.l_mess.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_mess.Location = New System.Drawing.Point(10, 26)
        Me.l_mess.Name = "l_mess"
        Me.l_mess.Size = New System.Drawing.Size(360, 77)
        Me.l_mess.TabIndex = 0
        Me.l_mess.Text = "<Pesan>"
        Me.l_mess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_yes
        '
        Me.btn_yes.BackColor = System.Drawing.Color.Black
        Me.btn_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_yes.ForeColor = System.Drawing.Color.White
        Me.btn_yes.Location = New System.Drawing.Point(59, 106)
        Me.btn_yes.Name = "btn_yes"
        Me.btn_yes.Size = New System.Drawing.Size(75, 41)
        Me.btn_yes.TabIndex = 1
        Me.btn_yes.Text = "IYA"
        Me.btn_yes.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(241, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "TIDAK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form_message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_message"
        Me.Text = "Form_message"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_yes As Button
    Friend WithEvents l_mess As Label
End Class
