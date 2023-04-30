using System.Data;

namespace CrudOperation.DAL
{
    public interface IDisplay
    {
        DataTable ReadEventDetails();
    }
}