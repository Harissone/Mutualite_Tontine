--insert into Reunion (id_reun, nom_reun, taux_col, nbre_mem, description, date_reun ) values (01 , 'famille tamo' , 10000, 12, 'reunion de famille', '15/08/2020' );
--alter table Reunion drop fonct_id;
alter table [membres] add [fonction] varchar(255) not null; 