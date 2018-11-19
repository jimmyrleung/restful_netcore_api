CREATE TABLE Book (
	id long NOT NULL,
	author VARCHAR(80),
	launchDate datetime(6) NOT null,
	price decimal(65,2) NOT null,
	title VARCHAR(50)
);

ALTER TABLE Book CHANGE id id INT(10) AUTO_INCREMENT PRIMARY KEY;