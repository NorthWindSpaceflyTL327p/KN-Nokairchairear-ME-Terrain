Public Class Cube
    Public Shared Volume_Cube As Double ' ประกาศตัวแปร Internal "ปริมาตรลูกบากศ์"
    Public Shared X_Size_Cube As Double ' ประกาศตัวแปร Internal "ขนาดลูกบาก์แกน X"
    Public Shared Y_Size_Cube As Double ' ประกาศตัวแปร Internal "ขนาดลูกบาก์แกน Y"
    Public Shared Z_Size_Cube As Double ' ประกาศตัวแปร Internal "ขนาดลูกบาก์แกน Z"
    Dim Sumary_Raw_Output As Double ' 
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Kernal.Enabled = True ' เปิดให้ฟอร์ม Kernal สามารถแก้ไขได้
        Kernal.AddNewRow(Kernal.DataTable_Max_ID_Valve + 1, "Cube", "Cube", X_Size_Cube, Y_Size_Cube, Z_Size_Cube, 0, 0, 0) ' เพิ่มแถวข้อมูลบน Kernal
        Update_Data() ' อัพเดตข้อมูล
        Me.Close() ' ปิดฟอร์มนี้
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Kernal.Enabled = True ' เปิดให้ฟอร์ม Kernal สามารถแก้ไขได้
        Me.Close() ' ปิดฟอร์มนี้
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Update_Data() ' อัพเดตข้อมูล
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Update_Data() ' อัพเดตข้อมูล
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Update_Data() ' อัพเดตข้อมูล
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Update_Data() ' อัพเดตข้อมูล
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Update_Data() ' อัพเดตข้อมูล
    End Sub

    Private Sub Cube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select() ' เลื่อน Cursor ไปที่ Textbox1 เพื่อเตรียมพร้อมสำหรับการใส่ข้อมูล
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Update_Data() ' อัพเดตข้อมูล
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Update_Data() ' อัพเดตข้อมูล
    End Sub

    Sub Update_Data()
        If TextBox1.Text = "" Then
            ' ถ้าเกิดว่าไม่มีอะไรให้ทำการข้าม
        Else
            If ComboBox1.Text = "เมตร" Then
                X_Size_Cube = (TextBox1.Text)
            ElseIf ComboBox1.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox1.Text)
                X_Size_Cube = Input / 100
            ElseIf ComboBox1.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox1.Text)
                X_Size_Cube = Input * 1000
            ElseIf ComboBox1.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox1.Text)
                X_Size_Cube = Input / 1000
            Else

            End If
        End If

        If TextBox2.Text = "" Then
            ' ถ้าเกิดว่าไม่มีอะไรให้ทำการข้าม
        Else
            If ComboBox2.Text = "เมตร" Then
                Y_Size_Cube = (TextBox2.Text)
            ElseIf ComboBox2.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox2.Text)
                Y_Size_Cube = Input / 100
            ElseIf ComboBox2.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox2.Text)
                Y_Size_Cube = Input * 1000
            ElseIf ComboBox2.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox2.Text)
                Y_Size_Cube = Input / 1000
            Else

            End If
        End If
        If TextBox3.Text = "" Then
            ' ถ้าเกิดว่าไม่มีอะไรให้ทำการข้าม
        Else
            If ComboBox3.Text = "เมตร" Then
                Z_Size_Cube = (TextBox3.Text)
            ElseIf ComboBox3.Text = "เซนติเมตร" Then
                Dim Input As Double = (TextBox3.Text)
                Z_Size_Cube = Input / 100
            ElseIf ComboBox3.Text = "กิโลเมตร" Then
                Dim Input As Double = (TextBox3.Text)
                Z_Size_Cube = Input * 1000
            ElseIf ComboBox3.Text = "มิลลิเมตร" Then
                Dim Input As Double = (TextBox3.Text)
                Z_Size_Cube = Input / 1000
            End If
        End If

        If ComboBox4.Text = "คิว-ลูกบาศก์เมตร" Then
            Sumary_Raw_Output = ((X_Size_Cube * Y_Size_Cube) * Z_Size_Cube)
        ElseIf ComboBox4.Text = "ลูกบาศก์เซนติเมตร" Then
            Sumary_Raw_Output = (((X_Size_Cube * Y_Size_Cube) * Z_Size_Cube) * 1000000)
        ElseIf ComboBox4.Text = "ลูกบาศก์กิโลเมตร" Then
            Sumary_Raw_Output = (((X_Size_Cube * Y_Size_Cube) * Z_Size_Cube) / 1000000000)
        ElseIf ComboBox4.Text = "ลิตร" Then
            Sumary_Raw_Output = (((X_Size_Cube * Y_Size_Cube) * Z_Size_Cube) * 1000)
        Else
            ' ถ้าเกิดว่าไม่มีอะไรให้ทำการข้าม
        End If

        Label_Volume_Object.Text = Sumary_Raw_Output.ToString("0.000000")
        Cube.Volume_Cube = Sumary_Raw_Output
    End Sub

    ' ฟังก์ชั่นเมื่อกดปุ่ม Enter แล้วจะเลื่อนลงไปช่องใส่ข้อมูลอีกช่อง
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Select()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Select()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Save.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class