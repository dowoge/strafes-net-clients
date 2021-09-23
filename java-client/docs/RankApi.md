# RankApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rankGet**](RankApi.md#rankGet) | **GET** /rank | 
[**rankUserIdGet**](RankApi.md#rankUserIdGet) | **GET** /rank/{userId} | 


<a name="rankGet"></a>
# **rankGet**
> List&lt;Rank&gt; rankGet(style, game, page)



Top ranked players, paged at 50 per page.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.RankApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

RankApi apiInstance = new RankApi();
Integer style = 56; // Integer | Style ID filter
Integer game = 56; // Integer | Game ID filter
Integer page = 56; // Integer | Page api results, Page size is 50.
try {
    List<Rank> result = apiInstance.rankGet(style, game, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling RankApi#rankGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **Integer**| Style ID filter |
 **game** | **Integer**| Game ID filter |
 **page** | **Integer**| Page api results, Page size is 50. | [optional]

### Return type

[**List&lt;Rank&gt;**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="rankUserIdGet"></a>
# **rankUserIdGet**
> Rank rankUserIdGet(userId, style, game)



Get rank of user by their id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.RankApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

RankApi apiInstance = new RankApi();
Integer userId = 56; // Integer | User ID filter
Integer style = 56; // Integer | Style ID filter
Integer game = 56; // Integer | Game ID filter
try {
    Rank result = apiInstance.rankUserIdGet(userId, style, game);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling RankApi#rankUserIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Integer**| User ID filter |
 **style** | **Integer**| Style ID filter |
 **game** | **Integer**| Game ID filter |

### Return type

[**Rank**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

