<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Queue_Kernal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Queue_Kernal))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button_Save_To_File = New System.Windows.Forms.Button()
        Me.Icon_Picture = New System.Windows.Forms.PictureBox()
        Me.Button_Maximium = New System.Windows.Forms.Button()
        Me.Button_Another_Menu = New System.Windows.Forms.Button()
        Me.Button_Minimium = New System.Windows.Forms.Button()
        Me.Button_Normal = New System.Windows.Forms.Button()
        Me.Button_End = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView_Queue = New System.Windows.Forms.DataGridView()
        Me.Timer_Update = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_Add_Next_Day = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Panel_Handle_TSS = New System.Windows.Forms.Panel()
        Me.H_ScrollBar_Back = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.H_ScrollBar_Tab = New System.Windows.Forms.Panel()
        Me.V_ScrollBar_Back = New System.Windows.Forms.Panel()
        Me.V_ScrollBar_Tab = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.Icon_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Queue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel_Handle_TSS.SuspendLayout()
        Me.H_ScrollBar_Back.SuspendLayout()
        Me.V_ScrollBar_Back.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button_Save_To_File)
        Me.Panel3.Controls.Add(Me.Icon_Picture)
        Me.Panel3.Controls.Add(Me.Button_Maximium)
        Me.Panel3.Controls.Add(Me.Button_Another_Menu)
        Me.Panel3.Controls.Add(Me.Button_Minimium)
        Me.Panel3.Controls.Add(Me.Button_Normal)
        Me.Panel3.Controls.Add(Me.Button_End)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1355, 37)
        Me.Panel3.TabIndex = 4
        '
        'Button_Save_To_File
        '
        Me.Button_Save_To_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save_To_File.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Save_To_File.Location = New System.Drawing.Point(126, 3)
        Me.Button_Save_To_File.Name = "Button_Save_To_File"
        Me.Button_Save_To_File.Size = New System.Drawing.Size(82, 29)
        Me.Button_Save_To_File.TabIndex = 6
        Me.Button_Save_To_File.Text = "บันทึก"
        Me.Button_Save_To_File.UseVisualStyleBackColor = True
        Me.Button_Save_To_File.Visible = False
        '
        'Icon_Picture
        '
        Me.Icon_Picture.Dock = System.Windows.Forms.DockStyle.Left
        Me.Icon_Picture.Image = Global.KN___Nokairchairear_ME_Terrain.My.Resources.Resources.KN_ICO
        Me.Icon_Picture.Location = New System.Drawing.Point(0, 0)
        Me.Icon_Picture.Name = "Icon_Picture"
        Me.Icon_Picture.Size = New System.Drawing.Size(35, 35)
        Me.Icon_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Icon_Picture.TabIndex = 5
        Me.Icon_Picture.TabStop = False
        '
        'Button_Maximium
        '
        Me.Button_Maximium.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Maximium.BackgroundImage = Global.KN___Nokairchairear_ME_Terrain.My.Resources.Resources._2
        Me.Button_Maximium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Maximium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Maximium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Maximium.Location = New System.Drawing.Point(1283, 0)
        Me.Button_Maximium.Name = "Button_Maximium"
        Me.Button_Maximium.Size = New System.Drawing.Size(35, 35)
        Me.Button_Maximium.TabIndex = 2
        Me.Button_Maximium.UseVisualStyleBackColor = True
        Me.Button_Maximium.Visible = False
        '
        'Button_Another_Menu
        '
        Me.Button_Another_Menu.Enabled = False
        Me.Button_Another_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Another_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Another_Menu.Location = New System.Drawing.Point(38, 3)
        Me.Button_Another_Menu.Name = "Button_Another_Menu"
        Me.Button_Another_Menu.Size = New System.Drawing.Size(82, 29)
        Me.Button_Another_Menu.TabIndex = 4
        Me.Button_Another_Menu.Text = "เมนู"
        Me.Button_Another_Menu.UseVisualStyleBackColor = True
        '
        'Button_Minimium
        '
        Me.Button_Minimium.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Minimium.BackgroundImage = Global.KN___Nokairchairear_ME_Terrain.My.Resources.Resources._1
        Me.Button_Minimium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Minimium.Location = New System.Drawing.Point(1248, 0)
        Me.Button_Minimium.Name = "Button_Minimium"
        Me.Button_Minimium.Size = New System.Drawing.Size(35, 35)
        Me.Button_Minimium.TabIndex = 3
        Me.Button_Minimium.UseVisualStyleBackColor = True
        '
        'Button_Normal
        '
        Me.Button_Normal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Normal.BackgroundImage = Global.KN___Nokairchairear_ME_Terrain.My.Resources.Resources._3
        Me.Button_Normal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Normal.Location = New System.Drawing.Point(1283, 0)
        Me.Button_Normal.Name = "Button_Normal"
        Me.Button_Normal.Size = New System.Drawing.Size(35, 35)
        Me.Button_Normal.TabIndex = 1
        Me.Button_Normal.UseVisualStyleBackColor = True
        '
        'Button_End
        '
        Me.Button_End.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_End.BackgroundImage = Global.KN___Nokairchairear_ME_Terrain.My.Resources.Resources._4
        Me.Button_End.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_End.Location = New System.Drawing.Point(1318, 0)
        Me.Button_End.Name = "Button_End"
        Me.Button_End.Size = New System.Drawing.Size(35, 35)
        Me.Button_End.TabIndex = 0
        Me.Button_End.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.DataGridView_Queue)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 637)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1355, 157)
        Me.Panel1.TabIndex = 5
        '
        'DataGridView_Queue
        '
        Me.DataGridView_Queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Queue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Queue.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Queue.Name = "DataGridView_Queue"
        Me.DataGridView_Queue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Queue.Size = New System.Drawing.Size(1355, 157)
        Me.DataGridView_Queue.TabIndex = 0
        '
        'Timer_Update
        '
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.Button_Add_Next_Day)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button_Edit)
        Me.Panel2.Controls.Add(Me.Button_Delete)
        Me.Panel2.Controls.Add(Me.Button_Add)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 583)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1355, 54)
        Me.Panel2.TabIndex = 7
        '
        'Button_Add_Next_Day
        '
        Me.Button_Add_Next_Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Add_Next_Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Add_Next_Day.Location = New System.Drawing.Point(288, 9)
        Me.Button_Add_Next_Day.Name = "Button_Add_Next_Day"
        Me.Button_Add_Next_Day.Size = New System.Drawing.Size(126, 35)
        Me.Button_Add_Next_Day.TabIndex = 84
        Me.Button_Add_Next_Day.Text = "เพิ่มคิววันถัดไป"
        Me.Button_Add_Next_Day.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(120, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 35)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "วันถัดไป"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button4.Location = New System.Drawing.Point(13, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 35)
        Me.Button4.TabIndex = 82
        Me.Button4.Text = "วันที่แล้ว"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(1046, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 35)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "อิสระ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(939, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 35)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "ตามเส้นเวลา"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Edit.Location = New System.Drawing.Point(745, 9)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(109, 35)
        Me.Button_Edit.TabIndex = 79
        Me.Button_Edit.Text = "แก้ไขคิว"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Delete.Location = New System.Drawing.Point(630, 9)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(109, 35)
        Me.Button_Delete.TabIndex = 78
        Me.Button_Delete.Text = "ลบคิว"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Add.Location = New System.Drawing.Point(515, 9)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(109, 35)
        Me.Button_Add.TabIndex = 77
        Me.Button_Add.Text = "เพิ่มคิว"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Panel_Handle_TSS
        '
        Me.Panel_Handle_TSS.Controls.Add(Me.Label1)
        Me.Panel_Handle_TSS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Handle_TSS.Location = New System.Drawing.Point(0, 37)
        Me.Panel_Handle_TSS.Name = "Panel_Handle_TSS"
        Me.Panel_Handle_TSS.Size = New System.Drawing.Size(1319, 477)
        Me.Panel_Handle_TSS.TabIndex = 0
        '
        'H_ScrollBar_Back
        '
        Me.H_ScrollBar_Back.BackColor = System.Drawing.SystemColors.HotTrack
        Me.H_ScrollBar_Back.Controls.Add(Me.Panel4)
        Me.H_ScrollBar_Back.Controls.Add(Me.H_ScrollBar_Tab)
        Me.H_ScrollBar_Back.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.H_ScrollBar_Back.Location = New System.Drawing.Point(0, 514)
        Me.H_ScrollBar_Back.Name = "H_ScrollBar_Back"
        Me.H_ScrollBar_Back.Size = New System.Drawing.Size(1355, 69)
        Me.H_ScrollBar_Back.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(707, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 69)
        Me.Panel4.TabIndex = 1
        '
        'H_ScrollBar_Tab
        '
        Me.H_ScrollBar_Tab.BackColor = System.Drawing.SystemColors.Highlight
        Me.H_ScrollBar_Tab.Location = New System.Drawing.Point(460, 13)
        Me.H_ScrollBar_Tab.Name = "H_ScrollBar_Tab"
        Me.H_ScrollBar_Tab.Size = New System.Drawing.Size(187, 38)
        Me.H_ScrollBar_Tab.TabIndex = 0
        '
        'V_ScrollBar_Back
        '
        Me.V_ScrollBar_Back.BackColor = System.Drawing.SystemColors.HotTrack
        Me.V_ScrollBar_Back.Controls.Add(Me.V_ScrollBar_Tab)
        Me.V_ScrollBar_Back.Dock = System.Windows.Forms.DockStyle.Right
        Me.V_ScrollBar_Back.Location = New System.Drawing.Point(1319, 37)
        Me.V_ScrollBar_Back.Name = "V_ScrollBar_Back"
        Me.V_ScrollBar_Back.Size = New System.Drawing.Size(36, 477)
        Me.V_ScrollBar_Back.TabIndex = 9
        '
        'V_ScrollBar_Tab
        '
        Me.V_ScrollBar_Tab.BackColor = System.Drawing.SystemColors.Highlight
        Me.V_ScrollBar_Tab.Location = New System.Drawing.Point(3, 399)
        Me.V_ScrollBar_Tab.Name = "V_ScrollBar_Tab"
        Me.V_ScrollBar_Tab.Size = New System.Drawing.Size(24, 38)
        Me.V_ScrollBar_Tab.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Queue_Kernal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1355, 794)
        Me.Controls.Add(Me.Panel_Handle_TSS)
        Me.Controls.Add(Me.V_ScrollBar_Back)
        Me.Controls.Add(Me.H_ScrollBar_Back)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Queue_Kernal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.Icon_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView_Queue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel_Handle_TSS.ResumeLayout(False)
        Me.Panel_Handle_TSS.PerformLayout()
        Me.H_ScrollBar_Back.ResumeLayout(False)
        Me.V_ScrollBar_Back.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Icon_Picture As PictureBox
    Friend WithEvents Button_Another_Menu As Button
    Friend WithEvents Button_Minimium As Button
    Friend WithEvents Button_Maximium As Button
    Friend WithEvents Button_Normal As Button
    Friend WithEvents Button_End As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer_Update As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Board_Time As Panel
    Friend WithEvents Panel_Handle_TSS As Panel
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Add As Button
    Friend WithEvents DataGridView_Queue As DataGridView
    Friend WithEvents Button_Save_To_File As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents H_ScrollBar_Back As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents H_ScrollBar_Tab As Panel
    Friend WithEvents V_ScrollBar_Back As Panel
    Friend WithEvents V_ScrollBar_Tab As Panel
    Friend WithEvents Button_Add_Next_Day As Button
    Friend WithEvents Label1 As Label
End Class
