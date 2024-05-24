-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Bulan Mei 2024 pada 09.53
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbmhs`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbmhs`
--

CREATE TABLE `tbmhs` (
  `idMhs` int(11) NOT NULL,
  `nama` text NOT NULL,
  `nim` text NOT NULL,
  `kelamin` varchar(255) NOT NULL,
  `ulang` varchar(255) NOT NULL,
  `prodi` text NOT NULL,
  `ipk` varchar(255) NOT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbmhs`
--

INSERT INTO `tbmhs` (`idMhs`, `nama`, `nim`, `kelamin`, `ulang`, `prodi`, `ipk`, `gambar`) VALUES
(1, 'Muhammad Abdillah', '2209106065', 'Laki - Laki', 'Tidak', 'Informatika', '4.0', 'GambarMhs\\abdi2.jpg'),
(2, 'Ahmad Nur Fauzan', '2209106057', 'Laki - Laki', 'Tidak', 'Informatika', '4.0', 'GambarMhs\\WhatsApp Image 2023-11-11 at 14.22.48_4f08db14.jpg'),
(4, 'Tommy Candra Gunawan', '2209106068', 'Laki - Laki', 'Tidak', 'Informatika', '4.0', 'GambarMhs\\tommy2.jpg'),
(5, 'Abdullah Azam', '2209106056', 'Laki - Laki', 'Tidak', 'Informatika', '4.0', 'GambarMhs\\WhatsApp Image 2023-11-11 at 14.22.49_80071b64.jpg'),
(7, '123', '123', 'Laki - Laki', 'Ya', 'Sistem Informasi', '4.0', 'GambarMhs\\pinguin.jpg'),
(8, '123', '123', 'Laki - Laki', 'Ya', 'Sistem Informasi', '4.0', 'GambarMhs\\WhatsApp Image 2024-03-27 at 16.59.21_dbea681a.jpg'),
(11, '345354', '34534', 'Laki - Laki', 'Ya', 'Informatika', '3.99', 'GambarMhs\\Screenshot 2024-05-17 225246.png');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbmhs`
--
ALTER TABLE `tbmhs`
  ADD PRIMARY KEY (`idMhs`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbmhs`
--
ALTER TABLE `tbmhs`
  MODIFY `idMhs` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
