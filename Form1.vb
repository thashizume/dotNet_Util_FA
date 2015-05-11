Public Class Form1

    Private _dt As System.Data.DataTable = Nothing
    Private _distExt As System.Data.DataTable = Nothing
    Private _distDirectory As System.Data.DataTable = Nothing
    Private _fl As jp.polestar.io.FileList = New jp.polestar.io.FileList
    Private _conditionString As String = String.Empty
    Private _countFile As Long = 0
    Private _countSize As Long = 0
    Private _dvType As ENUM_DV_TYPE = ENUM_DV_TYPE.file

    Private Sub AnalyzeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalyzeToolStripMenuItem.Click

        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' TODO: Use BackgroundProcess
            _dt = _fl.Analyse(Me.FolderBrowserDialog1.SelectedPath)

            Dim dv1 As System.Data.DataView = New System.Data.DataView(_fl.Files, _conditionString, "SELECTED desc, DIRECTORY_NAME", DataViewRowState.CurrentRows)
            DataGridView1.Columns.Clear()
            '     DataGridView1.Columns(0).Visible = False
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = dv1

            _countFile = dv1.Count
            _countSize = dv1.ToTable().Compute("Sum(size)", String.Empty)
            _dvType = ENUM_DV_TYPE.file



        End If

    End Sub

    Private Sub ExtentsNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtentsNameToolStripMenuItem.Click
        Dim dv1 As System.Data.DataView = New System.Data.DataView(_fl.Extents, _conditionString, "SIZE desc", DataViewRowState.CurrentRows)
        If dv1.Count = 0 Then Return

        DataGridView1.Columns.Clear()
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dv1

        _countFile = dv1.Count
        _countSize = dv1.ToTable().Compute("Sum(size)", String.Empty)
        _dvType = ENUM_DV_TYPE.ext


    End Sub

    Private Sub DirectoryNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectoryNameToolStripMenuItem.Click
        Dim dv1 As System.Data.DataView = New System.Data.DataView(_fl.Directories, _conditionString, "SIZE desc", DataViewRowState.CurrentRows)
        If dv1.Count = 0 Then Return

        DataGridView1.Columns.Clear()

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dv1

        _countFile = dv1.Count
        _countSize = dv1.ToTable().Compute("Sum(size)", String.Empty)
        _dvType = ENUM_DV_TYPE.directory


    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        Dim dv1 As System.Data.DataView = New System.Data.DataView(_fl.Files, _conditionString, "SELECTED desc, DIRECTORY_NAME", DataViewRowState.CurrentRows)
        If dv1.Count = 0 Then Return

        DataGridView1.Columns.Clear()
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dv1

        _countFile = dv1.Count
        _countSize = dv1.ToTable().Compute("Sum(size)", String.Empty)
        _dvType = ENUM_DV_TYPE.file

    End Sub

    Enum ENUM_DV_TYPE As Long
        file = 0
        directory = 1
        ext = 2
    End Enum

    Private Sub SELECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTToolStripMenuItem.Click

        Select Case _dvType
            Case ENUM_DV_TYPE.file
                Dim f As List(Of String) = New List(Of String)

                For Each _row As DataGridViewRow In DataGridView1.SelectedRows
                    f.Add(_row.Cells("FILE_NAME").Value)
                Next
                _fl.SeleteFile(f.ToArray)


                Dim dv1 As System.Data.DataView = New System.Data.DataView(_fl.Files, _conditionString, "SELECTED desc, DIRECTORY_NAME", DataViewRowState.CurrentRows)
                DataGridView1.Columns.Clear()
                '     DataGridView1.Columns(0).Visible = False
                DataGridView1.AutoGenerateColumns = True
                DataGridView1.DataSource = dv1

                _countFile = dv1.Count
                _countSize = dv1.ToTable().Compute("Sum(size)", String.Empty)
                _dvType = ENUM_DV_TYPE.file

            Case ENUM_DV_TYPE.directory



            Case ENUM_DV_TYPE.ext



        End Select


    End Sub



    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)
        'セルの列を確認
        If dgv.Columns(e.ColumnIndex).Name = "SELECTED" AndAlso TypeOf e.Value Is Long Then

            Select Case _dvType
                Case ENUM_DV_TYPE.file
                    Dim val As Integer = CInt(e.Value)
                    'セルの値により、背景色を変更する
                    If val = 0 Then
                        For Each _cell As DataGridViewCell In dgv.Rows(e.RowIndex).Cells
                            _cell.Style.BackColor = Color.White
                        Next
                    ElseIf val = 1 Then
                        For Each _cell As DataGridViewCell In dgv.Rows(e.RowIndex).Cells
                            _cell.Style.BackColor = Color.WhiteSmoke
                        Next
                    End If


                Case Else

            End Select

        End If

    End Sub
End Class

