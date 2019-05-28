Imports System.Runtime.InteropServices
Public Class FrmHome
    Private iscollapsed As Boolean = True
#Region "FUNCIONALIDADES DEL FORMULARIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10
    Dim panelnum As Integer

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Dim lx, ly As Integer
    Dim sw, sh As Integer
    Private Sub btnCerrar_MouseHover(sender As Object, e As EventArgs) Handles btnCerrar.MouseHover
        btnCerrar.BackColor = Color.Red
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        btnCerrar.BackColor = Color.FromArgb(4, 41, 68)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub
#End Region

    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Normal
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        If (Application.OpenForms("FormPacientes") Is Nothing) Then
            'Button1.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("FormAgenda") Is Nothing) Then
            ' Button2.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub

    Private Sub BtProspectos_Click(sender As Object, e As EventArgs) Handles btProspectos.Click
        Tiempo.Start()
        panelnum = 2
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        If panelnum = 1 Then
            abrirmenu(Panel1)
        ElseIf panelnum = 2 Then
            abrirmenu(Panel2)
        End If

    End Sub

    Private Sub BtImportarPros_Click(sender As Object, e As EventArgs) Handles btImportarPros.Click
        AbrirFormEnPanel(Of FrmImportarProspectos)()
        btProspectos.BackColor = Color.FromArgb(12, 61, 92)

    End Sub

    Private Sub BtnImportarMenu_Click(sender As Object, e As EventArgs) Handles btnImportarMenu.Click
        AbrirFormEnPanel(Of FrmImportar)()
        btnArticulos.BackColor = Color.FromArgb(12, 61, 92)

    End Sub

    Private Sub BtMantenimiento_Click(sender As Object, e As EventArgs) Handles btMantenimiento.Click
        AbrirFormEnPanel(Of FrmMantenimiento)()
        btnArticulos.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub BtnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Tiempo.Start()
        panelnum = 1
    End Sub
    'Funcion para abrir el menu desplegable de cada boton
    Sub abrirmenu(ByVal boton As Panel)
        If iscollapsed Then
            boton.Height += 10
            If boton.Size = boton.MaximumSize Then

                Tiempo.Stop()
                iscollapsed = False
            End If
        Else
            boton.Height -= 10
            If boton.Size = boton.MinimumSize Then
                Tiempo.Stop()
                iscollapsed = True
            End If
        End If

    End Sub
End Class