CREATE DATABASE `attendance`;

USE attendance;

CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(255) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `pangkat` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE `attendance` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) NOT NULL,
  `date` date NOT NULL DEFAULT CURRENT_DATE,
  `time` time NOT NULL DEFAULT CURRENT_TIME,
  `attendance` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
);

INSERT INTO users (email, nama, pangkat, password) VALUES ('admin@gmail.com', 'danda', 'admin', 'admin')