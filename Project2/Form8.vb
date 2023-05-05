Public Class Form8
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

    Private Sub BtnHomepage_Click(sender As Object, e As EventArgs) Handles BtnHomepage.Click
        Me.Hide()
        Dim Form10 As New Form10
        Form10.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim Form7 As New Form7
        Form7.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoopMartDataSet.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.CoopMartDataSet.tblProduct)
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

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "Select * from tblProduct"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub TblProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CoopMartDataSet)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "INSERT INTO tblProduct (ItemName,ItemCode,Price,Qty) values ('" & ItemNameTextBox.Text & "', '" & Val(ItemCodeTextBox.Text) & "'," & Val(PriceTextBox.Text) & "," & Val(QtyTextBox.Text) & ");"
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
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "UPDATE tblProduct SET ItemName='" & ItemNameTextBox.Text & "', ItemCode='" & Val(ItemCodeTextBox.Text) & "', " &
             " Price=" & Val(PriceTextBox.Text) & ", Qty=" & Val(QtyTextBox.Text) & " WHERE ID=" & Val(Me.Text) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")

            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value
        ItemNameTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value
        ItemCodeTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value
        PriceTextBox.Text = DataGridView1.CurrentRow.Cells(3).Value
        PriceTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "Delete * from tblProduct WHERE ID=" & Val(Me.Text) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been deleted successfully!")

            Else
                MsgBox("No record has been deleted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
End Class