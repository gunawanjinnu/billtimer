<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStatus))
        Me.TxbJam = New System.Windows.Forms.TextBox()
        Me.TxbMenit = New System.Windows.Forms.TextBox()
        Me.TxbDetik = New System.Windows.Forms.TextBox()
        Me.TxbMiliDetik = New System.Windows.Forms.TextBox()
        Me.TxbSisaWaktu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCurrentTime = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblWaktuSekarang = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnTambahWaktu = New System.Windows.Forms.Button()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxbPassword = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.CbxHargaTw = New System.Windows.Forms.ComboBox()
        Me.LblJamTw = New System.Windows.Forms.Label()
        Me.TxbJamTw = New System.Windows.Forms.TextBox()
        Me.LblMenitTw = New System.Windows.Forms.Label()
        Me.TxbMenitTw = New System.Windows.Forms.TextBox()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxbSisaDetikSaved = New System.Windows.Forms.TextBox()
        Me.LblSisaDetikSaved = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxbStartJam = New System.Windows.Forms.TextBox()
        Me.TxbStopJam = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxbJam
        '
        Me.TxbJam.Enabled = False
        Me.TxbJam.Location = New System.Drawing.Point(166, 66)
        Me.TxbJam.Name = "TxbJam"
        Me.TxbJam.Size = New System.Drawing.Size(100, 20)
        Me.TxbJam.TabIndex = 0
        '
        'TxbMenit
        '
        Me.TxbMenit.Enabled = False
        Me.TxbMenit.Location = New System.Drawing.Point(166, 88)
        Me.TxbMenit.Name = "TxbMenit"
        Me.TxbMenit.Size = New System.Drawing.Size(100, 20)
        Me.TxbMenit.TabIndex = 1
        '
        'TxbDetik
        '
        Me.TxbDetik.Enabled = False
        Me.TxbDetik.Location = New System.Drawing.Point(166, 110)
        Me.TxbDetik.Name = "TxbDetik"
        Me.TxbDetik.Size = New System.Drawing.Size(100, 20)
        Me.TxbDetik.TabIndex = 2
        '
        'TxbMiliDetik
        '
        Me.TxbMiliDetik.Enabled = False
        Me.TxbMiliDetik.Location = New System.Drawing.Point(166, 132)
        Me.TxbMiliDetik.Name = "TxbMiliDetik"
        Me.TxbMiliDetik.Size = New System.Drawing.Size(100, 20)
        Me.TxbMiliDetik.TabIndex = 3
        '
        'TxbSisaWaktu
        '
        Me.TxbSisaWaktu.Enabled = False
        Me.TxbSisaWaktu.Location = New System.Drawing.Point(166, 176)
        Me.TxbSisaWaktu.Name = "TxbSisaWaktu"
        Me.TxbSisaWaktu.Size = New System.Drawing.Size(100, 20)
        Me.TxbSisaWaktu.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = " Jam/Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Menit/Mins"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Detik/Secs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Milli Detik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sisa Waktu"
        '
        'LblCurrentTime
        '
        Me.LblCurrentTime.AutoSize = True
        Me.LblCurrentTime.BackColor = System.Drawing.Color.Transparent
        Me.LblCurrentTime.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentTime.ForeColor = System.Drawing.Color.White
        Me.LblCurrentTime.Location = New System.Drawing.Point(12, 47)
        Me.LblCurrentTime.Name = "LblCurrentTime"
        Me.LblCurrentTime.Size = New System.Drawing.Size(119, 18)
        Me.LblCurrentTime.TabIndex = 10
        Me.LblCurrentTime.Text = "Current time    :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(101, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Status"
        '
        'LblWaktuSekarang
        '
        Me.LblWaktuSekarang.BackColor = System.Drawing.Color.Transparent
        Me.LblWaktuSekarang.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaktuSekarang.Location = New System.Drawing.Point(163, 47)
        Me.LblWaktuSekarang.Name = "LblWaktuSekarang"
        Me.LblWaktuSekarang.Size = New System.Drawing.Size(101, 18)
        Me.LblWaktuSekarang.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(23, 364)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(80, 31)
        Me.BtnLogout.TabIndex = 14
        Me.BtnLogout.Text = "Log Out"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(133, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Created by: Tawan Tiroone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(164, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 23)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "DOOM.NET"
        '
        'BtnTambahWaktu
        '
        Me.BtnTambahWaktu.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahWaktu.Location = New System.Drawing.Point(16, 198)
        Me.BtnTambahWaktu.Name = "BtnTambahWaktu"
        Me.BtnTambahWaktu.Size = New System.Drawing.Size(251, 36)
        Me.BtnTambahWaktu.TabIndex = 15
        Me.BtnTambahWaktu.Text = "Tambah Waktu"
        Me.BtnTambahWaktu.UseVisualStyleBackColor = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.White
        Me.LblPassword.Location = New System.Drawing.Point(15, 237)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(69, 15)
        Me.LblPassword.TabIndex = 21
        Me.LblPassword.Text = "Password"
        '
        'TxbPassword
        '
        Me.TxbPassword.Location = New System.Drawing.Point(166, 236)
        Me.TxbPassword.Name = "TxbPassword"
        Me.TxbPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxbPassword.TabIndex = 22
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(166, 329)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(98, 24)
        Me.BtnOk.TabIndex = 23
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'CbxHargaTw
        '
        Me.CbxHargaTw.FormattingEnabled = True
        Me.CbxHargaTw.Location = New System.Drawing.Point(166, 305)
        Me.CbxHargaTw.Name = "CbxHargaTw"
        Me.CbxHargaTw.Size = New System.Drawing.Size(100, 21)
        Me.CbxHargaTw.TabIndex = 24
        '
        'LblJamTw
        '
        Me.LblJamTw.AutoSize = True
        Me.LblJamTw.BackColor = System.Drawing.Color.Transparent
        Me.LblJamTw.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJamTw.ForeColor = System.Drawing.Color.White
        Me.LblJamTw.Location = New System.Drawing.Point(10, 259)
        Me.LblJamTw.Name = "LblJamTw"
        Me.LblJamTw.Size = New System.Drawing.Size(90, 18)
        Me.LblJamTw.TabIndex = 25
        Me.LblJamTw.Text = " Jam/Hours"
        '
        'TxbJamTw
        '
        Me.TxbJamTw.Enabled = False
        Me.TxbJamTw.Location = New System.Drawing.Point(166, 259)
        Me.TxbJamTw.Name = "TxbJamTw"
        Me.TxbJamTw.Size = New System.Drawing.Size(100, 20)
        Me.TxbJamTw.TabIndex = 26
        '
        'LblMenitTw
        '
        Me.LblMenitTw.AutoSize = True
        Me.LblMenitTw.BackColor = System.Drawing.Color.Transparent
        Me.LblMenitTw.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenitTw.ForeColor = System.Drawing.Color.White
        Me.LblMenitTw.Location = New System.Drawing.Point(15, 284)
        Me.LblMenitTw.Name = "LblMenitTw"
        Me.LblMenitTw.Size = New System.Drawing.Size(85, 18)
        Me.LblMenitTw.TabIndex = 27
        Me.LblMenitTw.Text = "Menit/Mins"
        '
        'TxbMenitTw
        '
        Me.TxbMenitTw.Enabled = False
        Me.TxbMenitTw.Location = New System.Drawing.Point(166, 282)
        Me.TxbMenitTw.Name = "TxbMenitTw"
        Me.TxbMenitTw.Size = New System.Drawing.Size(100, 20)
        Me.TxbMenitTw.TabIndex = 28
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.BackColor = System.Drawing.Color.Transparent
        Me.LblHarga.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHarga.ForeColor = System.Drawing.Color.White
        Me.LblHarga.Location = New System.Drawing.Point(15, 307)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(52, 18)
        Me.LblHarga.TabIndex = 29
        Me.LblHarga.Text = "Harga"
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(23, 329)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancel.TabIndex = 30
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TxbSisaDetikSaved
        '
        Me.TxbSisaDetikSaved.Enabled = False
        Me.TxbSisaDetikSaved.Location = New System.Drawing.Point(166, 154)
        Me.TxbSisaDetikSaved.Name = "TxbSisaDetikSaved"
        Me.TxbSisaDetikSaved.Size = New System.Drawing.Size(100, 20)
        Me.TxbSisaDetikSaved.TabIndex = 32
        '
        'LblSisaDetikSaved
        '
        Me.LblSisaDetikSaved.AutoSize = True
        Me.LblSisaDetikSaved.BackColor = System.Drawing.Color.Transparent
        Me.LblSisaDetikSaved.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSisaDetikSaved.ForeColor = System.Drawing.Color.White
        Me.LblSisaDetikSaved.Location = New System.Drawing.Point(12, 156)
        Me.LblSisaDetikSaved.Name = "LblSisaDetikSaved"
        Me.LblSisaDetikSaved.Size = New System.Drawing.Size(128, 18)
        Me.LblSisaDetikSaved.TabIndex = 33
        Me.LblSisaDetikSaved.Text = "Sisa Detik Saved"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(57, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Start Jam"
        '
        'TxbStartJam
        '
        Me.TxbStartJam.Location = New System.Drawing.Point(164, 426)
        Me.TxbStartJam.Name = "TxbStartJam"
        Me.TxbStartJam.Size = New System.Drawing.Size(100, 20)
        Me.TxbStartJam.TabIndex = 35
        '
        'TxbStopJam
        '
        Me.TxbStopJam.Location = New System.Drawing.Point(164, 448)
        Me.TxbStopJam.Name = "TxbStopJam"
        Me.TxbStopJam.Size = New System.Drawing.Size(100, 20)
        Me.TxbStopJam.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(57, 451)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Stop Jam"
        '
        'FrmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 477)
        Me.Controls.Add(Me.TxbStopJam)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxbStartJam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblSisaDetikSaved)
        Me.Controls.Add(Me.TxbSisaDetikSaved)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.TxbMenitTw)
        Me.Controls.Add(Me.LblMenitTw)
        Me.Controls.Add(Me.TxbJamTw)
        Me.Controls.Add(Me.LblJamTw)
        Me.Controls.Add(Me.CbxHargaTw)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TxbPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnTambahWaktu)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.LblWaktuSekarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblCurrentTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxbSisaWaktu)
        Me.Controls.Add(Me.TxbMiliDetik)
        Me.Controls.Add(Me.TxbDetik)
        Me.Controls.Add(Me.TxbMenit)
        Me.Controls.Add(Me.TxbJam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1060, 250)
        Me.Name = "FrmStatus"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Limited"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxbJam As System.Windows.Forms.TextBox
    Friend WithEvents TxbMenit As System.Windows.Forms.TextBox
    Friend WithEvents TxbDetik As System.Windows.Forms.TextBox
    Friend WithEvents TxbMiliDetik As System.Windows.Forms.TextBox
    Friend WithEvents TxbSisaWaktu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblWaktuSekarang As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnTambahWaktu As System.Windows.Forms.Button
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxbPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents CbxHargaTw As System.Windows.Forms.ComboBox
    Friend WithEvents LblJamTw As System.Windows.Forms.Label
    Friend WithEvents TxbJamTw As System.Windows.Forms.TextBox
    Friend WithEvents LblMenitTw As System.Windows.Forms.Label
    Friend WithEvents TxbMenitTw As System.Windows.Forms.TextBox
    Friend WithEvents LblHarga As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxbSisaDetikSaved As System.Windows.Forms.TextBox
    Friend WithEvents LblSisaDetikSaved As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxbStartJam As System.Windows.Forms.TextBox
    Friend WithEvents TxbStopJam As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
