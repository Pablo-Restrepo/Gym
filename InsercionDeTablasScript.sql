/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     31/07/2022 8:19:35 p.?m.                     */
/*==============================================================*/


alter table ASESORA
   drop constraint FK_ASESORA_ASESORA_ENTRENAD;

alter table ASESORA
   drop constraint FK_ASESORA_ASESORA2_USUARIO;

alter table ASIGNA
   drop constraint FK_ASIGNA_ASIGNA_USUARIO;

alter table ASIGNA
   drop constraint FK_ASIGNA_ASIGNA2_PLANALIM;

alter table CAPACITA
   drop constraint FK_CAPACITA_CAPACITA_ENTRENAD;

alter table CAPACITA
   drop constraint FK_CAPACITA_CAPACITA2_CURSO;

alter table CLIENTE
   drop constraint FK_CLIENTE_ES_UN_PERSONA;

alter table CLIENTE
   drop constraint FK_CLIENTE_TIENE_USUARIO;

alter table COMPRA
   drop constraint FK_COMPRA_COMPRA_USUARIO;

alter table COMPRA
   drop constraint FK_COMPRA_COMPRA2_SUSCRIPC;

alter table COMPRA1
   drop constraint FK_COMPRA1_COMPRA1_USUARIO;

alter table COMPRA1
   drop constraint FK_COMPRA1_COMPRA3_PRODUCTO;

alter table EJERCICIO
   drop constraint FK_EJERCICI_USA_MAQUINA;

alter table ENTRENADOR
   drop constraint FK_ENTRENAD_ES_UN3_PERSONA;

alter table NUTRICIONISTA
   drop constraint FK_NUTRICIO_CREA_PLANALIM;

alter table NUTRICIONISTA
   drop constraint FK_NUTRICIO_ES_UN2_PERSONA;

alter table PRODUCTO
   drop constraint FK_PRODUCTO_PROVEE_PROVEEDO;

alter table RUTINA
   drop constraint FK_RUTINA_CREA1_ENTRENAD;

alter table TIENE1
   drop constraint FK_TIENE1_TIENE1_USUARIO;

alter table TIENE1
   drop constraint FK_TIENE1_TIENE7_RUTINA;

alter table TIENE2
   drop constraint FK_TIENE2_TIENE5_RUTINA;

alter table TIENE2
   drop constraint FK_TIENE2_TIENE6_EJERCICI;

alter table TIENE3
   drop constraint FK_TIENE3_TIENE3_SUSCRIPC;

alter table TIENE3
   drop constraint FK_TIENE3_TIENE4_ADICIONA;

alter table USUARIO
   drop constraint FK_USUARIO_HACE_EXAMENME;

alter table USUARIO
   drop constraint FK_USUARIO_TIENE2_CLIENTE;

drop table ADICIONAL cascade constraints;

drop index ASESORA2_FK;

drop index ASESORA_FK;

drop table ASESORA cascade constraints;

drop index ASIGNA2_FK;

drop index ASIGNA_FK;

drop table ASIGNA cascade constraints;

drop index CAPACITA2_FK;

drop index CAPACITA_FK;

drop table CAPACITA cascade constraints;

drop index TIENE_FK;

drop table CLIENTE cascade constraints;

drop index COMPRA2_FK;

drop index COMPRA_FK;

drop table COMPRA cascade constraints;

drop index COMPRA3_FK;

drop index COMPRA1_FK;

drop table COMPRA1 cascade constraints;

drop table CURSO cascade constraints;

drop index USA_FK;

drop table EJERCICIO cascade constraints;

drop table ENTRENADOR cascade constraints;

drop table EXAMENMEDICO cascade constraints;

drop table MAQUINA cascade constraints;

drop index CREA_FK;

drop table NUTRICIONISTA cascade constraints;

drop table PERSONA cascade constraints;

drop table PLANALIMENTACION cascade constraints;

drop index PROVEE_FK;

drop table PRODUCTO cascade constraints;

drop table PROVEEDOR cascade constraints;

drop index CREA1_FK;

drop table RUTINA cascade constraints;

drop table SUSCRIPCION cascade constraints;

drop index TIENE7_FK;

drop index TIENE1_FK;

drop table TIENE1 cascade constraints;

drop index TIENE6_FK;

drop index TIENE5_FK;

