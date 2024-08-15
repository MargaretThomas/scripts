Sub ColorCellsByDate()
    Dim ws As Worksheet
    Dim lastRow As Long
    Dim dateCollection As Collection
    Dim colorIndex As Long
    Dim currentDate As Variant
    Dim rng As Range
    Dim cell As Range
    Dim i As Long
    Dim found As Boolean

    Set ws = ThisWorkbook.Sheets(ActiveSheet.name) ' This macro will only run on the currently selected sheet aka the active sheet.
    lastRow = ws.Cells(ws.Rows.Count, "A").End(xlUp).Row
    Set dateCollection = New Collection
    
    colorIndex = 1 ' Start color index (can range from 1 to 56)

    ' Iterate through the dates in column A
    For Each cell In ws.Range("A2:A" & lastRow)
        currentDate = cell.Value
        found = False
        
        ' Check if date is already in collection
        For i = 1 To dateCollection.Count
            If dateCollection(i)(0) = currentDate Then
                found = True
                Exit For
            End If
        Next i
        
        ' If date is not in the collection, add it
        If Not found Then
            dateCollection.Add Array(currentDate, colorIndex)
            colorIndex = colorIndex + 1
            If colorIndex > 56 Then colorIndex = 1 ' Reset color index if it exceeds 56
        End If

        ' Apply the color to the corresponding cells in column B
        For i = 1 To dateCollection.Count
            If dateCollection(i)(0) = currentDate Then
                Set rng = ws.Range("B" & cell.Row & ":B" & cell.Row)
                rng.Interior.ColorIndex = dateCollection(i)(1)
                Exit For
            End If
        Next i
    Next cell

    MsgBox "Cells have been color filled based on dates in column A.", vbInformation
End Sub
