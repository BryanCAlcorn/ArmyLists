<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.HQPoints = New System.Windows.Forms.Label
        Me.TroopsPoints = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ElitesPoints = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.FAPoints = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.HSPoints = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TotalLabel = New System.Windows.Forms.Label
        Me.RemoveHQ = New System.Windows.Forms.Button
        Me.RemoveTroops = New System.Windows.Forms.Button
        Me.RemoveElites = New System.Windows.Forms.Button
        Me.RemoveFA = New System.Windows.Forms.Button
        Me.RemoveHS = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ArmySize = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TroopsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ElitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FastAttackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HeavySupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadTool = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyHS = New System.Windows.Forms.Button
        Me.CopyFA = New System.Windows.Forms.Button
        Me.CopyElite = New System.Windows.Forms.Button
        Me.CopyTroops = New System.Windows.Forms.Button
        Me.CopyHQ = New System.Windows.Forms.Button
        Me.HQTextBox = New System.Windows.Forms.ListBox
        Me.TroopsTextBox = New System.Windows.Forms.ListBox
        Me.ElitesTextBox = New System.Windows.Forms.ListBox
        Me.FATextBox = New System.Windows.Forms.ListBox
        Me.HSTextBox = New System.Windows.Forms.ListBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmySize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HQ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Points:"
        '
        'HQPoints
        '
        Me.HQPoints.AutoSize = True
        Me.HQPoints.Location = New System.Drawing.Point(46, 115)
        Me.HQPoints.Name = "HQPoints"
        Me.HQPoints.Size = New System.Drawing.Size(13, 13)
        Me.HQPoints.TabIndex = 2
        Me.HQPoints.Text = "0"
        '
        'TroopsPoints
        '
        Me.TroopsPoints.AutoSize = True
        Me.TroopsPoints.Location = New System.Drawing.Point(46, 242)
        Me.TroopsPoints.Name = "TroopsPoints"
        Me.TroopsPoints.Size = New System.Drawing.Size(13, 13)
        Me.TroopsPoints.TabIndex = 6
        Me.TroopsPoints.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Points:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Troops:"
        '
        'ElitesPoints
        '
        Me.ElitesPoints.AutoSize = True
        Me.ElitesPoints.Location = New System.Drawing.Point(45, 372)
        Me.ElitesPoints.Name = "ElitesPoints"
        Me.ElitesPoints.Size = New System.Drawing.Size(13, 13)
        Me.ElitesPoints.TabIndex = 10
        Me.ElitesPoints.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Points:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Elites:"
        '
        'FAPoints
        '
        Me.FAPoints.AutoSize = True
        Me.FAPoints.Location = New System.Drawing.Point(46, 494)
        Me.FAPoints.Name = "FAPoints"
        Me.FAPoints.Size = New System.Drawing.Size(13, 13)
        Me.FAPoints.TabIndex = 14
        Me.FAPoints.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 494)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Points:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 480)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Fast Attack:"
        '
        'HSPoints
        '
        Me.HSPoints.AutoSize = True
        Me.HSPoints.Location = New System.Drawing.Point(42, 621)
        Me.HSPoints.Name = "HSPoints"
        Me.HSPoints.Size = New System.Drawing.Size(13, 13)
        Me.HSPoints.TabIndex = 18
        Me.HSPoints.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(-3, 621)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Points:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(-3, 607)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Heavy Support:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Total:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(59, 61)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(20, 24)
        Me.TotalLabel.TabIndex = 26
        Me.TotalLabel.Text = "0"
        '
        'RemoveHQ
        '
        Me.RemoveHQ.Location = New System.Drawing.Point(4, 131)
        Me.RemoveHQ.Name = "RemoveHQ"
        Me.RemoveHQ.Size = New System.Drawing.Size(75, 23)
        Me.RemoveHQ.TabIndex = 27
        Me.RemoveHQ.Text = "Remove"
        Me.RemoveHQ.UseVisualStyleBackColor = True
        '
        'RemoveTroops
        '
        Me.RemoveTroops.Location = New System.Drawing.Point(4, 258)
        Me.RemoveTroops.Name = "RemoveTroops"
        Me.RemoveTroops.Size = New System.Drawing.Size(75, 23)
        Me.RemoveTroops.TabIndex = 28
        Me.RemoveTroops.Text = "Remove"
        Me.RemoveTroops.UseVisualStyleBackColor = True
        '
        'RemoveElites
        '
        Me.RemoveElites.Location = New System.Drawing.Point(4, 388)
        Me.RemoveElites.Name = "RemoveElites"
        Me.RemoveElites.Size = New System.Drawing.Size(75, 23)
        Me.RemoveElites.TabIndex = 29
        Me.RemoveElites.Text = "Remove"
        Me.RemoveElites.UseVisualStyleBackColor = True
        '
        'RemoveFA
        '
        Me.RemoveFA.Location = New System.Drawing.Point(4, 510)
        Me.RemoveFA.Name = "RemoveFA"
        Me.RemoveFA.Size = New System.Drawing.Size(75, 23)
        Me.RemoveFA.TabIndex = 30
        Me.RemoveFA.Text = "Remove"
        Me.RemoveFA.UseVisualStyleBackColor = True
        '
        'RemoveHS
        '
        Me.RemoveHS.Location = New System.Drawing.Point(4, 637)
        Me.RemoveHS.Name = "RemoveHS"
        Me.RemoveHS.Size = New System.Drawing.Size(75, 23)
        Me.RemoveHS.TabIndex = 31
        Me.RemoveHS.Text = "Remove"
        Me.RemoveHS.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(163, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(369, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-3, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 24)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Army Size:"
        '
        'ArmySize
        '
        Me.ArmySize.Location = New System.Drawing.Point(100, 40)
        Me.ArmySize.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.ArmySize.Name = "ArmySize"
        Me.ArmySize.Size = New System.Drawing.Size(57, 20)
        Me.ArmySize.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 734)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(410, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "All Pictures and Logos used in this Program are Copyrighted by Games Workshop Ltd" & _
            "."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(625, 24)
        Me.MenuStrip1.TabIndex = 49
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem, Me.LoadTool})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HQToolStripMenuItem, Me.TroopsToolStripMenuItem, Me.ElitesToolStripMenuItem, Me.FastAttackToolStripMenuItem, Me.HeavySupportToolStripMenuItem})
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveToolStripMenuItem.Text = "Add"
        '
        'HQToolStripMenuItem
        '
        Me.HQToolStripMenuItem.Name = "HQToolStripMenuItem"
        Me.HQToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HQToolStripMenuItem.Text = "HQ"
        '
        'TroopsToolStripMenuItem
        '
        Me.TroopsToolStripMenuItem.Name = "TroopsToolStripMenuItem"
        Me.TroopsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TroopsToolStripMenuItem.Text = "Troops"
        '
        'ElitesToolStripMenuItem
        '
        Me.ElitesToolStripMenuItem.Name = "ElitesToolStripMenuItem"
        Me.ElitesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ElitesToolStripMenuItem.Text = "Elites"
        '
        'FastAttackToolStripMenuItem
        '
        Me.FastAttackToolStripMenuItem.Name = "FastAttackToolStripMenuItem"
        Me.FastAttackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FastAttackToolStripMenuItem.Text = "Fast Attack"
        '
        'HeavySupportToolStripMenuItem
        '
        Me.HeavySupportToolStripMenuItem.Name = "HeavySupportToolStripMenuItem"
        Me.HeavySupportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HeavySupportToolStripMenuItem.Text = "Heavy Support"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Save"
        '
        'LoadTool
        '
        Me.LoadTool.Name = "LoadTool"
        Me.LoadTool.Size = New System.Drawing.Size(100, 22)
        Me.LoadTool.Text = "Load"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'CopyHS
        '
        Me.CopyHS.Location = New System.Drawing.Point(4, 666)
        Me.CopyHS.Name = "CopyHS"
        Me.CopyHS.Size = New System.Drawing.Size(75, 23)
        Me.CopyHS.TabIndex = 50
        Me.CopyHS.Text = "Copy"
        Me.CopyHS.UseVisualStyleBackColor = True
        '
        'CopyFA
        '
        Me.CopyFA.Location = New System.Drawing.Point(4, 539)
        Me.CopyFA.Name = "CopyFA"
        Me.CopyFA.Size = New System.Drawing.Size(75, 23)
        Me.CopyFA.TabIndex = 51
        Me.CopyFA.Text = "Copy"
        Me.CopyFA.UseVisualStyleBackColor = True
        '
        'CopyElite
        '
        Me.CopyElite.Location = New System.Drawing.Point(4, 417)
        Me.CopyElite.Name = "CopyElite"
        Me.CopyElite.Size = New System.Drawing.Size(75, 23)
        Me.CopyElite.TabIndex = 52
        Me.CopyElite.Text = "Copy"
        Me.CopyElite.UseVisualStyleBackColor = True
        '
        'CopyTroops
        '
        Me.CopyTroops.Location = New System.Drawing.Point(4, 287)
        Me.CopyTroops.Name = "CopyTroops"
        Me.CopyTroops.Size = New System.Drawing.Size(75, 23)
        Me.CopyTroops.TabIndex = 53
        Me.CopyTroops.Text = "Copy"
        Me.CopyTroops.UseVisualStyleBackColor = True
        '
        'CopyHQ
        '
        Me.CopyHQ.Location = New System.Drawing.Point(4, 160)
        Me.CopyHQ.Name = "CopyHQ"
        Me.CopyHQ.Size = New System.Drawing.Size(75, 23)
        Me.CopyHQ.TabIndex = 54
        Me.CopyHQ.Text = "Copy"
        Me.CopyHQ.UseVisualStyleBackColor = True
        '
        'HQTextBox
        '
        Me.HQTextBox.FormattingEnabled = True
        Me.HQTextBox.Location = New System.Drawing.Point(100, 100)
        Me.HQTextBox.Name = "HQTextBox"
        Me.HQTextBox.Size = New System.Drawing.Size(513, 108)
        Me.HQTextBox.TabIndex = 55
        '
        'TroopsTextBox
        '
        Me.TroopsTextBox.FormattingEnabled = True
        Me.TroopsTextBox.Location = New System.Drawing.Point(100, 228)
        Me.TroopsTextBox.Name = "TroopsTextBox"
        Me.TroopsTextBox.Size = New System.Drawing.Size(513, 108)
        Me.TroopsTextBox.TabIndex = 56
        '
        'ElitesTextBox
        '
        Me.ElitesTextBox.FormattingEnabled = True
        Me.ElitesTextBox.Location = New System.Drawing.Point(100, 358)
        Me.ElitesTextBox.Name = "ElitesTextBox"
        Me.ElitesTextBox.Size = New System.Drawing.Size(513, 108)
        Me.ElitesTextBox.TabIndex = 57
        '
        'FATextBox
        '
        Me.FATextBox.FormattingEnabled = True
        Me.FATextBox.Location = New System.Drawing.Point(100, 480)
        Me.FATextBox.Name = "FATextBox"
        Me.FATextBox.Size = New System.Drawing.Size(513, 108)
        Me.FATextBox.TabIndex = 58
        '
        'HSTextBox
        '
        Me.HSTextBox.FormattingEnabled = True
        Me.HSTextBox.Location = New System.Drawing.Point(98, 607)
        Me.HSTextBox.Name = "HSTextBox"
        Me.HSTextBox.Size = New System.Drawing.Size(513, 108)
        Me.HSTextBox.TabIndex = 59
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 735)
        Me.Controls.Add(Me.HSTextBox)
        Me.Controls.Add(Me.FATextBox)
        Me.Controls.Add(Me.ElitesTextBox)
        Me.Controls.Add(Me.TroopsTextBox)
        Me.Controls.Add(Me.HQTextBox)
        Me.Controls.Add(Me.CopyHQ)
        Me.Controls.Add(Me.CopyTroops)
        Me.Controls.Add(Me.CopyElite)
        Me.Controls.Add(Me.CopyFA)
        Me.Controls.Add(Me.CopyHS)
        Me.Controls.Add(Me.ArmySize)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RemoveHS)
        Me.Controls.Add(Me.RemoveFA)
        Me.Controls.Add(Me.RemoveElites)
        Me.Controls.Add(Me.RemoveTroops)
        Me.Controls.Add(Me.RemoveHQ)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HSPoints)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.FAPoints)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ElitesPoints)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TroopsPoints)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HQPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MainPage"
        Me.Text = "Warhammer 40k Army Lists"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmySize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HQPoints As System.Windows.Forms.Label
    Friend WithEvents TroopsPoints As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ElitesPoints As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FAPoints As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents HSPoints As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents RemoveHQ As System.Windows.Forms.Button
    Friend WithEvents RemoveTroops As System.Windows.Forms.Button
    Friend WithEvents RemoveElites As System.Windows.Forms.Button
    Friend WithEvents RemoveFA As System.Windows.Forms.Button
    Friend WithEvents RemoveHS As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ArmySize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HQToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TroopsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElitesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FastAttackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeavySupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyHS As System.Windows.Forms.Button
    Friend WithEvents CopyFA As System.Windows.Forms.Button
    Friend WithEvents CopyElite As System.Windows.Forms.Button
    Friend WithEvents CopyTroops As System.Windows.Forms.Button
    Friend WithEvents CopyHQ As System.Windows.Forms.Button
    Friend WithEvents HQTextBox As System.Windows.Forms.ListBox
    Friend WithEvents TroopsTextBox As System.Windows.Forms.ListBox
    Friend WithEvents ElitesTextBox As System.Windows.Forms.ListBox
    Friend WithEvents FATextBox As System.Windows.Forms.ListBox
    Friend WithEvents HSTextBox As System.Windows.Forms.ListBox

End Class
