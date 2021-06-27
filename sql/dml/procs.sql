-- data

CREATE procedure data.p_new_film
    @FilmId int,
    @FilmName varchar(max),
    @DirectorName varchar(max),
    @Time int

AS
    begin
        insert into data.Film values (@FilmId, @FilmName, @Time, @DirectorName);
    end
go

alter procedure data.p_update_film
    @FilmId int,
    @FilmName varchar(max),
    @Time   int,
    @DirectorName varchar(max)

as
    begin
        update data.Film
        set name=@FilmName,director=@DirectorName,timeMin = @Time
        where imdb = @FilmId;

    end
go

CREATE procedure data.p_delete_film
    @FilmId int
as
    begin
        delete from data.Film
        where imdb = @FilmId;

    end
go

CREATE procedure data.p_new_session
    @CinemaId int,
    @FilmId int,
    @StartDay date,
    @NoWeeks int

AS
    begin
        insert into data.Session values (@CinemaId, @FilmId, @StartDay, @NoWeeks);
    end
go

create procedure data.p_delete_session
    @SessionId int
as
    begin
        delete from data.Session where id = @SessionId;
    end
go

-- location
-- management
create procedure management.p_new_employee
    @Name varchar(max),
    @Email varchar(max),
    @Cinema int,
    @Shift int,
    @Type int
as
    begin
        declare @NewId int;
        insert into management.Employee values (@Name, @Email, @Cinema, @Shift, @Type);
        SELECT @NewId = SCOPE_IDENTITY();

        return @NewId;
    end
go

create procedure management.p_update_employee
    @Id int,
    @Name varchar(max),
    @Email varchar(max),
    @Cinema int,
    @Shift int,
    @Type int
as
    begin
        update management.Employee
        set name=@Name, email=@Email, location=@Cinema, eShift=@Shift, eType=@Type
        where id=@Id;

    end
go

create procedure management.p_delete_employee
    @Id int
as
    begin
        delete from management.Employee
        where id=@Id;
    end
go

create procedure management.p_new_room
    @Num int,
    @Cinema int,
    @NSeats int
as
	begin
		insert into management.Room values (@Num, @Cinema, @NSeats);
	end
go

create procedure management.p_delete_room
    @Num int,
    @Cinema int,
    @NSeats int
as
	begin
	    delete from management.Room
	    where nSeats=@NSeats and num=@Num and cinema=@Cinema;

	end
go
-- operations
create procedure operations.p_new_cleaning_record
    @Cinema int,
    @RoomNumber int,
    @Employee int,
    @Time datetime
as
begin
    insert into operations.Cleaning_Record values (@Time, @Cinema, @RoomNumber, @Employee);
end
go

create procedure operations.p_delete_cleaning_record
    @Cinema int,
    @RoomNumber int,
    @Employee int,
    @Time datetime
as
begin
    delete from operations.Cleaning_Record
    where sCinema=@Cinema and sNum=@RoomNumber and tm=@Time;
end
go

CREATE procedure operations.p_new_client
    @ClientName varchar(max),
    @ClientEmail varchar(max),
    @Birthday   date
as
    begin
        declare @NewId int
        insert into operations.Client values (@ClientName, @ClientEmail, @Birthday);
        SELECT @NewId = SCOPE_IDENTITY();

        return @NewId;
    end
go

CREATE procedure operations.p_update_client
    @ClientId int,
    @ClientName varchar(max),
    @ClientEmail varchar(max),
    @Birthday   date
as
    begin
        update operations.Client
        set name=@ClientName, email=@ClientEmail, dNasc = @Birthday
        where id = @ClientId;

    end
go

CREATE procedure operations.p_delete_client
    @ClientId int
as
    begin
        delete from operations.Client
        where id = @ClientId;

    end
go

CREATE procedure operations.p_new_reservation
    @SessionId int,
    @SessionTime time,
    @CinemaId int,
    @RoomNumber int,
    @SeatNumber int
as
    begin
        begin try
            declare @ResId int;
            insert into operations.Reservation values (@SeatNumber, @SessionId);
            SELECT @ResId = SCOPE_IDENTITY()
            return @ResId

        end try
        begin catch
            throw
        end catch
    end
go

CREATE procedure operations.p_new_ticket
    @SellerId int,
    @ClientId int,
    @SessionInstanceId int,
    @SeatNumber int,
    @Price real
as

        BEGIN TRY
            declare @ResId int;
            declare @Cinema int, @Time time, @Room int;
            begin transaction
            select  @Cinema = si.sCinema, @Time = time, @Room = si.sNum
            from Session_instance as si
            where id=@SessionInstanceId;

            exec @ResId = operations.p_new_reservation @SessionInstanceId, @Time,  @Cinema, @Room, @SeatNumber;
            insert into operations.Ticket values (@Price, @ClientId, @ResId, @SellerId);
            COMMIT TRANSACTION;
        end try
        begin catch
            ROLLBACK TRANSACTION;

            throw
        end catch
go

CREATE procedure operations.p_add_session_instance
    @SessionId int,
    @InstTime time,
    @RoomNumber int
as
begin
    declare @sCinema int, @rCinema int, @rNum int;

    -- check if session exists

    print @SessionId

    set @sCinema = null;
    select @sCinema = [cinema]
    from data.Session
    where id=@SessionId

    if @sCinema is null
        RAISERROR ('The session %d doesnt exist!', 1, 1, @SessionId);

    -- check if session cinema as @RoomNumber room
    set @rNum = null;
    select @rNum = num
    from management.Room
    where cinema=@sCinema and num=@RoomNumber

    if @rNum is null
        RAISERROR ('The cinema of session %d as no room %d', 1, 1, @sCinema, @RoomNumber);

    insert into operations.Session_instance values (
        @SessionId, @sCinema, @InstTime, @rNum
    );

end
go

