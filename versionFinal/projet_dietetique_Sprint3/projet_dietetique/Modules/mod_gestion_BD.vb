Imports System.Data.Sql
Imports System.Globalization
Imports MySql.Data.MySqlClient


Module mod_gestion_BD
    Sub Remplir_Combobox(bd As Connexion, colonne As String, table As String, _cbo As ComboBox)
        Dim _ds As New DataSet
        Dim _da As New MySqlDataAdapter

        bd.miseAjourDS(_ds, _da, "SELECT " & colonne & " FROM " & table & " WHERE actif = true ORDER BY " & colonne, table)

        For i = 0 To _ds.Tables(0).Rows.Count - 1
            If Not _cbo.Items.Contains(_ds.Tables(0).Rows(i).Item(0)) Then
                _cbo.Items.Add(_ds.Tables(0).Rows(i).Item(0))
            End If
        Next
    End Sub

    Sub Remplir_Combobox_Villes(bd As Connexion, colonne As String, table As String, _cbo As ComboBox)
        Dim _ds As New DataSet
        Dim _da As New MySqlDataAdapter

        bd.miseAjourDS(_ds, _da, "SELECT " & colonne & " FROM " & table & " WHERE actif = TRUE ORDER BY " & colonne, table)

        For i = 0 To _ds.Tables(0).Rows.Count - 1
            If Not _cbo.Items.Contains(_ds.Tables(0).Rows(i).Item(0)) Then
                _cbo.Items.Add(_ds.Tables(0).Rows(i).Item(0))
            End If
        Next
    End Sub

    'Génération d'un code (contrairement aux mots de passe, on ne va prendre que des majuscules et des chiffres)
    Function Generer_Code() As String
        Dim gen As New Random
        Dim generation As String = ""

        For i As Integer = 1 To 8

            'Le générateur favorise les lettres majuscules.'
            If gen.Next(0, 5) <> 1 Then
                generation &= Chr(gen.Next(65, 91))
            Else
                generation &= gen.Next(0, 9)
            End If
        Next

        Return generation
    End Function

    Function Contient_Lettres(ByVal prix As String) As Boolean
        Dim _char() As Char = prix

        For i As Integer = 0 To _char.Length - 1

            If Not IsNumeric(_char(i)) And _char(i) <> "," And _char(i) <> "." Then
                Return True
            End If
        Next

        Return False
    End Function

#Region "Méthodes d'ajustement et altérations"
    ''' <summary>
    ''' Sert à convertir la première lettre d'un string en majuscule.
    ''' </summary>
    ''' <param name="_str">Un string (ex. un nom, une ville...)</param>
    ''' <returns></returns>
    Function Upper_Premier_Char(ByVal _str As String) As String
        Dim _chr() As Char = _str
        If _str.Count > 0 Then
            _chr(0) = Char.ToUpper(_chr(0))
        End If
        Return New String(_chr)
    End Function

    ''' <summary>
    ''' Survient lorsqu'il y a une erreur dans une tentative (dans ce cas-ci, le MANQUE de tentative) d'ajout d'un élément dit obligatoire.
    ''' </summary>
    ''' <param name="_string">Le string, venant d'une textbox, qui a causé l'erreur.</param>
    ''' <param name="lbl_erreur">Le label qui va décrire l'erreur en question</param>
    ''' <param name="message_1">Un premier message dû à le TextBox qui est vide.</param>
    ''' <param name="message_2">Un deuxième message pour les autres erreurs (on présume ici une erreur dans le Regex)</param>
    Sub Ecrire_Erreur(_string As String, ByRef lbl_erreur As Label, message_1 As String, message_2 As String)
        If _string = "" Then
            lbl_erreur.Text = message_1
        Else
            lbl_erreur.Text = message_2
        End If
    End Sub

    ''' <summary>
    ''' Va prendre un string et va le rendre vide s'il est nul.
    ''' </summary>
    ''' <param name="item">Un string.</param>
    ''' <returns></returns>
    Public Function corriger_null(ByRef item As String) As String
        If IsDBNull(item) Then
            Return " "
        Else
            Return item
        End If
    End Function

    ''' <summary>
    ''' Ajuster le code postal pour ajouter l'espace à la quatrième position (position 3 si on part de 0)
    ''' </summary>
    ''' <param name="cp">Code postal</param>
    ''' <returns>Un code postal sous le modèle "A1A 1A1"</returns>
    Public Function Ajuster_CodePostal(ByVal cp As String) As String
        If cp.Length = 6 Then
            Return cp.Insert(3, " ")
        Else
            Return cp
        End If
    End Function

    Sub Alterer_Telephone(ByRef _tel As String)
        Dim tel_storage() As Char = _tel
        Dim numeros As String = ""

        For i As Integer = 0 To tel_storage.Count - 1
            If IsNumeric(tel_storage(i)) Then
                numeros += tel_storage(i)
            End If
        Next

        If Not numeros = String.Empty Then _tel = "(" & numeros.Substring(0, 3) & ") " & numeros.Substring(3, 3) & "-" & numeros.Substring(6)
    End Sub

    Function Enlever_Signe_Monnaie(ByVal prix As String, position As Integer) As Double
        Dim _char() As Char = prix
        If _char(position) = Chr(36) Or _char(position) = Chr(32) Then
            prix = New String(_char)
            Enlever_Signe_Monnaie(prix, position - 1)
        Else
            prix = New String(_char)
        End If

        Return Replace(prix.Substring(0, position + 1), ".", ",")
    End Function

    ''' <summary>
    ''' Modifie le caractère de séparation d'un nombre selon sa culture.
    ''' </summary>
    ''' <param name="val"></param>
    ''' <returns>La valeur à modifier.</returns>
    Function changeDecimal(val As String) As Decimal
        If CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "." Then
            Return Decimal.Parse(val.Replace(",", "."))
        Else
            Return Decimal.Parse(val.Replace(".", ","))
        End If
    End Function

#End Region

End Module
