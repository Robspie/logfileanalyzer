Imports System.IO
Module Misc
    Public Sub err(ByVal ex As Exception)
        Try
            Dim res As MsgBoxResult = MsgBox("There was an error!" & vbNewLine &
                   "Error Text:" & vbNewLine &
                   "------------------------------" & vbNewLine & vbNewLine &
                    ex.ToString & vbNewLine & vbNewLine &
                    "-----------------------------" & vbNewLine &
                    "Please report this error to Materaspieaux." & vbNewLine &
                    "Would you like to save the error to your clipboard?",
                    MsgBoxStyle.YesNo,
                    "Whoops.")
            If res = MsgBoxResult.Yes Then
                My.Computer.Clipboard.SetText(ex.ToString)
            End If
        Catch newEx As Exception
            'What the fuck did you do?! You fucking borked the error reporter!
            MsgBox("I don't know what the goddamned shit you just did, but you managed to fuck my error reporter." & vbNewLine &
                   "I'm not even going to tell you the error, faggot.",
                   MsgBoxStyle.Critical,
                   "WHAT THE FUCK")

        End Try

    End Sub

    Public Sub getPlayers(ByVal logPath As String, ByRef playerDict As Dictionary(Of String, playerInfo))
        Try


            Dim line As String = ""
            Dim tempCkey As String = ""
            Dim tempIgn As String = ""
            Dim tempIP As String = ""
            Dim tempCID As String = ""
            Using reader As New StreamReader(logPath)
                '[18:33:29]ACCESS: Login: Materaspieaux/(Jebus) from 127.0.0.1-3899995441 || BYOND v504
                While reader.EndOfStream = False
                    line = reader.ReadLine()
                    If line.Contains("ACCESS: Login:") Then
                        getCkeyAndName(line, tempCkey, tempIgn)
                        getIpandCID(line, tempIP, tempCID)
                        If playerDict.ContainsKey(tempCkey) Then
                            playerDict(tempCkey).addName(tempIgn)
                            playerDict(tempCkey).addIP(tempIP)
                        Else
                            Dim newP As New playerInfo
                            newP.CKey = tempCkey
                            newP.computerID = tempCID
                            newP.addName(tempIgn)
                            newP.addIP(tempIP)
                            playerDict.Add(tempCkey, newP)
                        End If
                    End If

                End While
            End Using
        Catch ex As Exception
            'To catch them is my real test...
            err(ex)
        End Try
    End Sub
    Public Sub getCkeyAndName(ByVal line As String, ByRef ck As String, ByRef ign As String)
        Dim firstParse As String = line.Substring(25)
        Dim secondParse As String = firstParse.Replace(firstParse.Substring(firstParse.IndexOf(" from ")), "")
        Dim thirdParse As String = secondParse.Replace("(", "").Replace(")", "")
        Dim fourthParse() As String = thirdParse.Split("/")

        If fourthParse.Length = 2 Then
            ck = fourthParse(0)
            ign = fourthParse(1)
            
        End If


    End Sub
    Public Sub getIpandCID(ByVal line As String, ByRef IP As String, ByRef CID As String)
        Dim firstParse As String = line.Substring(line.IndexOf(" from ") + 6)
        Dim secondParse As String = firstParse.Replace(firstParse.Substring(firstParse.IndexOf(" || ")), "")
        Dim splitToeNail() As String = secondParse.Split("-")
        If splitToeNail.Length = 2 Then
            IP = splitToeNail(0)
            CID = splitToeNail(1)
        Else
            CID = splitToeNail(splitToeNail.Length - 1)
            For i As Integer = 0 To splitToeNail.Length - 2
                IP &= splitToeNail(i) & "-"
            Next
        End If
    End Sub

    Public Function makeFileNameSafe(ByVal s As String) As String
        Dim ret As String = s
        ret = ret.Replace(":", "_")
        ret = ret.Replace("<", "_")
        ret = ret.Replace(">", "_")
        ret = ret.Replace("?", "_")
        ret = ret.Replace("*", "_")
        ret = ret.Replace("""", "_")
        ret = ret.Replace("/", "_")
        ret = ret.Replace("\", "_")
        Return ret
    End Function
    Public Function getTimeStamp(ByVal line As String, ByRef ret As String) As Boolean
        Dim found As Boolean = False
        If line.Length >= 10 Then
            If line(0) = "[" Then
                If line(9) = "]" Then
                    If (line(3) = ":") And (line(6) = ":") Then
                        ret = line.Substring(0, 10)
                        found = True
                    End If
                End If
            End If
        End If
        Return found
    End Function

    'This function will return a:
    '   1:  timestamp1 is later than timestamp2
    '   2:  timestamp2 is later than timestamp1
    '   3:  timestamps are equal
    '   -1: timestamp1 is wrongly formatted
    '   -2: timestamp2 is wrongly formatted
    '   -3: both are wrong. why.
    Public Function compareTimeStamps(ByVal timestamp1 As String, ByVal timestamp2 As String) As Integer
        '[xx:xx:xx]
        '0123456789
        Dim retNum As Integer = -1
        If (timestamp1.Length = 10) And (timestamp2.Length = 10) Then
            Dim hour1 As String = timestamp1.Substring(1, 2)
            Dim minute1 As String = timestamp1.Substring(4, 2)
            Dim second1 As String = timestamp1.Substring(7, 2)

            Dim hour2 As String = timestamp2.Substring(1, 2)
            Dim minute2 As String = timestamp2.Substring(4, 2)
            Dim second2 As String = timestamp2.Substring(7, 2)

            Dim pHour1 As Integer = Integer.Parse(hour1)
            Dim pMinute1 As String = Integer.Parse(minute1)
            Dim pSecond1 As String = Integer.Parse(second1)

            Dim pHour2 As Integer = Integer.Parse(hour2)
            Dim pMinute2 As String = Integer.Parse(minute2)
            Dim pSecond2 As String = Integer.Parse(second2)

            Dim tot1 As Integer = 0
            Dim tot2 As Integer = 0

            tot1 += pHour1 * 3600 + pMinute1 * 60 + pSecond1
            tot2 += pHour2 * 3600 + pMinute2 * 60 + pSecond2
            If tot1 > tot2 Then
                retNum = 1
            ElseIf tot2 > tot1 Then
                retNum = 2
            Else
                retNum = 3
            End If

        ElseIf timestamp1.Length <> 10 And timestamp2.Length = 10 Then
            retNum = -1
        ElseIf timestamp2.Length <> 10 And timestamp1.Length = 10 Then
            retNum = -2
        Else
            retNum = -3
        End If
        Return retNum
    End Function
    Public Sub mergeAttackAndServer(ByVal serverLogPath As String, ByVal attackLogPath As String, ByVal combinedLogPath As String)

        Using serverReader As New StreamReader(serverLogPath)
            Using attackReader As New StreamReader(attackLogPath)
                Using combinedWriter As New StreamWriter(combinedLogPath)
                    Dim serverLine As String = ""
                    Dim attackLine As String = ""

                    Dim serverLineTimeStamp As String = ""
                    Dim attackLineTimeStamp As String = ""

                    Dim serverLineHasTimeStamp As Boolean = False
                    Dim attackLineHasTimeStamp As Boolean = False

                    While (getTimeStamp(serverLine, serverLineTimeStamp) = False) And serverReader.EndOfStream = False
                        combinedWriter.WriteLine(serverLine)
                        serverLine = serverReader.ReadLine
                    End While
                    While (getTimeStamp(attackLine, attackLineTimeStamp) = False) And attackReader.EndOfStream = False
                        combinedWriter.WriteLine(attackLine)
                        attackLine = attackReader.ReadLine
                    End While

                    While (serverReader.EndOfStream = False) And (attackReader.EndOfStream = False)
                        If compareTimeStamps(serverLineTimeStamp, attackLineTimeStamp) = 1 Then

                            While ((getTimeStamp(attackLine, attackLineTimeStamp) = True) And attackReader.EndOfStream = False) And (compareTimeStamps(serverLineTimeStamp, attackLineTimeStamp) = 1)
                                combinedWriter.WriteLine(attackLine)
                                attackLine = attackReader.ReadLine
                            End While

                            combinedWriter.WriteLine(serverLine)
                            serverLine = serverReader.ReadLine

                        ElseIf compareTimeStamps(serverLineTimeStamp, attackLineTimeStamp) = 2 Then


                            While ((getTimeStamp(serverLine, serverLineTimeStamp) = True) And serverReader.EndOfStream = False) And (compareTimeStamps(serverLineTimeStamp, attackLineTimeStamp) = 2)
                                combinedWriter.WriteLine(serverLine)
                                serverLine = serverReader.ReadLine
                            End While
                            combinedWriter.WriteLine(attackLine)
                            attackLine = attackReader.ReadLine

                        ElseIf compareTimeStamps(serverLineTimeStamp, attackLineTimeStamp) = 3 Then
                            combinedWriter.WriteLine(serverLine)
                            combinedWriter.WriteLine(attackLine)
                            serverLine = serverReader.ReadLine
                            attackLine = attackReader.ReadLine

                        ElseIf compareTimeStamps(serverLineTimeStamp, attackLineTimeStamp) = -1 Then
                            combinedWriter.WriteLine(serverLine)
                            serverLine = serverReader.ReadLine

                        ElseIf compareTimeStamps(serverLineTimeStamp, attackLineTimeStamp) = -2 Then
                            combinedWriter.WriteLine(attackLine)
                            attackLine = attackReader.ReadLine
                        ElseIf compareTimeStamps(serverLineTimeStamp, attackLineTimeStamp) = -3 Then
                            combinedWriter.WriteLine(serverLine)
                            combinedWriter.WriteLine(attackLine)
                            serverLine = serverReader.ReadLine
                            attackLine = attackReader.ReadLine
                        End If

                    End While
                    While attackReader.EndOfStream = False
                        combinedWriter.WriteLine(attackLine)
                        attackLine = attackReader.ReadLine
                    End While
                    While serverReader.EndOfStream = False
                        combinedWriter.WriteLine(serverLine)
                        serverLine = serverReader.ReadLine
                    End While
                End Using
            End Using
        End Using
    End Sub

End Module
