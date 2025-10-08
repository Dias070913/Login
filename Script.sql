drop database if exists dbLogin;

create database dbLogin;

use dbLogin;

create table tbCliente(
	Id int primary key auto_increment,
    Nome varchar(100) not null,
    Nascimento date not null,
    Sexo char(1),
    CPF bigint not null,
    Telefone bigint,
    Email varchar(100) not null,
    Senha varchar(50) not null,
    Situacao varchar(100) not null
);

create table tbColaborador(
	Id int primary key auto_increment,
    Nome varchar(100) not null,
    Email varchar(100) not null,
    Senha varchar(50) not null,
    Tipo varchar(100) not null
);