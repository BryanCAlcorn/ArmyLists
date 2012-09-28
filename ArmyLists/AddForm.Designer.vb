<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.SquadName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PointsNumber = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.ModelsNumber = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.SubTotalLabel = New System.Windows.Forms.Label
        Me.AddSquad = New System.Windows.Forms.Button
        Me.TypeLabel = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TotalLabel = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.UpgNameBox = New System.Windows.Forms.TextBox
        Me.UpgPointsBox = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.UpgNumBox = New System.Windows.Forms.NumericUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.AddEquipment = New System.Windows.Forms.Button
        Me.NameListBox = New System.Windows.Forms.ListBox
        Me.PointsListBox = New System.Windows.Forms.ListBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RemoveEquipment = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.PointsLeft = New System.Windows.Forms.Label
        CType(Me.PointsNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelsNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpgPointsBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpgNumBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name Of the Squad:"
        '
        'SquadName
        '
        Me.SquadName.Location = New System.Drawing.Point(125, 37)
        Me.SquadName.Name = "SquadName"
        Me.SquadName.Size = New System.Drawing.Size(152, 20)
        Me.SquadName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Points Per Model:"
        '
        'PointsNumber
        '
        Me.PointsNumber.Location = New System.Drawing.Point(125, 85)
        Me.PointsNumber.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.PointsNumber.Name = "PointsNumber"
        Me.PointsNumber.Size = New System.Drawing.Size(44, 20)
        Me.PointsNumber.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of Models:"
        '
        'ModelsNumber
        '
        Me.ModelsNumber.Location = New System.Drawing.Point(125, 61)
        Me.ModelsNumber.Name = "ModelsNumber"
        Me.ModelsNumber.Size = New System.Drawing.Size(44, 20)
        Me.ModelsNumber.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sub Total:"
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Location = New System.Drawing.Point(125, 113)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(13, 13)
        Me.SubTotalLabel.TabIndex = 7
        Me.SubTotalLabel.Text = "0"
        '
        'AddSquad
        '
        Me.AddSquad.Location = New System.Drawing.Point(496, 293)
        Me.AddSquad.Name = "AddSquad"
        Me.AddSquad.Size = New System.Drawing.Size(75, 23)
        Me.AddSquad.TabIndex = 8
        Me.AddSquad.Text = "Add Squad"
        Me.AddSquad.UseVisualStyleBackColor = True
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLabel.Location = New System.Drawing.Point(6, 6)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(51, 24)
        Me.TypeLabel.TabIndex = 9
        Me.TypeLabel.Text = "Text"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Upgrades:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(479, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(532, 266)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(20, 24)
        Me.TotalLabel.TabIndex = 12
        Me.TotalLabel.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Points:"
        '
        'UpgNameBox
        '
        Me.UpgNameBox.Location = New System.Drawing.Point(70, 156)
        Me.UpgNameBox.Name = "UpgNameBox"
        Me.UpgNameBox.Size = New System.Drawing.Size(320, 20)
        Me.UpgNameBox.TabIndex = 19
        '
        'UpgPointsBox
        '
        Me.UpgPointsBox.Location = New System.Drawing.Point(496, 156)
        Me.UpgPointsBox.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.UpgPointsBox.Name = "UpgPointsBox"
        Me.UpgPointsBox.Size = New System.Drawing.Size(36, 20)
        Me.UpgPointsBox.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(493, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Points:"
        '
        'UpgNumBox
        '
        Me.UpgNumBox.Location = New System.Drawing.Point(397, 156)
        Me.UpgNumBox.Name = "UpgNumBox"
        Me.UpgNumBox.Size = New System.Drawing.Size(93, 20)
        Me.UpgNumBox.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(394, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Number of Models:"
        '
        'AddEquipment
        '
        Me.AddEquipment.Location = New System.Drawing.Point(536, 154)
        Me.AddEquipment.Name = "AddEquipment"
        Me.AddEquipment.Size = New System.Drawing.Size(35, 23)
        Me.AddEquipment.TabIndex = 25
        Me.AddEquipment.Text = "Add"
        Me.AddEquipment.UseVisualStyleBackColor = True
        '
        'NameListBox
        '
        Me.NameListBox.FormattingEnabled = True
        Me.NameListBox.Location = New System.Drawing.Point(10, 196)
        Me.NameListBox.Name = "NameListBox"
        Me.NameListBox.Size = New System.Drawing.Size(336, 95)
        Me.NameListBox.TabIndex = 26
        '
        'PointsListBox
        '
        Me.PointsListBox.FormatString = "N0"
        Me.PointsListBox.FormattingEnabled = True
        Me.PointsListBox.Location = New System.Drawing.Point(353, 196)
        Me.PointsListBox.Name = "PointsListBox"
        Me.PointsListBox.Size = New System.Drawing.Size(120, 95)
        Me.PointsListBox.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(283, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'RemoveEquipment
        '
        Me.RemoveEquipment.Location = New System.Drawing.Point(483, 196)
        Me.RemoveEquipment.Name = "RemoveEquipment"
        Me.RemoveEquipment.Size = New System.Drawing.Size(75, 23)
        Me.RemoveEquipment.TabIndex = 29
        Me.RemoveEquipment.Text = "Remove"
        Me.RemoveEquipment.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(447, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Points Left:"
        '
        'PointsLeft
        '
        Me.PointsLeft.AutoSize = True
        Me.PointsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PointsLeft.Location = New System.Drawing.Point(447, 37)
        Me.PointsLeft.Name = "PointsLeft"
        Me.PointsLeft.Size = New System.Drawing.Size(21, 24)
        Me.PointsLeft.TabIndex = 31
        Me.PointsLeft.Text = "0"
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 322)
        Me.Controls.Add(Me.PointsLeft)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RemoveEquipment)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PointsListBox)
        Me.Controls.Add(Me.NameListBox)
        Me.Controls.Add(Me.AddEquipment)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.UpgNumBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UpgPointsBox)
        Me.Controls.Add(Me.UpgNameBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.AddSquad)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ModelsNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PointsNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SquadName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddForm"
        Me.Text = "AddForm"
        CType(Me.PointsNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelsNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpgPointsBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpgNumBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SquadName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PointsNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ModelsNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents AddSquad As System.Windows.Forms.Button
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UpgNameBox As System.Windows.Forms.TextBox
    Friend WithEvents UpgPointsBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UpgNumBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AddEquipment As System.Windows.Forms.Button
    Friend WithEvents NameListBox As System.Windows.Forms.ListBox
    Friend WithEvents PointsListBox As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RemoveEquipment As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PointsLeft As System.Windows.Forms.Label
End Class
