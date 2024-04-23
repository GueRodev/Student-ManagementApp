<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Inicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Inicio))
        Me.lblCantidadUsuarios = New System.Windows.Forms.Label()
        Me.Pnl_CantidadUser = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Pnl_CantidadEstudiantes = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pnl_CantidadMaterias = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_HORA = New System.Windows.Forms.Label()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Pnl_CantidadUser.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_CantidadEstudiantes.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_CantidadMaterias.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantidadUsuarios
        '
        Me.lblCantidadUsuarios.AutoSize = True
        Me.lblCantidadUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidadUsuarios.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCantidadUsuarios.Location = New System.Drawing.Point(246, 40)
        Me.lblCantidadUsuarios.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCantidadUsuarios.Name = "lblCantidadUsuarios"
        Me.lblCantidadUsuarios.Size = New System.Drawing.Size(56, 65)
        Me.lblCantidadUsuarios.TabIndex = 0
        Me.lblCantidadUsuarios.Text = "#"
        '
        'Pnl_CantidadUser
        '
        Me.Pnl_CantidadUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Pnl_CantidadUser.Controls.Add(Me.Guna2PictureBox1)
        Me.Pnl_CantidadUser.Controls.Add(Me.lblCantidadUsuarios)
        Me.Pnl_CantidadUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadUser.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadUser.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pnl_CantidadUser.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_CantidadUser.Location = New System.Drawing.Point(260, 235)
        Me.Pnl_CantidadUser.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Pnl_CantidadUser.Name = "Pnl_CantidadUser"
        Me.Pnl_CantidadUser.Size = New System.Drawing.Size(354, 133)
        Me.Pnl_CantidadUser.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(40, 13)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(138, 102)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 5
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Pnl_CantidadEstudiantes
        '
        Me.Pnl_CantidadEstudiantes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Pnl_CantidadEstudiantes.Controls.Add(Me.Guna2PictureBox2)
        Me.Pnl_CantidadEstudiantes.Controls.Add(Me.Label1)
        Me.Pnl_CantidadEstudiantes.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadEstudiantes.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadEstudiantes.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pnl_CantidadEstudiantes.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_CantidadEstudiantes.Location = New System.Drawing.Point(742, 235)
        Me.Pnl_CantidadEstudiantes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Pnl_CantidadEstudiantes.Name = "Pnl_CantidadEstudiantes"
        Me.Pnl_CantidadEstudiantes.Size = New System.Drawing.Size(354, 133)
        Me.Pnl_CantidadEstudiantes.TabIndex = 2
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(30, 15)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(138, 102)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 6
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(268, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "#"
        '
        'Pnl_CantidadMaterias
        '
        Me.Pnl_CantidadMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Pnl_CantidadMaterias.Controls.Add(Me.Guna2PictureBox3)
        Me.Pnl_CantidadMaterias.Controls.Add(Me.Label2)
        Me.Pnl_CantidadMaterias.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadMaterias.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadMaterias.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pnl_CantidadMaterias.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_CantidadMaterias.Location = New System.Drawing.Point(1208, 235)
        Me.Pnl_CantidadMaterias.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Pnl_CantidadMaterias.Name = "Pnl_CantidadMaterias"
        Me.Pnl_CantidadMaterias.Size = New System.Drawing.Size(354, 133)
        Me.Pnl_CantidadMaterias.TabIndex = 3
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(40, 15)
        Me.Guna2PictureBox3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(138, 102)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 7
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(278, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 65)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "#"
        '
        'lbl_HORA
        '
        Me.lbl_HORA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_HORA.AutoSize = True
        Me.lbl_HORA.BackColor = System.Drawing.Color.Transparent
        Me.lbl_HORA.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HORA.ForeColor = System.Drawing.Color.White
        Me.lbl_HORA.Location = New System.Drawing.Point(491, 614)
        Me.lbl_HORA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_HORA.Name = "lbl_HORA"
        Me.lbl_HORA.Size = New System.Drawing.Size(441, 170)
        Me.lbl_HORA.TabIndex = 4
        Me.lbl_HORA.Text = "HORA"
        '
        'tmrHora
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(676, 398)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(401, 226)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Panel_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_HORA)
        Me.Controls.Add(Me.Pnl_CantidadMaterias)
        Me.Controls.Add(Me.Pnl_CantidadEstudiantes)
        Me.Controls.Add(Me.Pnl_CantidadUser)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Panel_Inicio"
        Me.Size = New System.Drawing.Size(1670, 883)
        Me.Pnl_CantidadUser.ResumeLayout(False)
        Me.Pnl_CantidadUser.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_CantidadEstudiantes.ResumeLayout(False)
        Me.Pnl_CantidadEstudiantes.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_CantidadMaterias.ResumeLayout(False)
        Me.Pnl_CantidadMaterias.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantidadUsuarios As Label
    Friend WithEvents Pnl_CantidadUser As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Pnl_CantidadEstudiantes As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Pnl_CantidadMaterias As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_HORA As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tmrHora As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
