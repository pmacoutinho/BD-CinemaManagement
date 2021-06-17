use proj_cinema;
-- Manegment Schema
create table Management.Cinema(
	id		int		Primary Key,
	name	varchar(50) not null,
	location varchar(50) not null
);

create table Management.Employee_Type(
	num		int		Primary Key,
	name	varchar(50) not null
);

create table Management.Employee_Shift(
	id			int Primary Key,
	start_time	time,
	end_time	time not null

); 

create table Management.Employee(
	id		int		Primary Key,
	name	varchar(50) not null,
	eType	int,
	eShift	int,

	-- supervisor
	-- deferrable constraints? R: not supported

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

	Primary Key(num, cinema),

	CONSTRAINT FK_room_cinema FOREIGN KEY (cinema)
      REFERENCES Management.Cinema(id)
      ON UPDATE CASCADE
	  ON DELETE Cascade
);

-- Data Schema
create table Data.Film(
	imdb	int Primary Key,
	name	varchar(50) not null,
	timeMin	int	not null, --minutos
	director varchar(50) not null
	-- divisão em partes ?
);

create table Data.Session(
	id		int Primary Key,
	cinema	int not null,
	filmId	int not null,
	wDay	int not null, -- represents one day of the week
	dTime	time not null
	CONSTRAINT FK_session_filmid FOREIGN KEY (filmId)
      REFERENCES Data.Film(imdb)
      ON UPDATE CASCADE,
	  -- on delete

	CONSTRAINT FK_session_cinema FOREIGN KEY (cinema)
      REFERENCES Management.Cinema(id)
      ON UPDATE CASCADE
	  On Delete Cascade
);


-- Operations Schema
create table Operations.Session_instance(
	session		int not null,
	sCinema		int not null,
	sNum		int not null,

	Primary Key (session, sCinema, sNum),

	CONSTRAINT FK_sessao_inst_sessao FOREIGN KEY (session)
      REFERENCES Data.Session(id)
      ON UPDATE CASCADE
	  On Delete Cascade,

	CONSTRAINT FK_sessao_inst_sala FOREIGN KEY (sCinema, sNum)
      REFERENCES Management.Room(cinema, num)
      ON UPDATE CASCADE
	  On Delete Set Null
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
      ON UPDATE CASCADE
	  ON DELETE Set Null,
);


create table Operations.Client(
	id		int	Primary Key,
	name	varchar(max) not null,
	dNasc	date	not null
);

create table Operations.Reservation(
	seat		int	not null,
	session		int not null,
	sCinema		int not null,
	sNum		int not null,

	Primary Key(seat, session, sCinema, sNum),

	CONSTRAINT FK_reserva_sessao FOREIGN KEY (session, sCinema, sNum)
      REFERENCES Operations.Session_instance(session, sCinema, sNum)
      ON UPDATE CASCADE
	  ON DELETE Set Null,
);

create table Operations.Bilhete(
	id			int Primary Key,
	preco		real not null,
	client		int	not null,
	
	lugar		int	not null,
	sessao		int not null,
	sCinema		int not null,
	sNum		int not null,

	CONSTRAINT FK_bilhete_cliente FOREIGN KEY (client)
      REFERENCES Operations.Client(id)
      ON UPDATE CASCADE
	  ON DELETE Set Null,

	CONSTRAINT FK_bilhete_reserva FOREIGN KEY (lugar, sessao, sCinema, sNum)
      REFERENCES Operations.reservation(seat, session, sCinema, sNum)
      ON UPDATE CASCADE
	  ON DELETE Set Null,

);

