CREATE TABLE seats_price
(
  class       decimal(7,0) NOT NULL primary key,
  seat_price  decimal(9,0) NOT NULL
);
ALTER TABLE seats_price ADD CONSTRAINT PK_seats_price primary key (class);

begin
insert into seats_price(class, seat_price)
VALUES('Econom', '€25');

insert into seats_price(class, seat_price)
VALUES('Standart', '€40');

insert into seats_price(class, seat_price)
VALUES('Premium', '€60');
end;


CREATE TABLE numbers
(
  num_id              decimal(5,0) NOT NULL,
  class               decimal(7,0) NOT NULL primary key,
  number_of_seats     decimal(5,0) NOT NULL,
  number_of_bookings  decimal(5,0) NOT NULL
);
ALTER TABLE numbers
ADD CONSTRAINT PK_numbers PRIMARY KEY (num_id);

begin
insert into numbers(num_id, class, number_of_seats, number_of_bookings)
VALUES('1000', 'Econom', '20', '3');

insert into numbers(num_id, class, number_of_seats, number_of_bookings)
VALUES('2000', 'Standart', '10', '1');

insert into numbers(num_id, class, number_of_seats, number_of_bookings)
VALUES('3000', 'Premium', '5', '2');
end;


CREATE TABLE guests
(
  passport_num  char(10)      NOT NULL primary key,
  borrowed_num  decimal(3,0)  NOT NULL, 
  name_surename char(50)      NOT NULL,
  gender        char(1)       DEFAULT 'M',
  organisation  char(60)      NULL,
  move_in_date  DATE          NOT NULL,
  move_out_date DATE          NOT NULL
);

ALTER TABLE guests ADD CONSTRAINT FK_PK_guests_number
FOREIGN KEY(borrowed_num) REFERENCES seats_price(class);

begin
insert into guests(passport_num, borrowed_num, name_surename, gender, organization, move_in_date, move_out_date)
VALUES('HF783DF', '1004', 'Monika Mägu', 'Male', '-', TO_DATE('2023-05-10', 'yyyy-mm-dd'), TO_DATE('2023-05-14', 'yyyy-mm-dd') );

insert into guests(passport_num, borrowed_num, name_surename, gender, organization, move_in_date, move_out_date)
VALUES('YU789SD', '1005', 'Mark Otts', 'Female', 'Saku Late AS', TO_DATE('2023-04-29', 'yyyy-mm-dd'), TO_DATE('2023-05-02', 'yyyy-mm-dd') );

insert into guests(passport_num, borrowed_num, name_surename, gender, organization, move_in_date, move_out_date)
VALUES('KL789AA', '1006', 'Kristjan Mails', 'Female', '-', TO_DATE('2023-06-15', 'yyyy-mm-dd'), TO_DATE('2023-06-20', 'yyyy-mm-dd') );

insert into guests(passport_num, borrowed_num, name_surename, gender, organization, move_in_date, move_out_date)
VALUES('JN093JP', '2007', 'Anna Kertu', 'Male', 'Joga TLN OÜ', TO_DATE('2023-06-23', 'yyyy-mm-dd'), TO_DATE('2023-06-25', 'yyyy-mm-dd') );

insert into guests(passport_num, borrowed_num, name_surename, gender, organization, move_in_date, move_out_date)
VALUES('MN892DY', '3010', 'Kert Heinsalu', 'Female', '-', TO_DATE('2023-06-28', 'yyyy-mm-dd'), TO_DATE('2023-07-01', 'yyyy-mm-dd') );

insert into guests(passport_num, borrowed_num, name_surename, gender, organization, move_in_date, move_out_date)
VALUES('OE923IO', '3005', 'Marta Jurgens', 'Male', '-', TO_DATE('2023-07-13', 'yyyy-mm-dd'), TO_DATE('2023-07-20', 'yyyy-mm-dd') );
end;

-- 2 Задание --
------- 1 -------
SELECT class, num_id AS "Свободные номера", number_of_seats AS "Количество мест"
FROM numbers
LEFT JOIN guests ON num_id = borrowed_num
WHERE borrowed_num IS NULL
ORDER BY class, num_id;

-- 2 Задание --
------- 2 -------
SELECT class, num_id AS "Забронированные номера", number_of_seats AS "Количество мест"
FROM numbers 
LEFT JOIN guests ON num_id = borrowed_num
GROUP BY class, num_id, number_of_seats
HAVING COUNT(passport_num) = number_of_seats
ORDER BY class, num_id;


-- 3 Задание --
------- 1 -------
CREATE VIEW NowGuests AS
SELECT *
FROM guests
WHERE TO_DATE('2023-06-30', 'yyyy-mm-dd') BETWEEN move_in_date AND move_out_date;

-- 3 Задание --
------- 2 -------
CREATE VIEW borrowed_rooms AS
SELECT num_id AS rooms, number_of_seats AS number_of_seats
FROM numbers
WHERE num_id IN (
    SELECT borrowed_num
    FROM guests
    GROUP BY borrowed_num
    HAVING COUNT(passport_num) = number_of_seats
);