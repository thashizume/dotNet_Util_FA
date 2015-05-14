Public Class ucFilterList
    Inherits System.Windows.Forms.UserControl


    Private Sub ucFilterList_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim _filters As List(Of String) = CType(Me.Parent.Parent.Parent.Parent.Parent, Form1).Filters


    End Sub


    Private Sub getFilterConditions()

    End Sub

    Private Sub clearFilterConditions()

    End Sub

    Private Sub lnkAdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAdd.LinkClicked
        Dim f As New Filter
        If f.ShowDialog() = DialogResult.OK Then


        End If

    End Sub

    Private Sub lnkApply_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkApply.LinkClicked

    End Sub


End Class
