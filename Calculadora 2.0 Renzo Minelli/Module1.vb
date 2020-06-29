Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Module Module1
    Dim ubicacion As String = "server=localhost; user id=root ; password='';database = calcu"
    Public Conexion As MySqlDataAdapter
    Public resu As DataTable
    Public Consulta As String
    Public MysqlConexion As MySqlConnection = New MySqlConnection(ubicacion)


    Public Sub consultar()
        Try
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            resu = New DataTable
            Conexion.Fill(resu)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    
End Module


