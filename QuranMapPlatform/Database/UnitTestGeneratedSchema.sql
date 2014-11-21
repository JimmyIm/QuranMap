
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKCE3593D87EC322F5]') AND parent_object_id = OBJECT_ID('Facts'))
alter table Facts  drop constraint FKCE3593D87EC322F5


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK1123795E1651D1F]') AND parent_object_id = OBJECT_ID('DimensionAssociations'))
alter table DimensionAssociations  drop constraint FK1123795E1651D1F


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK1123795B39BDB67]') AND parent_object_id = OBJECT_ID('DimensionAssociations'))
alter table DimensionAssociations  drop constraint FK1123795B39BDB67


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK11237957EC322F5]') AND parent_object_id = OBJECT_ID('DimensionAssociations'))
alter table DimensionAssociations  drop constraint FK11237957EC322F5


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2F0EC5F27D7D8E1]') AND parent_object_id = OBJECT_ID('FactAssociations'))
alter table FactAssociations  drop constraint FK2F0EC5F27D7D8E1


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2F0EC5F255291E99]') AND parent_object_id = OBJECT_ID('FactAssociations'))
alter table FactAssociations  drop constraint FK2F0EC5F255291E99


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2F0EC5F29E6DBACA]') AND parent_object_id = OBJECT_ID('FactAssociations'))
alter table FactAssociations  drop constraint FK2F0EC5F29E6DBACA


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2F0EC5F2C48D399D]') AND parent_object_id = OBJECT_ID('FactAssociations'))
alter table FactAssociations  drop constraint FK2F0EC5F2C48D399D


    if exists (select * from dbo.sysobjects where id = object_id(N'Facts') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Facts

    if exists (select * from dbo.sysobjects where id = object_id(N'Dimensions') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Dimensions

    if exists (select * from dbo.sysobjects where id = object_id(N'DimensionAssociations') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table DimensionAssociations

    if exists (select * from dbo.sysobjects where id = object_id(N'FactAssociations') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table FactAssociations

    if exists (select * from dbo.sysobjects where id = object_id(N'ValueTypes') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table ValueTypes

    if exists (select * from dbo.sysobjects where id = object_id(N'MyEntity1s') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table MyEntity1s

    if exists (select * from dbo.sysobjects where id = object_id(N'hibernate_unique_key') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table hibernate_unique_key

    create table Facts (
        FactId INT not null,
       Name NVARCHAR(255) null,
       Value NVARCHAR(255) null,
       DimensionId INT null,
       primary key (FactId)
    )

    create table Dimensions (
        DimensionId INT not null,
       Name NVARCHAR(255) null,
       primary key (DimensionId)
    )

    create table DimensionAssociations (
        DimensionAssociationId INT not null,
       Name NVARCHAR(255) null,
       SourceId INT null,
       TargetId INT null,
       DimensionId INT null,
       primary key (DimensionAssociationId)
    )

    create table FactAssociations (
        FactAssociationId INT not null,
       Name NVARCHAR(255) null,
       SourceId INT null,
       TargetId INT null,
       RelationTypeId INT null,
       FactId INT null,
       primary key (FactAssociationId)
    )

    create table ValueTypes (
        ValueTypeId INT not null,
       Name NVARCHAR(255) null,
       primary key (ValueTypeId)
    )

    create table MyEntity1s (
        MyEntity1Id INT not null,
       primary key (MyEntity1Id)
    )

    alter table Facts 
        add constraint FKCE3593D87EC322F5 
        foreign key (DimensionId) 
        references Dimensions

    alter table DimensionAssociations 
        add constraint FK1123795E1651D1F 
        foreign key (SourceId) 
        references Dimensions

    alter table DimensionAssociations 
        add constraint FK1123795B39BDB67 
        foreign key (TargetId) 
        references Dimensions

    alter table DimensionAssociations 
        add constraint FK11237957EC322F5 
        foreign key (DimensionId) 
        references Dimensions

    alter table FactAssociations 
        add constraint FK2F0EC5F27D7D8E1 
        foreign key (SourceId) 
        references Facts

    alter table FactAssociations 
        add constraint FK2F0EC5F255291E99 
        foreign key (TargetId) 
        references Facts

    alter table FactAssociations 
        add constraint FK2F0EC5F29E6DBACA 
        foreign key (RelationTypeId) 
        references DimensionAssociations

    alter table FactAssociations 
        add constraint FK2F0EC5F2C48D399D 
        foreign key (FactId) 
        references Facts

    create table hibernate_unique_key (
         next_hi INT 
    )

    insert into hibernate_unique_key values ( 1 )
