Imports System.Data
Imports System.Text.RegularExpressions
Imports Domain
Imports Common
Public Class Panel_Usuarios
    'Inicializar Constructor
    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub Panel_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamar al método para mostrar usuarios cuando se cargue el formulario
        MostrarUsuarios()
    End Sub

    Private Sub MostrarUsuarios()
        ' Instanciar UsuarioModelo
        Dim usuarioModelo As New UsuarioModelo()

        ' Obtener los datos de los usuarios
        Dim dtUsuarios As New DataTable()
        dtUsuarios = usuarioModelo.dominio_ObtenerUsuarios()

        ' Configurar las columnas del DataGridView
        dgv_usuarios.Columns.Clear() ' Limpiar las columnas existentes
        dgv_usuarios.AutoGenerateColumns = False ' Deshabilitar la generación automática de columnas

        ' Agregar las columnas necesarias
        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "ID"
        colID.HeaderText = "ID"
        dgv_usuarios.Columns.Add(colID)

        Dim colUsuario As New DataGridViewTextBoxColumn()
        colUsuario.DataPropertyName = "Usuario"
        colUsuario.HeaderText = "Usuario"
        dgv_usuarios.Columns.Add(colUsuario)

        Dim colEmail As New DataGridViewTextBoxColumn()
        colEmail.DataPropertyName = "Email"
        colEmail.HeaderText = "Email"
        dgv_usuarios.Columns.Add(colEmail)

        Dim colRol As New DataGridViewTextBoxColumn()
        colRol.DataPropertyName = "Rol"
        colRol.HeaderText = "Rol"
        dgv_usuarios.Columns.Add(colRol)

        ' Asignar los datos al DataGridView
        dgv_usuarios.DataSource = dtUsuarios
    End Sub

    Private Sub btnGuardarUsuario_Click(sender As Object, e As EventArgs) Handles btnGuardarUsuario.Click
        ' Mostrar un cuadro de diálogo de confirmación
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas crear un nuevo usuario?", "Confirmar creación de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si se confirmó la creación de usuario
        If respuesta = DialogResult.Yes Then
            ' Obtener los datos del usuario desde los campos del formulario
            Dim usuario As String = txtGuardarUsuario.Text
            Dim contraseña As String = txtGuardarPasswordUsuario.Text
            Dim email As String = txtGuardarEmailUsuario.Text

            ' Validar que los campos no estén vacíos
            If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contraseña) OrElse String.IsNullOrEmpty(email) Then
                MessageBox.Show("Por favor, complete todos los campos.")
                Return
            End If

            ' Validar el nombre de usuario
            If Not ValidarUsuario(usuario) Then
                MessageBox.Show("El nombre de usuario debe tener máximo 8 caracteres y como máximo 2 números.", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar la contraseña
            If Not ValidarContraseña(contraseña) Then
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres y contener al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar el correo electrónico
            If Not ValidarCorreo(email) Then
                MessageBox.Show("Ingrese un correo electrónico válido.", "Error de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Instanciar UsuarioModelo
            Dim usuarioModelo As New UsuarioModelo()

            ' Llamar al método dominio_Registrar para registrar el nuevo usuario con la contraseña encriptada
            Dim registroExitoso As Boolean = usuarioModelo.dominio_Registrar(usuario, contraseña, email)

            ' Verificar si el registro fue exitoso
            If registroExitoso Then
                MessageBox.Show("Usuario registrado correctamente.")

                ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
                CargarDatosUsuarios()

                ' Limpia los campos después de registrar el usuario
                LimpiarCampos()
            Else
                MessageBox.Show("Error al registrar el usuario. Inténtelo de nuevo.")
            End If
        End If
    End Sub

    Private Function ValidarUsuario(usuario As String) As Boolean
        ' Verificar que el usuario no tenga más de 8 caracteres
        If usuario.Length > 8 Then
            Return False
        End If

        ' Contador para contar números
        Dim numerosCount As Integer = 0

        ' Iterar sobre cada carácter del usuario
        For Each c As Char In usuario
            ' Verificar si el carácter es un número
            If Char.IsDigit(c) Then
                ' Incrementar el contador de números
                numerosCount += 1

                ' Verificar si se excede el límite de números permitidos
                If numerosCount > 2 Then
                    Return False
                End If
            End If
        Next

        ' Validación exitosa si se cumplen todas las condiciones
        Return True
    End Function

    Private Function ValidarCorreo(correo As String) As Boolean
        ' Verificar si el correo electrónico contiene un "@" y termina con ".com"
        Return correo.Contains("@") AndAlso correo.EndsWith(".com")
    End Function

    Private Function ValidarContraseña(contraseña As String) As Boolean
        ' Verificar si la contraseña cumple con los criterios de seguridad
        If contraseña.Length < 8 Then
            Return False
        End If

        ' Verificar si la contraseña contiene al menos una letra mayúscula, una letra minúscula, un número y un carácter especial
        If Not Regex.IsMatch(contraseña, "(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}") Then
            Return False
        End If

        Return True
    End Function

    Private Sub LimpiarCampos()
        ' Limpiar los campos del formulario
        txtGuardarUsuario.Clear()
        txtGuardarPasswordUsuario.Clear()
        txtGuardarEmailUsuario.Clear()
        txtGuardarUsuario.Focus()
    End Sub

    Private Sub dgv_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellClick
        ' Verificar si la celda seleccionada no es el encabezado de la fila
        If e.RowIndex >= 0 Then
            ' Obtener los valores de la fila seleccionada y mostrarlos en los campos de texto
            Dim selectedRow As DataGridViewRow = dgv_usuarios.Rows(e.RowIndex)
            txt_ID_Usuario.Text = selectedRow.Cells(0).Value.ToString()
            txtGuardarUsuario.Text = selectedRow.Cells(1).Value.ToString()
            txtGuardarEmailUsuario.Text = selectedRow.Cells(2).Value.ToString()
        End If
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        ' Obtener el ID del usuario seleccionado en el DataGridView
        Dim idUsuario As Integer
        If Integer.TryParse(txt_ID_Usuario.Text, idUsuario) AndAlso idUsuario > 0 Then
            ' Mostrar un cuadro de diálogo de confirmación
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que desea realizar cambios a este usuario?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Verificar si se confirmó la actualización
            If respuesta = DialogResult.Yes Then
                ' Obtener los datos del usuario desde los campos del formulario
                Dim usuario As String = txtGuardarUsuario.Text
                Dim email As String = txtGuardarEmailUsuario.Text

                ' Validar que los campos no estén vacíos
                If String.IsNullOrWhiteSpace(usuario) OrElse String.IsNullOrWhiteSpace(email) Then
                    MessageBox.Show("Por favor, complete todos los campos.")
                    Return
                End If

                ' Instanciar UsuarioModelo
                Dim usuarioModelo As New UsuarioModelo()

                ' Llamar al método dominio_ActualizarUsuario para actualizar los datos del usuario
                Dim actualizacionExitosa As Boolean = usuarioModelo.dominio_ActualizarUsuario(idUsuario, usuario, email)

                ' Verificar si la actualización fue exitosa
                If actualizacionExitosa Then
                    MessageBox.Show("Usuario actualizado correctamente.")

                    ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
                    CargarDatosUsuarios()

                    ' Limpiar los campos después de actualizar el usuario
                    LimpiarCampos()
                Else
                    MessageBox.Show("Error al actualizar el usuario. Inténtelo de nuevo.")
                End If
            End If
        Else
            MessageBox.Show("Por favor, seleccione un usuario de la lista para editar.")
        End If
    End Sub


    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        ' Obtener el ID del usuario seleccionado en el DataGridView
        Dim idUsuario As Integer
        If Integer.TryParse(txt_ID_Usuario.Text, idUsuario) AndAlso idUsuario > 0 Then
            ' Mostrar un cuadro de diálogo de confirmación
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Verificar si se confirmó la eliminación
            If respuesta = DialogResult.Yes Then
                ' Instanciar UsuarioModelo
                Dim usuarioModelo As New UsuarioModelo()

                ' Llamar al método dominio_EliminarUsuario para eliminar el usuario
                Dim eliminacionExitosa As Boolean = usuarioModelo.dominio_EliminarUsuario(idUsuario)

                ' Verificar si la eliminación fue exitosa
                If eliminacionExitosa Then
                    MessageBox.Show("Usuario eliminado correctamente.")

                    ' Recargar los datos del DataGridView para reflejar los cambios en tiempo real
                    CargarDatosUsuarios()

                    ' Limpiar los campos después de eliminar el usuario
                    LimpiarCampos()
                Else
                    MessageBox.Show("Error al eliminar el usuario. Inténtelo de nuevo.")
                End If
            End If
        Else
            MessageBox.Show("Por favor, seleccione un usuario de la lista para eliminar.")
        End If
    End Sub


    Private Sub CargarDatosUsuarios()
        ' Obtener los datos actualizados de los usuarios y cargarlos en el DataGridView
        Dim usuarioModelo As New UsuarioModelo()
        Dim dtUsuarios As DataTable = usuarioModelo.dominio_ObtenerUsuarios()
        dgv_usuarios.DataSource = dtUsuarios
    End Sub


End Class
