-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2025 at 11:06 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentinfodb`
--

-- --------------------------------------------------------

--
-- Table structure for table `coursetb`
--

CREATE TABLE `coursetb` (
  `courseId` int(11) NOT NULL,
  `courseName` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `coursetb`
--

INSERT INTO `coursetb` (`courseId`, `courseName`) VALUES
(1, 'IT'),
(2, 'BSBA'),
(3, 'ABEL'),
(4, 'BPA');

-- --------------------------------------------------------

--
-- Table structure for table `studentrecordtb`
--

CREATE TABLE `studentrecordtb` (
  `studentId` int(11) NOT NULL,
  `firstName` varchar(250) DEFAULT NULL,
  `lastName` varchar(250) DEFAULT NULL,
  `middleName` varchar(250) DEFAULT NULL,
  `houseNo` int(11) DEFAULT NULL,
  `brgyName` varchar(250) DEFAULT NULL,
  `municipality` varchar(250) DEFAULT NULL,
  `province` varchar(250) DEFAULT NULL,
  `region` varchar(250) DEFAULT NULL,
  `country` varchar(250) DEFAULT NULL,
  `birthdate` varchar(250) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `studContactNo` varchar(250) DEFAULT NULL,
  `emailAddress` varchar(250) DEFAULT NULL,
  `guardianFirstName` varchar(250) DEFAULT NULL,
  `guardianLastName` varchar(250) DEFAULT NULL,
  `hobbies` varchar(250) DEFAULT NULL,
  `nickname` varchar(250) DEFAULT NULL,
  `courseId` int(11) DEFAULT NULL,
  `yearId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `studentrecordtb`
--

INSERT INTO `studentrecordtb` (`studentId`, `firstName`, `lastName`, `middleName`, `houseNo`, `brgyName`, `municipality`, `province`, `region`, `country`, `birthdate`, `age`, `studContactNo`, `emailAddress`, `guardianFirstName`, `guardianLastName`, `hobbies`, `nickname`, `courseId`, `yearId`) VALUES
(1, 'Erika Jianzild', 'Malinab', 'Cervantes', 12, 'Alac', 'San Quintin', 'Pangasinan', 'Ilocos Region', 'Philippines', '2003-05-15', 21, '09171234567', 'Emalinab@email.com', 'Jose', 'Malinab', 'Reading', 'Jian', 1, 3),
(2, 'Alyssa', 'Santos', 'Fernandez', 1, 'Poblacion East', 'Natividad', 'Pangasinan', 'Ilocos Region', 'Philippines', '2002-08-22', 21, '09182345678', 'alyF@email.com', 'Antonio', 'Santos', 'Dancing', 'Aly', 2, 2),
(3, 'Jessa', 'Rizal', 'Domingo', 56, 'Rizal Ave', 'San Carlos City', 'Pangasinan', 'Ilocos Region', 'Philippines', '2001-06-19', 22, '09193456789', 'jRizal@email.com', 'Francisco', 'Rizal', 'Sports', 'Jess', 3, 4),
(4, 'Kimberly', 'Lopez', 'Guzman', 50, 'Payapa', 'Bautista', 'Pangasinan', 'Ilocos Region', 'Philippines', '2004-12-30', 19, '09104567890', 'kimLopez@email.com', 'Carlos', 'Lopez', 'Art', 'Kim', 1, 1),
(5, 'Carlos Alberto', 'Cruz', 'Aquino', 654, 'Mabini St', 'Bayambang', 'Pangasinan', 'Ilocos Region', 'Philippines', '2000-03-10', 25, '09115678901', 'carlosalberto@example.com', 'Ricardo', 'Cruz', 'Traveling', 'Albert', 2, 5);

-- --------------------------------------------------------

--
-- Table structure for table `yeartb`
--

CREATE TABLE `yeartb` (
  `yearId` int(11) NOT NULL,
  `yearLvl` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `yeartb`
--

INSERT INTO `yeartb` (`yearId`, `yearLvl`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `coursetb`
--
ALTER TABLE `coursetb`
  ADD PRIMARY KEY (`courseId`);

--
-- Indexes for table `studentrecordtb`
--
ALTER TABLE `studentrecordtb`
  ADD PRIMARY KEY (`studentId`),
  ADD KEY `courseId` (`courseId`),
  ADD KEY `yearId` (`yearId`);

--
-- Indexes for table `yeartb`
--
ALTER TABLE `yeartb`
  ADD PRIMARY KEY (`yearId`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `studentrecordtb`
--
ALTER TABLE `studentrecordtb`
  ADD CONSTRAINT `studentrecordtb_ibfk_1` FOREIGN KEY (`courseId`) REFERENCES `coursetb` (`courseId`),
  ADD CONSTRAINT `studentrecordtb_ibfk_2` FOREIGN KEY (`yearId`) REFERENCES `yeartb` (`yearId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
