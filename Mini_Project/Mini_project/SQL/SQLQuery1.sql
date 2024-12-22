create database Train_Reservation_Project

use Train_Reservation_Project


CREATE TABLE Trains(
Train_number int Primary key,
Train_name varchar(40),
Source varchar(40),
Destination varchar(40),
Departure_Time Datetime,
Arrival_Time Datetime,
Seats_available int,
Status varchar(20),
);

select * from Trains

create procedure sp_Add_Trains
@Train_number int,
@Train_name varchar(40),
@Source varchar(40),
@Destination varchar(40),
@Departure_Time Datetime,
@Arrival_Time Datetime,
@Seats_available int,
@Status varchar(20)
as
begin

Insert into Trains 
values
(@Train_number,@Train_name,@Source,@Destination,@Departure_Time,@Arrival_Time,@Seats_available,@Status)
end


----------------Delete Trains----------------------

Create procedure sp_delete_trains
@Train_number int,
@Train_name varchar(40),
@Source varchar(40),
@Destination varchar(40)
as
begin
UPDATE Trains
        SET status = 'InActive'
        WHERE train_name = @train_name and Train_number = @Train_number and Source = @Source and Destination = @Destination;
    END

--------------------Update Trains-----------

drop procedure sp_Update_trains

create procedure sp_Update_trains
@Train_number int,
@Train_name varchar(40),
@Source varchar(40),
@Destination varchar(40),
@Departure_Time Datetime,
@Arrival_Time Datetime,
@Status varchar(40)

as
begin

Update  Trains 
set
Train_name = @Train_name,
Source = @Source,
Destination = @Destination,
Departure_Time = @Departure_Time,
Arrival_Time = @Arrival_Time,
Status = @Status
where Train_number = @Train_number
end


select * from Trains



-----------------------User Block-----------------------

CREATE PROCEDURE sp_View_Trains_Information
AS
BEGIN 
SELECT 
Train_number,
Train_name,
Source,
Destination,
Departure_Time,
Arrival_Time,
Seats_available,
Status
FROM Trains
where Status = 'Active';
END;

-----------Tickets Table-----------------------
drop table Tickets
SELECT * from Tickets

create table Tickets
(
Train_number INT,
Train_name VARCHAR(40),
Passenger_name VARCHAR(40),
Passenger_age INT,
Gender VARCHAR(10),
Class_type VARCHAR(40),
Number_of_seats INT,
Status varchar(40)
);
select * from Tickets

drop procedure Train_booking_information


create OR alter procedure Train_booking_information
@Train_number int,
@Train_name varchar(40),
@Passenger_name varchar(40),
@Passenger_age int,
@Gender varchar(10),
@Class_type varchar(40),
@Number_of_seats int,
@Status varchar(40)
as
begin
insert into TICKETS
values
(
@Train_number,
@Train_name,
@Passenger_name,
@Passenger_age,
@Gender,
@Class_type,
@Number_of_seats,
@Status
)
end;



---------Cancel------------------

create procedure sp_Cancel_Ticket
@Train_number int,
@Train_Name varchar(40),
@Passenger_Name varchar(40),
@Passenger_age INT,
@Gender varchar(10),
@Class_type varchar(40),
@Number_of_seats int,
@status varchar(40)
As
begin
update Tickets set Status = 'cancelled' where Train_number = @Train_number and Train_Name = @Train_Name and Passenger_Name = @Passenger_Name and
Passenger_age = @passenger_age and Gender = @Gender and Number_of_seats = @Number_of_seats
end;
drop procedure sp_Cancel_Ticket;
-------------------Show all trains------------------

drop table view_trains_information

create table view_trains_information
(Train_number int,
Train_Name varchar(40),
Source varchar,
Destination varchar,
Departure_Time DateTime,
Arrival_Time DateTime,
Seats_available int,
Status varchar(40)
);

drop procedure sp_view_trains_information

create procedure sp_view_trains_information

@Train_number int,
@Train_name varchar(40),
@Source varchar(40),
@Destination varchar(40),
@Departure_Time Datetime,
@Arrival_Time Datetime,
@Seats_available int,
@Status varchar(20)
As
begin
insert into view_trains_informat
values
@Train_number,
@Train_name,
@Source,
@Destination,
@Departure_Time,
@Arrival_Time,
@Seats_available,
@Status
)
end;





