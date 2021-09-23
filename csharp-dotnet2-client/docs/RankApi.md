# IO.Swagger.Api.RankApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RankGet**](RankApi.md#rankget) | **GET** /rank | 
[**RankUserIdGet**](RankApi.md#rankuseridget) | **GET** /rank/{userId} | 


<a name="rankget"></a>
# **RankGet**
> List<Rank> RankGet (int? style, int? game, int? page)



Top ranked players, paged at 50 per page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RankGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new RankApi();
            var style = 56;  // int? | Style ID filter
            var game = 56;  // int? | Game ID filter
            var page = 56;  // int? | Page api results, Page size is 50. (optional) 

            try
            {
                List&lt;Rank&gt; result = apiInstance.RankGet(style, game, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RankApi.RankGet: " + e.Message );
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
 **page** | **int?**| Page api results, Page size is 50. | [optional] 

### Return type

[**List<Rank>**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rankuseridget"></a>
# **RankUserIdGet**
> Rank RankUserIdGet (int? userId, int? style, int? game)



Get rank of user by their id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RankUserIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new RankApi();
            var userId = 56;  // int? | User ID filter
            var style = 56;  // int? | Style ID filter
            var game = 56;  // int? | Game ID filter

            try
            {
                Rank result = apiInstance.RankUserIdGet(userId, style, game);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RankApi.RankUserIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| User ID filter | 
 **style** | **int?**| Style ID filter | 
 **game** | **int?**| Game ID filter | 

### Return type

[**Rank**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

