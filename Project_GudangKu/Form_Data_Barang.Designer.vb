<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Barang
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
        Me.l_jud = New System.Windows.Forms.Label()
        Me.tb_day = New System.Windows.Forms.TextBox()
        Me.tb_mon = New System.Windows.Forms.TextBox()
        Me.tb_year = New System.Windows.Forms.TextBox()
        Me.panel_tanggal = New System.Windows.Forms.Panel()
        Me.l1 = New System.Windows.Forms.Label()
        Me.pb_1 = New System.Windows.Forms.PictureBox()
        Me.waktu = New System.Windows.Forms.Timer(Me.components)
        Me.l_tim = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cb_nama_barang = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.l2 = New System.Windows.Forms.Label()
        Me.tb_inv = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_daftar = New System.Windows.Forms.Button()
        Me.panel_menu.SuspendLayout()
        Me.panel_tanggal.SuspendLayout()
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'l_jud
        '
        Me.l_jud.AutoSize = True
        Me.l_jud.BackColor = System.Drawing.Color.Transparent
        Me.l_jud.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_jud.Location = New System.Drawing.Point(307, 70)
        Me.l_jud.Name = "l_jud"
        Me.l_jud.Size = New System.Drawing.Size(143, 33)
        Me.l_jud.TabIndex = 3
        Me.l_jud.Text = "<JUDUL>"
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
        'panel_tanggal
        '
        Me.panel_tanggal.BackColor = System.Drawing.Color.Transparent
        Me.panel_tanggal.Controls.Add(Me.l1)
        Me.panel_tanggal.Controls.Add(Me.tb_mon)
        Me.panel_tanggal.Controls.Add(Me.tb_year)
        Me.panel_tanggal.Controls.Add(Me.tb_day)
        Me.panel_tanggal.Location = New System.Drawing.Point(170, 107)
        Me.panel_tanggal.Name = "panel_tanggal"
        Me.panel_tanggal.Size = New System.Drawing.Size(409, 80)
        Me.panel_tanggal.TabIndex = 7
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
        'pb_1
        '
        Me.pb_1.Image = Global.Project_GudangKu.My.Resources.Resources.Grey_and_Neon_Green_House_Home_Furnishing_Logo__2_
        Me.pb_1.Location = New System.Drawing.Point(602, 38)
        Me.pb_1.Name = "pb_1"
        Me.pb_1.Size = New System.Drawing.Size(45, 39)
        Me.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_1.TabIndex = 8
        Me.pb_1.TabStop = False
        '
        'waktu
        '
        '
        'l_tim
        '
        Me.l_tim.BackColor = System.Drawing.Color.Transparent
        Me.l_tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_tim.ForeColor = System.Drawing.Color.White
        Me.l_tim.Location = New System.Drawing.Point(653, 45)
        Me.l_tim.Name = "l_tim"
        Me.l_tim.Size = New System.Drawing.Size(135, 25)
        Me.l_tim.TabIndex = 9
        Me.l_tim.Text = "00 : 00 : 00"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.PicsArt_04_24_02_02_39
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(0, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 62)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cb_nama_barang, Me.kode, Me.jumlah, Me.Satuan})
        Me.DataGridView1.Location = New System.Drawing.Point(69, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 307)
        Me.DataGridView1.TabIndex = 12
        '
        'cb_nama_barang
        '
        Me.cb_nama_barang.HeaderText = "Nama"
        Me.cb_nama_barang.Name = "cb_nama_barang"
        Me.cb_nama_barang.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cb_nama_barang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cb_nama_barang.Width = 200
        '
        'kode
        '
        Me.kode.HeaderText = "Kode"
        Me.kode.Name = "kode"
        Me.kode.ReadOnly = True
        Me.kode.Width = 150
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'Satuan
        '
        Me.Satuan.HeaderText = "satuan"
        Me.Satuan.Name = "Satuan"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(64, 216)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(80, 25)
        Me.l2.TabIndex = 13
        Me.l2.Text = "Invoice"
        '
        'tb_inv
        '
        Me.tb_inv.Enabled = False
        Me.tb_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_inv.Location = New System.Drawing.Point(174, 213)
        Me.tb_inv.Name = "tb_inv"
        Me.tb_inv.Size = New System.Drawing.Size(193, 31)
        Me.tb_inv.TabIndex = 14
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Black
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(230, 600)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(316, 47)
        Me.btn_ok.TabIndex = 15
        Me.btn_ok.Text = "OKE"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_daftar
        '
        Me.btn_daftar.BackColor = System.Drawing.Color.Indigo
        Me.btn_daftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_daftar.ForeColor = System.Drawing.Color.White
        Me.btn_daftar.Location = New System.Drawing.Point(230, 653)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(316, 64)
        Me.btn_daftar.TabIndex = 16
        Me.btn_daftar.Text = "DAFTARKAN BARANG BARU"
        Me.btn_daftar.UseVisualStyleBackColor = False
        '
        'Form_Data_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Capture
        Me.ClientSize = New System.Drawing.Size(800, 730)
        Me.Controls.Add(Me.btn_daftar)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.tb_inv)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.l_tim)
        Me.Controls.Add(Me.pb_1)
        Me.Controls.Add(Me.panel_tanggal)
        Me.Controls.Add(Me.l_jud)
        Me.Controls.Add(Me.panel_menu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Data_Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Data_Barang"
        Me.panel_menu.ResumeLayout(False)
        Me.panel_tanggal.ResumeLayout(False)
        Me.panel_tanggal.PerformLayout()
        CType(Me.pb_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents l_jud As Label
    Friend WithEvents tb_day As TextBox
    Friend WithEvents tb_mon As TextBox
    Friend WithEvents tb_year As TextBox
    Friend WithEvents panel_tanggal As Panel
    Friend WithEvents l1 As Label
    Friend WithEvents pb_1 As PictureBox
    Friend WithEvents waktu As Timer
    Friend WithEvents l_tim As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cb_nama_barang As DataGridViewComboBoxColumn
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Satuan As DataGridViewTextBoxColumn
    Friend WithEvents l2 As Label
    Friend WithEvents tb_inv As TextBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_daftar As Button
End Class
