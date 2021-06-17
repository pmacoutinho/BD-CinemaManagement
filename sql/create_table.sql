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

create table Management.Funcionario(
	id		int		Primary Key,
	name	varchar(50) not null,
	eType	int,
	eShift	int,

	-- supervisor
	-- deferrable constraints? R: not supported

	CONSTRAINT FK_sFuncionario_type FOREIGN KEY (eType)
      REFERENCES Management.Employee_Type(num)
      ON UPDATE CASCADE
	  ON DELETE Set Null,

	CONSTRAINT FK_sFuncionario_shift FOREIGN KEY (eShift)
      REFERENCES Management.Employee_Shift(id)
      ON UPDATE CASCADE
	  ON DELETE Set Null
	
);

create table Management.Sala(
	num		int not null,
	cinema	int not null,
	nSeats	int not null,

	Primary Key(num, cinema),

	CONSTRAINT FK_sala_cinema FOREIGN KEY (cinema)
      REFERENCES Management.Cinema(id)
      ON UPDATE CASCADE
	  -- ON DELETE
);

-- Data Schema
create table Data.Filme(
	imdb	int Primary Key,
	name	varchar(50) not null,
	timeMin	int	not null, --minutos
	director varchar(50) not null
	-- divisão em partes ?
);

create table Data.Sessao(
	id		int Primary Key,
	cinema	int not null,
	filmId	int not null,
	wDay	int not null, -- represents one day of the week
	dTime	time not null
	CONSTRAINT FK_session_filmid FOREIGN KEY (filmId)
      REFERENCES Data.Filme(imdb)
      ON UPDATE CASCADE,
	  -- on delete

	CONSTRAINT FK_session_cinema FOREIGN KEY (cinema)
      REFERENCES Management.Cinema(id)
      ON UPDATE CASCADE
	  -- on delete
);


-- Operations Schema
create table Operations.Sessao_instance(
	sessao		int not null,
	sCinema		int not null,
	sNum		int not null,

	Primary Key (sessao, sCinema, sNum),

	CONSTRAINT FK_sessao_inst_sessao FOREIGN KEY (sessao)
      REFERENCES Data.Sessao(id)
      ON UPDATE CASCADE,
	  -- ON DELETE  

	CONSTRAINT FK_sessao_inst_sala FOREIGN KEY (sCinema, sNum)
      REFERENCES Management.Sala(cinema, num)
      ON UPDATE CASCADE
	  -- ON DELETE
);

create table Operations.Registo_Limpeza(
	tm		datetime not null,
	sCinema	int	not null,
	sNum	int	not null,
	func	int not null,

	Primary Key(sCinema, sNum, tm),

	CONSTRAINT FK_limpeza_sala FOREIGN KEY (sCinema, sNum)
      REFERENCES Management.Sala(cinema, num)
      ON UPDATE CASCADE,
	  -- ON DELETE 

	CONSTRAINT FK_limpeza_func FOREIGN KEY (func)
      REFERENCES Management.Funcionario(id)
      ON UPDATE CASCADE
	  ON DELETE Set Null,
);


create table Operations.Cliente(
	id		int	Primary Key,
	name	varchar(max) not null,
	dNasc	date	not null
);

create table Operations.Reserva(
	lugar		int	not null,
	sessao		int not null,
	sCinema		int not null,
	sNum		int not null,

	Primary Key(lugar, sessao, sCinema, sNum),

	CONSTRAINT FK_reserva_sessao FOREIGN KEY (sessao, sCinema, sNum)
      REFERENCES Operations.Sessao_instance(sessao, sCinema, sNum)
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
      REFERENCES Operations.Cliente(id)
      ON UPDATE CASCADE
	  ON DELETE Set Null,

	CONSTRAINT FK_bilhete_reserva FOREIGN KEY (lugar, sessao, sCinema, sNum)
      REFERENCES Operations.reserva(lugar, sessao, sCinema, sNum)
      ON UPDATE CASCADE
	  ON DELETE Set Null,

);

