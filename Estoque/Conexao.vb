Imports Npgsql
Module Conexao
    Public conectar As NpgsqlConnection
    Public comando As NpgsqlCommand
    Public local As DataSet
    Public adaptar As NpgsqlDataAdapter
    Public sql As String
    Public resultado As Integer
    Public registro As DataRow
    Public dt As DataSet
    Public cnn As String = "Host=localhost;Port=5432;Database=estoque_vb;Username=postgres;Password=knop123;"
    Public vnivel As String
    Public contador As Integer
End Module
