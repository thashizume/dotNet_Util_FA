Public Class Form1

    Dim _dt As System.Data.DataTable = Nothing
    Dim _distExt As System.Data.DataTable = Nothing
    Dim _distDirectory As System.Data.DataTable = Nothing
    Private _fl As jp.polestar.io.FileList = New jp.polestar.io.FileList

    Private Sub AnalyzeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalyzeToolStripMenuItem.Click
        _dt = _fl.Analyse("c:\Users\toshi")
        Me.DataGridView1.DataSource = _dt
    End Sub

    ''' <summary>
    ''' 拡張子毎に集計した結果を　DataGridView に出力する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExtentsNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtentsNameToolStripMenuItem.Click
        Dim dv1 As System.Data.DataView = New System.Data.DataView(_fl.Extents, String.Empty, "SIZE desc", DataViewRowState.CurrentRows)
        DataGridView1.DataSource = dv1

    End Sub

    ''' <summary>
    ''' Directory 毎にファイルサイズを集計し DataGridviewに出力する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DirectoryNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectoryNameToolStripMenuItem.Click
        Dim dv1 As System.Data.DataView = New System.Data.DataView(_fl.Directories, String.Empty, "SIZE desc", DataViewRowState.CurrentRows)
        DataGridView1.DataSource = dv1

    End Sub
End Class
