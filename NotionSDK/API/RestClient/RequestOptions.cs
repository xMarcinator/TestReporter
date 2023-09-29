namespace NotionSDK.API.RestClient;

public interface RequestOptions<T, K>
{
    public HttpRequestMessage buildRequest();
}