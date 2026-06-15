-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 15, 2026 at 03:42 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `task_management_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `companies`
--

CREATE TABLE `companies` (
  `comp_id` int(11) NOT NULL,
  `comp_name` varchar(50) DEFAULT NULL,
  `mobile_no` varchar(20) DEFAULT NULL,
  `tel_no` varchar(20) DEFAULT NULL,
  `comp_address` varchar(50) DEFAULT NULL,
  `tin` varchar(255) DEFAULT NULL,
  `business_type` varchar(255) DEFAULT NULL,
  `messenger_link` text DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `companies`
--

INSERT INTO `companies` (`comp_id`, `comp_name`, `mobile_no`, `tel_no`, `comp_address`, `tin`, `business_type`, `messenger_link`, `created_at`) VALUES
(1, 'Mabuhayone Corporation', '09072943742', NULL, 'Plaza Nova Bldg, Santiago Blvd, GSC', '298-506-622-000', 'Other Business Activities, N.E.C', NULL, '2024-08-27 23:10:04'),
(2, 'Honda Cars General Santos, INC.', '09072943742', NULL, 'J Catolico Ave, Lagao, GSC', '005-134-268-000', 'Sale and Repair of Motor Vigicles', NULL, '2024-08-27 23:10:40'),
(3, 'Peoples Rural Bank', '09072943742', NULL, 'Plaza Nova Bldg, Santiago Blvd, GSC', '005-135-590-000', 'Banking', NULL, '2024-08-29 09:11:21'),
(4, 'ECA Resources, Inc./ECA building', '09072943742', NULL, 'National Highway, City Heights, GSC', '006-623-611-000', 'Leasing', NULL, '2026-03-17 03:04:08'),
(5, 'Buildtolast Corporation', '09072943742', NULL, 'SAIP, National Highway, Polomolok', '010-114-555-000', 'Wholesale of Construction', NULL, '2026-03-17 03:04:09'),
(6, 'Mabuhay Technopark Corporation', '09072943742', NULL, 'National Highway, Lagao (1st & 3rd), GSC', '006-294-594-000', 'Leasing', NULL, '2026-03-17 03:04:08'),
(7, 'ECA Resources, INC./Cold Store Plus', '09072943742', NULL, 'Banisil, Brgy. Tambler', '000-623-611-001', 'Cold Storage', NULL, '2026-03-17 03:04:11'),
(8, 'Mincorn Corporation', '09072943742', NULL, 'Plaza Nova Bldg, Dad South, GSC', '777-399-279-000', 'Corn Milling', NULL, '0000-00-00 00:00:00'),
(9, 'Dalan Mindanao (A Foundatio), INC.', '09072943742', NULL, 'Plaza Nova Bldg, Dad South, GSC', '005-977-139-000', 'Corn Milling', NULL, '0000-00-00 00:00:00'),
(10, 'Ecalands Corporation', '09072943742', NULL, 'ECA Bldg, National Highway, GSC', '483-594-409-000', 'Real Estate Buyinng, Developing, Subdividing, Selleng', NULL, '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `notifications`
--

CREATE TABLE `notifications` (
  `notif_id` int(11) NOT NULL,
  `message` text NOT NULL,
  `recipient` int(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `date` date NOT NULL DEFAULT current_timestamp(),
  `is_read` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `notifications`
--

INSERT INTO `notifications` (`notif_id`, `message`, `recipient`, `type`, `date`, `is_read`) VALUES
(26, '\'Desktop\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-03-14', 1),
(27, '\'test1\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-03-14', 1),
(28, '\'CCTV HDD Replacement\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-03-17', 1),
(29, '\'Network Cable Installation\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-03-17', 1),
(30, '\'Computer System Maintenance\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-03-17', 1),
(31, '\'Printer Troubleshooting\' has been assigned to you. Please review and start working on it', 2, 'New Task Assigned', '2026-03-17', 1),
(32, '\'UPS Battery Replacement\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-03-17', 1),
(33, '\'test\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-03-18', 1),
(34, '\'System Repair\' has been assigned to you. Please review and start working on it', 2, 'New Task Assigned', '2026-03-30', 1),
(35, '\'CCTV\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-04-04', 1),
(36, '\'123\' has been assigned to you. Please review and start working on it', 2, 'New Task Assigned', '2026-05-18', 0),
(37, '\'Test\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-18', 1),
(38, '\'1\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-18', 1),
(39, '\'123\' has been assigned to you. Please review and start working on it', 2, 'New Task Assigned', '2026-05-19', 0),
(40, '\'1\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-22', 1),
(41, '\'1\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-22', 1),
(42, '\'2\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-22', 1),
(43, '\'33\' has been assigned to you. Please review and start working on it', 11, 'New Task Assigned', '2026-05-22', 0),
(44, '\'Epson L120 not printing\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-22', 1),
(45, '\'1\' has been assigned to you. Please review and start working on it', 11, 'New Task Assigned', '2026-05-23', 0),
(46, '\'1\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-23', 0),
(47, '\'12\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-23', 0),
(48, '\'12\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-23', 0),
(49, '\'12\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-23', 0),
(50, '\'1\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-23', 0),
(51, '\'Twst\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-23', 0),
(52, '\'1\' has been assigned to you. Please review and start working on it', 2, 'New Task Assigned', '2026-05-23', 0),
(53, '\'1\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-23', 0),
(54, '\'1\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-23', 0),
(55, '\'12\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-23', 0),
(56, '\'12\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-23', 0),
(57, '\'Ja\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-23', 0),
(58, '\'2\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-23', 0),
(59, '\'1\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-23', 0),
(60, '\'123\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-24', 0),
(61, '\'123\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-24', 0),
(62, '\'123\' has been assigned to you. Please review and start working on it', 8, 'New Task Assigned', '2026-05-24', 0),
(63, '\'123\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 1),
(64, '\'123\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(65, '\'123\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(66, '\'No internet\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(67, '\'Epson l120\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(68, '\'Epson l120\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(69, '\'L380\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(70, '\'HDD\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(71, '\'jaime\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(72, '\'Epson L120\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(73, '\'epson l120\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(74, '\'Epson L120\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(75, '\'Switch\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(76, '\'123\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(77, '\'HDD ERROR\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(78, '\'NO RECORD\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(79, '\'WEBMAIL PROBLEM\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(80, '\'PRINTER PROBLEM\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-29', 0),
(81, '\'No connection\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-30', 0),
(82, '\'NO RECORD\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-30', 0),
(83, '\'Cant access my company email\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-30', 0),
(84, '\'not turning on my CPU\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-30', 0),
(85, '\'CANT INSTALL QUICKBOOKS\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-05-30', 0),
(86, '\'Test\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-06-11', 0),
(87, '\'No record\' has been assigned to you. Please review and start working on it', 7, 'New Task Assigned', '2026-06-12', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tasks`
--

