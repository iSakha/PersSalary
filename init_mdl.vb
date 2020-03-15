Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.DataTable
Imports System.Runtime.InteropServices

Module init_mdl

    Public sPath As String
    Public appXL As New Excel.Application
    Public wbXl As Excel.Workbook
    Public shXL As Excel.Worksheet
    Public rngXL As Excel.Range
    Public tblXl As Object

    Public eventCollection As New Collection
    Public persCollection As New Collection
    Sub init()

        'Path to application folder
        sPath = Application.StartupPath

    End Sub


End Module
