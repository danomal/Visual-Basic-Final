<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditGolfer
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
        Me.hdrGolferID = New System.Windows.Forms.Label()
        Me.txtGolferID = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFavoriteMajor = New System.Windows.Forms.Label()
        Me.lblFavoriteMinor = New System.Windows.Forms.Label()
        Me.gbxHandicap = New System.Windows.Forms.GroupBox()
        Me.rad20plus = New System.Windows.Forms.RadioButton()
        Me.rad10to19 = New System.Windows.Forms.RadioButton()
        Me.rad1to9 = New System.Windows.Forms.RadioButton()
        Me.radZero = New System.Windows.Forms.RadioButton()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.lblRegistered = New System.Windows.Forms.Label()
        Me.chkRegistered = New System.Windows.Forms.CheckBox()
        Me.lblTimesPlayed = New System.Windows.Forms.Label()
        Me.lblLastPlayed = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblFavoritePro = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.ddlMajors = New System.Windows.Forms.ComboBox()
        Me.lstMinors = New System.Windows.Forms.ListBox()
        Me.txtAverageScore = New System.Windows.Forms.TextBox()
        Me.dtpLastPlayed = New System.Windows.Forms.DateTimePicker()
        Me.txtTimesPlayed = New System.Windows.Forms.TextBox()
        Me.ddlTime = New System.Windows.Forms.ComboBox()
        Me.txtFavoritePro = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblErrorID = New System.Windows.Forms.Label()
        Me.lblErrorFirst = New System.Windows.Forms.Label()
        Me.lblErrorLast = New System.Windows.Forms.Label()
        Me.lblErrorMajor = New System.Windows.Forms.Label()
        Me.lblErrorMinor = New System.Windows.Forms.Label()
        Me.lblErrorHandicap = New System.Windows.Forms.Label()
        Me.lblErrorAvg = New System.Windows.Forms.Label()
        Me.lblErrorTimesPlayed = New System.Windows.Forms.Label()
        Me.lblErrorPro = New System.Windows.Forms.Label()
        Me.lblErrorPlayTime = New System.Windows.Forms.Label()
        Me.gbxHandicap.SuspendLayout()
        Me.SuspendLayout()
        '
        'hdrGolferID
        '
        Me.hdrGolferID.AutoSize = True
        Me.hdrGolferID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrGolferID.Location = New System.Drawing.Point(12, 9)
        Me.hdrGolferID.Name = "hdrGolferID"
        Me.hdrGolferID.Size = New System.Drawing.Size(69, 16)
        Me.hdrGolferID.TabIndex = 5
        Me.hdrGolferID.Text = "Golfer ID"
        '
        'txtGolferID
        '
        Me.txtGolferID.Location = New System.Drawing.Point(125, 8)
        Me.txtGolferID.MaxLength = 5
        Me.txtGolferID.Name = "txtGolferID"
        Me.txtGolferID.Size = New System.Drawing.Size(100, 20)
        Me.txtGolferID.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(12, 48)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(83, 16)
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(12, 87)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(82, 16)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "Last Name"
        '
        'lblFavoriteMajor
        '
        Me.lblFavoriteMajor.AutoSize = True
        Me.lblFavoriteMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavoriteMajor.Location = New System.Drawing.Point(12, 126)
        Me.lblFavoriteMajor.Name = "lblFavoriteMajor"
        Me.lblFavoriteMajor.Size = New System.Drawing.Size(108, 16)
        Me.lblFavoriteMajor.TabIndex = 9
        Me.lblFavoriteMajor.Text = "Favorite Major"
        '
        'lblFavoriteMinor
        '
        Me.lblFavoriteMinor.AutoSize = True
        Me.lblFavoriteMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavoriteMinor.Location = New System.Drawing.Point(12, 165)
        Me.lblFavoriteMinor.Name = "lblFavoriteMinor"
        Me.lblFavoriteMinor.Size = New System.Drawing.Size(107, 16)
        Me.lblFavoriteMinor.TabIndex = 10
        Me.lblFavoriteMinor.Text = "Favorite Minor"
        '
        'gbxHandicap
        '
        Me.gbxHandicap.Controls.Add(Me.rad20plus)
        Me.gbxHandicap.Controls.Add(Me.rad10to19)
        Me.gbxHandicap.Controls.Add(Me.rad1to9)
        Me.gbxHandicap.Controls.Add(Me.radZero)
        Me.gbxHandicap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxHandicap.Location = New System.Drawing.Point(15, 249)
        Me.gbxHandicap.Name = "gbxHandicap"
        Me.gbxHandicap.Size = New System.Drawing.Size(159, 127)
        Me.gbxHandicap.TabIndex = 11
        Me.gbxHandicap.TabStop = False
        Me.gbxHandicap.Text = "Handicap"
        '
        'rad20plus
        '
        Me.rad20plus.AutoSize = True
        Me.rad20plus.Location = New System.Drawing.Point(71, 99)
        Me.rad20plus.Name = "rad20plus"
        Me.rad20plus.Size = New System.Drawing.Size(50, 20)
        Me.rad20plus.TabIndex = 8
        Me.rad20plus.TabStop = True
        Me.rad20plus.Text = "20+"
        Me.rad20plus.UseVisualStyleBackColor = True
        '
        'rad10to19
        '
        Me.rad10to19.AutoSize = True
        Me.rad10to19.Location = New System.Drawing.Point(71, 73)
        Me.rad10to19.Name = "rad10to19"
        Me.rad10to19.Size = New System.Drawing.Size(63, 20)
        Me.rad10to19.TabIndex = 7
        Me.rad10to19.TabStop = True
        Me.rad10to19.Text = "10-19"
        Me.rad10to19.UseVisualStyleBackColor = True
        '
        'rad1to9
        '
        Me.rad1to9.AutoSize = True
        Me.rad1to9.Location = New System.Drawing.Point(71, 47)
        Me.rad1to9.Name = "rad1to9"
        Me.rad1to9.Size = New System.Drawing.Size(47, 20)
        Me.rad1to9.TabIndex = 6
        Me.rad1to9.TabStop = True
        Me.rad1to9.Text = "1-9"
        Me.rad1to9.UseVisualStyleBackColor = True
        '
        'radZero
        '
        Me.radZero.AutoSize = True
        Me.radZero.Location = New System.Drawing.Point(71, 21)
        Me.radZero.Name = "radZero"
        Me.radZero.Size = New System.Drawing.Size(34, 20)
        Me.radZero.TabIndex = 5
        Me.radZero.TabStop = True
        Me.radZero.Text = "0"
        Me.radZero.UseVisualStyleBackColor = True
        '
        'lblAverageScore
        '
        Me.lblAverageScore.AutoSize = True
        Me.lblAverageScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageScore.Location = New System.Drawing.Point(12, 392)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(112, 16)
        Me.lblAverageScore.TabIndex = 12
        Me.lblAverageScore.Text = "Average Score"
        '
        'lblRegistered
        '
        Me.lblRegistered.AutoSize = True
        Me.lblRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistered.Location = New System.Drawing.Point(12, 424)
        Me.lblRegistered.Name = "lblRegistered"
        Me.lblRegistered.Size = New System.Drawing.Size(161, 16)
        Me.lblRegistered.TabIndex = 13
        Me.lblRegistered.Text = "Registered with USGA"
        '
        'chkRegistered
        '
        Me.chkRegistered.AutoSize = True
        Me.chkRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegistered.Location = New System.Drawing.Point(179, 423)
        Me.chkRegistered.Name = "chkRegistered"
        Me.chkRegistered.Size = New System.Drawing.Size(54, 20)
        Me.chkRegistered.TabIndex = 14
        Me.chkRegistered.Text = "Yes"
        Me.chkRegistered.UseVisualStyleBackColor = True
        '
        'lblTimesPlayed
        '
        Me.lblTimesPlayed.AutoSize = True
        Me.lblTimesPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimesPlayed.Location = New System.Drawing.Point(12, 456)
        Me.lblTimesPlayed.Name = "lblTimesPlayed"
        Me.lblTimesPlayed.Size = New System.Drawing.Size(177, 16)
        Me.lblTimesPlayed.TabIndex = 15
        Me.lblTimesPlayed.Text = "Times Played Per Month"
        '
        'lblLastPlayed
        '
        Me.lblLastPlayed.AutoSize = True
        Me.lblLastPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastPlayed.Location = New System.Drawing.Point(12, 488)
        Me.lblLastPlayed.Name = "lblLastPlayed"
        Me.lblLastPlayed.Size = New System.Drawing.Size(90, 16)
        Me.lblLastPlayed.TabIndex = 16
        Me.lblLastPlayed.Text = "Last Played"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(12, 520)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(162, 16)
        Me.lblTime.TabIndex = 17
        Me.lblTime.Text = "Favorite Time To Play"
        '
        'lblFavoritePro
        '
        Me.lblFavoritePro.AutoSize = True
        Me.lblFavoritePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavoritePro.Location = New System.Drawing.Point(12, 552)
        Me.lblFavoritePro.Name = "lblFavoritePro"
        Me.lblFavoritePro.Size = New System.Drawing.Size(156, 16)
        Me.lblFavoritePro.TabIndex = 18
        Me.lblFavoritePro.Text = "Favorite Professional"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(125, 47)
        Me.txtFirstName.MaxLength = 25
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(125, 86)
        Me.txtLastName.MaxLength = 35
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 2
        '
        'ddlMajors
        '
        Me.ddlMajors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlMajors.FormattingEnabled = True
        Me.ddlMajors.Location = New System.Drawing.Point(125, 125)
        Me.ddlMajors.Name = "ddlMajors"
        Me.ddlMajors.Size = New System.Drawing.Size(193, 21)
        Me.ddlMajors.TabIndex = 3
        '
        'lstMinors
        '
        Me.lstMinors.FormattingEnabled = True
        Me.lstMinors.Location = New System.Drawing.Point(125, 165)
        Me.lstMinors.Name = "lstMinors"
        Me.lstMinors.Size = New System.Drawing.Size(194, 82)
        Me.lstMinors.TabIndex = 4
        '
        'txtAverageScore
        '
        Me.txtAverageScore.Location = New System.Drawing.Point(125, 391)
        Me.txtAverageScore.MaxLength = 3
        Me.txtAverageScore.Name = "txtAverageScore"
        Me.txtAverageScore.Size = New System.Drawing.Size(100, 20)
        Me.txtAverageScore.TabIndex = 9
        '
        'dtpLastPlayed
        '
        Me.dtpLastPlayed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLastPlayed.Location = New System.Drawing.Point(108, 484)
        Me.dtpLastPlayed.Name = "dtpLastPlayed"
        Me.dtpLastPlayed.Size = New System.Drawing.Size(200, 20)
        Me.dtpLastPlayed.TabIndex = 11
        '
        'txtTimesPlayed
        '
        Me.txtTimesPlayed.Location = New System.Drawing.Point(195, 455)
        Me.txtTimesPlayed.MaxLength = 3
        Me.txtTimesPlayed.Name = "txtTimesPlayed"
        Me.txtTimesPlayed.Size = New System.Drawing.Size(113, 20)
        Me.txtTimesPlayed.TabIndex = 10
        '
        'ddlTime
        '
        Me.ddlTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlTime.FormattingEnabled = True
        Me.ddlTime.Items.AddRange(New Object() {"Morning", "Afternoon", "Evening"})
        Me.ddlTime.Location = New System.Drawing.Point(180, 519)
        Me.ddlTime.Name = "ddlTime"
        Me.ddlTime.Size = New System.Drawing.Size(128, 21)
        Me.ddlTime.TabIndex = 12
        '
        'txtFavoritePro
        '
        Me.txtFavoritePro.Location = New System.Drawing.Point(174, 551)
        Me.txtFavoritePro.MaxLength = 50
        Me.txtFavoritePro.Name = "txtFavoritePro"
        Me.txtFavoritePro.Size = New System.Drawing.Size(218, 20)
        Me.txtFavoritePro.TabIndex = 13
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(124, 580)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 31)
        Me.btnEdit.TabIndex = 28
        Me.btnEdit.Text = "&Edit Golfer"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(205, 580)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblErrorID
        '
        Me.lblErrorID.AutoSize = True
        Me.lblErrorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorID.ForeColor = System.Drawing.Color.Red
        Me.lblErrorID.Location = New System.Drawing.Point(222, 9)
        Me.lblErrorID.Name = "lblErrorID"
        Me.lblErrorID.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorID.TabIndex = 30
        Me.lblErrorID.Text = "*"
        '
        'lblErrorFirst
        '
        Me.lblErrorFirst.AutoSize = True
        Me.lblErrorFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorFirst.ForeColor = System.Drawing.Color.Red
        Me.lblErrorFirst.Location = New System.Drawing.Point(222, 48)
        Me.lblErrorFirst.Name = "lblErrorFirst"
        Me.lblErrorFirst.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorFirst.TabIndex = 31
        Me.lblErrorFirst.Text = "*"
        '
        'lblErrorLast
        '
        Me.lblErrorLast.AutoSize = True
        Me.lblErrorLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorLast.ForeColor = System.Drawing.Color.Red
        Me.lblErrorLast.Location = New System.Drawing.Point(222, 87)
        Me.lblErrorLast.Name = "lblErrorLast"
        Me.lblErrorLast.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorLast.TabIndex = 32
        Me.lblErrorLast.Text = "*"
        '
        'lblErrorMajor
        '
        Me.lblErrorMajor.AutoSize = True
        Me.lblErrorMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMajor.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMajor.Location = New System.Drawing.Point(324, 125)
        Me.lblErrorMajor.Name = "lblErrorMajor"
        Me.lblErrorMajor.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorMajor.TabIndex = 33
        Me.lblErrorMajor.Text = "*"
        '
        'lblErrorMinor
        '
        Me.lblErrorMinor.AutoSize = True
        Me.lblErrorMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMinor.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMinor.Location = New System.Drawing.Point(324, 165)
        Me.lblErrorMinor.Name = "lblErrorMinor"
        Me.lblErrorMinor.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorMinor.TabIndex = 34
        Me.lblErrorMinor.Text = "*"
        '
        'lblErrorHandicap
        '
        Me.lblErrorHandicap.AutoSize = True
        Me.lblErrorHandicap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorHandicap.ForeColor = System.Drawing.Color.Red
        Me.lblErrorHandicap.Location = New System.Drawing.Point(178, 258)
        Me.lblErrorHandicap.Name = "lblErrorHandicap"
        Me.lblErrorHandicap.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorHandicap.TabIndex = 35
        Me.lblErrorHandicap.Text = "*"
        '
        'lblErrorAvg
        '
        Me.lblErrorAvg.AutoSize = True
        Me.lblErrorAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorAvg.ForeColor = System.Drawing.Color.Red
        Me.lblErrorAvg.Location = New System.Drawing.Point(222, 391)
        Me.lblErrorAvg.Name = "lblErrorAvg"
        Me.lblErrorAvg.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorAvg.TabIndex = 36
        Me.lblErrorAvg.Text = "*"
        '
        'lblErrorTimesPlayed
        '
        Me.lblErrorTimesPlayed.AutoSize = True
        Me.lblErrorTimesPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorTimesPlayed.ForeColor = System.Drawing.Color.Red
        Me.lblErrorTimesPlayed.Location = New System.Drawing.Point(304, 455)
        Me.lblErrorTimesPlayed.Name = "lblErrorTimesPlayed"
        Me.lblErrorTimesPlayed.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorTimesPlayed.TabIndex = 37
        Me.lblErrorTimesPlayed.Text = "*"
        '
        'lblErrorPro
        '
        Me.lblErrorPro.AutoSize = True
        Me.lblErrorPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorPro.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPro.Location = New System.Drawing.Point(387, 552)
        Me.lblErrorPro.Name = "lblErrorPro"
        Me.lblErrorPro.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorPro.TabIndex = 39
        Me.lblErrorPro.Text = "*"
        '
        'lblErrorPlayTime
        '
        Me.lblErrorPlayTime.AutoSize = True
        Me.lblErrorPlayTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorPlayTime.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPlayTime.Location = New System.Drawing.Point(304, 523)
        Me.lblErrorPlayTime.Name = "lblErrorPlayTime"
        Me.lblErrorPlayTime.Size = New System.Drawing.Size(21, 25)
        Me.lblErrorPlayTime.TabIndex = 40
        Me.lblErrorPlayTime.Text = "*"
        '
        'frmEditGolfer
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 613)
        Me.Controls.Add(Me.lblErrorHandicap)
        Me.Controls.Add(Me.lblErrorMinor)
        Me.Controls.Add(Me.lblErrorMajor)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtFavoritePro)
        Me.Controls.Add(Me.ddlTime)
        Me.Controls.Add(Me.txtTimesPlayed)
        Me.Controls.Add(Me.dtpLastPlayed)
        Me.Controls.Add(Me.txtAverageScore)
        Me.Controls.Add(Me.lstMinors)
        Me.Controls.Add(Me.ddlMajors)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFavoritePro)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblLastPlayed)
        Me.Controls.Add(Me.lblTimesPlayed)
        Me.Controls.Add(Me.chkRegistered)
        Me.Controls.Add(Me.lblRegistered)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.gbxHandicap)
        Me.Controls.Add(Me.lblFavoriteMinor)
        Me.Controls.Add(Me.lblFavoriteMajor)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtGolferID)
        Me.Controls.Add(Me.hdrGolferID)
        Me.Controls.Add(Me.lblErrorID)
        Me.Controls.Add(Me.lblErrorFirst)
        Me.Controls.Add(Me.lblErrorLast)
        Me.Controls.Add(Me.lblErrorAvg)
        Me.Controls.Add(Me.lblErrorTimesPlayed)
        Me.Controls.Add(Me.lblErrorPro)
        Me.Controls.Add(Me.lblErrorPlayTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEditGolfer"
        Me.Text = "Edit Golfer (Daniel O'Malley #77)"
        Me.gbxHandicap.ResumeLayout(False)
        Me.gbxHandicap.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hdrGolferID As Label
    Friend WithEvents txtGolferID As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFavoriteMajor As Label
    Friend WithEvents lblFavoriteMinor As Label
    Friend WithEvents gbxHandicap As GroupBox
    Friend WithEvents rad20plus As RadioButton
    Friend WithEvents rad10to19 As RadioButton
    Friend WithEvents rad1to9 As RadioButton
    Friend WithEvents radZero As RadioButton
    Friend WithEvents lblAverageScore As Label
    Friend WithEvents lblRegistered As Label
    Friend WithEvents chkRegistered As CheckBox
    Friend WithEvents lblTimesPlayed As Label
    Friend WithEvents lblLastPlayed As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblFavoritePro As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents ddlMajors As ComboBox
    Friend WithEvents lstMinors As ListBox
    Friend WithEvents txtAverageScore As TextBox
    Friend WithEvents dtpLastPlayed As DateTimePicker
    Friend WithEvents txtTimesPlayed As TextBox
    Friend WithEvents ddlTime As ComboBox
    Friend WithEvents txtFavoritePro As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblErrorID As Label
    Friend WithEvents lblErrorFirst As Label
    Friend WithEvents lblErrorLast As Label
    Friend WithEvents lblErrorMajor As Label
    Friend WithEvents lblErrorMinor As Label
    Friend WithEvents lblErrorHandicap As Label
    Friend WithEvents lblErrorAvg As Label
    Friend WithEvents lblErrorTimesPlayed As Label
    Friend WithEvents lblErrorPro As Label
    Friend WithEvents lblErrorPlayTime As Label
End Class
