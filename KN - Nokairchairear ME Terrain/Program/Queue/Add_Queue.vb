Public Class Add_Queue
    Public Shared Queue_Number As Integer
    Public Shared Queue_Date As String
    Public Shared PhoneIn_Number As String

    Public Shared Customer_Name As String
    Public Shared Work_Location As String
    Public Shared Customer_Phone_Number As String

    Public Shared Concrete_Strange As String
    Public Shared Concrete_Formula As String
    Public Shared Concrete_Addition As String
    Public Shared Concrete_Quantity As Double

    Public Shared Time_To_Work_Location As String

    Public Shared Way_Quality As String
    Public Shared Truck_Size As String

    Public Shared Concrete_Pipe As String
    Public Shared Keep_Concrete_Test_Cube As String
    Public Shared Test_Slump As String

    Public Shared Site_Work_Type As String

    Public Shared More_Another As String
    Public Shared Note_Importan As String

    Dim hours As Integer
    Dim minutes As Integer
    Dim seconds As Integer

    Private Sub Add_Queue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MaxID As Integer
        Try
            MaxID = If(Queue_Kernal.Queue_Data_Table.Rows.Count > 0, Queue_Kernal.Queue_Data_Table.AsEnumerable().Max(Function(row) Convert.ToInt32(row("ID"))), 0)
        Catch ex As Exception
            MaxID = 0
        End Try
        Dim CurrentDateTime As DateTime = DateTime.Now
        Dim Time_Format As String = CurrentDateTime.Hour & ":" & CurrentDateTime.Minute & ":" & CurrentDateTime.Second & "-" & CurrentDateTime.Day & "/" & CurrentDateTime.Month & "/" & CurrentDateTime.Year

        hours = CurrentDateTime.Hour
        minutes = CurrentDateTime.Minute
        seconds = CurrentDateTime.Second

        TextBox4.Text = MaxID + 1
        TextBox5.Text = Time_Format
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Queue_Number = TextBox4.Text
        Queue_Kernal.Create_Queue(Queue_Number, "Queue : " & Queue_Number, 17, 1, 1, 1, "", "", "", "", "", "", "", "", 2, "", "", "", "", "", "", "", "", "")
        Me.Close()
    End Sub

    Sub Save_Data()
        Do While True
            Try

                Dim Time_100Format As Double = hours + (((100 / 60) * minutes) / 100) + (((100 / 60) * seconds) / 10000)
                Queue_Number = TextBox4.Text
                Queue_Date = TextBox5.Text
                PhoneIn_Number = TextBox6.Text

                Customer_Name = TextBox1.Text
                Work_Location = TextBox9.Text
                Customer_Phone_Number = TextBox3.Text

                Concrete_Strange = TextBox7.Text
                Concrete_Formula = TextBox8.Text
                If CheckBox12.CheckState = False And CheckBox13.CheckState = True Then
                    Concrete_Addition = "น้ำยาเร่ง"
                ElseIf CheckBox12.CheckState = True And CheckBox13.CheckState = False Then
                    Concrete_Addition = "น้ำยาหน่วง"
                End If
                Concrete_Quantity = TextBox2.Text

                Time_To_Work_Location = TextBox10.Text

                'Queue_Data_Table.Columns.Add("Load_Mixer_Time", GetType(String))
                'Queue_Data_Table.Columns.Add("Start_Travel_Time", GetType(String))
                'Queue_Data_Table.Columns.Add("Time_To_Work_Location", GetType(String))
                'Queue_Data_Table.Columns.Add("Finished_Time", GetType(String))
                'Queue_Data_Table.Columns.Add("Time_To_Plant", GetType(String))

                Way_Quality = TextBox15.Text
                Truck_Size = TextBox11.Text

                Concrete_Pipe = TextBox12.Text
                Keep_Concrete_Test_Cube = TextBox13.Text
                Test_Slump = TextBox14.Text

                Site_Work_Type = TextBox16.Text

                Queue_Kernal.Create_Queue(Queue_Number, "Queue : " & Queue_Number, 17, 1, 1, 1, Queue_Date, "", "", "", "", "", "", "", 2, "", "", "", "", "", "", "", "", "")
                Me.Close()
            Catch ex As Exception

                If ex.Message.Contains("Conversion from") Then
                    MessageBox.Show("ช่องใส่ข้อมูลว่างเปล่าหรือผิดชนิดตัวแปร", "ไม่สามารถดำเนินการต่อได้เนื่องจากมีบางอย่างผิดพลาด")
                End If
                Exit Do
            End Try
        Loop
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Kernal.Show()
    End Sub

    Function ReadSubstringBetween(inputString As String, startString As String, endString As String) As String
        Dim startIndex As Integer = inputString.IndexOf(startString)
        Dim endIndex As Integer = inputString.IndexOf(endString, startIndex + startString.Length)

        If startIndex <> -1 AndAlso endIndex <> -1 Then
            Dim substring As String = inputString.Substring(startIndex + startString.Length, endIndex - (startIndex + startString.Length))
            Return substring
        Else
            Return "Start or end string not found in the input."
        End If
    End Function
End Class