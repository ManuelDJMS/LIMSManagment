﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btMantenimiento = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnImportarMenu = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btImportarPros = New System.Windows.Forms.Button()
        Me.btProspectos = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tiempo
        '
        Me.Tiempo.Interval = 15
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1021, 32)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = Global.LIMSManagment.My.Resources.Resources.icons8_restore_window_50
        Me.btnRestaurar.Location = New System.Drawing.Point(953, 1)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(30, 30)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRestaurar.TabIndex = 7
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.LIMSManagment.My.Resources.Resources.icons8_minimize_window_50
        Me.btnMinimizar.Location = New System.Drawing.Point(919, 1)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(953, 1)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximizar.TabIndex = 5
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.LIMSManagment.My.Resources.Resources.icons8_close_window_50
        Me.btnCerrar.Location = New System.Drawing.Point(987, 1)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1021, 557)
        Me.PanelContenedor.TabIndex = 1
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.SystemColors.Control
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(200, 32)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(821, 525)
        Me.PanelFormularios.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 32)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 525)
        Me.PanelMenu.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LIMSManagment.My.Resources.Resources.metas_esta
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btMantenimiento)
        Me.Panel1.Controls.Add(Me.btnArticulos)
        Me.Panel1.Controls.Add(Me.btnImportarMenu)
        Me.Panel1.Location = New System.Drawing.Point(3, 117)
        Me.Panel1.MaximumSize = New System.Drawing.Size(200, 172)
        Me.Panel1.MinimumSize = New System.Drawing.Size(200, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 55)
        Me.Panel1.TabIndex = 2
        '
        'btMantenimiento
        '
        Me.btMantenimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btMantenimiento.FlatAppearance.BorderSize = 0
        Me.btMantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMantenimiento.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMantenimiento.ForeColor = System.Drawing.Color.Gainsboro
        Me.btMantenimiento.Image = Global.LIMSManagment.My.Resources.Resources.icons8_maintenance_30
        Me.btMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMantenimiento.Location = New System.Drawing.Point(32, 114)
        Me.btMantenimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.btMantenimiento.Name = "btMantenimiento"
        Me.btMantenimiento.Size = New System.Drawing.Size(167, 55)
        Me.btMantenimiento.TabIndex = 4
        Me.btMantenimiento.Text = "Mantenimiento"
        Me.btMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btMantenimiento.UseVisualStyleBackColor = False
        '
        'btnArticulos
        '
        Me.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArticulos.FlatAppearance.BorderSize = 0
        Me.btnArticulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnArticulos.Image = Global.LIMSManagment.My.Resources.Resources.icons8_biomass_48
        Me.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArticulos.Location = New System.Drawing.Point(2, 2)
        Me.btnArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(200, 55)
        Me.btnArticulos.TabIndex = 3
        Me.btnArticulos.Text = "ARTICULOS"
        Me.btnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnImportarMenu
        '
        Me.btnImportarMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnImportarMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportarMenu.FlatAppearance.BorderSize = 0
        Me.btnImportarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnImportarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnImportarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportarMenu.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportarMenu.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnImportarMenu.Image = Global.LIMSManagment.My.Resources.Resources.icons8_microsoft_excel_30
        Me.btnImportarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarMenu.Location = New System.Drawing.Point(32, 58)
        Me.btnImportarMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImportarMenu.Name = "btnImportarMenu"
        Me.btnImportarMenu.Size = New System.Drawing.Size(166, 55)
        Me.btnImportarMenu.TabIndex = 3
        Me.btnImportarMenu.Text = "Importar"
        Me.btnImportarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportarMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportarMenu.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btImportarPros)
        Me.Panel2.Controls.Add(Me.btProspectos)
        Me.Panel2.Location = New System.Drawing.Point(3, 178)
        Me.Panel2.MaximumSize = New System.Drawing.Size(200, 108)
        Me.Panel2.MinimumSize = New System.Drawing.Size(200, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 55)
        Me.Panel2.TabIndex = 3
        '
        'btImportarPros
        '
        Me.btImportarPros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImportarPros.FlatAppearance.BorderSize = 0
        Me.btImportarPros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btImportarPros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btImportarPros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImportarPros.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImportarPros.ForeColor = System.Drawing.Color.Gainsboro
        Me.btImportarPros.Image = Global.LIMSManagment.My.Resources.Resources.icons8_microsoft_excel_30
        Me.btImportarPros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btImportarPros.Location = New System.Drawing.Point(31, 59)
        Me.btImportarPros.Margin = New System.Windows.Forms.Padding(2)
        Me.btImportarPros.Name = "btImportarPros"
        Me.btImportarPros.Size = New System.Drawing.Size(166, 49)
        Me.btImportarPros.TabIndex = 6
        Me.btImportarPros.Text = "Importar"
        Me.btImportarPros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btImportarPros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btImportarPros.UseVisualStyleBackColor = True
        '
        'btProspectos
        '
        Me.btProspectos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btProspectos.FlatAppearance.BorderSize = 0
        Me.btProspectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btProspectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btProspectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btProspectos.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btProspectos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btProspectos.Image = Global.LIMSManagment.My.Resources.Resources.icons8_video_conference_48
        Me.btProspectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btProspectos.Location = New System.Drawing.Point(0, 2)
        Me.btProspectos.Margin = New System.Windows.Forms.Padding(2)
        Me.btProspectos.Name = "btProspectos"
        Me.btProspectos.Size = New System.Drawing.Size(200, 55)
        Me.btProspectos.TabIndex = 5
        Me.btProspectos.Text = "PROSPECTOS"
        Me.btProspectos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btProspectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btProspectos.UseVisualStyleBackColor = True
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 557)
        Me.Controls.Add(Me.PanelContenedor)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(850, 450)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenu"
        Me.PanelBarraTitulo.ResumeLayout(False)
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tiempo As Timer
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelMenu As FlowLayoutPanel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnArticulos As Button
    Friend WithEvents btMantenimiento As Button
    Friend WithEvents btnImportarMenu As Button
    Friend WithEvents btProspectos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btImportarPros As Button
End Class
