using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GymRecord.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GymRecord.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProgramController:ControllerBase
    {
        /// <summary>
        /// Получение всех программ
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProgramViewModel>>> GetAll()
        {
            return await Task.FromResult(Ok(new List<ProgramViewModel>()));
        }

        /// <summary>
        /// Получение программы по Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProgramViewModel>> GetById(Guid id)
        {
            return await Task.FromResult(Ok(new ProgramViewModel()));
        } 
        
        /// <summary>
        /// Получение программ пользователя по Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("user/{id}")]
        public async Task<ActionResult<IEnumerable<ProgramViewModel>>> GetByUserId([FromRoute] Guid id)
        {
            return await Task.FromResult<ActionResult>(Ok(new ProgramViewModel()));
        }

        /// <summary>
        /// Добавление программы
        /// </summary>
        /// <param name="program">Модель программы</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddProgram([FromBody] ProgramViewModel program)
        {
            return Ok();
        }

        /// <summary>
        /// Удаление программы
        /// </summary>
        /// <param name="programId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ActionResult> DeleteProgram([FromQuery] Guid programId, [FromQuery] Guid userId)
        {
            return NoContent();
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