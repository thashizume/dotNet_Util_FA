Public Class ucInfo

    Private cbValue1 As String = "Information"
    Private cbValue2 As String = "Filter"

    Private Sub ucInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'cb1.Items.Clear()
        'cb1.Items.Add(Me.cbValue1)
        'cb1.Items.Add(Me.cbValue2)


        Dim cbSource As System.Data.DataTable = New System.Data.DataTable
        Dim row As System.Data.DataRow
        cbSource.Columns.Add("DISP", GetType(String))
        cbSource.Columns.Add("VALUE", GetType(String))

        row = cbSource.NewRow()
        row(0) = cbValue1
        row(1) = cbValue1
        cbSource.Rows.Add(row)

        row = cbSource.NewRow()
        row(0) = cbValue2
        row(1) = cbValue2
        cbSource.Rows.Add(row)

        cb1.DataSource = cbSource
        cb1.DisplayMember = "DISP"
        cb1.ValueMember = "VALUE"

        Panel1.Height = cb1.Height

    End Sub

    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged

        Debug.Print(cb1.SelectedValue)

    End Sub






End Class
