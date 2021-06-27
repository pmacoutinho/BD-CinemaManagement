-- assure cliente final (cliente geral) não e eliminado
create trigger operations.t_client_assure_client_final
    on operations.Client
    for delete
    as
    begin
        if (select deleted.id from deleted) = 0
        begin
            raiserror('Client with id 0 cannot be deleted!',1, 1);
        end
    end
go

-- ensure fk update cascasde
create trigger management.t_cleaning_record_fk_func_update
    on management.Employee
    for update as
    begin
        if update(id)
        begin
            update operations.Cleaning_Record
            set func = inserted.id
            from operations.Cleaning_Record, inserted, deleted
            where deleted.id = Cleaning_Record.func;
        end
    end