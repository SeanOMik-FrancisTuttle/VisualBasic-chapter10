' Program name: Spring Break Vacation
' Name Sean Ervin

Public Class frmSpringBreakVacation
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpringBreakDataSet)

    End Sub

    Private Sub frmSpringBreakVacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpringBreakDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.SpringBreakDataSet.Table)

        Dim decCost As Decimal
        For Each ageRow As DataRow In SpringBreakDataSet.Table.Rows
            decCost += ageRow.Item("paid")
        Next

        lblTotal.Text = "Total Paid: " + decCost.ToString("C")
    End Sub
End Class
