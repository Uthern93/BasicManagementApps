Public Class Form3
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\uther\Downloads\Polimas\Semester 4\Visual Basic\Project2\CoopMart.accdb")
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim Form1 As New Form1
        Form1.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(FirstNameTextBox.Text.Trim) Then
            ErrorProvider1.SetError(FirstNameTextBox, "Please Enter Your First Name")
            FirstNameTextBox.Focus()
        Else
            ErrorProvider1.SetError(FirstNameTextBox, String.Empty)
        End If
        'lastname
        If String.IsNullOrEmpty(LastNameTextBox.Text.Trim) Then
            ErrorProvider1.SetError(LastNameTextBox, "Please Enter The Last Name")
            LastNameTextBox.Focus()
        Else
            ErrorProvider1.SetError(LastNameTextBox, String.Empty)
        End If
        'Password
        If String.IsNullOrEmpty(PasswordTextBox.Text.Trim) Then
            ErrorProvider1.SetError(PasswordTextBox, "Please Enter The Password")
            PasswordTextBox.Focus()
        Else
            ErrorProvider1.SetError(PasswordTextBox, String.Empty)
        End If

        Try
                Dim sql As String
                Dim cmd As New OleDb.OleDbCommand
                con.Open()
            sql = "INSERT INTO tblCustomer ([FirstName],[LastName],[Email],[Password]) values ('" & Trim(FirstNameTextBox.Text) & "', '" & Trim(LastNameTextBox.Text) & "','" & Trim(EmailTextBox.Text) & "','" & Trim(PasswordTextBox.Text) & "');"
            cmd.Connection = con
                cmd.CommandText = sql
                Dim i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("New record has been inserted successfully!")
                Else
                    MsgBox("No record has been inserted successfully!")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

            End Try
            MessageBox.Show("You Have Successfully Signup!", "Thank you for Signing up")
        Me.Hide()
        Dim Form2 As New Form2
        Form2.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoopMartDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.CoopMartDataSet.tblCustomer)
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

    Private Sub TblCustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblCustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CoopMartDataSet)

    End Sub

End Class