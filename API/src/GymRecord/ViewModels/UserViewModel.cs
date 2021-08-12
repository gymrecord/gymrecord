using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GymRecord.ViewModels
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// Уникальный идентификатор пользователя
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }
        
        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        
        /// <summary>
        /// Пароль
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }
        
        /// <summary>
        /// Логин
        /// </summary>
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// Фотография пользователя
        /// </summary>
        [JsonProperty("Image")]
        public MediaViewModel Image { get; set; }

        /// <summary>
        /// Набор программ тренировок
        /// </summary>
        [JsonProperty("programs")]
        public IEnumerable<ProgramViewModel> Programs { get; set; }
        
        /// <summary>
        /// Набор тренировок
        /// </summary>
        [JsonProperty("workouts")]
        public IEnumerable<WorkoutViewModel> Workouts { get; set; }

        /// <summary>
        /// Показатели
        /// </summary>
        [JsonProperty("indicators")]
        public IndicatorsViewModel Indicators { get; set; }
    }
}