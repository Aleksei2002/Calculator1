CREATE TABLE Products{
  prod id CHAR(10) not NULL,
  vend id CHAR(10) not NULL,
  prod_name CHAR(254) NOT NULL,
  prod_price DECIMAL(8,2) NOT NULL,
  prod_desc VARCHAR(1000) NULL
}

ALTER TABLE Products ADD CONSTRAINT PK_Products PRIMARY KEY (prod_id);

ALTER TABLE Vendors ADD CONSTRAINT PK_Vendors PRIMARY KEY (vend_id);

CREATE TABLE Vednors(
    vend_id      char(10) NOT NULL ,
    vend_name    char(50) NOT NULL ,
    vend_address char(50) NULL ,
    vend_city    char(50) NULL ,
    vend_state   char(5) NULL ,
    vend_zip     char(10) NULL ,
    vend_country char(50) NULL
);

ALTER TABLE Products
ADD CONSTRAINT FK_Products_Vendors FOREIGN KEY (vend_id)
REFERENCES Vendors (vend_id);