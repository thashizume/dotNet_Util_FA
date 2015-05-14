Public Class ucSubMenu

    Private cbValue1 As String = "Information"
    Private cbValue2 As String = "Filter"
    Private cbSource As System.Data.DataTable = New System.Data.DataTable

    Private Sub ucInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cb1.Items.Clear()
        Dim row As System.Data.DataRow
        cbSource.Columns.Add("DISP", GetType(String))
        cbSource.Columns.Add("VALUE", GetType(String))

        row = cbSource.NewRow()
        row(1) = ENUM_COMBO_ITEM.INFOMATION
        row(0) = cbValue1
        cbSource.Rows.Add(row)

        row = cbSource.NewRow()
        row(1) = ENUM_COMBO_ITEM.FILTER
        row(0) = cbValue2
        cbSource.Rows.Add(row)

        cb1.DataSource = cbSource
        cb1.DisplayMember = "DISP"
        cb1.ValueMember = "VALUE"

        Panel1.Height = cb1.Height

    End Sub

    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged

        Panel2.Controls.Clear()
        Select Case cb1.SelectedIndex
            Case ENUM_COMBO_ITEM.INFOMATION
                Dim uc As New ucInfo
                Panel2.Controls.Add(uc)
                Panel2.Controls(0).Dock = DockStyle.Fill

            Case ENUM_COMBO_ITEM.FILTER
                Dim uc As New ucFilterList
                Panel2.Controls.Add(uc)
                Panel2.Controls(0).Dock = DockStyle.Fill

            Case Else

        End Select

    End Sub





    Private Enum ENUM_COMBO_ITEM As Long
        INFOMATION = 0
        FILTER = 1
    End Enum

End Class