drop table TIENE2 cascade constraints;

drop index TIENE4_FK;

drop index TIENE3_FK;

drop table TIENE3 cascade constraints;

drop index HACE_FK;

drop index TIENE2_FK;

drop table USUARIO cascade constraints;

/*==============================================================*/
/* Table: ADICIONAL                                             */
/*==============================================================*/
create table ADICIONAL 
(
   ADI_NOMBRE           VARCHAR2(20)         not null,
   ADI_PRECIO           FLOAT                not null,
   ADI_DESCRIPCION      VARCHAR2(100),
   constraint PK_ADICIONAL primary key (ADI_NOMBRE)
);

/*==============================================================*/
/* Table: ASESORA                                               */
/*==============================================================*/
create table ASESORA 
(
   PER_CEDULA           INTEGER              not null,
   USU_LOGIN            VARCHAR2(20)         not null,
   constraint PK_ASESORA primary key (PER_CEDULA, USU_LOGIN)
);

/*==============================================================*/
/* Index: ASESORA_FK                                            */
/*==============================================================*/
create index ASESORA_FK on ASESORA (
   PER_CEDULA ASC
);

/*==============================================================*/
/* Index: ASESORA2_FK                                           */
/*==============================================================*/
create index ASESORA2_FK on ASESORA (
   USU_LOGIN ASC
);

/*==============================================================*/
/* Table: ASIGNA                                                */
/*==============================================================*/
create table ASIGNA 
(
   USU_LOGIN            VARCHAR2(20)         not null,
   PLAN_ID              INTEGER              not null,
   constraint PK_ASIGNA primary key (USU_LOGIN, PLAN_ID)
);

/*==============================================================*/
/* Index: ASIGNA_FK                                             */
/*==============================================================*/
create index ASIGNA_FK on ASIGNA (
   USU_LOGIN ASC
);

/*==============================================================*/
/* Index: ASIGNA2_FK                                            */
/*==============================================================*/
create index ASIGNA2_FK on ASIGNA (
   PLAN_ID ASC
);

/*==============================================================*/
/* Table: CAPACITA                                              */
/*==============================================================*/
create table CAPACITA 
(
   PER_CEDULA           INTEGER              not null,
   CUR_ID               INTEGER              not null,
   constraint PK_CAPACITA primary key (PER_CEDULA, CUR_ID)
);

/*==============================================================*/
/* Index: CAPACITA_FK                                           */
/*==============================================================*/
create index CAPACITA_FK on CAPACITA (
   PER_CEDULA ASC
);

/*==============================================================*/
/* Index: CAPACITA2_FK                                          */
/*==============================================================*/
create index CAPACITA2_FK on CAPACITA (
   CUR_ID ASC
);

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE 
(
   PER_CEDULA           INTEGER              not null,
   USU_LOGIN            VARCHAR2(20),
   PER_NOMBRE           VARCHAR2(20)         not null,
   PER_APELLIDO         VARCHAR2(20)         not null,
   PER_FECHANACI        DATE,
   PER_SEXO             VARCHAR2(20),
   PER_PESO             FLOAT,
   PER_ALTURA           FLOAT,
   PER_FOTO             BLOB,
   CLI_TARJETACREDITO   VARCHAR2(30)         not null,
   CLI_CIUDAD           VARCHAR2(20),
   constraint PK_CLIENTE primary key (PER_CEDULA)
);

/*==============================================================*/
/* Index: TIENE_FK                                              */
/*==============================================================*/
create index TIENE_FK on CLIENTE (
   USU_LOGIN ASC
);

/*==============================================================*/
/* Table: COMPRA                                                */
/*==============================================================*/
create table COMPRA 
(
   USU_LOGIN            VARCHAR2(20)         not null,
   SUS_NOMBRE           VARCHAR2(20)         not null,
   COMP_FECHAACTIV      DATE                 not null,
   COMP_FECHACANCEL     DATE,
   COMP_TIEMPOREST      DATE,
   constraint PK_COMPRA primary key (USU_LOGIN, SUS_NOMBRE)
);

/*==============================================================*/
/* Index: COMPRA_FK                                             */
/*==============================================================*/
create index COMPRA_FK on COMPRA (
   USU_LOGIN ASC
);

