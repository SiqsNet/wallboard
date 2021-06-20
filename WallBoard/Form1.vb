Imports System
Imports System.IO
Imports XQuickINI.xquickini

Public Class WpisNo
    Dim informacja1 As String
    Dim informacja2 As String
    Dim informacja3 As String
    Dim informacja4 As String
    Dim informacja5 As String
    Dim informacja6 As String
    Dim informacja7 As String
    Dim informacja8 As String
    Dim dane1 As String
    Dim dane2 As String
    Dim dane3 As String
    Dim dane4 As String
    Dim dane5 As String
    Dim dane6 As String
    Dim dane7 As String
    Dim dane8 As String
    Dim prog1 As String
    Dim prog2 As String
    Dim prog3 As String
    Dim prog4 As String
    Dim prog5 As String
    Dim prog6 As String
    Dim prog7 As String
    Dim prog8 As String
    Dim przenikanie As String
    Dim rozmiarfont As String
    Dim tlo As String
    Dim kolor1w As String
    Dim kolor1m As String
    Dim kolor1r As String
    Dim kolor2w As String
    Dim kolor2m As String
    Dim kolor2r As String
    Dim kolor3w As String
    Dim kolor3m As String
    Dim kolor3r As String
    Dim kolor4w As String
    Dim kolor4m As String
    Dim kolor4r As String
    Dim kolor5w As String
    Dim kolor5m As String
    Dim kolor5r As String
    Dim kolor6w As String
    Dim kolor6m As String
    Dim kolor6r As String
    Dim kolor7w As String
    Dim kolor7m As String
    Dim kolor7r As String
    Dim kolor8w As String
    Dim kolor8m As String
    Dim kolor8r As String
    Dim dzwiek1 As String
    Dim dzwiek2 As String
    Dim dzwiek3 As String
    Dim dzwiek4 As String
    Dim dzwiek5 As String
    Dim dzwiek6 As String
    Dim dzwiek7 As String
    Dim dzwiek8 As String
    Dim czas As String
    Dim program As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Show()
        On Error Resume Next
        ' czytanie konfiguracji
        On Error Resume Next
        Dim dat As New XQuickINI.xquickini()
        On Error Resume Next
        dat.Load("config.ini", False, True)
        On Error Resume Next
        informacja1 = dat.GetSection("informacja").GetKey("informacja1").GetValue()
        informacja2 = dat.GetSection("informacja").GetKey("informacja2").GetValue()
        informacja3 = dat.GetSection("informacja").GetKey("informacja3").GetValue()
        informacja4 = dat.GetSection("informacja").GetKey("informacja4").GetValue()
        informacja5 = dat.GetSection("informacja").GetKey("informacja5").GetValue()
        informacja6 = dat.GetSection("informacja").GetKey("informacja6").GetValue()
        informacja7 = dat.GetSection("informacja").GetKey("informacja7").GetValue()
        informacja8 = dat.GetSection("informacja").GetKey("informacja8").GetValue()


        prog1 = dat.GetSection("prog").GetKey("prog1").GetValue()
        prog1 = dat.GetSection("prog").GetKey("prog2").GetValue()
        prog1 = dat.GetSection("prog").GetKey("prog3").GetValue()
        prog1 = dat.GetSection("prog").GetKey("prog4").GetValue()
        prog1 = dat.GetSection("prog").GetKey("prog5").GetValue()
        prog1 = dat.GetSection("prog").GetKey("prog6").GetValue()
        prog1 = dat.GetSection("prog").GetKey("prog7").GetValue()
        prog1 = dat.GetSection("prog").GetKey("prog8").GetValue()

        przenikanie = dat.GetSection("przenikanie").GetKey("przenikanie").GetValue()
        rozmiarfont = dat.GetSection("rozmiar").GetKey("rozmiarfont").GetValue()
        tlo = dat.GetSection("tlo").GetKey("czarny").GetValue()
        czas = dat.GetSection("timer").GetKey("timer").GetValue()
        program = dat.GetSection("program").GetKey("program").GetValue()


        ' kolory
        kolor1w = dat.GetSection("kolory").GetKey("kolor1w").GetValue()
        kolor2w = dat.GetSection("kolory").GetKey("kolor2w").GetValue()
        kolor3w = dat.GetSection("kolory").GetKey("kolor3w").GetValue()
        kolor4w = dat.GetSection("kolory").GetKey("kolor4w").GetValue()
        kolor5w = dat.GetSection("kolory").GetKey("kolor5w").GetValue()
        kolor6w = dat.GetSection("kolory").GetKey("kolor6w").GetValue()
        kolor7w = dat.GetSection("kolory").GetKey("kolor7w").GetValue()
        kolor8w = dat.GetSection("kolory").GetKey("kolor8w").GetValue()

        kolor1r = dat.GetSection("kolory").GetKey("kolor1r").GetValue()
        kolor2r = dat.GetSection("kolory").GetKey("kolor2r").GetValue()
        kolor3r = dat.GetSection("kolory").GetKey("kolor3r").GetValue()
        kolor4r = dat.GetSection("kolory").GetKey("kolor4r").GetValue()
        kolor5r = dat.GetSection("kolory").GetKey("kolor5r").GetValue()
        kolor6r = dat.GetSection("kolory").GetKey("kolor6r").GetValue()
        kolor7r = dat.GetSection("kolory").GetKey("kolor7r").GetValue()
        kolor8r = dat.GetSection("kolory").GetKey("kolor8r").GetValue()

        kolor1m = dat.GetSection("kolory").GetKey("kolor1m").GetValue()
        kolor2m = dat.GetSection("kolory").GetKey("kolor2m").GetValue()
        kolor3m = dat.GetSection("kolory").GetKey("kolor3m").GetValue()
        kolor4m = dat.GetSection("kolory").GetKey("kolor4m").GetValue()
        kolor5m = dat.GetSection("kolory").GetKey("kolor5m").GetValue()
        kolor6m = dat.GetSection("kolory").GetKey("kolor6m").GetValue()
        kolor7m = dat.GetSection("kolory").GetKey("kolor7m").GetValue()
        kolor8m = dat.GetSection("kolory").GetKey("kolor8m").GetValue()


        On Error Resume Next
        dane1 = My.Computer.FileSystem.ReadAllText("dane1.txt")
        On Error Resume Next
        dane2 = My.Computer.FileSystem.ReadAllText("dane2.txt")
        On Error Resume Next
        dane3 = My.Computer.FileSystem.ReadAllText("dane3.txt")
        On Error Resume Next
        dane4 = My.Computer.FileSystem.ReadAllText("dane4.txt")
        On Error Resume Next
        dane5 = My.Computer.FileSystem.ReadAllText("dane5.txt")
        On Error Resume Next
        dane6 = My.Computer.FileSystem.ReadAllText("dane6.txt")
        On Error Resume Next
        dane7 = My.Computer.FileSystem.ReadAllText("dane7.txt")
        On Error Resume Next
        dane8 = My.Computer.FileSystem.ReadAllText("dane8.txt")
        On Error Resume Next


        Napis1.Text = informacja1
        Napis2.Text = informacja2
        Napis3.Text = informacja3
        Napis4.Text = informacja4
        Napis5.Text = informacja5
        Napis6.Text = informacja6
        Napis7.Text = informacja7
        Napis8.Text = informacja8
        Wpis1.Text = dane1
        Wpis2.Text = dane2
        Wpis3.Text = dane3
        Wpis4.Text = dane4
        Wpis5.Text = dane5
        Wpis6.Text = dane6
        Wpis7.Text = dane7
        Wpis8.Text = dane8


        Napis1.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Napis2.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Napis3.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Napis4.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Wpis1.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Wpis2.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Wpis3.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Napis5.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Napis6.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Napis7.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Napis8.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)

        Wpis4.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Wpis5.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Wpis6.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Wpis7.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        Wpis8.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)

        If tlo = True Then

            Me.BackColor = Color.Black
            Panel1.BackColor = Color.Black
            Panel2.BackColor = Color.Black
            Panel3.BackColor = Color.Black
            Panel4.BackColor = Color.Black
            Panel5.BackColor = Color.Black
            Panel6.BackColor = Color.Black
            Panel7.BackColor = Color.Black
            Panel8.BackColor = Color.Black
            Panel9.BackColor = Color.Black
            Panel10.BackColor = Color.Black
            Panel11.BackColor = Color.Black
            Panel12.BackColor = Color.Black
            Panel13.BackColor = Color.Black
            Panel14.BackColor = Color.Black
            Panel15.BackColor = Color.Black
            Panel17.BackColor = Color.Black

        End If

        If tlo = False Then

            Me.BackColor = Color.WhiteSmoke
            Panel1.BackColor = Color.WhiteSmoke
            Panel2.BackColor = Color.WhiteSmoke
            Panel3.BackColor = Color.WhiteSmoke
            Panel4.BackColor = Color.WhiteSmoke
            Panel5.BackColor = Color.WhiteSmoke
            Panel6.BackColor = Color.WhiteSmoke
            Panel7.BackColor = Color.WhiteSmoke
            Panel8.BackColor = Color.WhiteSmoke
            Panel9.BackColor = Color.WhiteSmoke
            Panel10.BackColor = Color.WhiteSmoke
            Panel11.BackColor = Color.WhiteSmoke
            Panel12.BackColor = Color.WhiteSmoke
            Panel13.BackColor = Color.WhiteSmoke
            Panel14.BackColor = Color.WhiteSmoke
            Panel15.BackColor = Color.WhiteSmoke
            Panel17.BackColor = Color.WhiteSmoke

        End If

        On Error Resume Next
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True

        For fadeIN = 0.0 To 1 Step 1
            Me.Opacity = fadeIN
            Me.Refresh()
            Threading.Thread.Sleep(20)
        Next

        Me.Opacity = przenikanie
        On Error Resume Next

        'startowanie dodatkowego programu
        Process.Start(program)

        'weryfikacja licencji
        On Error Resume Next
        If My.Settings.WERYFIKACJA = "TAK" Then
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
            Panel9.Visible = False
            Panel10.Visible = False
            Panel11.Visible = False
            Panel12.Visible = False
            Panel13.Visible = False
            Panel14.Visible = False
            Panel15.Visible = False
            Panel17.Visible = False
        End If

        'Licencjonowanie
        'Dim Year_in_Digits = Year(Now)
        'If Year_in_Digits <> "2020" Then
        'My.Settings.WERYFIKACJA = "TAK"
        'Panel1.Visible = False
        'Panel2.Visible = False
        'Panel3.Visible = False
        'Panel4.Visible = False
        'Panel5.Visible = False
        'Panel6.Visible = False
        'Panel7.Visible = False
        'Panel8.Visible = False
        'Panel9.Visible = False
        'Panel10.Visible = False
        'Panel11.Visible = False
        'Panel12.Visible = False
        'Panel13.Visible = False
        'Panel14.Visible = False
        'Panel15.Visible = False
        'Panel17.Visible = False
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' czytanie konfiguracji
        On Error Resume Next
        Dim dat As New XQuickINI.xquickini()
        On Error Resume Next
        dat.Load("config.ini", False, True)
        On Error Resume Next
        czas = dat.GetSection("timer").GetKey("timer").GetValue()
        Timer1.Interval = czas

        Process.Start(program)
        On Error Resume Next

        ' odczyt wiadomosci
        Dim a As System.IO.TextReader
        Dim zawartoscPlikua As String
        a = System.IO.File.OpenText("dane1.txt")
        zawartoscPlikua = a.ReadLine
        dane1 = zawartoscPlikua
        a.Close()

        Dim b As System.IO.TextReader
        Dim zawartoscPlikub As String
        b = System.IO.File.OpenText("dane2.txt")
        zawartoscPlikub = b.ReadLine
        dane2 = zawartoscPlikub
        b.Close()

        'dane1 = My.Computer.FileSystem.ReadAllText("dane1.txt")
        'On Error Resume Next
        'dane2 = My.Computer.FileSystem.ReadAllText("dane2.txt")
        'On Error Resume Next
        dane3 = My.Computer.FileSystem.ReadAllText("dane3.txt")
        On Error Resume Next
        dane4 = My.Computer.FileSystem.ReadAllText("dane4.txt")
        On Error Resume Next
        dane5 = My.Computer.FileSystem.ReadAllText("dane5.txt")
        On Error Resume Next
        dane6 = My.Computer.FileSystem.ReadAllText("dane6.txt")
        On Error Resume Next
        dane7 = My.Computer.FileSystem.ReadAllText("dane7.txt")
        On Error Resume Next
        dane8 = My.Computer.FileSystem.ReadAllText("dane8.txt")
        On Error Resume Next

        Napis1.Text = informacja1
        Napis2.Text = informacja2
        Napis3.Text = informacja3
        Napis4.Text = informacja4
        Napis5.Text = informacja5
        Napis6.Text = informacja6
        Napis7.Text = informacja7
        Napis8.Text = informacja8
        Wpis1.Text = dane1
        Wpis2.Text = dane2
        Wpis3.Text = dane3
        Wpis4.Text = dane4
        Wpis5.Text = dane5
        Wpis6.Text = dane6
        Wpis7.Text = dane7
        Wpis8.Text = dane8

        Wpis1.ForeColor = Color.GreenYellow
        Wpis2.ForeColor = Color.GreenYellow
        Wpis3.ForeColor = Color.GreenYellow
        Wpis4.ForeColor = Color.GreenYellow
        Wpis5.ForeColor = Color.GreenYellow
        Wpis6.ForeColor = Color.GreenYellow
        Wpis7.ForeColor = Color.GreenYellow
        Wpis8.ForeColor = Color.GreenYellow

        Napis1.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis2.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis3.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis4.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis1.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis2.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis3.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis5.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis6.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis7.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis8.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis4.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis5.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis6.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis7.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis8.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next

        ' kolorowanie wynikow
        Napis1.ForeColor = Color.LavenderBlush
        Napis2.ForeColor = Color.LavenderBlush
        Napis3.ForeColor = Color.LavenderBlush
        Napis4.ForeColor = Color.LavenderBlush
        Napis5.ForeColor = Color.LavenderBlush
        Napis6.ForeColor = Color.LavenderBlush
        Napis7.ForeColor = Color.LavenderBlush
        Napis8.ForeColor = Color.LavenderBlush

        Wpis1.ForeColor = Color.LavenderBlush
        Wpis2.ForeColor = Color.LavenderBlush
        Wpis3.ForeColor = Color.LavenderBlush
        Wpis4.ForeColor = Color.LavenderBlush
        Wpis5.ForeColor = Color.LavenderBlush
        Wpis6.ForeColor = Color.LavenderBlush
        Wpis7.ForeColor = Color.LavenderBlush
        Wpis8.ForeColor = Color.LavenderBlush

        ' kolorowanie
        If dane1 > prog1 Then
            Dim acolor As Color
            acolor = Color.FromName(kolor1w)
            Wpis1.ForeColor = acolor
        End If

        If dane1 < prog1 Then
            Dim acolor As Color
            acolor = Color.FromName(kolor1m)
            Wpis1.ForeColor = acolor
        End If

        If dane1 = prog1 Then

            Dim acolor As Color
            acolor = Color.FromName(kolor1r)
            Wpis1.ForeColor = acolor
        End If

        If dane2 > prog2 Then
            Dim acolor2w As Color
            Dim name As String = kolor2w
            acolor2w = Color.FromName(name)
            Wpis2.ForeColor = acolor2w
        End If

        If dane2 < prog2 Then
            Dim acolor2m As Color
            Dim name As String = kolor2w
            acolor2m = Color.FromName(name)
            Wpis2.ForeColor = acolor2m
        End If

        If dane2 = prog2 Then
            Dim acolor2r As Color
            Dim name As String = kolor2w
            acolor2r = Color.FromName(name)
            Wpis2.ForeColor = acolor2r
        End If

        If dane3 > prog3 Then
            Dim acolor3w As Color
            Dim name As String = kolor3w
            acolor3w = Color.FromName(name)
            Wpis3.ForeColor = acolor3w
        End If

        If dane3 < prog3 Then
            Dim acolor3m As Color
            Dim name As String = kolor3w
            acolor3m = Color.FromName(name)
            Wpis3.ForeColor = acolor3m
        End If

        If dane3 = prog3 Then
            Dim acolor3r As Color
            Dim name As String = kolor3w
            acolor3r = Color.FromName(name)
            Wpis3.ForeColor = acolor3r
        End If

        If dane4 > prog4 Then
            Dim acolor4w As Color
            Dim name As String = kolor4w
            acolor4w = Color.FromName(name)
            Wpis4.ForeColor = acolor4w
        End If

        If dane4 < prog4 Then
            Dim acolor4m As Color
            Dim name As String = kolor4w
            acolor4m = Color.FromName(name)
            Wpis4.ForeColor = acolor4m
        End If

        If dane4 = prog4 Then
            Dim acolor4r As Color
            Dim name As String = kolor4w
            acolor4r = Color.FromName(name)
            Wpis4.ForeColor = acolor4r
        End If

        If dane5 > prog5 Then
            Dim acolor5w As Color
            Dim name As String = kolor5w
            acolor5w = Color.FromName(name)
            Wpis5.ForeColor = acolor5w
        End If

        If dane5 < prog5 Then
            Dim acolor5m As Color
            Dim name As String = kolor5w
            acolor5m = Color.FromName(name)
            Wpis5.ForeColor = acolor5m
        End If

        If dane5 = prog5 Then
            Dim acolor5r As Color
            Dim name As String = kolor5w
            acolor5r = Color.FromName(name)
            Wpis5.ForeColor = acolor5r
        End If

        If dane6 > prog6 Then
            Dim acolor6w As Color
            Dim name As String = kolor6w
            acolor6w = Color.FromName(name)
            Wpis6.ForeColor = acolor6w
        End If

        If dane6 < prog6 Then
            Dim acolor6m As Color
            Dim name As String = kolor6w
            acolor6m = Color.FromName(name)
            Wpis6.ForeColor = acolor6m
        End If

        If dane6 = prog6 Then
            Dim acolor6r As Color
            Dim name As String = kolor6w
            acolor6r = Color.FromName(name)
            Wpis6.ForeColor = acolor6r
        End If

        If dane7 > prog7 Then
            Dim acolor7w As Color
            Dim name As String = kolor7w
            acolor7w = Color.FromName(name)
            Wpis7.ForeColor = acolor7w
        End If

        If dane7 < prog7 Then
            Dim acolor7m As Color
            Dim name As String = kolor7w
            acolor7m = Color.FromName(name)
            Wpis7.ForeColor = acolor7m
        End If

        If dane7 = prog7 Then
            Dim acolor7r As Color
            Dim name As String = kolor7w
            acolor7r = Color.FromName(name)
            Wpis7.ForeColor = acolor7r
        End If

        If dane8 > prog8 Then
            Dim acolor8w As Color
            Dim name As String = kolor8w
            acolor8w = Color.FromName(name)
            Wpis8.ForeColor = acolor8w
        End If

        If dane8 < prog8 Then
            Dim acolor8m As Color
            Dim name As String = kolor8w
            acolor8m = Color.FromName(name)
            Wpis8.ForeColor = acolor8m
        End If

        If dane8 = prog8 Then
            Dim acolor8r As Color
            Dim name As String = kolor8w
            acolor8r = Color.FromName(name)
            Wpis8.ForeColor = acolor8r
        End If
    End Sub
    Private Sub WpisNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Process.Start("konsola.vbs")
        On Error Resume Next

        ' odczyt wiadomosci

        dane1 = My.Computer.FileSystem.ReadAllText("dane1.txt")
        On Error Resume Next
        dane2 = My.Computer.FileSystem.ReadAllText("dane2.txt")
        On Error Resume Next
        dane3 = My.Computer.FileSystem.ReadAllText("dane3.txt")
        On Error Resume Next
        dane4 = My.Computer.FileSystem.ReadAllText("dane4.txt")
        On Error Resume Next
        dane5 = My.Computer.FileSystem.ReadAllText("dane5.txt")
        On Error Resume Next
        dane6 = My.Computer.FileSystem.ReadAllText("dane6.txt")
        On Error Resume Next
        dane7 = My.Computer.FileSystem.ReadAllText("dane7.txt")
        On Error Resume Next
        dane8 = My.Computer.FileSystem.ReadAllText("dane8.txt")
        On Error Resume Next

        Napis1.Text = informacja1
        Napis2.Text = informacja2
        Napis3.Text = informacja3
        Napis4.Text = informacja4
        Napis5.Text = informacja5
        Napis6.Text = informacja6
        Napis7.Text = informacja7
        Napis8.Text = informacja8
        Wpis1.Text = dane1
        Wpis2.Text = dane2
        Wpis3.Text = dane3
        Wpis4.Text = dane4
        Wpis5.Text = dane5
        Wpis6.Text = dane6
        Wpis7.Text = dane7
        Wpis8.Text = dane8

        Napis1.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis2.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis3.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis4.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis1.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis2.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis3.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis5.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis6.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis7.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Napis8.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis4.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis5.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis6.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis7.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
        Wpis8.Font = New System.Drawing.Font("Microsoft Sans Serif", rozmiarfont)
        On Error Resume Next
    End Sub
End Class