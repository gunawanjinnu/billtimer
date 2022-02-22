<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStart))
        Me.TxbJam = New System.Windows.Forms.TextBox()
        Me.TxbMenit = New System.Windows.Forms.TextBox()
        Me.TxbDetik = New System.Windows.Forms.TextBox()
        Me.TxbMilliDetik = New System.Windows.Forms.TextBox()
        Me.TxbSisaWaktu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCurrentTime = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblWaktuSekarang = New System.Windows.Forms.Label()
        Me.TmrBilling = New System.Windows.Forms.Timer(Me.components)
        Me.TmrCurrentTime = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnKeluarDarurat = New System.Windows.Forms.Button()
        Me.CbxHarga = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxbPassword = New System.Windows.Forms.TextBox()
        Me.TxbMasterPassword = New System.Windows.Forms.TextBox()
        Me.BtnMasterKeluar = New System.Windows.Forms.Button()
        Me.BtnShutdown = New System.Windows.Forms.Button()
        Me.LblMasterPassword = New System.Windows.Forms.Label()
        Me.TmrBackupSisaWaktu = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TxbJam
        '
        Me.TxbJam.Enabled = False
        Me.TxbJam.Location = New System.Drawing.Point(739, 256)
        Me.TxbJam.Name = "TxbJam"
        Me.TxbJam.Size = New System.Drawing.Size(100, 20)
        Me.TxbJam.TabIndex = 0
        '
        'TxbMenit
        '
        Me.TxbMenit.Enabled = False
        Me.TxbMenit.Location = New System.Drawing.Point(739, 284)
        Me.TxbMenit.Name = "TxbMenit"
        Me.TxbMenit.Size = New System.Drawing.Size(100, 20)
        Me.TxbMenit.TabIndex = 1
        '
        'TxbDetik
        '
        Me.TxbDetik.Enabled = False
        Me.TxbDetik.Location = New System.Drawing.Point(739, 311)
        Me.TxbDetik.Name = "TxbDetik"
        Me.TxbDetik.Size = New System.Drawing.Size(100, 20)
        Me.TxbDetik.TabIndex = 2
        '
        'TxbMilliDetik
        '
        Me.TxbMilliDetik.Enabled = False
        Me.TxbMilliDetik.Location = New System.Drawing.Point(739, 338)
        Me.TxbMilliDetik.Name = "TxbMilliDetik"
        Me.TxbMilliDetik.Size = New System.Drawing.Size(100, 20)
        Me.TxbMilliDetik.TabIndex = 3
        '
        'TxbSisaWaktu
        '
        Me.TxbSisaWaktu.Enabled = False
        Me.TxbSisaWaktu.Location = New System.Drawing.Point(739, 365)
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
        Me.Label1.Location = New System.Drawing.Point(582, 256)
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
        Me.Label2.Location = New System.Drawing.Point(585, 284)
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
        Me.Label3.Location = New System.Drawing.Point(587, 309)
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
        Me.Label4.Location = New System.Drawing.Point(585, 339)
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
        Me.Label5.Location = New System.Drawing.Point(585, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Time Remaining"
        '
        'LblCurrentTime
        '
        Me.LblCurrentTime.AutoSize = True
        Me.LblCurrentTime.BackColor = System.Drawing.Color.Transparent
        Me.LblCurrentTime.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentTime.ForeColor = System.Drawing.Color.White
        Me.LblCurrentTime.Location = New System.Drawing.Point(1105, 138)
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
        Me.Label7.Location = New System.Drawing.Point(1166, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "DOOM.NET"
        '
        'LblWaktuSekarang
        '
        Me.LblWaktuSekarang.BackColor = System.Drawing.Color.Transparent
        Me.LblWaktuSekarang.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaktuSekarang.ForeColor = System.Drawing.Color.White
        Me.LblWaktuSekarang.Location = New System.Drawing.Point(1230, 138)
        Me.LblWaktuSekarang.Name = "LblWaktuSekarang"
        Me.LblWaktuSekarang.Size = New System.Drawing.Size(116, 18)
        Me.LblWaktuSekarang.TabIndex = 12
        '
        'TmrBilling
        '
        Me.TmrBilling.Interval = 1000
        '
        'TmrCurrentTime
        '
        Me.TmrCurrentTime.Enabled = True
        Me.TmrCurrentTime.Interval = 1000
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(585, 552)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(254, 31)
        Me.BtnLogin.TabIndex = 13
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1218, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Created by: Tawan Tiroone"
        '
        'BtnKeluarDarurat
        '
        Me.BtnKeluarDarurat.Location = New System.Drawing.Point(1301, 28)
        Me.BtnKeluarDarurat.Name = "BtnKeluarDarurat"
        Me.BtnKeluarDarurat.Size = New System.Drawing.Size(53, 23)
        Me.BtnKeluarDarurat.TabIndex = 18
        Me.BtnKeluarDarurat.Text = "X"
        Me.BtnKeluarDarurat.UseVisualStyleBackColor = True
        '
        'CbxHarga
        '
        Me.CbxHarga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbxHarga.FormattingEnabled = True
        Me.CbxHarga.Location = New System.Drawing.Point(739, 479)
        Me.CbxHarga.Name = "CbxHarga"
        Me.CbxHarga.Size = New System.Drawing.Size(100, 21)
        Me.CbxHarga.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(587, 481)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Harga                Rp. "
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.White
        Me.LblPassword.Location = New System.Drawing.Point(587, 515)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(78, 18)
        Me.LblPassword.TabIndex = 22
        Me.LblPassword.Text = "Password"
        '
        'TxbPassword
        '
        Me.TxbPassword.Location = New System.Drawing.Point(671, 515)
        Me.TxbPassword.Name = "TxbPassword"
        Me.TxbPassword.Size = New System.Drawing.Size(168, 20)
        Me.TxbPassword.TabIndex = 23
        '
        'TxbMasterPassword
        '
        Me.TxbMasterPassword.Location = New System.Drawing.Point(1254, 79)
        Me.TxbMasterPassword.Name = "TxbMasterPassword"
        Me.TxbMasterPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxbMasterPassword.TabIndex = 24
        '
        'BtnMasterKeluar
        '
        Me.BtnMasterKeluar.Location = New System.Drawing.Point(1254, 103)
        Me.BtnMasterKeluar.Name = "BtnMasterKeluar"
        Me.BtnMasterKeluar.Size = New System.Drawing.Size(100, 23)
        Me.BtnMasterKeluar.TabIndex = 25
        Me.BtnMasterKeluar.Text = "Keluar"
        Me.BtnMasterKeluar.UseVisualStyleBackColor = True
        '
        'BtnShutdown
        '
        Me.BtnShutdown.BackColor = System.Drawing.Color.Black
        Me.BtnShutdown.BackgroundImage = CType(resources.GetObject("BtnShutdown.BackgroundImage"), System.Drawing.Image)
        Me.BtnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnShutdown.ForeColor = System.Drawing.Color.Black
        Me.BtnShutdown.Location = New System.Drawing.Point(1244, 670)
        Me.BtnShutdown.Name = "BtnShutdown"
        Me.BtnShutdown.Size = New System.Drawing.Size(49, 46)
        Me.BtnShutdown.TabIndex = 26
        Me.BtnShutdown.UseVisualStyleBackColor = False
        '
        'LblMasterPassword
        '
        Me.LblMasterPassword.AutoSize = True
        Me.LblMasterPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblMasterPassword.ForeColor = System.Drawing.Color.White
        Me.LblMasterPassword.Location = New System.Drawing.Point(1254, 63)
        Me.LblMasterPassword.Name = "LblMasterPassword"
        Me.LblMasterPassword.Size = New System.Drawing.Size(88, 13)
        Me.LblMasterPassword.TabIndex = 27
        Me.LblMasterPassword.Text = "Master Password"
        Me.LblMasterPassword.Visible = False
        '
        'TmrBackupSisaWaktu
        '
        Me.TmrBackupSisaWaktu.Interval = 180000
        '
        'FrmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.LblMasterPassword)
        Me.Controls.Add(Me.BtnShutdown)
        Me.Controls.Add(Me.BtnMasterKeluar)
        Me.Controls.Add(Me.TxbMasterPassword)
        Me.Controls.Add(Me.TxbPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxHarga)
        Me.Controls.Add(Me.BtnKeluarDarurat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LblWaktuSekarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblCurrentTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxbSisaWaktu)
        Me.Controls.Add(Me.TxbMilliDetik)
        Me.Controls.Add(Me.TxbDetik)
        Me.Controls.Add(Me.TxbMenit)
        Me.Controls.Add(Me.TxbJam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1060, 250)
        Me.Name = "FrmStart"
        Me.Opacity = 0.9R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Limited"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxbJam As System.Windows.Forms.TextBox
    Friend WithEvents TxbMenit As System.Windows.Forms.TextBox
    Friend WithEvents TxbDetik As System.Windows.Forms.TextBox
    Friend WithEvents TxbMilliDetik As System.Windows.Forms.TextBox
    Friend WithEvents TxbSisaWaktu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblWaktuSekarang As System.Windows.Forms.Label
    Friend WithEvents TmrBilling As System.Windows.Forms.Timer
    Friend WithEvents TmrCurrentTime As System.Windows.Forms.Timer
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnKeluarDarurat As System.Windows.Forms.Button
    Friend WithEvents CbxHarga As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxbPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxbMasterPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnMasterKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnShutdown As System.Windows.Forms.Button
    Friend WithEvents LblMasterPassword As System.Windows.Forms.Label
    Friend WithEvents TmrBackupSisaWaktu As System.Windows.Forms.Timer
End Class
