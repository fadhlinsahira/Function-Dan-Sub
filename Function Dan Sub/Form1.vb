Public Class Form1

    Private Sub S1()
        lbl1.Text = "Data tersebut"
    End Sub


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        S1()
    End Sub



    Private Sub S2(ByRef strText As String)
        strText = "Hello " & strText
    End Sub


    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim strText As String = txt1.Text
        S2(strText)
        lbl2.Text = strText
    End Sub



    Private Function F1()
        Return "Hello"
    End Function


    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lbl3.Text = F1()
    End Function



    Private Function F2(ByVal strText2 As String)
        Return strText2
    End Function


    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim strText2 As String = txt2.Text
        lbl4.Text = F2(txt2.Text)
    End Function

End Class
