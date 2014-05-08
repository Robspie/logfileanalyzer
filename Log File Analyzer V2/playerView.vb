Public Class playerView
    Public PINFO As playerInfo
    Public LFA As lfaMain

    Private Sub playerCkey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub playerView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = PINFO.CKey
        ckeyLBL.Text = "BYOND CKEY: " & PINFO.CKey
        cidLBL.Text = "Computer ID: " & PINFO.computerID
        For Each s As String In PINFO.ingameNames
            inGameNames.Text &= s & vbNewLine
        Next
        For Each s As String In PINFO.IPs
            IPs.Text &= s & vbNewLine
        Next
        If IO.File.Exists(LFA.serverLogPath) Then
            searchServerLog.Enabled = True
        Else
            LFA.updateEnableds()
        End If
        If IO.File.Exists(LFA.attackLogPath) Then
            searchAttackLog.Enabled = True
        Else
            LFA.updateEnableds()
        End If
        If IO.File.Exists(LFA.mergedLogPath) Then
            searchBothButton.Enabled = True
        Else
            LFA.updateEnableds()
        End If
        findSameIPS()
        findSameCIDs()
    End Sub

    Private Sub searchServerLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchServerLog.Click
        Dim SRF As New searchResultForm
        SRF.filePath = LFA.serverLogPath
        SRF.upPosTerms = "+" & PINFO.CKey & "/" & posTerms.Text
        SRF.upNegTerms = negTerms.Text
        SRF.posCaseSensitive = posCaseSensitive.Checked
        SRF.negCaseSensitive = negCaseSensitive.Checked

        SRF.Show()
    End Sub

    Private Sub searchAttackLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchAttackLog.Click
        Dim SRF As New searchResultForm
        SRF.filePath = LFA.attackLogPath
        SRF.upPosTerms = "+" & PINFO.CKey & "/" & posTerms.Text
        SRF.upNegTerms = negTerms.Text
        SRF.posCaseSensitive = posCaseSensitive.Checked
        SRF.negCaseSensitive = negCaseSensitive.Checked

        SRF.Show()
    End Sub

    Private Sub findSameCIDs()
        Dim playersFound As New Dictionary(Of String, playerInfo)
        For Each k As KeyValuePair(Of String, playerInfo) In LFA.playerDict
            If k.Value.CKey <> PINFO.CKey Then
                If k.Value.computerID = PINFO.computerID Then
                    playersFound.Add(k.Key, k.Value)
                End If
            End If
        Next
        sameCIDsListView.Items.Clear()
        For Each k As KeyValuePair(Of String, playerInfo) In playersFound
            sameCIDsListView.Items.Add(k.Key)
        Next
    End Sub

    Private Sub findSameIPS()
        try
            Dim playersFound As New Dictionary(Of String, playerInfo)
            For Each k As KeyValuePair(Of String, playerInfo) In LFA.playerDict
                If k.Value.CKey <> PINFO.CKey Then
                    For Each ip As String In PINFO.IPs
                        If k.Value.IPs.Contains(ip) Then
                            playersFound.Add(k.Key, k.Value)
                        End If
                    Next
                End If
            Next
        sameIPsListView.Items.Clear()
        For Each k As KeyValuePair(Of String, playerInfo) In playersFound
            sameIPsListView.Items.Add(k.Key)
            Next
        Catch ex As Exception
            'i dunno the rest of the lyrics
            err(ex)
        End Try

    End Sub

    Private Sub sameCIDsListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sameCIDsListView.DoubleClick
        newPView(sender)
    End Sub

    Private Sub sameIPsListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sameIPsListView.DoubleClick
        newPView(sender)
    End Sub

    Private Sub newPView(ByVal sender As ListView)
        Dim searchFor As String = sender.FocusedItem.Text
        If LFA.playerDict.ContainsKey(searchFor) Then
            Dim pview As New playerView
            pview.PINFO = LFA.playerDict(searchFor)
            pview.LFA = LFA
            pview.Show()
        End If
    End Sub
End Class