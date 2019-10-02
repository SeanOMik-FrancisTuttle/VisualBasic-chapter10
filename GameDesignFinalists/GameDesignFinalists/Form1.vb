' Title:        Gaming Art Windows Application
' Author:       Sean Ervin
' Date:         September 20, 2019
' Purpose:      The application displays the game design artists who have entered the Game Art &
'               design competition as an interface for a Microsoft Access database.
Public Class Form1
    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)

    End Sub

    Private Sub BtnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        ' strSQL is a SQL statement that selects all the fields from the
        ' Artists table

        Dim strSql As String = "SELECT * FROM Artist"

        'strPath provides the database type and path for the Art database
        Dim strPath As String = My.Settings.ArtConnectionString
        Dim odaArtist As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D

        ' The DataTable name datValue is filled with the table data
        odaArtist.Fill(datValue)
        ' The connection to the database is disconnected
        odaArtist.Dispose()

        For intCount = 0 To datValue.Rows.Count - 1
            decTotalValue += Convert.ToDecimal(datValue.Rows(intCount)("Retail Price"))
        Next
        lblTotalRetailValue.Visible = True
        lblTotalRetailValue.Text = "The Total Retail Value is " & decTotalValue.ToString("C")
    End Sub
End Class
