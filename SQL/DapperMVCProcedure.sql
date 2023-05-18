select * from EventDetails

create procedure EventAddOrEdit
@EventId int,
@EventName nvarchar(100),
@EventPrice decimal(10,2),
@EventDate date
As
Begin
	if  @EventId =0
		Insert into EventDetails values(@EventName,@EventPrice,@EventDate);
	else
		update EventDetails
		SET
		EventName=@EventName,EventPrice=@EventPrice,EventDate=@EventDate
		where
		EventId=@EventId
End;

create procedure EventDetailViewAll
As
Begin
	select * from EventDetails;
End;

create procedure EventDetailViewById
@EventId int
As
Begin
	select * from EventDetails where EventId=@EventId;
End;

create procedure EventDetailDeleteById
@EventId int
As
Begin
	delete EventDetails where EventId=@EventId;
End;

