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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Matricular))
        Me.dgv_Matricular = New System.Windows.Forms.DataGridView()
        Me.Materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Creditos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requisitos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombre_Matricular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTelefono_Matricular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCarnet_Matricular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtIdentificacion_Matricular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtApellidos_Matricular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbo_Carreras = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTime_Matricular = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLimpiar_Matricula = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_Matricular = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_Deshacer_Matricula = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtCorreo_Matricular = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgv_Matricular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Matricular
        '
        Me.dgv_Matricular.AllowUserToOrderColumns = True
        Me.dgv_Matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_Matricular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Matricular.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_Matricular.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Matricular.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Matricular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Matricular.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Materia, Me.Codigo, Me.Creditos, Me.Requisitos})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Matricular.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Matricular.EnableHeadersVisualStyles = False
        Me.dgv_Matricular.GridColor = System.Drawing.Color.White
        Me.dgv_Matricular.Location = New System.Drawing.Point(187, 176)
        Me.dgv_Matricular.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_Matricular.Name = "dgv_Matricular"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Matricular.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Matricular.RowHeadersVisible = False
        Me.dgv_Matricular.RowHeadersWidth = 51
        Me.dgv_Matricular.Size = New System.Drawing.Size(694, 305)
        Me.dgv_Matricular.TabIndex = 22
        '
        'Materia
        '
        Me.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Materia.DataPropertyName = "Nombre"
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
        'txtNombre_Matricular
        '
        Me.txtNombre_Matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombre_Matricular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre_Matricular.DefaultText = ""
        Me.txtNombre_Matricular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre_Matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombre_Matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre_Matricular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre_Matricular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre_Matricular.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtNombre_Matricular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombre_Matricular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre_Matricular.Location = New System.Drawing.Point(907, 176)
        Me.txtNombre_Matricular.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombre_Matricular.Name = "txtNombre_Matricular"
        Me.txtNombre_Matricular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre_Matricular.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombre_Matricular.PlaceholderText = "Nombre"
        Me.txtNombre_Matricular.SelectedText = ""
        Me.txtNombre_Matricular.Size = New System.Drawing.Size(212, 30)
        Me.txtNombre_Matricular.TabIndex = 34
        '
        'txtTelefono_Matricular
        '
        Me.txtTelefono_Matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTelefono_Matricular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono_Matricular.DefaultText = ""
        Me.txtTelefono_Matricular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTelefono_Matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTelefono_Matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono_Matricular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono_Matricular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono_Matricular.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtTelefono_Matricular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtTelefono_Matricular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono_Matricular.Location = New System.Drawing.Point(907, 354)
        Me.txtTelefono_Matricular.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTelefono_Matricular.Name = "txtTelefono_Matricular"
        Me.txtTelefono_Matricular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono_Matricular.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtTelefono_Matricular.PlaceholderText = "Telefono"
        Me.txtTelefono_Matricular.SelectedText = ""
        Me.txtTelefono_Matricular.Size = New System.Drawing.Size(212, 30)
        Me.txtTelefono_Matricular.TabIndex = 40
        '
        'txtCarnet_Matricular
        '
        Me.txtCarnet_Matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCarnet_Matricular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCarnet_Matricular.DefaultText = ""
        Me.txtCarnet_Matricular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCarnet_Matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCarnet_Matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCarnet_Matricular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCarnet_Matricular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCarnet_Matricular.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCarnet_Matricular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCarnet_Matricular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCarnet_Matricular.Location = New System.Drawing.Point(907, 283)
        Me.txtCarnet_Matricular.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCarnet_Matricular.Name = "txtCarnet_Matricular"
        Me.txtCarnet_Matricular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCarnet_Matricular.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCarnet_Matricular.PlaceholderText = "Carnet"
        Me.txtCarnet_Matricular.SelectedText = ""
        Me.txtCarnet_Matricular.Size = New System.Drawing.Size(212, 29)
        Me.txtCarnet_Matricular.TabIndex = 37
        '
        'txtIdentificacion_Matricular
        '
        Me.txtIdentificacion_Matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIdentificacion_Matricular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdentificacion_Matricular.DefaultText = ""
        Me.txtIdentificacion_Matricular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIdentificacion_Matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIdentificacion_Matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdentificacion_Matricular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdentificacion_Matricular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdentificacion_Matricular.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtIdentificacion_Matricular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtIdentificacion_Matricular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdentificacion_Matricular.Location = New System.Drawing.Point(907, 248)
        Me.txtIdentificacion_Matricular.Margin = New System.Windows.Forms.Padding(5)
        Me.txtIdentificacion_Matricular.Name = "txtIdentificacion_Matricular"
        Me.txtIdentificacion_Matricular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdentificacion_Matricular.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtIdentificacion_Matricular.PlaceholderText = "Identificacion"
        Me.txtIdentificacion_Matricular.SelectedText = ""
        Me.txtIdentificacion_Matricular.Size = New System.Drawing.Size(212, 29)
        Me.txtIdentificacion_Matricular.TabIndex = 38
        '
        'txtApellidos_Matricular
        '
        Me.txtApellidos_Matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtApellidos_Matricular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellidos_Matricular.DefaultText = ""
        Me.txtApellidos_Matricular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtApellidos_Matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtApellidos_Matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellidos_Matricular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellidos_Matricular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellidos_Matricular.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtApellidos_Matricular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtApellidos_Matricular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellidos_Matricular.Location = New System.Drawing.Point(907, 212)
        Me.txtApellidos_Matricular.Margin = New System.Windows.Forms.Padding(5)
        Me.txtApellidos_Matricular.Name = "txtApellidos_Matricular"
        Me.txtApellidos_Matricular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellidos_Matricular.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtApellidos_Matricular.PlaceholderText = "Apellidos"
        Me.txtApellidos_Matricular.SelectedText = ""
        Me.txtApellidos_Matricular.Size = New System.Drawing.Size(212, 30)
        Me.txtApellidos_Matricular.TabIndex = 36
        '
        'cbo_Carreras
        '
        Me.cbo_Carreras.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Carreras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cbo_Carreras.FormattingEnabled = True
        Me.cbo_Carreras.Location = New System.Drawing.Point(893, 410)
        Me.cbo_Carreras.Name = "cbo_Carreras"
        Me.cbo_Carreras.Size = New System.Drawing.Size(214, 31)
        Me.cbo_Carreras.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(889, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Carrera"
        '
        'DateTime_Matricular
        '
        Me.DateTime_Matricular.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_Matricular.CalendarForeColor = System.Drawing.Color.Coral
        Me.DateTime_Matricular.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DateTime_Matricular.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_Matricular.Location = New System.Drawing.Point(893, 469)
        Me.DateTime_Matricular.Name = "DateTime_Matricular"
        Me.DateTime_Matricular.Size = New System.Drawing.Size(214, 30)
        Me.DateTime_Matricular.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(891, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Fecha Ingreso"
        '
        'btnLimpiar_Matricula
        '
        Me.btnLimpiar_Matricula.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLimpiar_Matricula.AutoRoundedCorners = True
        Me.btnLimpiar_Matricula.BorderRadius = 18
        Me.btnLimpiar_Matricula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar_Matricula.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLimpiar_Matricula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLimpiar_Matricula.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLimpiar_Matricula.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLimpiar_Matricula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLimpiar_Matricula.FillColor = System.Drawing.Color.Goldenrod
        Me.btnLimpiar_Matricula.FillColor2 = System.Drawing.Color.Yellow
        Me.btnLimpiar_Matricula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar_Matricula.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar_Matricula.Image = CType(resources.GetObject("btnLimpiar_Matricula.Image"), System.Drawing.Image)
        Me.btnLimpiar_Matricula.Location = New System.Drawing.Point(279, 493)
        Me.btnLimpiar_Matricula.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar_Matricula.Name = "btnLimpiar_Matricula"
        Me.btnLimpiar_Matricula.Size = New System.Drawing.Size(83, 38)
        Me.btnLimpiar_Matricula.TabIndex = 48
        '
        'btn_Matricular
        '
        Me.btn_Matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Matricular.AutoRoundedCorners = True
        Me.btn_Matricular.BorderRadius = 18
        Me.btn_Matricular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Matricular.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Matricular.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Matricular.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Matricular.FillColor = System.Drawing.Color.Aqua
        Me.btn_Matricular.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.btn_Matricular.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Matricular.ForeColor = System.Drawing.Color.White
        Me.btn_Matricular.Image = CType(resources.GetObject("btn_Matricular.Image"), System.Drawing.Image)
        Me.btn_Matricular.Location = New System.Drawing.Point(383, 493)
        Me.btn_Matricular.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Matricular.Name = "btn_Matricular"
        Me.btn_Matricular.Size = New System.Drawing.Size(267, 38)
        Me.btn_Matricular.TabIndex = 45
        Me.btn_Matricular.Text = "Matricular"
        '
        'btn_Deshacer_Matricula
        '
        Me.btn_Deshacer_Matricula.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Deshacer_Matricula.AutoRoundedCorners = True
        Me.btn_Deshacer_Matricula.BorderRadius = 18
        Me.btn_Deshacer_Matricula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Deshacer_Matricula.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Deshacer_Matricula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Deshacer_Matricula.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Deshacer_Matricula.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Deshacer_Matricula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Deshacer_Matricula.FillColor = System.Drawing.Color.Snow
        Me.btn_Deshacer_Matricula.FillColor2 = System.Drawing.Color.Red
        Me.btn_Deshacer_Matricula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Deshacer_Matricula.ForeColor = System.Drawing.Color.White
        Me.btn_Deshacer_Matricula.Image = CType(resources.GetObject("btn_Deshacer_Matricula.Image"), System.Drawing.Image)
        Me.btn_Deshacer_Matricula.Location = New System.Drawing.Point(672, 493)
        Me.btn_Deshacer_Matricula.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Deshacer_Matricula.Name = "btn_Deshacer_Matricula"
        Me.btn_Deshacer_Matricula.Size = New System.Drawing.Size(139, 38)
        Me.btn_Deshacer_Matricula.TabIndex = 56
        Me.btn_Deshacer_Matricula.Text = "Estudiantes"
        '
        'txtCorreo_Matricular
        '
        Me.txtCorreo_Matricular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCorreo_Matricular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo_Matricular.DefaultText = ""
        Me.txtCorreo_Matricular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo_Matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo_Matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo_Matricular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo_Matricular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo_Matricular.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCorreo_Matricular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCorreo_Matricular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo_Matricular.Location = New System.Drawing.Point(907, 318)
        Me.txtCorreo_Matricular.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCorreo_Matricular.Name = "txtCorreo_Matricular"
        Me.txtCorreo_Matricular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo_Matricular.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCorreo_Matricular.PlaceholderText = "Correo"
        Me.txtCorreo_Matricular.SelectedText = ""
        Me.txtCorreo_Matricular.Size = New System.Drawing.Size(212, 30)
        Me.txtCorreo_Matricular.TabIndex = 57
        '
        'Panel_Matricular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.txtCorreo_Matricular)
        Me.Controls.Add(Me.btn_Deshacer_Matricula)
        Me.Controls.Add(Me.btnLimpiar_Matricula)
        Me.Controls.Add(Me.btn_Matricular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTime_Matricular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_Carreras)
        Me.Controls.Add(Me.txtTelefono_Matricular)
        Me.Controls.Add(Me.txtIdentificacion_Matricular)
        Me.Controls.Add(Me.txtCarnet_Matricular)
        Me.Controls.Add(Me.txtApellidos_Matricular)
        Me.Controls.Add(Me.txtNombre_Matricular)
        Me.Controls.Add(Me.dgv_Matricular)
        Me.Name = "Panel_Matricular"
        Me.Size = New System.Drawing.Size(1143, 623)
        CType(Me.dgv_Matricular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Matricular As DataGridView
    Friend WithEvents txtNombre_Matricular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTelefono_Matricular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCarnet_Matricular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtIdentificacion_Matricular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtApellidos_Matricular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbo_Carreras As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTime_Matricular As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLimpiar_Matricula As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_Matricular As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Creditos As DataGridViewTextBoxColumn
    Friend WithEvents Requisitos As DataGridViewTextBoxColumn
    Friend WithEvents btn_Deshacer_Matricula As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtCorreo_Matricular As Guna.UI2.WinForms.Guna2TextBox
End Class
