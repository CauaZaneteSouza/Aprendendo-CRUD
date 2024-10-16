create database bdEscola;
use bdEscola;

create table tblAluno(
id int not null auto_increment primary key,
nome varchar(50),
idade int,
unidade char(1),
serie int,
turma char(1)
);