create
    function management.f_get_employees() returns table as
    return
        select *
        from management.Employee;
go

create
    function management.f_get_employee(@EmployeeId int) returns table as
    return
        select *
        from management.f_get_employees()
        where id = @EmployeeId;
go

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

create
    function management.f_get_sellers() returns table as
    return
        select *
        from management.f_get_employees()
        where eType = 2;
go

create
    function management.f_get_seller(@EmployeeId int) returns table as
    return
        select *
        from management.f_get_sellers()
        where id = @EmployeeId;
go