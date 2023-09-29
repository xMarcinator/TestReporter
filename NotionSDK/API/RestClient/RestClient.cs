using System.Text.Json;
using NotionSDK.logging;

namespace NotionSDK.API.RestClient;

public class RestClient
{
    private HttpClient _httpClient;
    private ClientOptions _options;

    public HttpClient i()
    {
        if (_httpClient != null)
            return _httpClient;

        _httpClient = new HttpClient();


        var pipeline = new LoggingHandler { InnerHandler = new HttpClientHandler() };

        _httpClient = new HttpClient(pipeline);
        _httpClient.BaseAddress = new Uri(_options.BaseUrl);

        return _httpClient;
    }

    public async Task<K?> SendRequest<T, K>(RequestOptions<T, K> message, CancellationToken cancellationToken)
        where K : class
    {
        var httpResponse = await _httpClient.SendAsync(message, cancellationToken);

        if (!httpResponse.IsSuccessStatusCode)
        {
            throw await BuildException(httpResponse);
        }

        if (httpResponse.Content.Headers.ContentType?.MediaType != "application/json")
            Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");

        var contentStream = await httpResponse.Content.ReadAsStreamAsync();

        try
        {
            return await JsonSerializer.DeserializeAsync<K>(contentStream,
                new JsonSerializerOptions { IgnoreNullValues = true, PropertyNameCaseInsensitive = true });
        }
        catch (JsonException) // Invalid JSON
        {
            Console.WriteLine("Invalid JSON.");
        }

        return null;
    }

    private static async Task<Exception> BuildException(HttpResponseMessage response)
    {
        var errorBody = await response.Content.ReadAsStringAsync();

        NotionApiErrorResponse errorResponse = null;

        if (!string.IsNullOrWhiteSpace(errorBody))
        {
            try
            {
                errorResponse = JsonConvert.DeserializeObject<NotionApiErrorResponse>(errorBody);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error when parsing the notion api response.");
            }
        }

        return new NotionApiException(response.StatusCode, errorResponse?.ErrorCode, errorResponse?.Message);
    }
}