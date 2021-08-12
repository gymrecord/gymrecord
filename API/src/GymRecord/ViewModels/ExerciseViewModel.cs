using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GymRecord.ViewModels
{
    /// <summary>
    /// Упражнение
    /// </summary>
    public class ExerciseViewModel
    {
        /// <summary>
        /// Уникальный идентификатор упражнения
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }
        
        /// <summary>
        /// Название упражнения
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Название упражнения
        /// </summary>
        [JsonProperty("timer")]
        public TimeSpan? Timer { get; set; }
        
        /// <summary>
        /// Теги
        /// </summary>
        [JsonProperty("tags")]
        public IEnumerable<TagViewModel> Tags { get; set; }

        /// <summary>
        /// Отзыв от упражнения
        /// </summary>
        [JsonProperty("feedback")]
        public string Feedback { get; set; }

        /// <summary>
        /// Медиа
        /// </summary>
        [JsonProperty("feedback")]
        public IEnumerable<MediaViewModel> Media { get; set; }

        /// <summary>
        /// Подходы
        /// </summary>
        [JsonProperty("approaches")]
        public IEnumerable<ApproachViewModel> Approaches { get; set; }
    }
}