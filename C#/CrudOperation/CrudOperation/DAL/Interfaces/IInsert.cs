namespace CrudOperation.DAL
{
    public interface IInsert
    {
        int InsertEventDetail(int EventID, string EventName, decimal EventPrice, string EventDate);
    }
}