Imports System.Data.SqlClient


Module condb

    Public conectar As New SqlClient.SqlConnection

    Public cn As New SqlClient.SqlConnection("Data Source=localhost;Initial Catalog=base_proyecto;Integrated Security=True")
    Public cmd As New SqlClient.SqlCommand
    Public adt As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Public sql As String

    Public Sub conecta()

        conectar.ConnectionString = ("Data Source=localhost;Initial Catalog=base_proyecto;Integrated Security=True")

        If (conectar.State = 0) Then
            conectar.Open()
        Else
            MsgBox("Enlace de Conexión ya está abierto", MsgBoxStyle.OkOnly, "Mensaje")
        End If


    End Sub

    Public Sub CerrarConexion()
        If conectar.State = 1 Then
            conectar.Close()
        Else
            MsgBox("Enlace de Conexión ya está cerrado", MsgBoxStyle.OkOnly, "Mensaje")
        End If
    End Sub

    Public Sub ModificarBD(instruccion As String)

        Dim registrar As New SqlCommand(instruccion, conectar)
        registrar.ExecuteNonQuery()
        registrar.Dispose()

    End Sub

    Public Function LecturaBD(instruccion As String) As SqlDataReader

        Dim recuperar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(instruccion, conectar)
        recuperar = ejecutar.ExecuteReader

        Return recuperar

    End Function








End Module
