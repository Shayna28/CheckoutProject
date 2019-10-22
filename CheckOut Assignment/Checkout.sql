USE Checkout

CREATE TABLE Users (
UserId INT NOT NULL
,UserName VARCHAR(30) NOT NULL
,UserPassword VARCHAR(30) NOT NULL
,PRIMARY KEY (UserId)
)

INSERT INTO Users (UserId,UserName,UserPassword)
VALUES (1,'User1','Password1'),
(2,'User2','Password2')

select * from Users


CREATE TABLE Orders (
OrderId INT NOT NULL
,Amount VARCHAR(30) NOT NULL
,CardNumber VARCHAR(30) NOT NULL
,ExpiryDate Date
,CVV INT NOT NULL
,PRIMARY KEY (OrderId)
)

--Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Checkout;Integrated Security=True

select * from Orders