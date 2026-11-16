create database if not exists Mercado;
use Mercado;

create table if not exists Produtos(
    cod_prod int primary key,
    desc_prod varchar(60) not null,
    valor_prod decimal(5,2) not null,
    venc_prod date not null
)engine="InnoDB";

insert into Produtos(cod_prod, desc_prod, valor_prod, venc_prod)
values("46524","Pão de mão","15.49","2027-09-21"),
("20589","Batata Chips","7.50","2027-02-01"),
("07267","Amaciante de Roupa","75.49","2028-05-30"),
("87532","Saco de Arroz 1kg","25.49","2027-05-04"),
("92364","Saco de Feijão 1kg","27.49","2027-04-15"),
("38634","Chettos","6.49","2026-12-04"),
("90823","kg de maçã","31.99","2027-01-08"),
("18753","Peito de frango 1kg","19.49","2027-04-11"),
("43265","Pacote cerveja skol","28.49","2028-06-20"),
("53622","Miojo Nissin","5.49","2026-12-25"),
("65272","Caixa de Bombom","17.49","2027-03-09");

select * from produtos;