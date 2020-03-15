Public Class Events

    Public ID As Integer
    Public Name As String
    Public Location As String
    Public Manager As String
    Public Number As String
    Public StartDate As String
    Public EventDate As String
    Public EndDate As String
    Public DaysQty As Integer
    Public PersQty As Integer
    Public SheetName As String

    Public Sub New()

        Me.ID = 1
        Me.Name = mainForm.event_txt.Text
        Me.Location = mainForm.location_txt.Text
        Me.Manager = mainForm.manager_txt.Text
        Me.Number = mainForm.eventNumber_txt.Text
        Me.StartDate = mainForm.startDTP.Text
        Me.EventDate = mainForm.eventDTP.Text
        Me.EndDate = mainForm.endDTP.Text
        Me.DaysQty = CInt(mainForm.daysQty_txt.Text)
        On Error Resume Next
        Me.PersQty = CInt(mainForm.persQty_txt.Text)
        Me.SheetName = "event_" & Me.ID

        'eventCollection.Add(Me)

    End Sub

    Public Sub writeToExcel(_wbXl)

        tblXl = _wbXl.Sheets("Service").Listobjects("Events")

        tblXl.databodyrange.cells(Me.ID, 1).value = Me.ID
        tblXl.databodyrange.cells(Me.ID, 2).value = Me.Name
        tblXl.databodyrange.cells(Me.ID, 3).value = Me.Location
        tblXl.databodyrange.cells(Me.ID, 4).value = Me.Manager
        tblXl.databodyrange.cells(Me.ID, 5).value = Me.Number
        tblXl.databodyrange.cells(Me.ID, 6).value = Me.StartDate
        tblXl.databodyrange.cells(Me.ID, 7).value = Me.EventDate
        tblXl.databodyrange.cells(Me.ID, 8).value = Me.EndDate
        tblXl.databodyrange.cells(Me.ID, 9).value = Me.DaysQty
        tblXl.databodyrange.cells(Me.ID, 10).value = Me.PersQty
        tblXl.databodyrange.cells(Me.ID, 11).value = Me.SheetName

        tblXl.ListRows.add

    End Sub
End Class
