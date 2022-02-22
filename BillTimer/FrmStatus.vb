Public Class FrmStatus

    'Deklarasi variabel strPath untuk menyimpan current path dalam bentuk string
    Dim strPath As String = System.IO.Path.GetDirectoryName( _
    System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

    'Ini hanya Fungsi contoh penggunaan MessageBox yang membutuhkan jawaban dari user
    Public Sub TutupAplikasi()
        ' Display a message box asking users if they 
        ' want to exit the application.
        If MessageBox.Show("Do you want to exit?", "My Application", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
              = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub FrmStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnOk.Hide()
        BtnCancel.Hide()
        'BtnTambahWaktu.Hide()
        LblJamTw.Hide()
        LblMenitTw.Hide()
        LblHarga.Hide()
        LblPassword.Hide()
        'LblSisaDetik.Hide()
        'TxbSisaDetik.Hide()
        TxbJamTw.Hide()
        TxbMenitTw.Hide()
        TxbPassword.Hide()
        CbxHargaTw.Hide()

        TxbPassword.PasswordChar = "X"
        TxbPassword.MaxLength = 20

    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        If MessageBox.Show("Yakin ingin logoff ?", "Logoff", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
              = DialogResult.No Then
            Exit Sub
        End If

        'My.Computer.Audio.Play(strPath & "\MissileAlert.wav", AudioPlayMode.WaitToComplete)
        'My.Computer.Audio.Play(strPath & "\MissileAlert.wav")

        'Menutup beberapa aplikasi saat waktu rental habis
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

        'Mematikan timer billing yang ada di form start, menampilkan Form start dan menutup form ini
        FrmStart.TmrBilling.Stop()
        FrmStart.TmrBackupSisaWaktu.Stop()

        If FrmStart.TulisBackupSisaWaktu("00:00:00") = True Then
            MessageBox.Show("Sisa waktu = " & FrmStart.BacaBackupSisaWaktu.ToString)
        Else
            MessageBox.Show("Gagal menulis backup sisa waktu.")
        End If


        FrmStart.CbxHarga.Text = 1000
        FrmStart.TxbJam.Text = "0"
        FrmStart.TxbMenit.Text = "20"
        FrmStart.TxbDetik.Text = "0"
        FrmStart.TxbMilliDetik.Text = "000"
        FrmStart.TxbSisaWaktu.Text = "00:00:00"
        FrmStart.TxbPassword.Focus()

        FrmStart.Show()
        Me.Hide()

    End Sub

    Private Sub BtnTambahWaktu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambahWaktu.Click, BtnTambahWaktu.Click
        BtnOk.Show()
        BtnCancel.Show()
        LblJamTw.Show()
        LblMenitTw.Show()
        LblHarga.Show()
        LblPassword.Show()
        TxbJamTw.Show()
        TxbMenitTw.Show()
        TxbPassword.Show()
        CbxHargaTw.Show()

        BtnLogout.Hide()
        BtnTambahWaktu.Hide()

        
        'TxbSisaWaktu.Clear()

        CbxHargaTw.Items.Clear()
        For i = 0 To FrmStart.CbxHarga.Items.Count - 1
            CbxHargaTw.Items.Add(FrmStart.CbxHarga.Items(i))
            'adding items of combobox1 to another combobox
        Next
        TxbJamTw.Text = "0"
        TxbMenitTw.Text = "20"
        CbxHargaTw.Text = 1000
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If TxbPassword.Text = FrmStart.BacaPassword(FrmStart.strBacaPassword) Then
            BtnOk.Hide()
            BtnCancel.Hide()
            LblJamTw.Hide()
            LblMenitTw.Hide()
            LblHarga.Hide()
            LblPassword.Hide()
            TxbJamTw.Hide()
            TxbMenitTw.Hide()
            TxbPassword.Hide()
            CbxHargaTw.Hide()

            BtnLogout.Show()
            BtnTambahWaktu.Show()

            Dim h, m As Integer
            If Not Integer.TryParse(TxbJamTw.Text, h) OrElse _
               Not Integer.TryParse(TxbMenitTw.Text, m) Then
                MessageBox.Show("Tambahan waktu bad input, exit sub.")
                'bad input data
                Exit Sub
            End If

            FrmStart.sisaWaktuMetodeTimeSpan = FrmStart.sisaWaktuMetodeTimeSpan + New TimeSpan(h, m, 0)
            FrmStart.dtFuture = FrmStart.dtFuture.AddHours(h).AddMinutes(m).AddSeconds(0).AddMilliseconds(0)
            TxbStopJam.Text = FrmStart.dtFuture.ToShortTimeString

            FrmStart.TulisBackupSisaWaktu(FrmStart.sisaWaktuMetodeTimeSpan.ToString)
            TxbSisaDetikSaved.Text = FrmStart.BacaBackupSisaWaktu.ToString

            TxbJam.Text = FrmStart.TxbJam.Text
            TxbMenit.Text = FrmStart.TxbMenit.Text
            TxbDetik.Text = FrmStart.TxbDetik.Text
            TxbMiliDetik.Text = FrmStart.TxbMilliDetik.Text

            'MessageBox.Show("dtFutur saat ini :" & FrmStart.dtFuture.ToShortTimeString)
        Else
            MessageBox.Show("Password salah goblok.", "Warning", _
             MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CbxHargaTw_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxHargaTw.TextChanged
        Dim num As Integer
        If Integer.TryParse(CbxHargaTw.Text, num) Then
            If CbxHargaTw.Text = 1000 Then
                TxbJamTw.Text = 0
                TxbMenitTw.Text = 20
            ElseIf CbxHargaTw.Text = 2000 Then
                TxbJamTw.Text = 0
                TxbMenitTw.Text = 40
            ElseIf CbxHargaTw.Text = 3000 Then
                TxbJamTw.Text = 1
                TxbMenitTw.Text = 0
            ElseIf CbxHargaTw.Text = 4000 Then
                TxbJamTw.Text = 1
                TxbMenitTw.Text = 20
            ElseIf CbxHargaTw.Text = 5000 Then
                TxbJamTw.Text = 1
                TxbMenitTw.Text = 40
            ElseIf CbxHargaTw.Text = 6000 Then
                TxbJamTw.Text = 2
                TxbMenitTw.Text = 0
            ElseIf CbxHargaTw.Text = 7000 Then
                TxbJamTw.Text = 2
                TxbMenitTw.Text = 20
            ElseIf CbxHargaTw.Text = 8000 Then
                TxbJamTw.Text = 2
                TxbMenitTw.Text = 40
            ElseIf CbxHargaTw.Text = 9000 Then
                TxbJamTw.Text = 3
                TxbMenitTw.Text = 0
            ElseIf CbxHargaTw.Text = 10000 Then
                TxbJamTw.Text = 3
                TxbMenitTw.Text = 20
            Else
                MessageBox.Show("Harap isi harga kelipatan 1.000 sampai 10.000.")
                CbxHargaTw.Text = 1000
                TxbJamTw.Text = 0
                TxbMenitTw.Text = 20
            End If
        Else
            MessageBox.Show("Harap isi harga dengan benar!, Tolol!", "Warning", _
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            CbxHargaTw.Text = 1000
            TxbJamTw.Text = 0
            TxbMenitTw.Text = 20
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        BtnOk.Hide()
        BtnCancel.Hide()
        LblJamTw.Hide()
        LblMenitTw.Hide()
        LblHarga.Hide()
        LblPassword.Hide()
        TxbJamTw.Hide()
        TxbMenitTw.Hide()
        TxbPassword.Hide()
        CbxHargaTw.Hide()

        BtnLogout.Show()
        BtnTambahWaktu.Show()
    End Sub

    Private Sub CbxHargaTw_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxHargaTw.SelectedIndexChanged

    End Sub
End Class