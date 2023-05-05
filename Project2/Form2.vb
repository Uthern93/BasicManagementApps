﻿Public Class Form2
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\uther\Downloads\Polimas\Semester 4\Visual Basic\Project2\CoopMart.accdb")
    Dim side As String = "Close"
    Private Sub Timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If side = "Open" Then
            SideBar.Width += 20
            BtnAccount.Show()
            BtnHomepage.Show()
            BtnStation.Show()
            BtnConfec.Show()
            If SideBar.Width >= 160 Then
                side = "Close"
                Timer1.Stop()
            End If
        Else
            SideBar.Width -= 20
            BtnAccount.Hide()
            BtnHomepage.Hide()
            BtnStation.Hide()
            BtnConfec.Hide()
            If SideBar.Width <= 65 Then
                side = "Open"
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub BtnSlide_Click(sender As Object, e As EventArgs) Handles BtnSlide.Click
        Timer1.Start()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        Me.Hide()
        Dim Form2 As New Form2
        Form2.Show()
    End Sub

    Private Sub BtnHomepage_Click(sender As Object, e As EventArgs) Handles BtnHomepage.Click
        Me.Hide()
        Dim Form1 As New Form1
        Form1.Show()
    End Sub

    Private Sub BtnStation_Click(sender As Object, e As EventArgs) Handles BtnStation.Click
        Me.Hide()
        Dim Form4 As New Form4
        Form4.Show()
    End Sub

    Private Sub BtnConfec_Click(sender As Object, e As EventArgs) Handles BtnConfec.Click
        Me.Hide()
        Dim Form5 As New Form5
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'first method
        If TextEmail.Text = "" Then
            MessageBox.Show("Please Enter Email")
            TextEmail.Focus()
            Exit Sub
        ElseIf TextPassword.Text = "" Then
            MessageBox.Show("Please Enter The Password")
            TextPassword.Focus()
        Else
            MessageBox.Show("You Have Successfully Log In!")
            Me.Hide()
            Dim Form1 As New Form1
            Form1.Show()
        End If

        'second method
        'email
        If String.IsNullOrEmpty(TextEmail.Text.Trim) Then
            ErrorProvider1.SetError(TextEmail, "Please Enter The Email")
            TextEmail.Focus()
        Else
            ErrorProvider1.SetError(TextEmail, String.Empty)
        End If
        'Password
        If String.IsNullOrEmpty(TextPassword.Text.Trim) Then
            ErrorProvider1.SetError(TextPassword, "Please Enter The Password")
            TextPassword.Focus()
        Else
            ErrorProvider1.SetError(TextPassword, String.Empty)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim Form3 As New Form3
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Dim Form7 As New Form7
        Form7.Show()
    End Sub
End Class