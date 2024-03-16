-- 1 задание --
SELECT customer.cust_name, customer.cust_email
FROM customer
JOIN registration ON customer.cust_id = registration.cust_id
JOIN burner ON registration.burn_sn = burner.burn_sn
JOIN kind_burner ON burner.kind_id = kind_burner.kind_id
WHERE kind_burner.kind_name = 'FiredNow';

-- Ответ --
CUST_NAME	        CUST_EMAIL
Dmitri Rzevski	  dmitri@gmail.com
Natasha Rostova	  natasha@gmail.com
Pierre Bezukhov	  pierre@gmail.com

-- 2 задание --
SELECT cust_id, cust_name, cust_email
FROM customer
WHERE cust_id IN (SELECT cust_id FROM registration)
AND cust_id NOT IN (SELECT cust_id FROM repair);

-- Ответ --
CUST_ID	  CUST_NAME	           CUST_EMAIL
16	      Maria Bolkonskaya	   -
17	      Nikolai Rostov	     nik@gmail.com
18	      Yelena Prekrasnaja	 -
19	      Vasilisa Mudraja	   vasilisa@mail.ru

-- 3 задание --
SELECT cust_name, cust_email
FROM customer
WHERE cust_id IN
(SELECT cust_id FROM registration WHERE burn_sn IN
(SELECT burn_sn FROM burner WHERE kind_id IN
(SELECT kind_id FROM kind_burner WHERE kind_name = 'FiredNow')));

-- Ответ --
CUST_NAME         CUST_EMAIL
Dmitri Rzevski    dmitri@gmail.com
Natasha Rostova   natasha@gmail.com
Pierre Bezukhov   pierre@gmail.com

-- 4 задание --
SELECT cust_name
FROM customer
WHERE cust_email IS NULL 
ORDER BY cust_name DESC;

-- Ответ --
CUST_NAME
Maria Bolkonskaya
Yelena Prekrasnaja

-- 5 задание --
SELECT AVG(rep_cost) AS average_repair_cost
FROM repair;

-- Ответ --
AVERAGE_REPAIR_COST
127.775

-- 6 задание --
SELECT kind_name, COUNT(*) AS burner_count
FROM kind_burner
JOIN burner ON kind_burner.kind_id = burner.kind_id
GROUP BY kind_name;

-- Ответ --
KIND_NAME	    BURNER_COUNT
FiredAlways	  3
FiredAtCamp	  3
FiredNow	    3

-- 7 задание --
SELECT burner.*, kind_burner.kind_name, customer.cust_name, customer.cust_email, registration.reg_data, repair.rep_date, repair.rep_desc, repair.rep_cost
FROM burner
JOIN kind_burner ON burner.kind_id = kind_burner.kind_id
LEFT JOIN registration ON burner.burn_sn = registration.burn_sn
LEFT JOIN customer ON registration.cust_id = customer.cust_id
LEFT JOIN repair ON burner.burn_sn = repair.burn_sn;

-- Ответ --
BURN_SN	    KIND_ID	  BURN_VER	  BURN_DATE_PROD	  KIND_NAME	    CUST_NAME	          CUST_EMAIL	           REG_DATA	  REP_DATE	  REP_DESC	          REP_COST
1010-12SN	  1	        V1	        01/01/2022	      FiredNow	    Dmitri Rzevski	    dmitri@gmail.com	     03/11/2022	06/09/2022	Fix an element	    50
1010-13SN	  1	        V1	        01/10/2022	      FiredNow	    Natasha Rostova	    natasha@gmail.com	     03/21/2022	06/09/2022	Repair an element	  160.6
1010-14SN	  1	        V2	        01/20/2022	      FiredNow	    Pierre Bezukhov	    pierre@gmail.com	     03/30/2022	06/09/2022	Fix 3 elements	    200.5
2010-15SN	  2	        V1	        02/06/2022	      FiredAlways	  Andrei Bolkonsky	  a.bolkonsky@gmail.com	 04/06/2022	06/09/2022	Change an element	  100
2010-16SN	  2	        V3	        02/10/2022	      FiredAlways	  Maria Bolkonskaya	  -	                     04/07/2022	-	          -	                  -
2010-17SN	  2	        V1	        02/11/2022	      FiredAlways	  Nikolai Rostov	    nik@gmail.com	         04/21/2022	-	          -	                  -
3010-18SN	  3	        V1	        03/04/2022	      FiredAtCamp	  Yelena Prekrasnaja	-	                     06/08/2022	-	          -	                  -
3010-19SN	  3	        V3	        03/14/2022	      FiredAtCamp	  Vasilisa Mudraja	  vasilisa@mail.ru	     06/09/2022	-	          -	                  -

