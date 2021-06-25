-- data
create function data.f_get_film(@FilmImdb int)
returns table
AS
    return
        select *
        from data.Film
        where imdb=@FilmImdb
go

-- location
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

-- operations

create
    function operations.f_get_clients() returns table as
    return
        select id as ClientId, name as ClientName, email, dNasc as birthday
        from operations.Client
go

create
    function operations.f_get_client(@Id int) returns table as
    return
        select *
        from operations.f_get_clients()
        where ClientId =@Id;
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