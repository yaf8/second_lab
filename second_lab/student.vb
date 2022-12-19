Public Class student
    Public IDNO As String
    Public Fname As String
    Public Lname As String

    'Public Sub Readdata(ByVal ID As String, ByVal Name1 As String, ByVal Name2 As String)
    Public Sub Readdata()

        Dialog1.TextBoxID.Clear()
        Dialog1.TextBoxFname.Clear()
        Dialog1.TextBoxLname.Clear()


        'IDNO = ID
        'Fname = Name1
        'Lname = Name2

        Dialog1.ShowDialog()

        IDNO = Dialog1.TextBoxID.Text
        Fname = Dialog1.TextBoxFname.Text
        Lname = Dialog1.TextBoxLname.Text

    End Sub

End Class
