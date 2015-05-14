Public Class ucInfo




    Private Sub ucInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        pg1.SelectedObject = CType(CType(Me.Parent.Parent.Parent.Parent.Parent, Form1).FileList, FileList)


    End Sub
End Class
