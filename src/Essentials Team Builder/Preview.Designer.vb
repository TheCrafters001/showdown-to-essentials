﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preview
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
        RichTextBox1 = New RichTextBox()
        exit_btn = New Button()
        saveToTrainers_btn = New Button()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBox1.Location = New Point(12, 12)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(501, 471)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' exit_btn
        ' 
        exit_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        exit_btn.Location = New Point(438, 489)
        exit_btn.Name = "exit_btn"
        exit_btn.Size = New Size(75, 23)
        exit_btn.TabIndex = 1
        exit_btn.Text = "Exit"
        exit_btn.UseVisualStyleBackColor = True
        ' 
        ' saveToTrainers_btn
        ' 
        saveToTrainers_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        saveToTrainers_btn.Location = New Point(12, 489)
        saveToTrainers_btn.Name = "saveToTrainers_btn"
        saveToTrainers_btn.Size = New Size(420, 23)
        saveToTrainers_btn.TabIndex = 2
        saveToTrainers_btn.Text = "Save to trainers.txt"
        saveToTrainers_btn.UseVisualStyleBackColor = True
        ' 
        ' Preview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(525, 524)
        Controls.Add(saveToTrainers_btn)
        Controls.Add(exit_btn)
        Controls.Add(RichTextBox1)
        Name = "Preview"
        Text = "Preview"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents exit_btn As Button
    Friend WithEvents saveToTrainers_btn As Button
End Class