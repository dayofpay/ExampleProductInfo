-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране: 23 септ 2021 в 00:27
-- Версия на сървъра: 10.4.19-MariaDB
-- Версия на PHP: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `examplepd`
--

-- --------------------------------------------------------

--
-- Структура на таблица `productinfo`
--

CREATE TABLE `productinfo` (
  `product_id` int(200) NOT NULL,
  `product_desc` varchar(256) NOT NULL,
  `product_valid` tinyint(1) NOT NULL,
  `product_weight` varchar(256) NOT NULL,
  `product_price` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `productinfo`
--

INSERT INTO `productinfo` (`product_id`, `product_desc`, `product_valid`, `product_weight`, `product_price`) VALUES
(9582, 'Видео Игра GTA V', 1, '0.01KG', 0),
(9122, 'Видео Игра GTA SA', 0, '0.01KG', 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
