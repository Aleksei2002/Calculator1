-- Aleksei Malõškin Variant "C" -- 

--СОЗДАЕМ ТАБЛИЦЫ--
CREATE TABLE kind_burner (
  kind_id INT NOT NULL,
  kind_name VARCHAR(20) NOT NULL,
  PRIMARY KEY (kind_id)
);


CREATE TABLE burner (
  burn_sn VARCHAR(16) NOT NULL,
  kind_id INT NOT NULL,
  burn_ver VARCHAR(5) NOT NULL,
  burn_date_prod DATE NOT NULL,
  PRIMARY KEY (burn_sn),
  FOREIGN KEY (kind_id) REFERENCES kind_burner (kind_id)
);


CREATE TABLE customer (
  cust_id INT NOT NULL,
  cust_name VARCHAR(40) NOT NULL,
  cust_tell VARCHAR(12) NOT NULL,
  cust_email VARCHAR(40),
  PRIMARY KEY (cust_id)
);

CREATE TABLE registration (
  cust_id INT NOT NULL,
  burn_sn VARCHAR(16) NOT NULL,
  reg_data DATE NOT NULL,
  PRIMARY KEY (cust_id, burn_sn),
  FOREIGN KEY (burn_sn) REFERENCES burner (burn_sn),
  FOREIGN KEY (cust_id) REFERENCES customer (cust_id)
);


CREATE TABLE repair (
  invoice_id VARCHAR(20) NOT NULL,
  burn_sn VARCHAR(16) NOT NULL,
  cust_id INT NOT NULL,
  rep_date DATE NOT NULL,
  rep_desc VARCHAR(256) NOT NULL,
  rep_cost DECIMAL(6,2) NOT NULL,
  PRIMARY KEY (invoice_id),
  FOREIGN KEY (cust_id) REFERENCES customer (cust_id),
  FOREIGN KEY (burn_sn) REFERENCES burner (burn_sn)
)


-- 1. Выведите список версий всех горелок типа «FiredNow».
-- ОТВЕТ: 
SELECT burn_ver
FROM burner
JOIN kind_burner ON burner.kind_id = kind_burner.kind_id
WHERE kind_name = 'FiredNow';

select burn_ver from burner
where kind_id = (select kind_id from kind_burner where kind_name = 'FiredNow');

BURN_VER
V1
V1
V2

-- 2. Выведите серийный номер и дату регистрации для продуктов, зарегистрированных в
-- феврале.
-- ОТВЕТ: 
SELECT burn_sn, reg_data
FROM registration
WHERE TO_CHAR (reg_data, 'MON') = 'MAR';

BURN_SN	    REG_DATA
1010-12SN	  03/11/2022
1010-13SN	  03/21/2022
1010-14SN	  03/30/2022

-- 3. Выведите список имен покупателей, не имеющих электронной почты; отсортируйте
-- результаты в обратном алфавитном порядке.
-- ОТВЕТ: 
SELECT cust_name
FROM customer
WHERE cust_email IS NULL 
ORDER BY cust_name DESC;

CUST_NAME
Maria Bolkonskaya
Yelena Prekrasnaja

-- 4. Определите среднюю стоимость ремонта горелки.
-- ОТВЕТ: 
SELECT AVG(rep_cost) AS average_repair_cost
FROM repair;

AVERAGE_REPAIR_COST
127.775

-- 5. Определите количество горелок каждого типа и выведите тип и количество.
-- ОТВЕТ: 
SELECT kind_name, COUNT(*) AS burner_count
FROM kind_burner
JOIN burner ON kind_burner.kind_id = burner.kind_id
GROUP BY kind_name;

KIND_NAME	    BURNER_COUNT
FiredAlways	  3
FiredAtCamp	  3
FiredNow	    3

-- 6. Выведите имена и адреса электронной почты всех покупателей, на которых
-- зарегистрирована горелка типа «FiredNow». Используйте вложенный запрос.
-- ОТВЕТ: 
SELECT cust_name, cust_email
FROM customer
WHERE cust_id IN
(SELECT cust_id FROM registration WHERE burn_sn IN
(SELECT burn_sn FROM burner WHERE kind_id IN
(SELECT kind_id FROM kind_burner WHERE kind_name = 'FiredNow')));

