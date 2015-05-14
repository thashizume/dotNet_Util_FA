Public Class Filter

    Dim cbSource As System.Data.DataTable = New System.Data.DataTable

    Private Sub Filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb1.Items.Clear()
        Dim row As System.Data.DataRow
        cbSource.Columns.Add("DISP", GetType(String))
        cbSource.Columns.Add("VALUE", GetType(String))

        row = cbSource.NewRow()
        row(1) = ENUM_FILTER_ITEM.DIRECTORY
        row(0) = "Directory Name"
        cbSource.Rows.Add(row)

        row = cbSource.NewRow()
        row(1) = ENUM_FILTER_ITEM.EXTENTS
        row(0) = "Extent"
        cbSource.Rows.Add(row)

        row = cbSource.NewRow()
        row(1) = ENUM_FILTER_ITEM.FILE
        row(0) = "File Name"
        cbSource.Rows.Add(row)


        row = cbSource.NewRow()
        row(1) = ENUM_FILTER_ITEM.SIZE
        row(0) = "File Size"
        cbSource.Rows.Add(row)

        row = cbSource.NewRow()
        row(1) = ENUM_FILTER_ITEM.CREATE_DATE
        row(0) = "Create Date"
        cbSource.Rows.Add(row)

        row = cbSource.NewRow()
        row(1) = ENUM_FILTER_ITEM.MODIFY_DATE
        row(0) = "Modify Date"
        cbSource.Rows.Add(row)



        cb1.DataSource = cbSource
        cb1.DisplayMember = "DISP"
        cb1.ValueMember = "VALUE"


    End Sub

    Enum ENUM_FILTER_ITEM As Long
        DIRECTORY = 0
        EXTENTS = 1
        FILE = 2
        SIZE = 3
        CREATE_DATE = 4
        MODIFY_DATE = 5
    End Enum

    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged

        Panel3.Controls.Clear()

        Select Case cb1.SelectedIndex
            Case ENUM_FILTER_ITEM.DIRECTORY
                Dim uc As New ucFilterKeyword
                Panel3.Controls.Add(uc)
                Panel3.Controls(0).Dock = DockStyle.Fill

            Case ENUM_FILTER_ITEM.EXTENTS

                Dim uc As New ucFilterCheckbox
                Panel3.Controls.Add(uc)
                Panel3.Controls(0).Dock = DockStyle.Fill

            Case ENUM_FILTER_ITEM.CREATE_DATE
                Dim uc As New ucFilterDateRange
                Panel3.Controls.Add(uc)
                Panel3.Controls(0).Dock = DockStyle.Fill
            Case Else

        End Select
    End Sub
End Class