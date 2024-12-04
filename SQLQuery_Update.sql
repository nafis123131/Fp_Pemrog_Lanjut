use Sistem_Manajemen_Hotel

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