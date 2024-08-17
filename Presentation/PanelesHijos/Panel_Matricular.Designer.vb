<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Matricular
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Matricular))
        Me.dgv_matricular = New System.Windows.Forms.DataGridView()
        Me.AsociacionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Creditos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requisitos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombreEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFechaEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtIdentificacionEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCorreoEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtApellidosEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbo_Carreras = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLimpiarMaterias = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEditarMateria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnGuardarMateria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEliminarMateria = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.dgv_matricular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_matricular
        '
        Me.dgv_matricular.AllowUserToOrderColumns = True
        Me.dgv_matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_matricular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_matricular.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_matricular.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_matricular.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_matricular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_matricular.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AsociacionID, Me.Materia, Me.Codigo, Me.Creditos, Me.Requisitos})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_matricular.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_matricular.EnableHeadersVisualStyles = False
        Me.dgv_matricular.GridColor = System.Drawing.Color.White
        Me.dgv_matricular.Location = New System.Drawing.Point(172, 174)
        Me.dgv_matricular.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_matricular.Name = "dgv_matricular"
        Me.dgv_matricular.RowHeadersVisible = False
        Me.dgv_matricular.RowHeadersWidth = 51
        Me.dgv_matricular.Size = New System.Drawing.Size(694, 305)
        Me.dgv_matricular.TabIndex = 22
        '
        'AsociacionID
        '
        Me.AsociacionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AsociacionID.DataPropertyName = "AsociacionID"
        Me.AsociacionID.HeaderText = "AsociacionID"
        Me.AsociacionID.MinimumWidth = 6
        Me.AsociacionID.Name = "AsociacionID"
        Me.AsociacionID.ReadOnly = True
        Me.AsociacionID.Visible = False
        '
        'Materia
        '
        Me.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Materia.DataPropertyName = "Materia"
        Me.Materia.HeaderText = "Materia"
        Me.Materia.MinimumWidth = 6
        Me.Materia.Name = "Materia"
        Me.Materia.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Creditos
        '
        Me.Creditos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Creditos.DataPropertyName = "Creditos"
        Me.Creditos.HeaderText = "Creditos"
        Me.Creditos.MinimumWidth = 6
        Me.Creditos.Name = "Creditos"
        Me.Creditos.ReadOnly = True
        '
        'Requisitos
        '
        Me.Requisitos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Requisitos.DataPropertyName = "Requisitos"
        Me.Requisitos.HeaderText = "Requisitos"
        Me.Requisitos.MinimumWidth = 6
        Me.Requisitos.Name = "Requisitos"
        Me.Requisitos.ReadOnly = True
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
        Me.txtNombreEstudiante.Location = New System.Drawing.Point(892, 174)
        Me.txtNombreEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombreEstudiante.Name = "txtNombreEstudiante"
        Me.txtNombreEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombreEstudiante.PlaceholderText = "Nombre"
        Me.txtNombreEstudiante.SelectedText = ""
        Me.txtNombreEstudiante.Size = New System.Drawing.Size(226, 30)
        Me.txtNombreEstudiante.TabIndex = 34
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
        Me.txtFechaEstudiante.Location = New System.Drawing.Point(892, 332)
        Me.txtFechaEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFechaEstudiante.Name = "txtFechaEstudiante"
        Me.txtFechaEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtFechaEstudiante.PlaceholderText = "Telefono"
        Me.txtFechaEstudiante.SelectedText = ""
        Me.txtFechaEstudiante.Size = New System.Drawing.Size(226, 30)
        Me.txtFechaEstudiante.TabIndex = 40
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
        Me.txtIdentificacionEstudiante.Location = New System.Drawing.Point(892, 293)
        Me.txtIdentificacionEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtIdentificacionEstudiante.Name = "txtIdentificacionEstudiante"
        Me.txtIdentificacionEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdentificacionEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtIdentificacionEstudiante.PlaceholderText = "Carnet"
        Me.txtIdentificacionEstudiante.SelectedText = ""
        Me.txtIdentificacionEstudiante.Size = New System.Drawing.Size(226, 29)
        Me.txtIdentificacionEstudiante.TabIndex = 37
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
        Me.txtCorreoEstudiante.Location = New System.Drawing.Point(892, 254)
        Me.txtCorreoEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCorreoEstudiante.Name = "txtCorreoEstudiante"
        Me.txtCorreoEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreoEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCorreoEstudiante.PlaceholderText = "Identificacion"
        Me.txtCorreoEstudiante.SelectedText = ""
        Me.txtCorreoEstudiante.Size = New System.Drawing.Size(226, 29)
        Me.txtCorreoEstudiante.TabIndex = 38
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
        Me.txtApellidosEstudiante.Location = New System.Drawing.Point(892, 214)
        Me.txtApellidosEstudiante.Margin = New System.Windows.Forms.Padding(5)
        Me.txtApellidosEstudiante.Name = "txtApellidosEstudiante"
        Me.txtApellidosEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellidosEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtApellidosEstudiante.PlaceholderText = "Apellidos"
        Me.txtApellidosEstudiante.SelectedText = ""
        Me.txtApellidosEstudiante.Size = New System.Drawing.Size(226, 30)
        Me.txtApellidosEstudiante.TabIndex = 36
        '
        'cbo_Carreras
        '
        Me.cbo_Carreras.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Carreras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cbo_Carreras.FormattingEnabled = True
        Me.cbo_Carreras.Items.AddRange(New Object() {"Ingeniería Industrial", "Ingeniería en Sistemas", "Administración de Negocios", "Contaduría"})
        Me.cbo_Carreras.Location = New System.Drawing.Point(878, 390)
        Me.cbo_Carreras.Name = "cbo_Carreras"
        Me.cbo_Carreras.Size = New System.Drawing.Size(226, 31)
        Me.cbo_Carreras.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(874, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Carrera"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Coral
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(878, 449)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 30)
        Me.DateTimePicker1.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(876, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Fecha Ingreso"
        '
        'btnLimpiarMaterias
        '
        Me.btnLimpiarMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLimpiarMaterias.AutoRoundedCorners = True
        Me.btnLimpiarMaterias.BorderRadius = 13
        Me.btnLimpiarMaterias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarMaterias.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLimpiarMaterias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLimpiarMaterias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLimpiarMaterias.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLimpiarMaterias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLimpiarMaterias.FillColor = System.Drawing.Color.Goldenrod
        Me.btnLimpiarMaterias.FillColor2 = System.Drawing.Color.Yellow
        Me.btnLimpiarMaterias.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiarMaterias.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarMaterias.Image = CType(resources.GetObject("btnLimpiarMaterias.Image"), System.Drawing.Image)
        Me.btnLimpiarMaterias.Location = New System.Drawing.Point(264, 491)
        Me.btnLimpiarMaterias.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiarMaterias.Name = "btnLimpiarMaterias"
        Me.btnLimpiarMaterias.Size = New System.Drawing.Size(68, 28)
        Me.btnLimpiarMaterias.TabIndex = 48
        '
        'btnEditarMateria
        '
        Me.btnEditarMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditarMateria.AutoRoundedCorners = True
        Me.btnEditarMateria.BorderRadius = 13
        Me.btnEditarMateria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarMateria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarMateria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarMateria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarMateria.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarMateria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarMateria.FillColor = System.Drawing.Color.Aqua
        Me.btnEditarMateria.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.btnEditarMateria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditarMateria.ForeColor = System.Drawing.Color.White
        Me.btnEditarMateria.Image = CType(resources.GetObject("btnEditarMateria.Image"), System.Drawing.Image)
        Me.btnEditarMateria.Location = New System.Drawing.Point(487, 491)
        Me.btnEditarMateria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditarMateria.Name = "btnEditarMateria"
        Me.btnEditarMateria.Size = New System.Drawing.Size(124, 28)
        Me.btnEditarMateria.TabIndex = 46
        Me.btnEditarMateria.Text = "Actualizar"
        '
        'btnGuardarMateria
        '
        Me.btnGuardarMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardarMateria.AutoRoundedCorners = True
        Me.btnGuardarMateria.BorderRadius = 13
        Me.btnGuardarMateria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarMateria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardarMateria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardarMateria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardarMateria.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardarMateria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardarMateria.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardarMateria.FillColor2 = System.Drawing.Color.Green
        Me.btnGuardarMateria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarMateria.ForeColor = System.Drawing.Color.White
        Me.btnGuardarMateria.Image = CType(resources.GetObject("btnGuardarMateria.Image"), System.Drawing.Image)
        Me.btnGuardarMateria.Location = New System.Drawing.Point(348, 491)
        Me.btnGuardarMateria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarMateria.Name = "btnGuardarMateria"
        Me.btnGuardarMateria.Size = New System.Drawing.Size(124, 28)
        Me.btnGuardarMateria.TabIndex = 45
        Me.btnGuardarMateria.Text = "Guardar"
        '
        'btnEliminarMateria
        '
        Me.btnEliminarMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminarMateria.AutoRoundedCorners = True
        Me.btnEliminarMateria.BorderRadius = 13
        Me.btnEliminarMateria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarMateria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminarMateria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminarMateria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminarMateria.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminarMateria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEliminarMateria.FillColor = System.Drawing.Color.Salmon
        Me.btnEliminarMateria.FillColor2 = System.Drawing.Color.OrangeRed
        Me.btnEliminarMateria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarMateria.ForeColor = System.Drawing.Color.White
        Me.btnEliminarMateria.Image = CType(resources.GetObject("btnEliminarMateria.Image"), System.Drawing.Image)
        Me.btnEliminarMateria.Location = New System.Drawing.Point(626, 491)
        Me.btnEliminarMateria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarMateria.Name = "btnEliminarMateria"
        Me.btnEliminarMateria.Size = New System.Drawing.Size(124, 28)
        Me.btnEliminarMateria.TabIndex = 47
        Me.btnEliminarMateria.Text = "Eliminar"
        '
        'Panel_Matricular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.btnLimpiarMaterias)
        Me.Controls.Add(Me.btnEliminarMateria)
        Me.Controls.Add(Me.btnEditarMateria)
        Me.Controls.Add(Me.btnGuardarMateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_Carreras)
        Me.Controls.Add(Me.txtFechaEstudiante)
        Me.Controls.Add(Me.txtCorreoEstudiante)
        Me.Controls.Add(Me.txtIdentificacionEstudiante)
        Me.Controls.Add(Me.txtApellidosEstudiante)
        Me.Controls.Add(Me.txtNombreEstudiante)
        Me.Controls.Add(Me.dgv_matricular)
        Me.Name = "Panel_Matricular"
        Me.Size = New System.Drawing.Size(1143, 623)
        CType(Me.dgv_matricular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_matricular As DataGridView
    Friend WithEvents AsociacionID As DataGridViewTextBoxColumn
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Creditos As DataGridViewTextBoxColumn
    Friend WithEvents Requisitos As DataGridViewTextBoxColumn
    Friend WithEvents txtNombreEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFechaEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtIdentificacionEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCorreoEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtApellidosEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbo_Carreras As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLimpiarMaterias As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEditarMateria As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnGuardarMateria As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEliminarMateria As Guna.UI2.WinForms.Guna2GradientButton
End Class
