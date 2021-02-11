Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Module mod_regex
    Dim gestionBd As New Connexion
    Dim dataTable = New DataTable
    Dim dataAdapter As New MySqlDataAdapter
    Dim dataSet As DataSet
#Region "regex"
    'Utilisé pour un numéro de cours.'
    Public Function NoCours(cours As String)
        Dim regex As Regex = New Regex("[a-zA-Z0-9]{3}(-)[a-zA-Z0-9]{3}(-)[a-zA-Z0-9]{2}")
        Dim match As Match = regex.Match(cours)
        Return match.Success
    End Function

    'Utilisé pour un nom commun (pas pour un nom d'utilisateur).'
    Public Function Nom(nm As String)
        Dim regex As Regex = New Regex("^[a-z0-9\s,.'\p{L}-]+$")
        Dim match As Match = regex.Match(nm)
        Return match.Success
    End Function

    'Utilisé pour un nom d'exercice.'
    Public Function Exercice(nm As String)
        Dim regex As Regex = New Regex("^[a-z0-9\s,.'\p{L}(!)(?)($)(%)(&)(*)(+)(/)(=)("")(«)(»)(_)-]+$")
        Dim match As Match = regex.Match(nm)
        Return match.Success
    End Function

    'Utilisé pour un nom d'utilisateur.'
    Public Function Utls(_utls As String)
        Dim regex As Regex = New Regex("^[a-zA-Z0-9(_)-]+$")
        Dim match As Match = regex.Match(_utls)
        Return match.Success
    End Function

    ''' <summary>
    ''' Fonction qui vérifie si le taux de taxes entré est valide.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <param name="str"></param>
    ''' taux en paramètre
    ''' <returns></returns>
    ''' retourne true si valide sinon false
    ''' <tag>2019</tag>
    Function Taux_Taxes_Ok(ByVal str As String) As Boolean
        If System.Text.RegularExpressions.Regex.IsMatch(str, "^100$|^\d{0,2}(\,\d{1,3})? *%?$") Then
            Return True
        Else
            Return False
        End If
    End Function

    'Utilisé pour un nom d'utilisateur sans chiffre (generation automatique).'
    Public Function Utls_2(_utls As String)
        Dim regex As Regex = New Regex("^[a-zA-ZA-Z(_)-]+$")
        Dim match As Match = regex.Match(_utls)
        Return match.Success
    End Function

    'Mot de passe.'
    Public Function Mdp(_mdp As String)
        Dim regex As Regex = New Regex("^.*(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$")
        Dim match As Match = regex.Match(_mdp)
        Return match.Success
    End Function

    'Pour des regex variables.'
    Public Function RgxVariable(mot As String, rgx As String)
        Dim regex As Regex = New Regex(rgx)
        Dim match As Match = regex.Match(mot)
        Return match.Success
    End Function

    'Numéro de produit
    Public Function Est_Numero_Produit(_num As String)
        Dim regex As New Regex("^[a-zA-Z0-9]{2,10}$")

        Return regex.IsMatch(_num)
    End Function

    'Code barre
    Public Function Est_Code_Barre(_code As String)
        Dim regex As New Regex("[0-9]{11,13}")

        Return regex.IsMatch(_code)
    End Function

    'Code PLU
    Public Function Est_Code_PLU(_code As String)
        Dim regex As New Regex("[0-9]{4,5}")

        Return regex.IsMatch(_code)
    End Function

    'Tout ce qui concerne les noms
    Public Function Est_Nom(_nom As String)
        Dim regex As New Regex("(?i)^(?:(?![×Þß÷þø])[-'a-zÀ-ÿ\s.])+$")

        Return regex.IsMatch(_nom)
    End Function

    'Nombre
    Public Function Est_Nombre(_nombre As String)
        Dim regex As New Regex("(^\d{1,5}$|^\d{1,5}[\,\.]\d{1,2}$)")

        Return regex.IsMatch(_nombre)
    End Function

    ''' <summary>
    ''' Fonction déterminant si l'allergène que l'on désire ajouter à la liste des allergènes correspond au regex établit ci-dessous.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <param name="str"></param>
    ''' On prend en paramètre le nom de l'allergène que l'on veut ajouter
    ''' <returns></returns>
    ''' On retourne true si il correspond ou false si il ne correspond pas
    ''' <tag>2019</tag>
    Function Est_Allergene(ByVal str As String) As Boolean
        If System.Text.RegularExpressions.Regex.IsMatch(str, "^[A-Za-zé\sèàê]+$") Then
            Return True
        Else
            Return False
        End If
    End Function

    'Téléphone
    Function Est_Telephone(ByVal str As String) As Boolean
        Dim rgx As New Regex("^[\d\(][\d]{2,3}[\)\s\d\-]{1,2}[\d]{2,3}[\s\-\.\d]{1}[\d]{3,4}$")

        Dim rgxVerif As New Regex("[\d]{11,13}")

        If (rgxVerif.IsMatch(str)) Then
            Return False
        Else
            Return rgx.IsMatch(str)
        End If
    End Function

    'Courriel
    Function Est_Courriel(_courriel As String) As Boolean
        Dim rx As New Regex("^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")

        Return rx.IsMatch(_courriel)
    End Function

    'Code postal
    Function Est_CodePostal(ByRef _cp As String) As Boolean
        _cp = _cp.ToUpper()
        Dim regex As New Regex("[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]")

        Return regex.IsMatch(_cp)
    End Function

    'Ville
    Function Est_Ville(_ville As String) As Boolean
        Dim rx As New Regex("^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$")

        Return rx.IsMatch(_ville)
    End Function

    'Adresse
    Function Est_Adresse(_adresse As String) As Boolean
        Dim rx As New Regex("^[#.0-9a-zA-ZÀ-ÿ\s,-]+$")

        Return rx.IsMatch(_adresse)
    End Function

    Function Est_Site_Web(site As String) As Boolean
        Dim rx As New Regex("^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")

        Return rx.IsMatch(site)
    End Function

    'Prix
    Function Est_Prix(prix As String) As Boolean
        Dim rx As New Regex("(^\d{1,5}$|^\d{1,5}[\,\.]\d{1,2}$)")
        Dim prix_temp As String = Enlever_Signe_Monnaie(prix, prix.Length - 1)

        If Contient_Lettres(prix_temp) Then
            Return False
        ElseIf rx.IsMatch(CDbl(prix_temp)) Then
            Return True
        Else
            Return False
        End If

    End Function
