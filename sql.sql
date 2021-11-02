CREATE TABLE [dbo].[Category] (
    [Id]       INT           NOT NULL,
    [Category] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO Category (Category) VALUES ('Сereals')
INSERT INTO Category (Category) VALUES ('Bakery')
INSERT INTO Category (Category) VALUES ('Milk')

CREATE TABLE [dbo].[Product] (
    [Id]      INT           NOT NULL,
    [Product] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO Product (Product, CategoryId) VALUES ('Milk', 3)
INSERT INTO Product (Product, CategoryId) VALUES ('Bread', 2)
INSERT INTO Product (Product, CategoryId) VALUES ('Rice', 1)
INSERT INTO Product (Product, CategoryId) VALUES ('Buckwheat', 1)
INSERT INTO Product (Product) VALUES ('Pear')
