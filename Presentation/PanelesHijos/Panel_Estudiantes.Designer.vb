<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_Estudiantes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Estudiantes))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtNombreEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEliminarEstudiante = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEditarEstudiante = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dgv_estudiantes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtApellidosEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtIdentificacionEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCorreoEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLimpiarEstudiante = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtTelefonoEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCarnetEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_ID_Estudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFechaEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCarreraEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_estudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtNombreEstudiante
        '
        Me.txtNombreEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombreEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreEstudiante.DefaultText = ""
        Me.txtNombreEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombreEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreEstudiante.Location = New System.Drawing.Point(928, 211)
        Me.txtNombreEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombreEstudiante.Name = "txtNombreEstudiante"
        Me.txtNombreEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombreEstudiante.PlaceholderText = "Nombre"
        Me.txtNombreEstudiante.SelectedText = ""
        Me.txtNombreEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.txtNombreEstudiante.TabIndex = 25
        '
        'btnEliminarEstudiante
        '
        Me.btnEliminarEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminarEstudiante.AutoRoundedCorners = True
        Me.btnEliminarEstudiante.BorderRadius = 13
        Me.btnEliminarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarEstudiante.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminarEstudiante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminarEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminarEstudiante.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminarEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEliminarEstudiante.FillColor = System.Drawing.Color.Salmon
        Me.btnEliminarEstudiante.FillColor2 = System.Drawing.Color.OrangeRed
        Me.btnEliminarEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarEstudiante.ForeColor = System.Drawing.Color.White
        Me.btnEliminarEstudiante.Image = CType(resources.GetObject("btnEliminarEstudiante.Image"), System.Drawing.Image)
        Me.btnEliminarEstudiante.Location = New System.Drawing.Point(793, 161)
        Me.btnEliminarEstudiante.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarEstudiante.Name = "btnEliminarEstudiante"
        Me.btnEliminarEstudiante.Size = New System.Drawing.Size(124, 28)
        Me.btnEliminarEstudiante.TabIndex = 24
        Me.btnEliminarEstudiante.Text = "Eliminar"
        '
        'btnEditarEstudiante
        '
        Me.btnEditarEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditarEstudiante.AutoRoundedCorners = True
        Me.btnEditarEstudiante.BorderRadius = 13
        Me.btnEditarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarEstudiante.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarEstudiante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarEstudiante.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarEstudiante.FillColor = System.Drawing.Color.Aqua
        Me.btnEditarEstudiante.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.btnEditarEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditarEstudiante.ForeColor = System.Drawing.Color.White
        Me.btnEditarEstudiante.Image = CType(resources.GetObject("btnEditarEstudiante.Image"), System.Drawing.Image)
        Me.btnEditarEstudiante.Location = New System.Drawing.Point(661, 161)
        Me.btnEditarEstudiante.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditarEstudiante.Name = "btnEditarEstudiante"
        Me.btnEditarEstudiante.Size = New System.Drawing.Size(124, 28)
        Me.btnEditarEstudiante.TabIndex = 23
        Me.btnEditarEstudiante.Text = "Actualizar"
        '
        'dgv_estudiantes
        '
        Me.dgv_estudiantes.AllowUserToOrderColumns = True
        Me.dgv_estudiantes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_estudiantes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_estudiantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estudiantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Apellidos, Me.Identificacion, Me.Carnet, Me.Correo, Me.Telefono})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_estudiantes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_estudiantes.EnableHeadersVisualStyles = False
        Me.dgv_estudiantes.GridColor = System.Drawing.Color.White
        Me.dgv_estudiantes.Location = New System.Drawing.Point(200, 211)
        Me.dgv_estudiantes.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_estudiantes.Name = "dgv_estudiantes"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_estudiantes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_estudiantes.RowHeadersVisible = False
        Me.dgv_estudiantes.RowHeadersWidth = 51
        Me.dgv_estudiantes.Size = New System.Drawing.Size(718, 248)
        Me.dgv_estudiantes.TabIndex = 21
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellidos
        '
        Me.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Apellidos.DataPropertyName = "Apellidos"
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.MinimumWidth = 6
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        '
        'Identificacion
        '
        Me.Identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Identificacion.DataPropertyName = "Identificacion"
        Me.Identificacion.HeaderText = "Identificacion"
        Me.Identificacion.MinimumWidth = 6
        Me.Identificacion.Name = "Identificacion"
        Me.Identificacion.ReadOnly = True
        '
        'Carnet
        '
        Me.Carnet.DataPropertyName = "Carnet"
        Me.Carnet.HeaderText = "Carnet"
        Me.Carnet.MinimumWidth = 6
        Me.Carnet.Name = "Carnet"
        '
        'Correo
        '
        Me.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "Correo"
        Me.Correo.MinimumWidth = 6
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.MinimumWidth = 6
        Me.Telefono.Name = "Telefono"
        '
        'txtApellidosEstudiante
        '
        Me.txtApellidosEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtApellidosEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellidosEstudiante.DefaultText = ""
        Me.txtApellidosEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtApellidosEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtApellidosEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellidosEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellidosEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellidosEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtApellidosEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtApellidosEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellidosEstudiante.Location = New System.Drawing.Point(928, 243)
        Me.txtApellidosEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtApellidosEstudiante.Name = "txtApellidosEstudiante"
        Me.txtApellidosEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellidosEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtApellidosEstudiante.PlaceholderText = "Apellidos"
        Me.txtApellidosEstudiante.SelectedText = ""
        Me.txtApellidosEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.txtApellidosEstudiante.TabIndex = 29
        '
        'txtIdentificacionEstudiante
        '
        Me.txtIdentificacionEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIdentificacionEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdentificacionEstudiante.DefaultText = ""
        Me.txtIdentificacionEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIdentificacionEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIdentificacionEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdentificacionEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdentificacionEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdentificacionEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtIdentificacionEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtIdentificacionEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdentificacionEstudiante.Location = New System.Drawing.Point(928, 274)
        Me.txtIdentificacionEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtIdentificacionEstudiante.Name = "txtIdentificacionEstudiante"
        Me.txtIdentificacionEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdentificacionEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtIdentificacionEstudiante.PlaceholderText = "Identificacion"
        Me.txtIdentificacionEstudiante.SelectedText = ""
        Me.txtIdentificacionEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.txtIdentificacionEstudiante.TabIndex = 30
        '
        'txtCorreoEstudiante
        '
        Me.txtCorreoEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCorreoEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreoEstudiante.DefaultText = ""
        Me.txtCorreoEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreoEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreoEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreoEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreoEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreoEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCorreoEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCorreoEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreoEstudiante.Location = New System.Drawing.Point(928, 342)
        Me.txtCorreoEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCorreoEstudiante.Name = "txtCorreoEstudiante"
        Me.txtCorreoEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreoEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCorreoEstudiante.PlaceholderText = "Correo"
        Me.txtCorreoEstudiante.SelectedText = ""
        Me.txtCorreoEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.txtCorreoEstudiante.TabIndex = 31
        '
        'btnLimpiarEstudiante
        '
        Me.btnLimpiarEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLimpiarEstudiante.AutoRoundedCorners = True
        Me.btnLimpiarEstudiante.BorderRadius = 13
        Me.btnLimpiarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarEstudiante.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLimpiarEstudiante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLimpiarEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLimpiarEstudiante.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLimpiarEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLimpiarEstudiante.FillColor = System.Drawing.Color.Goldenrod
        Me.btnLimpiarEstudiante.FillColor2 = System.Drawing.Color.Yellow
        Me.btnLimpiarEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiarEstudiante.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarEstudiante.Image = CType(resources.GetObject("btnLimpiarEstudiante.Image"), System.Drawing.Image)
        Me.btnLimpiarEstudiante.Location = New System.Drawing.Point(581, 161)
        Me.btnLimpiarEstudiante.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiarEstudiante.Name = "btnLimpiarEstudiante"
        Me.btnLimpiarEstudiante.Size = New System.Drawing.Size(68, 28)
        Me.btnLimpiarEstudiante.TabIndex = 34
        '
        'txtTelefonoEstudiante
        '
        Me.txtTelefonoEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTelefonoEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefonoEstudiante.DefaultText = ""
        Me.txtTelefonoEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTelefonoEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTelefonoEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefonoEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefonoEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefonoEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtTelefonoEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtTelefonoEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefonoEstudiante.Location = New System.Drawing.Point(928, 378)
        Me.txtTelefonoEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTelefonoEstudiante.Name = "txtTelefonoEstudiante"
        Me.txtTelefonoEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefonoEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtTelefonoEstudiante.PlaceholderText = "Telefono"
        Me.txtTelefonoEstudiante.SelectedText = ""
        Me.txtTelefonoEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.txtTelefonoEstudiante.TabIndex = 36
        '
        'txtCarnetEstudiante
        '
        Me.txtCarnetEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCarnetEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCarnetEstudiante.DefaultText = ""
        Me.txtCarnetEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCarnetEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCarnetEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCarnetEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCarnetEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCarnetEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCarnetEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCarnetEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCarnetEstudiante.Location = New System.Drawing.Point(928, 306)
        Me.txtCarnetEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCarnetEstudiante.Name = "txtCarnetEstudiante"
        Me.txtCarnetEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCarnetEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCarnetEstudiante.PlaceholderText = "Carnet"
        Me.txtCarnetEstudiante.SelectedText = ""
        Me.txtCarnetEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.txtCarnetEstudiante.TabIndex = 39
        '
        'txt_ID_Estudiante
        '
        Me.txt_ID_Estudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_ID_Estudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ID_Estudiante.DefaultText = ""
        Me.txt_ID_Estudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ID_Estudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ID_Estudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID_Estudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID_Estudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID_Estudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID_Estudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_ID_Estudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID_Estudiante.Location = New System.Drawing.Point(200, 38)
        Me.txt_ID_Estudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_ID_Estudiante.Name = "txt_ID_Estudiante"
        Me.txt_ID_Estudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ID_Estudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_ID_Estudiante.PlaceholderText = "ID"
        Me.txt_ID_Estudiante.SelectedText = ""
        Me.txt_ID_Estudiante.Size = New System.Drawing.Size(180, 26)
        Me.txt_ID_Estudiante.TabIndex = 28
        Me.txt_ID_Estudiante.Visible = False
        '
        'txtFechaEstudiante
        '
        Me.txtFechaEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFechaEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFechaEstudiante.DefaultText = ""
        Me.txtFechaEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFechaEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFechaEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFechaEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFechaEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFechaEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFechaEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtFechaEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFechaEstudiante.Location = New System.Drawing.Point(390, 38)
        Me.txtFechaEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFechaEstudiante.Name = "txtFechaEstudiante"
        Me.txtFechaEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtFechaEstudiante.PlaceholderText = "Fecha Ingreso"
        Me.txtFechaEstudiante.SelectedText = ""
        Me.txtFechaEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.txtFechaEstudiante.TabIndex = 40
        Me.txtFechaEstudiante.Visible = False
        '
        'txtCarreraEstudiante
        '
        Me.txtCarreraEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCarreraEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCarreraEstudiante.DefaultText = ""
        Me.txtCarreraEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCarreraEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCarreraEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCarreraEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCarreraEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCarreraEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCarreraEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCarreraEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCarreraEstudiante.Location = New System.Drawing.Point(580, 38)
        Me.txtCarreraEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCarreraEstudiante.Name = "txtCarreraEstudiante"
        Me.txtCarreraEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCarreraEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCarreraEstudiante.PlaceholderText = "Carrera"
        Me.txtCarreraEstudiante.SelectedText = ""
        Me.txtCarreraEstudiante.Size = New System.Drawing.Size(180, 26)
        Me.txtCarreraEstudiante.TabIndex = 41
        Me.txtCarreraEstudiante.Visible = False
        '
        'Panel_Estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.txtCarreraEstudiante)
        Me.Controls.Add(Me.txtFechaEstudiante)
        Me.Controls.Add(Me.txtCarnetEstudiante)
        Me.Controls.Add(Me.txtTelefonoEstudiante)
        Me.Controls.Add(Me.btnLimpiarEstudiante)
        Me.Controls.Add(Me.txtCorreoEstudiante)
        Me.Controls.Add(Me.txtIdentificacionEstudiante)
        Me.Controls.Add(Me.txtApellidosEstudiante)
        Me.Controls.Add(Me.txt_ID_Estudiante)
        Me.Controls.Add(Me.txtNombreEstudiante)
        Me.Controls.Add(Me.btnEliminarEstudiante)
        Me.Controls.Add(Me.btnEditarEstudiante)
        Me.Controls.Add(Me.dgv_estudiantes)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Panel_Estudiantes"
        Me.Size = New System.Drawing.Size(1113, 565)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_estudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtNombreEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEliminarEstudiante As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEditarEstudiante As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgv_estudiantes As DataGridView
    Friend WithEvents txtCorreoEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtIdentificacionEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtApellidosEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLimpiarEstudiante As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtTelefonoEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCarnetEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_ID_Estudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCarreraEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFechaEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents Carnet As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
End Class
