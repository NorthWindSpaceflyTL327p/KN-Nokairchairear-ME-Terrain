﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3D_Editor
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
        Me.GlControl1 = New OpenTK.GLControl()
        Me.SuspendLayout()
        '
        'GlControl1
        '
        Me.GlControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GlControl1.Location = New System.Drawing.Point(137, 183)
        Me.GlControl1.Name = "GlControl1"
        Me.GlControl1.Size = New System.Drawing.Size(675, 364)
        Me.GlControl1.TabIndex = 0
        Me.GlControl1.VSync = False
        '
        '_3D_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1407, 791)
        Me.Controls.Add(Me.GlControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_3D_Editor"
        Me.Text = "_3D_Editor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GlControl1 As OpenTK.GLControl
End Class
