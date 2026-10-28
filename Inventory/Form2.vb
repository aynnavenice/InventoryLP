Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lptp_invntryDataSet2.inv_data' table. You can move, or remove it, as needed.
        Me.Inv_dataTableAdapter.Fill(Me.Lptp_invntryDataSet2.inv_data)
        FillByToolStrip.Visible = False
        Dim userID = GlobalVariables.loggedUserID


        Me.Inv_dataTableAdapter.FillBy(Me.Lptp_invntryDataSet2.inv_data, userID)
        Dim asst_stat As String() = {"", "Working", "Not Working", "Missing"}
        cmb_asst_stat.Items.AddRange(asst_stat)
        cmb_asst_stat.SelectedIndex = 0

        Dim inv_stat As String() = {"", "Active", "Retuned", "Deleted"}
        cmb_inv_status.Items.AddRange(inv_stat)
        cmb_inv_status.SelectedIndex = 0


    End Sub




    Private Sub resetgrid()
        Dim userID = GlobalVariables.loggedUserID
        'Me.FillByTeacherToolStripButton.Visible = False
        Me.Inv_dataTableAdapter.FillBy(Me.Lptp_invntryDataSet2.inv_data, userID)
    End Sub

    Private Sub Logout()
        GlobalVariables.loggedUserID = -1
        resetgrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Asset_Grid.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedrow As DataGridViewRow = Asset_Grid.Rows(e.RowIndex)
            Dim drv As DataRowView = CType(selectedrow.DataBoundItem, DataRowView)

            txt_asst_id.Text = selectedrow.Cells(2).Value.ToString()
            txt_asst_sn.Text = selectedrow.Cells(3).Value.ToString()
            txt_Stdnt_Nm.Text = selectedrow.Cells(0).Value.ToString()
            txt_stdnt_sctn.Text = selectedrow.Cells(1).Value.ToString()
            txt_asst_inc.Text = selectedrow.Cells(5).Value.ToString()
            cmb_asst_stat.SelectedItem = selectedrow.Cells(4).Value.ToString()
            cmb_inv_status.SelectedItem = selectedrow.Cells(6).Value.ToString()


        End If
    End Sub

    Private Sub ResetControls()
        'Reset control values upon add or update
        txt_asst_id.Text = ""
        txt_asst_sn.Text = ""
        txt_Stdnt_Nm.Text = ""
        txt_stdnt_sctn.Text = ""
        txt_asst_inc.Text = ""
        cmb_asst_stat.SelectedIndex = -1
        cmb_inv_status.SelectedIndex = -1

    End Sub




    'Create Asset Records
    Private Sub btn_addrecord_Click(sender As Object, e As EventArgs) Handles btn_addrecord.Click

        Dim StrAsst_SN As String = txt_asst_sn.Text
        Dim StrAsst_ID As String = txt_asst_id.Text
        Dim StrAsst_StdtNm As String = txt_Stdnt_Nm.Text
        Dim StrAsst_StdtSc As String = txt_stdnt_sctn.Text
        Dim StrAsst_Inc As String = txt_asst_inc.Text
        Dim StrAsst_Stat As String = cmb_asst_stat.SelectedItem.ToString()
        Dim StrInv_Stat As String = cmb_inv_status.SelectedItem.ToString()
        Dim StrTchr_ID As Integer = GlobalVariables.loggedUserID

        Dim query As String = String.Empty
        query &= "INSERT INTO inv_data (Serial_Number, Asset_ID, Student_Name, Student_Section, Asset_Status, Teacher_ID, Inclusion, Inventory_Status)"
        query &= "VALUES (@Serial_Number, @Asset_ID, @Student_Name, @Student_Section, @Asset_Status, @Teacher_ID, @Inclusion, @Inventory_Status)"

        Using conn As New SqlConnection("Data Source=LAPTOP-ONBUH1BD\SQLEXPRESS01;Initial Catalog=lptp_invntry;Integrated Security=True;TrustServerCertificate=True")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Serial_Number", StrAsst_SN)
                    .Parameters.AddWithValue("@Asset_ID", StrAsst_ID)
                    .Parameters.AddWithValue("@Student_Name", StrAsst_StdtNm)
                    .Parameters.AddWithValue("@Student_Section", StrAsst_StdtSc)
                    .Parameters.AddWithValue("@Asset_Status", StrAsst_Stat)
                    .Parameters.AddWithValue("@Teacher_ID", StrTchr_ID)
                    .Parameters.AddWithValue("@Inclusion", StrAsst_Inc)
                    .Parameters.AddWithValue("@Inventory_Status", StrInv_Stat)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                    Dim refreshquery As String = "Select * From inv_data Where Teacher_ID =" & GlobalVariables.loggedUserID.ToString()
                    Using refreshcomm As New SqlCommand(refreshquery, conn)
                        Using adapter As New SqlDataAdapter(refreshcomm)
                            Dim dt As New DataTable()
                            adapter.Fill(dt)
                            Asset_Grid.DataSource = dt
                        End Using
                    End Using

                    ResetControls()



                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Unable to add data")

                End Try
            End Using
        End Using
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Logout()
        Scrn_WelcomeForm.Show()
        Me.Hide()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Inv_dataTableAdapter.FillBy(Me.Lptp_invntryDataSet2.inv_data, CType(Teacher_IDToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub UpdateDatabase(selectedRow As DataGridViewRow)
    'Dim conn As New OleDbConnection("Data Source=LAPTOP-ONBUH1BD\SQLEXPRESS01;Initial Catalog=lptp_invntry;Integrated Security=True;TrustServerCertificate=True")
    'Dim cmd As New OleDbCommand()
    'Dim selectedID As Integer = Convert.ToInt32(selectedRow.Cells(7).Value)

    'Try
    '       conn.Open()
    'Dim sql As String = "UPDATE inv_data SET Serial_Number = @Serial_Number, " &
    '                       "Asset_ID = @Asset_ID, " &
    '                      "Stundent_Name = @Student_Name, " &
    '                     "Student_Section = @Student_Section, " &
    '                    "Asset_Status = @Asset_Status, " &
    '                   "Inclustion = @Inclusion " &
    '                  "Inventory_Status = @Inventory_Status " &
    '                 "WHERE ID = @ID"

    'cmd = New OleDbCommand(sql, conn)
    'cmd.Parameters.AddWithValue("@Serial_Number", txt_asst_sn.Text)
    'cmd.Parameters.AddWithValue("@Asset_ID", txt_asst_id.Text)
    'cmd.Parameters.AddWithValue("@Student_Name", txt_Stdnt_Nm.Text)
    'cmd.Parameters.AddWithValue("@Student_Section", txt_stdnt_sctn.Text)
    'cmd.Parameters.AddWithValue("@Inclusion", txt_asst_inc.Text)
    'cmd.Parameters.AddWithValue("@Asset_Status", cmb_asst_stat.SelectedItem.ToString())
    'cmd.Parameters.AddWithValue("@Inventory_Status", cmb_inv_status.SelectedItem.ToString())
    'cmd.Parameters.AddWithValue("@ID", selectedID)

    'cmd.ExecuteNonQuery()
    'MessageBox.Show("Record updated successfully")
    'GlobalVariables.updatemode = "Add"

    'Catch ex As Exception
    '   MessageBox.Show("Error updating record: " & ex.Message)
    'Finally
    '   conn.Close()
    'End Try
    'End Sub


    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillByToolStrip.ItemClicked
        Me.Hide()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_update_record.Click
        If Asset_Grid.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = Asset_Grid.CurrentRow
            Dim drv As DataRowView = CType(selectedRow.DataBoundItem, DataRowView)
            Dim userID As Integer = GlobalVariables.loggedUserID
            ' Get the DataRow associated with the DataGridViewRow
            Dim row As DataRow = drv.Row

            ' Get the ID of the record you want to update
            Dim recordID As Integer = CInt(row(0))

            ' Get the values from the text fields and dropdowns
            Dim StrAsst_SN As String = txt_asst_sn.Text
            Dim StrAsst_ID As String = txt_asst_id.Text
            Dim StrAsst_StdtNm As String = txt_Stdnt_Nm.Text
            Dim StrAsst_StdtSc As String = txt_stdnt_sctn.Text
            Dim StrAsst_Inc As String = txt_asst_inc.Text
            Dim StrAsst_Stat As String = cmb_asst_stat.SelectedItem.ToString()
            Dim StrInv_Stat As String = cmb_inv_status.SelectedItem.ToString()
            Dim StrTchr_ID As Integer = GlobalVariables.loggedUserID
            ' Repeat for other text fields and dropdowns as needed

            Try
                ' Update the record in the SQL database
                Using conn As New SqlConnection("Data Source=LAPTOP-ONBUH1BD\SQLEXPRESS01;Initial Catalog=lptp_invntry;Integrated Security=True;TrustServerCertificate=True")
                    conn.Open()
                    Dim query As String = "UPDATE inv_data SET Serial_Number = @Serial_Number, Asset_ID = @Asset_ID, Student_Name = @Student_Name, Student_Section = @Student_Section, Inclusion = @Inclusion, Asset_Status=@Asset_Status, Inventory_Status = @Inventory_Status WHERE Transaction_ID = @Transaction_ID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Serial_Number", txt_asst_sn.Text)
                        cmd.Parameters.AddWithValue("@Asset_ID", txt_asst_id.Text)
                        cmd.Parameters.AddWithValue("@Student_Name", txt_Stdnt_Nm.Text)
                        cmd.Parameters.AddWithValue("@Student_Section", txt_stdnt_sctn.Text)
                        cmd.Parameters.AddWithValue("@Inclusion", txt_asst_inc.Text)
                        cmd.Parameters.AddWithValue("@Asset_Status", cmb_asst_stat.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@Inventory_Status", cmb_inv_status.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@Transaction_ID", recordID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Update the DataRow in the DataTable but it returns string representation rather than actual value
                'row("Serial_Number") = txt_asst_sn.ToString()

                ' Repeat for other columns as needed

                ' Update the underlying DataTable
                Me.Lptp_invntryDataSet1.invtry_data.AcceptChanges()
                MsgBox("Record updated successfully.")
                ResetControls()

                Me.Inv_dataTableAdapter.FillBy(Me.Lptp_invntryDataSet2.inv_data, userID)
            Catch ex As Exception
                MsgBox("Error updating record: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Asset_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Asset_Grid.CellContentClick

    End Sub
End Class
