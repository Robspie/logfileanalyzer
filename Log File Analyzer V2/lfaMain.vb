Imports System.IO
Public Class lfaMain
    Public playerDict As New Dictionary(Of String, playerInfo)
    Dim logLoadedColor As Color = Color.LightGreen
    Dim logNotLoadedColor As Color = Color.LightCoral
    Dim logsHalfLoadedColor As Color = Color.FromArgb(255, 255, 128)

    Public serverLogPath As String = ""
    Public attackLogPath As String = ""
    Public mergedLogPath As String = ""

    Private Sub lfaMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Log File Analyzer " & Application.ProductVersion
        OpenLogFileToolStripMenuItem.BackColor = logNotLoadedColor
        ServerToolStripMenuItem.BackColor = logNotLoadedColor
        AttackToolStripMenuItem.BackColor = logNotLoadedColor
        Try
            If Directory.Exists("logFileAnalyzer") = False Then
                Directory.CreateDirectory("logFileAnalyzer")
            End If
            If Directory.Exists("logFileAnalyzer/" & Now.Month & "-" & Now.Day) = False Then
                Directory.CreateDirectory("logFileAnalyzer/" & Now.Month & "-" & Now.Day)
            End If
        Catch ex As Exception
            'I wanna be the very best; like no one ever was
            err(ex)
        End Try

    End Sub

    Private Sub ServerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerToolStripMenuItem.Click
        Dim serverLogOFD As New OpenFileDialog
        serverLogOFD.Filter = "log|*.txt;*.log"
        serverLogOFD.Title = "Open Server Log"
        serverLogOFD.Multiselect = False

        serverLogOFD.ShowDialog()
        If File.Exists(serverLogOFD.FileName) Then
            serverLogPath = serverLogOFD.FileName
            ServerToolStripMenuItem.BackColor = logLoadedColor
            If attackLogPath = "" Then
                OpenLogFileToolStripMenuItem.BackColor = logsHalfLoadedColor
            Else
                OpenLogFileToolStripMenuItem.BackColor = logLoadedColor
                mergeLogFiles()
            End If
            searchServerLogs.Enabled = True
            getPlayers(serverLogPath, playerDict)
            playerListView.Items.Clear()
            For Each KVP As KeyValuePair(Of String, playerInfo) In playerDict
                Dim addStr As String = KVP.Key & "("
                For Each s As String In KVP.Value.ingameNames
                    addStr &= s & ", "
                Next
                addStr = addStr.Substring(0, addStr.Length - 2)
                addStr &= ")"
                Dim newItem As New ListViewItem
                newItem.Text = addStr
                newItem.Tag = KVP.Key
                playerListView.Items.Add(newItem)
            Next
        Else
            If serverLogOFD.FileName.Length > 0 Then
                MsgBox("The file you selected doesn't exist!" & vbNewLine &
                       "You tried to open the file: " & vbNewLine &
                       serverLogOFD.FileName,
                       MsgBoxStyle.OkOnly,
                       "Error")
            End If
        End If
    End Sub

    Private Sub searchServerLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchServerLogs.Click
        Dim SRF As New searchResultForm
        SRF.filePath = serverLogPath
        SRF.upPosTerms = posTerms.Text
        SRF.upNegTerms = negTerms.Text
        SRF.posCaseSensitive = posCaseSensitive.Checked
        SRF.negCaseSensitive = negCaseSensitive.Checked

        SRF.Show()
    End Sub

    Private Sub AttackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttackToolStripMenuItem.Click
        'Fuck yeah copy/paste
        Dim serverLogOFD As New OpenFileDialog
        serverLogOFD.Filter = "log|*.txt;*.log"
        serverLogOFD.Title = "Open Attack Log"
        serverLogOFD.Multiselect = False

        serverLogOFD.ShowDialog()
        If File.Exists(serverLogOFD.FileName) Then
            attackLogPath = serverLogOFD.FileName
            AttackToolStripMenuItem.BackColor = logLoadedColor
            If serverLogPath = "" Then
                OpenLogFileToolStripMenuItem.BackColor = logsHalfLoadedColor
            Else
                OpenLogFileToolStripMenuItem.BackColor = logLoadedColor
                mergeLogFiles()
            End If
            searchAttackLogs.Enabled = True
        Else
            If serverLogOFD.FileName.Length > 0 Then
                MsgBox("The file you selected doesn't exist!" & vbNewLine &
                       "You tried to open the file: " & vbNewLine &
                       serverLogOFD.FileName,
                       MsgBoxStyle.OkOnly,
                       "Error")
            End If
        End If
    End Sub

    Private Sub searchAttackLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchAttackLogs.Click
        Dim SRF As New searchResultForm
        SRF.filePath = attackLogPath
        SRF.upPosTerms = posTerms.Text
        SRF.upNegTerms = negTerms.Text
        SRF.posCaseSensitive = posCaseSensitive.Checked
        SRF.negCaseSensitive = negCaseSensitive.Checked

        SRF.Show()
    End Sub

    Private Sub playerListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles playerListView.DoubleClick
        Dim searchFor As String = playerListView.FocusedItem.Tag
        If playerDict.ContainsKey(searchFor) Then
            Dim pview As New playerView
            pview.PINFO = playerDict(searchFor)
            pview.LFA = Me
            pview.Show()
        End If
    End Sub

    Private Sub playerListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playerListView.SelectedIndexChanged

    End Sub

    Private Sub CleanupLFADirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanupLFADirectoryToolStripMenuItem.Click
        Try
            Directory.Delete("LogFileAnalyzer/", True)
            Directory.CreateDirectory("LogFileAnalyzer/")
            MsgBox("Successfully cleaned the LFA Tempory Directory(./logFileAnalyzer)", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            'To train them is my cause
            err(ex)
        End Try
    End Sub

    Private Sub searchPlayersButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchPlayersButton.Click
        playerListView.Clear()
        For Each KVP As KeyValuePair(Of String, playerInfo) In playerDict
            If KVP.Value.searchInfo(searchPlayers.Text) Then
                Dim addStr As String = KVP.Key & "("
                For Each s As String In KVP.Value.ingameNames
                    addStr &= s & ", "
                Next
                addStr = addStr.Substring(0, addStr.Length - 2)
                addStr &= ")"
                Dim newItem As New ListViewItem
                newItem.Text = addStr
                newItem.Tag = KVP.Key
                playerListView.Items.Add(newItem)
            End If
        Next
    End Sub

    Private Sub mergeLogFiles()
        If attackLogPath <> "" And serverLogPath <> "" Then
            Dim rander As New Random
            Dim tempFileName As String = makeFileNameSafe("combined" & rander.Next(2 << 20, 2 << 21) & ".tmp")
            Dim tempFilePath = "logFileAnalyzer/" & Now.Month & "-" & Now.Day & "/" & tempFileName
            mergeAttackAndServer(serverLogPath, attackLogPath, tempFilePath)
            mergedLogPath = tempFilePath
            searchBothButton.Enabled = True
        End If
    End Sub

    Private Sub searchBothButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchBothButton.Click
        Dim SRF As New searchResultForm
        SRF.filePath = mergedLogPath
        SRF.upPosTerms = posTerms.Text
        SRF.upNegTerms = negTerms.Text
        SRF.posCaseSensitive = posCaseSensitive.Checked
        SRF.negCaseSensitive = negCaseSensitive.Checked

        SRF.Show()
    End Sub

    Public Sub updateEnableds()
        If File.Exists(serverLogPath) = False Then
            searchServerLogs.Enabled = False
        End If
        If File.Exists(attackLogPath) = False Then
            searchAttackLogs.Enabled = False
        End If
        If File.Exists(mergedLogPath) = False Then
            searchBothButton.Enabled = False
        End If
    End Sub
End Class