#End Region

    'Function convertissant les apostrophes simples (') en double ('') pour pouvoir les passer dans mysql.'
    Public Function ConvertirApostrophe(mot As String)
        mot = mot.Replace("'", "''")
        Return mot
    End Function


    'Function convertissant les signe de dollars et remplacant les point par des virgules pour faire un double ou l'inverse.

    Public Function replace_signe_dollars(nom_avec_signe As String, virgule_point As String)
        Dim str_requete_substr As String = ""
        Dim str_requete_replace As String = ""


        str_requete_replace = "select replace ('" & nom_avec_signe & "' , '$' , '')"
        gestionBd.miseAjourDS(DataSet, dataAdapter, str_requete_replace, "tbl_commandes")

        If virgule_point = "virgule" Then
            str_requete_replace = "select replace ('" & DataSet.Tables(0).Rows(0).Item(0) & "' , '.' , ',')"
        ElseIf virgule_point = "point" Then

            str_requete_replace = "select replace ('" & DataSet.Tables(0).Rows(0).Item(0) & "' , ',' , '.')"
        End If
        gestionBd.miseAjourDS(DataSet, dataAdapter, str_requete_replace, "tbl_commandes")

        DataSet.Tables(0).Rows(0).Item(0) = Replace(DataSet.Tables(0).Rows(0).Item(0), Chr(160), "")

        Return DataSet.Tables(0).Rows(0).Item(0)


    End Function


End Module
