# Thinkcode.RabbitMQ.OpenAPI.Api.QueuesApi

All URIs are relative to *http://mb1.bus.adaptive.me/rabbitmq/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsumeMessage**](QueuesApi.md#consumemessage) | **POST** /queues/{vhost}/{queue}/get | Consume Message
[**CreateQueue**](QueuesApi.md#createqueue) | **PUT** /queues/{vhost}/{queue} | Create Queue
[**CreateQueueActions**](QueuesApi.md#createqueueactions) | **POST** /queues/{vhost}/{queue}/actions | Create Actions for Queue
[**DeleteQueue**](QueuesApi.md#deletequeue) | **DELETE** /queues/{vhost}/{queue} | Delete Queue
[**DeleteQueueContents**](QueuesApi.md#deletequeuecontents) | **DELETE** /queues/{vhost}/{queue}/contents | Delete Queue Contents (Purge)
[**GetQueue**](QueuesApi.md#getqueue) | **GET** /queues/{vhost}/{queue} | Get Queue
[**ListBindingsForQueue**](QueuesApi.md#listbindingsforqueue) | **GET** /queues/{vhost}/{queue}/bindings | List All Bindings for Queue
[**ListQueues**](QueuesApi.md#listqueues) | **GET** /queues | List Queues
[**ListQueuesForVirtualHost**](QueuesApi.md#listqueuesforvirtualhost) | **GET** /queues/{vhost} | List Queues for VHost


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

            var apiInstance = new QueuesApi();
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
                Debug.Print("Exception when calling QueuesApi.ConsumeMessage: " + e.Message );
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

<a name="createqueue"></a>
# **CreateQueue**
> void CreateQueue (string vhost, string queue, QueueRequest body = null)

Create Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class CreateQueueExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new QueuesApi();
            var vhost = vhost_example;  // string | 
            var queue = queue_example;  // string | 
            var body = new QueueRequest(); // QueueRequest |  (optional) 

            try
            {
                // Create Queue
                apiInstance.CreateQueue(vhost, queue, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.CreateQueue: " + e.Message );
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
 **body** | [**QueueRequest**](QueueRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createqueueactions"></a>
# **CreateQueueActions**
> void CreateQueueActions (string vhost, string queue, QueueAction body = null)

Create Actions for Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class CreateQueueActionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new QueuesApi();
            var vhost = vhost_example;  // string | 
            var queue = queue_example;  // string | 
            var body = new QueueAction(); // QueueAction |  (optional) 

            try
            {
                // Create Actions for Queue
                apiInstance.CreateQueueActions(vhost, queue, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.CreateQueueActions: " + e.Message );
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
 **body** | [**QueueAction**](QueueAction.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequeue"></a>
# **DeleteQueue**
> void DeleteQueue (string vhost, string queue, bool? ifEmpty = null, bool? ifUnused = null)

Delete Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class DeleteQueueExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new QueuesApi();
            var vhost = vhost_example;  // string | 
            var queue = queue_example;  // string | 
            var ifEmpty = true;  // bool? |  (optional)  (default to true)
            var ifUnused = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Delete Queue
                apiInstance.DeleteQueue(vhost, queue, ifEmpty, ifUnused);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.DeleteQueue: " + e.Message );
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
 **ifEmpty** | **bool?**|  | [optional] [default to true]
 **ifUnused** | **bool?**|  | [optional] [default to true]

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequeuecontents"></a>
# **DeleteQueueContents**
> void DeleteQueueContents (string vhost, string queue)

Delete Queue Contents (Purge)

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class DeleteQueueContentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new QueuesApi();
            var vhost = vhost_example;  // string | 
            var queue = queue_example;  // string | 

            try
            {
                // Delete Queue Contents (Purge)
                apiInstance.DeleteQueueContents(vhost, queue);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.DeleteQueueContents: " + e.Message );
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

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueue"></a>
# **GetQueue**
> Queue GetQueue (string vhost, string queue)

Get Queue

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class GetQueueExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new QueuesApi();
            var vhost = vhost_example;  // string | 
            var queue = queue_example;  // string | 

            try
            {
                // Get Queue
                Queue result = apiInstance.GetQueue(vhost, queue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.GetQueue: " + e.Message );
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

[**Queue**](Queue.md)

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

            var apiInstance = new QueuesApi();
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
                Debug.Print("Exception when calling QueuesApi.ListBindingsForQueue: " + e.Message );
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

<a name="listqueues"></a>
# **ListQueues**
> ICollection<Queue> ListQueues ()

List Queues

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListQueuesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new QueuesApi();

            try
            {
                // List Queues
                ICollection&lt;Queue&gt; result = apiInstance.ListQueues();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.ListQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<Queue>**](Queue.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listqueuesforvirtualhost"></a>
# **ListQueuesForVirtualHost**
> ICollection<Queue> ListQueuesForVirtualHost (string vhost)

List Queues for VHost

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListQueuesForVirtualHostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new QueuesApi();
            var vhost = vhost_example;  // string | 

            try
            {
                // List Queues for VHost
                ICollection&lt;Queue&gt; result = apiInstance.ListQueuesForVirtualHost(vhost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueuesApi.ListQueuesForVirtualHost: " + e.Message );
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

[**ICollection<Queue>**](Queue.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

