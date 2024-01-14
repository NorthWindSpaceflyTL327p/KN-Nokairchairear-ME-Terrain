' Save the file and open the file.
Imports System.IO
Imports System.Data.SqlClient

Public Class Queue_Kernal

    ' Data table.
    Public Shared Queue_Data_Table As New DataTable
    Public Shared Board_Time_Data_Table As New DataTable

    ' Function to move a form.
    Private Form_isDragging As Boolean = False
    Private Form_offset As Point

    ' Draw a timeline and time text.
    Dim Timeline As New Panel()
    Dim Timeline_TimeText As New Label()

    Dim Timeline_On_ScrollBar As New Panel()

    ' Label to show a time track on the board.
    Dim Time_Label As New Label()

    ' Set a Queue block hight.
    Dim Queue_Width As Integer = 60

    ' Set up Track Zoom Verticle. ^
    Dim Track_Zoom_Verticle As Double = 0

    ' Set up Track Zoom Horizontal. <>
    Dim Track_Zoom_Horizontal As Double = 0

    ' Set up a Maximum and Minimum of ScrollBar
    Dim Max_Horizontal_Scroll_Bar_Value As Integer
    Dim Min_Horizontal_Scroll_Bar_Value As Integer

    Dim Max_Verticle_Scroll_Bar_Value As Integer
    Dim Min_Verticle_Scroll_Bar_Value As Integer

    ' Set up Connection Data
    Public Shared connectionString As String

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Setup data for use. (Setup)
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Shared Sub Load_Connection_String()

        ' Load the connection string fromo file is save in this same path of program.

        Dim programPath As String = Application.ExecutablePath
        Dim File_Path_Server_Name As String = Path.Combine(programPath, "/MSSQL_HOST.ConnectionString") ' SQL Server name.
        Dim File_Path_Schemas_Name As String = Path.Combine(programPath, "/MSSQL_SCHE.ConnectionString") ' SQL Call database name.

        Try

            Dim Server_Name As String
            Dim Database_Name As String

            Server_Name = (File.ReadAllText(File_Path_Server_Name))
            Database_Name = (File.ReadAllText(File_Path_Schemas_Name))

            connectionString = "Data Source=" & Server_Name & ";Initial Catalog=" & Database_Name & ";Integrated Security=True;"

        Catch ex As Exception

            ' if error make a connection string to default
            connectionString = "Data Source=" & "Nokairchairear" & ";Initial Catalog=" & "IISC" & ";Integrated Security=True;"

        End Try

    End Sub

    Private Sub Queue_Kernal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load the setting and startup
        Load_Connection_String()
        Setup_Data_Table()
        Load_To_Data()

        ' Setup a windows form
        H_ScrollBar_Tab.Height = H_ScrollBar_Back.Height
        V_ScrollBar_Tab.Width = V_ScrollBar_Back.Width

    End Sub

    Sub Setup_Data_Table()

        'Setup a colum of build-in data table.

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Board_Time_Data_Table.Columns.Add("ID", GetType(Integer))
        Board_Time_Data_Table.Columns.Add("Name_System", GetType(String))
        Board_Time_Data_Table.Columns.Add("Date_Show", GetType(String))

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Queue_Data_Table.Columns.Add("ID", GetType(Integer))
        Queue_Data_Table.Columns.Add("Name", GetType(String))

        Queue_Data_Table.Columns.Add("Queue_Number", GetType(Integer))
        Queue_Data_Table.Columns.Add("Queue_Date", GetType(String))

        Queue_Data_Table.Columns.Add("Phone_In_Number", GetType(String))

        Queue_Data_Table.Columns.Add("Customer_Name", GetType(String))
        Queue_Data_Table.Columns.Add("Customer_Work_Location", GetType(String))
        Queue_Data_Table.Columns.Add("Customer_Phone_Number", GetType(String))

        Queue_Data_Table.Columns.Add("Concrete_Strange", GetType(String))
        Queue_Data_Table.Columns.Add("Concrete_Formula", GetType(String))
        Queue_Data_Table.Columns.Add("Concrete_Addition", GetType(String))
        Queue_Data_Table.Columns.Add("Concrete_Quantity", GetType(Double))

        Queue_Data_Table.Columns.Add("Load_Mixer_Time", GetType(String))
        Queue_Data_Table.Columns.Add("Start_Travel_Time", GetType(String))
        Queue_Data_Table.Columns.Add("Time_To_Work_Location", GetType(String))
        Queue_Data_Table.Columns.Add("Finished_Time", GetType(String))
        Queue_Data_Table.Columns.Add("Time_To_Plant", GetType(String))

        Queue_Data_Table.Columns.Add("Way_Quality", GetType(String))
        Queue_Data_Table.Columns.Add("Site_Work_Type", GetType(String))

        Queue_Data_Table.Columns.Add("Truck_Size", GetType(String))

        Queue_Data_Table.Columns.Add("Concrete_Pipe", GetType(String))
        Queue_Data_Table.Columns.Add("Keep_Concrete_Test_Cube", GetType(String))
        Queue_Data_Table.Columns.Add("Test_Slump", GetType(String))

        Queue_Data_Table.Columns.Add("More_Another", GetType(String))
        Queue_Data_Table.Columns.Add("Note_Importan", GetType(String))

        Queue_Data_Table.Columns.Add("Sequence_Track_Position", GetType(String))

        DataGridView_Queue.DataSource = Queue_Data_Table

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Action Processing for windows form
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub Button_End_Click(sender As Object, e As EventArgs) Handles Button_End.Click

        ' Exit this form
        Me.Close()

    End Sub

    Private Sub Button_Normal_Click(sender As Object, e As EventArgs) Handles Button_Normal.Click

        ' Button resize this form to Normal
        Me.WindowState = WindowState.Normal
        Button_Maximium.Visible = True
        Button_Normal.Visible = False

    End Sub

    Private Sub Button_Maximium_Click(sender As Object, e As EventArgs) Handles Button_Maximium.Click

        ' Button resize this form to Maximized or full screen.
        Me.WindowState = WindowState.Maximized
        Button_Maximium.Visible = False
        Button_Normal.Visible = True

    End Sub

    Private Sub Button_Minimium_Click(sender As Object, e As EventArgs) Handles Button_Minimium.Click

        ' Button hide this form to taskbar.
        Me.WindowState = WindowState.Minimized

    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown

        ' Panel3 top of the form to control the position form.
        If e.Button = MouseButtons.Left Then

            Form_isDragging = True
            Form_offset = e.Location

        End If

    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove

        ' Panel3 top of the form to control the position form.
        If Form_isDragging Then

            Dim newLocation As Point = Me.PointToScreen(New Point(e.X, e.Y))
            newLocation.Offset(-Form_offset.X, -Form_offset.Y)
            Me.Location = newLocation

        End If

    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp

        ' Panel3 top of the form to control the position form.
        If e.Button = MouseButtons.Left Then

            Form_isDragging = False

        End If

    End Sub

    Private Sub Button_Another_Menu_Click(sender As Object, e As EventArgs) Handles Button_Another_Menu.Click

        ' Call a Main Menu
        Start_Menu.Show()

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Action Processing for Data Table of Board Time
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Sub Add_Time_Table_Data(ID As Integer, Name_System As String, Date_Show As String)

        Dim New_Row As DataRow = Board_Time_Data_Table.NewRow()

        New_Row("ID") = ID
        New_Row("Name_System") = Name_System

        New_Row("Date_Show") = Date_Show

        Board_Time_Data_Table.Rows.Add(New_Row)

    End Sub

    Sub Delete_Time_Table_Data(Colum_Name As String, Row_Data As String)

        Board_Time_Data_Table.Rows(Row_Data)(Colum_Name).Remove()

    End Sub

    Sub Edit_Time_Table_Data(ID_Input As Integer, Edit_Name_System As Integer, Edit_Date_Show As Integer)

        Board_Time_Data_Table.Rows(ID_Input)("Name_System") = Edit_Name_System
        Board_Time_Data_Table.Rows(ID_Input)("Date_Show") = Edit_Date_Show

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '  Update the data from Data Table to Board Time 
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    'Bug Fix : Is not function to detect the what boardtime to add this data. 
    Sub Update_DataTable_To_Board_Time()

        Dim TimerowCount As Integer = Board_Time_Data_Table.Rows.Count

        For p As Integer = 0 To TimerowCount - 1

            Dim CtrlF_Board_Time As Control = Nothing

            For Each ctrl As Control In Panel_Handle_TSS.Controls

                Dim RowData As Object = Board_Time_Data_Table.Rows(p)("ID")
                Dim TST As String = RowData

                If ctrl.Name = TST Then

                    CtrlF_Board_Time = ctrl
                    Exit For

                End If

            Next ctrl

            If CtrlF_Board_Time IsNot Nothing Then

                Dim rowCount As Integer = Queue_Data_Table.Rows.Count

                For x As Integer = 0 To rowCount - 1

                    Try

                        Dim CtrlF_Delete As Control = Nothing

                        For Each ctrl As Control In Board_Time.Controls

                            Dim RowData As Object = Queue_Data_Table.Rows(x)("ID")
                            Dim TST As String = RowData

                            If ctrl.Name = TST Then

                                CtrlF_Delete = ctrl
                                Exit For

                            End If

                        Next ctrl

                        If CtrlF_Delete IsNot Nothing Then

                            'Delete 'CtrlF_Delete'

                        Else

                            ' Handle the case where CtrlF is Nothing (control not found) if needed

                        End If

                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                        Dim CtrlF As Control = Nothing

                        For Each ctrl As Control In Board_Time.Controls

                            Dim RowData As Object = DataGridView_Queue.Rows(x).Cells("ID").Value
                            Dim TST As String = RowData

                            If ctrl.Name = TST Then

                                CtrlF = ctrl
                                Exit For

                            End If

                        Next ctrl

                        If CtrlF IsNot Nothing Then

                            Dim Sequence_Time_Start As Object = DataGridView_Queue.Rows(x).Cells("Sequence_Time_Start").Value
                            Dim Sequence_Track_Position As Object = DataGridView_Queue.Rows(x).Cells("Sequence_Track_Position").Value
                            Dim Sequence_Time_Duration As Object = DataGridView_Queue.Rows(x).Cells("Sequence_Time_Duration").Value

                            CtrlF.Location = New Point((Board_Time.Width / 24) * Convert.ToInt32(Sequence_Time_Start), (26 + ((Queue_Width + 2) * Convert.ToInt32(Sequence_Track_Position))))
                            CtrlF.Size = New Size((Board_Time.Width / 24) * Convert.ToInt32(Sequence_Time_Duration), Queue_Width)

                        Else

                            ' Handle the case where CtrlF is Nothing (control not found) if needed

                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message)

                        If ex.Message.Contains("Conversion from type 'DBNull' to type 'String' is not valid.") Then

                            Exit For
                            ' User select a blank row and cannot convert DBNull to String.

                        ElseIf ex.Message.Contains("") Then

                        End If

                    End Try

                Next

            Else

                ' Handle the case where CtrlF is Nothing (control not found) if needed

            End If

        Next
    End Sub



    Sub Update_DataTable_To_Panel_Handle_TSS()

        Dim rowCount As Integer = Board_Time_Data_Table.Rows.Count

        For x As Integer = 0 To rowCount - 1

            Try

                Dim CtrlF_Delete As Control = Nothing

                For Each ctrl As Control In Panel_Handle_TSS.Controls

                    Dim RowData As Object = Board_Time_Data_Table.Rows(x)("ID")
                    Dim TST As String = RowData

                    If ctrl.Name = TST Then

                        CtrlF_Delete = ctrl
                        Exit For

                    End If

                Next ctrl

                If CtrlF_Delete IsNot Nothing Then

                    Delete_Time_Label(CtrlF_Delete)

                Else

                    ' Handle the case where CtrlF is Nothing (control not found) if needed

                End If

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Dim CtrlF As Control = Nothing

                For Each ctrl As Control In Board_Time.Controls

                    Dim RowData As Object = Board_Time_Data_Table.Rows(x)("ID")
                    Dim TST As String = RowData

                    If ctrl.Name = TST Then

                        CtrlF = ctrl
                        Exit For

                    End If

                Next ctrl

                If CtrlF IsNot Nothing Then

                    Add_Time_Label(CtrlF)

                Else

                    ' Handle the case where CtrlF is Nothing (control not found) if needed

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message)

                If ex.Message.Contains("Conversion from type 'DBNull' to type 'String' is not valid.") Then

                    Exit For
                    ' User select a blank row and cannot convert DBNull to String.

                ElseIf ex.Message.Contains("") Then

                End If

            End Try

        Next

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Sub Draw_Sequence(Name As String, Title As String, Time_Start As Double, Time_Duration As Double, Track_Position As Integer)

        Dim Sequence_Panel As New Panel()
        Dim Sequence_Title_label As New Label()

        Dim Sequence_Time_Start As Integer
        Dim Sequence_Time_Duration As Integer
        Dim Sequence_Track_Position As Integer

        Sequence_Time_Duration = Time_Duration
        Sequence_Time_Start = Time_Start

        Sequence_Track_Position = (26 + ((Queue_Width + 2) * Track_Position))
        Dim Time_Start_Position_X As Integer = (Board_Time.Width / 24) * Sequence_Time_Start
        Dim Time_End_Position_X As Integer = (Board_Time.Width / 24) * Sequence_Time_Duration

        Sequence_Panel.Name = Name
        Sequence_Panel.BackColor = Color.White
        Sequence_Panel.Size = New Size(Time_End_Position_X, Queue_Width)
        Sequence_Panel.Location = New Point(Time_Start_Position_X, (26 + ((Queue_Width + 2) * Track_Position)))

        Sequence_Title_label.Text = Title
        Sequence_Title_label.Location = New Point(5, 5)
        Sequence_Title_label.AutoSize = True

        Board_Time.Controls.Add(Sequence_Panel)
        Sequence_Panel.Controls.Add(Sequence_Title_label)

    End Sub

    Sub Create_Sequence()

    End Sub

    Sub Delete_Sequence(Name As String)

    End Sub

    Sub Edit_Sequence(Name As String)

    End Sub

    Public Shared Sub Create_Queue(
                                   Name As String,
                                   Title As String,
                                   Time_Start As Double,
                                   Time_Duration As Double,
                                   Track_Position As Integer,
                                   Queue_Number As Integer,
                                   Queue_Date As String,
                                   Phone_In_Number As String,
                                   Customer_Name As String,
                                   Customer_Work_Location As String,
                                   Customer_Phone_Number As String,
                                   Concrete_Strange As String,
                                   Concrete_Formula As String,
                                   Concrete_Addition As String,
                                   Concrete_Quantity As Double,
                                   Time_To_Work_Location As String,
                                   Way_Quality As String,
                                   Truck_Size As String,
                                   Concrete_Pipe As String,
                                   Keep_Concrete_Test_Cube As String,
                                   Test_Slump As String,
                                   Site_Work_Type As String,
                                   More_Another As String,
                                   Note_Importan As String
                                  )

        ' Create a Queue and Data Queue on the form.

        Dim NameID As Integer = Name

        Queue_Kernal.Draw_Sequence(Name, Title, Time_Start, Time_Duration, Track_Position)

        'AddNewRow(NameID, Title, Queue_Number, Queue_Date, Phone_In_Number, Customer_Name, Customer_Work_Location, Customer_Phone_Number, Concrete_Strange,
        'Concrete_Formula, Concrete_Addition, Concrete_Quantity, Time_To_Work_Location, Way_Quality, Truck_Size, Concrete_Pipe,
        'Keep_Concrete_Test_Cube, Test_Slump, Site_Work_Type, More_Another, Note_Importan, Time_Start, Track_Position, Time_Duration)

    End Sub

    Public Shared Sub Delete_Queue()

    End Sub

    Public Shared Sub Edit_Queue()

    End Sub

    Sub Setup_Timeline(CTRL As Control)

        CTRL.Controls.Add(Timeline)
        CTRL.Controls.Add(Timeline_TimeText)

    End Sub

    Sub Add_Time_Label(CTRL As Control)

        For x As Integer = 0 To 23

            For i As Integer = 0 To 59

                For p As Integer = 0 To 59

                    Time_Label.Name = (x.ToString("00")) & "-" & (i.ToString("00")) & "-" & (p.ToString("00"))
                    Time_Label.AutoSize = True
                    Time_Label.Location = New Point((CTRL.Width / 24) * 0, 0)
                    Time_Label.Text = "00:00:00"

                    CTRL.Controls.Add(Time_Label)

                Next

            Next

        Next

    End Sub

    Sub Update_Time_Label(CTRL_CV As Control)

        For x As Integer = 0 To 23

            If Track_Zoom_Horizontal > 30 Then

                For i As Integer = 0 To 59

                    If Track_Zoom_Horizontal > 30 Then

                        For p As Integer = 0 To 59

                            Dim Label_SH As Control

                            For Each ctrl As Control In CTRL_CV.Controls

                                If ctrl.Name = (x.ToString("00")) & "-" & (i.ToString("00")) & "-" & (p.ToString("00")) Then

                                    Label_SH = ctrl
                                    Exit For

                                End If

                            Next ctrl

                            If Not Label_SH Is Nothing Then

                                Label_SH.Location = New Point((CTRL_CV.Width / 24) * 0, 0)
                                Label_SH.Text = (p.ToString("00")) & "S"

                            Else

                            End If

                        Next

                    Else

                        Dim Label_SH As Control

                        For Each ctrl As Control In CTRL_CV.Controls

                            If ctrl.Name = (x.ToString("00")) & "-" & (i.ToString("00")) & "-" & "00" Then

                                Label_SH = ctrl
                                Exit For

                            End If

                        Next ctrl

                        If Not Label_SH Is Nothing Then

                            Label_SH.Location = New Point((CTRL_CV.Width / 24) * 0, 0)
                            Label_SH.Text = (i.ToString("00")) & "M"

                        Else

                        End If

                    End If

                Next

            Else

                Dim Label_SH As Control

                For Each ctrl As Control In CTRL_CV.Controls

                    If ctrl.Name = (x.ToString("00")) & "-" & "00" & "-" & "00" Then

                        Label_SH = ctrl
                        Exit For

                    End If

                Next ctrl

                If Not Label_SH Is Nothing Then

                    Label_SH.Location = New Point((CTRL_CV.Width / 24) * 0, 0)
                    Label_SH.Text = (x.ToString("00")) & "H"

                Else

                End If

            End If

        Next

    End Sub

    Sub Delete_Time_Label(CTRL_CV As Control)

        For x As Integer = 0 To 23

            For i As Integer = 0 To 59

                For p As Integer = 0 To 59

                    Time_Label.Name = (x.ToString("00")) & "-" & (i.ToString("00")) & "-" & (p.ToString("00"))
                    Time_Label.AutoSize = True
                    Time_Label.Location = New Point((CTRL_CV.Width / 24) * 0, 0)
                    Time_Label.Text = "00:00:00"

                    CTRL_CV.Controls.Remove(Time_Label)

                Next

            Next

        Next

    End Sub

    Private Sub Button_Add_Next_Day_Click(sender As Object, e As EventArgs) Handles Button_Add_Next_Day.Click

    End Sub

    Sub Draw_Timeline(CTRL As Control)

        Update_DataTable_To_Board_Time()

        Timeline.BackColor = Color.Red
        Timeline.Size = New Size(1, CTRL.Height)
        Timeline_TimeText.AutoSize = True

        Dim currentTime As DateTime = DateTime.Now

        Dim hours As Integer = currentTime.Hour
        Dim minutes As Integer = currentTime.Minute
        Dim seconds As Integer = currentTime.Second

        Dim Time_100Format As Double = hours + (((100 / 60) * minutes) / 100) + (((100 / 60) * seconds) / 10000)
        Dim Time_100Format_Position As Integer = (CTRL.Width / 24) * Time_100Format

        Timeline.Location = New Point(Time_100Format_Position, 0)

        Timeline_TimeText.Location = New Point(Time_100Format_Position, 13)
        Timeline_TimeText.Text = hours.ToString("00") & ":" & minutes.ToString("00") & ":" & seconds.ToString("00")

    End Sub

    Private Sub Timer_Update_Tick(sender As Object, e As EventArgs) Handles Timer_Update.Tick

        'Draw_Timeline()

    End Sub

    'Add , Delete , Edit the Queue.

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click

        Add_Queue.Show()

    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click

        Delete_Select_Queue()

    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click

        ' Edit the Queue.

        ' Show old data to input form
        ' Delete a colum and data in datagrindview
        ' if ok then create a new data

    End Sub

    Public Shared Sub Delete_Select_Queue()

        If Queue_Kernal.DataGridView_Queue.SelectedRows.Count > 0 Then

            Dim rowIndex As Integer = Queue_Kernal.DataGridView_Queue.SelectedRows(0).Index

            If rowIndex >= 0 AndAlso rowIndex <= Queue_Kernal.DataGridView_Queue.Rows.Count Then

                Dim RowData As Object = Queue_Kernal.DataGridView_Queue.Rows(rowIndex).Cells("ID").Value
                Dim TST As String = RowData
                Queue_Kernal.Delete_Sequence(TST)
                Delete_Row_of_Sequence_Index(rowIndex)

            Else

                MessageBox.Show("เลือกแถวผิดพลาด")

            End If

        Else

            MessageBox.Show("ไม่มีแถวที่เลือก")

        End If

    End Sub

    Sub Add_New_Boarder_Time_Row_Data(ID As Integer, Name_Sytem As String, Date_Show As String)

        Dim New_Row As DataRow = Board_Time_Data_Table.NewRow()

        New_Row("ID") = ID
        New_Row("Name_System") = Name_Sytem
        New_Row("Date_Show") = Date_Show

        Queue_Data_Table.Rows.Add(New_Row)

    End Sub

    Public Shared Sub Add_New_Row_of_Sequence(
                                              ID As Integer,
                                              Name As String,
                                              Queue_Number As Integer,
                                              Queue_Date As String,
                                              Phone_In_Number As String,
                                              Customer_Name As String,
                                              Customer_Work_Location As String,
                                              Customer_Phone_Number As String,
                                              Concrete_Strange As String,
                                              Concrete_Formula As String,
                                              Concrete_Addition As String,
                                              Concrete_Quantity As Double,
                                              Load_Mixer_Time As String,
                                              Start_Travel_Time As String,
                                              Time_To_Work_Location As String,
                                              Finished_Time As String,
                                              Time_To_Plant As String,
                                              Way_Quality As String,
                                              Truck_Size As String,
                                              Concrete_Pipe As String,
                                              Keep_Concrete_Test_Cube As String,
                                              Test_Slump As String,
                                              Site_Work_Type As String,
                                              More_Another As String,
                                              Note_Importan As String,
                                              Sequence_Time_Start As String,
                                              Sequence_Track_Position As String,
                                              Sequence_Time_Duration As String
                                             )

        Dim New_Row As DataRow = Queue_Data_Table.NewRow()

        New_Row("ID") = ID
        New_Row("Name") = Name

        New_Row("Queue_Number") = Queue_Number
        New_Row("Queue_Date") = Queue_Date

        New_Row("Phone_In_Number") = Phone_In_Number

        New_Row("Customer_Name") = Customer_Name
        New_Row("Customer_Work_Location") = Customer_Work_Location
        New_Row("Customer_Phone_Number") = Customer_Phone_Number

        New_Row("Concrete_Strange") = Concrete_Strange
        New_Row("Concrete_Formula") = Concrete_Formula
        New_Row("Concrete_Addition") = Concrete_Addition
        New_Row("Concrete_Quantity") = Concrete_Quantity

        New_Row("Load_Mixer_Time") = Load_Mixer_Time
        New_Row("Start_Travel_Time") = Start_Travel_Time
        New_Row("Time_To_Work_Location") = Time_To_Work_Location
        New_Row("Finished_Time") = Finished_Time
        New_Row("Time_To_Plant") = Time_To_Plant

        New_Row("Way_Quality") = Way_Quality
        New_Row("Truck_Size") = Truck_Size

        New_Row("Concrete_Pipe") = Concrete_Pipe
        New_Row("Keep_Concrete_Test_Cube") = Keep_Concrete_Test_Cube
        New_Row("Test_Slump") = Test_Slump

        New_Row("Site_Work_Type") = Site_Work_Type

        New_Row("More_Another") = More_Another
        New_Row("Note_Importan") = Note_Importan

        New_Row("Sequence_Track_Position") = Sequence_Track_Position

        Queue_Data_Table.Rows.Add(New_Row)
        Queue_Kernal.DataGridView_Queue.DataSource = Queue_Data_Table

    End Sub

    Public Shared Sub Delete_Row_of_Sequence_Select()

        If Queue_Kernal.DataGridView_Queue.SelectedRows.Count > 0 Then

            Dim rowIndex As Integer = Queue_Kernal.DataGridView_Queue.SelectedRows(0).Index

            If rowIndex >= 0 AndAlso rowIndex < Queue_Kernal.DataGridView_Queue.Rows.Count Then

                Delete_Row_of_Sequence_Index(rowIndex)

            Else

                MessageBox.Show("เลือกแถวผิดพลาด")

            End If

        Else

            MessageBox.Show("ไม่มีแถวที่เลือก")

        End If

    End Sub

    Public Shared Sub Delete_Row_of_Sequence_Index(index As String)

        Queue_Kernal.DataGridView_Queue.Rows.RemoveAt(index)

    End Sub

    Public Shared Sub Update_SizePos_Row_of_Sequence(
                                                     Queue_Number As Integer,
                                                     Queue_Date As String,
                                                     Phone_In_Number As String,
                                                     Customer_Name As String,
                                                     Customer_Work_Location As String,
                                                     Customer_Phone_Number As String,
                                                     Concrete_Strange As String,
                                                     Concrete_Formula As String,
                                                     Concrete_Addition As String,
                                                     Concrete_Quantity As Double,
                                                     Time_To_Work_Location As String,
                                                     Way_Quality As String,
                                                     Truck_Size As String,
                                                     Concrete_Pipe As String,
                                                     Keep_Concrete_Test_Cube As String,
                                                     Test_Slump As String,
                                                     Site_Work_Type As String,
                                                     More_Another As String,
                                                     Note_Importan As String
                                                    )

        If Queue_Kernal.DataGridView_Queue.SelectedRows.Count > 0 Then

            Dim rowIndex As Integer = Queue_Kernal.DataGridView_Queue.SelectedRows(0).Index

            If rowIndex >= 0 AndAlso rowIndex < Queue_Data_Table.Rows.Count Then

                Queue_Data_Table.Rows(rowIndex)("Queue_Number") = Queue_Number
                Queue_Data_Table.Rows(rowIndex)("Queue_Date") = Queue_Date
                Queue_Data_Table.Rows(rowIndex)("Phone_In_Number") = Phone_In_Number

                Queue_Data_Table.Rows(rowIndex)("Customer_Name") = Customer_Name
                Queue_Data_Table.Rows(rowIndex)("Customer_Work_Location") = Customer_Work_Location
                Queue_Data_Table.Rows(rowIndex)("Customer_Phone_Number") = Customer_Phone_Number

                Queue_Data_Table.Rows(rowIndex)("Concrete_Strange") = Concrete_Strange
                Queue_Data_Table.Rows(rowIndex)("Concrete_Formula") = Concrete_Formula
                Queue_Data_Table.Rows(rowIndex)("Concrete_Addition") = Concrete_Addition
                Queue_Data_Table.Rows(rowIndex)("Concrete_Quantity") = Concrete_Quantity

                Queue_Data_Table.Rows(rowIndex)("Time_To_Work_Location") = Time_To_Work_Location
                Queue_Data_Table.Rows(rowIndex)("Way_Quality") = Way_Quality
                Queue_Data_Table.Rows(rowIndex)("Truck_Size") = Truck_Size

                Queue_Data_Table.Rows(rowIndex)("Concrete_Pipe") = Concrete_Pipe
                Queue_Data_Table.Rows(rowIndex)("Keep_Concrete_Test_Cube") = Keep_Concrete_Test_Cube
                Queue_Data_Table.Rows(rowIndex)("Test_Slump") = Test_Slump

                Queue_Data_Table.Rows(rowIndex)("Site_Work_Type") = Site_Work_Type

                Queue_Data_Table.Rows(rowIndex)("More_Another") = More_Another
                Queue_Data_Table.Rows(rowIndex)("Note_Importan") = Note_Importan

            Else

                MessageBox.Show("เลือกแถวผิดพลาด")

            End If

        Else

            MessageBox.Show("ไม่มีแถวที่เลือก")

        End If

    End Sub

    Private Sub Button_Save_To_File_Click(sender As Object, e As EventArgs) Handles Button_Save_To_File.Click

    End Sub

    Sub Save_To_File()

        ' Specify the file path
        Dim filePath As String = "C:\Path\To\Your\File.txt"

        ' Data to be saved
        Dim dataToSave As String = "Hello, World!"

        ' Write the data to the file
        File.WriteAllText(filePath, dataToSave)

    End Sub

    Sub Load_To_Data()

        ' Specify the file path
        Dim filePath As String = "C:\Path\To\Your\File.txt"

        ' Read the data from the file
        'Dim data As String = File.ReadAllText(filePath)

        ' Use the 'data' as needed

    End Sub

    Dim H_ScrollBar_Tab_isDragging As Boolean
    Dim H_ScrollBar_Tab_offset As New Point

    Private Sub H_ScrollBar_Tab_MouseDown(sender As Object, e As MouseEventArgs) Handles H_ScrollBar_Tab.MouseDown

        ' Panel3 top of the form to control the position form.
        If e.Button = MouseButtons.Left Then

            H_ScrollBar_Tab_isDragging = True
            H_ScrollBar_Tab_offset = e.Location

        End If

    End Sub

    Private Sub H_ScrollBar_Tab_MouseMove(sender As Object, e As MouseEventArgs) Handles H_ScrollBar_Tab.MouseMove

        ' Panel3 top of the form to control the position form.
        If H_ScrollBar_Tab_isDragging Then

            Dim globalMousePos As Point = MousePosition

            H_ScrollBar_Tab.Location = New Point(globalMousePos.X - H_ScrollBar_Tab_offset.X, 0)

        End If

    End Sub

    Private Sub H_ScrollBar_Tab_MouseUp(sender As Object, e As MouseEventArgs) Handles H_ScrollBar_Tab.MouseUp

        ' Panel3 top of the form to control the position form.
        If e.Button = MouseButtons.Left Then

            H_ScrollBar_Tab_isDragging = False

        End If

    End Sub

    Sub Update_H_Scrollbar()

    End Sub

    Sub C_Test_DB_SQL_Server()
        Try

            Dim connection As New SqlConnection(Queue_Kernal.connectionString)
            connection.Open()
            'SQL_Connection_Failed_Try_Again.Label2.Text = "เชื่อมต่อสำเร็จ"
            connection.Close()

        Catch ex As Exception

            'SQL_Connection_Failed_Try_Again.Label2.Text = "ไม่พบเซิฟเวอร์หรือฐานข้อมูล"
            'SQL_Connection_Failed_Try_Again.Show()

        End Try
    End Sub

    Dim V_ScrollBar_Tab_isDragging As Boolean
    Dim V_ScrollBar_Tab_offset As New Point

    Private Sub V_ScrollBar_Tab_MouseDown(sender As Object, e As MouseEventArgs) Handles V_ScrollBar_Tab.MouseDown

        ' Panel3 top of the form to control the position form.
        If e.Button = MouseButtons.Left Then

            V_ScrollBar_Tab_isDragging = True
            V_ScrollBar_Tab_offset = e.Location

        End If

    End Sub

    Private Sub V_ScrollBar_Tab_MouseMove(sender As Object, e As MouseEventArgs) Handles V_ScrollBar_Tab.MouseMove

        ' Panel3 top of the form to control the position form.
        If V_ScrollBar_Tab_isDragging Then

            'Dim globalMousePos As Point = Me.PointToScreen(e.Location)
            Dim globalMousePos As Point = MousePosition

            Dim XCSS As Integer = V_ScrollBar_Back.Location.Y

            V_ScrollBar_Tab.Location = New Point(0, (globalMousePos.Y - V_ScrollBar_Tab_offset.Y) - XCSS)
            Label1.Text = $"Global X: {globalMousePos.X}, Global Y: {globalMousePos.Y}"

        End If

    End Sub

    Private Sub V_ScrollBar_Tab_MouseUp(sender As Object, e As MouseEventArgs) Handles V_ScrollBar_Tab.MouseUp

        ' Panel3 top of the form to control the position form.
        If e.Button = MouseButtons.Left Then

            V_ScrollBar_Tab_isDragging = False

        End If

    End Sub

    Sub Update_V_Scrollbar()

    End Sub

End Class