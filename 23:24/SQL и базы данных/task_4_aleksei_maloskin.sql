Customers
CUST_ID	  CUST_NAME	    CUST_ADDRESS	      CUST_CITY	  CUST_STATE	  CUST_ZIP	  CUST_COUNTRY	  CUST_CONTACT	      CUST_EMAIL
10000001	Village Toys	200 Maple Lane	    Detroit	    MI	          44444	      USA	            John Smith	        sales@villagetoys.com
10000003	Fun4All	      1 Sunny Place	      Muncie	    IN	          42222	      USA	            Jim Jones	          jjones@fun4all.com
10000004	Fun4All	      829 Riverside Drive	Phoenix	    AZ	          88888	      USA	            Denise L. Stephens	dstephens@fun4all.com
10000005	The Toy Store	4545 53rd Street	  Chicago	    IL	          54545	      USA	            Kim Howard	        -

Orders
ORDER_NUM	 ORDER_DATE	  CUST_ID
20007	     01/30/2020	  100000004
20008	     02/03/2020	  100000005
20005	     05/01/2020	  100000001
20006	     01/12/2020	  100000003
20009	     02/08/2020	  100000001

Orderitems
ORDER_NUM	  ORDER_ITEM	  PROD_ID	  QUANTITY	  ITEM_PRICE
20005	      1	            BR01	    100	        5.49
20005	      2	            BR03	    100	        10.99
20006	      1	            BR01	    20	        5.99
20006	      2	            BR02	    10	        8.99
20006	      3	            BR03	    10	        11.99
20007	      1	            BR03	    50	        11.49
20007	      2	            BNBG01	  100	        2.99
20007	      3	            BNBG02	  100	        2.99
20007	      4	            BNBG03	  100	        2.99
20007	      5	            RGAN01	  50	        4.49
20008	      1	            RGAN01	  5	          4.99
20008	      2	            BR03	    5	          11.99
20008	      3	            BNBG01	  10	        3.49
20008	      4	            BNBG02	  10	        3.49
20008	      5	            BNBG03	  10	        3.49
20009	      1	            BNBG01	  250	        2.49
20009	      2	            BNBG02	  250	        2.49
20009	      3	            BNBG03	  250	        2.49

Product 
PROD_ID	  VEND_ID	  PROD_NAME 	        PROD_PRICE	  PROD_DESC
BR01	    BRS01	    8 inch teddy bear	  5.99	        8 inch teddy bear, comes with cap and jacket
BR03	    BRS01	    18 inch teddy bear	11.99	        18 inch teddy bear, comes with cap and jacket
BNBG01	  DLL01	    Fish bean bag toy	  3.49	        Fish bean bag toy, complete with bean bag worms with which to feed it
BNBG02	  DLL01	    Bird bean bag toy	  3.49	        Bird bean bag toy, eggs are not included
BNBG03	  DLL01	    Rabbit bean bag toy	3.49	        Rabbit bean bag toy, comes with bean bag carrots
RGAN01	  DLL01	    Raggedy Ann	        4.99	        18 inch Raggedy Ann doll
RYL01	    FNG01	    King doll	          9.49	        12 inch king doll with royal garments and crown
RYL02	    FNG01	    Queen doll	        9.49	        12 inch queen doll with royal garments and crown
BR02	    BRS01	    12 inch teddy bear	8.99	        12 inch teddy bear, comes with cap and jacket

Vendors 
VEND_ID	  VEND_NAME 	    VEND_ADDRESS	  VEND_CITY 	VEND_STATE	VEND_ZIP	 VEND_COUNTRY
BRE02	    Bear Emporium	  500 Park Street	Anytown	    OH	        44333	     USA
DLL01   	Doll House Inc.	555 High Street	Dollsville	CA	        99999	     USA
FRB01	    Furball Inc.	  1000 5th Avenue	New York	  NY	        11111	     USA
FNG01	    Fun and Games	  42 Galaxy Road	London	    -	          N16 6PS	   England
JTS01	    Jouets et ours	1 Rue Amusement	Paris	      -	          45678	     France
BRS01	    Bears R Us	    123 Main Street	Bear Town 	MI	        44444	     USA


1. Кто поставляет King doll?
2. Кто заказал Queen doll?
3. Какой товар самый дешёвый?
4. Какой товар самый дорогой?
5. Показать без повторений все товары, которые когда-либо были заказаны.
6. Узнать, какие товары не были ни разу заказаны.
7. Узнать, товары каких поставщиков заказывал клиент Village Toys?
8. Узнать, кто из клиентов не делал заказов.
9. Узнать, товары какого поставщика чаще всего заказывают.
10. Показать, на какую сумму сделал заказы каждый из клиентов.
11. Узнать, у кого из клиентов самое большое число заказов.
12. Добавить нового клиента.
13. Переименовать клиента Fun4All с адресом 829 Riverside Drive в клиента
All4Fun с тем же адресом.
Какие еще изменения необходимо внести в базу данных?
14. Удалить из базы данных клиента Fun4All. Обеспечить ссылочную
целостность базы данных.


