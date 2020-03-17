Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.DataTable
Imports System.Runtime.InteropServices

Public Class mainForm
    '==================================================================================================
    '==================================     Form load     =============================================
    '==================================================================================================

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        init()
        openExcel(sPath)
        loadEventCollection()
    End Sub

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

    '-----------------------------  Calculate days quantity  ------------------------------------------
    '--------------------------------------------------------------------------------------------------

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

    Private Sub daysQty_txt_TextChanged(sender As Object, e As EventArgs) Handles daysQty_txt.TextChanged
        Dim sDaysQty As String
        Dim iDaysQty As Integer

        sDaysQty = daysQty_txt.Text
        iDaysQty = CInt(daysQty_txt.Text)
        If iDaysQty <= 0 Then
            daysQty_txt.BackColor = Color.Red
        Else
            daysQty_txt.BackColor= Color.White
        End If
    End Sub
    '-----------------------------  Create and load events   ------------------------------------------
    '--------------------------------------------------------------------------------------------------
    Private Sub eventList_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eventList_cmb.SelectedIndexChanged
        fillFormWithSelectedEvent()
        writeDataToLabels()
    End Sub

    Private Sub newEvent_btn_Click(sender As Object, e As EventArgs) Handles newEvent_btn.Click
        clearMainForm()
    End Sub


    '-----------------------------   Click on NEXT_btn   ----------------------------------------------
    '--------------------------------------------------------------------------------------------------
    Private Sub next1_btn_Click(sender As Object, e As EventArgs) Handles next1_btn.Click
        populateListBoxFromExcel()
        TabControl1.SelectTab(1)
    End Sub

    '==================================================================================================
    '==================================      TAB 2      ===============================================
    '==================================================================================================

    Private Sub addPers_btn_Click(sender As Object, e As EventArgs) Handles addPers_btn.Click
        For Each it As String In ListBox1.SelectedItems
            'MsgBox(it)
            addPers(it)
        Next
        ' remove selected items
        Do While (ListBox1.SelectedItems.Count > 0)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Loop
    End Sub

    Private Sub subtractPers_btn_Click(sender As Object, e As EventArgs) Handles subtractPers_btn.Click
        For Each it As String In ListBox2.SelectedItems
            'MsgBox(it)
            subtractPers(it)
        Next
        ' remove selected items
        Do While (ListBox2.SelectedItems.Count > 0)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        Loop

    End Sub

    Private Sub next2_btn_Click(sender As Object, e As EventArgs) Handles next2_btn.Click
        For Each it As String In ListBox2.Items
            'MsgBox(it)
            ListBox3.Items.Add(it)
            TabControl1.SelectTab(2)

            Dim person As New Person

            person.Name = it
            persCollection.Add(person)

        Next
    End Sub
    '==================================================================================================
    '==================================     Form close     ============================================
    '==================================================================================================

    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        appXL.DisplayAlerts = False
        wbXl.Close(SaveChanges:=True)
        appXL.Quit()
        appXL = Nothing
    End Sub

    Private Sub startHoursUpDown_ValueChanged(sender As Object, e As EventArgs) Handles startHoursUpDown.ValueChanged
        If startHoursUpDown.Value = 13 Then
            startHoursUpDown.Value = 0
        End If

        Dim someTime As Date
        Dim someHour, someMinute As Integer
        someHour = startHoursUpDown.Value
        someMinute = startMinutesUpDown.Value

        'startJobDTP.Value = someTime

        'someHour = Hour(someTime)

    End Sub

    Private Sub startMinutesUpDown_ValueChanged(sender As Object, e As EventArgs) Handles startMinutesUpDown.ValueChanged
        If startMinutesUpDown.Value = 60 Then
            startMinutesUpDown.Value = 0
        End If
    End Sub

    Private Sub endHoursUpDown_ValueChanged(sender As Object, e As EventArgs) Handles endHoursUpDown.ValueChanged
        If endHoursUpDown.Value = 13 Then
            endHoursUpDown.Value = 0
        End If
    End Sub

    Private Sub endMinutesUpDown_ValueChanged(sender As Object, e As EventArgs) Handles endMinutesUpDown.ValueChanged
        If endMinutesUpDown.Value = 60 Then
            endMinutesUpDown.Value = 0
        End If
    End Sub
End Class
