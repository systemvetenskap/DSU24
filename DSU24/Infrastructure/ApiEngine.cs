using DSU24.Models;
using Newtonsoft.Json;
using System.Net;

namespace DSU24.Infrastructure
{
    public static class ApiEngine
    {
        public async static Task<ApiResponse<T>> Fetch<T>(string apiUrl)
        {
            using HttpClient client = new HttpClient();
            ApiResponse<T> apiResponse = new ApiResponse<T>();

            try
            {
                if (!Uri.TryCreate(apiUrl, UriKind.Absolute, out _))
                {
                    apiResponse.ErrorMessage = "Invalid URL";
                    HttpResponseMessage invalidUrlResponse = new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        ReasonPhrase = "Invalid URL"
                    };

                    apiResponse.Response = invalidUrlResponse;
                    return apiResponse;
                }

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    apiResponse.Data = JsonConvert.DeserializeObject<T>(responseData);
                }
                else
                {
                    apiResponse.StatusCode = response.StatusCode;
                }
            }
            catch (Exception)
            {

                apiResponse.ErrorMessage="nej";
            }
            return apiResponse;
        }
    }
}
