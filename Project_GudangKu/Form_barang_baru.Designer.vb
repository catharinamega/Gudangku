<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_barang_baru
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.l_jud = New System.Windows.Forms.Label()
        Me.panel_tanggal = New System.Windows.Forms.Panel()
        Me.l1 = New System.Windows.Forms.Label()
        Me.tb_mon = New System.Windows.Forms.TextBox()
        Me.tb_year = New System.Windows.Forms.TextBox()
        Me.tb_day = New System.Windows.Forms.TextBox()
        Me.Waktu = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_kode = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_satuan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RB_bisagunakan = New System.Windows.Forms.RadioButton()
        Me.RB_tidakdigunakan = New System.Windows.Forms.RadioButton()
        Me.bt_ok_ubah = New System.Windows.Forms.Button()
        Me.btn_daf_del = New System.Windows.Forms.Button()
        Me.panel_menu.SuspendLayout()
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
        Me.panel_menu.TabIndex = 2
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
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.Control
        Me.btn_back.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Grey_and_Neon_Green_House_Home_Furnishing_Logo__3_
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_back.Location = New System.Drawing.Point(12, 36)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(62, 57)
        Me.btn_back.TabIndex = 3
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'l_jud
        '
        Me.l_jud.BackColor = System.Drawing.Color.Transparent
        Me.l_jud.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_jud.Location = New System.Drawing.Point(116, 60)
        Me.l_jud.Name = "l_jud"
        Me.l_jud.Size = New System.Drawing.Size(409, 33)
        Me.l_jud.TabIndex = 4
        Me.l_jud.Text = "<JUDUL>"
        '
        'panel_tanggal
        '
        Me.panel_tanggal.BackColor = System.Drawing.Color.Transparent
        Me.panel_tanggal.Controls.Add(Me.l1)
        Me.panel_tanggal.Controls.Add(Me.tb_mon)
        Me.panel_tanggal.Controls.Add(Me.tb_year)
        Me.panel_tanggal.Controls.Add(Me.tb_day)
        Me.panel_tanggal.Location = New System.Drawing.Point(174, 117)
        Me.panel_tanggal.Name = "panel_tanggal"
        Me.panel_tanggal.Size = New System.Drawing.Size(409, 80)
        Me.panel_tanggal.TabIndex = 8
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
        'Waktu
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kode"
        '
        'tb_kode
        '
        Me.tb_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kode.Location = New System.Drawing.Point(227, 272)
        Me.tb_kode.Name = "tb_kode"
        Me.tb_kode.Size = New System.Drawing.Size(391, 35)
        Me.tb_kode.TabIndex = 10
        '
        'tb_nama
        '
        Me.tb_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nama.Location = New System.Drawing.Point(227, 327)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(391, 35)
        Me.tb_nama.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Satuan"
        '
        'cb_satuan
        '
        Me.cb_satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_satuan.FormattingEnabled = True
        Me.cb_satuan.Location = New System.Drawing.Point(227, 385)
        Me.cb_satuan.Name = "cb_satuan"
        Me.cb_satuan.Size = New System.Drawing.Size(225, 37)
        Me.cb_satuan.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Status"
        '
        'RB_bisagunakan
        '
        Me.RB_bisagunakan.AutoSize = True
        Me.RB_bisagunakan.BackColor = System.Drawing.Color.Transparent
        Me.RB_bisagunakan.Checked = True
        Me.RB_bisagunakan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_bisagunakan.Location = New System.Drawing.Point(227, 438)
        Me.RB_bisagunakan.Name = "RB_bisagunakan"
        Me.RB_bisagunakan.Size = New System.Drawing.Size(128, 33)
        Me.RB_bisagunakan.TabIndex = 16
        Me.RB_bisagunakan.TabStop = True
        Me.RB_bisagunakan.Text = "Tersedia"
        Me.RB_bisagunakan.UseVisualStyleBackColor = False
        '
        'RB_tidakdigunakan
        '
        Me.RB_tidakdigunakan.AutoSize = True
        Me.RB_tidakdigunakan.BackColor = System.Drawing.Color.Transparent
        Me.RB_tidakdigunakan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_tidakdigunakan.Location = New System.Drawing.Point(423, 438)
        Me.RB_tidakdigunakan.Name = "RB_tidakdigunakan"
        Me.RB_tidakdigunakan.Size = New System.Drawing.Size(195, 33)
        Me.RB_tidakdigunakan.TabIndex = 17
        Me.RB_tidakdigunakan.Text = "Tidak Tersedia"
        Me.RB_tidakdigunakan.UseVisualStyleBackColor = False
        '
        'bt_ok_ubah
        '
        Me.bt_ok_ubah.BackColor = System.Drawing.Color.Black
        Me.bt_ok_ubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ok_ubah.ForeColor = System.Drawing.Color.White
        Me.bt_ok_ubah.Location = New System.Drawing.Point(227, 518)
        Me.bt_ok_ubah.Name = "bt_ok_ubah"
        Me.bt_ok_ubah.Size = New System.Drawing.Size(316, 47)
        Me.bt_ok_ubah.TabIndex = 18
        Me.bt_ok_ubah.Text = "OKE"
        Me.bt_ok_ubah.UseVisualStyleBackColor = False
        '
        'btn_daf_del
        '
        Me.btn_daf_del.BackColor = System.Drawing.Color.Indigo
        Me.btn_daf_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_daf_del.ForeColor = System.Drawing.Color.White
        Me.btn_daf_del.Location = New System.Drawing.Point(227, 584)
        Me.btn_daf_del.Name = "btn_daf_del"
        Me.btn_daf_del.Size = New System.Drawing.Size(316, 64)
        Me.btn_daf_del.TabIndex = 19
        Me.btn_daf_del.Text = "DAFTARKAN BARANG BARU"
        Me.btn_daf_del.UseVisualStyleBackColor = False
        '
        'Form_barang_baru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Capture
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 666)
        Me.Controls.Add(Me.btn_daf_del)
        Me.Controls.Add(Me.bt_ok_ubah)
        Me.Controls.Add(Me.RB_tidakdigunakan)
        Me.Controls.Add(Me.RB_bisagunakan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_satuan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_kode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_tanggal)
        Me.Controls.Add(Me.l_jud)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.panel_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_barang_baru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_barang_baru"
        Me.panel_menu.ResumeLayout(False)
        Me.panel_tanggal.ResumeLayout(False)
        Me.panel_tanggal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents l_jud As Label
    Friend WithEvents panel_tanggal As Panel
    Friend WithEvents l1 As Label
    Friend WithEvents tb_mon As TextBox
    Friend WithEvents tb_year As TextBox
    Friend WithEvents tb_day As TextBox
    Friend WithEvents Waktu As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_kode As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_satuan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RB_bisagunakan As RadioButton
    Friend WithEvents RB_tidakdigunakan As RadioButton
    Friend WithEvents bt_ok_ubah As Button
    Friend WithEvents btn_daf_del As Button
End Class
