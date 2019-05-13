# Thinkcode.RabbitMQ.OpenAPI.Api.UsersApi

All URIs are relative to *http://mb1.bus.adaptive.me/rabbitmq/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](UsersApi.md#createuser) | **PUT** /users/{name} | Create User
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{name} | Delete User
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{name} | Get User
[**GetUserCurrent**](UsersApi.md#getusercurrent) | **GET** /whoami | Get Current User
[**ListUserPermissions**](UsersApi.md#listuserpermissions) | **GET** /users/{user}/permissions | List User Permissions
[**ListUsers**](UsersApi.md#listusers) | **GET** /users | List Users
[**ListUsersWithoutPermissions**](UsersApi.md#listuserswithoutpermissions) | **GET** /users/without-permissions | List Users without Permissions


<a name="createuser"></a>
# **CreateUser**
> void CreateUser (string name, UserRequest body = null)

Create User

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var name = name_example;  // string | 
            var body = new UserRequest(); // UserRequest |  (optional) 

            try
            {
                // Create User
                apiInstance.CreateUser(name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **body** | [**UserRequest**](UserRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string name)

Delete User

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var name = name_example;  // string | 

            try
            {
                // Delete User
                apiInstance.DeleteUser(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> User GetUser (string name)

Get User

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var name = name_example;  // string | 

            try
            {
                // Get User
                User result = apiInstance.GetUser(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusercurrent"></a>
# **GetUserCurrent**
> WhoAmI GetUserCurrent ()

Get Current User

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class GetUserCurrentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();

            try
            {
                // Get Current User
                WhoAmI result = apiInstance.GetUserCurrent();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserCurrent: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WhoAmI**](WhoAmI.md)

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

            var apiInstance = new UsersApi();
            var user = user_example;  // string | 

            try
            {
                // List User Permissions
                ICollection&lt;PermissionUser&gt; result = apiInstance.ListUserPermissions(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListUserPermissions: " + e.Message );
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

<a name="listusers"></a>
# **ListUsers**
> ICollection<PermissionUser> ListUsers ()

List Users

### Example
```csharp
using System;
using System.Diagnostics;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Example
{
    public class ListUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basic_auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();

            try
            {
                // List Users
                ICollection&lt;PermissionUser&gt; result = apiInstance.ListUsers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<PermissionUser>**](PermissionUser.md)

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

            var apiInstance = new UsersApi();

            try
            {
                // List Users without Permissions
                ICollection&lt;User&gt; result = apiInstance.ListUsersWithoutPermissions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListUsersWithoutPermissions: " + e.Message );
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

