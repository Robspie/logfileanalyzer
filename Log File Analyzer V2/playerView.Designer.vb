<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class playerView
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
        Me.playerIngameName = New System.Windows.Forms.Label()
        Me.searchAttackLog = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.posTerms = New System.Windows.Forms.TextBox()
        Me.negTerms = New System.Windows.Forms.TextBox()
        Me.posCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.negCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inGameNames = New System.Windows.Forms.TextBox()
        Me.IPs = New System.Windows.Forms.TextBox()
        Me.ckeyLBL = New System.Windows.Forms.Label()
        Me.cidLBL = New System.Windows.Forms.Label()
        Me.searchServerLog = New System.Windows.Forms.Button()
        Me.foundPlayersCIDs = New System.Windows.Forms.Label()
        Me.sameCIDsListView = New System.Windows.Forms.ListView()
        Me.foundPlayersIPs = New System.Windows.Forms.Label()
        Me.sameIPsListView = New System.Windows.Forms.ListView()
        Me.searchBothButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'playerIngameName
        '
        Me.playerIngameName.AutoSize = True
        Me.playerIngameName.Location = New System.Drawing.Point(12, 71)
        Me.playerIngameName.Name = "playerIngameName"
        Me.playerIngameName.Size = New System.Drawing.Size(83, 13)
        Me.playerIngameName.TabIndex = 0
        Me.playerIngameName.Text = "In-Game Names"
        '
        'searchAttackLog
        '
        Me.searchAttackLog.Enabled = False
        Me.searchAttackLog.Location = New System.Drawing.Point(15, 300)
        Me.searchAttackLog.Name = "searchAttackLog"
        Me.searchAttackLog.Size = New System.Drawing.Size(143, 23)
        Me.searchAttackLog.TabIndex = 4
        Me.searchAttackLog.Text = "Search Attack Log"
        Me.searchAttackLog.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Positive Search Terms"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Negative Search Terms"
        '
        'posTerms
        '
        Me.posTerms.Location = New System.Drawing.Point(17, 183)
        Me.posTerms.Multiline = True
        Me.posTerms.Name = "posTerms"
        Me.posTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.posTerms.Size = New System.Drawing.Size(139, 88)
        Me.posTerms.TabIndex = 7
        '
        'negTerms
        '
        Me.negTerms.Location = New System.Drawing.Point(162, 183)
        Me.negTerms.Multiline = True
        Me.negTerms.Name = "negTerms"
        Me.negTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.negTerms.Size = New System.Drawing.Size(143, 88)
        Me.negTerms.TabIndex = 8
        '
        'posCaseSensitive
        '
        Me.posCaseSensitive.AutoSize = True
        Me.posCaseSensitive.Location = New System.Drawing.Point(17, 277)
        Me.posCaseSensitive.Name = "posCaseSensitive"
        Me.posCaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.posCaseSensitive.TabIndex = 9
        Me.posCaseSensitive.Text = "Case Sensitive"
        Me.posCaseSensitive.UseVisualStyleBackColor = True
        '
        'negCaseSensitive
        '
        Me.negCaseSensitive.AutoSize = True
        Me.negCaseSensitive.Location = New System.Drawing.Point(203, 277)
        Me.negCaseSensitive.Name = "negCaseSensitive"
        Me.negCaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.negCaseSensitive.TabIndex = 10
        Me.negCaseSensitive.Text = "Case Sensitive"
        Me.negCaseSensitive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "IPs"
        '
        'inGameNames
        '
        Me.inGameNames.Location = New System.Drawing.Point(15, 87)
        Me.inGameNames.Multiline = True
        Me.inGameNames.Name = "inGameNames"
        Me.inGameNames.ReadOnly = True
        Me.inGameNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.inGameNames.Size = New System.Drawing.Size(141, 77)
        Me.inGameNames.TabIndex = 12
        '
        'IPs
        '
        Me.IPs.Location = New System.Drawing.Point(162, 87)
        Me.IPs.Multiline = True
        Me.IPs.Name = "IPs"
        Me.IPs.ReadOnly = True
        Me.IPs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.IPs.Size = New System.Drawing.Size(143, 77)
        Me.IPs.TabIndex = 13
        '
        'ckeyLBL
        '
        Me.ckeyLBL.AutoSize = True
        Me.ckeyLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeyLBL.Location = New System.Drawing.Point(12, 9)
        Me.ckeyLBL.Name = "ckeyLBL"
        Me.ckeyLBL.Size = New System.Drawing.Size(49, 16)
        Me.ckeyLBL.TabIndex = 14
        Me.ckeyLBL.Text = "Label2"
        '
        'cidLBL
        '
        Me.cidLBL.AutoSize = True
        Me.cidLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cidLBL.Location = New System.Drawing.Point(12, 25)
        Me.cidLBL.Name = "cidLBL"
        Me.cidLBL.Size = New System.Drawing.Size(49, 16)
        Me.cidLBL.TabIndex = 15
        Me.cidLBL.Text = "Label2"
        '
        'searchServerLog
        '
        Me.searchServerLog.Enabled = False
        Me.searchServerLog.Location = New System.Drawing.Point(313, 300)
        Me.searchServerLog.Name = "searchServerLog"
        Me.searchServerLog.Size = New System.Drawing.Size(143, 23)
        Me.searchServerLog.TabIndex = 17
        Me.searchServerLog.Text = "Search Server Log"
        Me.searchServerLog.UseVisualStyleBackColor = True
        '
        'foundPlayersCIDs
        '
        Me.foundPlayersCIDs.AutoSize = True
        Me.foundPlayersCIDs.Location = New System.Drawing.Point(311, 71)
        Me.foundPlayersCIDs.Name = "foundPlayersCIDs"
        Me.foundPlayersCIDs.Size = New System.Drawing.Size(169, 13)
        Me.foundPlayersCIDs.TabIndex = 18
        Me.foundPlayersCIDs.Text = "Players Found(Same Computer ID)"
        '
        'sameCIDsListView
        '
        Me.sameCIDsListView.Location = New System.Drawing.Point(311, 87)
        Me.sameCIDsListView.Name = "sameCIDsListView"
        Me.sameCIDsListView.Size = New System.Drawing.Size(228, 77)
        Me.sameCIDsListView.TabIndex = 19
        Me.sameCIDsListView.UseCompatibleStateImageBehavior = False
        Me.sameCIDsListView.View = System.Windows.Forms.View.List
        '
        'foundPlayersIPs
        '
        Me.foundPlayersIPs.AutoSize = True
        Me.foundPlayersIPs.Location = New System.Drawing.Point(311, 167)
        Me.foundPlayersIPs.Name = "foundPlayersIPs"
        Me.foundPlayersIPs.Size = New System.Drawing.Size(120, 13)
        Me.foundPlayersIPs.TabIndex = 20
        Me.foundPlayersIPs.Text = "Players Found(Same IP)"
        '
        'sameIPsListView
        '
        Me.sameIPsListView.Location = New System.Drawing.Point(311, 183)
        Me.sameIPsListView.Name = "sameIPsListView"
        Me.sameIPsListView.Size = New System.Drawing.Size(228, 88)
        Me.sameIPsListView.TabIndex = 21
        Me.sameIPsListView.UseCompatibleStateImageBehavior = False
        Me.sameIPsListView.View = System.Windows.Forms.View.List
        '
        'searchBothButton
        '
        Me.searchBothButton.Enabled = False
        Me.searchBothButton.Location = New System.Drawing.Point(164, 300)
        Me.searchBothButton.Name = "searchBothButton"
        Me.searchBothButton.Size = New System.Drawing.Size(143, 23)
        Me.searchBothButton.TabIndex = 22
        Me.searchBothButton.Text = "Search Both Logs"
        Me.searchBothButton.UseVisualStyleBackColor = True
        '
        'playerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 330)
        Me.Controls.Add(Me.searchBothButton)
        Me.Controls.Add(Me.sameIPsListView)
        Me.Controls.Add(Me.foundPlayersIPs)
        Me.Controls.Add(Me.sameCIDsListView)
        Me.Controls.Add(Me.foundPlayersCIDs)
        Me.Controls.Add(Me.searchServerLog)
        Me.Controls.Add(Me.cidLBL)
        Me.Controls.Add(Me.ckeyLBL)
        Me.Controls.Add(Me.IPs)
        Me.Controls.Add(Me.inGameNames)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.negCaseSensitive)
        Me.Controls.Add(Me.posCaseSensitive)
        Me.Controls.Add(Me.negTerms)
        Me.Controls.Add(Me.posTerms)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.searchAttackLog)
        Me.Controls.Add(Me.playerIngameName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "playerView"
        Me.ShowIcon = False
        Me.Text = "playername"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents playerIngameName As System.Windows.Forms.Label
    Friend WithEvents searchAttackLog As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents posTerms As System.Windows.Forms.TextBox
    Friend WithEvents negTerms As System.Windows.Forms.TextBox
    Friend WithEvents posCaseSensitive As System.Windows.Forms.CheckBox
    Friend WithEvents negCaseSensitive As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inGameNames As System.Windows.Forms.TextBox
    Friend WithEvents IPs As System.Windows.Forms.TextBox
    Friend WithEvents ckeyLBL As System.Windows.Forms.Label
    Friend WithEvents cidLBL As System.Windows.Forms.Label
    Friend WithEvents searchServerLog As System.Windows.Forms.Button
    Friend WithEvents foundPlayersCIDs As System.Windows.Forms.Label
    Friend WithEvents sameCIDsListView As System.Windows.Forms.ListView
    Friend WithEvents foundPlayersIPs As System.Windows.Forms.Label
    Friend WithEvents sameIPsListView As System.Windows.Forms.ListView
    Friend WithEvents searchBothButton As System.Windows.Forms.Button
End Class