/*==============================================================*/
/* Index: COMPRA2_FK                                            */
/*==============================================================*/
create index COMPRA2_FK on COMPRA (
   SUS_NOMBRE ASC
);

/*==============================================================*/
/* Table: COMPRA1                                               */
/*==============================================================*/
create table COMPRA1 
(
   USU_LOGIN            VARCHAR2(20)         not null,
   PROD_CODBARRAS       INTEGER              not null,
   COMP1_CODRECLAMAR    INTEGER              not null,
   COMP1_FECHACOMPRA    DATE                 not null,
   COMP1_CANTIDAD       INTEGER,
   COMP1_TOTAL          FLOAT,
   constraint PK_COMPRA1 primary key (USU_LOGIN, PROD_CODBARRAS, COMP1_CODRECLAMAR)
);

/*==============================================================*/
/* Index: COMPRA1_FK                                            */
/*==============================================================*/
create index COMPRA1_FK on COMPRA1 (
   USU_LOGIN ASC
);

/*==============================================================*/
/* Index: COMPRA3_FK                                            */
/*==============================================================*/
create index COMPRA3_FK on COMPRA1 (
   PROD_CODBARRAS ASC
);

/*==============================================================*/
/* Table: CURSO                                                 */
/*==============================================================*/
create table CURSO 
(
   CUR_ID               INTEGER              not null,
   CUR_NOMBRE           VARCHAR2(30)         not null,
   CUR_DESCRIPCION      VARCHAR2(200),
   PER_CEDULA INTEGER,
   constraint PK_CURSO primary key (CUR_ID)
);
/*==============================================================*/
/* Index: PER_CEDULA_FK                                                */
/*==============================================================*/
create index PER_CEDULA_FK on EJERCICIO (
   PER_CEDULA ASC
);


/*==============================================================*/
/* Table: EJERCICIO                                             */
/*==============================================================*/
create table EJERCICIO 
(
   EJER_CODIGO          INTEGER              not null,
   MAQ_CODIGO           INTEGER,
   EJER_NOMBRE          VARCHAR2(20)         not null,
   EJER_SERIES          INTEGER,
   EJER_REPESERIES      INTEGER,
   EJER_DESCANSO        VARCHAR2(20),
   EJER_DESCRIPCION     VARCHAR2(200),
   EJER_MUSCULOEJER     VARCHAR2(20),
   EJER_FOTO            BLOB,
   EJER_TIPOTRENEJER    VARCHAR2(20),
   constraint PK_EJERCICIO primary key (EJER_CODIGO)
);

/*==============================================================*/
/* Index: USA_FK                                                */
/*==============================================================*/
create index USA_FK on EJERCICIO (
   MAQ_CODIGO ASC
);

/*==============================================================*/
/* Table: ENTRENADOR                                            */
/*==============================================================*/
create table ENTRENADOR 
(
   PER_CEDULA           INTEGER              not null,
   PER_NOMBRE           VARCHAR2(20)         not null,
   PER_APELLIDO         VARCHAR2(20)         not null,
   PER_FECHANACI        DATE,
   PER_SEXO             VARCHAR2(20),
   PER_PESO             FLOAT,
   PER_ALTURA           FLOAT,
   PER_FOTO             BLOB,
   ENTRE_SALARIO        FLOAT,
   constraint PK_ENTRENADOR primary key (PER_CEDULA)
);

/*==============================================================*/
/* Table: EXAMENMEDICO                                          */
/*==============================================================*/
create table EXAMENMEDICO 
(
   EXA_NOMBRE           VARCHAR2(30)         not null,
   EXA_FECHA            DATE                 not null,
   EXA_DESCRIPCION      VARCHAR2(200),
   constraint PK_EXAMENMEDICO primary key (EXA_NOMBRE)
);

/*==============================================================*/
/* Table: MAQUINA                                               */
/*==============================================================*/
create table MAQUINA 
(
   MAQ_CODIGO           INTEGER              not null,
   MAQ_NOMBRE           VARCHAR2(30)         not null,
   MAQ_PESO             FLOAT,
   MAQ_TIPOMAQUINA      VARCHAR2(20),
   MAQ_MUSCULOTRABAJA   VARCHAR2(20),
   MAQ_MARCA            VARCHAR2(20),
   MAQ_FOTO             BLOB,
   constraint PK_MAQUINA primary key (MAQ_CODIGO)
);

