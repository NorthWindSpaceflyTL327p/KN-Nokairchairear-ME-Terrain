Public Class AddNewObject
    Public Shared Object_Type As String
    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Kernal.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click

        If RadioButton1.Checked Then

            Object_Type = "1"
            Cube.Show()

        ElseIf RadioButton2.Checked Then

            Object_Type = "2"
            Cylinder.Show()

        ElseIf RadioButton3.Checked Then

            Object_Type = "3"
            Prism.Show()

        ElseIf RadioButton4.Checked Then

            Object_Type = "4"

        ElseIf RadioButton5.Checked Then

            Object_Type = "5"

        ElseIf RadioButton6.Checked Then

            Object_Type = "6"
            Ball.Show()

        ElseIf RadioButton7.Checked Then

            Object_Type = "7"

        ElseIf RadioButton8.Checked Then

            Object_Type = "8"

        Else

            MessageBox.Show("ไม่สามารถดำเนินการได้")

        End If
        Me.Close()
    End Sub

    Private Sub AddNewObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddNewObject_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadioButton1_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadioButton2_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadioButton3_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadioButton4_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadioButton5_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadioButton6_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadioButton7_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadioButton8_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton8.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Enter.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            Button_Cancel.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

End Class