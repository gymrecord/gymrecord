using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GymRecord.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GymRecord.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutController: ControllerBase
    {
        /// <summary>
        /// Получения всех тренировок
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkoutViewModel>>> GetAll()
        {
            return Ok(new List<WorkoutViewModel>());
        }

        /// <summary>
        /// Получение тренировки по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<WorkoutViewModel>> GetById([FromRoute] Guid id)
        {
            return Ok(new WorkoutViewModel());
        }

        /// <summary>
        /// Полчучение тренировок пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("user/{id}")]
        public async Task<ActionResult<WorkoutViewModel>> GetByUserId([FromRoute] Guid id)
        {
            return Ok(new WorkoutViewModel());
        }

        /// <summary>
        /// Добавление тренировки
        /// </summary>
        /// <param name="workout"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddWorkout([FromBody] WorkoutViewModel workout)
        {
            return NoContent();
        }

        /// <summary>
        /// Удаление тренировки
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ActionResult> DeleteWorkout([FromQuery] Guid workoutId, [FromQuery] Guid userId)
        {
            return Ok();
        }
        
        /// <summary>
        /// Очистка кэша
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("cache")]
        public async Task<ActionResult> DeleteCache()
        {
            return NoContent();
        }
    }
}