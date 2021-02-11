Imports Excel = Microsoft.Office.Interop.Excel
Module mod_grid_Excel

    Public Sub LancerExcel(grid As DataGridView)

        'Crée une feuille excel.'
        Dim exApp As New Excel.Application
        Dim book As Excel.Workbook
        Dim sheet As Excel.Worksheet

        'Récupère les colonnes et les lignes du datagrid.'
        Dim col As Integer = grid.ColumnCount
        Dim row As Integer = grid.RowCount


        'Transfère le book et le sheet d'excel dans notre app.'
        book = exApp.Workbooks.Add()
        sheet = exApp.Worksheets.Add()

        'Remplis les noms de colonnes.'
        For i As Integer = 1 To col
            sheet.Cells.Item(1, i) = grid.Columns(i - 1).HeaderText.ToString
            sheet.Cells.Item(1, i).Borders.LineStyle = 7
        Next

        'Remplis les cellules d'excel.'
        For i As Integer = 0 To row - 1
            For j As Integer = 0 To col - 1
                'La première cell commence à (2,1).'
                sheet.Cells.Item(i + 2, j + 1) = grid.Rows(i).Cells(j).Value
                sheet.Cells.Item(i + 2, j + 1).Borders.LineStyle = 7
            Next
        Next

        'Modifie les colonnes.'
        sheet.Rows.Item(1).font.bold = 1
        sheet.Rows.Item(1).horizontalAlignment = 3
        sheet.Columns.AutoFit()

        'Fait apparaître l'application et la maximise.'
        exApp.Visible = True
        exApp.WindowState = Excel.XlWindowState.xlMaximized

        'Clear 
        sheet = Nothing
        book = Nothing
        exApp = Nothing
    End Sub

End Module
