-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : sam. 22 nov. 2025 à 13:05
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_ecole`
--

-- --------------------------------------------------------

--
-- Structure de la table `absences`
--

CREATE TABLE `absences` (
  `Id` int(11) NOT NULL,
  `EleveId` int(11) DEFAULT NULL,
  `DateAbsence` date DEFAULT NULL,
  `Justifiee` tinyint(1) DEFAULT 0,
  `Duree` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `eleves`
--

CREATE TABLE `eleves` (
  `Id` int(11) NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `DateNaissance` date DEFAULT NULL,
  `Classe` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `eleves`
--

INSERT INTO `eleves` (`Id`, `Nom`, `Prenom`, `DateNaissance`, `Classe`) VALUES
(1, 'Foukeng Kemayou', 'Bavel Franck', '2005-02-10', '6ème A'),
(2, 'Kemayou Pierre', 'Oscar', '2007-11-07', '6ème A'),
(3, 'Foukeng Kemayou', 'Bavel Franck', '2005-02-10', '6ème A'),
(4, 'Kemayou Pierre', 'Oscar', '2007-11-07', '6ème A');

-- --------------------------------------------------------

--
-- Structure de la table `matieres`
--

CREATE TABLE `matieres` (
  `Id` int(11) NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Coefficient` decimal(3,2) DEFAULT 1.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `matieres`
--

INSERT INTO `matieres` (`Id`, `Nom`, `Coefficient`) VALUES
(1, 'Maths', 2.00),
(2, 'Maths', 2.00),
(3, 'SVT', 2.00),
(4, 'SVT', 2.00),
(5, 'Histoire / Geographie', 2.00),
(6, 'Histoire / Geographie', 2.00);

-- --------------------------------------------------------

--
-- Structure de la table `notes`
--

CREATE TABLE `notes` (
  `Id` int(11) NOT NULL,
  `EleveId` int(11) DEFAULT NULL,
  `MatiereId` int(11) DEFAULT NULL,
  `Valeur` decimal(4,2) DEFAULT NULL,
  `DateNote` date DEFAULT NULL,
  `Commentaire` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `notes`
--

INSERT INTO `notes` (`Id`, `EleveId`, `MatiereId`, `Valeur`, `DateNote`, `Commentaire`) VALUES
(1, 1, 1, 16.00, '2025-11-11', 'BIEN'),
(2, 1, 3, 10.00, '2025-11-11', 'Passable'),
(3, 1, 5, 17.00, '2025-11-11', 'Tres Bien');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absences`
--
ALTER TABLE `absences`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `EleveId` (`EleveId`);

--
-- Index pour la table `eleves`
--
ALTER TABLE `eleves`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `matieres`
--
ALTER TABLE `matieres`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `EleveId` (`EleveId`),
  ADD KEY `MatiereId` (`MatiereId`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `absences`
--
ALTER TABLE `absences`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `eleves`
--
ALTER TABLE `eleves`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `matieres`
--
ALTER TABLE `matieres`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `notes`
--
ALTER TABLE `notes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absences`
--
ALTER TABLE `absences`
  ADD CONSTRAINT `absences_ibfk_1` FOREIGN KEY (`EleveId`) REFERENCES `eleves` (`Id`);

--
-- Contraintes pour la table `notes`
--
ALTER TABLE `notes`
  ADD CONSTRAINT `notes_ibfk_1` FOREIGN KEY (`EleveId`) REFERENCES `eleves` (`Id`),
  ADD CONSTRAINT `notes_ibfk_2` FOREIGN KEY (`MatiereId`) REFERENCES `matieres` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
