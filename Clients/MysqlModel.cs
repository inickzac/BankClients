using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Clients
{
    class MysqlModel
    {

        string connectionString = ConfigurationManager.ConnectionStrings["mySqlConnection"].ConnectionString;

        public MysqlModel()
        {
            InitDateBase();

        }
   
      public void ExecuteSqlNonQuery(string sql)
       {
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            var command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void ExecuteSqlWithQuery(string sql, Action<MySqlDataReader> elector)
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            var command = new MySqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            elector(reader);
            connection.Close();
        }

        private void InitDateBase()
        {
            ExecuteSqlNonQuery(CreateTables);

        }


        string CreateTables = @"drop database if exists clients;
            create database if not exists clients;
            use clients;


            create table city(
            id int primary key not null auto_increment,
            name varchar(30) not null
            );

            create table family_position(
            id int primary key not null auto_increment,
            name varchar(30) not null
            );

            create table citizenship(
            id int primary key not null auto_increment,
            name varchar(30) not null
            );

            create table disability(
            id int primary key not null auto_increment,
            name varchar(30) not null
            );

            create table client(
            id int not null primary key auto_increment,
            name varchar(30) not null,
            lastname varchar(30) not null,
            patronymic varchar(30) not null,
            date_of_birth date not null,
            gender int not null,
            passport_series varchar(10) not null,
            passport_number varchar(30) not null,
            place_of_birth varchar(30) not null,
            city_fact_residence_id int not null,
            adress_fact_residence varchar(30) not null,
            home_phone varchar(30) not null,
            mobile_phone varchar(30) not null,
            e_mail  varchar(30),
            place_of_work varchar(30),
            position varchar(30),
            city_of_registration_id int not null,
            place_of_residence varchar(30) not null,
            family_position_id int not null,
            citizenship_id int not null,
            disability_id int not null,
            pensioner int not null,
            monthly_income decimal,
            liable_for_military int not null,
            foreign key(city_fact_residence_id) references city(id),
            foreign key(city_of_registration_id) references city(id),
            foreign key(family_position_id) references family_position(id),
            foreign key(citizenship_id) references citizenship(id),
            foreign key(disability_id) references disability(id)
            )";

    string AddCities= @"insert into city (name) values ('Москва');
           insert into city (name) values ('Минск');
           insert into city (name) values ('Лондон');
           insert into city (name) values ('Берлин');
           insert into city (name) values ('Мадрид');";

    string AddFamilyPosition = @"insert into family_position (name) values ('Холост');
           insert into family_position (name) values ('Женат');";

    }
}
