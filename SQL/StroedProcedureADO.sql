--Display event details
CREATE PROCEDURE uspShowAllEventDetails
AS
Begin
	select EventId,EventName,EventPrice,EventDate from EventDetails;
end;

Execute uspShowAllEventDetails;

--Insert event details
CREATE PROCEDURE uspInsertEventDetails
@eventId int,
@eventName nvarchar(200),
@eventPrice decimal(10,2),
@eventDate date
AS
Begin
	INSERT INTO EventDetails VALUES(@eventId,@eventName,@eventPrice,@eventDate);
end;

Execute uspInsertEventDetails @eventId=6,@eventName="Mobile",@eventPrice = 456.23,@eventDate="05/14/2023";

--Delete event details
CREATE PROCEDURE uspDeleteEventDetails
@eventId int
AS
Begin
	DELETE EventDetails where EventId = @eventId;
end;

Execute uspDeleteEventDetails @eventId =7;

--Update event details
CREATE PROCEDURE uspUpdateEventDetails
@eventId int,
@eventName nvarchar(200)
AS
Begin
	UPDATE EventDetails SET EventName = @eventName WHERE EventId = @eventId;
end;

Execute uspUpdateEventDetails @eventId = 1,@eventName="Valliball";

--Create Table EventDetails

CREATE TABLE EventDetails
(EventId int not null primary key,EventName nvarchar(200) not null,EventPrice decimal(10,2) not null,EventDate date not null);
