Imports System.Data.SqlClient
Public Class FrmMantenimiento
    Private Sub FrmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        MetodoMetasInf2019()
        comando2019 = conexion2019.CreateCommand
        Dim r As String
        r = "Select [SetUpEquipment].EquipId, EquipmentName, Model, Accuracy, Mfr, Dept, Location, CALinterval, CALCycle,CALDue,ShortNotes,IsActive,OnSite, IEEEPort, CustomerPort,
             RS232Port,Subcontract,Automated,DtaIncluded,Catagory,Class,ItemNumber, AdditionalSepcification,TurnAroundTime,ApproxWeight,RelationItemNo,CalibrationMethod,
             Standardization,Accreditation,ServiceDescription,Scale1Accuracy,Scale2Accuracy, Scale1Resolution, Scale2Resolution,Scale1Unit,Scale2Unit,Uncertainity,
             ServicesId,Price,Field1,Field2,Field3,Field4,Field5,Field6,Value1,Value2,Value3,Value4,Value5,Value6
             from [SetUpEquipment] inner join SetUpEquipmentServiceMapping on [SetUpEquipment].EquipId=SetUpEquipmentServiceMapping.EquipId
             inner join EquipmentVariable on SetUpEquipment.EquipId=EquipmentVariable.EquipID_FK"
        comando2019.CommandText = r
        lector2019 = comando2019.ExecuteReader
        While lector2019.Read
            dgArticulos.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8), lector2019(9), lector2019(10), lector2019(11), lector2019(12), lector2019(13), lector2019(14), lector2019(15), lector2019(16), lector2019(17), lector2019(18), lector2019(19), lector2019(20), lector2019(21), lector2019(22), lector2019(23), lector2019(24), lector2019(25), lector2019(26), lector2019(27), lector2019(28), lector2019(29), lector2019(30), lector2019(31), lector2019(32), lector2019(33), lector2019(34), lector2019(35), lector2019(36), lector2019(37), lector2019(38), lector2019(39), lector2019(40), lector2019(41), lector2019(42), lector2019(43), lector2019(44), lector2019(45), lector2019(46), lector2019(47), lector2019(48), lector2019(49))
        End While
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub TextNum_TextChanged(sender As Object, e As EventArgs) Handles TextNum.TextChanged
        Try
            MetodoMetasInf2019()
            comando2019 = conexion2019.CreateCommand
            Dim r As String
            dgArticulos.Rows.Clear()
            If dgArticulos.Rows.Count < 2 Then
            Else
                dgArticulos.Rows.RemoveAt(dgArticulos.CurrentRow.Index)
            End If
            r = "Select [SetUpEquipment].EquipId, EquipmentName, Model, Accuracy, Mfr, Dept, Location, CALinterval, CALCycle,CALDue,ShortNotes,IsActive,OnSite, IEEEPort, CustomerPort,
            RS232Port,Subcontract,Automated,DtaIncluded,Catagory,Class,ItemNumber,TurnAroundTime,ApproxWeight,RelationItemNo,CalibrationMethod,
            Standardization,Accreditation,ServiceDescription,Scale1Accuracy,Scale2Accuracy, Scale1Resolution, Scale2Resolution,Scale1Unit,Scale2Unit,Uncertainity,
            ServicesId,Price,Field1,Field2,Field3,Field4,Field5,Field6,Value1,Value2,Value3,Value4,Value5,Value6
            from [SetUpEquipment] inner join SetUpEquipmentServiceMapping on [SetUpEquipment].EquipId=SetUpEquipmentServiceMapping.EquipId
            inner join EquipmentVariable on SetUpEquipment.EquipId=EquipmentVariable.EquipID_FK where ItemNumber LIKE  '" & TextNum.Text & "%' and EquipmentName like '" & TextNombre.Text & "%' 
            and Model like '" & TextModelo.Text & "%' and Mfr like '" & TextMarca.Text & "%'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read
                dgArticulos.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8), lector2019(9), lector2019(10), lector2019(11), lector2019(12), lector2019(13), lector2019(14), lector2019(15), lector2019(16), lector2019(17), lector2019(18), lector2019(19), lector2019(20), lector2019(21), lector2019(22), lector2019(23), lector2019(24), lector2019(25), lector2019(26), lector2019(27), lector2019(28), lector2019(29), lector2019(30), lector2019(31), lector2019(32), lector2019(33), lector2019(34), lector2019(35), lector2019(36), lector2019(37), lector2019(38), lector2019(39), lector2019(40), lector2019(41), lector2019(42), lector2019(43), lector2019(44), lector2019(45), lector2019(46), lector2019(47), lector2019(48), lector2019(49))
            End While
            lector2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextNombre_TextChanged(sender As Object, e As EventArgs) Handles TextNombre.TextChanged
        Try
            MetodoMetasInf2019()
            comando2019 = conexion2019.CreateCommand
            Dim r As String
            dgArticulos.Rows.Clear()
            If dgArticulos.Rows.Count < 2 Then
            Else
                dgArticulos.Rows.RemoveAt(dgArticulos.CurrentRow.Index)
            End If
            r = "Select [SetUpEquipment].EquipId, EquipmentName, Model, Accuracy, Mfr, Dept, Location, CALinterval, CALCycle,CALDue,ShortNotes,IsActive,OnSite, IEEEPort, CustomerPort,
            RS232Port,Subcontract,Automated,DtaIncluded,Catagory,Class,ItemNumber,TurnAroundTime,ApproxWeight,RelationItemNo,CalibrationMethod,
            Standardization,Accreditation,ServiceDescription,Scale1Accuracy,Scale2Accuracy, Scale1Resolution, Scale2Resolution,Scale1Unit,Scale2Unit,Uncertainity,
            ServicesId,Price,Field1,Field2,Field3,Field4,Field5,Field6,Value1,Value2,Value3,Value4,Value5,Value6
            from [SetUpEquipment] inner join SetUpEquipmentServiceMapping on [SetUpEquipment].EquipId=SetUpEquipmentServiceMapping.EquipId
            inner join EquipmentVariable on SetUpEquipment.EquipId=EquipmentVariable.EquipID_FK where ItemNumber LIKE  '" & TextNum.Text & "%' and EquipmentName like '" & TextNombre.Text & "%' 
            and Model like '" & TextModelo.Text & "%' and Mfr like '" & TextMarca.Text & "%'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read
                dgArticulos.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8), lector2019(9), lector2019(10), lector2019(11), lector2019(12), lector2019(13), lector2019(14), lector2019(15), lector2019(16), lector2019(17), lector2019(18), lector2019(19), lector2019(20), lector2019(21), lector2019(22), lector2019(23), lector2019(24), lector2019(25), lector2019(26), lector2019(27), lector2019(28), lector2019(29), lector2019(30), lector2019(31), lector2019(32), lector2019(33), lector2019(34), lector2019(35), lector2019(36), lector2019(37), lector2019(38), lector2019(39), lector2019(40), lector2019(41), lector2019(42), lector2019(43), lector2019(44), lector2019(45), lector2019(46), lector2019(47), lector2019(48), lector2019(49))
            End While
            lector2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextMarca_TextChanged(sender As Object, e As EventArgs) Handles TextMarca.TextChanged
        Try
            MetodoMetasInf2019()
            comando2019 = conexion2019.CreateCommand
            Dim r As String
            dgArticulos.Rows.Clear()
            If dgArticulos.Rows.Count < 2 Then
            Else
                dgArticulos.Rows.RemoveAt(dgArticulos.CurrentRow.Index)
            End If
            r = "Select [SetUpEquipment].EquipId, EquipmentName, Model, Accuracy, Mfr, Dept, Location, CALinterval, CALCycle,CALDue,ShortNotes,IsActive,OnSite, IEEEPort, CustomerPort,
            RS232Port,Subcontract,Automated,DtaIncluded,Catagory,Class,ItemNumber,TurnAroundTime,ApproxWeight,RelationItemNo,CalibrationMethod,
            Standardization,Accreditation,ServiceDescription,Scale1Accuracy,Scale2Accuracy, Scale1Resolution, Scale2Resolution,Scale1Unit,Scale2Unit,Uncertainity,
            ServicesId,Price,Field1,Field2,Field3,Field4,Field5,Field6,Value1,Value2,Value3,Value4,Value5,Value6
            from [SetUpEquipment] inner join SetUpEquipmentServiceMapping on [SetUpEquipment].EquipId=SetUpEquipmentServiceMapping.EquipId
            inner join EquipmentVariable on SetUpEquipment.EquipId=EquipmentVariable.EquipID_FK where ItemNumber LIKE  '" & TextNum.Text & "%' and EquipmentName like '" & TextNombre.Text & "%' 
            and Model like '" & TextModelo.Text & "%' and Mfr like '" & TextMarca.Text & "%'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read
                dgArticulos.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8), lector2019(9), lector2019(10), lector2019(11), lector2019(12), lector2019(13), lector2019(14), lector2019(15), lector2019(16), lector2019(17), lector2019(18), lector2019(19), lector2019(20), lector2019(21), lector2019(22), lector2019(23), lector2019(24), lector2019(25), lector2019(26), lector2019(27), lector2019(28), lector2019(29), lector2019(30), lector2019(31), lector2019(32), lector2019(33), lector2019(34), lector2019(35), lector2019(36), lector2019(37), lector2019(38), lector2019(39), lector2019(40), lector2019(41), lector2019(42), lector2019(43), lector2019(44), lector2019(45), lector2019(46), lector2019(47), lector2019(48), lector2019(49))
            End While
            lector2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextModelo_TextChanged(sender As Object, e As EventArgs) Handles TextModelo.TextChanged
        Try
            MetodoMetasInf2019()
            comando2019 = conexion2019.CreateCommand
            Dim r As String
            dgArticulos.Rows.Clear()
            If dgArticulos.Rows.Count < 2 Then
            Else
                dgArticulos.Rows.RemoveAt(dgArticulos.CurrentRow.Index)
            End If
            r = "Select [SetUpEquipment].EquipId, EquipmentName, Model, Accuracy, Mfr, Dept, Location, CALinterval, CALCycle,CALDue,ShortNotes,IsActive,OnSite, IEEEPort, CustomerPort,
            RS232Port,Subcontract,Automated,DtaIncluded,Catagory,Class,ItemNumber,TurnAroundTime,ApproxWeight,RelationItemNo,CalibrationMethod,
            Standardization,Accreditation,ServiceDescription,Scale1Accuracy,Scale2Accuracy, Scale1Resolution, Scale2Resolution,Scale1Unit,Scale2Unit,Uncertainity,
            ServicesId,Price,Field1,Field2,Field3,Field4,Field5,Field6,Value1,Value2,Value3,Value4,Value5,Value6
            from [SetUpEquipment] inner join SetUpEquipmentServiceMapping on [SetUpEquipment].EquipId=SetUpEquipmentServiceMapping.EquipId
            inner join EquipmentVariable on SetUpEquipment.EquipId=EquipmentVariable.EquipID_FK where ItemNumber LIKE  '" & TextNum.Text & "%' and EquipmentName like '" & TextNombre.Text & "%' 
            and Model like '" & TextModelo.Text & "%' and Mfr like '" & TextMarca.Text & "%'"
            comando2019.CommandText = r
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read
                dgArticulos.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8), lector2019(9), lector2019(10), lector2019(11), lector2019(12), lector2019(13), lector2019(14), lector2019(15), lector2019(16), lector2019(17), lector2019(18), lector2019(19), lector2019(20), lector2019(21), lector2019(22), lector2019(23), lector2019(24), lector2019(25), lector2019(26), lector2019(27), lector2019(28), lector2019(29), lector2019(30), lector2019(31), lector2019(32), lector2019(33), lector2019(34), lector2019(35), lector2019(36), lector2019(37), lector2019(38), lector2019(39), lector2019(40), lector2019(41), lector2019(42), lector2019(43), lector2019(44), lector2019(45), lector2019(46), lector2019(47), lector2019(48), lector2019(49))
            End While
            lector2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub RbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RbTodos.CheckedChanged
        For i = 1 To dgArticulos.Columns.Count
            dgArticulos.Columns("Column" & Convert.ToString(i)).Visible = True
        Next
    End Sub

    Private Sub dgDatosG_CheckedChanged(sender As Object, e As EventArgs) Handles dgDatosG.CheckedChanged
        Dim arreglo() = {2, 3, 4, 5, 6, 22, 26, 39}
        Dim l As Integer
        l = Convert.ToInt32(UBound(arreglo))
        For i = 1 To dgArticulos.Columns.Count
            For j = 0 To l
                If i = arreglo(j) Then
                    dgArticulos.Columns("Column" & Convert.ToString(i)).Visible = True
                    j = 8
                Else
                    dgArticulos.Columns("Column" & Convert.ToString(i)).Visible = False
                End If
            Next
        Next
    End Sub

    Private Sub RbTecnicos_CheckedChanged(sender As Object, e As EventArgs) Handles RbTecnicos.CheckedChanged
        Dim arreglo() = {2, 3, 4, 5, 14, 15, 16, 17, 18, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37}
        Dim l As Integer
        l = Convert.ToInt32(UBound(arreglo))
        For i = 1 To dgArticulos.Columns.Count
            For j = 0 To l
                If i = arreglo(j) Then
                    dgArticulos.Columns("Column" & Convert.ToString(i)).Visible = True
                    j = 21
                Else
                    dgArticulos.Columns("Column" & Convert.ToString(i)).Visible = False
                End If
            Next
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Using conexion As New SqlConnection(cnt)
            conexion.Open()
            Dim r As String
            Dim transaction As SqlTransaction
            transaction = conexion.BeginTransaction("Sample")
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.Connection = conexion
            comando.Transaction = transaction
            For i = 0 To dgArticulos.Rows.Count - 2
                r = "update [MetAs_Live].[dbo].[SetUpEquipment] set EquipmentName='" & (dgArticulos.Item(1, i).Value).Replace("'", "") & "',Model='" & (dgArticulos.Item(2, i).Value).Replace("'", "") & "',
                Accuracy='" & (dgArticulos.Item(3, i).Value) & "', Mfr='" & (dgArticulos.Item(4, i).Value) & "',Dept='" & (dgArticulos.Item(5, i).Value) & "',
                Location='" & (dgArticulos.Item(6, i).Value) & "',CALInterval=" & Val(dgArticulos.Item(7, i).Value) & ",CALCycle='" & (dgArticulos.Item(8, i).Value) & "',
                CALDue='" & (dgArticulos.Item(9, i).Value) & "',ShortNotes='" & (dgArticulos.Item(10, i).Value) & "',IsActive='" & (dgArticulos.Item(11, i).Value) & "',
                OnSite='" & (dgArticulos.Item(12, i).Value) & "',IEEEPort='" & (dgArticulos.Item(13, i).Value) & "',CustomerPort='" & (dgArticulos.Item(14, i).Value) & "',
                RS232Port='" & (dgArticulos.Item(15, i).Value) & "',Subcontract='" & (dgArticulos.Item(16, i).Value) & "',Automated='" & (dgArticulos.Item(17, i).Value) & "',
                DtaIncluded='" & (dgArticulos.Item(18, i).Value).Replace("≠", "") & "',Catagory='" & (dgArticulos.Item(19, i).Value) & "',Class='" & (dgArticulos.Item(20, i).Value) & "',ModifiedOn=getdate(),
                ItemNumber='" & (dgArticulos.Item(21, i).Value).Replace("'", "") & "',AdditionalSepcification='" & (dgArticulos.Item(22, i).Value) & "',
                TurnAroundTime='" & (dgArticulos.Item(23, i).Value) & "',ApproxWeight='" & (dgArticulos.Item(24, i).Value) & "',RelationItemNo='" & (dgArticulos.Item(25, i).Value) & "',
                CalibrationMethod='" & (dgArticulos.Item(26, i).Value) & "',Standardization='" & (dgArticulos.Item(27, i).Value) & "',Accreditation='" & (dgArticulos.Item(28, i).Value) & "',
                ServiceDescription='" & (dgArticulos.Item(29, i).Value).Replace("≠", "") & "',Scale1Accuracy='" & (dgArticulos.Item(30, i).Value) & "',Scale2Accuracy='" & (dgArticulos.Item(31, i).Value) & "',
                Scale1Resolution='" & (dgArticulos.Item(32, i).Value) & "',Scale2Resolution='" & (dgArticulos.Item(33, i).Value) & "',Scale1Unit='" & (dgArticulos.Item(34, i).Value) & "',
                Scale2Unit='" & (dgArticulos.Item(35, i).Value) & "',Uncertainity='" & (dgArticulos.Item(36, i).Value) & "' where EquipId=" & Val(dgArticulos.Item(0, i).Value)
                'MsgBox(r)
                comando.CommandText = r
                comando.ExecuteNonQuery()

                r = "update [MetAs_Live].[dbo].[SetupEquipmentServiceMapping] set Price=" & CDbl(dgArticulos.Item(38, i).Value) & " where EquipId=" & Val(dgArticulos.Item(0, i).Value)
                comando.CommandText = r
                comando.ExecuteNonQuery()

                r = "update [MetAs_Live].[dbo].[EquipmentVariable] set Field1='" & (dgArticulos.Item(39, i).Value) & "',Field2='" & (dgArticulos.Item(40, i).Value) & "',
                    Field3='" & (dgArticulos.Item(41, i).Value) & "',Field4='" & (dgArticulos.Item(42, i).Value) & "',Field5='" & (dgArticulos.Item(43, i).Value) & "',
                    Field6='" & (dgArticulos.Item(44, i).Value) & "',Value1='" & (dgArticulos.Item(45, i).Value) & "',Value2='" & (dgArticulos.Item(46, i).Value) & "',
                    Value3='" & (dgArticulos.Item(47, i).Value) & "',Value4='" & (dgArticulos.Item(48, i).Value) & "',Value5='" & (dgArticulos.Item(49, i).Value) & "',
                    Value6='" & (dgArticulos.Item(50, i).Value) & "' where EquipID_FK=" & Val(dgArticulos.Item(0, i).Value)
                comando.CommandText = r
                comando.ExecuteNonQuery()
                'MsgBox(r)
            Next

            Try
                If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    transaction.Commit()
                    MsgBox("El Catálogo se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                Else
                    transaction.Rollback()
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
        End Using
    End Sub
End Class