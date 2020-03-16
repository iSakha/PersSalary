Module func_mdl

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

    Sub fillFormWithSelectedEvent()
        Dim sDate As String

        mainForm.event_txt.Text = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).Name
        mainForm.location_txt.Text = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).Location
        mainForm.manager_txt.Text = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).Manager
        mainForm.eventNumber_txt.Text = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).Number
        sDate = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).StartDate
        sDate = convertToSysDate(sDate)
        mainForm.startDTP.Value = sDate
        sDate = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).EventDate
        sDate = convertToSysDate(sDate)
        mainForm.eventDTP.Value = sDate
        sDate = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).EndDate
        sDate = convertToSysDate(sDate)
        mainForm.endDTP.Value = sDate
        mainForm.daysQty_txt.Text = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).DaysQty
        mainForm.persQty_txt.Text = eventCollection.Item(mainForm.eventList_cmb.SelectedIndex + 1).PersQty

    End Sub


    Function convertToSysDate(str) As String

        Dim arr() As String

        arr = Split(str, ".", 3)

        convertToSysDate = arr(1) & "/" & arr(0) & "/" & arr(2)

    End Function

    Sub clearMainForm()

        mainForm.event_txt.Text = ""
        mainForm.location_txt.Text = ""
        mainForm.manager_txt.Text = ""
        mainForm.eventNumber_txt.Text = ""
        mainForm.startDTP.Value = Now()
        mainForm.eventDTP.Value = Now()
        mainForm.endDTP.Value = Now()
        mainForm.daysQty_txt.Text = ""
        mainForm.persQty_txt.Text = ""

    End Sub

    Sub writeDataToLabels()

        Dim startDate, endDate As Date
        Dim daysQty As TimeSpan

        mainForm.event_lbl.Text = mainForm.event_txt.Text
        mainForm.location_lbl.Text = mainForm.location_txt.Text
        mainForm.manager_lbl.Text = mainForm.manager_txt.Text
        mainForm.eventNumber_lbl.Text = mainForm.eventNumber_txt.Text

        startDate = mainForm.startDTP.Value
        endDate = mainForm.endDTP.Value
        daysQty = endDate.Subtract(startDate)
        mainForm.startDate_lbl.Text = mainForm.startDTP.Text
        mainForm.eventDate_lbl.Text = mainForm.eventDTP.Text
        mainForm.endDate_lbl.Text = mainForm.endDTP.Text
        mainForm.daysQty_txt.Text = CInt(daysQty.Days.ToString()) + 1
        mainForm.daysQty_lbl.Text = mainForm.daysQty_txt.Text

    End Sub

    Sub populateListBoxFromExcel()
        Dim i As Integer
        tblXl = wbXl.Sheets("Service").ListObjects("Persons")
        For i = 1 To tblXl.databodyrange.rows.count
            mainForm.ListBox1.Items.Add(tblXl.databodyrange.cells(i, 1).text)
        Next i
    End Sub

End Module
