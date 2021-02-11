''' <summary>
''' Module servant à rassembler toutes les fonctions de recherche. 
''' Toutes ces fonctions résultent en une requête que l'on va demander à la base de données.
''' </summary>

Module mod_recherches
    ''' <summary>
    ''' Rechercher un attribut ou un string dans une des colonnes de la BD.
    ''' </summary>
    ''' <param name="colonne"> Désigne la colonne dans laquelle on va rechercher</param>
    ''' <param name="choix"> Le choix, via ComboBox, pour décider si on veut que l'on recherche par contenu ou par début.</param>
    ''' <param name="rech"> L'attribut ou le string de recherche.</param>
    ''' <returns></returns>
    Function Rechercher_Selon_Contenu(colonne As String, ByVal choix As ComboBox, ByVal rech As String) As String
        Select Case choix.Text
            Case "Contient"
                If rech <> "" Then
                    Return " AND " & colonne & " LIKE '%" & rech & "%'"
                Else
                    Return ""
                End If
            Case "Commence par"
                If rech <> "" Then
                    Return " AND " & colonne & " LIKE '" & rech & "%'"
                Else
                    Return ""
                End If
            Case Else
                Return ""
        End Select
    End Function

    ''' <summary>
    ''' Rechercher par la catégorie
    ''' </summary>
    ''' <param name="categorie"> Vient via le ComboBox. Les catégories sont générées depuis la base de données via une procédure. </param>
    ''' <returns></returns>
    Function Rechercher_Categories(categorie As String) As String
        If categorie = "Tous" Then
            Return ""
        Else
            Return " AND nom_categorie = '" & categorie & "'"
        End If
    End Function

    ''' <summary>
    ''' Recherche par allergènes.
    ''' Va avoir une version surchargée de Verifier_MotsCles
    ''' </summary>
    ''' <param name="choix_allergenes"> C'est le texte venant du ComboBox pour choisir par quelle façon on va rechercher dans les allergènes. </param>
    ''' <param name="mots_cles"> C'est les mots clés. Ne sera pas nécessairement utilisé (seulement dans la recherche par mot clé)</param>
    ''' <returns></returns>
    Function Rechercher_Allergenes(choix_allergenes As String, mots_cles As String) As String
        Select Case choix_allergenes
            Case "Ne contient pas d'allergènes"
                Return " AND allergene = ''"
            Case "Contient des allergènes"
                Return " AND allergene <> ''"
            Case "Contient... (mot(s) clé(s))", "Ne contient pas... (mot(s) clé(s))"
                Return Verifier_MotsCles(mots_cles, "allergene", choix_allergenes)
            Case Else
                Return ""
        End Select
    End Function

    ''' <summary>
    ''' Recherche par description
    ''' </summary>
    ''' <param name="choix_description"> C'est le texte venant du ComboBox pour choisir par quelle façon on va rechercher dans la description.</param>
    ''' <param name="mots_cles"> C'est les mots clés. Ne sera pas nécessairement utilisé (utilisé seulement dans la recherche par mot clé)</param>
    ''' <returns></returns>
    Function Rechercher_Description(choix_description As String, mots_cles As String) As String
        Select Case choix_description
            Case "Ne contient pas de description"
                Return " AND description = ''"
            Case "Contient une description (tous)"
                Return " AND description <> ''"
            Case "Recherche par mot clé"
                Return Verifier_MotsCles(mots_cles, "description")
            Case Else
                Return ""
        End Select
    End Function

    ''' <summary>
    ''' Recherche par description inventaire
    ''' </summary>
    ''' <param name="choix_description"> C'est le texte venant du ComboBox pour choisir par quelle façon on va rechercher dans la description.</param>
    ''' <param name="mots_cles"> C'est les mots clés. Ne sera pas nécessairement utilisé (utilisé seulement dans la recherche par mot clé)</param>
    ''' <returns></returns>
    Function Rechercher_Description_inventaire(choix_description As String, mots_cles As String) As String
        Select Case choix_description
            Case "Ne contient pas de description"
                Return " AND p.description = ''"
            Case "Contient une p.description (tous)"
                Return " AND p.description <> ''"
            Case "Recherche par mot clé"
                Return Verifier_MotsCles(mots_cles, "p.description")
            Case Else
                Return ""
        End Select
    End Function

    ''' <summary>
    ''' Recherche des mots clés via la description. Une version surchargée existe pour les allergènes.
    ''' </summary>
    ''' <param name="_kw"> Les mots clés.</param>
    ''' <param name="colonne"> La colonne où l'on va rechercher les mots clés par la description</param>
    ''' <returns> Une autre partie de la requête finale. </returns>
    Function Verifier_MotsCles(ByVal _kw As String, ByVal colonne As String) As String
        'On utilise un Split pour séparer tous les mots après chaque point-virgule (;)
        Dim _motsCles() As String = _kw.Split(";")
        Dim partie_requete As String = ""

        'On facilite la construction de la requête en commençant par le premier mot, ensuite on fait la deuxième boucle pour le restant des mots.
        If _motsCles.Count >= 1 Then
            'Le trim est nécessaire pour bien trouver les mots sans les espaces avant et après
            'Ça règle l'habitude de mettre des espaces après les points-virgules (;)
            _motsCles(0) = _motsCles(0).Trim

            partie_requete = " AND " & colonne & " LIKE '%" & _motsCles(0) & "%'"
        End If

        For i = 1 To _motsCles.Count - 1
            _motsCles(i) = _motsCles(i).Trim()
            partie_requete += " OR " & colonne & " LIKE '%" & _motsCles(i) & "%'"
        Next

        Return partie_requete
    End Function

    ''' <summary>
    ''' Recherche par mot clé (version surchargée pour les allergènes)
    ''' </summary>
    ''' <param name="_kw"> Les mots clés qui seront séparés </param>
    ''' <param name="colonne"> La colonne dans laquelle on va rechercher. </param>
    ''' <param name="critere_recherche"> CONTIENT ou NE CONTIENT PAS. (en bref) </param>
    ''' <returns></returns>
    Function Verifier_MotsCles(ByVal _kw As String, ByVal colonne As String, ByVal critere_recherche As String) As String
        'On utilise un Split pour séparer tous les mots après chaque point-virgule (;)
        Dim _motsCles() As String = _kw.Split(";")
        Dim partie_requete As String = ""

        'On facilite la construction de la requête en commençant par le premier mot, ensuite on fait la deuxième boucle pour le restant des mots.
        If _motsCles.Count >= 1 Then
            _motsCles(0) = _motsCles(0).Trim

            If critere_recherche = "Ne contient pas... (mot(s) clé(s))" Then
                partie_requete = " AND " & colonne & " NOT LIKE '%" & _motsCles(0) & "%'"
            Else
                partie_requete = " AND " & colonne & " LIKE '%" & _motsCles(0) & "%'"
            End If

        End If

        For i = 1 To _motsCles.Count - 1
            _motsCles(i) = _motsCles(i).Trim()
            If critere_recherche = "Ne contient pas... (mot(s) clé(s))" Then
                partie_requete += " AND " & colonne & " NOT LIKE '%" & _motsCles(i) & "%'"
            Else
                partie_requete += " OR " & colonne & " LIKE '%" & _motsCles(i) & "%'"
            End If

        Next

        Return partie_requete
    End Function

    ''' <summary>
    ''' Rechercher par périssables. Si c'est oui, alors oui, Si non... c'est non.
    ''' </summary>
    ''' <param name="radio_oui"> Vérification si c'est coché ou pas (true or false) </param>
    ''' <param name="radio_non"> Idem. </param>
    ''' <returns></returns>
    Function Rechercher_Perissable(ByVal radio_oui As RadioButton, ByVal radio_non As RadioButton) As String
        If radio_oui.Checked = True Then
            Return " AND perissable = true"
        ElseIf radio_non.Checked = True Then
            Return " AND perissable = false"
        Else
            Return ""
        End If
    End Function


    Function Rechercher_Emplacement(emplacement As String) As String
        If emplacement = "Tous" Then
            Return ""
        Else
            Return " AND nom_emplacement = '" & emplacement & "'"
        End If
    End Function

    ''' <summary>
    ''' Comment on va trier les éléments de la base de données.
    ''' </summary>
    ''' <param name="choix"> Par quel élément? </param>
    ''' <param name="ordre"> En ordre croissant? Décroissant? </param>
    ''' <returns></returns>
    Function Verifier_Tri(choix As String, ordre As String) As String
        Select Case choix
            Case "N° de produit (par défaut)"
                Return " ORDER BY code_produit " & Verifier_Ordre(ordre)
            Case "Nom de produit"
                Return " ORDER BY nom_produit " & Verifier_Ordre(ordre)
            Case "Marque"
                Return " ORDER BY marque " & Verifier_Ordre(ordre)
            Case "Catégorie"
                Return " ORDER BY nom_categorie " & Verifier_Ordre(ordre)
            Case "Bio (Oui/Non)"
                Return " ORDER BY `Bio` " & Verifier_Ordre(ordre)
            Case "Périssable (Oui/Non)"
                Return " ORDER BY `Perissable` " & Verifier_Ordre(ordre)
            Case "Description (Oui/Non)"
                Return " ORDER BY p.`Description` " & Verifier_Ordre(ordre)
            Case "Allergènes (Oui/Non)"
                Return " ORDER BY p.`Allergenes` " & Verifier_Ordre(ordre)
            Case Else
                Return " ORDER BY " & choix & " " & Verifier_Ordre(ordre)
        End Select
    End Function

    Function Verifier_Tri_Inventaire(choix As String, ordre As String) As String
        Select Case choix
            Case "N° de produit (par défaut)"
                Return " ORDER BY p.code_produit " & Verifier_Ordre(ordre)
            Case "Nom de produit"
                Return " ORDER BY nom_produit " & Verifier_Ordre(ordre)
            Case "Marque"
                Return " ORDER BY p.marque " & Verifier_Ordre(ordre)
            Case "Catégorie"
                Return " ORDER BY nom_categorie " & Verifier_Ordre(ordre)
            Case "Périssable (Oui/Non)"
                Return " ORDER BY p.`Perissable` " & Verifier_Ordre(ordre)
            Case "Description (Oui/Non)"
                Return " ORDER BY p.`Description` " & Verifier_Ordre(ordre)
            Case "Allergènes (Oui/Non)"
                Return " ORDER BY p.`Allergene` " & Verifier_Ordre(ordre)
            Case "Bio (Oui/Non)"
                Return " ORDER BY `bio` " & Verifier_Ordre(ordre)
            Case "Emplacement"
                Return " ORDER BY `nom_emplacement` " & Verifier_Ordre(ordre)
            Case "Quantité"
                Return " ORDER BY id.`quantite` " & Verifier_Ordre(ordre)
            Case Else
                Return " ORDER BY p.code_produit " & Verifier_Ordre(ordre)
        End Select
    End Function

    Function Verifier_Tri_Fournisseurs(choix As String, ordre As String) As String
        Select Case choix
            Case "Nom de fournisseur (par défaut)"
                Return " ORDER BY nom_fournisseur " & Verifier_Ordre(ordre)
            Case "Ville"
                Return " ORDER BY ville " & Verifier_Ordre(ordre)
            Case "Adresse"
                Return " ORDER BY adresse " & Verifier_Ordre(ordre)
            Case "Frais de livraison"
                Return " ORDER BY frais_livraison " & Verifier_Ordre(ordre)
            Case "Commande minimale"
                Return " ORDER BY qte_min_commande " & Verifier_Ordre(ordre)
            Case Else
                Return " ORDER BY tbl_fournisseurs.no_fournisseur " & Verifier_Ordre(ordre)
        End Select
    End Function

    ''' <summary>
    ''' Vérification de l'ordre. Utilisé dans Verifier_Tri.
    ''' </summary>
    ''' <param name="ordre"> En ordre croissant, ou décroissant. </param>
    ''' <returns></returns>
    Function Verifier_Ordre(ordre As String) As String
        If ordre = "Ordre croissant" Then
            Return "ASC"
        Else
            Return "DESC"
        End If
    End Function

    Function Rechercher_Bio(ByVal bio_oui As RadioButton, ByVal bio_non As RadioButton) As String
        If bio_oui.Checked Then
            Return " AND bio = true"
        ElseIf bio_non.Checked Then
            Return " AND bio = false"
        Else
            Return ""
        End If
    End Function

    Function Verifier_Limites(choix As ComboBox, ByRef limite_inferieure As Decimal, ByRef limite_superieure As Decimal, colonne As String) As String
        If choix.Text = "Supérieur à" And limite_superieure = 0 Then
            Return " AND " & colonne & " > " & limite_inferieure.ToString.Replace(",", ".")
        ElseIf choix.Text = "Inférieur à" And limite_superieure = 0 Then
            Return " AND " & colonne & " < " & limite_inferieure.ToString.Replace(",", ".")
        ElseIf choix.Text = "Entre..." Then
            Return Verifier_Limites(limite_inferieure, limite_superieure, colonne)
        Else
            Return ""
        End If
    End Function

    Sub Interchanger_Limites(ByRef limite_inferieure, ByRef limite_superieure)
        Dim limite_temp As Decimal = limite_inferieure
        limite_inferieure = limite_superieure
        limite_superieure = limite_temp
    End Sub

    Function Verifier_Limites(ByRef limite_inferieure As Decimal, ByRef limite_superieure As Decimal, colonne As String) As String
        If limite_inferieure > limite_superieure Then
            Interchanger_Limites(limite_inferieure, limite_superieure)
        End If
        Return " AND " & colonne & " BETWEEN " & limite_inferieure.ToString.Replace(",", ".") & " AND " & limite_superieure.ToString.Replace(",", ".")
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="telephone">Le numéro de téléphone que l'on veut rechercher (via la textbox)</param>
    ''' <returns></returns>
    Function Rechercher_Telephone(ByRef telephone As String) As String
        If telephone <> "" Then
            Alterer_Telephone(telephone)
            Return " AND telephone = '" & telephone & "'"
        Else
            Return ""
        End If
    End Function

    Function Changer_Vue(ByVal radio_oui As RadioButton, ByVal radio_non As RadioButton) As String
        If radio_oui.Checked Then
            Return " AND actif = true"
        ElseIf radio_non.Checked Then
            Return " AND actif = false"
        Else
            Return ""
        End If
    End Function

    Function Verifier_Activite(ByVal radio_oui As RadioButton, ByVal radio_non As RadioButton, table As String) As String
        If radio_oui.Checked Then
            Return " " & table & ".actif = true"
        ElseIf radio_non.Checked Then
            Return " " & table & ".actif = false"
        Else
            Return " " & table & ".actif in (true, false)"
        End If
    End Function




    Function verifier_activite_combobox(ByVal cb_activite As ComboBox)



        If cb_activite.Text = "Actif" Then

            Return " where actif = true"


        ElseIf cb_activite.Text = "Inactif" Then

            Return " where actif = false"

        Else
            Return " where actif in (true,false)"

        End If

    End Function


    Function Verifier_Tri_unites_mesures(choix As String, ordre As String) As String
        Select Case choix
            Case "Unités de mesures (par défaut)"
                Return " ORDER BY unite_mesure " & Verifier_Ordre(ordre)
            Case "Types de mesures"
                Return " ORDER BY type_mesure " & Verifier_Ordre(ordre)
            Case Else
                Return ""
        End Select
    End Function
End Module
