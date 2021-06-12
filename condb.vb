Module condb

    Public conectar As New SqlClient.SqlConnection

    Public cn As New SqlClient.SqlConnection("Data Source=localhost;Initial Catalog=base_proyecto;Integrated Security=True")
    Public cmd As New SqlClient.SqlCommand
    Public adt As New SqlClient.SqlDataAdapter
    Public ds As New DataSet
    Public sql As String

    Public Sub conecta()

        conectar.ConnectionString = ("Data Source=localhost;Initial Catalog=base_proyecto;Integrated Security=True")
        conectar.Open()


    End Sub





End Module
