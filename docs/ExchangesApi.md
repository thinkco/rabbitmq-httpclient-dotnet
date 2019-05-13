# Thinkcode.RabbitMQ.OpenAPI.Api.ExchangesApi

All URIs are relative to *http://mb1.bus.adaptive.me/rabbitmq/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateExchange**](ExchangesApi.md#createexchange) | **PUT** /exchanges/{vhost}/{exchange} | Create Exchange
[**DeleteExchange**](ExchangesApi.md#deleteexchange) | **DELETE** /exchanges/{vhost}/{exchange} | Delete Exchange
[**GetExchange**](ExchangesApi.md#getexchange) | **GET** /exchanges/{vhost}/{exchange} | Read Exchange
[**ListExchanges**](ExchangesApi.md#listexchanges) | **GET** /exchanges | List Exchanges
[**ListExchangesForHost**](ExchangesApi.md#listexchangesforhost) | **GET** /exchanges/{vhost} | List Exchanges for VHost
[**PublishMessage**](ExchangesApi.md#publishmessage) | **POST** /exchanges/{vhost}/{exchange}/publish | Publish Message


<a name="createexchange"></a>
# **CreateExchange**
> void CreateExchange (string vhost, string exchange, ExchangeRequest body = null)

Create Exchange

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class CreateExchangeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExchangesApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 
            var body = new ExchangeRequest(); // ExchangeRequest |  (optional) 

            try
            {
                // Create Exchange
                apiInstance.CreateExchange(vhost, exchange, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.CreateExchange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vhost** | **string**|  | 
 **exchange** | **string**|  | 
 **body** | [**ExchangeRequest**](ExchangeRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexchange"></a>
# **DeleteExchange**
> void DeleteExchange (string vhost, string exchange)

Delete Exchange

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class DeleteExchangeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExchangesApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 

            try
            {
                // Delete Exchange
                apiInstance.DeleteExchange(vhost, exchange);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.DeleteExchange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vhost** | **string**|  | 
 **exchange** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexchange"></a>
# **GetExchange**
> Exchange GetExchange (string vhost, string exchange)

Read Exchange

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class GetExchangeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExchangesApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 

            try
            {
                // Read Exchange
                Exchange result = apiInstance.GetExchange(vhost, exchange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.GetExchange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vhost** | **string**|  | 
 **exchange** | **string**|  | 

### Return type

[**Exchange**](Exchange.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listexchanges"></a>
# **ListExchanges**
> ICollection<Exchange> ListExchanges ()

List Exchanges

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListExchangesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExchangesApi();

            try
            {
                // List Exchanges
                ICollection&lt;Exchange&gt; result = apiInstance.ListExchanges();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.ListExchanges: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<Exchange>**](Exchange.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listexchangesforhost"></a>
# **ListExchangesForHost**
> ICollection<Exchange> ListExchangesForHost (string vhost)

List Exchanges for VHost

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListExchangesForHostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExchangesApi();
            var vhost = vhost_example;  // string | 

            try
            {
                // List Exchanges for VHost
                ICollection&lt;Exchange&gt; result = apiInstance.ListExchangesForHost(vhost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.ListExchangesForHost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vhost** | **string**|  | 

### Return type

[**ICollection<Exchange>**](Exchange.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishmessage"></a>
# **PublishMessage**
> PublishResponse PublishMessage (string vhost, string exchange, PublishRequest body = null)

Publish Message

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class PublishMessageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExchangesApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 
            var body = new PublishRequest(); // PublishRequest |  (optional) 

            try
            {
                // Publish Message
                PublishResponse result = apiInstance.PublishMessage(vhost, exchange, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.PublishMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vhost** | **string**|  | 
 **exchange** | **string**|  | 
 **body** | [**PublishRequest**](PublishRequest.md)|  | [optional] 

### Return type

[**PublishResponse**](PublishResponse.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

