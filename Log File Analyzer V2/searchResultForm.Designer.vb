<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchResultForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchResultForm))
        Me.resultTextBox = New System.Windows.Forms.RichTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.newPosTerms = New System.Windows.Forms.TextBox()
        Me.newNegTerms = New System.Windows.Forms.TextBox()
        Me.narrowResults = New System.Windows.Forms.Button()
        Me.newNegCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.newPosCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'resultTextBox
        '
        Me.resultTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultTextBox.Location = New System.Drawing.Point(0, 0)
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.ReadOnly = True
        Me.resultTextBox.Size = New System.Drawing.Size(482, 246)
        Me.resultTextBox.TabIndex = 0
        Me.resultTextBox.Text = ""
        Me.resultTextBox.WordWrap = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.resultTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.newPosCaseSensitive)
        Me.SplitContainer1.Panel2.Controls.Add(Me.newNegCaseSensitive)
        Me.SplitContainer1.Panel2.Controls.Add(Me.narrowResults)
        Me.SplitContainer1.Panel2.Controls.Add(Me.newNegTerms)
        Me.SplitContainer1.Panel2.Controls.Add(Me.newPosTerms)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Margin = New System.Windows.Forms.Padding(3)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 366)
        Me.SplitContainer1.SplitterDistance = 248
        Me.SplitContainer1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Positive Search Terms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Negative Search Terms"
        '
        'newPosTerms
        '
        Me.newPosTerms.Location = New System.Drawing.Point(15, 26)
        Me.newPosTerms.Multiline = True
        Me.newPosTerms.Name = "newPosTerms"
        Me.newPosTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.newPosTerms.Size = New System.Drawing.Size(212, 53)
        Me.newPosTerms.TabIndex = 2
        '
        'newNegTerms
        '
        Me.newNegTerms.Location = New System.Drawing.Point(233, 25)
        Me.newNegTerms.Multiline = True
        Me.newNegTerms.Name = "newNegTerms"
        Me.newNegTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.newNegTerms.Size = New System.Drawing.Size(221, 54)
        Me.newNegTerms.TabIndex = 3
        '
        'narrowResults
        '
        Me.narrowResults.Location = New System.Drawing.Point(305, 85)
        Me.narrowResults.Name = "narrowResults"
        Me.narrowResults.Size = New System.Drawing.Size(149, 24)
        Me.narrowResults.TabIndex = 4
        Me.narrowResults.Text = "Narrow Search Results"
        Me.narrowResults.UseVisualStyleBackColor = True
        '
        'newNegCaseSensitive
        '
        Me.newNegCaseSensitive.AutoSize = True
        Me.newNegCaseSensitive.Location = New System.Drawing.Point(358, 3)
        Me.newNegCaseSensitive.Name = "newNegCaseSensitive"
        Me.newNegCaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.newNegCaseSensitive.TabIndex = 5
        Me.newNegCaseSensitive.Text = "Case Sensitive"
        Me.newNegCaseSensitive.UseVisualStyleBackColor = True
        '
        'newPosCaseSensitive
        '
        Me.newPosCaseSensitive.AutoSize = True
        Me.newPosCaseSensitive.Location = New System.Drawing.Point(131, 3)
        Me.newPosCaseSensitive.Name = "newPosCaseSensitive"
        Me.newPosCaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.newPosCaseSensitive.TabIndex = 6
        Me.newPosCaseSensitive.Text = "Case Sensitive"
        Me.newPosCaseSensitive.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'searchResultForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 366)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 0)
        Me.Name = "searchResultForm"
        Me.Text = "searchResultForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents resultTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents newPosTerms As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newNegTerms As System.Windows.Forms.TextBox
    Friend WithEvents newPosCaseSensitive As System.Windows.Forms.CheckBox
    Friend WithEvents newNegCaseSensitive As System.Windows.Forms.CheckBox
    Friend WithEvents narrowResults As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
