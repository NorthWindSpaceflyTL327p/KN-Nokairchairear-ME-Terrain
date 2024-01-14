<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sumary_Board
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sumary_Board))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button_CLose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(57, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "สรุป"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(263, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(504, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รวม : 00000.00000 ลูกบาศก์เมตร"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"คิว-ลูกบาศก์เมตร", "ลูกบาศก์เซนติเมตร", "ลูกบาศก์กิโลเมตร", "ลิตร"})
        Me.ComboBox1.Location = New System.Drawing.Point(36, 232)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 27)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "คิว-ลูกบาศก์เมตร"
        '
        'Button_CLose
        '
        Me.Button_CLose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_CLose.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_CLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_CLose.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Button_CLose.Location = New System.Drawing.Point(869, 220)
        Me.Button_CLose.Name = "Button_CLose"
        Me.Button_CLose.Size = New System.Drawing.Size(137, 46)
        Me.Button_CLose.TabIndex = 3
        Me.Button_CLose.Text = "ปิด"
        Me.Button_CLose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(629, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "นำเข้าไปยังระบบจัดคิว"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Button2.Location = New System.Drawing.Point(389, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 46)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "พิมพ์หรือบันทึก"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Sumary_Board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1034, 289)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_CLose)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sumary_Board"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sumary_Board"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button_CLose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
