'******************************************************
'* Name:       Daniel O'Malley
'* Class:      CIS-1510
'* Assignment: Final Project
'* File:       frmAddGolfers.vb
'* Purpose:    Add to golfer's log
'******************************************************
Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary
Imports System.IO
Imports System.Text
Public Class frmEditGolfer
    Const mainFile As String = "C:\GUI\Assignments\FinalProject\bin\Debug\StoredData.txt"
    Const majorsFile As String = "C:\GUI\Assignments\FinalProject\bin\Debug\majors.txt"
    Const minorsFile As String = "C:\GUI\Assignments\FinalProject\bin\Debug\minors.txt"


    Private Sub frmAddGolfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As IO.StreamReader
        Dim outSb As StringBuilder = New StringBuilder("")
        Dim masters As String
        Dim pga As String
        Dim us As String
        Dim open As String
        Dim wholeLine As String = ""
        Dim splitString As String()
        Dim inFile2 As IO.StreamReader
        Dim outSb2 As StringBuilder = New StringBuilder("")
        Dim wholeLine2 As String = ""
        Dim splitString2 As String()
        Dim safeway As String
        Dim houston As String
        Dim zozo As String
        Dim bermuda As String
        Dim mayakoba As String
        Dim rsm As String
        Dim travelers As String
        Dim rocket As String
        Dim deere As String
        Dim golferID As String = txtGolferID.Text
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim selectedGolfer As Golfer






        If Not File.Exists(majorsFile) Then
            MsgBox("The file " & majorsFile & " does not exist", MsgBoxStyle.Critical, "Error")
            Return
        End If

        inFile = File.OpenText(majorsFile)

        Do Until inFile.Peek = -1
            wholeLine = inFile.ReadLine()
            If (wholeLine.Contains(","c)) Then
                splitString = wholeLine.Split(","c)
                masters = splitString(0)
                pga = splitString(1)
                us = splitString(2)
                open = splitString(3)
            End If
        Loop

        inFile.Close()


        ddlMajors.Items.Add(masters)
        ddlMajors.Items.Add(pga)
        ddlMajors.Items.Add(us)
        ddlMajors.Items.Add(open)


        If Not File.Exists(minorsFile) Then
            MsgBox("The file " & minorsFile & " does not exist", MsgBoxStyle.Critical, "Error")
            Return
        End If

        inFile2 = File.OpenText(minorsFile)

        Do Until inFile2.Peek = -1
            wholeLine2 = inFile2.ReadLine()
            If (wholeLine2.Contains(","c)) Then
                splitString2 = wholeLine2.Split(","c)
                safeway = splitString2(0)
                houston = splitString2(1)
                zozo = splitString2(2)
                bermuda = splitString2(3)
                mayakoba = splitString2(4)
                rsm = splitString2(5)
                travelers = splitString2(6)
                rocket = splitString2(7)
                deere = splitString2(8)
            End If
        Loop
        inFile2.Close()

        lstMinors.Items.Add(safeway)
        lstMinors.Items.Add(houston)
        lstMinors.Items.Add(zozo)
        lstMinors.Items.Add(bermuda)
        lstMinors.Items.Add(mayakoba)
        lstMinors.Items.Add(rsm)
        lstMinors.Items.Add(travelers)
        lstMinors.Items.Add(rocket)
        lstMinors.Items.Add(deere)

        lblErrorID.Visible = False
        lblErrorFirst.Visible = False
        lblErrorLast.Visible = False
        lblErrorMajor.Visible = False
        lblErrorMinor.Visible = False
        lblErrorHandicap.Visible = False
        lblErrorAvg.Visible = False
        lblErrorTimesPlayed.Visible = False
        lblErrorPlayTime.Visible = False
        lblErrorPro.Visible = False

        selectedGolfer = frmGolfers.golferInfo(frmGolfers.lstGolfers.SelectedIndex)
        txtGolferID.Text = selectedGolfer.golferID
        txtFirstName.Text = selectedGolfer.firstName
        txtLastName.Text = selectedGolfer.lastName
        ddlMajors.SelectedItem = selectedGolfer.major
        lstMinors.SelectedItem = selectedGolfer.minor
        If selectedGolfer.handicap = "0" Then
            radZero.Checked = True
        ElseIf selectedGolfer.handicap = "1-9" Then
            rad1to9.Checked = True
        ElseIf selectedGolfer.handicap = "10-19" Then
            rad10to19.Checked = True
        ElseIf selectedGolfer.handicap = "20+" Then
            rad20plus.Checked = True
        End If
        txtAverageScore.Text = selectedGolfer.avgScore.ToString()
        If selectedGolfer.registered = True Then
            chkRegistered.Checked = True
        End If
        txtTimesPlayed.Text = selectedGolfer.timesPlayed.ToString()
        dtpLastPlayed.Value = Convert.ToDateTime(selectedGolfer.lastPlayed)
        ddlTime.SelectedItem = selectedGolfer.favoriteTime
        txtFavoritePro.Text = selectedGolfer.favoritePro

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If e.KeyChar >= "a" And e.KeyChar <= "z" Then
            Return
        End If

        If e.KeyChar >= "A" And e.KeyChar <= "Z" Then
            Return
        End If

        If e.KeyChar = " " Then
            Return
        End If

        If e.KeyChar = ChrW(1) Or e.KeyChar = ChrW(3) Or e.KeyChar = ChrW(22) Or e.KeyChar = ChrW(24) Then
            Return
        End If

        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If e.KeyChar = "-" Or e.KeyChar = "'" Then
            Return
        End If
        e.Handled = True
        Return
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If e.KeyChar >= "a" And e.KeyChar <= "z" Then
            Return
        End If

        If e.KeyChar >= "A" And e.KeyChar <= "Z" Then
            Return
        End If

        If e.KeyChar = " " Then
            Return
        End If

        If e.KeyChar = ChrW(1) Or e.KeyChar = ChrW(3) Or e.KeyChar = ChrW(22) Or e.KeyChar = ChrW(24) Then
            Return
        End If

        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If e.KeyChar = "-" Or e.KeyChar = "'" Then
            Return
        End If
        e.Handled = True
        Return
    End Sub

    Private Sub txtAverageScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAverageScore.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            Return
        End If
        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        e.Handled = True
        Return
    End Sub

    Private Sub txtTimesPlayed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTimesPlayed.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            Return
        End If
        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        e.Handled = True
        Return
    End Sub

    Private Sub txtFavoritePro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFavoritePro.KeyPress
        If e.KeyChar >= "a" And e.KeyChar <= "z" Then
            Return
        End If

        If e.KeyChar >= "A" And e.KeyChar <= "Z" Then
            Return
        End If

        If e.KeyChar = " " Then
            Return
        End If

        If e.KeyChar = ChrW(1) Or e.KeyChar = ChrW(3) Or e.KeyChar = ChrW(22) Or e.KeyChar = ChrW(24) Then
            Return
        End If

        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If e.KeyChar = "-" Or e.KeyChar = "'" Then
            Return
        End If
        e.Handled = True
        Return
    End Sub

    Private Sub txtGolferID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGolferID.KeyPress
        If e.KeyChar >= "a" And e.KeyChar <= "z" Then
            Return
        End If

        If e.KeyChar >= "A" And e.KeyChar <= "Z" Then
            Return
        End If
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            Return
        End If
        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        e.Handled = True
        Return
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim outFile As IO.StreamWriter
        Dim handicap As String
        Dim registered As Boolean
        If txtGolferID.Text = "" Then
            lblErrorID.Visible = True
            MsgBox("Error! Cannot leave Golfer ID blank", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorLast.Visible = False
            lblErrorMajor.Visible = False
            lblErrorMinor.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorAvg.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If txtFirstName.Text = "" Then
            lblErrorFirst.Visible = True
            MsgBox("Error! Cannot leave First Name blank", MsgBoxStyle.Critical, "Error!")
            lblErrorID.Visible = False
            lblErrorLast.Visible = False
            lblErrorMajor.Visible = False
            lblErrorMinor.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorAvg.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If txtLastName.Text = "" Then
            lblErrorLast.Visible = True
            MsgBox("Error! Cannot leave Last Name blank", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorID.Visible = False
            lblErrorMajor.Visible = False
            lblErrorMinor.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorAvg.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If ddlMajors.SelectedIndex = -1 Then
            lblErrorMajor.Visible = True
            MsgBox("Error! Cannot leave Favorite Major blank", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorLast.Visible = False
            lblErrorID.Visible = False
            lblErrorMinor.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorAvg.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If lstMinors.SelectedIndex = -1 Then
            lblErrorMinor.Visible = True
            MsgBox("Error! Cannot leave Favorite Minor blank", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorLast.Visible = False
            lblErrorMajor.Visible = False
            lblErrorID.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorAvg.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If radZero.Checked = False And rad1to9.Checked = False And rad10to19.Checked = False And rad20plus.Checked = False Then
            lblErrorHandicap.Visible = True
            MsgBox("Error! Must select a Handicap", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorLast.Visible = False
            lblErrorMajor.Visible = False
            lblErrorMinor.Visible = False
            lblErrorID.Visible = False
            lblErrorAvg.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If txtAverageScore.Text = "" Then
            lblErrorAvg.Visible = True
            MsgBox("Error! Cannot leave Average Score blank", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorLast.Visible = False
            lblErrorMajor.Visible = False
            lblErrorMinor.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorID.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If txtTimesPlayed.Text = "" Then
            lblErrorTimesPlayed.Visible = True
            MsgBox("Error! Cannot leave Times Played Per Month blank", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorLast.Visible = False
            lblErrorMajor.Visible = False
            lblErrorMinor.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorAvg.Visible = False
            lblErrorID.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If ddlTime.SelectedIndex = -1 Then
            lblErrorPlayTime.Visible = True
            MsgBox("Error! Cannot leave Favorite Time To Play blank", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorLast.Visible = False
            lblErrorMajor.Visible = False
            lblErrorMinor.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorAvg.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorID.Visible = False
            lblErrorPro.Visible = False
            Return
        End If
        If txtFavoritePro.Text = "" Then
            lblErrorPro.Visible = True
            MsgBox("Error! Cannot leave favorite professional blank", MsgBoxStyle.Critical, "Error!")
            lblErrorFirst.Visible = False
            lblErrorLast.Visible = False
            lblErrorMajor.Visible = False
            lblErrorMinor.Visible = False
            lblErrorHandicap.Visible = False
            lblErrorAvg.Visible = False
            lblErrorTimesPlayed.Visible = False
            lblErrorPlayTime.Visible = False
            lblErrorID.Visible = False
            Return
        End If
        If radZero.Checked Then
            handicap = "0"
        ElseIf rad1to9.Checked Then
            handicap = "1-9"
        ElseIf rad10to19.Checked Then
            handicap = "10-19"
        ElseIf rad20plus.Checked Then
            handicap = "20+"

        End If

        If chkRegistered.Checked Then
            registered = True
        Else
            registered = False
        End If

        Dim selectedGolfer As Golfer
        selectedGolfer = frmGolfers.golferInfo(frmGolfers.lstGolfers.SelectedIndex)
        selectedGolfer.golferID = txtGolferID.Text
        selectedGolfer.firstName = txtFirstName.Text
        selectedGolfer.lastName = txtLastName.Text
        selectedGolfer.major = ddlMajors.SelectedItem.ToString()
        selectedGolfer.minor = lstMinors.SelectedItem.ToString()
        selectedGolfer.handicap = handicap
        selectedGolfer.avgScore = Convert.ToInt32(txtAverageScore.Text)
        selectedGolfer.registered = Convert.ToBoolean(registered)
        selectedGolfer.timesPlayed = Convert.ToInt32(txtTimesPlayed.Text)
        selectedGolfer.lastPlayed = dtpLastPlayed.Value.ToString()
        selectedGolfer.favoriteTime = ddlTime.SelectedItem.ToString()
        selectedGolfer.favoritePro = txtFavoritePro.Text

        Dim counter As Int32 = 0
        Dim outLine As String
        Dim item As Golfer
        Dim itemRegistered As String
        IO.File.WriteAllText(mainFile, "")
        outFile = File.AppendText(mainFile)
        For counter = 0 To frmGolfers.lstGolfers.Items.Count - 1
            If counter = frmGolfers.lstGolfers.SelectedIndex Then
                item = selectedGolfer
            Else
                item = frmGolfers.golferInfo(counter)
            End If
            If item.registered = True Then
                itemRegistered = "1"
            Else
                itemRegistered = "0"
            End If
            outLine = item.golferID & "|" & item.firstName & "|" & item.lastName & "|" & item.major & "|" & item.minor & "|" & item.handicap & "|" & item.avgScore & "|" & itemRegistered & "|" & item.timesPlayed & "|" & item.lastPlayed & "|" & item.favoriteTime & "|" & item.favoritePro
            outFile.WriteLine(outLine)



        Next


        'golferInfo(golfers) = txtGolferID.Text & "|" & txtFirstName.Text & "|" & txtLastName.Text & "|" & ddlMajors.SelectedItem.ToString() & "|" & lstMinors.SelectedItem.ToString() & "|" & handicap & "|" & txtAverageScore.Text & "|" & registered & "|" & txtTimesPlayed.Text & "|" & dtpLastPlayed.Value.ToShortDateString() & "|" & ddlTime.SelectedItem.ToString() & "|" & txtFavoritePro.Text

        'outFile = File.AppendText(mainFile)

        'outFile.WriteLine(golferInfo(golfers))
        Dim selectedIndex As Int32 = frmGolfers.lstGolfers.SelectedIndex
        outFile.Close()
        Me.Hide()
        frmGolfers.loadGolfers()

        'frmGolfers.Show()
    End Sub


End Class

