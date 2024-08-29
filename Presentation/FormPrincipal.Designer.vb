<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.btnApagar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEstados = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMenuBar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelAbajo = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.btn_LogoCerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.lbl_Rol = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.btnMatricular = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAsignar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaterias = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEstudiantes = New Guna.UI2.WinForms.Guna2Button()
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelContainer.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelContainer
        '
        Me.panelContainer.Controls.Add(Me.PanelMenu)
        Me.panelContainer.Controls.Add(Me.PanelAbajo)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 0)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(924, 505)
        Me.panelContainer.TabIndex = 36
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.White
        Me.PanelMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.PanelMenu.Controls.Add(Me.btnApagar)
        Me.PanelMenu.Controls.Add(Me.btnEstados)
        Me.PanelMenu.Controls.Add(Me.btnMenuBar)
        Me.PanelMenu.Controls.Add(Me.btnHome)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(53, 485)
        Me.PanelMenu.TabIndex = 2
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUsuarios.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Black
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsuarios.Location = New System.Drawing.Point(1, 308)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(163, 57)
        Me.btnUsuarios.TabIndex = 7
        Me.btnUsuarios.Text = "   Usuarios"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCerrarSesion.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 364)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(163, 57)
        Me.btnCerrarSesion.TabIndex = 6
        Me.btnCerrarSesion.Text = " Salir"
        '
        'btnApagar
        '
        Me.btnApagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnApagar.BackColor = System.Drawing.Color.Transparent
        Me.btnApagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnApagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnApagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnApagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnApagar.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnApagar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnApagar.ForeColor = System.Drawing.Color.Black
        Me.btnApagar.Image = CType(resources.GetObject("btnApagar.Image"), System.Drawing.Image)
        Me.btnApagar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnApagar.Location = New System.Drawing.Point(0, 426)
        Me.btnApagar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(163, 57)
        Me.btnApagar.TabIndex = 5
        Me.btnApagar.Text = "  Apagar"
        '
        'btnEstados
        '
        Me.btnEstados.BackColor = System.Drawing.Color.Transparent
        Me.btnEstados.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEstados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEstados.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEstados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEstados.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnEstados.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEstados.ForeColor = System.Drawing.Color.Black
        Me.btnEstados.Image = CType(resources.GetObject("btnEstados.Image"), System.Drawing.Image)
        Me.btnEstados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEstados.Location = New System.Drawing.Point(0, 235)
        Me.btnEstados.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEstados.Name = "btnEstados"
        Me.btnEstados.Size = New System.Drawing.Size(163, 57)
        Me.btnEstados.TabIndex = 4
        Me.btnEstados.Text = "   Estados"
        '
        'btnMenuBar
        '
        Me.btnMenuBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuBar.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMenuBar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMenuBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMenuBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMenuBar.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnMenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenuBar.ForeColor = System.Drawing.Color.White
        Me.btnMenuBar.Image = CType(resources.GetObject("btnMenuBar.Image"), System.Drawing.Image)
        Me.btnMenuBar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMenuBar.Location = New System.Drawing.Point(7, 126)
        Me.btnMenuBar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenuBar.Name = "btnMenuBar"
        Me.btnMenuBar.Size = New System.Drawing.Size(49, 37)
        Me.btnMenuBar.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.Location = New System.Drawing.Point(0, 172)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(163, 57)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Inicio"
        '
        'PanelAbajo
        '
        Me.PanelAbajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAbajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelAbajo.Location = New System.Drawing.Point(0, 485)
        Me.PanelAbajo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelAbajo.Name = "PanelAbajo"
        Me.PanelAbajo.Size = New System.Drawing.Size(924, 20)
        Me.PanelAbajo.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(875, -1)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(51, 33)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(784, -2)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(51, 33)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(835, -2)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(41, 33)
        Me.btnMaximizar.TabIndex = 7
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(836, -2)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(41, 33)
        Me.btnRestaurar.TabIndex = 8
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.btnSalir)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(924, 28)
        Me.PanelTitulo.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 28)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Universidad Tecnológica Alajuela"
        '
        'PanelLogo
        '
        Me.PanelLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLogo.BackColor = System.Drawing.Color.White
        Me.PanelLogo.Controls.Add(Me.btn_LogoCerrarSesion)
        Me.PanelLogo.Controls.Add(Me.lbl_Rol)
        Me.PanelLogo.Controls.Add(Me.lbl_Usuario)
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.PictureBox2)
        Me.PanelLogo.Location = New System.Drawing.Point(0, 28)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(1113, 47)
        Me.PanelLogo.TabIndex = 34
        '
        'btn_LogoCerrarSesion
        '
        Me.btn_LogoCerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LogoCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_LogoCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_LogoCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_LogoCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_LogoCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_LogoCerrarSesion.FillColor = System.Drawing.Color.Empty
        Me.btn_LogoCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_LogoCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btn_LogoCerrarSesion.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_LogoCerrarSesion.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_LogoCerrarSesion.Image = CType(resources.GetObject("btn_LogoCerrarSesion.Image"), System.Drawing.Image)
        Me.btn_LogoCerrarSesion.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_LogoCerrarSesion.Location = New System.Drawing.Point(855, 0)
        Me.btn_LogoCerrarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_LogoCerrarSesion.Name = "btn_LogoCerrarSesion"
        Me.btn_LogoCerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_LogoCerrarSesion.Size = New System.Drawing.Size(67, 47)
        Me.btn_LogoCerrarSesion.TabIndex = 43
        '
        'lbl_Rol
        '
        Me.lbl_Rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Rol.Location = New System.Drawing.Point(751, 23)
        Me.lbl_Rol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(31, 19)
        Me.lbl_Rol.TabIndex = 42
        Me.lbl_Rol.Text = "Rol"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.ForeColor = System.Drawing.Color.Black
        Me.lbl_Usuario.Location = New System.Drawing.Point(777, 4)
        Me.lbl_Usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(60, 19)
        Me.lbl_Usuario.TabIndex = 41
        Me.lbl_Usuario.Text = "Usuario"
        '
        'PanelButtons
        '
        Me.PanelButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelButtons.Controls.Add(Me.btnMatricular)
        Me.PanelButtons.Controls.Add(Me.btnAsignar)
        Me.PanelButtons.Controls.Add(Me.btnMaterias)
        Me.PanelButtons.Controls.Add(Me.btnEstudiantes)
        Me.PanelButtons.Location = New System.Drawing.Point(0, 74)
        Me.PanelButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(1115, 52)
        Me.PanelButtons.TabIndex = 35
        '
        'btnMatricular
        '
        Me.btnMatricular.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnMatricular.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMatricular.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnMatricular.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnMatricular.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMatricular.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMatricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMatricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMatricular.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnMatricular.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMatricular.ForeColor = System.Drawing.Color.White
        Me.btnMatricular.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMatricular.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnMatricular.Location = New System.Drawing.Point(210, 1)
        Me.btnMatricular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMatricular.Name = "btnMatricular"
        Me.btnMatricular.Size = New System.Drawing.Size(163, 48)
        Me.btnMatricular.TabIndex = 6
        Me.btnMatricular.Text = "Matricula"
        '
        'btnAsignar
        '
        Me.btnAsignar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnAsignar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAsignar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAsignar.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnAsignar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAsignar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAsignar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAsignar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAsignar.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAsignar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAsignar.ForeColor = System.Drawing.Color.White
        Me.btnAsignar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAsignar.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnAsignar.Location = New System.Drawing.Point(388, 1)
        Me.btnAsignar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(163, 48)
        Me.btnAsignar.TabIndex = 5
        Me.btnAsignar.Text = "Asignar"
        '
        'btnMaterias
        '
        Me.btnMaterias.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnMaterias.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMaterias.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnMaterias.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnMaterias.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMaterias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMaterias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMaterias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMaterias.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnMaterias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMaterias.ForeColor = System.Drawing.Color.White
        Me.btnMaterias.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMaterias.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnMaterias.Location = New System.Drawing.Point(567, 1)
        Me.btnMaterias.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaterias.Name = "btnMaterias"
        Me.btnMaterias.Size = New System.Drawing.Size(163, 48)
        Me.btnMaterias.TabIndex = 4
        Me.btnMaterias.Text = "Cursos"
        '
        'btnEstudiantes
        '
        Me.btnEstudiantes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnEstudiantes.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEstudiantes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnEstudiantes.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnEstudiantes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEstudiantes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEstudiantes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEstudiantes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEstudiantes.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnEstudiantes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEstudiantes.ForeColor = System.Drawing.Color.White
        Me.btnEstudiantes.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEstudiantes.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnEstudiantes.Location = New System.Drawing.Point(745, 1)
        Me.btnEstudiantes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEstudiantes.Name = "btnEstudiantes"
        Me.btnEstudiantes.Size = New System.Drawing.Size(163, 48)
        Me.btnEstudiantes.TabIndex = 1
        Me.btnEstudiantes.Text = "Estudiantes"
        '
        'tmrOcultarMenu
        '
        Me.tmrOcultarMenu.Interval = 90
        '
        'tmrMostrarMenu
        '
        Me.tmrMostrarMenu.Interval = 90
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 505)
        Me.Controls.Add(Me.PanelButtons)
        Me.Controls.Add(Me.PanelLogo)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.panelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrincipal"
        Me.panelContainer.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.PanelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContainer As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents btnAsignar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaterias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelAbajo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEstados As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnApagar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMenuBar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tmrOcultarMenu As Timer
    Friend WithEvents tmrMostrarMenu As Timer
    Friend WithEvents btnEstudiantes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tmrHoraActual As Timer
    Friend WithEvents btn_LogoCerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents btnMatricular As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsuarios As Guna.UI2.WinForms.Guna2Button
End Class
