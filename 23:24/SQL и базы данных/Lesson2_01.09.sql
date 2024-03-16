CREATE TABLE Customers(
  cust_id       CHAR(8) NOT NULL,
  cust_name     CHAR(50) NOT NULL,
  cust_address  CHAR(100) NULL,
  cust_city     CHAR(50) NULL,
  cust_state    CHAR(10) NULL,
  cust_ZIP      CHAR(10) NULL,
  cust_country  CHAR(50) NULL,
  cust_contact  CHAR(50) NULL,
  cust_email    CHAR(50) NULL
);

----------------------------------------------------------------

ALTER TABLE Customers ADD CONSTRAINT PK_Customers PRIMARY KEY (cust_id);

----------------------------------------------------------------

CREATE TABLE Orders{
  order_num   int NOT NULL,
  order_date  date NOT NULL,
  cust_id     CHAR(10) NOT NULL
};

----------------------------------------------------------------

ALTER TABLE Orders ADD CONSTRAINT PK_Orders PRIMARY KEY (order_num);

----------------------------------------------------------------

ALTER TABLE Orders ADD CONSTRAINT FK_Orders_Customers FOREIGN KEY (cust_id) references Customers (cust_id);

----------------------------------------------------------------

CREATE TABLE OrderItems(
  order_num   int not null,
  order_item  int not null, 
  prod_id     char(10) not null,
  quantity    int      not null,
  item_price  decimal(8,2) not null
);

----------------------------------------------------------------

ALTER TABLE OrderItems ADD CONSTRAINT PK_OrderItems PRIMARY KEY (order_num, order_item);

----------------------------------------------------------------

ALTER TABLE OrderItems ADD CONSTRAINT FK_OrderItems_Orders FOREIGN KEY (order_num) REFERENCES Orders (order_num);

----------------------------------------------------------------

ALTER TABLE OrderItems ADD CONSTRAINT FK_OrderItems_Products FOREIGN KEY (prod_id) REFERENCES Products (prod_id);

----------------------------------------------------------------

INSERT INTO Orders(order_num, order_date, cust_id) VALUE(20005, TO_DATE('2020-05-01', 'yyyy-mm-dd'), '1000000001');

----------------------------------------------------------------

INSERT INTO Customers(cust_id, cust_name, cust_address, cust_state,
cust_zip, cust_country, cust_contact, cust_email)
VALUES('1000000001', 'Village Toys', '200 Maple Lane', 'Detroit', 'MI', '44444', 'USA',
'John Smith', 'sales@villagetoys.com');