-- 8 задание --
SELECT *
FROM ГОРЕЛКА_ПР
WHERE burn_sn >= '1010-14SN';

-- Ответ --
BURN_SN	    KIND_ID	  BURN_VER	BURN_DATE_PROD	KIND_NAME	    CUST_NAME	          CUST_EMAIL	            REG_DATA	    REP_DATE	  REP_DESC	          REP_COST
1010-14SN	  1	        V2	      01/20/2022	    FiredNow	    Pierre Bezukhov	    pierre@gmail.com	      03/30/2022	  06/09/2022	Fix 3 elements	    200.5
2010-15SN	  2	        V1	      02/06/2022	    FiredAlways	  Andrei Bolkonsky	  a.bolkonsky@gmail.com	  04/06/2022	  06/09/2022	Change an element	  100
2010-16SN	  2	        V3	      02/10/2022	    FiredAlways	  Maria Bolkonskaya	  -	                      04/07/2022	  -	          -	                  -
2010-17SN	  2	        V1	      02/11/2022	    FiredAlways	  Nikolai Rostov	    nik@gmail.com	          04/21/2022	  -	          -	                  -
3010-18SN	  3	        V1	      03/04/2022	    FiredAtCamp	  Yelena Prekrasnaja	-	                      06/08/2022	  -	          -	                  -
3010-19SN	  3	        V3	      03/14/2022	    FiredAtCamp	  Vasilisa Mudraja	  vasilisa@mail.ru	      06/09/2022	  -	          -	                  -
4010-20SN	  3	        V4	      03/20/2022	    FiredAtCamp	  -	                  -	                      -	            -	          -	                  -

-- 9 задание --
CREATE VIEW РЕГИСТРАЦИЯ_ПР AS
SELECT 
    registration.reg_data, 
    registration.burn_sn, 
    registration.cust_id, 
    burner.burn_ver, 
    burner.burn_date_prod, 
    kind_burner.kind_name, 
    kind_burner.kind_id, 
    customer.cust_name, 
    customer.cust_email, 
    customer.cust_tell
FROM registration
JOIN burner ON registration.burn_sn = burner.burn_sn
JOIN kind_burner ON burner.kind_id = kind_burner.kind_id
JOIN customer ON registration.cust_id = customer.cust_id;

-- Ответ --
REG_DATA	  BURN_SN	  CUST_ID	BURN_VER	BURN_DATE_PROD	KIND_NAME	    KIND_ID	    CUST_NAME	          CUST_EMAIL	          CUST_TELL
03/11/2022	  1010-12SN	  12	    V1	        01/01/2022	    FiredNow	    1	        Dmitri Rzevski	      dmitri@gmail.com	      37222052931
03/21/2022	  1010-13SN	  13	    V1	        01/10/2022	    FiredNow	    1	        Natasha Rostova	      natasha@gmail.com	      37238072145
03/30/2022	  1010-14SN   14	    V2	        01/20/2022	    FiredNow	    1	        Pierre Bezukhov	      pierre@gmail.com	      37238172045
04/06/2022	  2010-15SN	  15	    V1	        02/06/2022	    FiredAlways	    2	        Andrei Bolkonsky	  a.bolkonsky@gmail.com	  37232077045
04/07/2022	  2010-16SN	  16	    V3	        02/10/2022	    FiredAlways	    2	        Maria Bolkonskaya	  -	                      37222187133
04/21/2022	  2010-17SN   17	    V1	        02/11/2022	    FiredAlways	    2	        Nikolai Rostov	      nik@gmail.com	          37221082033
06/08/2022	  3010-18SN	  18	    V1	        03/04/2022	    FiredAtCamp	    3	        Yelena Prekrasnaja	  -	                      37221182133
06/09/2022	  3010-19SN	  19	    V3	        03/14/2022	    FiredAtCamp	    3	        Vasilisa Mudraja	  vasilisa@mail.ru	      37211052911

-- 10 задание --
INSERT INTO customer (cust_id, cust_name, cust_tell, cust_email)
VALUES (0001923, 'Mihkel Reinolds', '+37258940322', 'mihkel.rein@gmail.com');

INSERT INTO registration (cust_id, burn_sn, reg_data)
VALUES (0001923, 'VR405', TO_DATE('15.12.2023', 'DD.MM.YYYY'));