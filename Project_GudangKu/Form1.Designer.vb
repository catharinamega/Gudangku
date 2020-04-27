<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_login
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
        Me.panel_menu = New System.Windows.Forms.Panel()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_max = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.pan1 = New System.Windows.Forms.Panel()
        Me.l2 = New System.Windows.Forms.Label()
        Me.tb_pass = New System.Windows.Forms.TextBox()
        Me.btn_masuk = New System.Windows.Forms.Button()
        Me.l1 = New System.Windows.Forms.Label()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.panel_menu.SuspendLayout()
        Me.pan1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_menu
        '
        Me.panel_menu.BackColor = System.Drawing.Color.White
        Me.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_menu.Controls.Add(Me.btn_min)
        Me.panel_menu.Controls.Add(Me.btn_max)
        Me.panel_menu.Controls.Add(Me.btn_close)
        Me.panel_menu.Location = New System.Drawing.Point(0, 0)
        Me.panel_menu.Name = "panel_menu"
        Me.panel_menu.Size = New System.Drawing.Size(800, 30)
        Me.panel_menu.TabIndex = 0
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.Location = New System.Drawing.Point(711, 2)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 23)
        Me.btn_min.TabIndex = 2
        Me.btn_min.Text = "-"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_max
        '
        Me.btn_max.BackColor = System.Drawing.Color.Transparent
        Me.btn_max.Location = New System.Drawing.Point(741, 2)
        Me.btn_max.Name = "btn_max"
        Me.btn_max.Size = New System.Drawing.Size(24, 23)
        Me.btn_max.TabIndex = 1
        Me.btn_max.Text = "[:]"
        Me.btn_max.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Location = New System.Drawing.Point(771, 2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(24, 23)
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "X"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'pan1
        '
        Me.pan1.Controls.Add(Me.l2)
        Me.pan1.Controls.Add(Me.tb_pass)
        Me.pan1.Controls.Add(Me.btn_masuk)
        Me.pan1.Controls.Add(Me.l1)
        Me.pan1.Controls.Add(Me.tb_user)
        Me.pan1.Location = New System.Drawing.Point(157, 196)
        Me.pan1.Name = "pan1"
        Me.pan1.Size = New System.Drawing.Size(467, 233)
        Me.pan1.TabIndex = 1
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(45, 99)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(99, 24)
        Me.l2.TabIndex = 4
        Me.l2.Text = "Kata Sandi"
        '
        'tb_pass
        '
        Me.tb_pass.BackColor = System.Drawing.Color.Thistle
        Me.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pass.Location = New System.Drawing.Point(181, 96)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.Size = New System.Drawing.Size(213, 29)
        Me.tb_pass.TabIndex = 3
        '
        'btn_masuk
        '
        Me.btn_masuk.BackColor = System.Drawing.Color.Black
        Me.btn_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_masuk.ForeColor = System.Drawing.Color.White
        Me.btn_masuk.Location = New System.Drawing.Point(78, 161)
        Me.btn_masuk.Name = "btn_masuk"
        Me.btn_masuk.Size = New System.Drawing.Size(316, 47)
        Me.btn_masuk.TabIndex = 2
        Me.btn_masuk.Text = "MASUK"
        Me.btn_masuk.UseVisualStyleBackColor = False
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(45, 53)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(120, 24)
        Me.l1.TabIndex = 1
        Me.l1.Text = "ID Pengguna"
        '
        'tb_user
        '
        Me.tb_user.BackColor = System.Drawing.Color.Thistle
        Me.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(181, 50)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(213, 29)
        Me.tb_user.TabIndex = 0
        '
        'Logo
        '
        Me.Logo.Image = Global.Project_GudangKu.My.Resources.Resources.Grey_and_Neon_Green_House_Home_Furnishing_Logo
        Me.Logo.Location = New System.Drawing.Point(300, 47)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(176, 143)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 2
        Me.Logo.TabStop = False
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Blue_Extra_Fries_Funny_Wallpaper__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.pan1)
        Me.Controls.Add(Me.panel_menu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel_menu.ResumeLayout(False)
        Me.pan1.ResumeLayout(False)
        Me.pan1.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents pan1 As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents btn_masuk As Button
    Friend WithEvents l1 As Label
    Friend WithEvents tb_user As TextBox
    Friend WithEvents l2 As Label
    Friend WithEvents tb_pass As TextBox
End Class
