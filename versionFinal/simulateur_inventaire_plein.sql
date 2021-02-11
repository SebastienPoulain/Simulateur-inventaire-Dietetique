-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  ven. 10 mai 2019 à 17:46
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `simulateur_inventaire`
--

-- --------------------------------------------------------

--
-- Structure de la table `tbl_allergenes`
--

DROP TABLE IF EXISTS `tbl_allergenes`;
CREATE TABLE IF NOT EXISTS `tbl_allergenes` (
  `no_allergene` int(11) NOT NULL AUTO_INCREMENT,
  `nom_allergene` varchar(255) NOT NULL,
  PRIMARY KEY (`no_allergene`)
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_allergenes`
--

INSERT INTO `tbl_allergenes` (`no_allergene`, `nom_allergene`) VALUES
(69, 'Oeuf'),
(70, 'Lait'),
(71, 'Soja'),
(72, 'Graines de sésame'),
(73, 'Mollusques et crustacés'),
(74, 'Poissons');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_categories`
--

DROP TABLE IF EXISTS `tbl_categories`;
CREATE TABLE IF NOT EXISTS `tbl_categories` (
  `no_categorie` int(11) NOT NULL AUTO_INCREMENT,
  `nom_categorie` varchar(255) NOT NULL,
  `remarque` varchar(255) NOT NULL,
  `actif` tinyint(4) NOT NULL,
  PRIMARY KEY (`no_categorie`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_categories`
--

INSERT INTO `tbl_categories` (`no_categorie`, `nom_categorie`, `remarque`, `actif`) VALUES
(12, 'Viandes Et Substituts', '', 1),
(14, 'Poissons Et Fruits De Mer', '', 1),
(15, 'Végétalien', '', 1),
(16, 'Fruits Et Légumes', '', 1),
(17, 'Conserves', '', 1),
(18, 'Noix', '', 1),
(19, 'Épices', '', 1),
(20, 'Autres', '', 1),
(21, 'Produits Laitiers', '', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_commandes`
--

DROP TABLE IF EXISTS `tbl_commandes`;
CREATE TABLE IF NOT EXISTS `tbl_commandes` (
  `no_commande` varchar(11) NOT NULL,
  `no_utilisateur` varchar(35) NOT NULL,
  `no_fournisseur` varchar(11) NOT NULL,
  `no_exercice` int(11) NOT NULL,
  `montant_total` double(10,2) DEFAULT NULL,
  `date_commande` datetime NOT NULL,
  `remarque` varchar(255) DEFAULT NULL,
  `actif` int(11) NOT NULL,
  PRIMARY KEY (`no_commande`),
  KEY `no_utilisateur` (`no_utilisateur`),
  KEY `no_fournisseur` (`no_fournisseur`),
  KEY `no_exercice` (`no_exercice`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_commandes`
--

INSERT INTO `tbl_commandes` (`no_commande`, `no_utilisateur`, `no_fournisseur`, `no_exercice`, `montant_total`, `date_commande`, `remarque`, `actif`) VALUES
('181090', 'etu0001', 'OEQBO5AW', 45, 4.79, '2018-05-28 00:00:00', '', 1),
('246832', 'boot01', 'UKCCKTH8', 55, 88.20, '2019-05-10 13:44:07', '', 1),
('293362', 'enseign0001', 'OEQBO5AW', 45, 9.28, '2018-05-28 00:00:00', '', 1),
('559706', 'etu0001', '8YWPLIR1', 45, 6.39, '2018-05-28 00:00:00', '', 1),
('994904', 'etu0001', 'UKCCKTH8', 55, 52.50, '2019-05-10 13:45:19', '', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_commandes_detaillees`
--

DROP TABLE IF EXISTS `tbl_commandes_detaillees`;
CREATE TABLE IF NOT EXISTS `tbl_commandes_detaillees` (
  `no_produit` varchar(35) NOT NULL,
  `no_commande` varchar(11) NOT NULL,
  `quantite` double(6,2) DEFAULT NULL,
  `prix_unitaire` double(5,2) NOT NULL,
  PRIMARY KEY (`no_produit`,`no_commande`),
  KEY `no_produit` (`no_produit`,`no_commande`),
  KEY `no_commande` (`no_commande`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_commandes_detaillees`
--

INSERT INTO `tbl_commandes_detaillees` (`no_produit`, `no_commande`, `quantite`, `prix_unitaire`) VALUES
('0558720260', '293362', 1.00, 6.39),
('0558720260', '559706', 1.00, 6.39),
('0558720260', '827438', 1.00, 6.39),
('0558720260', '877054', 1.00, 6.39),
('0597498925', '181090', 1.00, 4.79),
('0597498926', '293362', 1.00, 2.89),
('780OAVYN', '246832', 1.00, 59.00),
('LSL2NTKW', '246832', 1.00, 25.00),
('LSL2NTKW', '994904', 2.00, 25.00);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_commandes_exercices`
--

DROP TABLE IF EXISTS `tbl_commandes_exercices`;
CREATE TABLE IF NOT EXISTS `tbl_commandes_exercices` (
  `no_exercice` int(11) NOT NULL,
  `no_commande` varchar(11) NOT NULL,
  `no_utilisateur` varchar(35) NOT NULL,
  PRIMARY KEY (`no_exercice`,`no_commande`,`no_utilisateur`),
  KEY `no_exercice` (`no_exercice`,`no_commande`,`no_utilisateur`),
  KEY `no_commande` (`no_commande`),
  KEY `no_utilisateur` (`no_utilisateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_commandes_exercices`
--

INSERT INTO `tbl_commandes_exercices` (`no_exercice`, `no_commande`, `no_utilisateur`) VALUES
(45, '181090', 'etu0001'),
(55, '246832', 'boot01'),
(45, '293362', 'enseign0001'),
(45, '559706', 'etu0001'),
(51, '827438', 'etu0001'),
(51, '877054', 'etu0001'),
(55, '994904', 'etu0001');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_commandes_prof`
--

DROP TABLE IF EXISTS `tbl_commandes_prof`;
CREATE TABLE IF NOT EXISTS `tbl_commandes_prof` (
  `no_utilisateur` varchar(35) NOT NULL,
  `no_commande` varchar(11) NOT NULL,
  `no_exercice` int(11) NOT NULL,
  PRIMARY KEY (`no_utilisateur`,`no_commande`,`no_exercice`),
  KEY `no_utilisateur` (`no_utilisateur`,`no_commande`,`no_exercice`),
  KEY `no_exercice` (`no_exercice`),
  KEY `no_commande` (`no_commande`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_commandes_prof`
--

INSERT INTO `tbl_commandes_prof` (`no_utilisateur`, `no_commande`, `no_exercice`) VALUES
('enseign0001', '293362', 45),
('boot01', '246832', 55);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_cours`
--

DROP TABLE IF EXISTS `tbl_cours`;
CREATE TABLE IF NOT EXISTS `tbl_cours` (
  `no_cours` varchar(13) NOT NULL,
  `nom_cours` varchar(50) NOT NULL,
  `actif` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`no_cours`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_cours`
--

INSERT INTO `tbl_cours` (`no_cours`, `nom_cours`, `actif`) VALUES
('105-104-RI-01', 'Transformation des aliments', 1),
('120-104-RI-01', 'Stratégies de l\'alimentation', 1),
('120-104-RI-02', 'Stratégies de l\'alimentation', 1),
('120-316-RI-01', 'Éléments de gestion des SA II', 1),
('120-316-RI-02', 'Éléments de gestion des SA II', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_cours_prof`
--

DROP TABLE IF EXISTS `tbl_cours_prof`;
CREATE TABLE IF NOT EXISTS `tbl_cours_prof` (
  `no_cours` varchar(13) NOT NULL,
  `no_utilisateur` varchar(35) NOT NULL,
  PRIMARY KEY (`no_cours`,`no_utilisateur`),
  KEY `no_cours` (`no_cours`,`no_utilisateur`),
  KEY `no_utilisateur` (`no_utilisateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_cours_prof`
--

INSERT INTO `tbl_cours_prof` (`no_cours`, `no_utilisateur`) VALUES
('105-104-RI-01', 'boot01'),
('120-104-RI-01', 'enseign0001'),
('120-104-RI-02', 'enseign0001'),
('120-316-RI-01', 'enseign0002'),
('120-316-RI-02', 'enseign0002');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_cours_utilisateur`
--

DROP TABLE IF EXISTS `tbl_cours_utilisateur`;
CREATE TABLE IF NOT EXISTS `tbl_cours_utilisateur` (
  `no_utilisateur` varchar(35) NOT NULL,
  `no_cours` varchar(13) NOT NULL,
  PRIMARY KEY (`no_utilisateur`,`no_cours`),
  KEY `no_utilisateur` (`no_utilisateur`,`no_cours`),
  KEY `no_cours` (`no_cours`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_cours_utilisateur`
--

INSERT INTO `tbl_cours_utilisateur` (`no_utilisateur`, `no_cours`) VALUES
('etu0001', '105-104-RI-01'),
('etu0002', '105-104-RI-01'),
('etu0001', '120-104-RI-01'),
('etu0002', '120-104-RI-01'),
('etu0003', '120-104-RI-01'),
('etu0004', '120-104-RI-02'),
('etu0005', '120-104-RI-02'),
('etu0006', '120-104-RI-02'),
('etu0001', '120-316-RI-01'),
('etu0003', '120-316-RI-01'),
('etu0005', '120-316-RI-01'),
('etu0002', '120-316-RI-02'),
('etu0004', '120-316-RI-02'),
('etu0006', '120-316-RI-02'),
('etu0001', '122-104-RI-01'),
('etudiet0001', '122-104-RI-01');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_emplacement_inventaire`
--

DROP TABLE IF EXISTS `tbl_emplacement_inventaire`;
CREATE TABLE IF NOT EXISTS `tbl_emplacement_inventaire` (
  `no_emplacement` int(11) NOT NULL AUTO_INCREMENT,
  `nom_emplacement` varchar(255) NOT NULL,
  `remarque` varchar(255) NOT NULL,
  `actif` tinyint(4) NOT NULL,
  PRIMARY KEY (`no_emplacement`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_emplacement_inventaire`
--

INSERT INTO `tbl_emplacement_inventaire` (`no_emplacement`, `nom_emplacement`, `remarque`, `actif`) VALUES
(6, 'Armoire', '', 1),
(7, 'Congélateur', '', 1),
(8, 'Frigo', '', 1),
(9, 'Pièces secondaires', '', 1),
(10, 'Tiroir', 'C\'est le tiroir #1', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_exercices`
--

DROP TABLE IF EXISTS `tbl_exercices`;
CREATE TABLE IF NOT EXISTS `tbl_exercices` (
  `no_exercice` int(11) NOT NULL AUTO_INCREMENT,
  `no_cours` varchar(13) NOT NULL,
  `no_inventaire` int(11) NOT NULL,
  `nom_travail` varchar(30) NOT NULL,
  `description` varchar(255) NOT NULL,
  `actif` tinyint(4) NOT NULL DEFAULT '1',
  `actif_prof` tinyint(1) NOT NULL DEFAULT '1',
  `Date_remise` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`no_exercice`),
  KEY `no_inventaire` (`no_inventaire`),
  KEY `no_cours` (`no_cours`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_exercices`
--

INSERT INTO `tbl_exercices` (`no_exercice`, `no_cours`, `no_inventaire`, `nom_travail`, `description`, `actif`, `actif_prof`, `Date_remise`) VALUES
(45, '120-104-RI-01', 83, 'Gâteau Aux Jujubes', 'Faire un gâteau aux jujubes, selon moi.', 1, 0, '2019-03-26 00:00:00'),
(52, '120-316-RI-02', 100, 'Test', '', 1, 0, '2019-04-30 12:48:00'),
(55, '105-104-RI-01', 103, 'Exercice 1', 'Faire une tarte aux pommes', 1, 1, '2019-05-10 13:50:00');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_exercice_recette`
--

DROP TABLE IF EXISTS `tbl_exercice_recette`;
CREATE TABLE IF NOT EXISTS `tbl_exercice_recette` (
  `no_recette` int(11) NOT NULL,
  `no_exercice` int(11) NOT NULL,
  `nom_recette` varchar(100) NOT NULL,
  `description` varchar(100) NOT NULL,
  PRIMARY KEY (`no_recette`,`no_exercice`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_exercice_recette`
--

INSERT INTO `tbl_exercice_recette` (`no_recette`, `no_exercice`, `nom_recette`, `description`) VALUES
(6, 55, 'Recette_Tarte_Au_Pomme.csv', 'Exercice 1');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_formats`
--

DROP TABLE IF EXISTS `tbl_formats`;
CREATE TABLE IF NOT EXISTS `tbl_formats` (
  `no_format` int(11) NOT NULL AUTO_INCREMENT,
  `nom_format` varchar(30) NOT NULL,
  `remarque` varchar(255) NOT NULL,
  `actif` tinyint(4) NOT NULL,
  PRIMARY KEY (`no_format`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_formats`
--

INSERT INTO `tbl_formats` (`no_format`, `nom_format`, `remarque`, `actif`) VALUES
(13, 'Caisse', '', 1),
(14, 'Sac', '', 1),
(15, 'Carton', '', 1),
(16, 'Pinte', '', 1),
(17, 'Conserve', '', 1),
(18, 'Unitaire', '', 1),
(19, 'En Vrac', '', 1),
(20, 'Embalage De Plastique', '', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_fournisseurs`
--

DROP TABLE IF EXISTS `tbl_fournisseurs`;
CREATE TABLE IF NOT EXISTS `tbl_fournisseurs` (
  `no_fournisseur` varchar(11) NOT NULL,
  `nom_fournisseur` varchar(50) NOT NULL,
  `ville` int(11) DEFAULT NULL,
  `code_postal` char(7) NOT NULL,
  `adresse` varchar(50) NOT NULL,
  `nom_contact` varchar(50) NOT NULL,
  `prenom_contact` varchar(30) NOT NULL,
  `titre_contact` varchar(50) NOT NULL,
  `adresse_couriel_contact` varchar(50) NOT NULL,
  `lien_internet` varchar(255) NOT NULL,
  `frais_livraison` double(6,2) NOT NULL,
  `qte_min_commande` int(3) NOT NULL,
  `remarque` varchar(255) NOT NULL,
  `actif` int(11) NOT NULL,
  PRIMARY KEY (`no_fournisseur`),
  KEY `ville` (`ville`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_fournisseurs`
--

INSERT INTO `tbl_fournisseurs` (`no_fournisseur`, `nom_fournisseur`, `ville`, `code_postal`, `adresse`, `nom_contact`, `prenom_contact`, `titre_contact`, `adresse_couriel_contact`, `lien_internet`, `frais_livraison`, `qte_min_commande`, `remarque`, `actif`) VALUES
('8YWPLIR1', 'IGA Supermarché Jean XXIII', 8, 'G8Z 4B5', '6060 boul Jean-XXII', 'St-Jean', 'Maryse', 'Commis', 'maryse.st.jean@iga.ca', 'https://www.iga.net/fr', 0.00, 0, 'Commande minimum de 45,00 $.', 1),
('OEQBO5AW', 'Métro Plus des Forges', 8, 'G8Y 0G7', '3425, Boulevard du Chanoine Moreau', 'Lavallée', 'Francis', 'Commis', '', 'https://www.metro.ca/', 0.00, 0, '', 1),
('REQDPSFN', 'Super C', 11, 'G9A 6M1', '2975, Boulevard des Récollets', 'Mercier', 'Jacques', 'Commis', '', 'https://www.superc.ca/index.fr.html', 0.00, 0, '', 1),
('UKCCKTH8', 'Costco', 11, 'G9A 6J2', '3000 Boulevard des Récollets', 'Labranche', 'Régina', 'Représentante', 'regina.labranche@costco.ca', 'https://costco.ca/', 0.00, 0, '', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_inventaire`
--

DROP TABLE IF EXISTS `tbl_inventaire`;
CREATE TABLE IF NOT EXISTS `tbl_inventaire` (
  `no_inventaire` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`no_inventaire`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_inventaire`
--

INSERT INTO `tbl_inventaire` (`no_inventaire`) VALUES
(67),
(81),
(82),
(83),
(84),
(85),
(86),
(87),
(88),
(89),
(90),
(91),
(92),
(93),
(94),
(95),
(96),
(97),
(98),
(99),
(100),
(101),
(102),
(103);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_inventaire_detail`
--

DROP TABLE IF EXISTS `tbl_inventaire_detail`;
CREATE TABLE IF NOT EXISTS `tbl_inventaire_detail` (
  `no_inventaire` int(11) NOT NULL,
  `code_produit` varchar(11) NOT NULL,
  `no_emplacement` int(11) NOT NULL,
  `quantite` double(6,2) NOT NULL,
  PRIMARY KEY (`no_inventaire`,`code_produit`,`no_emplacement`),
  KEY `code_produit` (`no_emplacement`),
  KEY `no_emplacement` (`no_emplacement`),
  KEY `code_produit_2` (`code_produit`),
  KEY `no_inventaire` (`no_inventaire`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_inventaire_detail`
--

INSERT INTO `tbl_inventaire_detail` (`no_inventaire`, `code_produit`, `no_emplacement`, `quantite`) VALUES
(81, '0597499016', 8, 1.00),
(83, '0597499016', 8, 1.00),
(91, 'LSL2NTKW', 9, 0.50),
(102, 'LSL2NTKW', 9, 0.50),
(103, 'LSL2NTKW', 9, 0.50);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_inventaire_prof`
--

DROP TABLE IF EXISTS `tbl_inventaire_prof`;
CREATE TABLE IF NOT EXISTS `tbl_inventaire_prof` (
  `no_utilisateur` varchar(35) NOT NULL,
  `no_inventaire` int(11) NOT NULL,
  PRIMARY KEY (`no_utilisateur`),
  KEY `no_cours` (`no_utilisateur`,`no_inventaire`),
  KEY `no_utilisateur` (`no_utilisateur`),
  KEY `no_inventaire` (`no_inventaire`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_inventaire_prof`
--

INSERT INTO `tbl_inventaire_prof` (`no_utilisateur`, `no_inventaire`) VALUES
('enseign0001', 81),
('enseign0002', 82),
('boot01', 91);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_produits`
--

DROP TABLE IF EXISTS `tbl_produits`;
CREATE TABLE IF NOT EXISTS `tbl_produits` (
  `nom_produit` varchar(255) NOT NULL,
  `code_produit` varchar(11) NOT NULL,
  `code_barre` varchar(11) NOT NULL,
  `code_plu` varchar(11) NOT NULL,
  `no_format` int(11) NOT NULL,
  `no_categorie` int(11) NOT NULL,
  `no_mesure` int(11) NOT NULL,
  `description` varchar(255) NOT NULL,
  `remarque` varchar(255) NOT NULL,
  `nbr_unite_format` double(6,2) NOT NULL,
  `marque` varchar(50) NOT NULL,
  `perissable` tinyint(1) NOT NULL,
  `actif` tinyint(1) NOT NULL,
  `allergene` varchar(255) NOT NULL,
  `bio` tinyint(4) NOT NULL,
  PRIMARY KEY (`code_produit`),
  KEY `no_fournisseur` (`no_format`,`no_categorie`,`no_mesure`),
  KEY `no_format` (`no_format`),
  KEY `no_categorie` (`no_categorie`),
  KEY `no_mesure` (`no_mesure`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_produits`
--

INSERT INTO `tbl_produits` (`nom_produit`, `code_produit`, `code_barre`, `code_plu`, `no_format`, `no_categorie`, `no_mesure`, `description`, `remarque`, `nbr_unite_format`, `marque`, `perissable`, `actif`, `allergene`, `bio`) VALUES
('Lait 2 % (4 L)', '0558720260', '', '', 16, 21, 17, 'Le lait partiellement écrémé Québon® est le fruit d\'une tradition puisant ses racines dans la province du Québec. Il combine le goût frais et savoureux du lait à de nombreux minéraux et vitamines néce', '', 4.00, 'Québon', 1, 1, 'Lait', 0),
('Farine tout usage (2.5 kg)', '0597498925', '', '', 14, 20, 15, 'Offrant une saveur authentique, ce mélange de farine tout usage enrichie et pré-tamisée est idéal pour les crêpes, les croûtes à tarte, les pizzas, les pains et les croissants.', '', 2.50, 'Selection', 0, 1, '', 0),
('Œufs bruns gros biologiques, Bio', '0597499016', '', '', 15, 12, 19, 'Les œufs Irresistibles™ Bio sont biologiques et de grade Canada A.', '', 12.00, 'Irresistibles', 1, 1, 'Oeufs', 1),
('Pâté d\'esturgeon fumé', '780OAVYN', '', '', 13, 14, 16, '', '', 100.00, 'Esturgeon de l\'Acadie', 1, 1, '', 0),
('Frites de calmars sauvages', 'LSL2NTKW', '', '', 15, 14, 15, '', '', 6.00, 'OceanPrime', 1, 1, '', 0);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_produit_fournisseur_prix`
--

DROP TABLE IF EXISTS `tbl_produit_fournisseur_prix`;
CREATE TABLE IF NOT EXISTS `tbl_produit_fournisseur_prix` (
  `code_produit` varchar(11) NOT NULL,
  `no_fournisseur` varchar(11) NOT NULL,
  `prix` double(6,2) DEFAULT NULL,
  `date_prix` datetime NOT NULL,
  `actif` tinyint(4) NOT NULL,
  PRIMARY KEY (`code_produit`,`no_fournisseur`,`date_prix`),
  KEY `no_fournisseur` (`no_fournisseur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_produit_fournisseur_prix`
--

INSERT INTO `tbl_produit_fournisseur_prix` (`code_produit`, `no_fournisseur`, `prix`, `date_prix`, `actif`) VALUES
('0558720260', '8YWPLIR1', 6.39, '2018-05-25 12:07:30', 1),
('0558720260', 'OEQBO5AW', 6.39, '2018-05-25 12:07:30', 1),
('0597498925', 'OEQBO5AW', 4.79, '2018-05-25 11:56:04', 1),
('0597499016', 'OEQBO5AW', 6.49, '2018-05-25 11:56:18', 1),
('780OAVYN', 'UKCCKTH8', 59.00, '2018-05-28 12:27:25', 1),
('LSL2NTKW', 'UKCCKTH8', 25.00, '2018-05-28 12:27:15', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_produit_taxe`
--

DROP TABLE IF EXISTS `tbl_produit_taxe`;
CREATE TABLE IF NOT EXISTS `tbl_produit_taxe` (
  `code_produit` varchar(11) NOT NULL,
  `id_taxe` int(11) NOT NULL,
  PRIMARY KEY (`code_produit`,`id_taxe`),
  KEY `id_taxe` (`id_taxe`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_produit_taxe`
--

INSERT INTO `tbl_produit_taxe` (`code_produit`, `id_taxe`) VALUES
('LSL2NTKW', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_reception_details`
--

DROP TABLE IF EXISTS `tbl_reception_details`;
CREATE TABLE IF NOT EXISTS `tbl_reception_details` (
  `no_reception` int(11) NOT NULL,
  `code_produit` varchar(11) NOT NULL,
  `no_commande` varchar(11) NOT NULL,
  `quantite` int(11) NOT NULL,
  `prix_unitaire` double(5,2) NOT NULL,
  `escompte` double(5,2) DEFAULT NULL,
  `remarque` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`no_reception`,`code_produit`,`no_commande`),
  KEY `code_produit` (`code_produit`,`no_commande`),
  KEY `no_commande` (`no_commande`),
  KEY `no_reception` (`no_reception`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_reception_details`
--

INSERT INTO `tbl_reception_details` (`no_reception`, `code_produit`, `no_commande`, `quantite`, `prix_unitaire`, `escompte`, `remarque`) VALUES
(128, '0558720260', '293362', 1, 6.39, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_reception_exercices`
--

DROP TABLE IF EXISTS `tbl_reception_exercices`;
CREATE TABLE IF NOT EXISTS `tbl_reception_exercices` (
  `no_reception` int(11) NOT NULL AUTO_INCREMENT,
  `no_exercice` int(11) NOT NULL,
  `date_reception` date NOT NULL,
  `remarque` varchar(255) DEFAULT NULL,
  `actif` tinyint(1) NOT NULL,
  PRIMARY KEY (`no_reception`),
  KEY `no_reception` (`no_exercice`),
  KEY `no_travail` (`no_exercice`)
) ENGINE=InnoDB AUTO_INCREMENT=129 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_reception_exercices`
--

INSERT INTO `tbl_reception_exercices` (`no_reception`, `no_exercice`, `date_reception`, `remarque`, `actif`) VALUES
(128, 45, '2018-05-28', NULL, 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_recette`
--

DROP TABLE IF EXISTS `tbl_recette`;
CREATE TABLE IF NOT EXISTS `tbl_recette` (
  `no_recette` int(11) NOT NULL AUTO_INCREMENT,
  `source_Img` varchar(1000) NOT NULL,
  `source_doc` varchar(1000) NOT NULL,
  `nom_recette` varchar(500) NOT NULL,
  PRIMARY KEY (`no_recette`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_recette`
--

INSERT INTO `tbl_recette` (`no_recette`, `source_Img`, `source_doc`, `nom_recette`) VALUES
(6, 'dossierRecette\\tate au pomme.jpg', 'dossierRecette\\Recette_Tarte_Au_Pomme.csv', 'Recette_Tarte_Au_Pomme.csv');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_taxes`
--

DROP TABLE IF EXISTS `tbl_taxes`;
CREATE TABLE IF NOT EXISTS `tbl_taxes` (
  `id_taxes` int(11) NOT NULL AUTO_INCREMENT,
  `date_taxe` date NOT NULL,
  `type_taxe` varchar(50) NOT NULL,
  `pourcentage_taxe` varchar(50) NOT NULL,
  PRIMARY KEY (`id_taxes`,`date_taxe`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_taxes`
--

INSERT INTO `tbl_taxes` (`id_taxes`, `date_taxe`, `type_taxe`, `pourcentage_taxe`) VALUES
(1, '2018-04-17', 'TPS', '5,00'),
(2, '2018-04-17', 'TVQ', '9,975');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_telephones`
--

DROP TABLE IF EXISTS `tbl_telephones`;
CREATE TABLE IF NOT EXISTS `tbl_telephones` (
  `no_telephone` int(11) NOT NULL AUTO_INCREMENT,
  `no_fournisseur` varchar(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `telephone` varchar(14) NOT NULL COMMENT '(819) 999-9999',
  `poste` varchar(10) NOT NULL,
  `remarque` varchar(255) NOT NULL,
  PRIMARY KEY (`no_telephone`),
  KEY `no_fournisseur` (`no_fournisseur`)
) ENGINE=InnoDB AUTO_INCREMENT=225 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_telephones`
--

INSERT INTO `tbl_telephones` (`no_telephone`, `no_fournisseur`, `type`, `telephone`, `poste`, `remarque`) VALUES
(219, 'OEQBO5AW', 'Bureau', '(819) 373-5166', '', ''),
(220, '8YWPLIR1', 'Bureau', '(819) 374-6060', '', ''),
(222, 'REQDPSFN', 'Cell.', '(819) 374-0000', '', ''),
(223, 'UKCCKTH8', 'Bureau', '(819) 758-5555', '687', ''),
(224, 'UKCCKTH8', 'Cell.', '(819) 777-4444', '', '');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_unites_mesure`
--

DROP TABLE IF EXISTS `tbl_unites_mesure`;
CREATE TABLE IF NOT EXISTS `tbl_unites_mesure` (
  `no_mesure` int(11) NOT NULL AUTO_INCREMENT,
  `unite_mesure` varchar(30) NOT NULL,
  `type_mesure` varchar(20) NOT NULL,
  `actif` tinyint(4) NOT NULL,
  PRIMARY KEY (`no_mesure`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_unites_mesure`
--

INSERT INTO `tbl_unites_mesure` (`no_mesure`, `unite_mesure`, `type_mesure`, `actif`) VALUES
(15, 'Kilogramme (Kg)', 'Poids', 1),
(16, 'Grammes (G)', 'Poids', 1),
(17, 'Litres (L)', 'Volume', 1),
(18, 'Millilitres (Ml)', 'Volume', 1),
(19, 'Unités', 'Unité(S)', 1),
(20, 'Sachet(S)', 'Unité(S)', 1),
(21, 'Onces Liquides (Fl Oz)', 'Volume', 1),
(22, 'Onces (Oz)', 'Poids', 1),
(23, 'Livres', 'Poids', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_utilisateurs`
--

DROP TABLE IF EXISTS `tbl_utilisateurs`;
CREATE TABLE IF NOT EXISTS `tbl_utilisateurs` (
  `no_utilisateur` varchar(35) NOT NULL,
  `prenom_personne` varchar(35) NOT NULL,
  `nom_personne` varchar(50) NOT NULL,
  `mot_de_passe` varchar(35) NOT NULL,
  `titre` char(1) NOT NULL,
  `Actif` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`no_utilisateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_utilisateurs`
--

INSERT INTO `tbl_utilisateurs` (`no_utilisateur`, `prenom_personne`, `nom_personne`, `mot_de_passe`, `titre`, `Actif`) VALUES
('admin', 'Admin', 'Admin', '21232F297A57A5A743894A0E4A801FC3', 'a', 1),
('boot01', 'Al', 'Brod', '202CB962AC59075B964B07152D234B70', 'p', 1),
('enseign0001', 'Maryse', 'Beauchemin', '202CB962AC59075B964B07152D234B70', 'p', 1),
('enseign0002', 'Paul', 'Boissoneault', '202CB962AC59075B964B07152D234B70', 'p', 1),
('etu0001', 'Gérard', 'Bertrand', '202CB962AC59075B964B07152D234B70', 'e', 1),
('etu0002', 'etu0002', 'etu0002', '202CB962AC59075B964B07152D234B70', 'e', 1),
('etu0003', 'etu0003', 'etu0003', '202CB962AC59075B964B07152D234B70', 'e', 1),
('etu0004', 'etu0004', 'etu0004', '202CB962AC59075B964B07152D234B70', 'e', 1),
('etu0005', 'etu0005', 'etu0005', '202CB962AC59075B964B07152D234B70', 'e', 1),
('etu0006', 'etu0006', 'etu0006', '202CB962AC59075B964B07152D234B70', 'e', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_ville`
--

DROP TABLE IF EXISTS `tbl_ville`;
CREATE TABLE IF NOT EXISTS `tbl_ville` (
  `no_ville` int(11) NOT NULL AUTO_INCREMENT,
  `nom_ville` varchar(35) NOT NULL,
  `actif` tinyint(4) NOT NULL,
  PRIMARY KEY (`no_ville`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tbl_ville`
--

INSERT INTO `tbl_ville` (`no_ville`, `nom_ville`, `actif`) VALUES
(8, 'Trois-Rivières Ouest', 1),
(9, 'Cap-De-La-Madeleine', 1),
(10, 'Pointe-Du-Lac', 1),
(11, 'Trois-Rivières', 1);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `tbl_commandes`
--
ALTER TABLE `tbl_commandes`
  ADD CONSTRAINT `tbl_commandes_ibfk_1` FOREIGN KEY (`no_fournisseur`) REFERENCES `tbl_fournisseurs` (`no_fournisseur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_commandes_ibfk_2` FOREIGN KEY (`no_utilisateur`) REFERENCES `tbl_utilisateurs` (`no_utilisateur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_commandes_ibfk_3` FOREIGN KEY (`no_exercice`) REFERENCES `tbl_exercices` (`no_exercice`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_exercices`
--
ALTER TABLE `tbl_exercices`
  ADD CONSTRAINT `tbl_exercices_ibfk_2` FOREIGN KEY (`no_cours`) REFERENCES `tbl_cours` (`no_cours`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_exercices_ibfk_3` FOREIGN KEY (`no_inventaire`) REFERENCES `tbl_inventaire` (`no_inventaire`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_fournisseurs`
--
ALTER TABLE `tbl_fournisseurs`
  ADD CONSTRAINT `tbl_fournisseurs_ibfk_1` FOREIGN KEY (`ville`) REFERENCES `tbl_ville` (`no_ville`);

--
-- Contraintes pour la table `tbl_inventaire_detail`
--
ALTER TABLE `tbl_inventaire_detail`
  ADD CONSTRAINT `tbl_inventaire_detail_ibfk_1` FOREIGN KEY (`no_emplacement`) REFERENCES `tbl_emplacement_inventaire` (`no_emplacement`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_inventaire_detail_ibfk_2` FOREIGN KEY (`code_produit`) REFERENCES `tbl_produits` (`code_produit`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_inventaire_detail_ibfk_3` FOREIGN KEY (`no_inventaire`) REFERENCES `tbl_inventaire` (`no_inventaire`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_inventaire_prof`
--
ALTER TABLE `tbl_inventaire_prof`
  ADD CONSTRAINT `tbl_inventaire_prof_ibfk_1` FOREIGN KEY (`no_utilisateur`) REFERENCES `tbl_utilisateurs` (`no_utilisateur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_inventaire_prof_ibfk_4` FOREIGN KEY (`no_inventaire`) REFERENCES `tbl_inventaire` (`no_inventaire`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_produits`
--
ALTER TABLE `tbl_produits`
  ADD CONSTRAINT `tbl_produits_ibfk_1` FOREIGN KEY (`no_mesure`) REFERENCES `tbl_unites_mesure` (`no_mesure`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_produits_ibfk_2` FOREIGN KEY (`no_format`) REFERENCES `tbl_formats` (`no_format`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_produits_ibfk_3` FOREIGN KEY (`no_categorie`) REFERENCES `tbl_categories` (`no_categorie`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_produit_fournisseur_prix`
--
ALTER TABLE `tbl_produit_fournisseur_prix`
  ADD CONSTRAINT `tbl_produit_fournisseur_prix_ibfk_1` FOREIGN KEY (`no_fournisseur`) REFERENCES `tbl_fournisseurs` (`no_fournisseur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_produit_fournisseur_prix_ibfk_2` FOREIGN KEY (`code_produit`) REFERENCES `tbl_produits` (`code_produit`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_produit_taxe`
--
ALTER TABLE `tbl_produit_taxe`
  ADD CONSTRAINT `tbl_produit_taxe_ibfk_1` FOREIGN KEY (`code_produit`) REFERENCES `tbl_produits` (`code_produit`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_produit_taxe_ibfk_2` FOREIGN KEY (`id_taxe`) REFERENCES `tbl_taxes` (`id_taxes`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_reception_details`
--
ALTER TABLE `tbl_reception_details`
  ADD CONSTRAINT `tbl_reception_detail_ibfk_1` FOREIGN KEY (`no_reception`) REFERENCES `tbl_reception_exercices` (`no_reception`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_reception_detail_ibfk_2` FOREIGN KEY (`code_produit`) REFERENCES `tbl_produits` (`code_produit`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_reception_detail_ibfk_3` FOREIGN KEY (`no_commande`) REFERENCES `tbl_commandes` (`no_commande`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_reception_exercices`
--
ALTER TABLE `tbl_reception_exercices`
  ADD CONSTRAINT `tbl_exercices_ibfk_1` FOREIGN KEY (`no_exercice`) REFERENCES `tbl_exercices` (`no_exercice`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tbl_telephones`
--
ALTER TABLE `tbl_telephones`
  ADD CONSTRAINT `tbl_telephones_ibfk_1` FOREIGN KEY (`no_fournisseur`) REFERENCES `tbl_fournisseurs` (`no_fournisseur`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
