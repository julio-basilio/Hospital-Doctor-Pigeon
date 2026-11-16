create database if not exists DoctorPigeon;
use DoctorPigeon;

create table if not exists Medico (
    crm_Med char(6),
    nome_Med varchar(60) not null,
    espec_Med varchar(100) not null,
    fone_Med char(17) not null,
    email_Med varchar(35) not null,
    data_Med date not null,
    primary key(crm_Med)
) engine="InnoDB";

create table if not exists Paciente (
    cpf_Pct char(14),
    nome_Pct varchar(35) not null,
    date_Pct date not null,
    foto_Pct longblob,
    genero_Pct varchar(15) not null, 
    primary key(cpf_Pct)
) engine="InnoDB";

create table if not exists Agendamento (
    cod_Agend int auto_increment,
    crm_Med char(6),
    cpf_Pct char(14),
    data_Agend date not null,
    hora_Agend time not null,
    status_Agend varchar(15) not null,
    primary key(cod_Agend),
    constraint fk_agend_medico foreign key (crm_Med) references Medico(crm_Med),
    constraint fk_agend_paciente foreign key (cpf_Pct) references Paciente(cpf_Pct)
) engine="InnoDB";

create table if not exists Atendimento (
    id_Atend int auto_increment,
    cod_Agend int,
    desc_Atend varchar(500),
    primary key(id_Atend),
    constraint fk_atend_agendamento foreign key (cod_Agend) references Agendamento(cod_Agend)
) engine="InnoDB";