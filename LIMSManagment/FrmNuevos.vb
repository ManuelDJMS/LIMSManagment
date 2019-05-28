Imports System.Data.SqlClient
Public Class FrmNuevos
    Dim r As String
    Dim maximo, maximo2 As Integer

    Private Sub FrmNuevos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            r = "select distinct * from (
	            select NoCatalogo, CONVERT( VARCHAR(MAX),Instrumento) as Instrumentos, isnull(ClaseDeExactitud,'-') as Exactitud, isnull(Consecutivo,0) as Depto, isnull(CONVERT( VARCHAR(MAX),MetododeCalibracion),'-') as MetododeCalobracion, isnull(CONVERT( VARCHAR(MAX),ResultadosInforme),'-') as Resultados, isnull(NormasdeReferencia,'-') as Referencia, 
	            isnull(Acreditamiento,'-') as Acreditamiento, isnull(PuntosdeCalibracion,'-') as Puntos, isnull(PatronesReferencia,'-') as Patrones, isnull(Trazabilidad,'-') as Trazabilidad, isnull(Magnitud,'-') as Magnitud, isnull(PrecioBase,0) as Precio from 
	            [METASINF-2019].[dbo].[Catalogo-Calibracion-Laboratorios] as x1 inner join [METASINF-2019].[dbo].[Magnitudes] as x2  on x1.Laboratorio=x2.Laboratorio
	            union 
	            select NoCatalogo, CONVERT( VARCHAR(MAX),Instrumento) as Instrumentos, isnull(ClaseDeExactitud,'-') as Exactitud, isnull(Consecutivo,0) as Depto, isnull(CONVERT( VARCHAR(MAX),MetododeCalibracion),'-') as MetododeCalobracion, isnull(CONVERT( VARCHAR(MAX),ResultadosInforme),'-') as Resultados, isnull(NormasdeReferencia,'-') as Referencia, 
	            isnull(Acreditamiento,'-') as Acreditamiento, isnull(PuntosdeCalibracion,'-') as Puntos, isnull(PatronesReferencia,'-') as Patrones, isnull(Trazabilidad,'-') as Trazabilidad, isnull(Magnitud,'-') as Magnitud, isnull(PrecioBase,0) as Precio from 
	            [METASINF-2018].[dbo].[Catalogo-Calibracion-Laboratorios] as x1 inner join [METASINF-2019].[dbo].[Magnitudes] as x2  on x1.Laboratorio=x2.Laboratorio
	            union
                select NoCatalogo, CONVERT( VARCHAR(MAX),Instrumento) as Instrumentos, isnull(ClaseDeExactitud,'-') as Exactitud, isnull(Consecutivo,0) as Depto, isnull(CONVERT( VARCHAR(MAX),MetododeCalibracion),'-') as MetododeCalobracion, isnull(CONVERT( VARCHAR(MAX),ResultadosInforme),'-') as Resultados, isnull(NormasdeReferencia,'-') as Referencia, 
	            isnull(Acreditamiento,'-') as Acreditamiento, isnull(PuntosdeCalibracion,'-') as Puntos, isnull(PatronesReferencia,'-') as Patrones, isnull(Trazabilidad,'-') as Trazabilidad, isnull(Magnitud,'-') as Magnitud, isnull(PrecioBase,0) as Precio from 
	            [METASINF-2017].[dbo].[Catalogo-Calibracion-Laboratorios] as x1 inner join [METASINF-2017].[dbo].[Magnitudes] as x2  on x1.Laboratorio=x2.Laboratorio
	            union
	            select NoCatalogo, CONVERT( VARCHAR(MAX),Instrumento) as Instrumentos, isnull(ClaseDeExactitud,'-') as Exactitud, isnull(Consecutivo,0) as Depto, isnull(CONVERT( VARCHAR(MAX),MetododeCalibracion),'-') as MetododeCalobracion, isnull(CONVERT( VARCHAR(MAX),ResultadosInforme),'-') as Resultados, isnull(NormasdeReferencia,'-') as Referencia, 
	            isnull(Acreditamiento,'-') as Acreditamiento, isnull(PuntosdeCalibracion,'-') as Puntos, isnull(PatronesReferencia,'-') as Patrones, isnull(Trazabilidad,'-') as Trazabilidad, isnull(Magnitud,'-') as Magnitud, isnull(PrecioBase,0) as Precio from 
	            [METASINF-2016].[dbo].[Catalogo-Calibracion-Laboratorios] as x1 inner join [METASINF-2017].[dbo].[Magnitudes] as x2  on x1.Laboratorio=x2.Laboratorio
	            union
	            select NoCatalogo, CONVERT( VARCHAR(MAX),Instrumento) as Instrumentos, isnull(ClaseDeExactitud,'-') as Exactitud, isnull(Consecutivo,0) as Depto, isnull(CONVERT( VARCHAR(MAX),MetododeCalibracion),'-') as MetododeCalobracion, isnull(CONVERT( VARCHAR(MAX),ResultadosInforme),'-') as Resultados, isnull(NormasdeReferencia,'-') as Referencia, 
	            isnull(Acreditamiento,'-') as Acreditamiento, isnull(PuntosdeCalibracion,'-') as Puntos, isnull(PatronesReferencia,'-') as Patrones, isnull(Trazabilidad,'-') as Trazabilidad, isnull(Magnitud,'-') as Magnitud, isnull(PrecioBase,0) as Precio from 
	            [METASINF-2015].[dbo].[Catalogo-Calibracion-Laboratorios] as x1 inner join [METASINF-2017].[dbo].[Magnitudes] as x2  on x1.Laboratorio=x2.Laboratorio
              ) x"
            comandoMetasCotizador.CommandText = r
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgArticulos.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6), lectorMetasCotizador(7), lectorMetasCotizador(8), lectorMetasCotizador(9), lectorMetasCotizador(10), lectorMetasCotizador(11), lectorMetasCotizador(12))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Using conexion As New SqlConnection(cnt)
            conexion.Open()
            Dim r As String
            Dim transaction As SqlTransaction
            transaction = conexion.BeginTransaction("Sample")
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.Connection = conexion
            comando.Transaction = transaction
            '-----------------------Sacar el ultimo registro----------------------------------------
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
                r = "if exists(select ItemNumber from [SetUpEquipment] where ItemNumber='" & (dgArticulos.Item(0, i).Value).Replace("'", "") & "') begin update [SetUpEquipmentServiceMapping] set Price=" & CDbl(dgArticulos.Item(12, i).Value) & " where EquipId IN (SELECT [SetupEquipmentServiceMapping].EquipId
                    FROM  [SetUpEquipment] inner join [SetUpEquipmentServiceMapping] on [SetUpEquipment].EquipId=[SetUpEquipmentServiceMapping].EquipId
                    WHERE ItemNumber='" & (dgArticulos.Item(0, i).Value).Replace("'", "") & "'); 
                    end else begin insert into [SetUpEquipment](InstrumentId,EquipmentName,Model,Accuracy,Mfr,SrlNo,Dept,Location,CALInterval,CALCycle,CALDue,ShortNotes,IsActive,OnSite,IEEEPort,CustomerPort,RS232Port,
                    Subcontract, Automated, DtaIncluded,PriceCode,Catagory,Class,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,ItemNumber,AdditionalSepcification,TurnAroundTime,ApproxWeight,RelationItemNo,
                    CalibrationMethod,Standardization,Accreditation,ServiceDescription,AttachmentName,Attachment,Scale1Accuracy,Scale2Accuracy,Scale1Resolution,Scale2Resolution,Scale1Unit,Scale2Unit,Uncertainity, 
                    Folio)VALUES (N'','" & (dgArticulos.Item(1, i).Value).Replace("'", "") & "','N/A',N'" & (dgArticulos.Item(2, i).Value) & "','N/A','N/A', " & (dgArticulos.Item(3, i).Value) & ",
                    '-',0,'N/A','-','-','Y','-','N','N','N','N','N','N','-','-','-','Sistemas',getdate(),'-',getdate(),'" & (dgArticulos.Item(0, i).Value).Replace("'", "") & "','N/A','10','N/A'
                    ,'N/A',N'" & (dgArticulos.Item(4, i).Value).Replace("'", "") & "',N'" & (dgArticulos.Item(6, i).Value).Replace("'", "") & "',N'" & (dgArticulos.Item(7, i).Value).Replace("'", "") & "',N'" & (dgArticulos.Item(5, i).Value).Replace("'", "") & "','-'
                    ,CONVERT(VARBINARY(25), '0x9473FBCCBC01AF',1),'-','-','-','-','-','-','-',0); end"
                comando.CommandText = r
                comando.ExecuteNonQuery()
                '--------------------------
                maximo = maximo + 1
                r = "insert into [EquipmentVariable](EquipID_FK,Field1,Field2,Field3,Field4,Field5,Field6,Value1,Value2,Value3,Value4,Value5,Value6)
                             VALUES (" & maximo & ",1,0,0,0,0,0
                             ,'" & (dgArticulos.Item(8, i).Value).replace("'", "") & "','" & (dgArticulos.Item(9, i).Value).replace("'", "") & "','" & (dgArticulos.Item(10, i).Value).replace("'", "") & "','" & (dgArticulos.Item(11, i).Value).replace("'", "") & "','-','-')"

                comando.CommandText = r
                comando.ExecuteNonQuery()
                '--------------------------
                maximo2 = maximo2 + 1
                r = "insert into [SetupEquipmentServiceMapping] (EquipId,ServicesId,Price,CreatedOn)
                    VALUES (" & maximo2 & ",1
                             ," & CDbl(dgArticulos.Item(12, i).Value) & ", getdate())"
                comando.CommandText = r
                comando.ExecuteNonQuery()
            Next
            MsgBox("¡Primer Hoja Cargada Correctamente!", MsgBoxStyle.Information)
            Try
                If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    transaction.Commit()
                    MsgBox("El Catálogo se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                Else
                    maximo = 0
                    maximo2 = 0
                    transaction.Rollback()
                    MsgBox("Operación Cancelada", MsgBoxStyle.Critical)
                    r = "DBCC CHECKIDENT(SetUpEquipment, RESEED, 1)"
                    comando.CommandText = r
                    comando.ExecuteNonQuery()
                    '-----------------------------------------
                    r = "DBCC CHECKIDENT(SetupEquipmentServiceMapping, RESEED, " & maximo & ")"
                    comando.CommandText = r
                    comando.ExecuteNonQuery()
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
            'Else
            '    MsgBox("Faltan hojas por exportar", MsgBoxStyle.Critical, "Error interno del Sistema")
            '    importarExcel(dgArticulos, 3)
            'End If
        End Using
    End Sub
End Class