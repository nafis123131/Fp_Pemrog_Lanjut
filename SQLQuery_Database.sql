use Sistem_Manajemen_Hotel

CREATE TABLE Client_Table
(
	Client_ID int identity (1,1) NOT NULL,
	Client_FirstName VARCHAR (150) NOT NULL,
	Client_LastName VARCHAR (150) NOT NULL,
	Client_Phone VARCHAR (150) UNIQUE NOT NULL,
	Client_Address VARCHAR(150) NOT NULL,
	CONSTRAINT Client_table_Client_ID_PK PRIMARY KEY (Client_ID)
);

INSERT INTO Client_Table VALUES
('Ramadhan','Nafis','23115873','Athaya'),
('Muhammad', 'Ramadhan','115873','Nafis');

DROP TABLE User_Table;