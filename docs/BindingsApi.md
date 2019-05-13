# Thinkcode.RabbitMQ.OpenAPI.Api.BindingsApi

All URIs are relative to *http://mb1.bus.adaptive.me/rabbitmq/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBindingsForQueueExchange**](BindingsApi.md#createbindingsforqueueexchange) | **POST** /bindings/{vhost}/e/{exchange}/q/{queue} | Create Bindings for Queue
[**DeleteBindingForQueueExchange**](BindingsApi.md#deletebindingforqueueexchange) | **DELETE** /bindings/{vhost}/e/{exchange}/q/{queue}/{propertyKey} | Delete Binding for Queue
[**GetBindingForQueueExchange**](BindingsApi.md#getbindingforqueueexchange) | **GET** /bindings/{vhost}/e/{exchange}/q/{queue}/{propertyKey} | Get Binding for Queue
[**ListBindings**](BindingsApi.md#listbindings) | **GET** /bindings | List Bindings
[**ListBindingsAsDestination**](BindingsApi.md#listbindingsasdestination) | **GET** /exchanges/{vhost}/{exchange}/bindings/destination | List Bindings as Destination
[**ListBindingsAsSource**](BindingsApi.md#listbindingsassource) | **GET** /exchanges/{vhost}/{exchange}/bindings/source | List Bindings as Source
[**ListBindingsForQueue**](BindingsApi.md#listbindingsforqueue) | **GET** /queues/{vhost}/{queue}/bindings | List All Bindings for Queue
[**ListBindingsForQueueExchange**](BindingsApi.md#listbindingsforqueueexchange) | **GET** /bindings/{vhost}/e/{exchange}/q/{queue} | List Bindings for Queue


<a name="createbindingsforqueueexchange"></a>
# **CreateBindingsForQueueExchange**
> void CreateBindingsForQueueExchange (string vhost, string exchange, string queue, BindingRequest body = null)

Create Bindings for Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class CreateBindingsForQueueExchangeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 
            var queue = queue_example;  // string | 
            var body = new BindingRequest(); // BindingRequest |  (optional) 

            try
            {
                // Create Bindings for Queue
                apiInstance.CreateBindingsForQueueExchange(vhost, exchange, queue, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.CreateBindingsForQueueExchange: " + e.Message );
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
 **queue** | **string**|  | 
 **body** | [**BindingRequest**](BindingRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebindingforqueueexchange"></a>
# **DeleteBindingForQueueExchange**
> void DeleteBindingForQueueExchange (string vhost, string exchange, string queue, string propertyKey)

Delete Binding for Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class DeleteBindingForQueueExchangeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 
            var queue = queue_example;  // string | 
            var propertyKey = propertyKey_example;  // string | 

            try
            {
                // Delete Binding for Queue
                apiInstance.DeleteBindingForQueueExchange(vhost, exchange, queue, propertyKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.DeleteBindingForQueueExchange: " + e.Message );
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
 **queue** | **string**|  | 
 **propertyKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbindingforqueueexchange"></a>
# **GetBindingForQueueExchange**
> Binding GetBindingForQueueExchange (string vhost, string exchange, string queue, string propertyKey)

Get Binding for Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class GetBindingForQueueExchangeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 
            var queue = queue_example;  // string | 
            var propertyKey = propertyKey_example;  // string | 

            try
            {
                // Get Binding for Queue
                Binding result = apiInstance.GetBindingForQueueExchange(vhost, exchange, queue, propertyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.GetBindingForQueueExchange: " + e.Message );
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
 **queue** | **string**|  | 
 **propertyKey** | **string**|  | 

### Return type

[**Binding**](Binding.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbindings"></a>
# **ListBindings**
> ICollection<Binding> ListBindings ()

List Bindings

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListBindingsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();

            try
            {
                // List Bindings
                ICollection&lt;Binding&gt; result = apiInstance.ListBindings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.ListBindings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<Binding>**](Binding.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbindingsasdestination"></a>
# **ListBindingsAsDestination**
> ICollection<Binding> ListBindingsAsDestination (string vhost, string exchange)

List Bindings as Destination

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListBindingsAsDestinationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 

            try
            {
                // List Bindings as Destination
                ICollection&lt;Binding&gt; result = apiInstance.ListBindingsAsDestination(vhost, exchange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.ListBindingsAsDestination: " + e.Message );
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

[**ICollection<Binding>**](Binding.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbindingsassource"></a>
# **ListBindingsAsSource**
> ICollection<Binding> ListBindingsAsSource (string vhost, string exchange)

List Bindings as Source

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListBindingsAsSourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 

            try
            {
                // List Bindings as Source
                ICollection&lt;Binding&gt; result = apiInstance.ListBindingsAsSource(vhost, exchange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.ListBindingsAsSource: " + e.Message );
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

[**ICollection<Binding>**](Binding.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbindingsforqueue"></a>
# **ListBindingsForQueue**
> ICollection<Binding> ListBindingsForQueue (string vhost, string queue)

List All Bindings for Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListBindingsForQueueExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();
            var vhost = vhost_example;  // string | 
            var queue = queue_example;  // string | 

            try
            {
                // List All Bindings for Queue
                ICollection&lt;Binding&gt; result = apiInstance.ListBindingsForQueue(vhost, queue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.ListBindingsForQueue: " + e.Message );
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

### Return type

[**ICollection<Binding>**](Binding.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbindingsforqueueexchange"></a>
# **ListBindingsForQueueExchange**
> ICollection<Binding> ListBindingsForQueueExchange (string vhost, string exchange, string queue)

List Bindings for Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListBindingsForQueueExchangeExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BindingsApi();
            var vhost = vhost_example;  // string | 
            var exchange = exchange_example;  // string | 
            var queue = queue_example;  // string | 

            try
            {
                // List Bindings for Queue
                ICollection&lt;Binding&gt; result = apiInstance.ListBindingsForQueueExchange(vhost, exchange, queue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindingsApi.ListBindingsForQueueExchange: " + e.Message );
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
 **queue** | **string**|  | 

### Return type

[**ICollection<Binding>**](Binding.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

