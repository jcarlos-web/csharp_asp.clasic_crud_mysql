create database db_proyecto;
use db_proyecto;

-- Tabla usuario
create table usuario(
id_usuario int identity not null,
nombre varchar(45) not null,
ap_pat varchar(45) not null,
ap_mat varchar(45) not null,
email varchar(45) not null,
phone varchar(45) not null,
usu   varchar(45) not null,
pw    varchar(45) not null,
activo varchar(45) not null,
);