# Thinkcode.RabbitMQ.OpenAPI.Api.VirtualHostsApi

All URIs are relative to *http://mb1.bus.adaptive.me/rabbitmq/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDefinitionsForVirtualHost**](VirtualHostsApi.md#createdefinitionsforvirtualhost) | **POST** /definitions/{vhost} | Create Definitions for VHost
[**CreateVirtualHost**](VirtualHostsApi.md#createvirtualhost) | **PUT** /vhosts/{vhost} | Create VHost
[**DeleteVirtualHost**](VirtualHostsApi.md#deletevirtualhost) | **DELETE** /vhosts/{vhost} | Delete VHost
[**GetDefinitionsForVirtualHost**](VirtualHostsApi.md#getdefinitionsforvirtualhost) | **GET** /definitions/{vhost} | Get Definitions for VHost
[**GetVirtualHost**](VirtualHostsApi.md#getvirtualhost) | **GET** /vhosts/{vhost} | Read VHost
[**ListVirtualHosts**](VirtualHostsApi.md#listvirtualhosts) | **GET** /vhosts | List VHosts


<a name="createdefinitionsforvirtualhost"></a>
# **CreateDefinitionsForVirtualHost**
> void CreateDefinitionsForVirtualHost (string vhost, Definition body = null)

Create Definitions for VHost

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class CreateDefinitionsForVirtualHostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualHostsApi();
            var vhost = vhost_example;  // string | 
            var body = new Definition(); // Definition |  (optional) 

            try
            {
                // Create Definitions for VHost
                apiInstance.CreateDefinitionsForVirtualHost(vhost, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualHostsApi.CreateDefinitionsForVirtualHost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vhost** | **string**|  | 
 **body** | [**Definition**](Definition.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvirtualhost"></a>
# **CreateVirtualHost**
> void CreateVirtualHost (string vhost)

Create VHost

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class CreateVirtualHostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualHostsApi();
            var vhost = vhost_example;  // string | 

            try
            {
                // Create VHost
                apiInstance.CreateVirtualHost(vhost);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualHostsApi.CreateVirtualHost: " + e.Message );
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

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevirtualhost"></a>
# **DeleteVirtualHost**
> void DeleteVirtualHost (string vhost)

Delete VHost

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class DeleteVirtualHostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualHostsApi();
            var vhost = vhost_example;  // string | 

            try
            {
                // Delete VHost
                apiInstance.DeleteVirtualHost(vhost);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualHostsApi.DeleteVirtualHost: " + e.Message );
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

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefinitionsforvirtualhost"></a>
# **GetDefinitionsForVirtualHost**
> Definition GetDefinitionsForVirtualHost (string vhost)

Get Definitions for VHost

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class GetDefinitionsForVirtualHostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualHostsApi();
            var vhost = vhost_example;  // string | 

            try
            {
                // Get Definitions for VHost
                Definition result = apiInstance.GetDefinitionsForVirtualHost(vhost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualHostsApi.GetDefinitionsForVirtualHost: " + e.Message );
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

[**Definition**](Definition.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvirtualhost"></a>
# **GetVirtualHost**
> VHost GetVirtualHost (string vhost)

Read VHost

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class GetVirtualHostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualHostsApi();
            var vhost = vhost_example;  // string | 

            try
            {
                // Read VHost
                VHost result = apiInstance.GetVirtualHost(vhost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualHostsApi.GetVirtualHost: " + e.Message );
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

[**VHost**](VHost.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvirtualhosts"></a>
# **ListVirtualHosts**
> ICollection<VHost> ListVirtualHosts ()

List VHosts

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListVirtualHostsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualHostsApi();

            try
            {
                // List VHosts
                ICollection&lt;VHost&gt; result = apiInstance.ListVirtualHosts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualHostsApi.ListVirtualHosts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<VHost>**](VHost.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