/*==============================================================*/
/* Table: NUTRICIONISTA                                         */
/*==============================================================*/
create table NUTRICIONISTA 
(
   PER_CEDULA           INTEGER              not null,
   PLAN_ID              INTEGER              not null,
   PER_NOMBRE           VARCHAR2(20)         not null,
   PER_APELLIDO         VARCHAR2(20)         not null,
   PER_FECHANACI        DATE,
   PER_SEXO             VARCHAR2(20),
   PER_PESO             FLOAT,
   PER_ALTURA           FLOAT,
   PER_FOTO             BLOB,
   NUTRI_TITULO         VARCHAR2(20)         not null,
   NUTRI_SALARIO        FLOAT,
   constraint PK_NUTRICIONISTA primary key (PER_CEDULA)
);

/*==============================================================*/
/* Index: CREA_FK                                               */
/*==============================================================*/
create index CREA_FK on NUTRICIONISTA (
   PLAN_ID ASC
);

/*==============================================================*/
/* Table: PERSONA                                               */
/*==============================================================*/
create table PERSONA 
(
   PER_CEDULA           INTEGER              not null,
   PER_NOMBRE           VARCHAR2(20)         not null,
   PER_APELLIDO         VARCHAR2(20)         not null,
   PER_FECHANACI        DATE,
   PER_SEXO             VARCHAR2(20),
   PER_PESO             FLOAT,
   PER_ALTURA           FLOAT,
   PER_FOTO             BLOB,
   constraint PK_PERSONA primary key (PER_CEDULA)
);

/*==============================================================*/
/* Table: PLANALIMENTACION                                      */
/*==============================================================*/
create table PLANALIMENTACION 
(
   PLAN_ID              INTEGER              not null,
   PLAN_NOMBRE          VARCHAR2(30)         not null,
   PLAN_LUNES           VARCHAR2(200),
   PLAN_MARTES          VARCHAR2(200),
   PLAN_MIERCOLES       VARCHAR2(200),
   PLAN_JUEVES          VARCHAR2(200),
   PLAN_VIERNES         VARCHAR2(200),
   PLAN_SABADO          VARCHAR2(200),
   PLAN_DOMINGO         VARCHAR2(200),
   constraint PK_PLANALIMENTACION primary key (PLAN_ID)
);

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO 
(
   PROD_CODBARRAS       INTEGER              not null,
   PROVE_NIT            INTEGER              not null,
   PROD_NOMBRE          VARCHAR2(50)         not null,
   PROD_PRECIO          FLOAT,
   PROD_CANTIDAD        INTEGER,
   PROD_FOTO            BLOB,
   PROD_TIPOPROD        VARCHAR2(20),
   constraint PK_PRODUCTO primary key (PROD_CODBARRAS)
);

/*==============================================================*/
/* Index: PROVEE_FK                                             */
/*==============================================================*/
create index PROVEE_FK on PRODUCTO (
   PROVE_NIT ASC
);

/*==============================================================*/
/* Table: PROVEEDOR                                             */
/*==============================================================*/
create table PROVEEDOR 
(
   PROVE_NIT            INTEGER              not null,
   PROVE_NOMBRE         VARCHAR2(30)         not null,
   PROVE_TELEFONO       INTEGER,
   PROVE_DIRECCION      VARCHAR2(40),
   PROVE_CORREO         VARCHAR2(40),
   constraint PK_PROVEEDOR primary key (PROVE_NIT)
);

/*==============================================================*/
/* Table: RUTINA                                                */
/*==============================================================*/
create table RUTINA 
(
   RUT_ID               INTEGER              not null,
   PER_CEDULA           INTEGER              not null,
   RUT_NOMBRE           VARCHAR2(20)         not null,
   RUT_TIPOTRENEJER     VARCHAR2(20),
   constraint PK_RUTINA primary key (RUT_ID)
);

/*==============================================================*/
/* Index: CREA1_FK                                              */
/*==============================================================*/
create index CREA1_FK on RUTINA (
   PER_CEDULA ASC
);

