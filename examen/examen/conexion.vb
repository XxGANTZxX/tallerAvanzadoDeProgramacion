Imports System.Data.SqlClient
Imports System.IO.MemoryStream
Imports System.Windows.Forms



Public Class conexion
    Public cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUJ4JJR\SQLGERMAN;Initial catalog=softrentacar;Integrated security=true")
    Public dt As DataTable
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public rd As SqlDataReader
    Public cmd As New SqlCommand
    Public ms As New System.IO.MemoryStream()
    Public dbds As DataSet
    Public reader As SqlDataReader



    'Dim da As New SqlDataAdapter

    Public Sub conectar()

        Try
            cn.Open()
        Catch ex As Exception
            MsgBox("No Conecta", MsgBoxStyle.Critical, "Soft Farmacia")
        End Try
    End Sub

    Public Sub CerrarConexion()
        cn.Close()
    End Sub

End Class
