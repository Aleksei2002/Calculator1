----------------------------
-- Populate OrderItems table
----------------------------
INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20005, 1, 'BR01', 100, 5.49);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20005, 2, 'BR03', 100, 10.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20006, 1, 'BR01', 20, 5.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20006, 2, 'BR02', 10, 8.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20006, 3, 'BR03', 10, 11.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20007, 1, 'BR03', 50, 11.49);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20007, 2, 'BNBG01', 100, 2.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20007, 3, 'BNBG02', 100, 2.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20007, 4, 'BNBG03', 100, 2.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20007, 5, 'RGAN01', 50, 4.49);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20008, 1, 'RGAN01', 5, 4.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20008, 2, 'BR03', 5, 11.99);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20008, 3, 'BNBG01', 10, 3.49);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20008, 4, 'BNBG02', 10, 3.49);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20008, 5, 'BNBG03', 10, 3.49);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20009, 1, 'BNBG01', 250, 2.49);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20009, 2, 'BNBG02', 250, 2.49);

INSERT INTO OrderItems(order_num, order_item, prod_id, quantity, item_price)
VALUES(20009, 3, 'BNBG03', 250, 2.49);


------------------------
-- Populate Orders table
------------------------
INSERT INTO Orders(order_num, order_date, cust_id)
VALUES(20005, TO_DATE('2020-05-01', 'yyyy-mm-dd'), '1000000001');

INSERT INTO Orders(order_num, order_date, cust_id)
VALUES(20006, TO_DATE('2020-01-12', 'yyyy-mm-dd'), '1000000003');

INSERT INTO Orders(order_num, order_date, cust_id)
VALUES(20007, TO_DATE('2020-01-30', 'yyyy-mm-dd'), '1000000004');

INSERT INTO Orders(order_num, order_date, cust_id)
VALUES(20008, TO_DATE('2020-02-03', 'yyyy-mm-dd'), '1000000005');

INSERT INTO Orders(order_num, order_date, cust_id)
VALUES(20009, TO_DATE('2020-02-08', 'yyyy-mm-dd'), '1000000001');


--------- Команды ---------
--------- 1 zadanie ---------
SELECT order_num, order_date FROM Orders

--- ОТВЕТ ---
ORDER_NUM	 ORDER_DATE
20007	     01/30/2020
20008	     02/03/2020
20005	     05/01/2020
20006	     01/12/2020
20009	     02/08/2020

--------- 2 zadanie ---------
SELECT cust_id, cust_contact FROM Customers
WHERE cust_id LIKE '10000003';

--- ОТВЕТ ---
CUST_ID	  CUST_CONTACT
10000003	Jim Jones

--------- 3 zadanie ---------
SELECT * FROM Products
WHERE vend_id = 'DLL01';

--- ОТВЕТ ---
PROD_ID	VEND_ID	PROD_NAME	            PROD_PRICE	PROD_DESC
BNBG01	DLL01	  Fish bean bag toy	    3.49	      Fish bean bag toy, complete with bean bag worms with which to feed it
BNBG02	DLL01	  Bird bean bag toy	    3.49	      Bird bean bag toy, eggs are not included
BNBG03	DLL01	  Rabbit bean bag toy	  3.49	      Rabbit bean bag toy, comes with bean bag carrots
RGAN01	DLL01	  Raggedy Ann	          4.99	      18 inch Raggedy Ann doll

--------- 4 zadanie ---------
SELECT cust_id, cust_name, cust_contact, cust_email FROM Customers

--- ОТВЕТ ---
CUST_ID	  CUST_NAME	      CUST_CONTACT	      CUST_EMAIL
10000001	Village Toys	  John Smith	        sales@villagetoys.com
10000003	Fun4All	        Jim Jones	          jjones@fun4all.com
10000004	Fun4All	        Denise L. Stephens	dstephens@fun4all.com
10000005	The Toy Store	  Kim Howard	        -

--------- 5 zadanie ---------
SELECT cust_contact, cust_id, cust_name FROM Customers
ORDER BY cust_contact;

--- ОТВЕТ ---
CUST_CONTACT	      CUST_ID	  CUST_NAME
Denise L. Stephens	10000004	Fun4All
Jim Jones	          10000003	Fun4All
John Smith	        10000001	Village Toys
Kim Howard	        10000005	The Toy Store

--------- 6 zadanie ---------
SELECT prod_price FROM Products
WHERE prod_price < 5.00;

--- ОТВЕТ ---
PROD_PRICE
3.49
3.49
3.49
4.99

--------- 7 zadanie ---------
SELECT * FROM Customers
WHERE cust_name BETWEEN 'A%' AND 'J%';

--- ОТВЕТ ---
CUST_ID	  CUST_NAME	 CUST_ADDRESS	        CUST_CITY	  CUST_STATE	CUST_ZIP	CUST_COUNTRY	CUST_CONTACT	CUST_EMAIL
10000003	Fun4All	   1 Sunny Place	      Muncie	    IN	        42222	    USA	          Jim Jones	    jjones@fun4all.com
10000004	Fun4All	   829 Riverside Drive	Phoenix	    AZ	        88888	    USA	          Denise L.     Stephens	dstephens@fun4all.com

--------- 8 zadanie ---------
SELECT * FROM Customers
WHERE cust_contact LIKE 'J%';

--- ОТВЕТ ---
CUST_ID	  CUST_NAME	    CUST_ADDRESS	  CUST_CITY	  CUST_STATE	CUST_ZIP	CUST_COUNTRY	CUST_CONTACT	CUST_EMAIL
10000001	Village Toys	200 Maple Lane	Detroit	    MI	        44444	    USA	          John Smith	  sales@villagetoys.com
10000003	Fun4All	      1 Sunny Place	  Muncie	    IN	        42222	    USA	          Jim Jones	    jjones@fun4all.com

--------- 9 zadanie ---------
SELECT * FROM Orders
WHERE order_date = '01/30/2020';

--- ОТВЕТ ---
ORDER_NUM	 ORDER_DATE	 CUST_ID
20007	     01/30/2020	 100000004


--------- 11 zadanie ---------
