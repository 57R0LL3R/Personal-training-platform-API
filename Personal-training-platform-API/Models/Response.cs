﻿namespace Personal_training_platform_API.Models
{
    public class Response
    {
        public int CodeReponse { get; set; }
        public string Message { get; set; }
        public dynamic? Data {get;set;}
    }
}
