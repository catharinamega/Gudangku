<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Opname
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
        Me.panel_waktu = New System.Windows.Forms.Panel()
        Me.pb_1 = New System.Windows.Forms.PictureBox()
        Me.l_tim = New System.Windows.Forms.Label()
        Me.waktu = New System.Windows.Forms.Timer(Me.components)
        Me.btn_home = New System.Windows.Forms.Button()
        Me.panel_tanggal = New System.Windows.Forms.Panel()
        Me.l1 = New System.Windows.Forms.Label()
        Me.tb_mon = New System.Windows.Forms.TextBox()
        Me.tb_year = New System.Windows.Forms.TextBox()
        Me.tb_day = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.tb_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_nama = New System.Windows.Forms.ComboBox()
        Me.cb_sat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btn_masuk = New System.Windows.Forms.Button()
        Me.panel_menu.SuspendLayout()
        Me.panel_waktu.SuspendLayout()
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_tanggal.SuspendLayout()
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
        'panel_waktu
        '
        Me.panel_waktu.BackColor = System.Drawing.Color.Transparent
        Me.panel_waktu.Controls.Add(Me.pb_1)
        Me.panel_waktu.Controls.Add(Me.l_tim)
        Me.panel_waktu.Location = New System.Drawing.Point(596, 38)
        Me.panel_waktu.Name = "panel_waktu"
        Me.panel_waktu.Size = New System.Drawing.Size(200, 51)
        Me.panel_waktu.TabIndex = 2
        '
        'pb_1
        '
        Me.pb_1.Image = Global.Project_GudangKu.My.Resources.Resources.Grey_and_Neon_Green_House_Home_Furnishing_Logo__2_
        Me.pb_1.Location = New System.Drawing.Point(7, 6)
        Me.pb_1.Name = "pb_1"
        Me.pb_1.Size = New System.Drawing.Size(45, 39)
        Me.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_1.TabIndex = 8
        Me.pb_1.TabStop = False
        '
        'l_tim
        '
        Me.l_tim.BackColor = System.Drawing.Color.Transparent
        Me.l_tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_tim.ForeColor = System.Drawing.Color.White
        Me.l_tim.Location = New System.Drawing.Point(58, 14)
        Me.l_tim.Name = "l_tim"
        Me.l_tim.Size = New System.Drawing.Size(135, 25)
        Me.l_tim.TabIndex = 7
        Me.l_tim.Text = "00 : 00 : 00"
        '
        'waktu
        '
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_home.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Grey_and_Neon_Green_House_Home_Furnishing_Logo__5_
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_home.Location = New System.Drawing.Point(12, 30)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(75, 75)
        Me.btn_home.TabIndex = 19
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'panel_tanggal
        '
        Me.panel_tanggal.BackColor = System.Drawing.Color.Transparent
        Me.panel_tanggal.Controls.Add(Me.l1)
        Me.panel_tanggal.Controls.Add(Me.tb_mon)
        Me.panel_tanggal.Controls.Add(Me.tb_year)
        Me.panel_tanggal.Controls.Add(Me.tb_day)
        Me.panel_tanggal.Location = New System.Drawing.Point(179, 127)
        Me.panel_tanggal.Name = "panel_tanggal"
        Me.panel_tanggal.Size = New System.Drawing.Size(409, 80)
        Me.panel_tanggal.TabIndex = 20
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(16, 9)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(66, 20)
        Me.l1.TabIndex = 7
        Me.l1.Text = "Tanggal"
        '
        'tb_mon
        '
        Me.tb_mon.BackColor = System.Drawing.Color.White
        Me.tb_mon.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mon.Location = New System.Drawing.Point(100, 32)
        Me.tb_mon.Name = "tb_mon"
        Me.tb_mon.ReadOnly = True
        Me.tb_mon.Size = New System.Drawing.Size(216, 38)
        Me.tb_mon.TabIndex = 5
        Me.tb_mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_year
        '
        Me.tb_year.BackColor = System.Drawing.Color.White
        Me.tb_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_year.Location = New System.Drawing.Point(315, 32)
        Me.tb_year.Name = "tb_year"
        Me.tb_year.ReadOnly = True
        Me.tb_year.Size = New System.Drawing.Size(84, 38)
        Me.tb_year.TabIndex = 6
        Me.tb_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_day
        '
        Me.tb_day.BackColor = System.Drawing.Color.White
        Me.tb_day.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_day.Location = New System.Drawing.Point(20, 32)
        Me.tb_day.Name = "tb_day"
        Me.tb_day.ReadOnly = True
        Me.tb_day.Size = New System.Drawing.Size(84, 38)
        Me.tb_day.TabIndex = 4
        Me.tb_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 37)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Stok Opname"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(95, 232)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(106, 24)
        Me.l2.TabIndex = 22
        Me.l2.Text = "ID Opname"
        '
        'tb_ID
        '
        Me.tb_ID.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.tb_ID.Enabled = False
        Me.tb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ID.ForeColor = System.Drawing.Color.White
        Me.tb_ID.Location = New System.Drawing.Point(285, 229)
        Me.tb_ID.Name = "tb_ID"
        Me.tb_ID.Size = New System.Drawing.Size(298, 29)
        Me.tb_ID.TabIndex = 23
        Me.tb_ID.Text = "<ID Opname>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama"
        '
        'cb_nama
        '
        Me.cb_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_nama.FormattingEnabled = True
        Me.cb_nama.Location = New System.Drawing.Point(285, 274)
        Me.cb_nama.Name = "cb_nama"
        Me.cb_nama.Size = New System.Drawing.Size(298, 32)
        Me.cb_nama.TabIndex = 25
        '
        'cb_sat
        '
        Me.cb_sat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sat.FormattingEnabled = True
        Me.cb_sat.Location = New System.Drawing.Point(609, 274)
        Me.cb_sat.Name = "cb_sat"
        Me.cb_sat.Size = New System.Drawing.Size(127, 32)
        Me.cb_sat.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Stok Sistem"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Stok Ril"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 24)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Selisih"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 24)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Keterangan"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(285, 317)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(298, 29)
        Me.TextBox1.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(285, 362)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(298, 29)
        Me.TextBox2.TabIndex = 32
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(285, 402)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(298, 29)
        Me.TextBox3.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(145, 467)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(438, 72)
        Me.TextBox4.TabIndex = 34
        '
        'btn_masuk
        '
        Me.btn_masuk.BackColor = System.Drawing.Color.Black
        Me.btn_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_masuk.ForeColor = System.Drawing.Color.White
        Me.btn_masuk.Location = New System.Drawing.Point(251, 545)
        Me.btn_masuk.Name = "btn_masuk"
        Me.btn_masuk.Size = New System.Drawing.Size(316, 47)
        Me.btn_masuk.TabIndex = 35
        Me.btn_masuk.Text = "OKE"
        Me.btn_masuk.UseVisualStyleBackColor = False
        '
        'Form_Opname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Capture
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.btn_masuk)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_sat)
        Me.Controls.Add(Me.cb_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_ID)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_tanggal)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.panel_waktu)
        Me.Controls.Add(Me.panel_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Opname"
        Me.Text = "Form_Opname"
        Me.panel_menu.ResumeLayout(False)
        Me.panel_waktu.ResumeLayout(False)
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_tanggal.ResumeLayout(False)
        Me.panel_tanggal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents panel_waktu As Panel
    Friend WithEvents waktu As Timer
    Friend WithEvents pb_1 As PictureBox
    Friend WithEvents l_tim As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents panel_tanggal As Panel
    Friend WithEvents l1 As Label
    Friend WithEvents tb_mon As TextBox
    Friend WithEvents tb_year As TextBox
    Friend WithEvents tb_day As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents tb_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_nama As ComboBox
    Friend WithEvents cb_sat As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btn_masuk As Button
End Class
