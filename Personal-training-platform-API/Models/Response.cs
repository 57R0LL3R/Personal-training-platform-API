namespace Personal_training_platform_API.Models
{
    public class Response
    {
        public int CodeReponse { get; set; } = 1;
        public string Message { get; set; } = "Proceso realizado correctamente ";
        public dynamic? Data {get;set;}
    }
}
