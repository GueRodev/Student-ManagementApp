<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnMinimizarLogin = New System.Windows.Forms.Button()
        Me.btnCerrarLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCuentaNueva = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ErrorLogin = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_Usuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_Contrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_IniciarSesion = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 323)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnMinimizarLogin)
        Me.PanelTitulo.Controls.Add(Me.btnCerrarLogin)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(488, 26)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnMinimizarLogin
        '
        Me.btnMinimizarLogin.FlatAppearance.BorderSize = 0
        Me.btnMinimizarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMinimizarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMinimizarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizarLogin.Image = CType(resources.GetObject("btnMinimizarLogin.Image"), System.Drawing.Image)
        Me.btnMinimizarLogin.Location = New System.Drawing.Point(412, -1)
        Me.btnMinimizarLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizarLogin.Name = "btnMinimizarLogin"
        Me.btnMinimizarLogin.Size = New System.Drawing.Size(38, 27)
        Me.btnMinimizarLogin.TabIndex = 4
        Me.btnMinimizarLogin.UseVisualStyleBackColor = True
        '
        'btnCerrarLogin
        '
        Me.btnCerrarLogin.FlatAppearance.BorderSize = 0
        Me.btnCerrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarLogin.Image = CType(resources.GetObject("btnCerrarLogin.Image"), System.Drawing.Image)
        Me.btnCerrarLogin.Location = New System.Drawing.Point(450, -1)
        Me.btnCerrarLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrarLogin.Name = "btnCerrarLogin"
        Me.btnCerrarLogin.Size = New System.Drawing.Size(38, 27)
        Me.btnCerrarLogin.TabIndex = 3
        Me.btnCerrarLogin.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 339)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 10)
        Me.Panel1.TabIndex = 2
        '
        'btnCuentaNueva
        '
        Me.btnCuentaNueva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCuentaNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnCuentaNueva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCuentaNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnCuentaNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCuentaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentaNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuentaNueva.ForeColor = System.Drawing.Color.White
        Me.btnCuentaNueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuentaNueva.Location = New System.Drawing.Point(59, 156)
        Me.btnCuentaNueva.Name = "btnCuentaNueva"
        Me.btnCuentaNueva.Size = New System.Drawing.Size(107, 34)
        Me.btnCuentaNueva.TabIndex = 18
        Me.btnCuentaNueva.Text = "Cuenta Nueva"
        Me.btnCuentaNueva.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(231, 312)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Universidad Tecnológica Alajuela"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(247, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'ErrorLogin
        '
        Me.ErrorLogin.ContainerControl = Me
        '
        'txt_Usuario
        '
        Me.txt_Usuario.AutoRoundedCorners = True
        Me.txt_Usuario.BorderRadius = 10
        Me.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Usuario.DefaultText = ""
        Me.txt_Usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Usuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_Usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Usuario.IconLeft = CType(resources.GetObject("txt_Usuario.IconLeft"), System.Drawing.Image)
        Me.txt_Usuario.Location = New System.Drawing.Point(246, 163)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Usuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Usuario.PlaceholderText = "Usuario"
        Me.txt_Usuario.SelectedText = ""
        Me.txt_Usuario.Size = New System.Drawing.Size(221, 22)
        Me.txt_Usuario.TabIndex = 28
        '
        'txt_Contrasena
        '
        Me.txt_Contrasena.AutoRoundedCorners = True
        Me.txt_Contrasena.BorderRadius = 10
        Me.txt_Contrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Contrasena.DefaultText = ""
        Me.txt_Contrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Contrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Contrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Contrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Contrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Contrasena.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_Contrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Contrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Contrasena.IconLeft = CType(resources.GetObject("txt_Contrasena.IconLeft"), System.Drawing.Image)
        Me.txt_Contrasena.Location = New System.Drawing.Point(246, 200)
        Me.txt_Contrasena.Name = "txt_Contrasena"
        Me.txt_Contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_Contrasena.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Contrasena.PlaceholderText = "Contraseña"
        Me.txt_Contrasena.SelectedText = ""
        Me.txt_Contrasena.Size = New System.Drawing.Size(221, 22)
        Me.txt_Contrasena.TabIndex = 29
        '
        'btn_IniciarSesion
        '
        Me.btn_IniciarSesion.AutoRoundedCorners = True
        Me.btn_IniciarSesion.BorderRadius = 12
        Me.btn_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_IniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_IniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_IniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_IniciarSesion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_IniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_IniciarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_IniciarSesion.FillColor2 = System.Drawing.Color.DarkSeaGreen
        Me.btn_IniciarSesion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_IniciarSesion.ForeColor = System.Drawing.Color.White
        Me.btn_IniciarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IniciarSesion.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_IniciarSesion.Location = New System.Drawing.Point(246, 235)
        Me.btn_IniciarSesion.Name = "btn_IniciarSesion"
        Me.btn_IniciarSesion.Size = New System.Drawing.Size(221, 27)
        Me.btn_IniciarSesion.TabIndex = 30
        Me.btn_IniciarSesion.Text = "Iniciar Sesión"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 349)
        Me.Controls.Add(Me.btn_IniciarSesion)
        Me.Controls.Add(Me.txt_Contrasena)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCuentaNueva)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnMinimizarLogin As Button
    Friend WithEvents btnCerrarLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCuentaNueva As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ErrorLogin As ErrorProvider
    Friend WithEvents txt_Contrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_IniciarSesion As Guna.UI2.WinForms.Guna2GradientButton
End Class
