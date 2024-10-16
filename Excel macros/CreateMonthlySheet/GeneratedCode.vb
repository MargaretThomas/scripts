Sub CreateMonthlySheet()
    Dim ws As Worksheet
    Dim sheetName As String
    Dim startDate As Date
    Dim endDate As Date
    Dim currentRow As Integer
    Dim day As Date
    Dim i As Integer
    Dim tbl As ListObject
    Dim tableRange As Range
    
    ' Define the sheet name as "Month Year"
    sheetName = Format(Date, "mmmm yyyy")
    
    ' Check if a sheet with the same name already exists
    On Error Resume Next
    Set ws = ThisWorkbook.Worksheets(sheetName)
    On Error GoTo 0
    
    ' If the sheet does not exist, create it
    If ws Is Nothing Then
        Set ws = ThisWorkbook.Worksheets.Add
        ws.Name = sheetName
    Else
        MsgBox "Sheet for " & sheetName & " already exists."
        Exit Sub
    End If
    
    ' Define the start and end dates for the current month
    startDate = DateSerial(Year(Date), Month(Date), 1)
    endDate = DateSerial(Year(Date), Month(Date) + 1, 0)
    
    ' Set up the table headers
    ws.Cells(1, 1).Value = "Date"
    ws.Cells(1, 2).Value = "Task"
    
    ' Initialize the row counter
    currentRow = 2
    
    ' Loop through each day of the month and add 5 rows per day
    For day = startDate To endDate
        For i = 1 To 5
            ws.Cells(currentRow, 1).Value = Format(day, "dddd dd-mmm-yyyy")
            ws.Cells(currentRow, 1).HorizontalAlignment = xlRight
            currentRow = currentRow + 1
        Next i
    Next day
    
    ' Define the range of the table (headers + data)
    Set tableRange = ws.Range("A1:B" & currentRow - 1)
    
    ' Create the table and apply the "Dark Teal, Table Style Medium 2" style
    Set tbl = ws.ListObjects.Add(xlSrcRange, tableRange, , xlYes)
    tbl.TableStyle = "TableStyleMedium2"
    
    ' Set the column widths
    ws.Columns("A").ColumnWidth = 22.33
    ws.Columns("B").ColumnWidth = 77.88
    
    ' Auto-fit the columns for better readability (if needed)
    ' ws.Columns("A:B").AutoFit  ' Uncomment if auto-fitting is desired in addition to set width
End Sub