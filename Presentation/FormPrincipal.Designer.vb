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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnMenuBar = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.btnPerfil = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.txtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAsignar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaterias = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEstudiantes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsuarios = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInicio = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEstados = New Guna.UI2.WinForms.Guna2Button()
        Me.btnApagar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.panelContainer.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelContainer
        '
        Me.panelContainer.Controls.Add(Me.PanelLateral)
        Me.panelContainer.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.panelContainer.Controls.Add(Me.Panel1)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 0)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(835, 459)
        Me.panelContainer.TabIndex = 36
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderRadius = 3
        Me.Guna2CustomGradientPanel1.BorderThickness = 1
        Me.Guna2CustomGradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Empty
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(708, 173)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(60, 215)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'btnMenuBar
        '
        Me.btnMenuBar.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMenuBar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMenuBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMenuBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMenuBar.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnMenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenuBar.ForeColor = System.Drawing.Color.White
        Me.btnMenuBar.Image = CType(resources.GetObject("btnMenuBar.Image"), System.Drawing.Image)
        Me.btnMenuBar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnMenuBar.Location = New System.Drawing.Point(0, 106)
        Me.btnMenuBar.Name = "btnMenuBar"
        Me.btnMenuBar.Size = New System.Drawing.Size(122, 46)
        Me.btnMenuBar.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 443)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 16)
        Me.Panel1.TabIndex = 0
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
        Me.btnSalir.Location = New System.Drawing.Point(798, -1)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(38, 27)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(730, -2)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(38, 27)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(768, -2)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(31, 27)
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
        Me.btnRestaurar.Location = New System.Drawing.Point(769, -2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(31, 27)
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
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(835, 23)
        Me.PanelTitulo.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Universidad Tecnológica Alajuela"
        '
        'PanelLogo
        '
        Me.PanelLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLogo.BackColor = System.Drawing.Color.White
        Me.PanelLogo.Controls.Add(Me.btnPerfil)
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.PictureBox2)
        Me.PanelLogo.Location = New System.Drawing.Point(0, 23)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(835, 38)
        Me.PanelLogo.TabIndex = 34
        '
        'btnPerfil
        '
        Me.btnPerfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPerfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPerfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPerfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPerfil.FillColor = System.Drawing.Color.Empty
        Me.btnPerfil.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnPerfil.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnPerfil.Image = CType(resources.GetObject("btnPerfil.Image"), System.Drawing.Image)
        Me.btnPerfil.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPerfil.Location = New System.Drawing.Point(783, 0)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnPerfil.Size = New System.Drawing.Size(50, 38)
        Me.btnPerfil.TabIndex = 37
        '
        'PanelButtons
        '
        Me.PanelButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelButtons.Controls.Add(Me.txtBuscar)
        Me.PanelButtons.Controls.Add(Me.btnAsignar)
        Me.PanelButtons.Controls.Add(Me.btnMaterias)
        Me.PanelButtons.Controls.Add(Me.Guna2Button3)
        Me.PanelButtons.Controls.Add(Me.btnEstudiantes)
        Me.PanelButtons.Controls.Add(Me.btnUsuarios)
        Me.PanelButtons.Controls.Add(Me.btnInicio)
        Me.PanelButtons.Location = New System.Drawing.Point(0, 60)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(836, 42)
        Me.PanelButtons.TabIndex = 35
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Animated = True
        Me.txtBuscar.AutoRoundedCorners = True
        Me.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtBuscar.BorderRadius = 9
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.DefaultText = ""
        Me.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.IconLeft = CType(resources.GetObject("txtBuscar.IconLeft"), System.Drawing.Image)
        Me.txtBuscar.Location = New System.Drawing.Point(661, 11)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.PlaceholderText = "Buscar"
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(171, 21)
        Me.txtBuscar.TabIndex = 1
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
        Me.btnAsignar.Location = New System.Drawing.Point(527, 1)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(122, 39)
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
        Me.btnMaterias.Location = New System.Drawing.Point(395, 1)
        Me.btnMaterias.Name = "btnMaterias"
        Me.btnMaterias.Size = New System.Drawing.Size(122, 39)
        Me.btnMaterias.TabIndex = 4
        Me.btnMaterias.Text = "Materias"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Button3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Guna2Button3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Guna2Button3.Location = New System.Drawing.Point(393, 1)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(122, 39)
        Me.Guna2Button3.TabIndex = 3
        Me.Guna2Button3.Text = "Inicio"
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
        Me.btnEstudiantes.Location = New System.Drawing.Point(263, 1)
        Me.btnEstudiantes.Name = "btnEstudiantes"
        Me.btnEstudiantes.Size = New System.Drawing.Size(122, 39)
        Me.btnEstudiantes.TabIndex = 2
        Me.btnEstudiantes.Text = "Estudiantes"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnUsuarios.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnUsuarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnUsuarios.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUsuarios.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnUsuarios.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnUsuarios.Location = New System.Drawing.Point(132, 1)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(122, 39)
        Me.btnUsuarios.TabIndex = 1
        Me.btnUsuarios.Text = "Usuarios"
        '
        'btnInicio
        '
        Me.btnInicio.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnInicio.Checked = True
        Me.btnInicio.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnInicio.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnInicio.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInicio.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnInicio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnInicio.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnInicio.Location = New System.Drawing.Point(0, 1)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(122, 39)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "Inicio"
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.White
        Me.PanelLateral.Controls.Add(Me.btnCerrarSesion)
        Me.PanelLateral.Controls.Add(Me.btnApagar)
        Me.PanelLateral.Controls.Add(Me.btnEstados)
        Me.PanelLateral.Controls.Add(Me.btnMenuBar)
        Me.PanelLateral.Controls.Add(Me.btnHome)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(122, 443)
        Me.PanelLateral.TabIndex = 2
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
        Me.btnHome.Location = New System.Drawing.Point(0, 156)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(122, 46)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Inicio"
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
        Me.btnEstados.Location = New System.Drawing.Point(0, 206)
        Me.btnEstados.Name = "btnEstados"
        Me.btnEstados.Size = New System.Drawing.Size(122, 46)
        Me.btnEstados.TabIndex = 4
        Me.btnEstados.Text = "  Estados"
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
        Me.btnApagar.Location = New System.Drawing.Point(0, 395)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(122, 46)
        Me.btnApagar.TabIndex = 5
        Me.btnApagar.Text = " Apagar"
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 345)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(122, 46)
        Me.btnCerrarSesion.TabIndex = 6
        Me.btnCerrarSesion.Text = "Salir"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 459)
        Me.Controls.Add(Me.PanelButtons)
        Me.Controls.Add(Me.PanelLogo)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.panelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrincipal"
        Me.panelContainer.ResumeLayout(False)
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.PanelButtons.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
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
    Friend WithEvents btnInicio As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEstudiantes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsuarios As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAsignar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaterias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPerfil As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnMenuBar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEstados As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnApagar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCerrarSesion As Guna.UI2.WinForms.Guna2Button
End Class
