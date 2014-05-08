Public Class playerInfo
    Public CKey As String
    Public ingameNames() As String
    Public IPs() As String
    Public computerID As String

    Public Sub addName(ByVal s As String)
        If (Not (ingameNames Is Nothing)) Then
            If Not (ingameNames.Contains(s)) Then
                ReDim Preserve ingameNames(ingameNames.Length)
                ingameNames(ingameNames.Length - 1) = s
            End If
        Else
            ReDim ingameNames(0)
            ingameNames(0) = s
        End If
    End Sub
    Public Sub addIP(ByVal s As String)
        If (Not (IPs Is Nothing)) Then
            If Not (IPs.Contains(s)) Then
                ReDim Preserve IPs(IPs.Length)
                IPs(IPs.Length - 1) = s
            End If
        Else
            ReDim IPs(0)
            IPs(0) = s
        End If
    End Sub

    Public Function searchInfo(ByVal s As String) As Boolean
        Dim ret As Boolean = False
        If CKey.ToLower.Contains(s.ToLower) Then
            ret = True
        End If
        If computerID.ToLower.Contains(s.ToLower) Then
            ret = True
        End If
        For Each ip As String In IPs
            If ip.ToLower.Contains(s.ToLower) Then
                ret = True
            End If
        Next
        For Each name As String In ingameNames
            If name.ToLower.Contains(s.ToLower) Then
                ret = True
            End If
        Next
        Return ret
    End Function
End Class
