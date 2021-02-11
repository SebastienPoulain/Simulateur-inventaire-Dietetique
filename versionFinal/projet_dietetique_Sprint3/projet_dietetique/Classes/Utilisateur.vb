Public Class Utilisateur


    Dim _no_utilisateur As String
    Dim _prenom_personne As String
    Dim _nom_personne As String
    Dim _mot_de_passe As String
    Dim _titre As Char
    Dim _titreLong As String


    Public Property Nom_personne As String
        Get
            Return _nom_personne
        End Get
        Set(value As String)
            _nom_personne = value
        End Set

    End Property

    Public Property Prenom_personne As String
        Get
            Return _prenom_personne
        End Get
        Set(value As String)
            _prenom_personne = value
        End Set

    End Property






    Public Property Mot_de_passe As String
        Get
            Return _mot_de_passe
        End Get
        Set(value As String)
            _mot_de_passe = value

        End Set
    End Property

    Public Property Titre As Char
        Get
            Return _titre
        End Get
        Set(value As Char)
            _titre = value

        End Set
    End Property

    Public Property TitreLong As String
        Get
            Return _titreLong
        End Get
        Set(value As String)
            _titreLong = value

        End Set
    End Property

    Public Property No_id As String
        Get
            Return _no_utilisateur
        End Get
        Set(value As String)
            _no_utilisateur = value

        End Set
    End Property

    Sub New(ByVal No_id As String, Nom_personne As String)
        _no_utilisateur = No_id
        _nom_personne = Nom_personne
        _prenom_personne = Prenom_personne
    End Sub

    Sub New(ByVal No_id As String, prenom_personne As String, Nom_personne As String)
        _no_utilisateur = No_id
        _nom_personne = Nom_personne
        _prenom_personne = prenom_personne
    End Sub

    Sub New(ByVal No_id As String, prenom_personne As String, Nom_personne As String, Mot_de_passe As String, Titre As Char)
        _no_utilisateur = No_id
        _prenom_personne = prenom_personne
        _nom_personne = Nom_personne
        _mot_de_passe = Mot_de_passe
        _titre = Titre
    End Sub

    Sub New(ByVal No_id As String, prenom_personne As String, Nom_personne As String, titreLong As String)
        _no_utilisateur = No_id
        _prenom_personne = prenom_personne
        _nom_personne = Nom_personne
        _titreLong = titreLong
    End Sub

    Sub New(ByVal No_id As String, prenom_personne As String, Nom_personne As String, Mot_de_passe As String, Titre As Char, titreLong As String)
        _no_utilisateur = No_id
        _prenom_personne = prenom_personne
        _nom_personne = Nom_personne
        _mot_de_passe = Mot_de_passe
        _titreLong = titreLong
    End Sub

End Class
