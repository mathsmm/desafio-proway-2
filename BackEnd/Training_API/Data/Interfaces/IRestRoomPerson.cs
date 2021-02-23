using System.Collections.Generic;
using System.Threading.Tasks;
using Training_API.Models;

namespace Training_API.Data.Interfaces
{
    public interface IRestRoomPerson
    {
        Task<RestRoomPerson[]> GetAllAsync();
        Task<RestRoomPerson> GetByIdAsync(int restRoomPersonId);
    }
}