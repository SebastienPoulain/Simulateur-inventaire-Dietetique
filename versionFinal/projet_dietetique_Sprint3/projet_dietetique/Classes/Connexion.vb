Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient


Public Class Connexion


    Private _position As Integer = 0
    Public _ConnectionStringMain As String

    Private _conn As New MySqlConnection
    Private _cmd As MySqlCommand
    Dim gestionOperation As New MySqlCommandBuilder

    'Constructeur par défault
    Sub New()
        _ConnectionStringMain = "Server=localhost; DataBase=simulateur_inventaire; Uid=root; Pwd="
    End Sub




    '- Permet de set ou get la position actuel de la personne sélectionner
    Public Property position() As Integer
        Get
            Return _position
        End Get
        Set(ByVal value As Integer)
            _position = value
        End Set
    End Property

    '- Permet de get ou set la connection string de la bd
    Public Property ConnectionStringMain() As String
        Get
            Return _ConnectionStringMain
        End Get
        Set(ByVal value As String)
            _ConnectionStringMain = value
        End Set
    End Property

    'Test la connexion.'
    Function test_connexion() As Boolean
        _conn.ConnectionString = _ConnectionStringMain

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch ae As MySqlException
            Return False
        End Try

        _conn.Close()
        Return True
    End Function


    '- Remplie mon dataset des données de ma bd en fonction de la requête envoyée.
    Sub Requete(ByVal req As String, ByVal ds As DataSet, ByVal da As MySqlDataAdapter, ByVal table As String)
        _conn.Close()
        _conn.ConnectionString = _ConnectionStringMain




        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try



        _cmd = New MySqlCommand
        _cmd.Connection = _conn
        _cmd.CommandText = req
        da.SelectCommand = _cmd



        Try
            ' _cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(_cmd)
            da.Fill(ds, table)

        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())

        End Try

        _conn.Close()
    End Sub


    '- Met à jour la bd selon la requete que je suis envoie. Elle sert pour les inserts, les updates, et les deletes.
    Sub InsDelUpd(ByVal req As String)

        _conn.ConnectionString = _ConnectionStringMain

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())
        End Try



        _cmd = New MySqlCommand(req, _conn)


        Try
            _cmd.ExecuteNonQuery()
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())

        End Try

        _conn.Close()


    End Sub


    '- Met à jour la bd en fonction du dataset que je lui passe en paramètre
    Sub miseAjourBD(ByVal ds As DataSet, ByVal da As MySqlDataAdapter, tbl As String)

        _conn.ConnectionString = _ConnectionStringMain

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try



        Try
            gestionOperation = New MySqlCommandBuilder(da)
            da.Update(ds, tbl)
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())
        End Try

        _conn.Close()
    End Sub



    '- Met à jour un dataset avec les informations de la bd.
    Sub miseAjourDS(ByRef ds As DataSet, ByRef da As MySqlDataAdapter, req As String, table As String)
        ds = New DataSet
        da = New MySqlDataAdapter
        Requete(req, ds, da, table)
    End Sub

    'Effectue une requête et recupère la donnée reçu dans une variable (par exemble select max(id) from...).'
    Function Requete(ByVal req As String)
        _conn.ConnectionString = _ConnectionStringMain
        Dim var As Double = 0

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())
        End Try



        _cmd = New MySqlCommand(req, _conn)


        Try
            _cmd.ExecuteNonQuery()
            var = _cmd.ExecuteScalar
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())

        End Try

        _conn.Close()
        Return var
    End Function
    ''' <summary>
    ''' Fonction qui effectue une requête à la base de données et recupère la donnée reçu dans une variable de type string'
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <param name="req"></param>
    ''' On met en paramètre la requête que l'on veut faire sur la base de données.
    ''' <returns></returns>
    ''' La fonction va récupérer le contenu de la requête et la mettre dans une variable de type string.
    ''' <tag>2019</tag>
    Function Requete2(ByVal req As String)
        _conn.ConnectionString = _ConnectionStringMain
        Dim var As String = ""

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())
        End Try



        _cmd = New MySqlCommand(req, _conn)


        Try
            _cmd.ExecuteNonQuery()
            var = _cmd.ExecuteScalar
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())

        End Try

        _conn.Close()
        Return var
    End Function

End Class
