Public Class Sumary_Board

    Private Sub Button_CLose_Click(sender As Object, e As EventArgs) Handles Button_CLose.Click
        Me.Close()
    End Sub

    Private Sub Sumary_Board_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "คิว-ลูกบาศก์เมตร" Then
            Label2.Text = "รวม : " & (Kernal.Object_Volume) & " ลูกบาศก์เมตร"
        ElseIf ComboBox1.Text = "ลูกบาศก์เซนติเมตร" Then
            Label2.Text = "รวม : " & (Kernal.Object_Volume * 1000000) & " ลูกบาศก์เซนติเมตร"
        ElseIf ComboBox1.Text = "ลูกบาศก์กิโลเมตร" Then
            Label2.Text = "รวม : " & (Kernal.Object_Volume / 1000000000) & " ลูกบาศก์กิโลเมตร"
        ElseIf ComboBox1.Text = "ลิตร" Then
            Label2.Text = "รวม : " & (Kernal.Object_Volume * 1000) & " ลิตร"
        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Sumary_Volumetric_Print.Show()

    End Sub

End Class