--------- 1 zadanie ---------
SELECT VEND_NAME
FROM VENDORS
WHERE VEND_ID = (
    SELECT VEND_ID
    FROM PRODUCTS
    WHERE PROD_NAME = 'King doll'
);

--- ОТВЕТ ---
VEND_NAME:
Fun and Games

--------- 2 zadanie ---------
SELECT cust_name
FROM Customers
WHERE cust_id = (
    SELECT cust_id
    FROM Orders
    WHERE order_num = (
        SELECT order_num
        FROM Orderitems
        WHERE prod_id = 'RYL02'
    )
);

--- ОТВЕТ ---
no data found

--------- 3 zadanie ---------
SELECT PROD_NAME, PROD_PRICE
FROM PRODUCTS
WHERE PROD_PRICE = (
    SELECT MIN(PROD_PRICE)
    FROM PRODUCTS
);

--- ОТВЕТ ---
PROD_NAME	          PROD_PRICE
Fish bean bag toy	  3.49
Bird bean bag toy	  3.49
Rabbit bean bag toy	  3.49

--------- 4 zadanie ---------
SELECT PROD_NAME, PROD_PRICE
FROM PRODUCTS
WHERE PROD_PRICE = (
    SELECT MAX(PROD_PRICE)
    FROM PRODUCTS
);

--- ОТВЕТ ---
PROD_NAME	          PROD_PRICE
18 inch teddy bear	  11.99

--------- 5 zadanie ---------
SELECT DISTINCT prod_id FROM Orderitems;

--- ОТВЕТ ---
PROD_ID:
BR03
RGAN01
BR02
BNBG03
BR01
BNBG02
BNBG01

--------- 6 zadanie ---------
SELECT PROD_NAME
FROM PRODUCTS
WHERE PROD_ID NOT IN (
    SELECT DISTINCT PROD_ID
    FROM ORDERITEMS
);

--- ОТВЕТ ---
PROD_NAME:
King doll
Queen doll

--------- 7 zadanie ---------
SELECT DISTINCT P.PROD_NAME, V.VEND_NAME
FROM CUSTOMERS C
JOIN ORDERS O ON C.CUST_ID = O.CUST_ID
JOIN ORDERITEMS OI ON O.ORDER_NUM = OI.ORDER_NUM
JOIN PRODUCTS P ON OI.PROD_ID = P.PROD_ID
JOIN VENDORS V ON P.VEND_ID = V.VEND_ID
WHERE C.CUST_NAME = 'Village Toys';

--- ОТВЕТ ---
no data found

--------- 8 zadanie ---------
SELECT cust_name FROM Customers
WHERE cust_id NOT IN (SELECT DISTINCT cust_id FROM Orders);

--- ОТВЕТ ---
CUST_NAME:
Village Toys
Fun4All
Fun4All
The Toy Store

--------- 9 zadanie ---------
SELECT V.VEND_NAME
FROM VENDORS V
JOIN PRODUCTS P ON V.VEND_ID = P.VEND_ID
WHERE P.PROD_ID = (
    SELECT OI.PROD_ID
    FROM ORDERITEMS OI
    GROUP BY OI.PROD_ID
    HAVING COUNT(*) = (
        SELECT MAX(COUNT(*))
        FROM ORDERITEMS
        GROUP BY PROD_ID
    )
);

--- ОТВЕТ ---
VEND_NAME:
Bears R Us

--------- 10 zadanie ---------
SELECT cust_id, SUM(QUANTITY * ITEM_PRICE) AS total_spent
FROM Orders
JOIN Orderitems ON Orders.order_num = Orderitems.order_num
GROUP BY cust_id;

--- ОТВЕТ ---
CUST_ID	    TOTAL_SPENT
100000003	  329.6
100000004	  1696
100000005	  189.6
100000001	  3515.5

--------- 11 zadanie ---------
SELECT C.CUST_NAME
FROM CUSTOMERS C
JOIN ORDERS O ON C.CUST_ID = O.CUST_ID
GROUP BY C.CUST_NAME
HAVING COUNT(*) = (
    SELECT MAX(COUNT(*))
    FROM ORDERS
    GROUP BY CUST_ID
);

--- ОТВЕТ ---
no data found

--------- 12 zadanie ---------
INSERT INTO CUSTOMERS (CUST_ID, CUST_NAME, CUST_ADDRESS, CUST_CITY, CUST_STATE, CUST_ZIP, CUST_COUNTRY, CUST_CONTACT, CUST_EMAIL)
VALUES (10000009, 'ToyStore', '20 Santa Barbara', 'Los Angeles', 'CA', 48392, 'USA', 'Jack Farlem', 'farlem.j@gmail.com');

--- ОТВЕТ ---
1 row(s) inserted.

--------- 13 zadanie ---------
UPDATE Customers
SET cust_name = 'All4Fun'
WHERE cust_name = 'Fun4All' AND cust_address = '829 Riverside Drive';

--- ОТВЕТ ---
1 row(s) updated.

--------- 14 zadanie ---------
DELETE FROM Customers WHERE cust_name = 'Fun4All';

--- ОТВЕТ ---
1 row(s) deleted.