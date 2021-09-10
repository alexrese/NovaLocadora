-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 10, 2021 at 02:05 AM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `locadora`
--

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `nomeCliente` varchar(100) NOT NULL,
  `cpfCliente` varchar(20) NOT NULL,
  `emailCliente` varchar(150) NOT NULL,
  `ativoCliente` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`idCliente`, `nomeCliente`, `cpfCliente`, `emailCliente`, `ativoCliente`) VALUES
(1, 'Alex Luciano Roesler Rese', '999.999.999-99', 'alexrese@univali.br', 1);

-- --------------------------------------------------------

--
-- Table structure for table `filme`
--

CREATE TABLE `filme` (
  `idFilme` int(11) NOT NULL,
  `nomeFilme` varchar(100) NOT NULL,
  `categoriaFilme` varchar(50) NOT NULL,
  `descricaoFilme` text NOT NULL,
  `anoFilme` int(4) NOT NULL,
  `ativoFilme` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `filme`
--

INSERT INTO `filme` (`idFilme`, `nomeFilme`, `categoriaFilme`, `descricaoFilme`, `anoFilme`, `ativoFilme`) VALUES
(1, 'Jurassic Park I', 'Ficção', 'filme de dinossauros', 1996, 1),
(2, 'Clube da Luta', 'Ficção', 'filme que tem regras', 1999, 1),
(3, 'De volta para o futuro', 'Ficção', 'Filme de um cientista e um jovem malandro que viajam no tempo', 1994, 1),
(4, 'Efeito Borboleta', 'Ficção', 'filme de um rapaz que quer concertar o passado, com vários beneficios no futuro', 1998, 1),
(5, '007', 'ação', 'agende britanico que combate o mundo', 2010, 1),
(6, 'Jurrasic Park III', 'Ficção/Aventura', 'Segundo filme de dinossauros', 1998, 1),
(7, 'Matrix 4', 'Ficção/Ação', 'Filme que mostrar que vivemos em uma simulação', 2021, 1),
(8, 'Matrix 3', 'Ficção', 'Mais um filme de simulação', 2008, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Indexes for table `filme`
--
ALTER TABLE `filme`
  ADD PRIMARY KEY (`idFilme`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `filme`
--
ALTER TABLE `filme`
  MODIFY `idFilme` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
