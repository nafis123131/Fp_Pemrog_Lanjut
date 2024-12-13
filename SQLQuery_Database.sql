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

create table Room_Table
(
	Room_Number int identity (1,1) NOT NULL,
	Room_Type VARCHAR (6) NOT NULL,
	Room_Phone varchar (15) NOT NULL,
	Room_Free varchar (3) Not null,
	constraint Room_Table_Room_Number_PK Primary key (Room_Number)
);

insert into Room_Table values 
('Single','1234','Yes'),
('Family','5678','No');