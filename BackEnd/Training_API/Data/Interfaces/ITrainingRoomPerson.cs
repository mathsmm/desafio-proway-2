using System.Collections.Generic;
using System.Threading.Tasks;
using Training_API.Models;

namespace Training_API.Data.Interfaces
{
    public interface ITrainingRoomPerson
    {
        Task<TrainingRoomPerson[]> GetAllAsync();
        Task<TrainingRoomPerson> GetByIdAsync(int trainingRoomPersonId);
        List<int> ReturnPeopleQuantityPerRoomList();
        int ReturnPeopleQuantityInRoom(int trainingRoomid);
    }
}