CREATE procedure data.p_new_session
    @Cinema int,
    @FilmId int,
    @StartDay datetime,
	@NoWeeks int

AS
    begin
        insert into data.Session values (@Cinema, @FilmId, @StartDay, @NoWeeks);
    end
go
