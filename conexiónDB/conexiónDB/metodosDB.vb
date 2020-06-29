Imports MySql.Data.MySqlClient

Module metodosDB
    Public conn As New MySqlConnection("server=localhost; user=root; password=; database=calculadora; port=3306")

    Public Sub conexion()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function consultar(ByVal sql As String) As DataSet
        Dim ds As New DataSet

        Try
            Dim reader As New MySqlDataAdapter(Sql, conn)
            reader.Fill(ds, "Historial")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return ds
    End Function

End Module
