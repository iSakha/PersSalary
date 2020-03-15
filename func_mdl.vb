﻿Module func_mdl

    Sub openExcel(_path)

        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        appXL.Visible = True

        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        appXL.Visible = True

        Try
            wbXl = appXL.Workbooks.Open(_path & "\Salary.xlsx")
        Catch
            'MsgBox("File is already open")
            appXL.Quit()
            appXL = Nothing
        End Try

    End Sub

    Sub loadEventCollection()

        Dim itemQty, i As Integer

        tblXl = wbXl.Sheets("Service").ListObjects("Events")
        itemQty = tblXl.DataBodyRange.Rows.Count - 1
        mainForm.eventList_cmb.Items.Clear()
        For i = 1 To itemQty
            Dim myEvent As New Events
            myEvent.ID = tblXl.DataBodyRange.cells(i, 1).text
            myEvent.Name = tblXl.DataBodyRange.cells(i, 2).text
            myEvent.Location = tblXl.DataBodyRange.cells(i, 3).text
            myEvent.Manager = tblXl.DataBodyRange.cells(i, 4).text
            myEvent.Number = tblXl.DataBodyRange.cells(i, 5).text
            myEvent.StartDate = tblXl.DataBodyRange.cells(i, 6).text
            myEvent.EventDate = tblXl.DataBodyRange.cells(i, 7).text
            myEvent.EndDate = tblXl.DataBodyRange.cells(i, 8).text
            myEvent.DaysQty = tblXl.DataBodyRange.cells(i, 9).text
            myEvent.PersQty = tblXl.DataBodyRange.cells(i, 10).text
            myEvent.SheetName = "event_" & myEvent.ID

            eventCollection.Add(myEvent)
            mainForm.eventList_cmb.Items.Add(myEvent.Name)

        Next i

        'MsgBox(itemQty)

    End Sub



End Module