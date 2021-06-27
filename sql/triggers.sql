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