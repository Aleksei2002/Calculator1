--------- Customers ---------
CUST_ID	  CUST_NAME	      CUST_ADDRESS	       CUST_CITY	 CUST_STATE	  CUST_ZIP	  CUST_COUNTRY	 CUST_CONTACT	        CUST_EMAIL
10000001	Village Toys	  200 Maple Lane	     Detroit	   MI	          44444	      USA	           John Smith	          sales@villagetoys.com
10000003	Fun4All	        1 Sunny Place	       Muncie	     IN	          42222	      USA	           Jim Jones	          jjones@fun4all.com
10000004	Fun4All	        829 Riverside Drive	 Phoenix	   AZ	          88888	      USA	           Denise L. Stephens 	dstephens@fun4all.com
10000005	The Toy Store	  4545 53rd Street	   Chicago	   IL	          54545	      USA	           Kim Howard	          -

--------- Products ---------
PROD_ID	  VEND_ID	  PROD_NAME	            PROD_PRICE	  PROD_DESC
BR01	    BRS01	    8 inch teddy bear	    5.99	        8 inch teddy bear, comes with cap and jacket
BR03	    BRS01	    18 inch teddy bear	  11.99	        18 inch teddy bear, comes with cap and jacket
BNBG01	  DLL01	    Fish bean bag toy	    3.49	        Fish bean bag toy, complete with bean bag worms with which to feed it
BNBG02	  DLL01	    Bird bean bag toy	    3.49	        Bird bean bag toy, eggs are not included
BNBG03	  DLL01	    Rabbit bean bag toy	  3.49	        Rabbit bean bag toy, comes with bean bag carrots
RGAN01	  DLL01	    Raggedy Ann	          4.99	        18 inch Raggedy Ann doll
RYL01	    FNG01	    King doll	            9.49	        12 inch king doll with royal garments and crown
RYL02	    FNG01	    Queen doll	          9.49	        12 inch queen doll with royal garments and crown
BR02	    BRS01	    12 inch teddy bear	  8.99	        12 inch teddy bear, comes with cap and jacket

--------- Product Items ---------
ORDER_NUM   ORDER_ITEM  PROD_ID   QUANTITY  ITEM_PRICE
20005       1,          BR01      100       5.49
20005       2,          BR03      100       10.99
20006       1,          BR01      20        5.99
20006       2,          BR02      10        8.99
20006       3,          BR03      10        11.99
20007       1,          BR03      50        11.49
20007       2,          BNBG01    100       2.99
20007       3,          BNBG02    100       2.99
20007       4,          BNBG03    100       2.99
20007       5,          RGAN01    50        4.49
20008       1,          RGAN01    5         4.99
20008       2,          BR03      5         11.99
20008       3,          BNBG01    10        3.49
20008       4,          BNBG02    10        3.49
20008       5,          BNBG03    10        3.49
20009       1,          BNBG01    250       2.49
20009       2,          BNBG02    250       2.49
20009       3,          BNBG03    250       2.49

--------- Orders ---------
ORDER_NUM	 ORDER_DATE	 CUST_ID
20007	     01/30/2020	 100000004
20008	     02/03/2020	 100000005
20005    	 05/01/2020	 100000001
20006	     01/12/2020	 100000003
20009	     02/08/2020	 100000001

--------- Orders ---------
ORDER_NUM	  ORDER_ITEM	 PROD_ID	 QUANTITY	  ITEM_PRICE
20005	      1	           BR01	     100	      5.49
20005	      2	           BR03	     100	      10.99
20006	      1	           BR01	     20	        5.99
20006	      2	           BR02	     10	        8.99
20006	      3	           BR03	     10	        11.99
20007	      1	           BR03	     50	        11.49
20007	      2	           BNBG01	   100	      2.99
20007	      3	           BNBG02	   100	      2.99
20007	      4	           BNBG03	   100	      2.99
20007	      5	           RGAN01	   50	        4.49

--------- Команды ---------
--------- 1 zadanie ---------
SELECT prod_name, prod_price, prod_desc FROM Products

--- ОТВЕТ ---
PROD_NAME             PROD_PRICE     PROD_DESC
8 inch teddy bear	    5.99	         8 inch teddy bear, comes with cap and jacket
18 inch teddy bear	  11.99	         18 inch teddy bear, comes with cap and jacket
Fish bean bag toy	    3.49	         Fish bean bag toy, complete with bean bag worms with which to feed it
Bird bean bag toy	    3.49	         Bird bean bag toy, eggs are not included
Rabbit bean bag toy	  3.49	         Rabbit bean bag toy, comes with bean bag carrots
Raggedy Ann	          4.99	         18 inch Raggedy Ann doll
King doll	            9.49	         12 inch king doll with royal garments and crown
Queen doll	          9.49	         12 inch queen doll with royal garments and crown
12 inch teddy bear	  8.99	         12 inch teddy bear, comes with cap and jacket

--------- 2 zadanie ---------
SELECT vend_name FROM Vendors

--- ОТВЕТ ---
VEND_NAME
Bear Emporium
Doll House Inc.
Furball Inc.
Fun and Games
Jouets et ours
Bears R Us

--------- 3 zadanie ---------
SELECT cust_contact FROM Customers

--- ОТВЕТ ---
CUST_CONTACT
John Smith
Jim Jones
Denise L. Stephens
Kim Howard

--------- 4 zadanie ---------
SELECT VEND_NAME
FROM Vendors
WHERE VEND_ID = (SELECT VEND_ID FROM Products WHERE PROD_NAME = 'King doll');
--- ОТВЕТ ---
VEND_ID
FNG01

--------- 5 zadanie ---------
SELECT cust_contact FROM Customers
JOIN Products
ON Customers.cust_contact = Products.prod_name
WHERE Prod_name = 'Queen doll';

--- ОТВЕТ ---

--------- 6 zadanie ---------
SELECT PROD_NAME
FROM Products
WHERE PROD_PRICE = (SELECT MIN(PROD_PRICE) FROM Products);

--- ОТВЕТ ---
PROD_NAME
Rabbit bean bag toy   3.49
Bird bean bag toy     3.49
Fish bean bag toy     3.49

--------- 7 zadanie ---------
SELECT PROD_NAME
FROM Products
WHERE PROD_PRICE = (SELECT MIN(PROD_PRICE) FROM Products);

--- ОТВЕТ ---
PROD_NAME
18 inch teddy bear    11.99

--------- 8 zadanie ---------
SELECT COUNT(*) AS prod_name FROM Products;

--- ОТВЕТ ---
PROD_NAME
9

--------- 9 zadanie ---------
SELECT COUNT(*) AS vend_name FROM Vendors;

--- ОТВЕТ ---
VEND_NAME
6

--------- 10 zadanie ---------
SELECT COUNT(CUST_ID)
FROM Customers
WHERE CUST_EMAIL IS NOT NULL;

--- ОТВЕТ ---
COUNT(CUST_ID)
3

--------- 11 zadanie ---------

--- ОТВЕТ ---

--------- 12 zadanie ---------

--- ОТВЕТ ---