using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GymRecord.ViewModels
{
    /// <summary>
    /// Медиаконтент
    /// </summary>
    public class MediaViewModel
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
        /// Медиаконтент (картинка, гифка, видео) строка base64
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Ссылка на  медиаконтент(картинка, гифка, видео)
        /// </summary>
        [JsonProperty("contentLink")]
        public string ContentLink { get; set; }
        
        /// <summary>
        /// Теги
        /// </summary>
        [JsonProperty("tags")]
        public IEnumerable<TagViewModel> Tags { get; set; }
    }
}