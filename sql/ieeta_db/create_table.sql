use p3g8;

create table Location.Cinema(
	id		int		Primary Key IDENTITY(0,1),
	name	varchar(max) not null,
	location varchar(max) not null
);

-- Manegment Schema
create table Management.Employee_Type(
	num		int		Primary Key IDENTITY(0,1),
	name	varchar(max) not null
);

create table Management.Employee_Shift(
	id			int Primary Key IDENTITY(0,1),
	start_time	time,
	end_time	time not null

); 

create table Management.Employee(
	id		int		Primary Key IDENTITY(0,1),
	name	varchar(max) not null,
	email   varchar(max),
	location int not null,
	eShift	int,
	eType	int,

	-- supervisor
	-- deferrable constraints? R: not supported
    CONSTRAINT FK_employee_location FOREIGN KEY (location)
      REFERENCES Location.Cinema(id)
      ON UPDATE CASCADE
	  ON DELETE CASCADE,

	CONSTRAINT FK_employee_type FOREIGN KEY (eType)
      REFERENCES Management.Employee_Type(num)
      ON UPDATE CASCADE
	  ON DELETE Set Null,

	CONSTRAINT FK_employee_shift FOREIGN KEY (eShift)
      REFERENCES Management.Employee_Shift(id)
      ON UPDATE CASCADE
	  ON DELETE Set Null
	
);

create table Management.Room(
	num		int not null,
	cinema	int not null,
	nSeats	int not null,

	Primary Key(cinema, num),

	CONSTRAINT FK_room_cinema FOREIGN KEY (cinema)
      REFERENCES Location.Cinema(id)
      ON UPDATE CASCADE
	  ON DELETE Cascade
);

-- Data Schema
create table Data.Film(
	imdb	int Primary Key,
	name	varchar(max) not null,
	timeMin	int	not null, --minutos
	director varchar(max) not null
	-- divis�o em partes ?
);

create table Data.Session(
	id		int Primary Key IDENTITY(0,1),
	cinema	int not null,
	filmId	int not null,
	wDay	int not null, -- represents one day of the week
	dTime	time not null
	CONSTRAINT FK_session_filmid FOREIGN KEY (filmId)
      REFERENCES Data.Film(imdb)
      ON UPDATE CASCADE,
	  -- on delete

	CONSTRAINT FK_session_cinema FOREIGN KEY (cinema)
      REFERENCES Location.Cinema(id)
      ON UPDATE CASCADE
	  On Delete Cascade
);


-- Operations Schema
create table Operations.Session_instance(
	session		int not null,
	sCinema		int not null,
	sNum		int not null,

	Primary Key (session, sCinema, sNum),

	CONSTRAINT FK_session_inst_sessao FOREIGN KEY (session)
      REFERENCES Data.Session(id),
      --ON UPDATE CASCADE
	  --On Delete Cascade,

	CONSTRAINT FK_session_inst_sala FOREIGN KEY (sCinema, sNum)
      REFERENCES Management.Room(cinema, num)
      --ON UPDATE CASCADE
	  --On Delete Cascade
);

create table Operations.Cleaning_Record(
	tm		datetime not null,
	sCinema	int	not null,
	sNum	int	not null,
	func	int not null,

	Primary Key(sCinema, sNum, tm),

	CONSTRAINT FK_limpeza_sala FOREIGN KEY (sCinema, sNum)
      REFERENCES Management.Room(cinema, num)
      ON UPDATE CASCADE
	  On Delete Cascade,

	CONSTRAINT FK_limpeza_func FOREIGN KEY (func)
      REFERENCES Management.Employee(id)
      ON UPDATE CASCADE,
);

create table Operations.Client(
	id		int	Primary Key IDENTITY(0,1),
	name	varchar(max) not null,
	dNasc	date	not null
);

create table Operations.Reservation(
	seat		int	not null,
	session		int not null,
	sCinema		int not null,
	sNum		int not null,

	Primary Key(seat, session, sCinema, sNum),

	CONSTRAINT FK_reservation_session FOREIGN KEY (session, sCinema, sNum)
      REFERENCES Operations.Session_instance(session, sCinema, sNum)
      ON UPDATE CASCADE
	  ON DELETE Cascade,
);

create table Operations.Ticket(
	id			int Primary Key IDENTITY(0,1),
	price		real not null,
	client		int	not null,

	seat		int	not null,
	session		int not null,
	sCinema		int not null,
	sNum		int not null,

	CONSTRAINT FK_ticket_client FOREIGN KEY (client)
      REFERENCES Operations.Client(id)
      ON UPDATE CASCADE
	  ON DELETE no action,

	CONSTRAINT FK_ticket_reservation FOREIGN KEY (seat, session, sCinema, sNum)
      REFERENCES Operations.reservation(seat, session, sCinema, sNum)
      ON UPDATE CASCADE
	  ON DELETE No action,

);

