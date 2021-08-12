using Newtonsoft.Json;

namespace GymRecord.ViewModels
{
    /// <summary>
    /// Подход
    /// </summary>
    public class ApproachViewModel
    {
        /// <summary>
        /// Вес
        /// </summary>
        [JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Количество повторений
        /// </summary>
        [JsonProperty("repetitions")]
        public int? Repetitions { get; set; }
    }
}