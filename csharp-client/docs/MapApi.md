# IO.Swagger.Api.MapApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MapGet**](MapApi.md#mapget) | **GET** /map | 
[**MapMapIdGet**](MapApi.md#mapmapidget) | **GET** /map/{mapId} | 


<a name="mapget"></a>
# **MapGet**
> List<Dictionary> MapGet (int? game = null, int? page = null)



Get list of maps.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MapApi();
            var game = 56;  // int? | Game ID filter (optional) 
            var page = 56;  // int? | Page api results. Page size is 200. (optional) 

            try
            {
                List&lt;Dictionary&gt; result = apiInstance.MapGet(game, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **game** | **int?**| Game ID filter | [optional] 
 **page** | **int?**| Page api results. Page size is 200. | [optional] 

### Return type

**List<Dictionary>**

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapmapidget"></a>
# **MapMapIdGet**
> Dictionary MapMapIdGet (int? mapId)



Get map by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapMapIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MapApi();
            var mapId = 56;  // int? | Map ID filter

            try
            {
                Dictionary result = apiInstance.MapMapIdGet(mapId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.MapMapIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **int?**| Map ID filter | 

### Return type

**Dictionary**

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

