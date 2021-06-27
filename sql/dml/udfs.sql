-- data

create function data.f_get_film(@FilmImdb int)
returns table
AS
    return
        select *
        from data.Film
        where imdb=@FilmImdb
go
create function data.f_get_sessions(@CinemaID int, @Date date)
returns table
as
	return
		SELECT name AS 'Film Name', startDay AS 'Premiere', noWeeks AS 'No Weeks'
		FROM Data.Session
		JOIN Data.Film ON filmId = imdb
		WHERE Data.Session.cinema=@CinemaID AND ((@Date between startDay and dateadd(week, noWeeks, startDay)) or @Date < Session.startDay)
go

-- locations

create function location.f_get_cinemas() returns table as
    return select * from Cinema
go

-- management

create
    function management.f_get_employees() returns table as
    return
        select *
        from management.Employee
go

create
    function management.f_get_employee(@EmployeeId int) returns table as
    return
        select *
        from management.f_get_employees()
        where id = @EmployeeId
go

create
    function management.f_get_sellers() returns table as
    return
        select *
        from management.f_get_employees()
        where eType = 2
go

create
    function management.f_get_seller(@EmployeeId int) returns table as
    return
        select *
        from management.f_get_sellers()
        where id = @EmployeeId
go

create
    function management.f_get_cleaners() returns table as
    return
        select *
        from management.f_get_employees()
        where eType = 3
go
create
    function management.f_get_managers() returns table as
    return
        select *
        from management.Employee
        where eType = 0
go
CREATE
    function management.f_get_non_managers(@Cinema int) returns table as
    return
        select *
        from management.Employee
        where eType != 0 and location = @Cinema
go

create
    function management.f_get_rooms(@CinemaId int) returns table as
    return
        select *
        from management.Room
        where cinema=@CinemaId
go


-- operations

--returns all clients
create
    function operations.f_get_clients() returns table as
    return
        select id as ClientId, name as ClientName, email, dNasc as birthday
        from operations.Client
go

-- returns a single client
create
    function operations.f_get_client(@Id int) returns table as
    return
        select *
        from operations.f_get_clients()
        where ClientId =@Id;
go

-- returns all cleaning records for a given cinema
create function operations.f_get_cleaning_records_cinema(@CinemaId int) RETURNS TABLE AS
    return select *
            from operations.Cleaning_Record
            where sCinema=@CinemaId
go

-- returns all cleaning records for a given cinema and a given employee
create function operations.f_get_cleaning_records(@CinemaId int, @EmployeeId int) RETURNS TABLE AS
    return select *
            from operations.Cleaning_Record
            where sCinema=@CinemaId and func=@EmployeeId
go

-- returns all reservations for a given session instance
CREATE function operations.f_get_res_session_inst(@SessionInst int) returns table as
    return select si.id, nSeats,seat
            from operations.Session_instance as si
            join management.Room on cinema=si.sCinema and num = si.sNum
            left outer join  Reservation R2 on si.id = R2.session_i
            where si.id =@SessionInst
go

--returns all sessions for a given cinema
create
    function operations.f_get_session_instance(@CinemaId int) returns table as
    return
        SELECT Operations.Session_instance.id AS 'ID', Data.Film.name AS 'Film',
		Operations.Session_instance.time AS 'Start Time', Operations.Session_instance.sNum AS 'Room'
		FROM Operations.Session_instance
		JOIN Data.Session ON Operations.Session_instance.session=Data.Session.id
		JOIN Data.Film ON filmId=imdb
		WHERE Operations.Session_instance.sCinema=@CinemaId
go

-- returns tickets sold in a cinema
create
    function operations.f_get_tickets(@CinemaId int) returns table as
    return
        SELECT Operations.Ticket.id AS 'ID', price AS 'Price', Operations.Client.name AS 'Client', Management.Employee.name AS 'Seller'
		FROM Operations.Ticket
		JOIN Operations.Client ON Operations.Ticket.client=Operations.Client.id
		JOIN Operations.Reservation ON Operations.Ticket.reservation=Operations.Reservation.id
		JOIN Data.Session ON Operations.Reservation.session_i=Data.Session.id
		JOIN Management.Employee ON Operations.Ticket.sellerId=Management.Employee.id
		WHERE Data.Session.cinema=@CinemaId
go


-- public_access

create function public_access.f_get_film_sessions(@FilmImdb int)
returns table
    as
    return
        select *
        from data.Session
        where filmId=@FilmImdb
go

-- get  open sessions
alter function public_access.f_get_open_sessions(@Date date)
returns table
as
    return
        select filmId, name, director, timeMin, cinema, session, Session_instance.id as sessionInst, startDay, noWeeks, sNum as room, time as InstanceTime
        FROM data.Session
        join data.Film on Session.filmId = Film.imdb
        join operations.Session_instance on Session.id = Session_instance.session
        where (@Date between startDay and dateadd(week, noWeeks, startDay)) or @Date < Session.startDay
go

-- get open sessions for a cinema in a given dateº
alter function public_access.f_get_open_sessions_cinema(@Date date, @CinemaId int)
returns table
as
    return
        select *
        from public_access.f_get_open_sessions (@Date)
        where cinema = @CinemaId
go

select * from public_access.f_get_open_sessions_cinema ('20210724', 0)

CREATE function public_access.f_get_films_in_exibition_cinema(@Date date, @Cinema int)
returns table
as
    return
        select filmId, name
        from public_access.f_get_open_sessions(@Date)
        where cinema=@Cinema
        group by name, filmId
go

CREATE function public_access.f_get_instance_time_cinema(@Date date, @Cinema int, @Time time) returns table as
    return select *
    from public_access.f_get_open_sessions_cinema (@Date, @Cinema) as f
    where '8:00' >= @Time
;
go

CREATE function  public_access.f_get_open_session_ins_details(@Date date) returns table as
    return
        select filmId, name, f.cinema, session, sessionInst, startDay, noWeeks, room, nSeats, count(seat) as reservations
        from public_access.f_get_open_sessions(@Date) as f
        join management.Room on management.Room.cinema = f.cinema and num=f.room
        left outer join operations.Reservation on session_i=sessionInst
        group by filmId, name, f.cinema, session, sessionInst, startDay, noWeeks, room,  nSeats
go

create function public_access.f_get_session_inst(@SessionInstId int) returns table AS
    return
        select *
        from operations.Session_instance
        where id=@SessionInstId
go

create function public_access.f_get_session_inst_reservations(@SessionInstId int)
returns table
as
    return
        select f.id , count(seat) as reservations
        from f_get_session_inst  (@SessionInstId) as f
        join operations.Reservation on session_i=@SessionInstId
        group by f.id
go

create function public_access.f_movie_open_sessions(@FilmImdb int)
returns table
as
    return
        select filmId, name, startDay, noWeeks
        from public_access.f_get_open_sessions (cast(getdate() as date))
        where filmId=@FilmImdb
go