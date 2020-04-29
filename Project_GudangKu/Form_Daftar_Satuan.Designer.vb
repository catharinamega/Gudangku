<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Daftar_Satuan
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_singkatan = New System.Windows.Forms.TextBox()
        Me.TB_satuan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RB_bisagunakan = New System.Windows.Forms.RadioButton()
        Me.RB_tidakdigunakan = New System.Windows.Forms.RadioButton()
        Me.btn_ok = New System.Windows.Forms.Button()
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
        Me.panel_menu.Size = New System.Drawing.Size(625, 30)
        Me.panel_menu.TabIndex = 3
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.Location = New System.Drawing.Point(532, 2)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 23)
        Me.btn_min.TabIndex = 2
        Me.btn_min.Text = "-"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_max
        '
        Me.btn_max.BackColor = System.Drawing.Color.Transparent
        Me.btn_max.Location = New System.Drawing.Point(562, 2)
        Me.btn_max.Name = "btn_max"
        Me.btn_max.Size = New System.Drawing.Size(24, 23)
        Me.btn_max.TabIndex = 1
        Me.btn_max.Text = "[:]"
        Me.btn_max.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Location = New System.Drawing.Point(592, 2)
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
        Me.Label1.Location = New System.Drawing.Point(107, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Daftarkan Satuan Baru"
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Grey_and_Neon_Green_House_Home_Furnishing_Logo__3_
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_back.Location = New System.Drawing.Point(4, 36)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 54)
        Me.btn_back.TabIndex = 5
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Singkatan Satuan"
        '
        'TB_singkatan
        '
        Me.TB_singkatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_singkatan.Location = New System.Drawing.Point(310, 167)
        Me.TB_singkatan.Name = "TB_singkatan"
        Me.TB_singkatan.Size = New System.Drawing.Size(226, 35)
        Me.TB_singkatan.TabIndex = 7
        '
        'TB_satuan
        '
        Me.TB_satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_satuan.Location = New System.Drawing.Point(310, 224)
        Me.TB_satuan.Name = "TB_satuan"
        Me.TB_satuan.Size = New System.Drawing.Size(226, 35)
        Me.TB_satuan.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Status"
        '
        'RB_bisagunakan
        '
        Me.RB_bisagunakan.AutoSize = True
        Me.RB_bisagunakan.BackColor = System.Drawing.Color.Transparent
        Me.RB_bisagunakan.Checked = True
        Me.RB_bisagunakan.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_bisagunakan.Location = New System.Drawing.Point(98, 330)
        Me.RB_bisagunakan.Name = "RB_bisagunakan"
        Me.RB_bisagunakan.Size = New System.Drawing.Size(183, 30)
        Me.RB_bisagunakan.TabIndex = 11
        Me.RB_bisagunakan.TabStop = True
        Me.RB_bisagunakan.Text = "Bisa Digunakan"
        Me.RB_bisagunakan.UseVisualStyleBackColor = False
        '
        'RB_tidakdigunakan
        '
        Me.RB_tidakdigunakan.AutoSize = True
        Me.RB_tidakdigunakan.BackColor = System.Drawing.Color.Transparent
        Me.RB_tidakdigunakan.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_tidakdigunakan.Location = New System.Drawing.Point(310, 330)
        Me.RB_tidakdigunakan.Name = "RB_tidakdigunakan"
        Me.RB_tidakdigunakan.Size = New System.Drawing.Size(241, 30)
        Me.RB_tidakdigunakan.TabIndex = 12
        Me.RB_tidakdigunakan.Text = "Tidak Bisa Digunakan"
        Me.RB_tidakdigunakan.UseVisualStyleBackColor = False
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Black
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(136, 391)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(316, 47)
        Me.btn_ok.TabIndex = 17
        Me.btn_ok.Text = "DAFTAR"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Form_Daftar_Satuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_GudangKu.My.Resources.Resources.Capture
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(627, 464)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.RB_tidakdigunakan)
        Me.Controls.Add(Me.RB_bisagunakan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_satuan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_singkatan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Daftar_Satuan"
        Me.Text = "Form_Daftar_Satuan"
        Me.panel_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_singkatan As TextBox
    Friend WithEvents TB_satuan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RB_bisagunakan As RadioButton
    Friend WithEvents RB_tidakdigunakan As RadioButton
    Friend WithEvents btn_ok As Button
End Class
