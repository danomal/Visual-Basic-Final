'******************************************************
'* Name:       Daniel O'Malley
'* Class:      CIS-1510
'* Assignment: Final Project
'* File:       frmGolfers.vb
'* Purpose:    Golfer's log
'******************************************************

Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary
Imports System.IO
Imports System.Text
Public Class frmGolfers
    Const mainFile As String = "C:\GUI\Assignments\FinalProject\bin\Debug\StoredData.txt"
    Const MAX_Value As Integer = 1000

    Public golfers As Integer = 0

    Public golferInfo(MAX_Value - 1) As Golfer
    Private Sub frmGolfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGolfers()
        lstGolfers.SelectedIndex = 0
    End Sub
    Private Sub btnAddGolfer_Click(sender As Object, e As EventArgs) Handles btnAddGolfer.Click
        frmAddGolfer.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        frmInfo.Show()
    End Sub

    Private Sub lstGolfers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGolfers.SelectedIndexChanged
        If lstGolfers.SelectedIndex = -1 Then
            Return
        End If
        Dim selectedGolfer As Golfer
        selectedGolfer = golferInfo(lstGolfers.SelectedIndex)
        lblGolferID.Text = selectedGolfer.golferID
        lblFirstName.Text = selectedGolfer.firstName
        lblLastName.Text = selectedGolfer.lastName
        lblFavoriteMajor.Text = selectedGolfer.major
        lblFavoriteMinor.Text = selectedGolfer.minor
        lblHandicap.Text = selectedGolfer.handicap
        lblAverageScore.Text = selectedGolfer.avgScore.ToString()
        If selectedGolfer.registered = True Then
            lblRegistered.Text = "Yes"
        Else
            lblRegistered.Text = "No"
        End If
        lblTimesPlayed.Text = selectedGolfer.timesPlayed.ToString()
        lblDate.Text = selectedGolfer.lastPlayed
        lblTime.Text = selectedGolfer.favoriteTime
        lblFavoritePro.Text = selectedGolfer.favoritePro

    End Sub
    Public Sub loadGolfers()
        golfers = 0
        Array.Clear(golferInfo, 0, golferInfo.Length)
        lstGolfers.Items.Clear()
        Dim inFile As IO.StreamReader
        Dim outSb As StringBuilder = New StringBuilder("")
        Dim wholeLine As String = ""
        Dim splitString As String()




        If Not File.Exists(mainFile) Then
            MsgBox("The file " & mainFile & " does not exist", MsgBoxStyle.Critical, "Error")
            Return
        End If


        inFile = File.OpenText(mainFile)

        Do Until inFile.Peek = -1
            wholeLine = inFile.ReadLine()
            If (wholeLine.Contains("|"c)) Then
                splitString = wholeLine.Split("|"c)
                lstGolfers.Items.Add(splitString(0).ToString() & " " & splitString(1).ToString() & " " & splitString(2).ToString())
                Dim newGolfer As Golfer = New Golfer(splitString(0).ToString(), splitString(1).ToString(), splitString(2).ToString(), splitString(3).ToString(), splitString(4).ToString(), splitString(5).ToString(), Convert.ToInt32(splitString(6)), Convert.ToBoolean(Convert.ToInt32(splitString(7))), Convert.ToInt32(splitString(8)), splitString(9).ToString(), splitString(10).ToString(), splitString(11).ToString())
                golferInfo(golfers) = newGolfer
                golfers += 1
            Else
                outSb.Append(wholeLine + ControlChars.NewLine)
            End If

        Loop

        inFile.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEditGolfer.Show()
    End Sub
End Class

Public Class Golfer
    Public golferID As String
    Public firstName As String
    Public lastName As String
    Public major As String
    Public minor As String
    Public handicap As String
    Public avgScore As Integer
    Public registered As Boolean
    Public timesPlayed As Integer
    Public lastPlayed As String
    Public favoriteTime As String
    Public favoritePro As String

    Public Sub New(ByVal INgolferID As String, ByVal INfirstName As String, ByVal INlastName As String, ByVal INmajor As String, ByVal INminor As String, ByVal INhandicap As String, ByVal INavgScore As Integer, ByVal INRegistered As Boolean, ByVal INtimesPlayed As Integer, ByVal INlastPlayed As String, ByVal INfavoriteTime As String, ByVal INfavoritePro As String)
        golferID = INgolferID
        firstName = INfirstName
        lastName = INlastName
        major = INmajor
        minor = INminor
        handicap = INhandicap
        avgScore = INavgScore
        registered = INRegistered
        timesPlayed = INtimesPlayed
        lastPlayed = INlastPlayed
        favoriteTime = INfavoriteTime
        favoritePro = INfavoritePro
    End Sub
End Class