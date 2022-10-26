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
        Me.AbsoluteButton = New System.Windows.Forms.Button()
        Me.Chart = New System.Windows.Forms.PictureBox()
        Me.SequenceNumber = New System.Windows.Forms.NumericUpDown()
        Me.TrialsNumber = New System.Windows.Forms.NumericUpDown()
        Me.SequenceLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProbabilityLabel = New System.Windows.Forms.Label()
        Me.ProbabilityNumber = New System.Windows.Forms.NumericUpDown()
        Me.RelativeButton = New System.Windows.Forms.Button()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SequenceNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrialsNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProbabilityNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AbsoluteButton
        '
        Me.AbsoluteButton.Location = New System.Drawing.Point(1097, 10)
        Me.AbsoluteButton.Name = "AbsoluteButton"
        Me.AbsoluteButton.Size = New System.Drawing.Size(132, 27)
        Me.AbsoluteButton.TabIndex = 0
        Me.AbsoluteButton.Text = "Absolute Frequency"
        Me.AbsoluteButton.UseVisualStyleBackColor = True
        '
        'Chart
        '
        Me.Chart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Chart.Location = New System.Drawing.Point(29, 79)
        Me.Chart.MaximumSize = New System.Drawing.Size(1200, 600)
        Me.Chart.Name = "Chart"
        Me.Chart.Size = New System.Drawing.Size(1200, 600)
        Me.Chart.TabIndex = 1
        Me.Chart.TabStop = False
        '
        'SequenceNumber
        '
        Me.SequenceNumber.Location = New System.Drawing.Point(194, 12)
        Me.SequenceNumber.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.SequenceNumber.Name = "SequenceNumber"
        Me.SequenceNumber.Size = New System.Drawing.Size(120, 23)
        Me.SequenceNumber.TabIndex = 2
        '
        'TrialsNumber
        '
        Me.TrialsNumber.Location = New System.Drawing.Point(518, 12)
        Me.TrialsNumber.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.TrialsNumber.Name = "TrialsNumber"
        Me.TrialsNumber.Size = New System.Drawing.Size(120, 23)
        Me.TrialsNumber.TabIndex = 3
        '
        'SequenceLabel
        '
        Me.SequenceLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SequenceLabel.Location = New System.Drawing.Point(12, 11)
        Me.SequenceLabel.Name = "SequenceLabel"
        Me.SequenceLabel.Size = New System.Drawing.Size(176, 23)
        Me.SequenceLabel.TabIndex = 4
        Me.SequenceLabel.Text = "Number of sequences:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(369, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of trials:"
        '
        'ProbabilityLabel
        '
        Me.ProbabilityLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProbabilityLabel.Location = New System.Drawing.Point(819, 14)
        Me.ProbabilityLabel.Name = "ProbabilityLabel"
        Me.ProbabilityLabel.Size = New System.Drawing.Size(98, 23)
        Me.ProbabilityLabel.TabIndex = 7
        Me.ProbabilityLabel.Text = "Probability:"
        '
        'ProbabilityNumber
        '
        Me.ProbabilityNumber.DecimalPlaces = 2
        Me.ProbabilityNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProbabilityNumber.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ProbabilityNumber.Location = New System.Drawing.Point(923, 14)
        Me.ProbabilityNumber.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ProbabilityNumber.Name = "ProbabilityNumber"
        Me.ProbabilityNumber.Size = New System.Drawing.Size(90, 23)
        Me.ProbabilityNumber.TabIndex = 8
        '
        'RelativeButton
        '
        Me.RelativeButton.Location = New System.Drawing.Point(1097, 43)
        Me.RelativeButton.Name = "RelativeButton"
        Me.RelativeButton.Size = New System.Drawing.Size(132, 23)
        Me.RelativeButton.TabIndex = 9
        Me.RelativeButton.Text = "Relative Frequency"
        Me.RelativeButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.RelativeButton)
        Me.Controls.Add(Me.ProbabilityNumber)
        Me.Controls.Add(Me.ProbabilityLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SequenceLabel)
        Me.Controls.Add(Me.TrialsNumber)
        Me.Controls.Add(Me.SequenceNumber)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.AbsoluteButton)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SequenceNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrialsNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProbabilityNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AbsoluteButton As Button
    Friend WithEvents Chart As PictureBox
    Friend WithEvents SequenceNumber As NumericUpDown
    Friend WithEvents TrialsNumber As NumericUpDown
    Friend WithEvents SequenceLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProbabilityLabel As Label
    Friend WithEvents ProbabilityNumber As NumericUpDown
    Friend WithEvents RelativeButton As Button
End Class
