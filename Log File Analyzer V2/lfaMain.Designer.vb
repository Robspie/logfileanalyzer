<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lfaMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lfaMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.playerTab = New System.Windows.Forms.TabPage()
        Me.searchPlayersButton = New System.Windows.Forms.Button()
        Me.searchPlayers = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.playerListView = New System.Windows.Forms.ListView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.negCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.posCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.searchServerLogs = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.negTerms = New System.Windows.Forms.TextBox()
        Me.searchAttackLogs = New System.Windows.Forms.Button()
        Me.posTerms = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenLogFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanupLFADirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchBothButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.playerTab.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.playerTab)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(372, 252)
        Me.TabControl1.TabIndex = 0
        '
        'playerTab
        '
        Me.playerTab.Controls.Add(Me.searchPlayersButton)
        Me.playerTab.Controls.Add(Me.searchPlayers)
        Me.playerTab.Controls.Add(Me.Label4)
        Me.playerTab.Controls.Add(Me.Label1)
        Me.playerTab.Controls.Add(Me.playerListView)
        Me.playerTab.Location = New System.Drawing.Point(4, 22)
        Me.playerTab.Name = "playerTab"
        Me.playerTab.Padding = New System.Windows.Forms.Padding(3)
        Me.playerTab.Size = New System.Drawing.Size(364, 226)
        Me.playerTab.TabIndex = 1
        Me.playerTab.Text = "Players"
        Me.playerTab.UseVisualStyleBackColor = True
        '
        'searchPlayersButton
        '
        Me.searchPlayersButton.Location = New System.Drawing.Point(225, 201)
        Me.searchPlayersButton.Name = "searchPlayersButton"
        Me.searchPlayersButton.Size = New System.Drawing.Size(75, 23)
        Me.searchPlayersButton.TabIndex = 4
        Me.searchPlayersButton.Text = "Search"
        Me.searchPlayersButton.UseVisualStyleBackColor = True
        '
        'searchPlayers
        '
        Me.searchPlayers.Location = New System.Drawing.Point(76, 203)
        Me.searchPlayers.Name = "searchPlayers"
        Me.searchPlayers.Size = New System.Drawing.Size(143, 20)
        Me.searchPlayers.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Search For:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Player List(Double click to view information)"
        '
        'playerListView
        '
        Me.playerListView.Location = New System.Drawing.Point(11, 19)
        Me.playerListView.Name = "playerListView"
        Me.playerListView.Size = New System.Drawing.Size(345, 174)
        Me.playerListView.TabIndex = 0
        Me.playerListView.UseCompatibleStateImageBehavior = False
        Me.playerListView.View = System.Windows.Forms.View.List
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.searchBothButton)
        Me.TabPage3.Controls.Add(Me.negCaseSensitive)
        Me.TabPage3.Controls.Add(Me.posCaseSensitive)
        Me.TabPage3.Controls.Add(Me.searchServerLogs)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.negTerms)
        Me.TabPage3.Controls.Add(Me.searchAttackLogs)
        Me.TabPage3.Controls.Add(Me.posTerms)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(364, 226)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Search Logs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'negCaseSensitive
        '
        Me.negCaseSensitive.AutoSize = True
        Me.negCaseSensitive.Location = New System.Drawing.Point(132, 104)
        Me.negCaseSensitive.Name = "negCaseSensitive"
        Me.negCaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.negCaseSensitive.TabIndex = 7
        Me.negCaseSensitive.Text = "Case Sensitive"
        Me.negCaseSensitive.UseVisualStyleBackColor = True
        '
        'posCaseSensitive
        '
        Me.posCaseSensitive.AutoSize = True
        Me.posCaseSensitive.Location = New System.Drawing.Point(132, 9)
        Me.posCaseSensitive.Name = "posCaseSensitive"
        Me.posCaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.posCaseSensitive.TabIndex = 6
        Me.posCaseSensitive.Text = "Case Sensitive"
        Me.posCaseSensitive.UseVisualStyleBackColor = True
        '
        'searchServerLogs
        '
        Me.searchServerLogs.Enabled = False
        Me.searchServerLogs.Location = New System.Drawing.Point(250, 200)
        Me.searchServerLogs.Name = "searchServerLogs"
        Me.searchServerLogs.Size = New System.Drawing.Size(106, 23)
        Me.searchServerLogs.TabIndex = 4
        Me.searchServerLogs.Text = "Search Server Log"
        Me.searchServerLogs.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Negative Search Terms"
        '
        'negTerms
        '
        Me.negTerms.Location = New System.Drawing.Point(8, 121)
        Me.negTerms.Multiline = True
        Me.negTerms.Name = "negTerms"
        Me.negTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.negTerms.Size = New System.Drawing.Size(348, 76)
        Me.negTerms.TabIndex = 2
        '
        'searchAttackLogs
        '
        Me.searchAttackLogs.Enabled = False
        Me.searchAttackLogs.Location = New System.Drawing.Point(8, 200)
        Me.searchAttackLogs.Name = "searchAttackLogs"
        Me.searchAttackLogs.Size = New System.Drawing.Size(106, 23)
        Me.searchAttackLogs.TabIndex = 3
        Me.searchAttackLogs.Text = "Search Attack Log"
        Me.searchAttackLogs.UseVisualStyleBackColor = True
        '
        'posTerms
        '
        Me.posTerms.Location = New System.Drawing.Point(8, 26)
        Me.posTerms.Multiline = True
        Me.posTerms.Name = "posTerms"
        Me.posTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.posTerms.Size = New System.Drawing.Size(348, 76)
        Me.posTerms.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Positive Search Terms:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenLogFileToolStripMenuItem, Me.CleanupLFADirectoryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(372, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenLogFileToolStripMenuItem
        '
        Me.OpenLogFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OpenLogFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerToolStripMenuItem, Me.AttackToolStripMenuItem})
        Me.OpenLogFileToolStripMenuItem.Name = "OpenLogFileToolStripMenuItem"
        Me.OpenLogFileToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.OpenLogFileToolStripMenuItem.Text = "Open Log File"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'AttackToolStripMenuItem
        '
        Me.AttackToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral
        Me.AttackToolStripMenuItem.Name = "AttackToolStripMenuItem"
        Me.AttackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AttackToolStripMenuItem.Text = "Attack"
        '
        'CleanupLFADirectoryToolStripMenuItem
        '
        Me.CleanupLFADirectoryToolStripMenuItem.Name = "CleanupLFADirectoryToolStripMenuItem"
        Me.CleanupLFADirectoryToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.CleanupLFADirectoryToolStripMenuItem.Text = "Cleanup LFA Directory"
        '
        'searchBothButton
        '
        Me.searchBothButton.Enabled = False
        Me.searchBothButton.Location = New System.Drawing.Point(130, 200)
        Me.searchBothButton.Name = "searchBothButton"
        Me.searchBothButton.Size = New System.Drawing.Size(106, 23)
        Me.searchBothButton.TabIndex = 8
        Me.searchBothButton.Text = "Search Both Logs"
        Me.searchBothButton.UseVisualStyleBackColor = True
        '
        'lfaMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "lfaMain"
        Me.Text = "Log File Analyzer V2"
        Me.TabControl1.ResumeLayout(False)
        Me.playerTab.ResumeLayout(False)
        Me.playerTab.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents playerTab As System.Windows.Forms.TabPage
    Friend WithEvents playerListView As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents searchAttackLogs As System.Windows.Forms.Button
    Friend WithEvents posTerms As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents negTerms As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenLogFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents searchServerLogs As System.Windows.Forms.Button
    Friend WithEvents ServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents posCaseSensitive As System.Windows.Forms.CheckBox
    Friend WithEvents negCaseSensitive As System.Windows.Forms.CheckBox
    Friend WithEvents CleanupLFADirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents searchPlayersButton As System.Windows.Forms.Button
    Friend WithEvents searchPlayers As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents searchBothButton As System.Windows.Forms.Button

End Class
