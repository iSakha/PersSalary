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

        ' Write textbox values to labels
        writeDataToLabels()

        Dim currentEvent As New Events

        tblXl = wbXl.Sheets("Service").ListObjects("Events")
        currentEvent.ID = tblXl.DataBodyRange.Rows.Count
        currentEvent.SheetName = "event_" & currentEvent.ID

        currentEvent.writeToExcel(wbXl)
        eventCollection.Add(currentEvent)
        eventList_cmb.Items.Add(currentEvent.Name)

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
        writeDataToLabels()
    End Sub

    Private Sub newEvent_btn_Click(sender As Object, e As EventArgs) Handles newEvent_btn.Click
        clearMainForm()
    End Sub

    Private Sub daysQty_txt_TextChanged(sender As Object, e As EventArgs) Handles daysQty_txt.TextChanged
        If CInt(daysQty_txt.Text) <= 0 Then
            daysQty_txt.BackColor = Color.Red
        Else
            daysQty_txt.BackColor = Color.White
        End If
    End Sub

    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        appXL.DisplayAlerts = False
        wbXl.Close(SaveChanges:=True)
        appXL.Quit()
        appXL = Nothing
    End Sub

    Private Sub next1_btn_Click(sender As Object, e As EventArgs) Handles next1_btn.Click
        populateListBoxFromExcel()
    End Sub

    Private Sub addPers_btn_Click(sender As Object, e As EventArgs) Handles addPers_btn.Click
        MsgBox(ListBox1.SelectedItem)
    End Sub
End Class
