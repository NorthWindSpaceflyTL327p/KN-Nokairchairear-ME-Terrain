Public Class Cube_Editor
    Public Shared Volume_Cube_Edited, X_Size_Cube_Edited, Y_Size_Cube_Edited, Z_Size_Cube_Edited As Double
    Public Shared X_Pos_Cube_Edited, Y_Pos_Cube_Edited, Z_Pos_Cube_Edited As Double
    Dim Sumary_Raw_Output_Edited As Double
    Private Sub Cube_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        Update_Timer.Start()
    End Sub
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Kernal.Enabled = True
        Kernal.Update_SizePos_Row(X_Size_Cube_Edited, Y_Size_Cube_Edited, Z_Size_Cube_Edited, X_Pos_Cube_Edited, Y_Pos_Cube_Edited, Z_Pos_Cube_Edited)

        Me.Hide()
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Update_Timer.Stop()
        Me.Close()
        Kernal.Enabled = True
    End Sub

    Private Sub Update_Timer_Tick(sender As Object, e As EventArgs) Handles Update_Timer.Tick
        Update_TP()
    End Sub

    Sub Update_TP()
        If TextBox1.Text = "" Then

        Else
            If ComboBox1.Text = "เมตร" Then
                X_Size_Cube_Edited = (TextBox1.Text)
            ElseIf ComboBox1.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox1.Text)
                X_Size_Cube_Edited = Input / 100
            ElseIf ComboBox1.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox1.Text)
                X_Size_Cube_Edited = Input * 1000
            ElseIf ComboBox1.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox1.Text)
                X_Size_Cube_Edited = Input / 1000
            Else

            End If
        End If

        If TextBox2.Text = "" Then

        Else
            If ComboBox2.Text = "เมตร" Then
                Y_Size_Cube_Edited = (TextBox2.Text)
            ElseIf ComboBox2.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox2.Text)
                Y_Size_Cube_Edited = Input / 100
            ElseIf ComboBox2.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox2.Text)
                Y_Size_Cube_Edited = Input * 1000
            ElseIf ComboBox2.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox2.Text)
                Y_Size_Cube_Edited = Input / 1000
            Else

            End If
        End If

        If TextBox3.Text = "" Then

        Else
            If ComboBox3.Text = "เมตร" Then
                Z_Size_Cube_Edited = (TextBox3.Text)
            ElseIf ComboBox3.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox3.Text)
                Z_Size_Cube_Edited = Input / 100
            ElseIf ComboBox3.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox3.Text)
                Z_Size_Cube_Edited = Input * 1000
            ElseIf ComboBox3.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox3.Text)
                Z_Size_Cube_Edited = Input / 1000
            End If
        End If

        If TextBox4.Text = "" Then

        Else
            If ComboBox4.Text = "เมตร" Then
                X_Pos_Cube_Edited = (TextBox4.Text)
            ElseIf ComboBox4.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox4.Text)
                X_Pos_Cube_Edited = Input / 100
            ElseIf ComboBox4.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox4.Text)
                X_Pos_Cube_Edited = Input * 1000
            ElseIf ComboBox4.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox4.Text)
                X_Pos_Cube_Edited = Input / 1000
            End If
        End If

        If TextBox5.Text = "" Then

        Else
            If ComboBox5.Text = "เมตร" Then
                Y_Pos_Cube_Edited = (TextBox5.Text)
            ElseIf ComboBox5.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox5.Text)
                Y_Pos_Cube_Edited = Input / 100
            ElseIf ComboBox5.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox5.Text)
                Y_Pos_Cube_Edited = Input * 1000
            ElseIf ComboBox5.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox5.Text)
                Y_Pos_Cube_Edited = Input / 1000
            End If
        End If

        If TextBox6.Text = "" Then

        Else
            If ComboBox6.Text = "เมตร" Then
                Z_Pos_Cube_Edited = (TextBox6.Text)
            ElseIf ComboBox6.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox6.Text)
                Z_Pos_Cube_Edited = Input / 100
            ElseIf ComboBox6.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox6.Text)
                Z_Pos_Cube_Edited = Input * 1000
            ElseIf ComboBox6.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox6.Text)
                Z_Pos_Cube_Edited = Input / 1000
            End If
        End If

        If ComboBox7.Text = "คิว-ลูกบาศก์เมตร" Then
            Sumary_Raw_Output_Edited = ((X_Size_Cube_Edited * Y_Size_Cube_Edited) * Z_Size_Cube_Edited)
        ElseIf ComboBox7.Text = "ลูกบาศก์เซนติเมตร" Then
            Sumary_Raw_Output_Edited = (((X_Size_Cube_Edited * Y_Size_Cube_Edited) * Z_Size_Cube_Edited) * 1000000)
        ElseIf ComboBox7.Text = "ลูกบาศก์กิโลเมตร" Then
            Sumary_Raw_Output_Edited = (((X_Size_Cube_Edited * Y_Size_Cube_Edited) * Z_Size_Cube_Edited) / 1000000000)
        ElseIf ComboBox7.Text = "ลิตร" Then
            Sumary_Raw_Output_Edited = (((X_Size_Cube_Edited * Y_Size_Cube_Edited) * Z_Size_Cube_Edited) * 1000)
        Else

        End If

        Label_Volume_Object.Text = Sumary_Raw_Output_Edited.ToString("0.000000")
        Cube.Volume_Cube = Sumary_Raw_Output_Edited
        'Kernal.Update_SizePos_Row(X_Size_Cube_Edited, Y_Size_Cube_Edited, Z_Size_Cube_Edited, X_Pos_Cube_Edited, Y_Pos_Cube_Edited, Z_Pos_Cube_Edited)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Update_TP()
        If e.KeyCode = Keys.Enter Then
            TextBox2.Select()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Update_TP()
        If e.KeyCode = Keys.Enter Then
            TextBox3.Select()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        Update_TP()
        If e.KeyCode = Keys.Enter Then
            TextBox4.Select()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        Update_TP()
        If e.KeyCode = Keys.Enter Then
            TextBox5.Select()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        Update_TP()
        If e.KeyCode = Keys.Enter Then
            TextBox6.Select()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        Update_TP()
        If e.KeyCode = Keys.Enter Then
            Button_Save.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class