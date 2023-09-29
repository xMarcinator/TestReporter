namespace NotionSDK.API.Helper;

public class Endpoint<T, K>
{
    private T data;

    private string endpoint;

    private ReguestMethod method;

    public Endpoint(T data, HttpMethod method, string endpoint)
    {
        this.data = data;
        this.method = method;
        this.endpoint = endpoint;
    }

    public HttpRequestMessage build()
    {
        switch (method)
        {
        }


        var httpRequestMessage = new HttpRequestMessage(method, NotionBase.baseURL + endpoint);


        return httpRequestMessage;
    }
}