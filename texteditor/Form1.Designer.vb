﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        OpenFolderToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        listBoxFiles = New ListBox()
        txteditor = New TextBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 29)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenFolderToolStripMenuItem, SaveToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 25)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' OpenFolderToolStripMenuItem
        ' 
        OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        OpenFolderToolStripMenuItem.Size = New Size(180, 26)
        OpenFolderToolStripMenuItem.Text = "Open Folder"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(180, 26)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' listBoxFiles
        ' 
        listBoxFiles.Dock = DockStyle.Left
        listBoxFiles.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        listBoxFiles.FormattingEnabled = True
        listBoxFiles.ItemHeight = 20
        listBoxFiles.Location = New Point(0, 29)
        listBoxFiles.Name = "listBoxFiles"
        listBoxFiles.Size = New Size(200, 421)
        listBoxFiles.TabIndex = 1
        ' 
        ' txteditor
        ' 
        txteditor.Dock = DockStyle.Fill
        txteditor.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txteditor.Location = New Point(200, 29)
        txteditor.Multiline = True
        txteditor.Name = "txteditor"
        txteditor.ScrollBars = ScrollBars.Vertical
        txteditor.Size = New Size(600, 421)
        txteditor.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txteditor)
        Controls.Add(listBoxFiles)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "File Explorer Text Editor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents listBoxFiles As ListBox
    Friend WithEvents txteditor As TextBox
End Class
