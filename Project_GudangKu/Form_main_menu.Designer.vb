<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_main_menu
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
        Me.panel_menu = New System.Windows.Forms.Panel()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_max = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.pan_back = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_dbk = New System.Windows.Forms.Button()
        Me.bt_dbm = New System.Windows.Forms.Button()
        Me.l1 = New System.Windows.Forms.Label()
        Me.bt_keluar = New System.Windows.Forms.Button()
        Me.waktu = New System.Windows.Forms.Timer(Me.components)
        Me.l_tim = New System.Windows.Forms.Label()
        Me.pb_1 = New System.Windows.Forms.PictureBox()
        Me.panel_menu.SuspendLayout()
        Me.pan_back.SuspendLayout()
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel_menu.TabIndex = 1
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
        'pan_back
        '
        Me.pan_back.Controls.Add(Me.Button5)
        Me.pan_back.Controls.Add(Me.Button4)
        Me.pan_back.Controls.Add(Me.Button3)
        Me.pan_back.Controls.Add(Me.Button2)
        Me.pan_back.Controls.Add(Me.btn_dbk)
        Me.pan_back.Controls.Add(Me.bt_dbm)
        Me.pan_back.Location = New System.Drawing.Point(62, 96)
        Me.pan_back.Name = "pan_back"
        Me.pan_back.Size = New System.Drawing.Size(684, 299)
        Me.pan_back.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(392, 215)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(261, 60)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Ubah/Hapus Data"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(392, 121)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(261, 60)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Konversi Jumlah"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(50, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(261, 60)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Stok Opname"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(50, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(261, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Seluruh Barang"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_dbk
        '
        Me.btn_dbk.BackColor = System.Drawing.Color.White
        Me.btn_dbk.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_dbk.FlatAppearance.BorderSize = 0
        Me.btn_dbk.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dbk.Location = New System.Drawing.Point(392, 31)
        Me.btn_dbk.Name = "btn_dbk"
        Me.btn_dbk.Size = New System.Drawing.Size(256, 60)
        Me.btn_dbk.TabIndex = 1
        Me.btn_dbk.Text = "Data Barang Keluar"
        Me.btn_dbk.UseVisualStyleBackColor = False
        '
        'bt_dbm
        '
        Me.bt_dbm.BackColor = System.Drawing.Color.White
        Me.bt_dbm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bt_dbm.FlatAppearance.BorderSize = 0
        Me.bt_dbm.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_dbm.Location = New System.Drawing.Point(50, 31)
        Me.bt_dbm.Name = "bt_dbm"
        Me.bt_dbm.Size = New System.Drawing.Size(261, 60)
        Me.bt_dbm.TabIndex = 0
        Me.bt_dbm.Text = "Data Barang Masuk"
        Me.bt_dbm.UseVisualStyleBackColor = False
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.White
        Me.l1.Location = New System.Drawing.Point(392, 56)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(354, 25)
        Me.l1.TabIndex = 3
        Me.l1.Text = "Selamat Datang, <ID Pengguna>"
        '
        'bt_keluar
        '
        Me.bt_keluar.BackColor = System.Drawing.Color.MediumPurple
        Me.bt_keluar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bt_keluar.FlatAppearance.BorderSize = 0
        Me.bt_keluar.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_keluar.ForeColor = System.Drawing.Color.White
        Me.bt_keluar.Location = New System.Drawing.Point(62, 401)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(161, 39)
        Me.bt_keluar.TabIndex = 4
        Me.bt_keluar.Text = "Keluar Akun"
        Me.bt_keluar.UseVisualStyleBackColor = False
        '
        'waktu
        '
        '
        'l_tim
        '
        Me.l_tim.BackColor = System.Drawing.Color.Transparent
        Me.l_tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_tim.ForeColor = System.Drawing.Color.White
        Me.l_tim.Location = New System.Drawing.Point(611, 409)
        Me.l_tim.Name = "l_tim"
        Me.l_tim.Size = New System.Drawing.Size(135, 25)
        Me.l_tim.TabIndex = 5
        Me.l_tim.Text = "00 : 00 : 00"
        '
        'pb_1
        '
        Me.pb_1.Image = Global.Project_GudangKu.My.Resources.Resources.Grey_and_Neon_Green_House_Home_Furnishing_Logo__2_
        Me.pb_1.Location = New System.Drawing.Point(560, 401)
        Me.pb_1.Name = "pb_1"
        Me.pb_1.Size = New System.Drawing.Size(45, 39)
        Me.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_1.TabIndex = 6
        Me.pb_1.TabStop = False
        '
        'Form_main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Blue_Extra_Fries_Funny_Wallpaper__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 465)
        Me.Controls.Add(Me.pb_1)
        Me.Controls.Add(Me.l_tim)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.pan_back)
        Me.Controls.Add(Me.panel_menu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_main_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_main_menu"
        Me.panel_menu.ResumeLayout(False)
        Me.pan_back.ResumeLayout(False)
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents pan_back As Panel
    Friend WithEvents bt_dbm As Button
    Friend WithEvents l1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_dbk As Button
    Friend WithEvents bt_keluar As Button
    Friend WithEvents waktu As Timer
    Friend WithEvents l_tim As Label
    Friend WithEvents pb_1 As PictureBox
End Class
