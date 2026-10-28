Public Class Adm_frm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lptp_invntryDataSet5.inv_data' table. You can move, or remove it, as needed.
        Me.Inv_dataTableAdapter.Fill(Me.Lptp_invntryDataSet5.inv_data)
        'TODO: This line of code loads data into the 'Lptp_invntryDataSet3.invtry_data' table. You can move, or remove it, as needed.
        Me.Invtry_dataTableAdapter.Fill(Me.Lptp_invntryDataSet3.invtry_data)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure want to sign out?", "SIGN OUT",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then

            Me.Hide()
            Scrn_WelcomeForm.Show()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.show()
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(30, 30, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class