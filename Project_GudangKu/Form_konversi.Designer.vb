<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_konversi
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
        Me.CoBox_besar = New System.Windows.Forms.ComboBox()
        Me.TB_Besar = New System.Windows.Forms.TextBox()
        Me.CoBox_satbesar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CoBox_satkecil = New System.Windows.Forms.ComboBox()
        Me.TB_kecil = New System.Windows.Forms.TextBox()
        Me.CoBox_Kecil = New System.Windows.Forms.ComboBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_daftar = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_table = New System.Windows.Forms.Button()
        Me.panel_menu.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Konversi Jumlah"
        '
        'CoBox_besar
        '
        Me.CoBox_besar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoBox_besar.FormattingEnabled = True
        Me.CoBox_besar.Location = New System.Drawing.Point(52, 153)
        Me.CoBox_besar.Name = "CoBox_besar"
        Me.CoBox_besar.Size = New System.Drawing.Size(253, 37)
        Me.CoBox_besar.TabIndex = 4
        '
        'TB_Besar
        '
        Me.TB_Besar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Besar.Location = New System.Drawing.Point(52, 221)
        Me.TB_Besar.Name = "TB_Besar"
        Me.TB_Besar.Size = New System.Drawing.Size(100, 35)
        Me.TB_Besar.TabIndex = 5
        '
        'CoBox_satbesar
        '
        Me.CoBox_satbesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoBox_satbesar.FormattingEnabled = True
        Me.CoBox_satbesar.Location = New System.Drawing.Point(184, 219)
        Me.CoBox_satbesar.Name = "CoBox_satbesar"
        Me.CoBox_satbesar.Size = New System.Drawing.Size(121, 37)
        Me.CoBox_satbesar.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 37)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "="
        '
        'CoBox_satkecil
        '
        Me.CoBox_satkecil.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoBox_satkecil.FormattingEnabled = True
        Me.CoBox_satkecil.Location = New System.Drawing.Point(613, 221)
        Me.CoBox_satkecil.Name = "CoBox_satkecil"
        Me.CoBox_satkecil.Size = New System.Drawing.Size(121, 37)
        Me.CoBox_satkecil.TabIndex = 10
        '
        'TB_kecil
        '
        Me.TB_kecil.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_kecil.Location = New System.Drawing.Point(481, 221)
        Me.TB_kecil.Name = "TB_kecil"
        Me.TB_kecil.Size = New System.Drawing.Size(100, 35)
        Me.TB_kecil.TabIndex = 9
        '
        'CoBox_Kecil
        '
        Me.CoBox_Kecil.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoBox_Kecil.FormattingEnabled = True
        Me.CoBox_Kecil.Location = New System.Drawing.Point(481, 155)
        Me.CoBox_Kecil.Name = "CoBox_Kecil"
        Me.CoBox_Kecil.Size = New System.Drawing.Size(253, 37)
        Me.CoBox_Kecil.TabIndex = 8
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Black
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(217, 309)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(316, 47)
        Me.btn_ok.TabIndex = 16
        Me.btn_ok.Text = "OKE"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_daftar
        '
        Me.btn_daftar.BackColor = System.Drawing.Color.Indigo
        Me.btn_daftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_daftar.ForeColor = System.Drawing.Color.White
        Me.btn_daftar.Location = New System.Drawing.Point(217, 362)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(316, 64)
        Me.btn_daftar.TabIndex = 17
        Me.btn_daftar.Text = "BUAT DATA TURUNAN BARU"
        Me.btn_daftar.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_home.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.PicsArt_04_24_02_02_39
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_home.Location = New System.Drawing.Point(12, 36)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(75, 75)
        Me.btn_home.TabIndex = 18
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'btn_table
        '
        Me.btn_table.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_table.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_table.Location = New System.Drawing.Point(712, 36)
        Me.btn_table.Name = "btn_table"
        Me.btn_table.Size = New System.Drawing.Size(75, 75)
        Me.btn_table.TabIndex = 19
        Me.btn_table.Text = "Table"
        Me.btn_table.UseVisualStyleBackColor = False
        '
        'Form_konversi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Capture
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_table)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_daftar)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.CoBox_satkecil)
        Me.Controls.Add(Me.TB_kecil)
        Me.Controls.Add(Me.CoBox_Kecil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CoBox_satbesar)
        Me.Controls.Add(Me.TB_Besar)
        Me.Controls.Add(Me.CoBox_besar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_konversi"
        Me.Text = "Form_konversi"
        Me.panel_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CoBox_besar As ComboBox
    Friend WithEvents TB_Besar As TextBox
    Friend WithEvents CoBox_satbesar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CoBox_satkecil As ComboBox
    Friend WithEvents TB_kecil As TextBox
    Friend WithEvents CoBox_Kecil As ComboBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_daftar As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_table As Button
End Class
