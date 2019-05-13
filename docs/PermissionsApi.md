# Thinkcode.RabbitMQ.OpenAPI.Api.PermissionsApi

All URIs are relative to *http://mb1.bus.adaptive.me/rabbitmq/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserPermissions**](PermissionsApi.md#listuserpermissions) | **GET** /users/{user}/permissions | List User Permissions
[**ListUsersTopicPermissions**](PermissionsApi.md#listuserstopicpermissions) | **GET** /users/{user}/topic-permissions | List Users Topic Permissions
[**ListUsersWithoutPermissions**](PermissionsApi.md#listuserswithoutpermissions) | **GET** /users/without-permissions | List Users without Permissions


<a name="listuserpermissions"></a>
# **ListUserPermissions**
> ICollection<PermissionUser> ListUserPermissions (string user)

List User Permissions

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListUserPermissionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PermissionsApi();
            var user = user_example;  // string | 

            try
            {
                // List User Permissions
                ICollection&lt;PermissionUser&gt; result = apiInstance.ListUserPermissions(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.ListUserPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **string**|  | 

### Return type

[**ICollection<PermissionUser>**](PermissionUser.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listuserstopicpermissions"></a>
# **ListUsersTopicPermissions**
> ICollection<PermissionTopic> ListUsersTopicPermissions (string user)

List Users Topic Permissions

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListUsersTopicPermissionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PermissionsApi();
            var user = user_example;  // string | 

            try
            {
                // List Users Topic Permissions
                ICollection&lt;PermissionTopic&gt; result = apiInstance.ListUsersTopicPermissions(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.ListUsersTopicPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **string**|  | 

### Return type

[**ICollection<PermissionTopic>**](PermissionTopic.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listuserswithoutpermissions"></a>
# **ListUsersWithoutPermissions**
> ICollection<User> ListUsersWithoutPermissions ()

List Users without Permissions

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListUsersWithoutPermissionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PermissionsApi();

            try
            {
                // List Users without Permissions
                ICollection&lt;User&gt; result = apiInstance.ListUsersWithoutPermissions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.ListUsersWithoutPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<User>**](User.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

