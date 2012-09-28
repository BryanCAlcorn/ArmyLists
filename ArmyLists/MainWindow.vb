Public Class MainPage
    Public Saved As Boolean = True
    Private Sub RemoveHQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveHQ.Click
        Dim Index As Integer
        Dim PointVal As Integer
        'These blocks remove the selected unit from the listbox, weather you select the equipment
        'or the unit itself. Based on the selected index
        If (HQTextBox.SelectedIndex > -1) Then
            Index = HQTextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Remove " & HQTextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Remove") = MsgBoxResult.Yes) Then
                PointVal = Searching(HQTextBox.Items.Item(Index))
                HQPoints.Text = Conversion.Int(HQPoints.Text) - PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) - PointVal
                HQTextBox.Items.RemoveAt(Index)
                HQTextBox.Items.RemoveAt(Index)
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Remove", MsgBoxStyle.Critical, "Remove Failed")
        End If
    End Sub

    Private Sub RemoveTroops_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveTroops.Click
        Dim Index As Integer
        Dim PointVal As Integer
        If (TroopsTextBox.SelectedIndex > -1) Then
            Index = TroopsTextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Remove " & TroopsTextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Remove") = MsgBoxResult.Yes) Then
                PointVal = Searching(TroopsTextBox.Items.Item(Index))
                TroopsPoints.Text = Conversion.Int(TroopsPoints.Text) - PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) - PointVal
                TroopsTextBox.Items.RemoveAt(Index)
                TroopsTextBox.Items.RemoveAt(Index)
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Remove", MsgBoxStyle.Critical, "Remove Failed")
        End If
    End Sub

    Private Sub RemoveElites_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveElites.Click
        Dim Index As Integer
        Dim PointVal As Integer
        If (ElitesTextBox.SelectedIndex > -1) Then
            Index = ElitesTextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Remove " & ElitesTextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Remove") = MsgBoxResult.Yes) Then
                PointVal = Searching(ElitesTextBox.Items.Item(Index))
                ElitesPoints.Text = Conversion.Int(ElitesPoints.Text) - PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) - PointVal
                ElitesTextBox.Items.RemoveAt(Index)
                ElitesTextBox.Items.RemoveAt(Index)
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Remove", MsgBoxStyle.Critical, "Remove Failed")
        End If
    End Sub

    Private Sub RemoveFA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFA.Click
        Dim Index As Integer
        Dim PointVal As Integer
        If (FATextBox.SelectedIndex > -1) Then
            Index = FATextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Remove " & FATextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Remove") = MsgBoxResult.Yes) Then
                PointVal = Searching(FATextBox.Items.Item(Index))
                FAPoints.Text = Conversion.Int(FAPoints.Text) - PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) - PointVal
                FATextBox.Items.RemoveAt(Index)
                FATextBox.Items.RemoveAt(Index)
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Remove", MsgBoxStyle.Critical, "Remove Failed")
        End If
    End Sub

    Private Sub RemoveHS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveHS.Click
        Dim Index As Integer
        Dim PointVal As Integer
        If (HSTextBox.SelectedIndex > -1) Then
            Index = HSTextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Remove " & HSTextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Remove") = MsgBoxResult.Yes) Then
                PointVal = Searching(HSTextBox.Items.Item(Index))
                HSPoints.Text = Conversion.Int(HSPoints.Text) - PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) - PointVal
                HSTextBox.Items.RemoveAt(Index)
                HSTextBox.Items.RemoveAt(Index)
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Remove", MsgBoxStyle.Critical, "Remove Failed")
        End If
    End Sub

    Public Function Searching(ByVal Search As String)
        Dim SearchArray() As Char
        Dim Found As Boolean
        Dim SearchString As String
        Dim Find As Integer

        SearchArray = Search.ToCharArray()
        ReDim Preserve SearchArray(SearchArray.Length)
        Found = False
        SearchString = ""

        'This searches the string for the ":" character to get the points cost for a unit
        For count As Integer = 0 To (SearchArray.Length - 1)
            If (Found) Then
                SearchString = SearchString + SearchArray(count)
            End If
            If (SearchArray(count) = ":") Then
                Found = True
            End If
        Next

        Find = Conversion.Int(SearchString)
        Return Find
    End Function
    Public Sub Loader()
        Dim OFD As New OpenFileDialog
        Dim Temp(5) As Integer
        Dim ArmyArray(5) As String

        OFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        
        If (OFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim SR As IO.StreamReader = IO.File.OpenText(OFD.FileName)
            Dim Text As String
            'Deletes the Previous List
            For i As Integer = 0 To HQTextBox.Items.Count - 1
                HQTextBox.Items.RemoveAt(0)
            Next
            For i As Integer = 0 To TroopsTextBox.Items.Count - 1
                TroopsTextBox.Items.RemoveAt(0)
            Next
            For i As Integer = 0 To ElitesTextBox.Items.Count - 1
                ElitesTextBox.Items.RemoveAt(0)
            Next
            For i As Integer = 0 To FATextBox.Items.Count - 1
                FATextBox.Items.RemoveAt(0)
            Next
            For i As Integer = 0 To HSTextBox.Items.Count - 1
                HSTextBox.Items.RemoveAt(0)
            Next
            'Loads the List into the string variable
            Text = SR.ReadToEnd
            SR.Close()
            'Sets the Labels for the point values to the ones loaded, based on format saved
            TotalLabel.Text = Text.Substring(7, 4)
            Temp(0) = Text.IndexOf("HQ:")
            HQPoints.Text = Text.Substring(Temp(0) + 4, 4)
            Temp(1) = Text.IndexOf("Troops:")
            TroopsPoints.Text = Text.Substring(Temp(1) + 8, 4)
            Temp(2) = Text.IndexOf("Elites:")
            ElitesPoints.Text = Text.Substring(Temp(2) + 8, 4)
            Temp(3) = Text.IndexOf("Fast Attack:")
            FAPoints.Text = Text.Substring(Temp(3) + 13, 4)
            Temp(4) = Text.IndexOf("Heavy Support:")
            HSPoints.Text = Text.Substring(Temp(4) + 15, 4)
            'Makes seperate strings for each piece of the army list
            ArmyArray(0) = Text.Substring(Temp(0), Temp(1) - Temp(0))
            ArmyArray(1) = Text.Substring(Temp(1), Temp(2) - Temp(1))
            ArmyArray(2) = Text.Substring(Temp(2), Temp(3) - Temp(2))
            ArmyArray(3) = Text.Substring(Temp(3), Temp(4) - Temp(3))
            ArmyArray(4) = Text.Substring(Temp(4), Text.Length() - Temp(4))
            'These blocks search for the distinctive "|" character and the one after,
            'then get the text in between them.
            Dim Start As Integer = 0
            Dim Fin As Integer = 0
            While (ArmyArray(0).IndexOf("|", Start + 1) <> -1)
                If (Start = 0) Then
                    Start = ArmyArray(0).IndexOf("|")
                End If
                Fin = ArmyArray(0).IndexOf("|", Start + 1)
                HQTextBox.Items.Add(ArmyArray(0).Substring(Start + 1, (Fin - Start - 3)))
                Start = Fin
            End While

            Start = 0
            Fin = 0
            While (ArmyArray(1).IndexOf("|", Start + 1) <> -1)
                If (Start = 0) Then
                    Start = ArmyArray(1).IndexOf("|")
                End If
                Fin = ArmyArray(1).IndexOf("|", Start + 1)
                TroopsTextBox.Items.Add(ArmyArray(1).Substring(Start + 1, (Fin - Start - 3)))
                Start = Fin
            End While

            Start = 0
            Fin = 0
            While (ArmyArray(2).IndexOf("|", Start + 1) <> -1)
                If (Start = 0) Then
                    Start = ArmyArray(2).IndexOf("|")
                End If
                Fin = ArmyArray(2).IndexOf("|", Start + 1)
                ElitesTextBox.Items.Add(ArmyArray(2).Substring(Start + 1, (Fin - Start - 3)))
                Start = Fin
            End While

            Start = 0
            Fin = 0
            While (ArmyArray(3).IndexOf("|", Start + 1) <> -1)
                If (Start = 0) Then
                    Start = ArmyArray(3).IndexOf("|")
                End If
                Fin = ArmyArray(3).IndexOf("|", Start + 1)
                FATextBox.Items.Add(ArmyArray(3).Substring(Start + 1, (Fin - Start - 3)))
                Start = Fin
            End While

            Start = 0
            Fin = 0
            While (ArmyArray(4).IndexOf("|", Start + 1) <> -1)
                If (Start = 0) Then
                    Start = ArmyArray(4).IndexOf("|")
                End If
                Fin = ArmyArray(4).IndexOf("|", Start + 1)
                HSTextBox.Items.Add(ArmyArray(4).Substring(Start + 1, (Fin - Start - 3)))
                Start = Fin
            End While
        End If
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Dim HelpString As String
        HelpString = "Welcome to WH40K Army Lists!" & vbNewLine & "To add a selection go to file and select Add > Unit type, this will bring up a new window, where you can add a Unit to your army" & vbNewLine
        HelpString = HelpString & "If you leave the Army Size at 0, there will be no restrictions imposed" & vbNewLine
        HelpString = HelpString & "You Must add at least one piece of Equipment to each Unit that you make, default equipment can work if you have no upgrades" & vbNewLine
        HelpString = HelpString & "To Remove a Unit/Upgrade Simply Click on the Names inside the boxes and press the remove button" & vbNewLine
        'HelpString = HelpString & "To Edit a Unit/Upgrade Click on the Names inside the boxes and press the edit button" & vbNewLine
        HelpString = HelpString & "The Save Button will save your army as a new text file in the path that you specify" & vbNewLine
        HelpString = HelpString & "The Load Button will load an army list from a previous text file, Make sure you do not re-format the file for loading purposes" & vbNewLine
        HelpString = HelpString & "All Pictures and Logos used are copyrighted by Games Workshop Ltd." & vbNewLine
        MsgBox(HelpString, MsgBoxStyle.Information)
    End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        Dim THESTRING As String
        Dim Sfd As New SaveFileDialog

        Sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"

        'This formats the string to go to the save file, First it gets the point values,
        'then it takes all of the items from the seperate list boxes, then it adds a "|"
        'character if it is needed so the file can be loaded later.
        If (Sfd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            THESTRING = "Total: " & TotalLabel.Text & vbNewLine & vbNewLine
            THESTRING = THESTRING & "HQ: " & HQPoints.Text & " " & vbNewLine
            If (HQTextBox.Items.Count > 0) Then
                For index As Integer = 0 To (HQTextBox.Items.Count - 1)
                    THESTRING = THESTRING & "|" & HQTextBox.Items.Item(index) & vbNewLine
                Next
                If (HQTextBox.Items.Count <> 0) Then
                    THESTRING = THESTRING & "|"
                End If
            End If
            THESTRING = THESTRING & vbNewLine & "Troops: " & TroopsPoints.Text & " " & vbNewLine
            If (TroopsTextBox.Items.Count > 0) Then
                For index As Integer = 0 To (TroopsTextBox.Items.Count - 1)
                    THESTRING = THESTRING & "|" & TroopsTextBox.Items.Item(index) & vbNewLine
                Next
                If (TroopsTextBox.Items.Count <> 0) Then
                    THESTRING = THESTRING & "|"
                End If
            End If
            THESTRING = THESTRING & vbNewLine & "Elites: " & ElitesPoints.Text & " " & vbNewLine
            If (ElitesTextBox.Items.Count > 0) Then
                For index As Integer = 0 To (ElitesTextBox.Items.Count - 1)
                    THESTRING = THESTRING & "|" & ElitesTextBox.Items.Item(index) & vbNewLine
                Next
                If (ElitesTextBox.Items.Count <> 0) Then
                    THESTRING = THESTRING & "|"
                End If
            End If
            THESTRING = THESTRING & vbNewLine & "Fast Attack: " & FAPoints.Text & " " & vbNewLine
            If (FATextBox.Items.Count > 0) Then
                For index As Integer = 0 To (FATextBox.Items.Count - 1)
                    THESTRING = THESTRING & "|" & FATextBox.Items.Item(index) & vbNewLine
                Next
                If (FATextBox.Items.Count <> 0) Then
                    THESTRING = THESTRING & "|"
                End If
            End If
            THESTRING = THESTRING & vbNewLine & "Heavy Support: " & HSPoints.Text & " " & vbNewLine
            If (HSTextBox.Items.Count > 0) Then
                For index As Integer = 0 To (HSTextBox.Items.Count - 1)
                    THESTRING = THESTRING & "|" & HSTextBox.Items.Item(index) & vbNewLine
                Next
                If (HSTextBox.Items.Count <> 0) Then
                    THESTRING = THESTRING & "|"
                End If
            End If
            Saved = True
            My.Computer.FileSystem.WriteAllText(Sfd.FileName, THESTRING, False)
        End If
    End Sub

    Private Sub LoadTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadTool.Click
        If (Saved = False) Then
            If (MsgBox("Are You Sure you Want to load? (Your List is not Saved)", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Loader()
            End If
        Else
            Loader()
        End If
    End Sub

    Private Sub HQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HQToolStripMenuItem.Click
        AddForm.TypeLabel.Text = "HQ"
        AddForm.Show()
    End Sub

    Private Sub TroopsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TroopsToolStripMenuItem.Click
        AddForm.TypeLabel.Text = "Troops"
        AddForm.Show()
    End Sub

    Private Sub ElitesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElitesToolStripMenuItem.Click
        AddForm.TypeLabel.Text = "Elites"
        AddForm.Show()
    End Sub

    Private Sub FastAttackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FastAttackToolStripMenuItem.Click
        AddForm.TypeLabel.Text = "Fast Attack"
        AddForm.Show()
    End Sub

    Private Sub HeavySupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeavySupportToolStripMenuItem.Click
        AddForm.TypeLabel.Text = "Heavy Support"
        AddForm.Show()
    End Sub

    Private Sub CopyHQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyHQ.Click
        Dim Index As Integer
        Dim PointVal As Integer

        If (HQTextBox.SelectedIndex > -1) Then
            Index = HQTextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Copy " & HQTextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Copy") = MsgBoxResult.Yes) Then
                PointVal = Searching(HQTextBox.Items.Item(Index))
                HQPoints.Text = Conversion.Int(HQPoints.Text) + PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) + PointVal
                HQTextBox.Items.Add(HQTextBox.Items.Item(Index))
                HQTextBox.Items.Add(HQTextBox.Items.Item(Index + 1))
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Copy", MsgBoxStyle.Critical, "Copy Failed")
        End If
    End Sub

    Private Sub CopyTroops_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyTroops.Click
        Dim Index As Integer
        Dim PointVal As Integer

        If (TroopsTextBox.SelectedIndex > -1) Then
            Index = TroopsTextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Copy " & TroopsTextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Copy") = MsgBoxResult.Yes) Then
                PointVal = Searching(TroopsTextBox.Items.Item(Index))
                TroopsPoints.Text = Conversion.Int(TroopsPoints.Text) + PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) + PointVal
                TroopsTextBox.Items.Add(TroopsTextBox.Items.Item(Index))
                TroopsTextBox.Items.Add(TroopsTextBox.Items.Item(Index + 1))
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Copy", MsgBoxStyle.Critical, "Copy Failed")
        End If
    End Sub

    Private Sub CopyElite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyElite.Click
        Dim Index As Integer
        Dim PointVal As Integer

        If (ElitesTextBox.SelectedIndex > -1) Then
            Index = ElitesTextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Copy " & ElitesTextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Copy") = MsgBoxResult.Yes) Then
                PointVal = Searching(ElitesTextBox.Items.Item(Index))
                ElitesPoints.Text = Conversion.Int(ElitesPoints.Text) + PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) + PointVal
                ElitesTextBox.Items.Add(ElitesTextBox.Items.Item(Index))
                ElitesTextBox.Items.Add(ElitesTextBox.Items.Item(Index + 1))
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Copy", MsgBoxStyle.Critical, "Copy Failed")
        End If
    End Sub

    Private Sub CopyFA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFA.Click
        Dim Index As Integer
        Dim PointVal As Integer

        If (FATextBox.SelectedIndex > -1) Then
            Index = FATextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Copy " & FATextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Copy") = MsgBoxResult.Yes) Then
                PointVal = Searching(FATextBox.Items.Item(Index))
                FAPoints.Text = Conversion.Int(FAPoints.Text) + PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) + PointVal
                FATextBox.Items.Add(FATextBox.Items.Item(Index))
                FATextBox.Items.Add(FATextBox.Items.Item(Index + 1))
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Copy", MsgBoxStyle.Critical, "Copy Failed")
        End If
    End Sub

    Private Sub CopyHS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyHS.Click
        Dim Index As Integer
        Dim PointVal As Integer

        If (HSTextBox.SelectedIndex > -1) Then
            Index = HSTextBox.SelectedIndex
            If (Index Mod 2 <> 0) Then
                Index = Index - 1
            End If
            If (MsgBox("Are You Sure You Want to Copy " & HSTextBox.Items.Item(Index), MsgBoxStyle.YesNo, "Copy") = MsgBoxResult.Yes) Then
                PointVal = Searching(HSTextBox.Items.Item(Index))
                HSPoints.Text = Conversion.Int(HSPoints.Text) + PointVal
                TotalLabel.Text = Conversion.Int(TotalLabel.Text) + PointVal
                HSTextBox.Items.Add(HSTextBox.Items.Item(Index))
                HSTextBox.Items.Add(HSTextBox.Items.Item(Index + 1))
            End If
            Saved = False
        Else
            MsgBox("Select An Item to Copy", MsgBoxStyle.Critical, "Copy Failed")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
