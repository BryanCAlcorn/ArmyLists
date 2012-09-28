Public Class AddForm
    'These are for controlling the model number and points per model
    Private Sub ModelsNumber_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ModelsNumber.KeyUp
        SubTotalLabel.Text = PointsNumber.Value * ModelsNumber.Value
        TotalLabel.Text = SubTotalLabel.Text
    End Sub

    Private Sub ModelsNumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModelsNumber.ValueChanged
        SubTotalLabel.Text = PointsNumber.Value * ModelsNumber.Value
        TotalLabel.Text = SubTotalLabel.Text
    End Sub

    Private Sub PointsNumber_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PointsNumber.KeyUp
        SubTotalLabel.Text = PointsNumber.Value * ModelsNumber.Value
        TotalLabel.Text = SubTotalLabel.Text
    End Sub

    Private Sub PointsNumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointsNumber.ValueChanged
        SubTotalLabel.Text = PointsNumber.Value * ModelsNumber.Value
        TotalLabel.Text = SubTotalLabel.Text
    End Sub

    Private Function MakeData1()
        Dim Text As String
        'Formats the unit's name so that it can go to the main window properly
        Text = SquadName.Text & " x" & ModelsNumber.Value.ToString & ": " & TotalLabel.Text
        Return Text
    End Function
    Private Function MakeData2()
        Dim Text As String
        'formats the unit's upgrades so that it can go to the main window properly
        Text = "      "
        For count As Integer = 0 To (NameListBox.Items.Count - 1)
            Text = Text & NameListBox.Items.Item(count) & ", "
        Next
        Return Text
    End Function

    Private Sub AddEquipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEquipment.Click
        'Makes sure the format is all correct
        If (UpgNumBox.Value > ModelsNumber.Value) Then
            MsgBox("You Are trying to Upgrade Too many models!", MsgBoxStyle.Critical)
        ElseIf (UpgNameBox.Text = "") Then
            MsgBox("Please Enter a Name for your Upgrade", MsgBoxStyle.Critical)
        ElseIf (UpgNumBox.Value = 0) Then
            MsgBox("Please Enter a Value for Number of Models", MsgBoxStyle.Critical)
            'Adds the upgrade to the unit, updating the total points value and adding the items
            'to the list boxes
        Else
            NameListBox.Items.Add(UpgNameBox.Text + " x" + UpgNumBox.Value.ToString)
            PointsListBox.Items.Add(UpgPointsBox.Value * UpgNumBox.Value)
            TotalLabel.Text = Conversion.Int(TotalLabel.Text) + (UpgPointsBox.Value * UpgNumBox.Value)
            UpgNameBox.Text = ""
            UpgNumBox.Value = 0
            UpgPointsBox.Value = 0
        End If
    End Sub

    Private Sub RemoveEquipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveEquipment.Click
        If (NameListBox.SelectedIndex > -1) Then
            'Removes an item from the upgrade list based on the selected index of the item
            TotalLabel.Text = Conversion.Int(TotalLabel.Text) - Conversion.Int(PointsListBox.Items.Item(NameListBox.SelectedIndex))
            PointsListBox.Items.RemoveAt(NameListBox.SelectedIndex)
            NameListBox.Items.RemoveAt(NameListBox.SelectedIndex)
        Else
            MsgBox("Select An Item to Remove", MsgBoxStyle.Critical, "Remove Failed")
        End If
    End Sub

    Private Sub AddSquad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSquad.Click
        Dim Checked As Boolean
        Checked = True
        'These statements make sure the input is all there, so the user cannot mess up the formatting
        If (MainPage.ArmySize.Value <= 0) Then
            Checked = True
        ElseIf (MainPage.ArmySize.Value < (Conversion.Int(MainPage.TotalLabel.Text) + Conversion.Int(TotalLabel.Text))) Then
            MsgBox("Your Unit is too expensive", MsgBoxStyle.Critical)
            Checked = False
        End If
        If (SquadName.Text = "" Or ModelsNumber.Value = 0 Or PointsNumber.Value = 0) Then
            MsgBox("Please Fill out the Name/Number/Points of the Model", MsgBoxStyle.Critical)
            Checked = False
        ElseIf (NameListBox.Items.Count = 0) Then
            MsgBox("Please Put Equipment On your Squad", MsgBoxStyle.Critical)
            Checked = False
        End If
        'This puts the data back into the main window and resets the point values
        If (Checked) Then
            If (TypeLabel.Text = "HQ") Then
                '------------------------------------------------------------------------
                MainPage.HQTextBox.Items.Add(MakeData1())
                MainPage.HQTextBox.Items.Add(MakeData2())
                MainPage.HQPoints.Text = Conversion.Int(MainPage.HQPoints.Text) + Conversion.Int(TotalLabel.Text)
                '---------------------------------------------------------------------
            ElseIf (TypeLabel.Text = "Troops") Then
                MainPage.TroopsTextBox.Items.Add(MakeData1())
                MainPage.TroopsTextBox.Items.Add(MakeData2())
                MainPage.TroopsPoints.Text = Conversion.Int(MainPage.TroopsPoints.Text) + Conversion.Int(TotalLabel.Text)
                '---------------------------------------------------------------------
            ElseIf (TypeLabel.Text = "Elites") Then
                MainPage.ElitesTextBox.Items.Add(MakeData1())
                MainPage.ElitesTextBox.Items.Add(MakeData2())
                MainPage.ElitesPoints.Text = Conversion.Int(MainPage.ElitesPoints.Text) + Conversion.Int(TotalLabel.Text)
                '-------------------------------------------------------------------------
            ElseIf (TypeLabel.Text = "Fast Attack") Then
                MainPage.FATextBox.Items.Add(MakeData1())
                MainPage.FATextBox.Items.Add(MakeData2())
                MainPage.FAPoints.Text = Conversion.Int(MainPage.FAPoints.Text) + Conversion.Int(TotalLabel.Text)
                '---------------------------------------------------------------------------
            ElseIf (TypeLabel.Text = "Heavy Support") Then
                MainPage.HSTextBox.Items.Add(MakeData1())
                MainPage.HSTextBox.Items.Add(MakeData2())
                MainPage.HSPoints.Text = Conversion.Int(MainPage.HSPoints.Text) + Conversion.Int(TotalLabel.Text)
                '-------------------------------------------------------------------------
            End If
            'Closes the window, and resets the total points to the new value
            Me.Close()
            MainPage.Saved = False
            MainPage.TotalLabel.Text = Conversion.Int(MainPage.HQPoints.Text) + Conversion.Int(MainPage.TroopsPoints.Text) + Conversion.Int(MainPage.ElitesPoints.Text) + Conversion.Int(MainPage.FAPoints.Text) + Conversion.Int(MainPage.HSPoints.Text)
        End If
    End Sub

    Private Sub AddForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MainPage.ArmySize.Value = 0 Then
            PointsLeft.Text = "N/A"
        Else
            PointsLeft.Text = MainPage.ArmySize.Value - Conversion.Int(MainPage.TotalLabel.Text)
        End If
    End Sub
End Class