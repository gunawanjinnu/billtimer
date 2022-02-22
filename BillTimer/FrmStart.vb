Imports System.Data.OleDb

Public Class FrmStart
    'Variable untuk fungsi database
    Dim KoneksiStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb;Jet OLEDB:Database Password=motox"
    Dim Koneksi As New OleDbConnection(KoneksiStr)
    Dim OleDbCmd As New OleDbCommand
    Dim OleDbDtRdr As OleDbDataReader = Nothing

    'Deklarasi variabel dtFuture Timer untuk menyimpan nilai waktu stop (sesuai harga rental)
    Public dtFuture As New DateTime
    'Deklarasi dtNowLokal untuk menyimpan jam komputer, variabel ini akan di tambah 1 setiap kali timer berdetak dengan interval 1000
    'sehingga menjadi seperti jam biasa, namun tidak terpengaruh apabila jam komputer di ubah pada saat runtime.
    Public dtNowLokal As New DateTime
    'Jika waktu rental belum habis, maka waktu rental akan terus dikurangi setiap kali timer berdetak
    ' dengan waktu sekarang dan menampilkan hasilnya dalam bentuk hitungan mundur pada textbox sisa waktu
    'Variabel sisaWaktuMetodeTimeSpan akan menyimpan sisa waktu, contohnya seperti dibawah ini:
    'contoh: dtFuture/waktu stop = jam 5:50 dan dtNowLokal/waktu sekarang = jam 5:35
    'maka : 05:50 - 05:35 = 00:15, berarti sisa waktunya 0 jam 15 menit. Waktu tersebut akan terus berkurang
    'disebabkan karena dtNowLokal terus maju/bertambah. Saat dtNowLokal mencapai jam 05.50, maka sisaWaktuMetodeTimeSpan
    'akan bernilai : 00:00, saat itulah waktu rental habis. SisaWaktuMetodeTimeSpan dapat diconversi menjadi total menit dengan
    'cara: sisaWaktuMetodeTimeSpan.TotalMinutes
    Public sisaWaktuMetodeTimeSpan As New TimeSpan
    'Untuk menyimpan current directory dalam bentuk string ke variabel strPath
    Dim strPath As String = System.IO.Path.GetDirectoryName( _
    System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

    'Untuk parameter fungsi baca password
    Public strBacaPassword As String = "Select [Password] from [Table1]"
    Public strBacaMasterPassword As String = "Select [MasterPassword] from [Table1]"

    Private Function InisialisasiAwal() As Boolean
        'Membuat form berada diatas semua form
        TopMost = True

        'Menyimpan waktu sekarang ke variabel dtNowLokal untuk membuat jam independen 
        'agar jam aplikasi tidak bisa di intervensi oleh jam komputer
        dtNowLokal = DateTime.Now

        'Mengisi combobox harga
        CbxHarga.Items.Add(1000) : CbxHarga.Items.Add(2000) : CbxHarga.Items.Add(3000) : CbxHarga.Items.Add(4000)
        CbxHarga.Items.Add(5000) : CbxHarga.Items.Add(6000) : CbxHarga.Items.Add(7000) : CbxHarga.Items.Add(8000)
        CbxHarga.Items.Add(9000) : CbxHarga.Items.Add(10000)


        'Mengosongkan textbox password, menyembunyikan password dengan karakter X, dan membatasi jumlah maksimal
        'karakter yang diperbolehkan sebagai password
        TxbPassword.Text = ""
        TxbPassword.PasswordChar = "X"
        TxbPassword.MaxLength = 20

        'Menyembunyikan textbox password dan tombol keluar billing
        TxbMasterPassword.Hide()
        BtnMasterKeluar.Hide()
        Return True
    End Function

    Public Function BacaBackupSisaWaktu() As TimeSpan
        Dim CmdBacaBackupSisaWaktu As String = ("Select [backupSisaWaktu] from [Table1]")
        OleDbCmd.CommandText = CmdBacaBackupSisaWaktu
        OleDbCmd.CommandType = CommandType.Text
        OleDbCmd.Connection = Koneksi

        Dim tsReturn As TimeSpan
        Try
            If Koneksi.State <> ConnectionState.Open Then
                Koneksi.Open()
                OleDbDtRdr = OleDbCmd.ExecuteReader
                While OleDbDtRdr.Read
                    'Cara membaca 1 field yang didefinisikan yaitu dengan mengatur indeks OleDbDtRdr.
                    Dim sHasil As String = OleDbDtRdr(0).ToString
                    tsReturn = TimeSpan.Parse(sHasil)
                End While
                OleDbDtRdr.Close()
                Koneksi.Close()
            Else
                OleDbDtRdr = OleDbCmd.ExecuteReader
                While OleDbDtRdr.Read
                    'Cara membaca 1 field yang didefinisikan yaitu dengan mengatur indeks OleDbDtRdr.
                    Dim sHasil As String = OleDbDtRdr(0).ToString
                    tsReturn = TimeSpan.Parse(sHasil)
                End While
                OleDbDtRdr.Close()
                Koneksi.Close()
            End If
        Catch ArgEx As ArgumentException
            MessageBox.Show(ArgEx.ToString)
        Catch OlDb As OleDb.OleDbException
            MessageBox.Show(OlDb.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return tsReturn
    End Function

    Public Function TulisBackupSisaWaktu(ByVal strSisaWaktu As String) As Boolean
        Dim CmdUpdateSisaWaktu As String = "Update [Table1] set backupSisaWaktu='" & strSisaWaktu.ToString & "'"
        OleDbCmd.Connection = Koneksi
        OleDbCmd.CommandText = CmdUpdateSisaWaktu
        OleDbCmd.CommandType = CommandType.Text

        OleDbDtRdr = Nothing
        Try
            If Koneksi.State <> ConnectionState.Open Then
                Koneksi.Open()
                OleDbCmd.ExecuteNonQuery()
                Koneksi.Close()
            Else
                OleDbCmd.ExecuteNonQuery()
                Koneksi.Close()
            End If
        Catch ArgEx As ArgumentException
            MessageBox.Show(ArgEx.ToString)
        Catch OlDb As OleDb.OleDbException
            MessageBox.Show(OlDb.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Function BacaPassword(ByVal CmdBacaPassword As String) As String
        Dim sHasil As String = ""
        'Gunakan parameter ini untuk membaca password dari tabel1 ("Select [Password] from [Table1]")
        'Gunakan parameter ini untuk membaca master password dari tabel1 ("Select [MasterPassword] from [Table1]")
        OleDbCmd.CommandText = CmdBacaPassword
        OleDbCmd.CommandType = CommandType.Text
        OleDbCmd.Connection = Koneksi

        Try
            If Koneksi.State <> ConnectionState.Open Then
                Koneksi.Open()
                OleDbDtRdr = OleDbCmd.ExecuteReader
                While OleDbDtRdr.Read
                    'Cara membaca 1 field yang didefinisikan yaitu dengan mengatur indeks OleDbDtRdr.
                    sHasil = OleDbDtRdr(0).ToString
                End While
                OleDbDtRdr.Close()
                Koneksi.Close()
            Else
                OleDbDtRdr = OleDbCmd.ExecuteReader
                While OleDbDtRdr.Read
                    'Cara membaca 1 field yang didefinisikan yaitu dengan mengatur indeks OleDbDtRdr.
                    sHasil = OleDbDtRdr(0).ToString
                End While
                OleDbDtRdr.Close()
                Koneksi.Close()
            End If
        Catch ArgEx As ArgumentException
            MessageBox.Show(ArgEx.ToString)
        Catch OlDb As OleDb.OleDbException
            MessageBox.Show(OlDb.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return sHasil
    End Function

    Private Sub FrmStart_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.WindowsShutDown Then
            Process.Start("shutdown.exe", "/a")
        End If
    End Sub

    Private Sub FrmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InisialisasiAwal()

        sisaWaktuMetodeTimeSpan = BacaBackupSisaWaktu()

        MessageBox.Show("Form Load, sisaWaktuMetodeTimeSpan = " & sisaWaktuMetodeTimeSpan.ToString)

        If sisaWaktuMetodeTimeSpan.TotalMinutes > 0 Then
            'Jika saat form di load sisaWaktuMetodeTimeSpan > 0, berarti penutupan aplikasi tidak normal
            MessageBox.Show("Sistem tidak di shutdown dengan benar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            TmrBilling.Start()
            TmrBackupSisaWaktu.Start()

            dtFuture = dtNowLokal + sisaWaktuMetodeTimeSpan
            FrmStatus.TxbStartJam.Text = dtNowLokal.ToShortTimeString
            FrmStatus.TxbStopJam.Text = dtFuture.ToShortTimeString
            Me.Hide()
            FrmStatus.Show()

        Else
            'Memastikan timer billing tidak aktif, kemudian mengisi nilai 0 ke masing-masing textbox
            TmrBilling.Enabled = False
            TmrBackupSisaWaktu.Enabled = False

            'Inisialisasi nilai awal
            CbxHarga.Text = 1000 : TxbJam.Text = "0" : TxbMenit.Text = 20 : TxbDetik.Text = "0" : TxbMilliDetik.Text = "000"
            'Inisialisasi awal textbox sisa detik yang ada di form status
            FrmStatus.TxbSisaDetikSaved.Text = 0

        End If
    End Sub

    Private Sub TmrBilling_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrBilling.Tick
        '
        'Jika waktu saat ini sudah mencapai waktu berhenti atau sudah melewati waktu berhenti sesuai harga, maka
        'textbox sisa waktu di isi "blast off", timer billing di hentikan, variabel yang menyimpan jumlah detik
        'di set ke nol.
        'If dtNowLokal > dtFuture Then
        If sisaWaktuMetodeTimeSpan.TotalSeconds <= 0 Then
            TxbSisaWaktu.Text = "blast off"
            TmrBilling.Stop()
            TmrBackupSisaWaktu.Stop()
            'Buka koneksi, lalu set backupSisaWaktu menjadi 0
            If TulisBackupSisaWaktu("00:00:00") = True Then
                MessageBox.Show("Set backupSisaWaktu ke 0")
            End If
            FrmStatus.TxbSisaWaktu.Text = 0

            'Bunyikan audio tanda waktu rental telah habis
            'My.Computer.Audio.Play(strPath & "\MissileAlert.wav", AudioPlayMode.WaitToComplete)
            'Tutup beberapa aplikasi jika belum ditutup oleh klien
            For Each selProcess As Process In Process.GetProcesses
                If selProcess.ProcessName = "taskmgr" Then
                    selProcess.Kill()
                End If
                If selProcess.ProcessName = "chrome" Then
                    selProcess.Kill()
                End If
                If selProcess.ProcessName = "ONET" Then
                    selProcess.Kill()
                End If
                If selProcess.ProcessName = "PlantVsZombie" Then
                    selProcess.Kill()
                End If
                If selProcess.ProcessName = "popcapgame1" Then
                    selProcess.Kill()
                End If
            Next
            'Form status di sembunyikan, kemudian tampilkan form ini(FrmStart)
            FrmStatus.Hide()
            Me.Show()
        Else
            'Jika waktu rental belum habis, maka waktu rental akan terus dikurangi setiap kali timer berdetak
            ' dengan waktu sekarang dan menampilkan hasilnya dalam bentuk hitungan mundur pada textbox sisa waktu
            'Variabel sisaWaktuMetodeTimeSpan akan menyimpan sisa waktu, contohnya seperti dibawah ini:
            'contoh: dtFuture/waktu stop = jam 5:50 dan dtNowLokal/waktu sekarang = jam 5:35
            'maka : 05:50 - 05:35 = 00:15, berarti sisa waktunya 0 jam 15 menit. Waktu tersebut akan terus berkurang
            'disebabkan karena dtNowLokal terus maju/bertambah. Saat dtNowLokal mencapai jam 05.50, maka sisaWaktuMetodeTimeSpan
            'akan bernilai : 00:00, saat itulah waktu rental habis. sisaWaktuMetodeTimeSpan dapat diconversi menjadi total menit dengan
            'cara: sisaWaktuMetodeTimeSpan.TotalMinutes
            'sisaWaktuMetodeTimeSpan = dtFuture - dtNowLokal

            sisaWaktuMetodeTimeSpan = sisaWaktuMetodeTimeSpan.Subtract(New TimeSpan(0, 0, 1))

            'Menampilkan sisa waktu klien pada textbox dengan cara mengakses metode TotalSeconds pada objek sisaWaktuMetodeTimeSpan
            'FrmStatus.TxbSisaDetikSaved.Text = sisaWaktuMetodeTimeSpan.TotalSeconds

            'Untuk menampilkan format waktu lengkap dengan millidetik, namun interval timer harus di set 100 agar tampil secara realtime
            'TxbSisaWaktu.Text = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", _
            'sisaWaktuMetodeTimeSpan.Hours, sisaWaktuMetodeTimeSpan.Minutes, sisaWaktuMetodeTimeSpan.Seconds, sisaWaktuMetodeTimeSpan.Milliseconds)

            'Untuk menampilkan format waktu tanpa millidetik, interval timer di set 1000
            TxbSisaWaktu.Text = String.Format("{0:D2}:{1:D2}:{2:D2}:000", _
                                          sisaWaktuMetodeTimeSpan.Hours, sisaWaktuMetodeTimeSpan.Minutes, sisaWaktuMetodeTimeSpan.Seconds)

            'Menyamakan sisa waktu di form start dengan form status
            FrmStatus.TxbSisaWaktu.Text = TxbSisaWaktu.Text

            'Menampilkan pesan sisa waktu kepada klien
            'If sisaWaktuMetodeTimeSpan.TotalSeconds = 180 Then '180 detik = 3 menit
            If sisaWaktuMetodeTimeSpan.TotalSeconds = 300 Then
                MessageBox.Show("Sisa waktu tinggal " & sisaWaktuMetodeTimeSpan.TotalSeconds / 60 & " menit.", "Sisa waktu.")
                'MessageBox.Show("sisaWaktuMetodeTimeSpan saat ini :" & sisaWaktuMetodeTimeSpan.ToString)
            ElseIf sisaWaktuMetodeTimeSpan.TotalSeconds = 60 Then
                My.Computer.Audio.Play(strPath & "\MissileAlert.wav")
            End If
        End If
    End Sub

    Private Sub TmrCurrentTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrCurrentTime.Tick

        'Menampilkan jam di form start dan form status menggunakan timer komputer(akan berpengaruh jika jam komputer dirubah saat runtime)
        'LblWaktuSekarang.Text = TimeOfDay

        'Setiap kali timer berdetak, maka dtNowLokal bertambah 1 detik, sehingga jam lokal berjalan dan tidak mengikuti jam komputer
        '(tidak dapat diintervensi saat runtime meskipun jam komputer berubah)
        dtNowLokal = dtNowLokal.AddSeconds(1)

        'Menampilkan jam di form start dan form status
        LblWaktuSekarang.Text = dtNowLokal.ToLongTimeString
        FrmStatus.LblWaktuSekarang.Text = LblWaktuSekarang.Text

        'Menyamakan isi textbox yang di form status dengan form start
        FrmStatus.TxbJam.Text = TxbJam.Text
        FrmStatus.TxbMenit.Text = TxbMenit.Text
        FrmStatus.TxbDetik.Text = TxbDetik.Text
        FrmStatus.TxbMiliDetik.Text = TxbMilliDetik.Text

        'Untuk memblok/mematikan taskmanager
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
            End If
            'If selProcess.ProcessName = "chrome" Then
            'selProcess.Kill()
            'End If
        Next


    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        'Deklarasi variabel untuk menyimpan parameter waktu/timer ke dtFuture
        Dim h, m, s, ms As Integer
        'Memastikan bahwa nilai pada masing-masing textbox adalah integer, jika bukan integer maka langsung keluar
        'jika benar integer, maka nilai langsung dimasukkan ke variabel Timer dtFuture
        If Not Integer.TryParse(TxbJam.Text, h) OrElse _
        Not Integer.TryParse(TxbMenit.Text, m) OrElse _
        Not Integer.TryParse(TxbDetik.Text, s) OrElse _
        Not Integer.TryParse(TxbMilliDetik.Text, ms) Then
            'bad input data
            MessageBox.Show("Bad input data. Exit sub.")
            Exit Sub
        End If
        'dtFuture = DateTime.Now.AddHours(h).AddMinutes(m).AddSeconds(s).AddMilliseconds(ms)
        dtFuture = dtNowLokal.AddHours(h).AddMinutes(m).AddSeconds(s).AddMilliseconds(ms)

        'Menghitung durasi waktu antara waktu sekarang dengan beberapa menit/jam kedepan dan menyimpannya dalam 
        'variabel sisaWaktuMetodeTimeSpan
        'sisaWaktuMetodeTimeSpan = dtFuture - dtNowLokal
        sisaWaktuMetodeTimeSpan = New TimeSpan(h, m, s)

        'Memeriksa apakah password benar atau salah, jika benar, maka kosongkan textbox password lalu 
        'mengaktifkan timer TmrBilling, menutup form ini dan menampilkan form status
        '=============================================================================================
        If TxbPassword.Text = BacaPassword(strBacaPassword) Then

            'Menyimpan sisa waktu dengan interval 3 menit atau timer interval 180.000
            If TulisBackupSisaWaktu(sisaWaktuMetodeTimeSpan.ToString) = True Then
                MessageBox.Show("Sisa waktu = " & BacaBackupSisaWaktu.ToString)
            Else
                MessageBox.Show("Gagal menulis backup sisa waktu.")
            End If

            FrmStatus.TxbSisaDetikSaved.Text = BacaBackupSisaWaktu.ToString

            TmrBilling.Start()
            TmrBackupSisaWaktu.Start()

            TxbPassword.Text = ""
            FrmStatus.TxbStartJam.Text = dtNowLokal.ToShortTimeString
            FrmStatus.TxbStopJam.Text = dtFuture.ToShortTimeString
            Me.Hide()
            FrmStatus.Show()

        Else
            MessageBox.Show("Password salah, Bodo'", "Warning", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TxbPassword.Focus()
        End If
    End Sub

    Private Sub BtnKeluarDarurat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluarDarurat.Click
        TxbMasterPassword.Text = ""
        TxbMasterPassword.PasswordChar = "A"
        If BtnKeluarDarurat.Text = "X" Then
            BtnKeluarDarurat.Text = "Batal"
            TxbMasterPassword.Show()
            BtnMasterKeluar.Show()
            LblMasterPassword.Show()
        ElseIf BtnKeluarDarurat.Text = "Batal" Then
            BtnKeluarDarurat.Text = "X"
            TxbMasterPassword.Hide()
            BtnMasterKeluar.Hide()
            LblMasterPassword.Hide()
        End If
        TxbMasterPassword.Focus()
    End Sub

    Private Sub CbxHarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxHarga.TextChanged
        'Memastikan isi combobox harga adalah nomor dan bukan huruf atau simbol
        Dim num As Integer
        If Integer.TryParse(CbxHarga.Text, num) Then
            If num = 1000 Then
                TxbJam.Text = 0
                TxbMenit.Text = 20
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            ElseIf CbxHarga.Text = 2000 Then
                TxbJam.Text = 0
                TxbMenit.Text = 40
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            ElseIf CbxHarga.Text = 3000 Then
                TxbJam.Text = 1
                TxbMenit.Text = 0
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            ElseIf CbxHarga.Text = 4000 Then
                TxbJam.Text = 1
                TxbMenit.Text = 20
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            ElseIf CbxHarga.Text = 5000 Then
                TxbJam.Text = 1
                TxbMenit.Text = 40
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            ElseIf CbxHarga.Text = 6000 Then
                TxbJam.Text = 2
                TxbMenit.Text = 0
            ElseIf CbxHarga.Text = 7000 Then
                TxbJam.Text = 2
                TxbMenit.Text = 20
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            ElseIf CbxHarga.Text = 8000 Then
                TxbJam.Text = 2
                TxbMenit.Text = 40
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            ElseIf CbxHarga.Text = 9000 Then
                TxbJam.Text = 3
                TxbMenit.Text = 0
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            ElseIf CbxHarga.Text = 10000 Then
                TxbJam.Text = 3
                TxbMenit.Text = 20
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
            Else
                MessageBox.Show("Harap isi harga kelipatan 1.000, maksimal 10.000")
                CbxHarga.Text = 1000
                TxbJam.Text = 0
                TxbMenit.Text = 20
                TxbDetik.Text = 0
                TxbMilliDetik.Text = 0
                Exit Sub
            End If
        Else
            MessageBox.Show("Harap isi harga dengan benar!, Tolol!", "Warning", _
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            CbxHarga.Text = 1000
            TxbJam.Text = 0
            TxbMenit.Text = 20
            TxbDetik.Text = 0
            TxbMilliDetik.Text = 0
            Exit Sub
        End If
        TxbPassword.Focus()
    End Sub

    Private Sub CbxHarga_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxHarga.SelectedIndexChanged
        TxbPassword.Focus()
    End Sub

    Private Sub BtnMasterKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMasterKeluar.Click
        If TxbMasterPassword.Text = BacaPassword(strBacaMasterPassword) Then
            TxbMasterPassword.Text = ""
            Me.Close()
        Else
            MessageBox.Show("Dasar bodoh, idiot, salah!!!", "Warning", _
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub BtnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShutdown.Click
        If MessageBox.Show("Yakin ingin Shutdown computer ?", "Shutdown", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
              = DialogResult.No Then
            Exit Sub
        End If
        System.Diagnostics.Process.Start("shutdown", "-f -s -t 00")
    End Sub

    Private Sub TmrBackupSisaWaktu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrBackupSisaWaktu.Tick
        'Menyimpan sisa waktu dengan interval 3 menit atau timer interval 180.000
        TulisBackupSisaWaktu(sisaWaktuMetodeTimeSpan.ToString)
        FrmStatus.TxbSisaDetikSaved.Text = BacaBackupSisaWaktu.ToString
    End Sub
End Class