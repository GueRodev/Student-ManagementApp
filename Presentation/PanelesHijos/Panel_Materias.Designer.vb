<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_Materias
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Materias))
        Me.ErrorMaterias = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnEliminarMateria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEditarMateria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnGuardarMateria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_ID_Materias = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCodigoMateria = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCreditosMateria = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNombreMateria = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgv_materias = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Creditos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpiarMaterias = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.ErrorMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_materias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorMaterias
        '
        Me.ErrorMaterias.ContainerControl = Me
        '
        'btnEliminarMateria
        '
        Me.btnEliminarMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminarMateria.AutoRoundedCorners = True
        Me.btnEliminarMateria.BorderRadius = 10
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
        Me.btnEliminarMateria.Location = New System.Drawing.Point(677, 110)
        Me.btnEliminarMateria.Name = "btnEliminarMateria"
        Me.btnEliminarMateria.Size = New System.Drawing.Size(93, 23)
        Me.btnEliminarMateria.TabIndex = 37
        Me.btnEliminarMateria.Text = "Eliminar"
        '
        'btnEditarMateria
        '
        Me.btnEditarMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditarMateria.AutoRoundedCorners = True
        Me.btnEditarMateria.BorderRadius = 10
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
        Me.btnEditarMateria.Location = New System.Drawing.Point(581, 110)
        Me.btnEditarMateria.Name = "btnEditarMateria"
        Me.btnEditarMateria.Size = New System.Drawing.Size(93, 23)
        Me.btnEditarMateria.TabIndex = 36
        Me.btnEditarMateria.Text = "Actualizar"
        '
        'btnGuardarMateria
        '
        Me.btnGuardarMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardarMateria.AutoRoundedCorners = True
        Me.btnGuardarMateria.BorderRadius = 10
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
        Me.btnGuardarMateria.Location = New System.Drawing.Point(482, 110)
        Me.btnGuardarMateria.Name = "btnGuardarMateria"
        Me.btnGuardarMateria.Size = New System.Drawing.Size(93, 23)
        Me.btnGuardarMateria.TabIndex = 35
        Me.btnGuardarMateria.Text = "Guardar"
        '
        'txt_ID_Materias
        '
        Me.txt_ID_Materias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_ID_Materias.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ID_Materias.DefaultText = ""
        Me.txt_ID_Materias.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ID_Materias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ID_Materias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID_Materias.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID_Materias.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID_Materias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID_Materias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_ID_Materias.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID_Materias.Location = New System.Drawing.Point(127, 149)
        Me.txt_ID_Materias.Margin = New System.Windows.Forms.Padding(7)
        Me.txt_ID_Materias.Name = "txt_ID_Materias"
        Me.txt_ID_Materias.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ID_Materias.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_ID_Materias.PlaceholderText = "ID"
        Me.txt_ID_Materias.SelectedText = ""
        Me.txt_ID_Materias.Size = New System.Drawing.Size(35, 21)
        Me.txt_ID_Materias.TabIndex = 42
        '
        'txtCodigoMateria
        '
        Me.txtCodigoMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCodigoMateria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoMateria.DefaultText = ""
        Me.txtCodigoMateria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCodigoMateria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCodigoMateria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigoMateria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigoMateria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigoMateria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoMateria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCodigoMateria.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigoMateria.Location = New System.Drawing.Point(369, 149)
        Me.txtCodigoMateria.Margin = New System.Windows.Forms.Padding(7)
        Me.txtCodigoMateria.Name = "txtCodigoMateria"
        Me.txtCodigoMateria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoMateria.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCodigoMateria.PlaceholderText = "Codigo"
        Me.txtCodigoMateria.SelectedText = ""
        Me.txtCodigoMateria.Size = New System.Drawing.Size(202, 21)
        Me.txtCodigoMateria.TabIndex = 41
        '
        'txtCreditosMateria
        '
        Me.txtCreditosMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCreditosMateria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreditosMateria.DefaultText = ""
        Me.txtCreditosMateria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCreditosMateria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCreditosMateria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreditosMateria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreditosMateria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreditosMateria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCreditosMateria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCreditosMateria.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreditosMateria.Location = New System.Drawing.Point(577, 149)
        Me.txtCreditosMateria.Margin = New System.Windows.Forms.Padding(7)
        Me.txtCreditosMateria.Name = "txtCreditosMateria"
        Me.txtCreditosMateria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCreditosMateria.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtCreditosMateria.PlaceholderText = "Creditos"
        Me.txtCreditosMateria.SelectedText = ""
        Me.txtCreditosMateria.Size = New System.Drawing.Size(196, 21)
        Me.txtCreditosMateria.TabIndex = 40
        '
        'txtNombreMateria
        '
        Me.txtNombreMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombreMateria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreMateria.DefaultText = ""
        Me.txtNombreMateria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreMateria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreMateria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreMateria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreMateria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreMateria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtNombreMateria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombreMateria.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreMateria.Location = New System.Drawing.Point(168, 149)
        Me.txtNombreMateria.Margin = New System.Windows.Forms.Padding(7)
        Me.txtNombreMateria.Name = "txtNombreMateria"
        Me.txtNombreMateria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreMateria.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombreMateria.PlaceholderText = "Nombre"
        Me.txtNombreMateria.SelectedText = ""
        Me.txtNombreMateria.Size = New System.Drawing.Size(195, 21)
        Me.txtNombreMateria.TabIndex = 39
        '
        'dgv_materias
        '
        Me.dgv_materias.AllowUserToOrderColumns = True
        Me.dgv_materias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_materias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_materias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_materias.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_materias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_materias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Codigo, Me.Creditos})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_materias.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_materias.EnableHeadersVisualStyles = False
        Me.dgv_materias.GridColor = System.Drawing.Color.White
        Me.dgv_materias.Location = New System.Drawing.Point(127, 175)
        Me.dgv_materias.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_materias.Name = "dgv_materias"
        Me.dgv_materias.RowHeadersVisible = False
        Me.dgv_materias.RowHeadersWidth = 82
        Me.dgv_materias.Size = New System.Drawing.Size(646, 173)
        Me.dgv_materias.TabIndex = 38
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID.DataPropertyName = "ID"
        Me.ID.FillWeight = 20.0!
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 10
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 10
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 10
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Creditos
        '
        Me.Creditos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Creditos.DataPropertyName = "Creditos"
        Me.Creditos.HeaderText = "Creditos"
        Me.Creditos.MinimumWidth = 10
        Me.Creditos.Name = "Creditos"
        Me.Creditos.ReadOnly = True
        '
        'btnLimpiarMaterias
        '
        Me.btnLimpiarMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLimpiarMaterias.AutoRoundedCorners = True
        Me.btnLimpiarMaterias.BorderRadius = 10
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
        Me.btnLimpiarMaterias.Location = New System.Drawing.Point(425, 110)
        Me.btnLimpiarMaterias.Name = "btnLimpiarMaterias"
        Me.btnLimpiarMaterias.Size = New System.Drawing.Size(51, 23)
        Me.btnLimpiarMaterias.TabIndex = 43
        '
        'Panel_Materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.btnLimpiarMaterias)
        Me.Controls.Add(Me.txt_ID_Materias)
        Me.Controls.Add(Me.txtCodigoMateria)
        Me.Controls.Add(Me.txtCreditosMateria)
        Me.Controls.Add(Me.txtNombreMateria)
        Me.Controls.Add(Me.dgv_materias)
        Me.Controls.Add(Me.btnEliminarMateria)
        Me.Controls.Add(Me.btnEditarMateria)
        Me.Controls.Add(Me.btnGuardarMateria)
        Me.Name = "Panel_Materias"
        Me.Size = New System.Drawing.Size(835, 459)
        CType(Me.ErrorMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_materias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorMaterias As ErrorProvider
    Friend WithEvents btnEliminarMateria As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEditarMateria As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnGuardarMateria As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_ID_Materias As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCodigoMateria As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCreditosMateria As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNombreMateria As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgv_materias As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Creditos As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiarMaterias As Guna.UI2.WinForms.Guna2GradientButton
End Class
