<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGetFiles = New System.Windows.Forms.Button()
        Me.tbUrl = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnExtension = New System.Windows.Forms.RadioButton()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.tbRename = New System.Windows.Forms.TextBox()
        Me.rbtnEnd = New System.Windows.Forms.RadioButton()
        Me.rbtnBeginning = New System.Windows.Forms.RadioButton()
        Me.rbtnRemoveWord = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvFilenames = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGetFiles)
        Me.GroupBox1.Controls.Add(Me.tbUrl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "URL"
        '
        'btnGetFiles
        '
        Me.btnGetFiles.Location = New System.Drawing.Point(553, 17)
        Me.btnGetFiles.Name = "btnGetFiles"
        Me.btnGetFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnGetFiles.TabIndex = 1
        Me.btnGetFiles.Text = "Get Files"
        Me.btnGetFiles.UseVisualStyleBackColor = True
        '
        'tbUrl
        '
        Me.tbUrl.Location = New System.Drawing.Point(6, 19)
        Me.tbUrl.Name = "tbUrl"
        Me.tbUrl.Size = New System.Drawing.Size(541, 20)
        Me.tbUrl.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnExtension)
        Me.GroupBox2.Controls.Add(Me.btnRename)
        Me.GroupBox2.Controls.Add(Me.tbRename)
        Me.GroupBox2.Controls.Add(Me.rbtnEnd)
        Me.GroupBox2.Controls.Add(Me.rbtnBeginning)
        Me.GroupBox2.Controls.Add(Me.rbtnRemoveWord)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(643, 84)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rename"
        '
        'rbtnExtension
        '
        Me.rbtnExtension.AutoSize = True
        Me.rbtnExtension.Location = New System.Drawing.Point(234, 19)
        Me.rbtnExtension.Name = "rbtnExtension"
        Me.rbtnExtension.Size = New System.Drawing.Size(71, 17)
        Me.rbtnExtension.TabIndex = 4
        Me.rbtnExtension.TabStop = True
        Me.rbtnExtension.Text = "Extension"
        Me.rbtnExtension.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(553, 40)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(75, 23)
        Me.btnRename.TabIndex = 2
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'tbRename
        '
        Me.tbRename.Location = New System.Drawing.Point(7, 43)
        Me.tbRename.Name = "tbRename"
        Me.tbRename.Size = New System.Drawing.Size(540, 20)
        Me.tbRename.TabIndex = 3
        '
        'rbtnEnd
        '
        Me.rbtnEnd.AutoSize = True
        Me.rbtnEnd.Location = New System.Drawing.Point(184, 19)
        Me.rbtnEnd.Name = "rbtnEnd"
        Me.rbtnEnd.Size = New System.Drawing.Size(44, 17)
        Me.rbtnEnd.TabIndex = 2
        Me.rbtnEnd.TabStop = True
        Me.rbtnEnd.Text = "End"
        Me.rbtnEnd.UseVisualStyleBackColor = True
        '
        'rbtnBeginning
        '
        Me.rbtnBeginning.AutoSize = True
        Me.rbtnBeginning.Location = New System.Drawing.Point(106, 19)
        Me.rbtnBeginning.Name = "rbtnBeginning"
        Me.rbtnBeginning.Size = New System.Drawing.Size(72, 17)
        Me.rbtnBeginning.TabIndex = 1
        Me.rbtnBeginning.TabStop = True
        Me.rbtnBeginning.Text = "Beginning"
        Me.rbtnBeginning.UseVisualStyleBackColor = True
        '
        'rbtnRemoveWord
        '
        Me.rbtnRemoveWord.AutoSize = True
        Me.rbtnRemoveWord.Location = New System.Drawing.Point(6, 19)
        Me.rbtnRemoveWord.Name = "rbtnRemoveWord"
        Me.rbtnRemoveWord.Size = New System.Drawing.Size(94, 17)
        Me.rbtnRemoveWord.TabIndex = 0
        Me.rbtnRemoveWord.TabStop = True
        Me.rbtnRemoveWord.Text = "Remove Word"
        Me.rbtnRemoveWord.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(565, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lvFilenames)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(643, 223)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Files"
        '
        'lvFilenames
        '
        Me.lvFilenames.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvFilenames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvFilenames.Location = New System.Drawing.Point(3, 16)
        Me.lvFilenames.Name = "lvFilenames"
        Me.lvFilenames.Size = New System.Drawing.Size(637, 204)
        Me.lvFilenames.TabIndex = 0
        Me.lvFilenames.UseCompatibleStateImageBehavior = False
        Me.lvFilenames.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Filenames"
        Me.ColumnHeader1.Width = 633
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "File Renamer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetFiles As System.Windows.Forms.Button
    Friend WithEvents tbUrl As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnExtension As System.Windows.Forms.RadioButton
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents tbRename As System.Windows.Forms.TextBox
    Friend WithEvents rbtnEnd As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBeginning As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnRemoveWord As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lvFilenames As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader

End Class