CREATE TABLE `tasks` (
  `task_id` int(11) NOT NULL,
  `report_id` varchar(50) DEFAULT NULL,
  `category` varchar(50) DEFAULT NULL,
  `title` varchar(100) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `company_id` int(11) DEFAULT NULL,
  `company_name` varchar(255) DEFAULT NULL,
  `requested_by` varchar(50) DEFAULT NULL,
  `requester_no` varchar(20) DEFAULT NULL,
  `requester_ipadd` varchar(20) DEFAULT NULL,
  `device_info` text DEFAULT NULL,
  `assigned_id` int(11) DEFAULT NULL,
  `assigned_to` int(11) DEFAULT NULL,
  `due_date` date DEFAULT NULL,
  `status` enum('pending','assigned','in_progress','on_hold','completed','cancelled') DEFAULT 'pending',
  `dagnosis` text DEFAULT NULL,
  `recommendation` text DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tasks`
--

INSERT INTO `tasks` (`task_id`, `report_id`, `category`, `title`, `description`, `company_id`, `company_name`, `requested_by`, `requester_no`, `requester_ipadd`, `device_info`, `assigned_id`, `assigned_to`, `due_date`, `status`, `dagnosis`, `recommendation`, `created_at`) VALUES
(39, '100901', NULL, 'CCTV HDD Replacement', 'Replaced the defective hard disk drive of the DVR to restore video recording functionality.', NULL, 'Mabuhayone Corporation', '', NULL, '', NULL, 8, 7, '2026-06-02', 'completed', NULL, NULL, '2026-05-31 18:04:02'),
(40, '100902', NULL, 'Network Cable Installation', 'Installed new LAN cable connection to provide stable internet access for the workstation.', NULL, 'Honda Cars General Santos, INC.', '', NULL, '', NULL, 8, 7, '2026-03-18', 'completed', NULL, NULL, '2026-03-17 02:46:03'),
(41, '100903', NULL, 'Computer System Maintenance', 'Performed system cleanup, virus scan, and software updates to improve computer performance.', NULL, 'Peoples Rural Bank', '', NULL, '', NULL, 2, 8, '2026-03-21', 'completed', NULL, NULL, '2026-03-17 02:46:51'),
(42, '100904', NULL, 'Printer Troubleshooting', 'Diagnosed and fixed printer connectivity issue to restore normal printing operation.', NULL, 'Mabuhayone Corporation', '', NULL, '', NULL, 7, 2, '2026-03-18', 'completed', NULL, NULL, '2026-03-17 02:47:26'),
(43, '100985', NULL, 'UPS Battery Replacement', 'Replaced old UPS battery to ensure continuous power backup during power interruptions.', NULL, 'Mabuhayone Corporation', '', NULL, '', NULL, 7, 7, '2026-03-17', 'completed', NULL, NULL, '2026-03-17 02:48:06'),
(45, '100986', NULL, 'System Repair', 'No Hard disk', NULL, 'ECA Resources, INC./Cold Store Plus', '', NULL, '', NULL, 2, 2, '2026-03-31', 'completed', NULL, NULL, '2026-03-30 08:31:35'),
(46, '100987', NULL, 'CCTV', 'NO HARD DISK', NULL, 'Honda Cars General Santos, INC.', '', NULL, '', NULL, 7, 8, '2026-04-05', 'completed', NULL, NULL, '2026-04-04 10:42:21'),
(47, '100988', NULL, '123', '123', NULL, 'Honda Cars General Santos, INC.', '123', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-19', 'pending', NULL, NULL, '2026-05-18 12:01:22'),
(48, '100989', NULL, 'Test', 'Test', NULL, 'ECA Resources, INC./Cold Store Plus', 'Test', NULL, '192.168.1.4', 'Mozilla/5.0 (Linux; Android 10; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Mobile Safari/537.36', 7, 7, '2026-05-19', 'completed', NULL, NULL, '2026-05-18 12:06:24'),
(49, '100990', NULL, '1', '1', NULL, 'Mabuhay Technopark Corporation', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 8, '2026-05-20', 'completed', NULL, NULL, '2026-05-18 12:27:59'),
(50, '100991', NULL, '123', '123', NULL, 'Honda Cars General Santos, INC.', '123', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 8, 2, '0000-00-00', 'pending', NULL, NULL, '2026-05-19 14:07:38'),
(51, '100992', NULL, '1', '1', NULL, 'Buildtolast Corporation', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 7, '2026-05-23', 'completed', NULL, NULL, '2026-05-22 12:43:26'),
(52, '100993', NULL, '1', '1', NULL, 'Buildtolast Corporation', '', NULL, '', NULL, 7, 7, '2026-05-23', 'completed', NULL, NULL, '2026-05-22 12:45:11'),
(53, '100994', NULL, '2', '2', NULL, 'Peoples Rural Bank', '', NULL, '', NULL, 8, 7, '2026-05-23', 'completed', NULL, NULL, '2026-05-22 13:22:31'),
(55, '100995', NULL, 'Epson L120 not printing', 'Nag paper Jam', NULL, 'Honda Cars General Santos, INC.', 'Shiloh', NULL, '192.168.1.6', 'Mozilla/5.0 (Linux; Android 10; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Mobile Safari/537.36', 8, 7, '2026-05-25', 'in_progress', NULL, NULL, '2026-05-22 15:42:22'),
(56, '100996', 'Hardware', '1', '', NULL, 'ECA Resources, Inc./ECA building', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 8, 11, '2026-05-30', 'pending', NULL, NULL, '2026-05-22 16:20:50'),
(57, '100997', 'Others', '1', '', NULL, 'ECA Resources, Inc./ECA building', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 8, '2026-05-30', 'completed', NULL, NULL, '2026-05-22 16:27:24'),
(58, '100998', 'Printer', '12', '12', NULL, 'ECA Resources, Inc./ECA building', '12', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 8, '2026-05-29', 'pending', NULL, NULL, '2026-05-22 16:29:00'),
(59, '100999', 'Others', '12', '', NULL, 'Buildtolast Corporation', '12', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 3, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-22 16:29:49'),
(60, '101000', 'Others', '12', '', NULL, 'Mabuhay Technopark Corporation', '12', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 8, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-22 16:30:52'),
(61, '101001', 'Others', '1', '', NULL, 'Peoples Rural Bank', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 7, '2026-05-28', 'completed', NULL, NULL, '2026-05-22 16:34:39'),
(62, '101002', 'Account', 'Twst', 'Test', NULL, 'Buildtolast Corporation', 'Aida tagalog', NULL, '192.168.1.4', 'Mozilla/5.0 (Linux; Android 10; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/149.0.0.0 Mobile Safari/537.36', 8, 7, '2026-05-30', 'completed', NULL, NULL, '2026-05-22 16:37:11'),
(63, '101003', 'Email', '1', '', NULL, 'ECA Resources, Inc./ECA building', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 2, '2026-05-30', 'pending', NULL, NULL, '2026-05-22 16:41:38'),
(64, '101004', 'Others', '1', '1', NULL, 'Mabuhay Technopark Corporation', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 7, '2026-05-29', 'completed', NULL, NULL, '2026-05-22 16:42:03'),
(65, '101005', 'Device', '1', '', NULL, 'Mabuhay Technopark Corporation', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 7, '2026-05-29', 'pending', NULL, NULL, '2026-05-22 16:52:49'),
(66, '101006', 'Maintenance', '12', '12', NULL, 'Mabuhay Technopark Corporation', '12', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 8, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-22 16:55:56'),
(67, '101007', 'Others', '12', '12', NULL, 'Buildtolast Corporation', '12', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 7, '2026-05-30', 'pending', NULL, NULL, '2026-05-22 16:56:30'),
(68, '101008', 'Email', 'Ja', '', NULL, 'Mincorn Corporation', 'Aj', NULL, '192.168.1.4', 'Mozilla/5.0 (Linux; Android 10; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/149.0.0.0 Mobile Safari/537.36', 2, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-22 16:57:42'),
(69, '101009', 'Email', '2', '2', NULL, 'Buildtolast Corporation', '2', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-22 17:10:28'),
(70, '101010', 'Others', '1', '1', NULL, 'Buildtolast Corporation', '1', NULL, '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 7, '0000-00-00', 'pending', NULL, NULL, '2026-05-22 17:10:49'),
(71, '101011', 'Email', '123', '123', NULL, 'Mabuhay Technopark Corporation', '123', '2147483647', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 8, '2026-05-29', 'pending', NULL, NULL, '2026-05-24 14:17:47'),
(72, '101012', 'Hardware', '123', '123', NULL, 'Mabuhay Technopark Corporation', '123', '2147483647', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-05-27', 'pending', NULL, NULL, '2026-05-24 14:18:57'),
(73, '101013', 'Software', '123', '123', NULL, 'ECA Resources, Inc./ECA building', '123123', '09123123123', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 2, 8, '2026-05-25', 'pending', NULL, NULL, '2026-05-24 14:20:05'),
(74, '101014', 'Hardware', '123', '123', 5, NULL, '123', '09123123123', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 12:05:08'),
(75, '101015', 'Email', '123', '123', 1, NULL, '123', '09123123123', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 13:52:27'),
(76, '101015', 'Email', '123', '123', 1, NULL, '123', '09123123123', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 13:54:12'),
(77, '101016', 'Hardware', '123', '123', 1, NULL, '123', '09123123123', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 13:55:54'),
(78, '101017', 'Account', '123', '123', 1, NULL, '123', '09123123123', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 13:57:39'),
(79, '101018', 'Network', 'No internet', 'please asap', 1, NULL, 'jaime segador', '09123123123', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 14:06:23'),
(80, '101019', 'Printer', 'Epson l120', 'Paper Jan', 1, NULL, 'marilyn', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-31', 'pending', NULL, NULL, '2026-05-29 14:22:58'),
(81, '101019', 'Printer', 'Epson l120', 'Paper Jan', 1, NULL, 'marilyn', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-31', 'pending', NULL, NULL, '2026-05-29 14:29:27'),
(82, '101020', 'Printer', 'L380', 'Jam', 1, NULL, 'Jaime', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-31', 'pending', NULL, NULL, '2026-05-29 14:36:18'),
(83, '101021', 'Hardware', 'HDD', 'No Record', 1, NULL, 'Jaime Segador', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-06-06', 'pending', NULL, NULL, '2026-05-29 14:44:55'),
(84, '101022', 'Printer', 'jaime', 'jaime', 1, NULL, 'jaime', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 14:49:32'),
(85, '101023', 'Printer', 'Epson L120', 'Paper jam', 1, NULL, 'Jaime segador', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-05-31', 'pending', NULL, NULL, '2026-05-29 14:53:41'),
(86, '101024', 'Printer', 'epson l120', 'test', 4, NULL, 'jaime', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 14:57:26'),
(87, '101025', 'Printer', 'Epson L120', 'Paper jam', 1, NULL, 'Marilyb', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 15:00:57'),
(88, '101026', 'Network', 'Switch', 'No Internet', 1, NULL, 'Jaime Segador', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-06-05', 'pending', NULL, NULL, '2026-05-29 15:03:33'),
(89, '101027', 'Network', '123', '123', 4, NULL, '123', '09123123123', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 15:17:19'),
(90, '101027', 'Hardware', 'HDD ERROR', 'CANT STORE DATA', 1, NULL, 'JEFF', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 8, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 15:18:07'),
(91, '101028', 'CCTV', 'NO RECORD', 'CANT UPDATE TIME', 4, NULL, '123', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-31', 'pending', NULL, NULL, '2026-05-29 15:21:07'),
(92, '101029', 'Email', 'WEBMAIL PROBLEM', 'CANT RECEIVE EMAILS', 1, NULL, 'JAIME SEGADOR', '09072943742', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 15:25:09'),
(93, '101030', 'Hardware', 'PRINTER PROBLEM', 'CANNOT PRINT PAPER JAM', 1, NULL, 'Mahel Luis', '09391979091', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-30', 'pending', NULL, NULL, '2026-05-29 15:53:28'),
(94, '101031', 'Internet', 'No connection', 'Please Restore asap', 2, NULL, 'Jaime Segador', '', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-06-06', 'pending', NULL, NULL, '2026-05-29 16:10:54'),
(95, '101032', 'CCTV', 'NO RECORD', 'Please check the camera infront of office. thanks', 7, NULL, 'Jaime Segador', '', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 7, '2026-05-31', 'pending', NULL, NULL, '2026-05-29 16:17:12'),
(96, '101033', 'Account', 'Cant access my company email', 'Please restore my account. thanks', 3, NULL, 'Jaime Segador', '', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-05-31', 'pending', NULL, NULL, '2026-05-29 16:22:56'),
(97, '101034', 'Hardware', 'not turning on my CPU', '', 2, NULL, 'Jaime Segador', '', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 7, 2, '2026-06-06', 'pending', NULL, NULL, '2026-05-29 22:22:22'),
(98, '101035', 'Software', 'CANT INSTALL QUICKBOOKS', '', 2, NULL, 'JAIME SEGADOR', '', '::1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/148.0.0.0 Safari/537.36', 8, 8, '2026-06-30', 'pending', NULL, NULL, '2026-06-12 14:22:22'),
(99, '101036', 'Software', 'Test', 'Test', 6, NULL, 'Jaime', '', '192.168.1.4', 'Mozilla/5.0 (Linux; Android 10; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/149.0.0.0 Mobile Safari/537.36', 8, 8, '2026-07-20', 'pending', NULL, NULL, '2026-06-11 14:36:55'),
(100, '101037', 'CCTV', 'No record', 'Test', 7, NULL, 'Jaime', '09072943742', '192.168.1.4', 'Mozilla/5.0 (Linux; Android 10; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/149.0.0.0 Mobile Safari/537.36', 7, 7, '2026-06-20', 'pending', NULL, NULL, '2026-06-11 18:06:52');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `employee_id` varchar(20) DEFAULT NULL,
  `full_name` varchar(50) NOT NULL,
  `mobile_no` varchar(50) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `position` varchar(20) DEFAULT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('superadmin','','admin','','misuser','','mishead','','ssuser','','sshead','','financeuser','','financehead','','acctuser','','accthead','','hrauser','','hrahead','','employee') NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `employee_id`, `full_name`, `mobile_no`, `email`, `position`, `username`, `password`, `role`, `created_at`) VALUES
(1, '10001', 'Juan Dela Cruz', '09072943742', NULL, 'OWNER', 'admin', '$2y$10$TnyR1Y43m1EIWpb0MiwE8Ocm6rj0F2KojE3PobVfQDo9HYlAHY/7O', 'admin', '2024-08-28 07:10:04'),
(2, '10002', 'Ferdinand Jereme', '09072943742', NULL, 'MIS HEAD', 'ferds', '$2y$10$AYDEfwwCROSn.NtFaMVIuuoY3e.CgimrSsHt8da3VjYQJH7QPQDuq', 'employee', '2024-08-28 07:10:40'),
(7, '10003', 'Jaime Segador', '09072943742', 'jaimsegador20@gmail.', 'IT ASSOCIATE', 'jaime', '$2y$10$3HErJSVERBw1Mg3kbPBBmODu99Kpda127PrJzMUuS7Mh801e/7DQq', 'employee', '2024-08-29 17:11:21'),
(8, '10004', 'Jeffrey Faeldonia', '09072943742', NULL, 'IT ASSOCIATE', 'jeff', '$2y$10$ZQthtesHaFOPWrNOfndSh.rn4bxIO.Gg/Xf6DQpO34qCtpf0mp.9i', 'employee', '2024-08-29 17:11:34'),
(11, NULL, 'Firstname Lastname', '09072943742', 'test', 'test', 'test', '$2y$10$..pgEZG0duw4DB0QWbV0Vee5hft2i8AjdB8WXZ220nP3aMLbblouq', 'employee', '2026-05-22 13:50:29');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `notifications`
--
ALTER TABLE `notifications`
  ADD PRIMARY KEY (`notif_id`);

--
-- Indexes for table `tasks`
--
ALTER TABLE `tasks`
  ADD PRIMARY KEY (`task_id`),
  ADD KEY `assigned_to` (`assigned_to`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `notifications`
--
ALTER TABLE `notifications`
  MODIFY `notif_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=88;

--
-- AUTO_INCREMENT for table `tasks`
--
ALTER TABLE `tasks`
  MODIFY `task_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tasks`
--
ALTER TABLE `tasks`
  ADD CONSTRAINT `tasks_ibfk_1` FOREIGN KEY (`assigned_to`) REFERENCES `users` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
