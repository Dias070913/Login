drop database if exists dbLogin;

create database dbLogin;

use dbLogin;

create table tbCliente(
	Id int primary key auto_increment,
    Nome varchar(100) not null,
    Nascimento datetime not null,
    Sexo char(1),
    CPF varchar(11) not null,
    Telefone varchar(14) not null,
    Email varchar(100) not null,
    Senha varchar(50) not null,
    ConfirmacaoSenha varchar(50) not null,
    Situacao char(1) not null
);

create table tbColaborador(
	Id int primary key auto_increment,
    Nome varchar(100) not null,
    Email varchar(100) not null,
    Senha varchar(50) not null,
    Tipo varchar(8) not null
);