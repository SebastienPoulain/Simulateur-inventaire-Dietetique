-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  jeu. 09 mai 2019 à 19:35
-- Version du serveur :  5.7.23
-- Version de PHP :  7.2.10

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
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=latin1;

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

-- --------------------------------------------------------

--
-- Structure de la table `tbl_inventaire`
--

DROP TABLE IF EXISTS `tbl_inventaire`;
CREATE TABLE IF NOT EXISTS `tbl_inventaire` (
  `no_inventaire` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`no_inventaire`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

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
('admin', 'Admin', 'Admin', '21232F297A57A5A743894A0E4A801FC3', 'a', 1);

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
