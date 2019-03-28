Imports System.Data.SqlClient
Public Class FrmMantenimiento
    Private Sub FrmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        MetodoMetasInf2019()
            comando2019 = conexion2019.CreateCommand
            Dim r As String
        r = "Select [SetUpEquipment].EquipId, EquipmentName, Model, Accuracy, Mfr, Dept, Location, CALinterval, CALCycle,CALDue,ShortNotes,IsActive,OnSite, IEEEPort, CustomerPort,
            RS232Port,Subcontract,Automated,DtaIncluded,Catagory,Class,ItemNumber,TurnAroundTime,ApproxWeight,RelationItemNo,CalibrationMethod,
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
End Class