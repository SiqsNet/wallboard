Public Class Form2
    Dim news As String
    Dim czas As String
    Dim czas2 As String


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.Show()
        On Error Resume Next
        WpisNo.TopMost = False
        On Error Resume Next
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        On Error Resume Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' czytanie konfiguracji
        On Error Resume Next
        Dim dat As New XQuickINI.xquickini()
        On Error Resume Next
        dat.Load("config.ini", False, True)
        On Error Resume Next
        czas = dat.GetSection("timer").GetKey("timer").GetValue()
        czas2 = dat.GetSection("timer").GetKey("timer2").GetValue()
        Timer1.Interval = czas

        Timer2.Interval = czas
        On Error Resume Next
        Process.Start("redekran.vbs")
        On Error Resume Next
        Dim read As New System.IO.StreamReader("news.txt")
        On Error Resume Next
        TextBox1.Text = read.ReadToEnd
        On Error Resume Next
        read.Close()
    End Sub

    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'Me.Hide()
        On Error Resume Next
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' czytanie konfiguracji
        On Error Resume Next
        Dim dat As New XQuickINI.xquickini()
        On Error Resume Next
        dat.Load("config.ini", False, True)
        On Error Resume Next
        czas = dat.GetSection("timer").GetKey("timer").GetValue()
        Timer1.Interval = czas


        On Error Resume Next
        Dim read As New System.IO.StreamReader("news.txt")
        On Error Resume Next
        TextBox1.Text = read.ReadToEnd
        On Error Resume Next
        read.Close()
        On Error Resume Next
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        On Error Resume Next
        'Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True
        On Error Resume Next

        Timer2.Interval = czas
        On Error Resume Next
        Timer1.Interval = czas2
        On Error Resume Next

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Interval = czas
        On Error Resume Next
        Me.Hide()
        On Error Resume Next
    End Sub
End Class