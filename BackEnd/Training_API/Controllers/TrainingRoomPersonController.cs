using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training_API.Data.Interfaces;
using Training_API.Data.Services.Verification;
using Training_API.Models;

namespace Training_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainingRoomPersonController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly ITrainingRoomPerson _trainingRoomPerson;
        private readonly ITrainingRoom _trainingRoom;
        private readonly VerificationService _verification;
        public TrainingRoomPersonController(IRepository repository, 
                                            ITrainingRoomPerson trainingRoomPerson, 
                                            ITrainingRoom trainingRoom, 
                                            VerificationService verification)
        {
            this._repository = repository;
            this._trainingRoomPerson = trainingRoomPerson;
            this._trainingRoom = trainingRoom;
            this._verification = verification;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(
                    await _trainingRoomPerson.GetAllAsync()
                );
            }
            catch (Exception ex)
            {
                return BadRequest($"When getting the trainingroom_person, an error ocurred: {ex.Message}");
            }
        }

        [HttpGet("id={trainingRoomPersonId}")]
        public async Task<IActionResult> GetById(int trainingRoomPersonId)
        {
            try
            {
                return Ok(
                    await _trainingRoomPerson.GetByIdAsync(trainingRoomPersonId)
                );
            }
            catch (Exception ex)
            {
                return BadRequest($"When getting the trainingroom_person, an error ocurred: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(TrainingRoomPerson trainingRoomPerson)
        {
            try
            {
                _repository.Add(trainingRoomPerson);
                if (await this._repository.SaveChangesAsync() != true)
                {
                    return BadRequest();
                }
                int trainingRoomId = trainingRoomPerson.TrainingRoomId;
                if (
                    _verification.VerifyPeopleExcess(
                        _trainingRoom.ReturnTrainingRoomCapacity(trainingRoomId), 
                        _trainingRoomPerson.ReturnPeopleQuantityInRoom(trainingRoomId)
                    )
                )
                {
                    return BadRequest("The room is already full! Please delete the instance you created.");
                }
                int stageTimeId = trainingRoomPerson.StageTimeId;
                if(
                    _verification.VerifyDifferenceOfOne(
                        _trainingRoomPerson.ReturnPeopleQuantityPerRoomList(stageTimeId)
                    )
                )
                {
                    return BadRequest("The difference in the number of people in each room must be one or less! Please delete the instance you created.");
                }
                return Ok(trainingRoomPerson);
            }
            catch (Exception ex)
            {
                return BadRequest($"When posting the trainingroom_person, an error ocurred: {ex.Message}");
            }
        }

        [HttpPut("id={trainingRoomPersonId}")]
        public async Task<IActionResult> Put(int trainingRoomPersonId, TrainingRoomPerson trainingRoomPerson)
        {
            try
            {
                var registeredTrainingRoomPerson = await _trainingRoomPerson.GetByIdAsync(trainingRoomPersonId);
                if (registeredTrainingRoomPerson == null)
                {
                    return NotFound();
                }
                _repository.Update(trainingRoomPerson);
                if (await _repository.SaveChangesAsync())
                {
                    return Ok(trainingRoomPerson);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"When updating the trainingroom_person, an error ocurred: {ex.Message}");
            }
            return BadRequest();
        }

        [HttpDelete("id={trainingRoomPersonId}")]
        public async Task<IActionResult> Delete(int trainingRoomPersonId)
        {
            try
            {
                var registeredTrainingRoomPerson = await _trainingRoomPerson.GetByIdAsync(trainingRoomPersonId);
                if (registeredTrainingRoomPerson == null)
                {
                    return NotFound();
                }
                _repository.Delete(registeredTrainingRoomPerson);
                if (await _repository.SaveChangesAsync())
                {
                    return Ok(
                        new {
                            message="Deleted!"
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"When deleting the trainingroom_person, an error ocurred: {ex.Message}");
            }
            return BadRequest();
        }
    }
}