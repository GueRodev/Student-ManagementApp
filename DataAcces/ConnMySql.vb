Imports MySql.Data.MySqlClient
' Clase abstracta para manejar la conexión a MySQL
Public MustInherit Class ConnMySql

    ' Cadena de conexión para conectarse a la base de datos MySQL
    Private connectionString As String

    ' Constructor protegido para evitar la creación directa de instancias de esta clase
    Protected Sub New()
        connectionString = "Server=localhost;userid=root;password='';database=uta_database2"
    End Sub

    'Función protegida para obtener una conexión a MySQL
    Protected Function GetConnection() As MySqlConnection
        ' Crea y devuelve una nueva instancia de MySqlConnection utilizando la cadena de conexión
        Return New MySqlConnection(connectionString)
    End Function

End Class

