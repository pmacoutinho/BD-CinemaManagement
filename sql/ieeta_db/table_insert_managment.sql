use p3g8;
-----------------------
-- management tables
-----------------------

go
insert into management.Employee_Type values ('Manager');
insert into management.Employee_Type values ('Deputy Manager');
insert into management.Employee_Type values ('Sales');
insert into management.Employee_Type values ('Cleaning');
go
    -- full time shifts
insert into management.Employee_Shift values ('8:00', '18:00');

insert into management.Employee_Shift values ('8:00', '17:00');
insert into management.Employee_Shift values ('17:00', '2:00');
    -- part time shifts
insert into management.Employee_Shift values ('8:00', '12:30');
insert into management.Employee_Shift values ('12:30', '17:00');
go

-- placio gelo employees
insert into management.Employee values ('Leonor Figueiredo', 'leonoedo@gmail.com', 1, 0, 0); -- manager
insert into management.Employee values ('Nelson Domingues', 'nelsoes@gmail.com', 1, 2, 1)-- nigth shift deputy manager
insert into management.Employee values ('Hélder Carvalho', 'helderho@gmail.com', 1, 1, 2); -- day shiift sales
insert into management.Employee values ('Lorena Lourenço', 'lorenanco@gmail.com',1, 2, 2) --nigth shift sales
insert into management.Employee values ('Isabela Pinto', 'isabelnto@gmail.com', 1, 3, 2) -- 1st part time sales shift
insert into management.Employee values ('Martinho Melo', 'martelo@gmail.com', 1, 4, 2) -- 2nd part time sales shift
insert into management.Employee values ('Xavier Rocha', 'xaviecha@gmail.com', 1, 1, 3) -- cleaning day shift
go

-- glicinias aveiro
insert into management.Room values (1, 0, 114);
insert into management.Room values (2, 0, 102);
insert into management.Room values (3, 0, 120);
insert into management.Room values (4, 0, 114);
insert into management.Room values (5, 0, 92);
insert into management.Room values (6, 0, 146);
-- palacio gelo viseu
insert into management.Room values (1, 1, 114);
insert into management.Room values (2, 1, 102);
insert into management.Room values (3, 1, 120);
insert into management.Room values (4, 1, 114);
insert into management.Room values (5, 1, 92);
insert into management.Room values (6, 1, 146);
-- palacio gelo viseu
insert into management.Room values (1, 2, 114);
insert into management.Room values (2, 2, 102);
insert into management.Room values (3, 2, 120);
insert into management.Room values (4, 2, 114);
insert into management.Room values (5, 2, 92);
insert into management.Room values (6, 2, 146);
-- forum coimbra
insert into management.Room values (1, 3, 114);
insert into management.Room values (2, 3, 102);
insert into management.Room values (3, 3, 120);
insert into management.Room values (4, 3, 114);
insert into management.Room values (5, 3, 92);
insert into management.Room values (6, 3, 146);

go