/*==============================================================*/
/* Table: SUSCRIPCION                                           */
/*==============================================================*/
create table SUSCRIPCION 
(
   SUS_NOMBRE           VARCHAR2(20)         not null,
   SUS_PRECIO           FLOAT                not null,
   SUS_DESCRIPCION      VARCHAR2(100),
   constraint PK_SUSCRIPCION primary key (SUS_NOMBRE)
);

/*==============================================================*/
/* Table: TIENE1                                                */
/*==============================================================*/
create table TIENE1 
(
   USU_LOGIN            VARCHAR2(20)         not null,
   RUT_ID               INTEGER              not null,
   constraint PK_TIENE1 primary key (USU_LOGIN, RUT_ID)
);

/*==============================================================*/
/* Index: TIENE1_FK                                             */
/*==============================================================*/
create index TIENE1_FK on TIENE1 (
   USU_LOGIN ASC
);

/*==============================================================*/
/* Index: TIENE7_FK                                             */
/*==============================================================*/
create index TIENE7_FK on TIENE1 (
   RUT_ID ASC
);

/*==============================================================*/
/* Table: TIENE2                                                */
/*==============================================================*/
create table TIENE2 
(
   RUT_ID               INTEGER              not null,
   EJER_CODIGO          INTEGER              not null,
   constraint PK_TIENE2 primary key (RUT_ID, EJER_CODIGO)
);

/*==============================================================*/
/* Index: TIENE5_FK                                             */
/*==============================================================*/
create index TIENE5_FK on TIENE2 (
   RUT_ID ASC
);

/*==============================================================*/
/* Index: TIENE6_FK                                             */
/*==============================================================*/
create index TIENE6_FK on TIENE2 (
   EJER_CODIGO ASC
);

/*==============================================================*/
/* Table: TIENE3                                                */
/*==============================================================*/
create table TIENE3 
(
   SUS_NOMBRE           VARCHAR2(20)         not null,
   ADI_NOMBRE           VARCHAR2(20)         not null,
   constraint PK_TIENE3 primary key (SUS_NOMBRE, ADI_NOMBRE)
);

/*==============================================================*/
/* Index: TIENE3_FK                                             */
/*==============================================================*/
create index TIENE3_FK on TIENE3 (
   SUS_NOMBRE ASC
);