CUST_NAME         CUST_EMAIL
Dmitri Rzevski    dmitri@gmail.com
Natasha Rostova   natasha@gmail.com
Pierre Bezukhov   pierre@gmail.com

-- 7. Выведите имена и адреса электронной почты всех покупателей, на которых
-- зарегистрирована горелка типа «FiredNow». Используйте объединение.
-- ОТВЕТ: 
SELECT customer.cust_name, customer.cust_email
FROM customer
JOIN registration ON customer.cust_id = registration.cust_id
JOIN burner ON registration.burn_sn = burner.burn_sn
JOIN kind_burner ON burner.kind_id = kind_burner.kind_id
WHERE kind_burner.kind_name = 'FiredNow';

CUST_NAME	        CUST_EMAIL
Dmitri Rzevski	  dmitri@gmail.com
Natasha Rostova	  natasha@gmail.com
Pierre Bezukhov	  pierre@gmail.com

-- 8. Выведите имена и адреса электронной почты покупателей, имеющих зарегистрированную
-- горелку, но не сдававших ни одной горелки в ремонт.
-- ОТВЕТ: 
SELECT cust_id, cust_name, cust_email
FROM customer
WHERE cust_id IN (SELECT cust_id FROM registration)
AND cust_id NOT IN (SELECT cust_id FROM repair);

CUST_ID	  CUST_NAME	           CUST_EMAIL
16	      Maria Bolkonskaya	   -
17	      Nikolai Rostov	     nik@gmail.com
18	      Yelena Prekrasnaja	 -
19	      Vasilisa Mudraja	   vasilisa@mail.ru

-- 9. Постройте представление, начинающееся с таблицы ГОРЕЛКА и содержащее все данные
-- из всех таблиц. Назовите это представление ГОРЕЛКА_ПР.
-- ОТВЕТ: 
CREATE VIEW ГОРЕЛКА_ПР AS
SELECT burner.*, kind_burner.kind_name, customer.cust_name, customer.cust_email, registration.reg_data, repair.rep_date, repair.rep_desc, repair.rep_cost
FROM burner
JOIN kind_burner ON burner.kind_id = kind_burner.kind_id
LEFT JOIN registration ON burner.burn_sn = registration.burn_sn
LEFT JOIN customer ON registration.cust_id = customer.cust_id
LEFT JOIN repair ON burner.burn_sn = repair.burn_sn;

BURN_SN	    KIND_ID	  BURN_VER	  BURN_DATE_PROD	  KIND_NAME	    CUST_NAME	          CUST_EMAIL	           REG_DATA	  REP_DATE	  REP_DESC	          REP_COST
1010-12SN	  1	        V1	        01/01/2022	      FiredNow	    Dmitri Rzevski	    dmitri@gmail.com	     03/11/2022	06/09/2022	Fix an element	    50
1010-13SN	  1	        V1	        01/10/2022	      FiredNow	    Natasha Rostova	    natasha@gmail.com	     03/21/2022	06/09/2022	Repair an element	  160.6
1010-14SN	  1	        V2	        01/20/2022	      FiredNow	    Pierre Bezukhov	    pierre@gmail.com	     03/30/2022	06/09/2022	Fix 3 elements	    200.5
2010-15SN	  2	        V1	        02/06/2022	      FiredAlways	  Andrei Bolkonsky	  a.bolkonsky@gmail.com	 04/06/2022	06/09/2022	Change an element	  100
2010-16SN	  2	        V3	        02/10/2022	      FiredAlways	  Maria Bolkonskaya	  -	                     04/07/2022	-	          -	                  -
2010-17SN	  2	        V1	        02/11/2022	      FiredAlways	  Nikolai Rostov	    nik@gmail.com	         04/21/2022	-	          -	                  -
3010-18SN	  3	        V1	        03/04/2022	      FiredAtCamp	  Yelena Prekrasnaja	-	                     06/08/2022	-	          -	                  -
3010-19SN	  3	        V3	        03/14/2022	      FiredAtCamp	  Vasilisa Mudraja	  vasilisa@mail.ru	     06/09/2022	-	          -	                  -
4010-20SN	  3	        V4	        03/20/2022	      FiredAtCamp	  -	-	-	-	-	-

-- 10. Напишите SQL-операторы, необходимые для чтения представления
SELECT * FROM ГОРЕЛКА_ПР;
-- ОТВЕТ: 
