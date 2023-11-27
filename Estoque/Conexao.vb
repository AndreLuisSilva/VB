Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Module Conexao
    Public conectar As SqlConnection
    Public comando As SqlCommand
    Public local As DataSet
    Public adaptar As SqlDataAdapter
    Public sql As String
    Public resultado As Integer
    Public registro As DataRow
    Public dt As DataSet
    Public cnn As String = "Server = localhost; Port = 5432; UserId = postgres; Password = knop123; Database = estoque_vb"
    Public vnivel As String
    Public contador As Integer
End Module
