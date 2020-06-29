-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 15-06-2018 a las 02:09:15
-- Versión del servidor: 5.7.19
-- Versión de PHP: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `calcu`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentas`
--

DROP TABLE IF EXISTS `cuentas`;
CREATE TABLE IF NOT EXISTS `cuentas` (
  `num1` double NOT NULL,
  `signo` varchar(30) NOT NULL,
  `num2` double NOT NULL,
  `resultado` double NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cuentas`
--

INSERT INTO `cuentas` (`num1`, `signo`, `num2`, `resultado`) VALUES
(55.4, '-', 2, 53.4),
(555, '-', 8, 547),
(555555555555, '+', 3333333333, 558888888888),
(10, '/', 3, 3.33333333333333),
(555, '+', 3, 558),
(88, '+', 3, 91),
(5, '+', 6, 11),
(55, '+', 3, 58),
(6, '+', 3, 9),
(1, '+', 2, 3),
(5, '*', 6, 30),
(30755.6, '+', 333.55, 31089.15),
(31089.15, '-', 55.222, 31033.928),
(31033.928, '+', 4411, 35444.928),
(35444.928, '*', 8855, 313864837.44),
(313864837.44, '/', 3, 104621612.48);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
