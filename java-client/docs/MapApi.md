# MapApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mapGet**](MapApi.md#mapGet) | **GET** /map | 
[**mapMapIdGet**](MapApi.md#mapMapIdGet) | **GET** /map/{mapId} | 


<a name="mapGet"></a>
# **mapGet**
> List&lt;Map&gt; mapGet(game, page)



Get list of maps.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.MapApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

MapApi apiInstance = new MapApi();
Integer game = 56; // Integer | Game ID filter
Integer page = 56; // Integer | Page api results. Page size is 200.
try {
    List<Map> result = apiInstance.mapGet(game, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling MapApi#mapGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **game** | **Integer**| Game ID filter | [optional]
 **page** | **Integer**| Page api results. Page size is 200. | [optional]

### Return type

[**List&lt;Map&gt;**](Map.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mapMapIdGet"></a>
# **mapMapIdGet**
> Map mapMapIdGet(mapId)



Get map by ID.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.MapApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

MapApi apiInstance = new MapApi();
Integer mapId = 56; // Integer | Map ID filter
try {
    Map result = apiInstance.mapMapIdGet(mapId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling MapApi#mapMapIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **Integer**| Map ID filter |

### Return type

[**Map**](Map.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

