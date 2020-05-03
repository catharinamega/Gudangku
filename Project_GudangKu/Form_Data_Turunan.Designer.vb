<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Turunan
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
        Me.panel_menu = New System.Windows.Forms.Panel()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_max = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_satuanKecil = New System.Windows.Forms.ComboBox()
        Me.TB_jumlahKecil = New System.Windows.Forms.TextBox()
        Me.CB_itemKecil = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cb_satuanBesar = New System.Windows.Forms.ComboBox()
        Me.TB_Jumlahbesar = New System.Windows.Forms.TextBox()
        Me.CB_itemBesar = New System.Windows.Forms.ComboBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_dafbar = New System.Windows.Forms.Button()
        Me.panel_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_menu
        '
        Me.panel_menu.BackColor = System.Drawing.Color.Transparent
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Turunan Barang"
        '
        'CB_satuanKecil
        '
        Me.CB_satuanKecil.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_satuanKecil.FormattingEnabled = True
        Me.CB_satuanKecil.Location = New System.Drawing.Point(595, 220)
        Me.CB_satuanKecil.Name = "CB_satuanKecil"
        Me.CB_satuanKecil.Size = New System.Drawing.Size(121, 37)
        Me.CB_satuanKecil.TabIndex = 17
        '
        'TB_jumlahKecil
        '
        Me.TB_jumlahKecil.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_jumlahKecil.Location = New System.Drawing.Point(463, 220)
        Me.TB_jumlahKecil.Name = "TB_jumlahKecil"
        Me.TB_jumlahKecil.Size = New System.Drawing.Size(100, 35)
        Me.TB_jumlahKecil.TabIndex = 16
        '
        'CB_itemKecil
        '
        Me.CB_itemKecil.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_itemKecil.FormattingEnabled = True
        Me.CB_itemKecil.Location = New System.Drawing.Point(463, 154)
        Me.CB_itemKecil.Name = "CB_itemKecil"
        Me.CB_itemKecil.Size = New System.Drawing.Size(253, 37)
        Me.CB_itemKecil.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(347, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 37)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "="
        '
        'Cb_satuanBesar
        '
        Me.Cb_satuanBesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_satuanBesar.FormattingEnabled = True
        Me.Cb_satuanBesar.Location = New System.Drawing.Point(166, 218)
        Me.Cb_satuanBesar.Name = "Cb_satuanBesar"
        Me.Cb_satuanBesar.Size = New System.Drawing.Size(121, 37)
        Me.Cb_satuanBesar.TabIndex = 13
        '
        'TB_Jumlahbesar
        '
        Me.TB_Jumlahbesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Jumlahbesar.Location = New System.Drawing.Point(34, 220)
        Me.TB_Jumlahbesar.Name = "TB_Jumlahbesar"
        Me.TB_Jumlahbesar.Size = New System.Drawing.Size(100, 35)
        Me.TB_Jumlahbesar.TabIndex = 12
        '
        'CB_itemBesar
        '
        Me.CB_itemBesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_itemBesar.FormattingEnabled = True
        Me.CB_itemBesar.Location = New System.Drawing.Point(34, 152)
        Me.CB_itemBesar.Name = "CB_itemBesar"
        Me.CB_itemBesar.Size = New System.Drawing.Size(253, 37)
        Me.CB_itemBesar.TabIndex = 11
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Grey_and_Neon_Green_House_Home_Furnishing_Logo__3_
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_back.Location = New System.Drawing.Point(12, 36)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 54)
        Me.btn_back.TabIndex = 18
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Black
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(224, 322)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(316, 47)
        Me.btn_ok.TabIndex = 19
        Me.btn_ok.Text = "OKE"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_dafbar
        '
        Me.btn_dafbar.BackColor = System.Drawing.Color.Indigo
        Me.btn_dafbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dafbar.ForeColor = System.Drawing.Color.White
        Me.btn_dafbar.Location = New System.Drawing.Point(224, 375)
        Me.btn_dafbar.Name = "btn_dafbar"
        Me.btn_dafbar.Size = New System.Drawing.Size(316, 47)
        Me.btn_dafbar.TabIndex = 20
        Me.btn_dafbar.Text = "DAFTARKAN BARANG BARU"
        Me.btn_dafbar.UseVisualStyleBackColor = False
        '
        'Form_Data_Turunan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Capture
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_dafbar)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.CB_satuanKecil)
        Me.Controls.Add(Me.TB_jumlahKecil)
        Me.Controls.Add(Me.CB_itemKecil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cb_satuanBesar)
        Me.Controls.Add(Me.TB_Jumlahbesar)
        Me.Controls.Add(Me.CB_itemBesar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Data_Turunan"
        Me.Text = "Form_Data_Turunan"
        Me.panel_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_satuanKecil As ComboBox
    Friend WithEvents TB_jumlahKecil As TextBox
    Friend WithEvents CB_itemKecil As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cb_satuanBesar As ComboBox
    Friend WithEvents TB_Jumlahbesar As TextBox
    Friend WithEvents CB_itemBesar As ComboBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_dafbar As Button
End Class
