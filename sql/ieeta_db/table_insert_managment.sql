use p3g8;
-----------------------
-- management tables
-----------------------

go
insert into management.Employee_Type values ('Manager');
insert into management.Employee_Type values ('Sales');
insert into management.Employee_Type values ('Cleaning');

    -- full time shifts
go
insert into management.Employee_Shift values ('8:00', '17:00');
insert into management.Employee_Shift values ('17:00', '2:00');
    -- part time shifts
insert into management.Employee_Shift values ('8:00', '12:30');
insert into management.Employee_Shift values ('12:30', '17:00');

go