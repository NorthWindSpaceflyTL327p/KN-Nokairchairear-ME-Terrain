Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Public Class Kernal

    Private GlControl1_isDragging As Boolean = False
    Private GlControl1_startPoint As Point

    Private GlControl1_isDragging_MoveCamera As Boolean = False
    Private GlControl1_isShift_MoveCamera As Boolean = False
    Private GlControl1_startPoint_MoveCamera As Point

    Public Shared Object_Data_Table As New DataTable

    Public Shared DataTable_Max_ID_Valve As Integer

    Dim GlControl1_MouseWheel_Delta As Integer = 10

    Private Sub Kernal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Setup_Data_Table()

        Rotate_X_Pos = 45
        Rotate_Y_Pos = 30


    End Sub

    Private Sub Button_Normal_Click(sender As Object, e As EventArgs) Handles Button_Normal.Click

        Me.WindowState = WindowState.Normal
        Button_Maximium.Visible = True
        Button_Normal.Visible = False

    End Sub

    Private Sub Button_Maximium_Click(sender As Object, e As EventArgs) Handles Button_Maximium.Click

        Me.WindowState = WindowState.Maximized
        Button_Maximium.Visible = False
        Button_Normal.Visible = True

    End Sub

    Private Sub Button_Minimium_Click(sender As Object, e As EventArgs) Handles Button_Minimium.Click

        Me.WindowState = WindowState.Minimized

    End Sub

    Private Sub Button_End_Click(sender As Object, e As EventArgs) Handles Button_End.Click

        Me.Close()

    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click

        AddNewObject.Show()
        Me.Enabled = False
        GlControl1.Invalidate()

    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click

        Delete_Row_Select()
        GlControl1.Invalidate()

    End Sub

    Private Sub Button_Sum_Click(sender As Object, e As EventArgs) Handles Button_Sum.Click

        Sumary_Board.Show()

    End Sub

    Private Sub Button_Editor_Click(sender As Object, e As EventArgs) Handles Button_Editor.Click

        If DataGridView_Object.SelectedRows.Count > 0 Then

            Dim rowIndex As Integer = DataGridView_Object.SelectedRows(0).Index

            If rowIndex >= 0 AndAlso rowIndex < Object_Data_Table.Rows.Count Then

                Dim Obj_Type As Object = DataGridView_Object.Rows(rowIndex).Cells("Type").Value

                If Obj_Type = "Cube" Then
                    Dim Cube_X_Size As Object = DataGridView_Object.Rows(rowIndex).Cells("X_Size").Value
                    Dim Cube_Y_Size As Object = DataGridView_Object.Rows(rowIndex).Cells("Y_Size").Value
                    Dim Cube_Z_Size As Object = DataGridView_Object.Rows(rowIndex).Cells("Z_Size").Value

                    Dim Cube_X_Pos As Object = DataGridView_Object.Rows(rowIndex).Cells("X_Pos").Value
                    Dim Cube_Y_Pos As Object = DataGridView_Object.Rows(rowIndex).Cells("Y_Pos").Value
                    Dim Cube_Z_Pos As Object = DataGridView_Object.Rows(rowIndex).Cells("Z_Pos").Value

                    Cube_Editor.TextBox1.Text = Cube_X_Size
                    Cube_Editor.TextBox2.Text = Cube_Y_Size
                    Cube_Editor.TextBox3.Text = Cube_Z_Size * 100

                    Cube_Editor.TextBox4.Text = Cube_X_Pos
                    Cube_Editor.TextBox5.Text = Cube_Y_Pos
                    Cube_Editor.TextBox6.Text = Cube_Z_Pos

                    Cube_Editor.Show()

                ElseIf Obj_Type = "Cylinder" Then



                    Cylinder_Editor.Show()

                ElseIf Obj_Type = "Prism" Then



                    Prism_Editor.Show()

                ElseIf Obj_Type = "Ball" Then



                    Ball_Editor.Show()

                End If

            Else

                MessageBox.Show("เลือกแถวผิดพลาด")

            End If

        Else

            MessageBox.Show("ไม่มีแถวที่เลือก")

        End If

    End Sub

    Private Sub Button_Another_Menu_Click(sender As Object, e As EventArgs) Handles Button_Another_Menu.Click

        Start_Menu.Show()

    End Sub

    Private Sub GlControl1_Load(sender As Object, e As EventArgs) Handles GlControl1.Load

        GL.ClearColor(Color.Black)

    End Sub

    Private Sub GlControl1_MouseWheel(sender As Object, e As MouseEventArgs) Handles GlControl1.MouseWheel

        GlControl1_MouseWheel_Delta += (e.Delta / 100)

        If GlControl1_MouseWheel_Delta < 0 Then

        Else

            GlControl1.Invalidate()

        End If

    End Sub

    Private Sub GlControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles GlControl1.MouseDown

        If e.Button = MouseButtons.Left Then

            GlControl1_isDragging = True
            GlControl1_startPoint = e.Location
            Me.Cursor = Cursors.Hand

        ElseIf e.Button = MouseButtons.Right Then

            GlControl1_isDragging_MoveCamera = True
            GlControl1_startPoint_MoveCamera = e.Location

        End If

    End Sub

    Dim Rotate_X_Pos, Rotate_Y_Pos As Integer
    Dim Camera_Move_X_Pos, Camera_Move_Y_Pos As Double

    Private Sub GlControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles GlControl1.MouseMove
        If GlControl1_isDragging Then

            Dim deltaX As Integer = e.X - GlControl1_startPoint.X
            Dim deltaY As Integer = e.Y - GlControl1_startPoint.Y

            Rotate_X_Pos += deltaX
            Rotate_Y_Pos += deltaY

            GlControl1_startPoint = e.Location

        ElseIf GlControl1_isDragging_MoveCamera Then

            Dim deltaX As Integer = e.X - GlControl1_startPoint.X
            Dim deltaY As Integer = e.Y - GlControl1_startPoint.Y

            Camera_Move_X_Pos += deltaX / 100
            Camera_Move_Y_Pos += deltaY / 100

            'GlControl1_startPoint_MoveCamera = e.Location

        End If
        GlControl1.Invalidate()
    End Sub

    Private Sub GlControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles GlControl1.MouseUp

        Me.Cursor = Cursors.Default
        GlControl1_isDragging = False
        GlControl1_isDragging_MoveCamera = False

    End Sub

    Public Shared Object_Volume As Double

    Private Sub GlControl1_Paint(sender As Object, e As PaintEventArgs) Handles GlControl1.Paint
        Try
            Dim All_Object_Volume As Double = 0

            GL.Clear(ClearBufferMask.ColorBufferBit)
            GL.Clear(ClearBufferMask.DepthBufferBit)

            Dim perspective As Matrix4 = Matrix4.CreatePerspectiveFieldOfView(0.54, 2, 1, 10000)
            Dim lookat As Matrix4 = Matrix4.LookAt(GlControl1_MouseWheel_Delta, 0, 0, 0, 0, 0, 0, 1, 0)

            GL.MatrixMode(MatrixMode.Projection)
            GL.LoadIdentity()
            GL.LoadMatrix(perspective)
            GL.MatrixMode(MatrixMode.Modelview)
            GL.LoadIdentity()
            GL.LoadMatrix(lookat)
            GL.Viewport(0, 0, GlControl1.Width, GlControl1.Height)
            GL.Enable(EnableCap.DepthTest)
            GL.DepthFunc(DepthFunction.Less)

            GL.Rotate(Rotate_Y_Pos, 0, 0, 1)
            GL.Rotate(Rotate_X_Pos, 0, 1, 0)
            GL.Scale(1, 1, 1)

            Draw_Grid(0, 0, 0)
            'Draw_Grid(1, 1, 1)

            Try
                Dim Total_Row As Integer = (Object_Data_Table.Rows.Count)
                For i As Integer = 0 To Total_Row
                    Dim Obj_Type As Object = DataGridView_Object.Rows(i).Cells("Type").Value
                    If Obj_Type = "Cube" Then
                        Dim Cube_X_Size As Object = DataGridView_Object.Rows(i).Cells("X_Size").Value
                        Dim Cube_Y_Size As Object = DataGridView_Object.Rows(i).Cells("Y_Size").Value
                        Dim Cube_Z_Size As Object = DataGridView_Object.Rows(i).Cells("Z_Size").Value

                        Dim Cube_X_Pos As Object = DataGridView_Object.Rows(i).Cells("X_Pos").Value
                        Dim Cube_Y_Pos As Object = DataGridView_Object.Rows(i).Cells("Y_Pos").Value
                        Dim Cube_Z_Pos As Object = DataGridView_Object.Rows(i).Cells("Z_Pos").Value

                        Draw_Cube(Cube_X_Size, Cube_Y_Size, Cube_Z_Size, Cube_X_Pos, Cube_Y_Pos, Cube_Z_Pos)
                        All_Object_Volume += ((Cube_X_Size * Cube_Y_Size) * Cube_Z_Size)
                    ElseIf Obj_Type = "Cylinder" Then
                        Dim Cube_X_Size As Object = DataGridView_Object.Rows(i).Cells("X_Size").Value
                        Dim Cube_Y_Size As Object = DataGridView_Object.Rows(i).Cells("Y_Size").Value
                        Dim Cube_Z_Size As Object = DataGridView_Object.Rows(i).Cells("Z_Size").Value

                        Dim Cube_X_Pos As Object = DataGridView_Object.Rows(i).Cells("X_Pos").Value
                        Dim Cube_Y_Pos As Object = DataGridView_Object.Rows(i).Cells("Y_Pos").Value
                        Dim Cube_Z_Pos As Object = DataGridView_Object.Rows(i).Cells("Z_Pos").Value

                        'Draw_Cube(Cube_X_Size, Cube_Y_Size, Cube_Z_Size, Cube_X_Pos, Cube_Y_Pos, Cube_Z_Pos)
                        'All_Object_Volume += ((Cube_X_Size * Cube_Y_Size) * Cube_Z_Size)
                    ElseIf Obj_Type = "Prism" Then

                    End If


                Next

                Label_Sumary.Text = "ปริมาตรทั้งหมด : " & All_Object_Volume & " ลูกบาศเมตร"
                Kernal.Object_Volume = All_Object_Volume

                DataTable_Max_ID_Valve = Kernal.Object_Data_Table.AsEnumerable().Max(Function(row) Convert.ToInt32(row("Value")))
                Draw_Cylinder(1, 1, 1, 0, 0, 0)
            Catch ex As Exception

            End Try
            GlControl1.SwapBuffers()
        Catch ex As Exception

        End Try
    End Sub

    Sub Draw_Grid(Start_Point_X As Integer, Start_Point_Y As Integer, Srtart_Point_Z As Integer)
        Dim F1 As Integer = 255
        Dim F2 As Integer = 140
        GL.Begin(BeginMode.Lines)
        GL.Color3(Color.FromArgb(0, 0, F1))
        GL.Vertex3(Start_Point_X, Srtart_Point_Z, Start_Point_Y)
        GL.Vertex3(Start_Point_X, Srtart_Point_Z + 1000, Start_Point_Y)
        GL.End()

        For i As Integer = 1 To 1000 Step 1
            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(0, 0, F2))
            GL.Vertex3(Start_Point_X, Srtart_Point_Z + (0 - (i + 0)), Start_Point_Y)
            GL.Vertex3(Start_Point_X, Srtart_Point_Z + (0 - (i + 0.5)), Start_Point_Y)
            GL.End()

            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(0, 0, 0))
            GL.Vertex3(Start_Point_X, Srtart_Point_Z + (0 - (i + 0.5)), Start_Point_Y)
            GL.Vertex3(Start_Point_X, Srtart_Point_Z + (0 - (i + 1)), Start_Point_Y)
            GL.End()
        Next

        GL.Begin(BeginMode.Lines)
        GL.Color3(Color.FromArgb(F1, 0, 0))
        GL.Vertex3(Start_Point_X, Srtart_Point_Z, Start_Point_Y)
        GL.Vertex3(Start_Point_X + 1000, Srtart_Point_Z, Start_Point_Y)
        GL.End()

        For i As Integer = 1 To 1000 Step 1
            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(F2, 0, 0))
            GL.Vertex3(Start_Point_X + (0 - (i + 0)), Srtart_Point_Z, Start_Point_Y)
            GL.Vertex3(Start_Point_X + (0 - (i + 0.5)), Srtart_Point_Z, Start_Point_Y)
            GL.End()

            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(0, 0, 0))
            GL.Vertex3(Start_Point_X + (0 - (i + 0.5)), Srtart_Point_Z, Start_Point_Y)
            GL.Vertex3(Start_Point_X + (0 - (i + 1)), Srtart_Point_Z, Start_Point_Y)
            GL.End()
        Next

        GL.Begin(BeginMode.Lines)
        GL.Color3(Color.FromArgb(0, F1, 0))
        GL.Vertex3(Start_Point_X, Srtart_Point_Z, Start_Point_Y)
        GL.Vertex3(Start_Point_X, Srtart_Point_Z, Start_Point_Y + 1000)
        GL.End()

        For i As Integer = 1 To 1000 Step 1
            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(0, F2, 0))
            GL.Vertex3(Start_Point_X, Srtart_Point_Z, Start_Point_Y + (0 - (i + 0)))
            GL.Vertex3(Start_Point_X, Srtart_Point_Z, Start_Point_Y + (0 - (i + 0.5)))
            GL.End()

            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(0, 0, 0))
            GL.Vertex3(Start_Point_X, Srtart_Point_Z, Start_Point_Y + (0 - (i + 0.5)))
            GL.Vertex3(Start_Point_X, Srtart_Point_Z, Start_Point_Y + (0 - (i + 1)))
            GL.End()
        Next

        For i As Integer = -100 To 100 Step 1
            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(F2, F2, F2))
            GL.Vertex3(Start_Point_X + i, Srtart_Point_Z, Start_Point_Y + (-100))
            GL.Vertex3(Start_Point_X + i, Srtart_Point_Z, Start_Point_Y + 100)
            GL.End()
        Next

        For i As Integer = -100 To 100 Step 1
            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(F2, F2, F2))
            GL.Vertex3(Start_Point_X + (-100), Srtart_Point_Z, Start_Point_Y + i)
            GL.Vertex3(Start_Point_X + 100, Srtart_Point_Z, Start_Point_Y + i)
            GL.End()
        Next
    End Sub

    Sub Draw_Cube(X_Size As Double, Y_Size As Double, Z_Size As Double, X_Pos As Double, Y_Pos As Double, Z_Pos As Double)

        GL.Begin(BeginMode.QuadStrip)
        GL.Color3(Color.Gray)
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (0 - (Z_Size / 2)), X_Pos + ((X_Size / 2)))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + ((Z_Size / 2)), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + ((Z_Size / 2)), X_Pos + ((X_Size / 2)))
        GL.End()

        GL.Begin(BeginMode.QuadStrip)
        GL.Color3(Color.Gray)
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (X_Size / 2))
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (Z_Size / 2), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (Z_Size / 2), X_Pos + (X_Size / 2))
        GL.End()

        GL.Begin(BeginMode.QuadStrip)
        GL.Color3(Color.Gray)
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (X_Size / 2))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (X_Size / 2))
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (Z_Size / 2), X_Pos + (X_Size / 2))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (Z_Size / 2), X_Pos + (X_Size / 2))
        GL.End()

        GL.Begin(BeginMode.QuadStrip)
        GL.Color3(Color.Gray)
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (Z_Size / 2), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (Z_Size / 2), X_Pos + (0 - (X_Size / 2)))
        GL.End()

        GL.Begin(BeginMode.QuadStrip)
        GL.Color3(Color.DarkGray)
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (Z_Size / 2), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (Z_Size / 2), X_Pos + (X_Size / 2))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (Z_Size / 2), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (Z_Size / 2), X_Pos + (X_Size / 2))
        GL.End()

        GL.Begin(BeginMode.QuadStrip)
        GL.Color3(Color.DarkGray)
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (0 - (Y_Size / 2)), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (X_Size / 2))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (0 - (X_Size / 2)))
        GL.Vertex3(Y_Pos + (Y_Size / 2), Z_Pos + (0 - (Z_Size / 2)), X_Pos + (X_Size / 2))
        GL.End()

    End Sub

    Sub Draw_Cylinder(X_Size As Double, Y_Size As Double, Z_Size As Double, X_Pos As Double, Y_Pos As Double, Z_Pos As Double)

        Dim segments As Integer = 64
        Dim Radius_X As Double = X_Size / 2
        Dim Radius_Y As Double = Y_Size / 2
        Dim Center_Point_X, Center_Point_Y, Center_Point_Z As Double
        Center_Point_X = X_Pos / 2
        Center_Point_Y = Y_Pos / 2
        Center_Point_Z = Z_Pos / 2

        For i As Integer = 0 To segments - 1
            Dim Sata1 As Double = (360 / segments) * i
            Dim Sata1InRadians As Double = Sata1 * Math.PI / 180.0
            Dim Cy_Point_X As Double = (Math.Sin(Sata1InRadians)) * Radius_X
            Dim Cy_Point_Y As Double = (Math.Cos(Sata1InRadians)) * Radius_Y

            GL.Begin(BeginMode.Lines)
            GL.Color3(Color.FromArgb(0, 0, 255))
            GL.Vertex3(Y_Pos, Z_Pos, X_Pos)
            GL.Vertex3(Y_Pos + Cy_Point_Y, Z_Pos, X_Pos + Cy_Point_X)
            GL.End()
        Next

    End Sub

    Sub Draw_Prism()

    End Sub

    Sub Draw_Ball()

    End Sub

    Sub Setup_Data_Table()

        Kernal.Object_Data_Table.Columns.Add("ID", GetType(Integer))
        Kernal.Object_Data_Table.Columns.Add("Name", GetType(String))
        Kernal.Object_Data_Table.Columns.Add("Type", GetType(String))
        Kernal.Object_Data_Table.Columns.Add("X_Size", GetType(Double))
        Kernal.Object_Data_Table.Columns.Add("Y_Size", GetType(Double))
        Kernal.Object_Data_Table.Columns.Add("Z_Size", GetType(Double))
        Kernal.Object_Data_Table.Columns.Add("X_Pos", GetType(Double))
        Kernal.Object_Data_Table.Columns.Add("Y_Pos", GetType(Double))
        Kernal.Object_Data_Table.Columns.Add("Z_Pos", GetType(Double))

        DataGridView_Object.DataSource = Kernal.Object_Data_Table
    End Sub

    Public Shared Sub AddNewRow(id As String, name As String, Type As String, X_Size As Double, Y_Size As Double, Z_Size As Double, X_Pos As Double, Y_Pos As Double, Z_Pos As Double)
        Dim newRow As DataRow = Kernal.Object_Data_Table.NewRow()

        newRow("ID") = id
        newRow("Name") = name
        newRow("Type") = Type
        newRow("X_Size") = X_Size
        newRow("Y_Size") = Y_Size
        newRow("Z_Size") = Z_Size
        newRow("X_Pos") = X_Pos
        newRow("Y_Pos") = Y_Pos
        newRow("Z_Pos") = Z_Pos

        Kernal.Object_Data_Table.Rows.Add(newRow)
        Kernal.DataGridView_Object.DataSource = Kernal.Object_Data_Table
    End Sub

    Public Shared Sub Delete_Row_Select()
        If Kernal.DataGridView_Object.SelectedRows.Count > 0 Then

            Dim rowIndex As Integer = Kernal.DataGridView_Object.SelectedRows(0).Index

            If rowIndex >= 0 AndAlso rowIndex < Object_Data_Table.Rows.Count Then
                Delete_Row_Index(rowIndex)
            Else
                MessageBox.Show("เลือกแถวผิดพลาด")
            End If
        Else
            MessageBox.Show("ไม่มีแถวที่เลือก")
        End If
    End Sub

    Public Shared Sub Delete_Row_Index(index As String)
        Object_Data_Table.Rows.RemoveAt(index)
    End Sub

    Public Shared Sub Update_SizePos_Row(X_Size As Double, Y_Size As Double, Z_Size As Double, X_Pos As Double, Y_Pos As Double, Z_Pos As Double)
        If Kernal.DataGridView_Object.SelectedRows.Count > 0 Then

            Dim rowIndex As Integer = Kernal.DataGridView_Object.SelectedRows(0).Index

            If rowIndex >= 0 AndAlso rowIndex < Kernal.Object_Data_Table.Rows.Count Then
                Kernal.Object_Data_Table.Rows(rowIndex)("X_Size") = X_Size
                Kernal.Object_Data_Table.Rows(rowIndex)("Y_Size") = Y_Size
                Kernal.Object_Data_Table.Rows(rowIndex)("Z_Size") = Z_Size

                Kernal.Object_Data_Table.Rows(rowIndex)("X_Pos") = X_Pos
                Kernal.Object_Data_Table.Rows(rowIndex)("Y_Pos") = Y_Pos
                Kernal.Object_Data_Table.Rows(rowIndex)("Z_Pos") = Z_Pos
            Else
                MessageBox.Show("เลือกแถวผิดพลาด")
            End If
        Else
            MessageBox.Show("ไม่มีแถวที่เลือก")
        End If
    End Sub

    Private Sub DataGridView_Object_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Object.CellContentClick
        GlControl1.Invalidate()
    End Sub

    Private Form_isDragging As Boolean = False
    Private Form_offset As Point

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        If e.Button = MouseButtons.Left Then
            Form_isDragging = True
            Form_offset = e.Location
        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If Form_isDragging Then
            Dim newLocation As Point = Me.PointToScreen(New Point(e.X, e.Y))
            newLocation.Offset(-Form_offset.X, -Form_offset.Y)
            Me.Location = newLocation
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        If e.Button = MouseButtons.Left Then
            Form_isDragging = False
        End If
    End Sub

    Private Sub DataGridView_Object_MouseMove(sender As Object, e As MouseEventArgs) Handles DataGridView_Object.MouseMove
        GlControl1.Invalidate()
    End Sub

    Private Sub DataGridView_Object_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView_Object.KeyDown
        GlControl1.Invalidate()
        If e.KeyCode = Keys.Q Then
            Button_Add.PerformClick()
        ElseIf e.KeyCode = Keys.E Then
            Button_Editor.PerformClick()
        ElseIf e.KeyCode = Keys.S Then
            Button_Sum.PerformClick()
        ElseIf e.KeyCode = Keys.Delete Then
            Button_Delete.PerformClick()
        End If
    End Sub

    Private Sub GlControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GlControl1.KeyDown
        GlControl1.Invalidate()
        If e.KeyCode = Keys.Q Then
            Button_Add.PerformClick()
        ElseIf e.KeyCode = Keys.E Then
            Button_Editor.PerformClick()
        ElseIf e.KeyCode = Keys.S Then
            Button_Sum.PerformClick()
        ElseIf e.KeyCode = Keys.Delete Then
            Button_Delete.PerformClick()
        End If
    End Sub
End Class