using System;
using Newtonsoft.Json;

namespace GymRecord.ViewModels
{
    /// <summary>
    /// Показатели
    /// </summary>
    public class IndicatorsViewModel
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; } 
        
        /// <summary>
        /// Уникальный идентификатор пользователя
        /// </summary>
        [JsonProperty("id")]
        public Guid UserId { get; set; }
        
        /// <summary>
        /// Вес
        /// </summary>
        [JsonProperty("weight")]
        public double? Weight { get; set; }
        
        /// <summary>
        /// Рост
        /// </summary>
        [JsonProperty("height")]
        public double? Height { get; set; }
    }
}