/*==============================================================*/
/* Index: TIENE4_FK                                             */
/*==============================================================*/
create index TIENE4_FK on TIENE3 (
   ADI_NOMBRE ASC
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO 
(
   USU_LOGIN            VARCHAR2(20)         not null,
   EXA_NOMBRE           VARCHAR2(30),
   PER_CEDULA           INTEGER,
   USU_PASSWORD         VARCHAR2(30)         not null,
   USU_CORREO           VARCHAR2(40),
   constraint PK_USUARIO primary key (USU_LOGIN)
);

/*==============================================================*/
/* Index: TIENE2_FK                                             */
/*==============================================================*/
create index TIENE2_FK on USUARIO (
   PER_CEDULA ASC
);

/*==============================================================*/
/* Index: HACE_FK                                               */
/*==============================================================*/
create index HACE_FK on USUARIO (
   EXA_NOMBRE ASC
);

alter table ASESORA
   add constraint FK_ASESORA_ASESORA_ENTRENAD foreign key (PER_CEDULA)
      references ENTRENADOR (PER_CEDULA);

alter table ASESORA
   add constraint FK_ASESORA_ASESORA2_USUARIO foreign key (USU_LOGIN)
      references USUARIO (USU_LOGIN);

alter table ASIGNA
   add constraint FK_ASIGNA_ASIGNA_USUARIO foreign key (USU_LOGIN)
      references USUARIO (USU_LOGIN);

alter table ASIGNA
   add constraint FK_ASIGNA_ASIGNA2_PLANALIM foreign key (PLAN_ID)
      references PLANALIMENTACION (PLAN_ID);

alter table CAPACITA
   add constraint FK_CAPACITA_CAPACITA_ENTRENAD foreign key (PER_CEDULA)
      references ENTRENADOR (PER_CEDULA);

alter table CAPACITA
   add constraint FK_CAPACITA_CAPACITA2_CURSO foreign key (CUR_ID)
      references CURSO (CUR_ID);

alter table CLIENTE
   add constraint FK_CLIENTE_ES_UN_PERSONA foreign key (PER_CEDULA)
      references PERSONA (PER_CEDULA);

alter table CLIENTE
   add constraint FK_CLIENTE_TIENE_USUARIO foreign key (USU_LOGIN)
      references USUARIO (USU_LOGIN);

alter table COMPRA
   add constraint FK_COMPRA_COMPRA_USUARIO foreign key (USU_LOGIN)
      references USUARIO (USU_LOGIN);

alter table COMPRA
   add constraint FK_COMPRA_COMPRA2_SUSCRIPC foreign key (SUS_NOMBRE)
      references SUSCRIPCION (SUS_NOMBRE);

alter table COMPRA1
   add constraint FK_COMPRA1_COMPRA1_USUARIO foreign key (USU_LOGIN)
      references USUARIO (USU_LOGIN);

alter table COMPRA1
   add constraint FK_COMPRA1_COMPRA3_PRODUCTO foreign key (PROD_CODBARRAS)
      references PRODUCTO (PROD_CODBARRAS);

alter table EJERCICIO
   add constraint FK_EJERCICI_USA_MAQUINA foreign key (MAQ_CODIGO)
      references MAQUINA (MAQ_CODIGO);

alter table ENTRENADOR
   add constraint FK_ENTRENAD_ES_UN3_PERSONA foreign key (PER_CEDULA)
      references PERSONA (PER_CEDULA);

alter table NUTRICIONISTA
   add constraint FK_NUTRICIO_CREA_PLANALIM foreign key (PLAN_ID)
      references PLANALIMENTACION (PLAN_ID);

alter table NUTRICIONISTA
   add constraint FK_NUTRICIO_ES_UN2_PERSONA foreign key (PER_CEDULA)
      references PERSONA (PER_CEDULA);

alter table PRODUCTO
   add constraint FK_PRODUCTO_PROVEE_PROVEEDO foreign key (PROVE_NIT)
      references PROVEEDOR (PROVE_NIT);

alter table RUTINA
   add constraint FK_RUTINA_CREA1_ENTRENAD foreign key (PER_CEDULA)
      references ENTRENADOR (PER_CEDULA);

alter table TIENE1
   add constraint FK_TIENE1_TIENE1_USUARIO foreign key (USU_LOGIN)
      references USUARIO (USU_LOGIN);

alter table TIENE1
   add constraint FK_TIENE1_TIENE7_RUTINA foreign key (RUT_ID)
      references RUTINA (RUT_ID);

alter table TIENE2
   add constraint FK_TIENE2_TIENE5_RUTINA foreign key (RUT_ID)
      references RUTINA (RUT_ID);

alter table TIENE2
   add constraint FK_TIENE2_TIENE6_EJERCICI foreign key (EJER_CODIGO)
      references EJERCICIO (EJER_CODIGO);

alter table TIENE3
   add constraint FK_TIENE3_TIENE3_SUSCRIPC foreign key (SUS_NOMBRE)
      references SUSCRIPCION (SUS_NOMBRE);

alter table TIENE3
   add constraint FK_TIENE3_TIENE4_ADICIONA foreign key (ADI_NOMBRE)
      references ADICIONAL (ADI_NOMBRE);

alter table USUARIO
   add constraint FK_USUARIO_HACE_EXAMENME foreign key (EXA_NOMBRE)
      references EXAMENMEDICO (EXA_NOMBRE);

alter table USUARIO
   add constraint FK_USUARIO_TIENE2_CLIENTE foreign key (PER_CEDULA)
      references CLIENTE (PER_CEDULA);
      
alter table CURSO
   add constraint PER_CEDULA_FK foreign key (PER_CEDULA)
   references ENTRENADOR(PER_CEDULA);
INSERT INTO examenmedico (exa_nombre , exa_fecha , exa_descripcion ) VALUES('Examen General', '02/08/2022', 'Examen para valorar estado fisico');
INSERT INTO suscripcion(sus_nombre , sus_precio , sus_descripcion ) values ('Base', 30000, 'Brinda entrada ilimitada al gimnasio');
INSERT INTO suscripcion(sus_nombre , sus_precio , sus_descripcion ) values ('Base2', 45000, 'Brinda entrada ilimitada al gimnasio y entrenador');
INSERT INTO suscripcion(sus_nombre , sus_precio , sus_descripcion ) values ('Base3', 60000, 'Brinda entrada ilimitada al gimnasio, entrnador y alimentacion');

