Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
'Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Module Importar
    Public myFileDialog As New OpenFileDialog()
    Public b, a As Boolean

    Sub libro()
        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            b = True
        Else
            b = False
        End If
    End Sub

    Sub importarExcel(ByVal tabla As DataGridView, ByVal bandera As Integer)
        Dim xSheet As String = ""
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection
            If (bandera = 1) Then
                xSheet = InputBox("Digite el nombre de la PRIMER Hoja que desea importar", "IMPORTACIÓN")
            ElseIf (bandera = 2) Then
                xSheet = InputBox("Digite el nombre de la SEGUNDA Hoja que desea importar", "IMPORTACIÓN")
            Else
                xSheet = InputBox("Digite el nombre de la TERCER Hoja que desea importar", "IMPORTACIÓN")
            End If

            If xSheet.ToString <> "" Then
                MsgBox("dentro IF")
                conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")
                Try
                    da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)
                    conn.Open()
                    da.Fill(ds, "MyData")
                    dt = ds.Tables("MyData")
                    tabla.DataSource = ds
                    tabla.DataMember = "MyData"
                Catch ex As Exception
                    MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
                Finally
                    conn.Close()
                End Try
            Else
                a = True
            End If
        End If
        'MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub
End Module

