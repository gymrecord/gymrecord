using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GymRecord.ViewModels
{
    /// <summary>
    /// Тренировка
    /// </summary>
    public class WorkoutViewModel
    {
        /// <summary>
        /// Уникальный идентификатор тренировки
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Название тренировки
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Описание тренировки
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        [JsonProperty("сategory")]
        public string Category { get; set; }

        /// <summary>
        /// Список упражнений
        /// </summary>
        [JsonProperty("exercises")]
        public IEnumerable<ExerciseViewModel> Exercises { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        [JsonProperty("dateTime")]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Теги
        /// </summary>
        [JsonProperty("tags")]
        public IEnumerable<TagViewModel> Tags { get; set; }

        /// <summary>
        /// Лайки
        /// </summary>
        [JsonProperty("likes")]
        public int? Likes { get; set; }
    }
}