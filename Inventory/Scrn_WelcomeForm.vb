Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Net.Security
Module GlobalVariables
    Public loggedUserID As Integer = -1



End Module
Public Class Scrn_WelcomeForm


    'Function to call on login'
    Private Function UserLogIn(UN As String, PW As String) As Boolean
        Dim isValid As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM usr_data WHERE Username = @Username AND Password = @Password"

        Using conn As New SqlConnection("Data Source=LAPTOP-ONBUH1BD\SQLEXPRESS01;Initial Catalog=lptp_invntry;Integrated Security=True;TrustServerCertificate=True")
            Using comm As New SqlCommand(query, conn)
                comm.Parameters.AddWithValue("@Username", UN)
                comm.Parameters.AddWithValue("@Password", PW)

                Try
                    conn.Open()
                    Dim result As Integer = Convert.ToInt32(comm.ExecuteScalar())
                    If result > 0 Then
                        isValid = True

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Username or Password is incorrect")
                End Try
            End Using
        End Using

        Return isValid
    End Function

    Private Function GetUserID(UN As String, PW As String) As Integer
        Dim userID As Integer = -1 ' Initialize with a default value
        Dim query As String = "SELECT ID FROM usr_data WHERE Username = @Username AND Password = @Password"

        Using conn As New SqlConnection("Data Source=LAPTOP-ONBUH1BD\SQLEXPRESS01;Initial Catalog=lptp_invntry;Integrated Security=True;TrustServerCertificate=True")
            Using comm As New SqlCommand(query, conn)
                comm.Parameters.AddWithValue("@Username", UN)
                comm.Parameters.AddWithValue("@Password", PW)

                Try
                    conn.Open()
                    Dim result As Object = comm.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        userID = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error")
                End Try
            End Using
        End Using

        Return userID
    End Function


    Private Function UserSignUp(strGn As String, strLN As String, strUN As String, strPW As String, strUT As String) As Boolean
        Dim success As Boolean = False
        Dim query As String = String.Empty
        query &= "INSERT INTO usr_data (Given_Name, Last_Name, UserName, Password, UserType)"
        query &= "VALUES (@Given_Name, @Last_Name,@UserName, @Password, @UserType)"

        Using conn As New SqlConnection("Data Source=LAPTOP-ONBUH1BD\SQLEXPRESS01;Initial Catalog=lptp_invntry;Integrated Security=True;TrustServerCertificate=True")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Given_Name", strGn)
                    .Parameters.AddWithValue("@Last_Name", strLN)
                    .Parameters.AddWithValue("@Username", strUN)
                    .Parameters.AddWithValue("@Password", strPW)
                    .Parameters.AddWithValue("@UserType", strUT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    ' If the execution reached here, the data insertion was successful
                    success = True
                    'Reset controls to blank    
                    For Each Control As Control In Me.grp_signup.Controls
                        If TypeOf Control Is TextBox Then
                            Control.Text = String.Empty
                        End If
                    Next

                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Unable to add data")
                End Try
            End Using
        End Using

        Return success
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grp_signup.Visible = False
        grp_signIn.Visible = True

    End Sub



    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim strGN As String = txt_gn.Text
        Dim strLN As String = txt_ln.Text
        Dim strUN As String = txt_un.Text
        Dim strPW As String = txt_pw.Text
        Dim strUT As String = "Teacher" 'cmbUserT.SelectedItem.ToString()

        If UserSignUp(strGN, strLN, strUN, strPW, strUT) Then
            MessageBox.Show("User signed up successfully")
            Me.Hide()
            grp_signIn.Show()
        Else
            MessageBox.Show("Unable to sign up user")
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_signIn.LinkClicked
        grp_signup.Visible = False
        grp_signIn.Visible = True
    End Sub

    Private Sub lnk_signUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_signUp.LinkClicked
        grp_signup.Visible = True
        grp_signIn.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'button sample for login'
        Dim username As String = txt_login_un.Text
        Dim password As String = txt_login_pw.Text
        Dim valid As Boolean = UserLogIn(username, password)
        If valid = True Then
            ' Login successful
            ' Proceed to next form or do any other action
            MessageBox.Show("Login successful")
            Dim userID As Integer = GetUserID(username, password)
            GlobalVariables.loggedUserID = userID
            Dim gridform As New Form2()
            gridform.Show()
            Me.Hide()
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

    Private Sub txt_pw_TextChanged(sender As Object, e As EventArgs) Handles txt_pw.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Adm_frm.Show()
        Me.Hide()

    End Sub

    Private Sub grp_signIn_Enter(sender As Object, e As EventArgs) Handles grp_signIn.Enter

    End Sub
End Class
