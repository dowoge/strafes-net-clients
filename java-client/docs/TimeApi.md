# TimeApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**timeMapMapIdGet**](TimeApi.md#timeMapMapIdGet) | **GET** /time/map/{mapId} | 
[**timeMapMapIdWrGet**](TimeApi.md#timeMapMapIdWrGet) | **GET** /time/map/{mapId}/wr | 
[**timeRecentGet**](TimeApi.md#timeRecentGet) | **GET** /time/recent | 
[**timeRecentWrGet**](TimeApi.md#timeRecentWrGet) | **GET** /time/recent/wr | 
[**timeTimeIdGet**](TimeApi.md#timeTimeIdGet) | **GET** /time/{timeId} | 
[**timeTimeIdRankGet**](TimeApi.md#timeTimeIdRankGet) | **GET** /time/{timeId}/rank | 
[**timeUserUserIdGet**](TimeApi.md#timeUserUserIdGet) | **GET** /time/user/{userId} | 
[**timeUserUserIdWrGet**](TimeApi.md#timeUserUserIdWrGet) | **GET** /time/user/{userId}/wr | 


<a name="timeMapMapIdGet"></a>
# **timeMapMapIdGet**
> List&lt;Time&gt; timeMapMapIdGet(mapId, style, page)



Time by map id. Sorted in ascending order.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TimeApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

TimeApi apiInstance = new TimeApi();
Integer mapId = 56; // Integer | Map ID filter
Integer style = 56; // Integer | Style ID filter
Integer page = 56; // Integer | Page api results. Page size is 200.
try {
    List<Time> result = apiInstance.timeMapMapIdGet(mapId, style, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TimeApi#timeMapMapIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **Integer**| Map ID filter |
 **style** | **Integer**| Style ID filter | [optional]
 **page** | **Integer**| Page api results. Page size is 200. | [optional]

### Return type

[**List&lt;Time&gt;**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeMapMapIdWrGet"></a>
# **timeMapMapIdWrGet**
> Time timeMapMapIdWrGet(mapId, style)



Get WR of map.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TimeApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

TimeApi apiInstance = new TimeApi();
Integer mapId = 56; // Integer | Map ID filter
Integer style = 56; // Integer | Style ID filter
try {
    Time result = apiInstance.timeMapMapIdWrGet(mapId, style);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TimeApi#timeMapMapIdWrGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **Integer**| Map ID filter |
 **style** | **Integer**| Style ID filter |

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeRecentGet"></a>
# **timeRecentGet**
> List&lt;Time&gt; timeRecentGet(date, style, game, map)



50 recent times.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TimeApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

TimeApi apiInstance = new TimeApi();
Integer date = 56; // Integer | Filter out all times before unix time stamp.
Integer style = 56; // Integer | Style ID filter
Integer game = 56; // Integer | Game ID filter
Integer map = 56; // Integer | Map ID filter
try {
    List<Time> result = apiInstance.timeRecentGet(date, style, game, map);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TimeApi#timeRecentGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **Integer**| Filter out all times before unix time stamp. | [optional]
 **style** | **Integer**| Style ID filter | [optional]
 **game** | **Integer**| Game ID filter | [optional]
 **map** | **Integer**| Map ID filter | [optional]

### Return type

[**List&lt;Time&gt;**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeRecentWrGet"></a>
# **timeRecentWrGet**
> List&lt;Time&gt; timeRecentWrGet(style, game, whitelist)



10 recent world records.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TimeApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

TimeApi apiInstance = new TimeApi();
Integer style = 56; // Integer | Style ID filter
Integer game = 56; // Integer | Game ID filter
Boolean whitelist = true; // Boolean | Filters for only players on the whitelist
try {
    List<Time> result = apiInstance.timeRecentWrGet(style, game, whitelist);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TimeApi#timeRecentWrGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **Integer**| Style ID filter |
 **game** | **Integer**| Game ID filter |
 **whitelist** | **Boolean**| Filters for only players on the whitelist | [optional]

### Return type

[**List&lt;Time&gt;**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeTimeIdGet"></a>
# **timeTimeIdGet**
> Time timeTimeIdGet(timeId)



Time from id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TimeApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

TimeApi apiInstance = new TimeApi();
Integer timeId = 56; // Integer | Time ID filter
try {
    Time result = apiInstance.timeTimeIdGet(timeId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TimeApi#timeTimeIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeId** | **Integer**| Time ID filter |

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeTimeIdRankGet"></a>
# **timeTimeIdRankGet**
> Object timeTimeIdRankGet(timeId)



Time rank from id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TimeApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

TimeApi apiInstance = new TimeApi();
Integer timeId = 56; // Integer | Time ID filter
try {
    Object result = apiInstance.timeTimeIdRankGet(timeId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TimeApi#timeTimeIdRankGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeId** | **Integer**| Time ID filter |

### Return type

**Object**

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeUserUserIdGet"></a>
# **timeUserUserIdGet**
> List&lt;Time&gt; timeUserUserIdGet(userId, map, style, game, page)



Time by user id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TimeApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

TimeApi apiInstance = new TimeApi();
Integer userId = 56; // Integer | User ID filter
Integer map = 56; // Integer | Map ID filter
Integer style = 56; // Integer | Style ID filter
Integer game = 56; // Integer | Game ID filter
Integer page = 56; // Integer | Page api results. Page size is 200.
try {
    List<Time> result = apiInstance.timeUserUserIdGet(userId, map, style, game, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TimeApi#timeUserUserIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Integer**| User ID filter |
 **map** | **Integer**| Map ID filter | [optional]
 **style** | **Integer**| Style ID filter | [optional]
 **game** | **Integer**| Game ID filter | [optional]
 **page** | **Integer**| Page api results. Page size is 200. | [optional]

### Return type

[**List&lt;Time&gt;**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeUserUserIdWrGet"></a>
# **timeUserUserIdWrGet**
> List&lt;Time&gt; timeUserUserIdWrGet(userId, game, style)



World records by user id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TimeApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: api-key
ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
api-key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.setApiKeyPrefix("Token");

TimeApi apiInstance = new TimeApi();
Integer userId = 56; // Integer | User ID filter
Integer game = 56; // Integer | Game ID filter
Integer style = 56; // Integer | Style ID filter
try {
    List<Time> result = apiInstance.timeUserUserIdWrGet(userId, game, style);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TimeApi#timeUserUserIdWrGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Integer**| User ID filter |
 **game** | **Integer**| Game ID filter |
 **style** | **Integer**| Style ID filter |

### Return type

[**List&lt;Time&gt;**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

