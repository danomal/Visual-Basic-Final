<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGolfers
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
        Me.btnAddGolfer = New System.Windows.Forms.Button()
        Me.lstGolfers = New System.Windows.Forms.ListBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.hdrGolferID = New System.Windows.Forms.Label()
        Me.hdrFirstName = New System.Windows.Forms.Label()
        Me.hdrLastName = New System.Windows.Forms.Label()
        Me.hdrFavoriteMajor = New System.Windows.Forms.Label()
        Me.hdrFavoriteMinor = New System.Windows.Forms.Label()
        Me.hdrHandicap = New System.Windows.Forms.Label()
        Me.hdrAverageScore = New System.Windows.Forms.Label()
        Me.hdrRegistered = New System.Windows.Forms.Label()
        Me.hdrDate = New System.Windows.Forms.Label()
        Me.hdrTime = New System.Windows.Forms.Label()
        Me.hdrFavoritePro = New System.Windows.Forms.Label()
        Me.lblGolferID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFavoriteMajor = New System.Windows.Forms.Label()
        Me.lblFavoriteMinor = New System.Windows.Forms.Label()
        Me.lblHandicap = New System.Windows.Forms.Label()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.lblRegistered = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblFavoritePro = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.hdrTimesPlayed = New System.Windows.Forms.Label()
        Me.lblTimesPlayed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddGolfer
        '
        Me.btnAddGolfer.Location = New System.Drawing.Point(74, 415)
        Me.btnAddGolfer.Name = "btnAddGolfer"
        Me.btnAddGolfer.Size = New System.Drawing.Size(75, 33)
        Me.btnAddGolfer.TabIndex = 0
        Me.btnAddGolfer.Text = "&Add Golfer"
        Me.btnAddGolfer.UseVisualStyleBackColor = True
        '
        'lstGolfers
        '
        Me.lstGolfers.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGolfers.FormattingEnabled = True
        Me.lstGolfers.Location = New System.Drawing.Point(12, 12)
        Me.lstGolfers.Name = "lstGolfers"
        Me.lstGolfers.Size = New System.Drawing.Size(214, 394)
        Me.lstGolfers.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(363, 415)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&Edit Golfer"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(713, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'hdrGolferID
        '
        Me.hdrGolferID.AutoSize = True
        Me.hdrGolferID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrGolferID.Location = New System.Drawing.Point(256, 22)
        Me.hdrGolferID.Name = "hdrGolferID"
        Me.hdrGolferID.Size = New System.Drawing.Size(69, 16)
        Me.hdrGolferID.TabIndex = 4
        Me.hdrGolferID.Text = "Golfer ID"
        '
        'hdrFirstName
        '
        Me.hdrFirstName.AutoSize = True
        Me.hdrFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrFirstName.Location = New System.Drawing.Point(256, 55)
        Me.hdrFirstName.Name = "hdrFirstName"
        Me.hdrFirstName.Size = New System.Drawing.Size(83, 16)
        Me.hdrFirstName.TabIndex = 5
        Me.hdrFirstName.Text = "First Name"
        '
        'hdrLastName
        '
        Me.hdrLastName.AutoSize = True
        Me.hdrLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrLastName.Location = New System.Drawing.Point(256, 88)
        Me.hdrLastName.Name = "hdrLastName"
        Me.hdrLastName.Size = New System.Drawing.Size(82, 16)
        Me.hdrLastName.TabIndex = 6
        Me.hdrLastName.Text = "Last Name"
        '
        'hdrFavoriteMajor
        '
        Me.hdrFavoriteMajor.AutoSize = True
        Me.hdrFavoriteMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrFavoriteMajor.Location = New System.Drawing.Point(256, 121)
        Me.hdrFavoriteMajor.Name = "hdrFavoriteMajor"
        Me.hdrFavoriteMajor.Size = New System.Drawing.Size(108, 16)
        Me.hdrFavoriteMajor.TabIndex = 7
        Me.hdrFavoriteMajor.Text = "Favorite Major"
        '
        'hdrFavoriteMinor
        '
        Me.hdrFavoriteMinor.AutoSize = True
        Me.hdrFavoriteMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrFavoriteMinor.Location = New System.Drawing.Point(256, 154)
        Me.hdrFavoriteMinor.Name = "hdrFavoriteMinor"
        Me.hdrFavoriteMinor.Size = New System.Drawing.Size(107, 16)
        Me.hdrFavoriteMinor.TabIndex = 8
        Me.hdrFavoriteMinor.Text = "Favorite Minor"
        '
        'hdrHandicap
        '
        Me.hdrHandicap.AutoSize = True
        Me.hdrHandicap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrHandicap.Location = New System.Drawing.Point(256, 187)
        Me.hdrHandicap.Name = "hdrHandicap"
        Me.hdrHandicap.Size = New System.Drawing.Size(75, 16)
        Me.hdrHandicap.TabIndex = 9
        Me.hdrHandicap.Text = "Handicap"
        '
        'hdrAverageScore
        '
        Me.hdrAverageScore.AutoSize = True
        Me.hdrAverageScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrAverageScore.Location = New System.Drawing.Point(256, 220)
        Me.hdrAverageScore.Name = "hdrAverageScore"
        Me.hdrAverageScore.Size = New System.Drawing.Size(112, 16)
        Me.hdrAverageScore.TabIndex = 10
        Me.hdrAverageScore.Text = "Average Score"
        '
        'hdrRegistered
        '
        Me.hdrRegistered.AutoSize = True
        Me.hdrRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrRegistered.Location = New System.Drawing.Point(256, 253)
        Me.hdrRegistered.Name = "hdrRegistered"
        Me.hdrRegistered.Size = New System.Drawing.Size(161, 16)
        Me.hdrRegistered.TabIndex = 11
        Me.hdrRegistered.Text = "Registered with USGA"
        '
        'hdrDate
        '
        Me.hdrDate.AutoSize = True
        Me.hdrDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrDate.Location = New System.Drawing.Point(256, 286)
        Me.hdrDate.Name = "hdrDate"
        Me.hdrDate.Size = New System.Drawing.Size(90, 16)
        Me.hdrDate.TabIndex = 12
        Me.hdrDate.Text = "Last Played"
        '
        'hdrTime
        '
        Me.hdrTime.AutoSize = True
        Me.hdrTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrTime.Location = New System.Drawing.Point(256, 352)
        Me.hdrTime.Name = "hdrTime"
        Me.hdrTime.Size = New System.Drawing.Size(162, 16)
        Me.hdrTime.TabIndex = 13
        Me.hdrTime.Text = "Favorite Time To Play"
        '
        'hdrFavoritePro
        '
        Me.hdrFavoritePro.AutoSize = True
        Me.hdrFavoritePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrFavoritePro.Location = New System.Drawing.Point(256, 385)
        Me.hdrFavoritePro.Name = "hdrFavoritePro"
        Me.hdrFavoritePro.Size = New System.Drawing.Size(156, 16)
        Me.hdrFavoritePro.TabIndex = 14
        Me.hdrFavoritePro.Text = "Favorite Professional"
        '
        'lblGolferID
        '
        Me.lblGolferID.AutoSize = True
        Me.lblGolferID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGolferID.Location = New System.Drawing.Point(477, 22)
        Me.lblGolferID.Name = "lblGolferID"
        Me.lblGolferID.Size = New System.Drawing.Size(48, 16)
        Me.lblGolferID.TabIndex = 15
        Me.lblGolferID.Text = "#####"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(477, 55)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(38, 16)
        Me.lblFirstName.TabIndex = 16
        Me.lblFirstName.Text = "First"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(477, 88)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(37, 16)
        Me.lblLastName.TabIndex = 17
        Me.lblLastName.Text = "Last"
        '
        'lblFavoriteMajor
        '
        Me.lblFavoriteMajor.AutoSize = True
        Me.lblFavoriteMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavoriteMajor.Location = New System.Drawing.Point(477, 121)
        Me.lblFavoriteMajor.Name = "lblFavoriteMajor"
        Me.lblFavoriteMajor.Size = New System.Drawing.Size(47, 16)
        Me.lblFavoriteMajor.TabIndex = 18
        Me.lblFavoriteMajor.Text = "Major"
        '
        'lblFavoriteMinor
        '
        Me.lblFavoriteMinor.AutoSize = True
        Me.lblFavoriteMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavoriteMinor.Location = New System.Drawing.Point(477, 154)
        Me.lblFavoriteMinor.Name = "lblFavoriteMinor"
        Me.lblFavoriteMinor.Size = New System.Drawing.Size(46, 16)
        Me.lblFavoriteMinor.TabIndex = 19
        Me.lblFavoriteMinor.Text = "Minor"
        '
        'lblHandicap
        '
        Me.lblHandicap.AutoSize = True
        Me.lblHandicap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHandicap.Location = New System.Drawing.Point(477, 187)
        Me.lblHandicap.Name = "lblHandicap"
        Me.lblHandicap.Size = New System.Drawing.Size(24, 16)
        Me.lblHandicap.TabIndex = 20
        Me.lblHandicap.Text = "+2"
        '
        'lblAverageScore
        '
        Me.lblAverageScore.AutoSize = True
        Me.lblAverageScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageScore.Location = New System.Drawing.Point(477, 220)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(24, 16)
        Me.lblAverageScore.TabIndex = 21
        Me.lblAverageScore.Text = "85"
        '
        'lblRegistered
        '
        Me.lblRegistered.AutoSize = True
        Me.lblRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistered.Location = New System.Drawing.Point(477, 253)
        Me.lblRegistered.Name = "lblRegistered"
        Me.lblRegistered.Size = New System.Drawing.Size(60, 16)
        Me.lblRegistered.TabIndex = 22
        Me.lblRegistered.Text = "Yes/No"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(477, 286)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(74, 16)
        Me.lblDate.TabIndex = 23
        Me.lblDate.Text = "01/1/2020"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(477, 352)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(63, 16)
        Me.lblTime.TabIndex = 24
        Me.lblTime.Text = "Morning"
        '
        'lblFavoritePro
        '
        Me.lblFavoritePro.AutoSize = True
        Me.lblFavoritePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavoritePro.Location = New System.Drawing.Point(477, 385)
        Me.lblFavoritePro.Name = "lblFavoritePro"
        Me.lblFavoritePro.Size = New System.Drawing.Size(98, 16)
        Me.lblFavoritePro.TabIndex = 25
        Me.lblFavoritePro.Text = "Tiger Woods"
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(632, 415)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(75, 33)
        Me.btnInfo.TabIndex = 26
        Me.btnInfo.Text = "&Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'hdrTimesPlayed
        '
        Me.hdrTimesPlayed.AutoSize = True
        Me.hdrTimesPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrTimesPlayed.Location = New System.Drawing.Point(256, 319)
        Me.hdrTimesPlayed.Name = "hdrTimesPlayed"
        Me.hdrTimesPlayed.Size = New System.Drawing.Size(176, 16)
        Me.hdrTimesPlayed.TabIndex = 27
        Me.hdrTimesPlayed.Text = "Times Played per Month"
        '
        'lblTimesPlayed
        '
        Me.lblTimesPlayed.AutoSize = True
        Me.lblTimesPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimesPlayed.Location = New System.Drawing.Point(477, 319)
        Me.lblTimesPlayed.Name = "lblTimesPlayed"
        Me.lblTimesPlayed.Size = New System.Drawing.Size(16, 16)
        Me.lblTimesPlayed.TabIndex = 28
        Me.lblTimesPlayed.Text = "9"
        '
        'frmGolfers
        '
        Me.AcceptButton = Me.btnAddGolfer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTimesPlayed)
        Me.Controls.Add(Me.hdrTimesPlayed)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.lblFavoritePro)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblRegistered)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.lblHandicap)
        Me.Controls.Add(Me.lblFavoriteMinor)
        Me.Controls.Add(Me.lblFavoriteMajor)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblGolferID)
        Me.Controls.Add(Me.hdrFavoritePro)
        Me.Controls.Add(Me.hdrTime)
        Me.Controls.Add(Me.hdrDate)
        Me.Controls.Add(Me.hdrRegistered)
        Me.Controls.Add(Me.hdrAverageScore)
        Me.Controls.Add(Me.hdrHandicap)
        Me.Controls.Add(Me.hdrFavoriteMinor)
        Me.Controls.Add(Me.hdrFavoriteMajor)
        Me.Controls.Add(Me.hdrLastName)
        Me.Controls.Add(Me.hdrFirstName)
        Me.Controls.Add(Me.hdrGolferID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstGolfers)
        Me.Controls.Add(Me.btnAddGolfer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGolfers"
        Me.Text = "Golfer's Log (Daniel O'Malley #77)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddGolfer As Button
    Friend WithEvents lstGolfers As ListBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents hdrGolferID As Label
    Friend WithEvents hdrFirstName As Label
    Friend WithEvents hdrLastName As Label
    Friend WithEvents hdrFavoriteMajor As Label
    Friend WithEvents hdrFavoriteMinor As Label
    Friend WithEvents hdrHandicap As Label
    Friend WithEvents hdrAverageScore As Label
    Friend WithEvents hdrRegistered As Label
    Friend WithEvents hdrDate As Label
    Friend WithEvents hdrTime As Label
    Friend WithEvents hdrFavoritePro As Label
    Friend WithEvents lblGolferID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFavoriteMajor As Label
    Friend WithEvents lblFavoriteMinor As Label
    Friend WithEvents lblHandicap As Label
    Friend WithEvents lblAverageScore As Label
    Friend WithEvents lblRegistered As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblFavoritePro As Label
    Friend WithEvents btnInfo As Button
    Friend WithEvents hdrTimesPlayed As Label
    Friend WithEvents lblTimesPlayed As Label
End Class
