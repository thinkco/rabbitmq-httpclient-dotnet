# Thinkcode.RabbitMQ.OpenAPI.Api.PubSubApi

All URIs are relative to *http://mb1.bus.adaptive.me/rabbitmq/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsumeMessage**](PubSubApi.md#consumemessage) | **POST** /queues/{vhost}/{queue}/get | Consume Message
[**PublishMessage**](PubSubApi.md#publishmessage) | **POST** /exchanges/{vhost}/{exchange}/publish | Publish Message


<a name="consumemessage"></a>
# **ConsumeMessage**
> ICollection<ConsumeResponse> ConsumeMessage (string vhost, string queue, ConsumeRequest body = null)

Consume Message

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ConsumeMessageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PubSubApi();
            var vhost = vhost_example;  // string | 
            var queue = queue_example;  // string | 
            var body = new ConsumeRequest(); // ConsumeRequest |  (optional) 

            try
            {
                // Consume Message
                ICollection&lt;ConsumeResponse&gt; result = apiInstance.ConsumeMessage(vhost, queue, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PubSubApi.ConsumeMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vhost** | **string**|  | 
 **queue** | **string**|  | 
 **body** | [**ConsumeRequest**](ConsumeRequest.md)|  | [optional] 

### Return type

[**ICollection<ConsumeResponse>**](ConsumeResponse.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: application/json
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

            var apiInstance = new PubSubApi();
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
                Debug.Print("Exception when calling PubSubApi.PublishMessage: " + e.Message );
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

