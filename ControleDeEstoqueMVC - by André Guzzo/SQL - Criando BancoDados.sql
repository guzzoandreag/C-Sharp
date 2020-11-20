CREATE DATABASE dbControleDeEstoque
ON PRIMARY(
NAME=dbControleDeEstoque,
FILENAME='C:\BD\dbControleDeEstoque.MDF',
SIZE=100MB,
MAXSIZE=300MB,
FILEGROWTH=10%
)

USE dbControleDeEstoque

CREATE TABLE tbl_Produtos(
id int PRIMARY KEY IDENTITY(1,1),
cod_barras char(9) NOT NULL,
descricao varchar(200) NOT NULL,
foto image,
qtde smallint NOT NULL,
vr_unitario money NOT NULL)

select * from tbl_Produtos