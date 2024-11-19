using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class PromptService
{
    private readonly HttpClient _httpClient;

    public PromptService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<HttpResponseMessage> ChangePromptsAsync(FormUrlEncodedContent content)
    {
        return await _httpClient.PostAsync("/changed", content);
    }
}