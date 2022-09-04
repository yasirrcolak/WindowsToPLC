-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 04 Eyl 2022, 17:08:01
-- Sunucu sürümü: 10.4.24-MariaDB
-- PHP Sürümü: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `plc_db_s7`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `okuma`
--

CREATE TABLE `okuma` (
  `islemYapilanPlc` varchar(50) NOT NULL,
  `okumaAdresi` varchar(50) NOT NULL,
  `okunanDeger` varchar(20) NOT NULL,
  `tarihSaat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yazma`
--

CREATE TABLE `yazma` (
  `islemYapilanPlc` varchar(50) NOT NULL,
  `yazmaAdresi` varchar(50) NOT NULL,
  `oncekiDeger` varchar(20) NOT NULL,
  `yazilanDeger` varchar(20) NOT NULL,
  `tarihSaat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
