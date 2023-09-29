using NotionSDK.logging;

namespace NotionSDK.API.RestClient;

public class LoggingHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        Log.Trace("Request: {request}", request);

        try
        {
            var response = await base.SendAsync(request, cancellationToken);

            Log.Trace("Response: {response}", response);

            return response;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Failed to get response: {exception}", ex);

            throw;
        }
    }
}