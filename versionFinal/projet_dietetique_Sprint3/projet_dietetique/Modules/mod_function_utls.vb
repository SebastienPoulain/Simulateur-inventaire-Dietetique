Imports System
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography
Module mod_function_utls
    Dim gen As New Random
    Private ReadOnly _md5 As MD5 = MD5.Create()

    Public Function GenererMdp()
        Dim generation As String = ""
        For i As Integer = 1 To 8
            'Le générateur favorise les lettres minuscules.'
            If gen.Next(0, 5) <> 1 Then
                If gen.Next(0, 5) <> 1 Then
                    generation &= Chr(gen.Next(97, 123))
                Else
                    generation &= Chr(gen.Next(65, 91))
                End If
            Else
                generation &= gen.Next(0, 9)
            End If
        Next

        'Vérifie que la génération de mot de passe contient une majuscule et 1 chiffre ou recommence.'
        If Not mod_regex.Mdp(generation) Then
            GenererMdp()
        End If

        Return generation
    End Function

    ''' <summary>
    ''' Fonction servant à convertir la première lettre d'un mot en Majuscule
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <param name="val"></param>
    ''' On met le mot complet en paramètre (string)
    ''' <returns></returns>
    ''' si la valeur est null ou vide on retourne cette valeur sinon on retourne la nouvelle chaine de caractères.
    ''' <tag>2019</tag>
    Function UppercaseFirstLetter(ByVal val As String) As String
        ' On test pour les valeurs nulles ou vides.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        'On convertit la chaine de caractères en tableau de caractères.
        Dim array() As Char = val.ToCharArray

        'On met le premier caractère du tableau en lettre majuscule.
        array(0) = Char.ToUpper(array(0))

        ' On retourne la nouvelle chaine de caractères.
        Return New String(array)
    End Function
    ''' <summary>
    ''' Fonction servant à crypter les mots de passe lors de l'insertion de ceux-ci dans la base de données.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <param name="source"></param>
    ''' On met en paramètre la valeur des mots de passe en claire.
    ''' <returns></returns>
    ''' On retourne une chaine de caractères en format hexadécimal qui correspond au mot de passe, mais crypté.
    ''' <tag>2019</tag>
    Public Function GetMd5Hash(source As String) As String

        Dim data = _md5.ComputeHash(Encoding.UTF8.GetBytes(source))
        Dim sb As New StringBuilder()
        Array.ForEach(data, Function(x) sb.Append(x.ToString("X2")))
        Return sb.ToString()

    End Function

End Module
