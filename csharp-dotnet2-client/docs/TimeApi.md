# IO.Swagger.Api.TimeApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimeMapMapIdGet**](TimeApi.md#timemapmapidget) | **GET** /time/map/{mapId} | 
[**TimeMapMapIdWrGet**](TimeApi.md#timemapmapidwrget) | **GET** /time/map/{mapId}/wr | 
[**TimeRecentGet**](TimeApi.md#timerecentget) | **GET** /time/recent | 
[**TimeRecentWrGet**](TimeApi.md#timerecentwrget) | **GET** /time/recent/wr | 
[**TimeTimeIdGet**](TimeApi.md#timetimeidget) | **GET** /time/{timeId} | 
[**TimeTimeIdRankGet**](TimeApi.md#timetimeidrankget) | **GET** /time/{timeId}/rank | 
[**TimeUserUserIdGet**](TimeApi.md#timeuseruseridget) | **GET** /time/user/{userId} | 
[**TimeUserUserIdWrGet**](TimeApi.md#timeuseruseridwrget) | **GET** /time/user/{userId}/wr | 


<a name="timemapmapidget"></a>
# **TimeMapMapIdGet**
> List<Time> TimeMapMapIdGet (int? mapId, int? style, int? page)



Time by map id. Sorted in ascending order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeMapMapIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TimeApi();
            var mapId = 56;  // int? | Map ID filter
            var style = 56;  // int? | Style ID filter (optional) 
            var page = 56;  // int? | Page api results. Page size is 200. (optional) 

            try
            {
                List&lt;Time&gt; result = apiInstance.TimeMapMapIdGet(mapId, style, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeApi.TimeMapMapIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **int?**| Map ID filter | 
 **style** | **int?**| Style ID filter | [optional] 
 **page** | **int?**| Page api results. Page size is 200. | [optional] 

### Return type

[**List<Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timemapmapidwrget"></a>
# **TimeMapMapIdWrGet**
> Time TimeMapMapIdWrGet (int? mapId, int? style)



Get WR of map.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeMapMapIdWrGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TimeApi();
            var mapId = 56;  // int? | Map ID filter
            var style = 56;  // int? | Style ID filter

            try
            {
                Time result = apiInstance.TimeMapMapIdWrGet(mapId, style);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeApi.TimeMapMapIdWrGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **int?**| Map ID filter | 
 **style** | **int?**| Style ID filter | 

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timerecentget"></a>
# **TimeRecentGet**
> List<Time> TimeRecentGet (int? date, int? style, int? game, int? map)



50 recent times.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeRecentGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TimeApi();
            var date = 56;  // int? | Filter out all times before unix time stamp. (optional) 
            var style = 56;  // int? | Style ID filter (optional) 
            var game = 56;  // int? | Game ID filter (optional) 
            var map = 56;  // int? | Map ID filter (optional) 

            try
            {
                List&lt;Time&gt; result = apiInstance.TimeRecentGet(date, style, game, map);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeApi.TimeRecentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **int?**| Filter out all times before unix time stamp. | [optional] 
 **style** | **int?**| Style ID filter | [optional] 
 **game** | **int?**| Game ID filter | [optional] 
 **map** | **int?**| Map ID filter | [optional] 

### Return type

[**List<Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timerecentwrget"></a>
# **TimeRecentWrGet**
> List<Time> TimeRecentWrGet (int? style, int? game, bool? whitelist)



10 recent world records.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeRecentWrGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TimeApi();
            var style = 56;  // int? | Style ID filter
            var game = 56;  // int? | Game ID filter
            var whitelist = true;  // bool? | Filters for only players on the whitelist (optional) 

            try
            {
                List&lt;Time&gt; result = apiInstance.TimeRecentWrGet(style, game, whitelist);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeApi.TimeRecentWrGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **int?**| Style ID filter | 
 **game** | **int?**| Game ID filter | 
 **whitelist** | **bool?**| Filters for only players on the whitelist | [optional] 

### Return type

[**List<Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timetimeidget"></a>
# **TimeTimeIdGet**
> Time TimeTimeIdGet (int? timeId)



Time from id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeTimeIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TimeApi();
            var timeId = 56;  // int? | Time ID filter

            try
            {
                Time result = apiInstance.TimeTimeIdGet(timeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeApi.TimeTimeIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeId** | **int?**| Time ID filter | 

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timetimeidrankget"></a>
# **TimeTimeIdRankGet**
> Object TimeTimeIdRankGet (int? timeId)



Time rank from id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeTimeIdRankGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TimeApi();
            var timeId = 56;  // int? | Time ID filter

            try
            {
                Object result = apiInstance.TimeTimeIdRankGet(timeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeApi.TimeTimeIdRankGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeId** | **int?**| Time ID filter | 

### Return type

**Object**

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeuseruseridget"></a>
# **TimeUserUserIdGet**
> List<Time> TimeUserUserIdGet (int? userId, int? map, int? style, int? game, int? page)



Time by user id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeUserUserIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TimeApi();
            var userId = 56;  // int? | User ID filter
            var map = 56;  // int? | Map ID filter (optional) 
            var style = 56;  // int? | Style ID filter (optional) 
            var game = 56;  // int? | Game ID filter (optional) 
            var page = 56;  // int? | Page api results. Page size is 200. (optional) 

            try
            {
                List&lt;Time&gt; result = apiInstance.TimeUserUserIdGet(userId, map, style, game, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeApi.TimeUserUserIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| User ID filter | 
 **map** | **int?**| Map ID filter | [optional] 
 **style** | **int?**| Style ID filter | [optional] 
 **game** | **int?**| Game ID filter | [optional] 
 **page** | **int?**| Page api results. Page size is 200. | [optional] 

### Return type

[**List<Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeuseruseridwrget"></a>
# **TimeUserUserIdWrGet**
> List<Time> TimeUserUserIdWrGet (int? userId, int? game, int? style)



World records by user id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeUserUserIdWrGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TimeApi();
            var userId = 56;  // int? | User ID filter
            var game = 56;  // int? | Game ID filter
            var style = 56;  // int? | Style ID filter

            try
            {
                List&lt;Time&gt; result = apiInstance.TimeUserUserIdWrGet(userId, game, style);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeApi.TimeUserUserIdWrGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| User ID filter | 
 **game** | **int?**| Game ID filter | 
 **style** | **int?**| Style ID filter | 

### Return type

[**List<Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

