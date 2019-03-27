Imports System.Data.SqlClient
Public Class FrmImportar
    Dim maximo, maximo2 As Integer
    Public hojas As Integer
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        hojas = 0
        Using conexion As New SqlConnection(cnt)
            conexion.Open()
            Dim r As String
            Dim transaction As SqlTransaction
            transaction = conexion.BeginTransaction("Sample")
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.Connection = conexion
            comando.Transaction = transaction
            For i = 0 To dgArticulos.Rows.Count - 2
                r = "insert into [MetAs_Live].[dbo].[SetUpEquipment](InstrumentId,EquipmentName,Model,Accuracy,Mfr,SrlNo,Dept,Location,CALInterval,CALCycle,
                CALDue,ShortNotes,IsActive,OnSite,IEEEPort,CustomerPort,RS232Port,Subcontract,Automated,DtaIncluded,
                PriceCode,Catagory,Class,CreatedBy,CreatedOn,
                ModifiedBy,ModifiedOn,ItemNumber,AdditionalSepcification,TurnAroundTime,
                ApproxWeight,RelationItemNo,CalibrationMethod,Standardization,Accreditation,
                ServiceDescription,AttachmentName,Attachment,Scale1Accuracy,Scale2Accuracy,
                Scale1Resolution,Scale2Resolution,Scale1Unit,Scale2Unit,Uncertainity)VALUES ('" & dgArticulos.Item(1, i).Value & "','
                " & (dgArticulos.Item(2, i).Value).Replace("'", "") & "','" & (dgArticulos.Item(3, i).Value).Replace("'", "") & "','" & dgArticulos.Item(4, i).Value & "'
                ,'" & (dgArticulos.Item(5, i).Value) & "','" & dgArticulos.Item(6, i).Value & "','" & dgArticulos.Item(7, i).Value & "'
                ,'" & dgArticulos.Item(8, i).Value & "'," & Val(dgArticulos.Item(9, i).Value) & ",'" & dgArticulos.Item(10, i).Value & "'
                ,'" & (dgArticulos.Item(11, i).Value) & "','" & (dgArticulos.Item(12, i).Value) & "'
                ,'" & (dgArticulos.Item(13, i).Value) & "','" & (dgArticulos.Item(14, i).Value) & "'
                ,'" & (dgArticulos.Item(15, i).Value) & "','" & (dgArticulos.Item(16, i).Value) & "'
                ,'" & (dgArticulos.Item(17, i).Value) & "','" & (dgArticulos.Item(18, i).Value) & "','" & (dgArticulos.Item(19, i).Value) & "'
                ,'" & (dgArticulos.Item(20, i).Value) & "','" & (dgArticulos.Item(21, i).Value) & "','" & (dgArticulos.Item(22, i).Value) & "'
                ,'" & (dgArticulos.Item(23, i).Value) & "','" & (dgArticulos.Item(24, i).Value) & "',getdate(),'" & (dgArticulos.Item(26, i).Value) & "',getdate(),'" & (dgArticulos.Item(28, i).Value).Replace("'", "") & "'
                ,'" & dgArticulos.Item(29, i).Value & "','" & (dgArticulos.Item(30, i).Value) & "','" & dgArticulos.Item(31, i).Value & "'
                ,'" & (dgArticulos.Item(32, i).Value) & "','" & (dgArticulos.Item(33, i).Value) & "','" & dgArticulos.Item(34, i).Value & "'
                ,'" & (dgArticulos.Item(35, i).Value) & "','" & (dgArticulos.Item(36, i).Value).Replace("≠", "") & "','" & (dgArticulos.Item(37, i).Value) & "'
                ,CONVERT(VARBINARY(25), '0x9473FBCCBC01AF',1),'" & (dgArticulos.Item(39, i).Value) & "','" & (dgArticulos.Item(40, i).Value) & "'
                ,'" & (dgArticulos.Item(41, i).Value) & "','" & (dgArticulos.Item(42, i).Value) & "','" & (dgArticulos.Item(43, i).Value) & "'
                ,'" & (dgArticulos.Item(44, i).Value) & "','" & (dgArticulos.Item(45, i).Value) & "')"
                comando.CommandText = r
                comando.ExecuteNonQuery()
            Next
            MsgBox("¡Primer Hoja Cargada Correctamente!", MsgBoxStyle.Information)
            hojas = 1
            importarExcel(dgArticulos, 2)
            comando.CommandText = "select MAX(EquipID_FK) from [EquipmentVariable]"
            lector2019 = comando.ExecuteReader
            lector2019.Read()
            If ((lector2019(0) Is DBNull.Value) OrElse (lector2019(0) Is Nothing)) Then
                maximo = 0
                maximo2 = 0
            Else
                maximo = lector2019(0)
                maximo2 = lector2019(0)
            End If
            lector2019.Close()
            For i = 0 To dgArticulos.Rows.Count - 2
                maximo = maximo + 1
                r = "insert into [MetAs_Live].[dbo].[EquipmentVariable](EquipID_FK,Field1,Field2,Field3,Field4,Field5,Field6,Value1,Value2,Value3,Value4,Value5,Value6)
                         VALUES (" & maximo & "," & Val(dgArticulos.Item(1, i).Value) & "," & Val(dgArticulos.Item(2, i).Value) & "
                         ," & Val(dgArticulos.Item(3, i).Value) & "," & Val(dgArticulos.Item(4, i).Value) & "," & Val(dgArticulos.Item(5, i).Value) & "," & Val(dgArticulos.Item(6, i).Value) & "
                         ,'" & dgArticulos.Item(7, i).Value & "','" & dgArticulos.Item(8, i).Value & "','" & dgArticulos.Item(9, i).Value & "'
                         ,'" & dgArticulos.Item(10, i).Value & "','" & (dgArticulos.Item(11, i).Value) & "','" & (dgArticulos.Item(12, i).Value) & "')"
                comando.CommandText = r
                comando.ExecuteNonQuery()
            Next
            MsgBox("¡Segunda Hoja Cargada Correctamente!", MsgBoxStyle.Information)
            hojas = 2
            importarExcel(dgArticulos, 3)
            '--------------------------
            If a = False Then
                For i = 0 To dgArticulos.Rows.Count - 2
                    maximo2 = maximo2 + 1
                    r = "insert into [MetAs_Live].[dbo].[SetupEquipmentServiceMapping] (EquipId,ServicesId,Price,CreatedOn)
                VALUES (" & maximo2 & "," & Val(dgArticulos.Item(2, i).Value) & "
                         ," & CDbl(dgArticulos.Item(3, i).Value) & ", getdate())"
                    comando.CommandText = r
                    comando.ExecuteNonQuery()
                Next
                MsgBox("¡Tercer Hoja Cardada Correctamente!", MsgBoxStyle.Information)
                hojas = 3
            End If
            If hojas = 3 Then
                Try
                    If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        transaction.Commit()
                        MsgBox("El Catálogo se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                    Else
                        maximo = 0
                        maximo2 = 0
                        transaction.Rollback()
                        MsgBox("Operación Cancelada", MsgBoxStyle.Critical)
                        conexion.Close()
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
            Else
                MsgBox("Faltan hojas por exportar", MsgBoxStyle.Critical, "Error interno del Sistema")
                importarExcel(dgArticulos, 3)
            End If
        End Using
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        MsgBox("Para guardar correctamente los datos de los Artículos es necesario insertar las 3 hojas del archivo de Excel ", MsgBoxStyle.Information)
        libro()
        If b = True Then
            importarExcel(dgArticulos, 1)
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If

    End Sub
End Class