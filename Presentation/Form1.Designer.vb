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
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.inkRecuperarContrasena = New System.Windows.Forms.LinkLabel()
        Me.txtMostrarEncrypt = New System.Windows.Forms.TextBox()
        Me.ErrorLogin = New System.Windows.Forms.ErrorProvider(Me.components)
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
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnIniciarSesion.FlatAppearance.BorderSize = 0
        Me.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.btnIniciarSesion.Location = New System.Drawing.Point(246, 242)
        Me.btnIniciarSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(221, 27)
        Me.btnIniciarSesion.TabIndex = 19
        Me.btnIniciarSesion.Text = "Iniciar Sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(244, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(243, 188)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(246, 161)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(221, 22)
        Me.txtUsuario.TabIndex = 22
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtContrasena.Location = New System.Drawing.Point(246, 208)
        Me.txtContrasena.Multiline = True
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContrasena.Size = New System.Drawing.Size(221, 20)
        Me.txtContrasena.TabIndex = 23
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
        Me.PictureBox2.Location = New System.Drawing.Point(247, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'inkRecuperarContrasena
        '
        Me.inkRecuperarContrasena.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.inkRecuperarContrasena.AutoSize = True
        Me.inkRecuperarContrasena.BackColor = System.Drawing.Color.Transparent
        Me.inkRecuperarContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inkRecuperarContrasena.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.inkRecuperarContrasena.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.inkRecuperarContrasena.Location = New System.Drawing.Point(243, 282)
        Me.inkRecuperarContrasena.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inkRecuperarContrasena.Name = "inkRecuperarContrasena"
        Me.inkRecuperarContrasena.Size = New System.Drawing.Size(114, 13)
        Me.inkRecuperarContrasena.TabIndex = 26
        Me.inkRecuperarContrasena.TabStop = True
        Me.inkRecuperarContrasena.Text = "Recuperar Contraseña"
        '
        'txtMostrarEncrypt
        '
        Me.txtMostrarEncrypt.Location = New System.Drawing.Point(73, 233)
        Me.txtMostrarEncrypt.Name = "txtMostrarEncrypt"
        Me.txtMostrarEncrypt.Size = New System.Drawing.Size(100, 20)
        Me.txtMostrarEncrypt.TabIndex = 27
        Me.txtMostrarEncrypt.Visible = False
        '
        'ErrorLogin
        '
        Me.ErrorLogin.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 349)
        Me.Controls.Add(Me.txtMostrarEncrypt)
        Me.Controls.Add(Me.inkRecuperarContrasena)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.btnCuentaNueva)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "      "
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
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents inkRecuperarContrasena As LinkLabel
    Friend WithEvents txtMostrarEncrypt As TextBox
    Friend WithEvents ErrorLogin As ErrorProvider
End Class
