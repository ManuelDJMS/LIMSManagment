Imports System.Data.SqlClient
Public Class FrmImportarProspectos
    Dim maximo, maximo2 As Integer
    Public hojas As Integer
    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        libro()
        If b = True Then
            importarExcel(dgArticulos, 1)
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' hojas = 0
        Using conexion As New SqlConnection(cnt)
            conexion.Open()
            Dim r As String
            Dim transaction As SqlTransaction
            transaction = conexion.BeginTransaction("Sample")
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.Connection = conexion
            comando.Transaction = transaction

            For i = 0 To dgArticulos.Rows.Count - 2
                r = "insert into Empresas (FechaAlta , RazonSocial , Compania , DomicilioFiscal , DomicilioConsig , RFC, Ciudad , CiudadConsig 
                    , EdoConsig , EdooProv , CPFiscal , CPConsig , PaisConsig , Pais , TipoCliente , Mensajeria , Saldo , Credito, CondicionesClienteAdmon 
                    , ObservAdminpaq , Giro , MetodoPagoCte ) VALUES (getdate(),'" & dgArticulos.Item(0, i).Value & "',
                '" & (dgArticulos.Item(1, i).Value).Replace("'", "") & "','" & (dgArticulos.Item(2, i).Value).Replace("'", "") & "','" & dgArticulos.Item(3, i).Value & "'
                ,'" & (dgArticulos.Item(4, i).Value) & "','" & dgArticulos.Item(5, i).Value & "','" & dgArticulos.Item(6, i).Value & "'
                ,'" & dgArticulos.Item(7, i).Value & "','" & dgArticulos.Item(8, i).Value & "','" & dgArticulos.Item(9, i).Value & "'
                ,'" & (dgArticulos.Item(10, i).Value) & "','" & (dgArticulos.Item(11, i).Value) & "'
                ,'" & (dgArticulos.Item(12, i).Value) & "','Prospecto','" & (dgArticulos.Item(13, i).Value) & "'
                ," & (dgArticulos.Item(14, i).Value).Replace("NULL", 0) & ",'" & (dgArticulos.Item(15, i).Value) & "','" & (dgArticulos.Item(16, i).Value) & "'
                ,'" & (dgArticulos.Item(17, i).Value) & "'," & Val(dgArticulos.Item(18, i).Value) & " 
                ,'" & (dgArticulos.Item(19, i).Value) & "')"
                'MsgBox(r)
                comando.CommandText = r
                'comando.CommandTimeout = 50000
                comando.ExecuteNonQuery()
            Next
            'MsgBox("¡Primer Hoja Cargada Correctamente!", MsgBoxStyle.Information)
            'hojas = 1
            'importarExcel(dgArticulos, 2)
            'comando.CommandText = "select MAX(EquipID_FK) from [EquipmentVariable]"
            'lector2019 = comando.ExecuteReader
            'lector2019.Read()
            'If ((lector2019(0) Is DBNull.Value) OrElse (lector2019(0) Is Nothing)) Then
            '    maximo = 0
            '    maximo2 = 0
            'Else
            '    maximo = lector2019(0)
            '    maximo2 = lector2019(0)
            'End If
            'lector2019.Close()
            'For i = 0 To dgArticulos.Rows.Count - 2
            '    maximo = maximo + 1
            '    r = "insert into [MetAs_Live].[dbo].[EquipmentVariable](EquipID_FK,Field1,Field2,Field3,Field4,Field5,Field6,Value1,Value2,Value3,Value4,Value5,Value6)
            '             VALUES (" & maximo & "," & Val(dgArticulos.Item(1, i).Value) & "," & Val(dgArticulos.Item(2, i).Value) & "
            '             ," & Val(dgArticulos.Item(3, i).Value) & "," & Val(dgArticulos.Item(4, i).Value) & "," & Val(dgArticulos.Item(5, i).Value) & "," & Val(dgArticulos.Item(6, i).Value) & "
            '             ,'" & dgArticulos.Item(7, i).Value & "','" & dgArticulos.Item(8, i).Value & "','" & dgArticulos.Item(9, i).Value & "'
            '             ,'" & dgArticulos.Item(10, i).Value & "','" & (dgArticulos.Item(11, i).Value) & "','" & (dgArticulos.Item(12, i).Value) & "')"
            '    comando.CommandText = r
            '    comando.ExecuteNonQuery()
            'Next
            'MsgBox("¡Segunda Hoja Cargada Correctamente!", MsgBoxStyle.Information)
            'hojas = 2
            'importarExcel(dgArticulos, 3)
            ''--------------------------
            'If a = False Then
            '    For i = 0 To dgArticulos.Rows.Count - 2
            '        maximo2 = maximo2 + 1
            '        r = "insert into [MetAs_Live].[dbo].[SetupEquipmentServiceMapping] (EquipId,ServicesId,Price,CreatedOn)
            '    VALUES (" & maximo2 & "," & Val(dgArticulos.Item(2, i).Value) & "
            '             ," & CDbl(dgArticulos.Item(3, i).Value) & ", getdate())"
            '        comando.CommandText = r
            '        comando.ExecuteNonQuery()
            '    Next
            '    MsgBox("¡Tercer Hoja Cardada Correctamente!", MsgBoxStyle.Information)
            '    hojas = 3
            'End If
            'If hojas = 3 Then
            Try
                If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    transaction.Commit()
                    MsgBox("El Catálogo se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                Else
                    maximo = 0
                    maximo2 = 0
                    transaction.Rollback()
                    'MsgBox("Operación Cancelada", MsgBoxStyle.Critical)
                    'r = "DBCC CHECKIDENT(SetUpEquipment, RESEED, 1)"
                    'comando.CommandText = r
                    'comando.ExecuteNonQuery()
                    ''-----------------------------------------
                    'r = "DBCC CHECKIDENT(SetupEquipmentServiceMapping, RESEED, " & maximo & ")"
                    'comando.CommandText = r
                    'comando.ExecuteNonQuery()
                    'conexion.Close()
                    Me.Dispose()
                End If
            Catch ex As Exception
                MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                Try
                    transaction.Rollback()
                Catch ex1 As Exception
                    MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                End Try
            End Try
            conexion.Close()
            'Else
            '    MsgBox("Faltan hojas por exportar", MsgBoxStyle.Critical, "Error interno del Sistema")
            '    importarExcel(dgArticulos, 3)
            'End If
        End Using
    End Sub
End Class