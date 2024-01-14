<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kernal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kernal))
        Me.Button_Editor = New System.Windows.Forms.Button()
        Me.Button_Sum = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Icon_Picture = New System.Windows.Forms.PictureBox()
        Me.Button_Another_Menu = New System.Windows.Forms.Button()
        Me.Button_Minimium = New System.Windows.Forms.Button()
        Me.Button_Maximium = New System.Windows.Forms.Button()
        Me.Button_Normal = New System.Windows.Forms.Button()
        Me.Button_End = New System.Windows.Forms.Button()
        Me.DataGridView_Object = New System.Windows.Forms.DataGridView()
        Me.Label_Sumary = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GlControl1 = New OpenTK.GLControl()
        Me.Panel3.SuspendLayout()
        CType(Me.Icon_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Object, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Editor
        '
        Me.Button_Editor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Editor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Editor.ForeColor = System.Drawing.Color.White
        Me.Button_Editor.Location = New System.Drawing.Point(3, 79)
        Me.Button_Editor.Name = "Button_Editor"
        Me.Button_Editor.Size = New System.Drawing.Size(141, 32)
        Me.Button_Editor.TabIndex = 3
        Me.Button_Editor.Text = "แก้ไขวัตถุ"
        Me.Button_Editor.UseVisualStyleBackColor = True
        '
        'Button_Sum
        '
        Me.Button_Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Sum.ForeColor = System.Drawing.Color.White
        Me.Button_Sum.Location = New System.Drawing.Point(3, 117)
        Me.Button_Sum.Name = "Button_Sum"
        Me.Button_Sum.Size = New System.Drawing.Size(141, 32)
        Me.Button_Sum.TabIndex = 2
        Me.Button_Sum.Text = "สรุปผล"
        Me.Button_Sum.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Delete.ForeColor = System.Drawing.Color.White
        Me.Button_Delete.Location = New System.Drawing.Point(3, 41)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(141, 32)
        Me.Button_Delete.TabIndex = 1
        Me.Button_Delete.Text = "ลบวัตถุ"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Add.ForeColor = System.Drawing.Color.White
        Me.Button_Add.Location = New System.Drawing.Point(3, 3)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(141, 32)
        Me.Button_Add.TabIndex = 0
        Me.Button_Add.Text = "เพิ่มวัตถุ"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Icon_Picture)
        Me.Panel3.Controls.Add(Me.Button_Another_Menu)
        Me.Panel3.Controls.Add(Me.Button_Minimium)
        Me.Panel3.Controls.Add(Me.Button_Maximium)
        Me.Panel3.Controls.Add(Me.Button_Normal)
        Me.Panel3.Controls.Add(Me.Button_End)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1349, 37)
        Me.Panel3.TabIndex = 3
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
        'Button_Another_Menu
        '
        Me.Button_Another_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Another_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Another_Menu.Location = New System.Drawing.Point(38, 3)
        Me.Button_Another_Menu.Name = "Button_Another_Menu"
        Me.Button_Another_Menu.Size = New System.Drawing.Size(82, 29)
        Me.Button_Another_Menu.TabIndex = 4
        Me.Button_Another_Menu.Text = "เมนู"
        Me.Button_Another_Menu.UseVisualStyleBackColor = True
        Me.Button_Another_Menu.Visible = False
        '
        'Button_Minimium
        '
        Me.Button_Minimium.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Minimium.BackgroundImage = Global.KN___Nokairchairear_ME_Terrain.My.Resources.Resources._1
        Me.Button_Minimium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Minimium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Minimium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Minimium.Location = New System.Drawing.Point(1245, 3)
        Me.Button_Minimium.Name = "Button_Minimium"
        Me.Button_Minimium.Size = New System.Drawing.Size(29, 29)
        Me.Button_Minimium.TabIndex = 3
        Me.Button_Minimium.UseVisualStyleBackColor = True
        '
        'Button_Maximium
        '
        Me.Button_Maximium.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Maximium.BackgroundImage = Global.KN___Nokairchairear_ME_Terrain.My.Resources.Resources._2
        Me.Button_Maximium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Maximium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Maximium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Maximium.Location = New System.Drawing.Point(1280, 3)
        Me.Button_Maximium.Name = "Button_Maximium"
        Me.Button_Maximium.Size = New System.Drawing.Size(29, 29)
        Me.Button_Maximium.TabIndex = 2
        Me.Button_Maximium.UseVisualStyleBackColor = True
        Me.Button_Maximium.Visible = False
        '
        'Button_Normal
        '
        Me.Button_Normal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Normal.BackgroundImage = Global.KN___Nokairchairear_ME_Terrain.My.Resources.Resources._3
        Me.Button_Normal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Normal.Location = New System.Drawing.Point(1280, 3)
        Me.Button_Normal.Name = "Button_Normal"
        Me.Button_Normal.Size = New System.Drawing.Size(29, 29)
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
        Me.Button_End.Location = New System.Drawing.Point(1315, 3)
        Me.Button_End.Name = "Button_End"
        Me.Button_End.Size = New System.Drawing.Size(29, 29)
        Me.Button_End.TabIndex = 0
        Me.Button_End.UseVisualStyleBackColor = True
        '
        'DataGridView_Object
        '
        Me.DataGridView_Object.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Object.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView_Object.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_Object.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Object.Location = New System.Drawing.Point(164, 0)
        Me.DataGridView_Object.Name = "DataGridView_Object"
        Me.DataGridView_Object.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Object.Size = New System.Drawing.Size(1185, 152)
        Me.DataGridView_Object.TabIndex = 0
        '
        'Label_Sumary
        '
        Me.Label_Sumary.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_Sumary.AutoSize = True
        Me.Label_Sumary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label_Sumary.Location = New System.Drawing.Point(3, 5)
        Me.Label_Sumary.Name = "Label_Sumary"
        Me.Label_Sumary.Size = New System.Drawing.Size(12, 18)
        Me.Label_Sumary.TabIndex = 4
        Me.Label_Sumary.Text = "."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.DataGridView_Object)
        Me.Panel1.Controls.Add(Me.Button_Editor)
        Me.Panel1.Controls.Add(Me.Button_Sum)
        Me.Panel1.Controls.Add(Me.Button_Add)
        Me.Panel1.Controls.Add(Me.Button_Delete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 677)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 152)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label_Sumary)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 651)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1349, 26)
        Me.Panel2.TabIndex = 6
        '
        'GlControl1
        '
        Me.GlControl1.BackColor = System.Drawing.Color.Black
        Me.GlControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GlControl1.Location = New System.Drawing.Point(0, 37)
        Me.GlControl1.Name = "GlControl1"
        Me.GlControl1.Size = New System.Drawing.Size(1349, 614)
        Me.GlControl1.TabIndex = 7
        Me.GlControl1.VSync = False
        '
        'Kernal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1349, 829)
        Me.Controls.Add(Me.GlControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kernal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kernal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.Icon_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Object, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_End As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Add As Button
    Friend WithEvents DataGridView_Object As DataGridView
    Friend WithEvents Button_Minimium As Button
    Friend WithEvents Button_Maximium As Button
    Friend WithEvents Button_Normal As Button
    Friend WithEvents Label_Sumary As Label
    Friend WithEvents Button_Editor As Button
    Friend WithEvents Button_Sum As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GlControl1 As OpenTK.GLControl
    Friend WithEvents Button_Another_Menu As Button
    Friend WithEvents Icon_Picture As PictureBox
End Class
