<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListButton = New System.Windows.Forms.ComboBox()
        Me.CmdStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumInterval = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mouse Button:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interval:"
        '
        'ListButton
        '
        Me.ListButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListButton.FormattingEnabled = True
        Me.ListButton.Items.AddRange(New Object() {"Mouse Right", "Mouse Left", "Mouse Middle"})
        Me.ListButton.Location = New System.Drawing.Point(94, 15)
        Me.ListButton.Name = "ListButton"
        Me.ListButton.Size = New System.Drawing.Size(192, 21)
        Me.ListButton.TabIndex = 2
        '
        'CmdStart
        '
        Me.CmdStart.Location = New System.Drawing.Point(94, 69)
        Me.CmdStart.Name = "CmdStart"
        Me.CmdStart.Size = New System.Drawing.Size(75, 23)
        Me.CmdStart.TabIndex = 4
        Me.CmdStart.Text = "Start"
        Me.CmdStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(292, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ms"
        '
        'NumInterval
        '
        Me.NumInterval.Location = New System.Drawing.Point(94, 42)
        Me.NumInterval.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NumInterval.Name = "NumInterval"
        Me.NumInterval.Size = New System.Drawing.Size(192, 20)
        Me.NumInterval.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 109)
        Me.Controls.Add(Me.NumInterval)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdStart)
        Me.Controls.Add(Me.ListButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.NumInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListButton As ComboBox
    Friend WithEvents CmdStart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NumInterval As NumericUpDown
End Class
