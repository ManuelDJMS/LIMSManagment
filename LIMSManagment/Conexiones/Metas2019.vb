Imports System.Data.SqlClient
Module Metas2019
    Public conexion2019 As SqlConnection              ''Base de datos METASINF-2019
    Public comando2019 As SqlCommand
    Public lector2019 As SqlDataReader
    Public cnt As String = "Data Source=DATABASESERVER\COMPAC; Initial Catalog=MetAs_Live-pruebas; User Id=sa; Password=Contpaq1; Integrated Security=false"
    Sub MetodoMetasInf2019()
        Try
            conexion2019 = New SqlConnection("Data Source=DATABASESERVER\COMPAC; Initial Catalog=MetAs_Live-pruebas; User Id=sa; Password=Contpaq1; Integrated Security=false")
            conexion2019.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
End Module
