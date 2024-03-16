SELECT vend_name ||'('|| vend_country||')'
FROM Vendors
ORDER BY vend_name;

SELECT RTRIM(vend_name) ||'('|| RTRIM(vend_country)||')' AS vend_title
FROM Vendors
ORDER BY vend_name;

SELECT vend_name + '('+ vend_country +')'
FROM Vendors
ORDER BY vend_name;

/*
  Выражение SELECT возвращвет один столбец 
  (вычисляемое поле), содерж. все четыре 
  элемента как одно целое
*/

SELECT prod_id, quantity, item_price FROM OrderItems
WHERE order_num = 20008;

SELECT prod_id, quantity, item_price, 
quantity * item_price AS expanded_price /* количество продукта * цена товара */
FROM OrderItems
WHERE order_num = 20008;

/*AS - переименование таблицы под себя*/

SELECT vend_name, UPPER(vend_name) AS vend_name_upcase /* UPPER */
FROM Vendors
ORDER BY vend_name;

--- ОТВЕТ ---
vend_name	          vend_name_upcase
Denise L. Stephens	DENISE L. STEPHENS
Jim Jones	          JIM JONES
John Smith	       	JOHN Smith

SELECT cust_name, cust_contact FROM customers
WHERE soundex(cust_contact) = soundex('Michael Green')

SELECT * FROM orders
WHERE to_number(to_char(order_date,'MM'))=2

--- ОТВЕТ Все заказы, которые были сделаны в Марте ---
ORDER_NUM	  ORDER_DATE	 CUST_ID
20008	      02/03/2020	 100000005
20009	      02/08/2020	 100000001

SELECT AVG(prod_price) AS avg_price FROM Products
WHERE vend_id = 'DLL01'; 
/* Вычисляет среднюю стоимость товаров с таблицы */

SELECT COUNT(*) AS num_cust FROM Customers;
/* COUNT(*) - Подсчет всех строк */

SELECT COUNT(*) AS num_cust FROM Customers;
SELECT MAX(*) AS prod_price FROM Products;
SELECT MIN(*) AS prod_price FROM Products;

SELECT SUM(quantity) AS item_ordered FROM OrderItems
WHERE order_num = 20008;

SELECT SUM(item_price * quantity) AS total_price FROM OrderItems
WHERE order_num = 20008;

SELECT COUNT(*) AS num_items,
MIN(prod_price) AS price_min,
MAX(prod_price) AS price_max,
AVG(prod_price) AS price_avg
FROM Products;

--- ОТВЕТ ---
NUM_ITEMS	 PRICE_MIN	PRICE_MAX	 PRICE_AVG
9	         3.49	      11.99	     6.82333333333333333333333333333333333333

SELECT cust_id, COUNT(*) AS orders FROM Orders;
GROUP BY cust_id, COUNT
HAVING COUNT(*) >=2;