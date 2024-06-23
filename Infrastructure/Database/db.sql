CREATE DATABASE ecommerceDB;

CREATE TABLE IF NOT EXISTS Users (
    Id SERIAL PRIMARY KEY,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(255),
    Password VARCHAR(255),
    Cpf VARCHAR(14),
    Phone VARCHAR(20),
    Active BOOLEAN
    CreatedAt DATE,
    UodatedAt DATE
);

CREATE TABLE IF NOT EXISTS UserAddress (
    Id SERIAL PRIMARY KEY,
    Address VARCHAR(255),
    District VARCHAR(100),
    Number int,
    Cep VARCHAR(9) NOT NULL,
    City VARCHAR(255),
    Uf VARCHAR(2),
    Complement VARCHAR(255),
    UserId int not null,
    CreatedAt DATE,
    UodatedAt DATE
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

