﻿CREATE TABLE `User` (
	id long NOT NULL,
	username VARCHAR(80) NOT NULL,
	passwd VARCHAR(80) NOT NULL
);

ALTER TABLE `User` CHANGE id id INT(10) AUTO_INCREMENT PRIMARY KEY;