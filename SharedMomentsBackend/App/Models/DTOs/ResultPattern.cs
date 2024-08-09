namespace SharedMomentsBackend.App.Models.DTOs
{
    public class ResultPattern<T>
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; } = 200;
    } 
}