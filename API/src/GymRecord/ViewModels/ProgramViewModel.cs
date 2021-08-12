using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GymRecord.ViewModels
{
    /// <summary>
    /// Программа тренировок
    /// </summary>
    public class ProgramViewModel
    {
        /// <summary>
        /// Уникальный идентификатор упражнения
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }
        
        /// <summary>
        /// Набор тренировок
        /// </summary>
        [JsonProperty("workouts")]
        public IEnumerable<WorkoutViewModel> Workouts { get; set; }
        
        /// <summary>
        /// Теги
        /// </summary>
        [JsonProperty("tags")]
        public IEnumerable<TagViewModel> Tags { get; set; }

        /// <summary>
        /// Дата добавления
        /// </summary>
        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Id автора программы
        /// </summary>
        [JsonProperty("creatorId")]
        public Guid CreatorId { get; set; }

        /// <summary>
        /// Имя автора программы
        /// </summary>
        public string CreatorName { get; set; }

        /// <summary>
        /// Лайки
        /// </summary>
        [JsonProperty("likes")]
        public int? Likes { get; set; }
    }
}