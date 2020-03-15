Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.DataTable
Imports System.Runtime.InteropServices

Public Class mainForm



    '==================================================================================================
    '==================================      TAB 1      ===============================================
    '==================================================================================================

    '-----------------------------  Click on eventOK_btn  ---------------------------------------------
    '--------------------------------------------------------------------------------------------------
    Private Sub eventOK_btn_Click(sender As Object, e As EventArgs) Handles eventOK_btn.Click

        Dim startDate, endDate As Date
        Dim daysQty As TimeSpan

        '   Path to application folder
        sPath = Application.StartupPath

        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        'appXL.Visible = True
        Try
            wbXl = appXL.Workbooks.Open(sPath & "\Salary.xlsx")
        Catch
            'MsgBox("File is already open")
            appXL.Quit()
            appXL = Nothing
            'For Each wb As Excel.Workbook In appXL.Workbooks
            '    If wb.Name = "Salary.xlsx" Then
            '        wbXl = wb
            '    End If
            'Next wb
            wbXl = appXL.Workbooks("Salary.xlsx")

        End Try

        ' Write textbox values to labels

        event_lbl.Text = event_txt.Text
        location_lbl.Text = location_txt.Text
        manager_lbl.Text = manager_txt.Text
        eventNumber_lbl.Text = eventNumber_txt.Text

        startDate = startDTP.Value
        endDate = endDTP.Value
        daysQty = endDate.Subtract(startDate)
        startDate_lbl.Text = startDTP.Text
        eventDate_lbl.Text = eventDTP.Text
        endDate_lbl.Text = endDTP.Text
        daysQty_txt.Text = CInt(daysQty.Days.ToString()) + 1
        daysQty_lbl.Text = daysQty_txt.Text

        Dim currentEvent As New Events

        tblXl = wbXl.Sheets("Service").ListObjects("Events")
        currentEvent.ID = tblXl.DataBodyRange.Rows.Count

        currentEvent.writeToExcel(wbXl)
        appXL.DisplayAlerts = False
        wbXl.Close(SaveChanges:=True)
        appXL.Quit()
        appXL = Nothing

    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        init()
        openExcel(sPath)
        loadEventCollection()
    End Sub

    Private Sub endDTP_ValueChanged(sender As Object, e As EventArgs) Handles endDTP.ValueChanged
        Dim startDate, endDate As Date
        Dim daysQty As TimeSpan
        startDate = startDTP.Value
        endDate = endDTP.Value
        daysQty = endDate.Subtract(startDate)
        startDate_lbl.Text = startDTP.Text
        eventDate_lbl.Text = eventDTP.Text
        endDate_lbl.Text = endDTP.Text
        daysQty_txt.Text = CInt(daysQty.Days.ToString()) + 1
        daysQty_lbl.Text = daysQty_txt.Text
    End Sub

    Private Sub eventList_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eventList_cmb.SelectedIndexChanged
        fillFormWithSelectedEvent()
    End Sub
End Class
