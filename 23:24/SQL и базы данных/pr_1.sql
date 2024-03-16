CREATE TABLE Owners
(
  own_id    decimal(6,0) NOT NULL primary key,
	own_name  char(50) NOT NULL,
	own_phone char(20) NULL
);

CREATE TABLE Apartments
(
  apart_id 	          decimal(5,0) NOT NULL primary key,
	own_id 		          decimal(6,0) NOT NULL,
	apart_area	        decimal(4,1) NOT NULL,
	apart_living 	      decimal(4,1) NOT NULL,
	apart_rooms         decimal(1,0) NOT NULL,
	apart_kitchen_area  decimal(3,1) NOT NULL,
	apart_floor         decimal(2,0) NOT NULL,
	total_floors        decimal(2,0) NULL,
	apart_price         decimal(7,0) NOT NULL,
	apart_address       char(30)     NOT NULL,
	apart_date          DATE         NOT NULL
);

ALTER TABLE Owners ADD CONSTRAINT PK_owners primary key (own_id);

ALTER TABLE Apartments ADD CONSTRAINT FK_PK_apartments_Owners
FOREIGN KEY(own_id) REFERENCES Owners(own_id);

begin
insert into owners(own_id, own_name, own_phone)
VALUES('1', 'Vasja Vasechkin', '55544222');

insert into owners(own_id, own_name, own_phone)
VALUES('2', 'Petja Vasechkin', '55544333');
end;

begin
insert into Apartments(
  apart_id, own_id, apart_area, apart_living, apart_rooms, apart_kitchen_area, apart_floor, 
  total_floors, apart_price, apart_address, apart_date
)
VALUES ( '10', '1', '86', '74', '4', '6', '4', '9','65000','Viru 1-1', 
TO_DATE('2023-01-01', 'yyyy-mm-dd'));

insert into Apartments(
  apart_id, own_id, apart_area, apart_living, apart_rooms, apart_kitchen_area, apart_floor, 
  total_floors, apart_price, apart_address, apart_date
)
VALUES ( '11', '2', '75', '66', '3', '6', '4','9','65000','Viru 1-2', 
TO_DATE('2023-05-01', 'yyyy-mm-dd'));

insert into Apartments(
  apart_id, own_id, apart_area, apart_living, apart_rooms, apart_kitchen_area, apart_floor, 
  total_floors, apart_price, apart_address, apart_date
)
VALUES ( '12', '2', '66', '56', '2', '6', '9','9','65000','Viru 1-12', 
TO_DATE('2023-05-15', 'yyyy-mm-dd'));
end

select * from Apartments

select * from Apartments
where apart_area > apart_living + apart_kitchen_area

select * from Apartments
where apart_floor>1 and apart_floor<total_floors and apart_rooms=3
order by apart_date;

select * from Apartments
where apart_floor>1 and apart_floor<total_floors and apart_rooms=3
and apart_date > CURRENT_DATE-300;

select * from Apartments
where apart_area > 80
and apart_price < 150000;

select * from Apartments
where apart_floor>1 and apart_floor<total_floors and apart_rooms=3
and 
to_number(to_char(apart_date,'MM'))>4 and
to_number(to_char(apart_date,'MM'))<11;

-- владельцев и их квартир (идентификатор квартиры и адрес) --
select owners.own_id, own_name, apart_address
from owners
inner join Apartments on Owners.own_id = Apartments.own_id
order by own_name;

-- 3 задание --
-- 1) "Двухкомнатные квартиры" (все поля отношения "Квартиры")--
CREATE VIEW two_room_apartments AS
SELECT *
FROM Apartments
WHERE apart_rooms = 2;

-- 2) "Владение квартирами" (имя владельца, количество квартир, общая площадь этих квартир)--
CREATE VIEW Apartment_ownership AS
SELECT Owners.own_name, 
       COUNT(Apartments.apart_id) AS count_apartments,
       SUM(Apartments.apart_area) AS sum_area
FROM Owners, Apartments
WHERE Owners.own_id = Apartments.own_id
GROUP BY Owners.own_name;

-- 2) "Владельцы однокомнатных квартир" (имя, телефон, площадь квартиры)--
CREATE VIEW One_room_apartment_owners AS 
SELECT own_name, own_phone, apart_area
FROM Owners
INNER JOIN Apartments on Apartments.own_id = Owners.own_id
WHERE apart_rooms = 1;