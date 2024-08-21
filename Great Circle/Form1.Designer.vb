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
        ReadFlightButton = New Button()
        ReadFlightBox = New TextBox()
        WriteFlightButton = New Button()
        WriteFlightBox = New TextBox()
        CalcDistBox = New TextBox()
        GCDistanceButton = New Button()
        Label1 = New Label()
        NumSegmentsBox = New TextBox()
        Label2 = New Label()
        NumPointsBox = New TextBox()
        InterBox = New TextBox()
        GCInterpolateButton = New Button()
        Label3 = New Label()
        ResultsLat1 = New TextBox()
        TestButton = New Button()
        ResultsLon1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' ReadFlightButton
        ' 
        ReadFlightButton.Location = New Point(23, 21)
        ReadFlightButton.Name = "ReadFlightButton"
        ReadFlightButton.Size = New Size(144, 32)
        ReadFlightButton.TabIndex = 0
        ReadFlightButton.Text = "Read Flight Schedule"
        ReadFlightButton.UseVisualStyleBackColor = True
        ' 
        ' ReadFlightBox
        ' 
        ReadFlightBox.Location = New Point(173, 27)
        ReadFlightBox.Name = "ReadFlightBox"
        ReadFlightBox.Size = New Size(110, 23)
        ReadFlightBox.TabIndex = 1
        ' 
        ' WriteFlightButton
        ' 
        WriteFlightButton.Location = New Point(23, 59)
        WriteFlightButton.Name = "WriteFlightButton"
        WriteFlightButton.Size = New Size(144, 32)
        WriteFlightButton.TabIndex = 2
        WriteFlightButton.Text = "Write Flight Schedule"
        WriteFlightButton.UseVisualStyleBackColor = True
        ' 
        ' WriteFlightBox
        ' 
        WriteFlightBox.Location = New Point(173, 65)
        WriteFlightBox.Name = "WriteFlightBox"
        WriteFlightBox.Size = New Size(110, 23)
        WriteFlightBox.TabIndex = 3
        ' 
        ' CalcDistBox
        ' 
        CalcDistBox.Location = New Point(173, 120)
        CalcDistBox.Name = "CalcDistBox"
        CalcDistBox.Size = New Size(110, 23)
        CalcDistBox.TabIndex = 5
        ' 
        ' GCDistanceButton
        ' 
        GCDistanceButton.Location = New Point(23, 114)
        GCDistanceButton.Name = "GCDistanceButton"
        GCDistanceButton.Size = New Size(144, 32)
        GCDistanceButton.TabIndex = 4
        GCDistanceButton.Text = "GC Distance"
        GCDistanceButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 15)
        Label1.TabIndex = 6
        Label1.Text = "Number of Segments ="
        ' 
        ' NumSegmentsBox
        ' 
        NumSegmentsBox.Location = New Point(151, 174)
        NumSegmentsBox.Name = "NumSegmentsBox"
        NumSegmentsBox.Size = New Size(41, 23)
        NumSegmentsBox.TabIndex = 7
        NumSegmentsBox.Text = "200"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(219, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 15)
        Label2.TabIndex = 8
        Label2.Text = "Number of In-Between Points ="
        ' 
        ' NumPointsBox
        ' 
        NumPointsBox.BackColor = SystemColors.ControlLight
        NumPointsBox.Enabled = False
        NumPointsBox.Location = New Point(390, 174)
        NumPointsBox.Name = "NumPointsBox"
        NumPointsBox.Size = New Size(41, 23)
        NumPointsBox.TabIndex = 9
        NumPointsBox.Text = "199"
        ' 
        ' InterBox
        ' 
        InterBox.Location = New Point(173, 209)
        InterBox.Name = "InterBox"
        InterBox.Size = New Size(110, 23)
        InterBox.TabIndex = 11
        ' 
        ' GCInterpolateButton
        ' 
        GCInterpolateButton.Location = New Point(23, 203)
        GCInterpolateButton.Name = "GCInterpolateButton"
        GCInterpolateButton.Size = New Size(144, 32)
        GCInterpolateButton.TabIndex = 10
        GCInterpolateButton.Text = "GC Interpolate"
        GCInterpolateButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(230, 15)
        Label3.TabIndex = 12
        Label3.Text = "Lat-Lon Point Based on f Value in the code"
        ' 
        ' ResultsLat1
        ' 
        ResultsLat1.Location = New Point(173, 323)
        ResultsLat1.Name = "ResultsLat1"
        ResultsLat1.Size = New Size(110, 23)
        ResultsLat1.TabIndex = 14
        ' 
        ' TestButton
        ' 
        TestButton.Location = New Point(23, 317)
        TestButton.Name = "TestButton"
        TestButton.Size = New Size(144, 32)
        TestButton.TabIndex = 13
        TestButton.Text = "Test Button"
        TestButton.UseVisualStyleBackColor = True
        ' 
        ' ResultsLon1
        ' 
        ResultsLon1.Location = New Point(289, 323)
        ResultsLon1.Name = "ResultsLon1"
        ResultsLon1.Size = New Size(110, 23)
        ResultsLon1.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(182, 305)
        Label4.Name = "Label4"
        Label4.Size = New Size(23, 15)
        Label4.TabIndex = 16
        Label4.Text = "Lat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(298, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 15)
        Label5.TabIndex = 17
        Label5.Text = "Lon"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(505, 392)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ResultsLon1)
        Controls.Add(ResultsLat1)
        Controls.Add(TestButton)
        Controls.Add(Label3)
        Controls.Add(InterBox)
        Controls.Add(GCInterpolateButton)
        Controls.Add(NumPointsBox)
        Controls.Add(Label2)
        Controls.Add(NumSegmentsBox)
        Controls.Add(Label1)
        Controls.Add(CalcDistBox)
        Controls.Add(GCDistanceButton)
        Controls.Add(WriteFlightBox)
        Controls.Add(WriteFlightButton)
        Controls.Add(ReadFlightBox)
        Controls.Add(ReadFlightButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ReadFlightButton As Button
    Friend WithEvents ReadFlightBox As TextBox
    Friend WithEvents WriteFlightButton As Button
    Friend WithEvents WriteFlightBox As TextBox
    Friend WithEvents CalcDistBox As TextBox
    Friend WithEvents GCDistanceButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NumSegmentsBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NumPointsBox As TextBox
    Friend WithEvents InterBox As TextBox
    Friend WithEvents GCInterpolateButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ResultsLat1 As TextBox
    Friend WithEvents TestButton As Button
    Friend WithEvents ResultsLon1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
