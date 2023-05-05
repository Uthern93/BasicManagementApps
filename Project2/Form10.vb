Public Class Form10
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\uther\Downloads\Polimas\Semester 4\Visual Basic\Project2\CoopMart.accdb")
    Dim side As String = "Close"
    Private Sub Timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If side = "Open" Then
            SideBar.Width += 20
            BtnAccount.Show()
            BtnHomepage.Show()
            BtnStock.Show()
            BtnLogout.Show()
            If SideBar.Width >= 160 Then
                side = "Close"
                Timer1.Stop()
            End If
        Else
            SideBar.Width -= 20
            BtnAccount.Hide()
            BtnHomepage.Hide()
            BtnStock.Hide()
            BtnLogout.Hide()
            If SideBar.Width <= 65 Then
                side = "Open"
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BtnSlide_Click(sender As Object, e As EventArgs) Handles BtnSlide.Click
        Timer1.Start()
    End Sub

    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        Me.Hide()
        Dim Form9 As New Form9
        Form9.Show()
    End Sub

    Private Sub BtnStock_Click(sender As Object, e As EventArgs) Handles BtnStock.Click
        Me.Hide()
        Dim Form8 As New Form8
        Form8.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim Form7 As New Form7
        Form7.Show()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()

            If con.State = ConnectionState.Open Then
                MsgBox("Connected")
            Else
                MsgBox("Not Connected!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
End Class