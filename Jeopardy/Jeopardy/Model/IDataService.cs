using System.Threading.Tasks;

namespace Jeopardy.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}