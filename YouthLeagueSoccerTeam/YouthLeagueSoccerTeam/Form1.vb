﻿' Title:        Youth League Soccer Team Windows Application
' Author:       Sean Ervin
' Date:         September 23, 2019
' Purpose:      The application displays the the memebers of a soccer team and
'               calculates the average age of the members while also getting the
'               amount of players that are 12, 13, or 14.
Public Class frmYouthLeagueSoccerTeam
    Private Sub TeamBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TeamBindingNavigatorSaveItem.Click
        ' Auto generated by Visual Studio
        Me.Validate()
        Me.TeamBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SoccerDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event runs on load and fills the table with the data base. It also
        ' calculates the average age for all team memebers and gets the amount of
        ' people that are 12, 13, or 14.
        Me.TeamTableAdapter.Fill(Me.SoccerDataSet.Team)

        Dim intAmountOld As Integer = 0
        Dim intAverageAge As Integer = 0
        Dim intSize As Integer = 0
        For Each ageRow As DataRow In SoccerDataSet.Team.Rows
            Dim intAge As Integer = ageRow.Item("Age")
            If intAge >= 12 And intAge <= 14 Then
                intAmountOld += 1
            End If
            intAverageAge += intAge
            intSize += 1
        Next

        intAverageAge /= intSize
        lblAverage.Text = "Average Age: " & intAverageAge
        lblOldAmount.Text = "Old Team Member Amount: " & intAmountOld
    End Sub
End Class
