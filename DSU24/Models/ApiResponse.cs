using System.Net;

namespace DSU24.Models
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public HttpResponseMessage Response { get; set; }
        public string ErrorMessage { get; set; }
        public HttpStatusCode StatusCode { get; internal set; }
        public bool IsSuccessful => string.IsNullOrEmpty(ErrorMessage);
    }
}
