Imports System.IO

Public Class searchResultForm
    Public filePath As String
    Public upPosTerms As String
    Public upNegTerms As String
    Public posCaseSensitive As Boolean
    Public negCaseSensitive As Boolean
    Dim tempFilePath As String
    Private Sub searchResultForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "(" & filePath & ")+" & upPosTerms & " | " & "-" & upNegTerms

            Dim QRand As New Random
            Dim tempFileName As String = makeFileNameSafe("+" & upPosTerms & " ; -" & upNegTerms & ";" & QRand.Next(2 << 20, 2 << 21) & ".tmp")
            tempFilePath = "logFileAnalyzer/" & Now.Month & "-" & Now.Day & "/" & tempFileName


            Dim line As String = ""
            Dim hasNegs As Boolean = True
            Dim PosTerms() As String = upPosTerms.Split("/")
            Dim NegTerms() As String = upNegTerms.Split("/")
            Dim PosANDTermsCount As Integer = 0
            Dim PosORTermsCount As Integer = 0
            For Each term As String In PosTerms
                If term <> "" Then
                    If term(0) = "+" Then
                        PosANDTermsCount += 1
                    Else
                        PosORTermsCount += 1
                    End If
                End If
            Next
                
                If NegTerms.Length = 1 Then
                    If NegTerms(0) = "" Then
                        hasNegs = False
                    End If
            End If
            Dim pass As Boolean = False
            Dim numPassed As Integer = 0
            Dim PosAndTermsFound As Integer = 0
            Dim posOrTermsFound As Integer = 0
            Using logFileReader As New StreamReader(filePath)
                Using tempFileWriter As New StreamWriter(tempFilePath)
                    If hasNegs = False Then
                        While logFileReader.EndOfStream = False
                            line = logFileReader.ReadLine
                            For Each term As String In PosTerms
                                If term <> "" Then
                                    If term(0) = "+" Then
                                        If IIf(posCaseSensitive, line, line.ToLower).ToString.Contains(IIf(posCaseSensitive, term, term.ToLower).ToString.Substring(1)) Then
                                            PosAndTermsFound += 1
                                            numPassed += 1
                                        End If
                                    Else
                                        If IIf(posCaseSensitive, line, line.ToLower).ToString.Contains(IIf(posCaseSensitive, term, term.ToLower).ToString.Substring(1)) Then
                                            posOrTermsFound += 1
                                            numPassed += 1
                                        End If
                                    End If
                                End If
                            Next
                            If (numPassed > 0) And (PosAndTermsFound = PosANDTermsCount) And (IIf(PosORTermsCount = 0, True, posOrTermsFound > 0)) Then
                                tempFileWriter.WriteLine(line)
                            End If
                            numPassed = 0
                            PosAndTermsFound = 0
                        End While
                    Else
                        While logFileReader.EndOfStream = False
                            line = logFileReader.ReadLine
                            For Each term As String In PosTerms
                                If term <> "" Then
                                    If term(0) = "+" Then
                                        If IIf(posCaseSensitive, line, line.ToLower).ToString.Contains(IIf(posCaseSensitive, term, term.ToLower).ToString.Substring(1)) Then
                                            PosAndTermsFound += 1
                                            numPassed += 1
                                        End If
                                    Else
                                        If IIf(posCaseSensitive, line, line.ToLower).ToString.Contains(IIf(posCaseSensitive, term, term.ToLower).ToString.Substring(1)) Then
                                            posOrTermsFound += 1
                                            numPassed += 1
                                        End If
                                    End If
                                Else
                                    numPassed += 1
                                End If
                            Next

                            If ((numPassed > 0) And (PosAndTermsFound = PosANDTermsCount)) And hasNegs Then
                                For Each term As String In NegTerms
                                    If (IIf(negCaseSensitive, line, line.ToLower).ToString.Contains(IIf(negCaseSensitive, term, term.ToLower).ToString)) Then
                                        numPassed = 0
                                    End If
                                Next
                            End If

                            If (numPassed > 0) And (PosAndTermsFound = PosANDTermsCount) And (IIf(PosORTermsCount = 0, True, posOrTermsFound > 0)) Then
                                tempFileWriter.WriteLine(line)
                            End If
                            numPassed = 0
                            PosAndTermsFound = 0
                            posOrTermsFound = 0
                        End While
                    End If
                End Using
            End Using
            resultTextBox.LoadFile(tempFilePath, RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            'GOTTA CATCH 'EM ALL
            Misc.err(ex)
        End Try
    End Sub

    Private Sub narrowResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narrowResults.Click
        Dim SRF As New searchResultForm
        SRF.filePath = tempFilePath
        SRF.upPosTerms = newPosTerms.Text
        SRF.upNegTerms = newNegTerms.Text
        SRF.posCaseSensitive = newPosCaseSensitive.Checked
        SRF.negCaseSensitive = newNegCaseSensitive.Checked

        SRF.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim SFD As New SaveFileDialog
            SFD.Title = "Select Output File"
            SFD.OverwritePrompt = True
            SFD.Filter = "log|*.txt;*.log"
            SFD.ValidateNames = True

            SFD.ShowDialog()
            If SFD.FileName <> "" Then
                resultTextBox.SaveFile(SFD.FileName, RichTextBoxStreamType.PlainText)
                MsgBox("File Saved", MsgBoxStyle.Information, "Probably A Success")
            End If
        Catch ex As Exception
            'POKEMON
            err(ex)
        End Try
    End Sub
End Class