# StrafesNetPublicApi.RankApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rankGet**](RankApi.md#rankGet) | **GET** /rank | 
[**rankUserIdGet**](RankApi.md#rankUserIdGet) | **GET** /rank/{userId} | 


<a name="rankGet"></a>
# **rankGet**
> [Rank] rankGet(style, game, opts)



Top ranked players, paged at 50 per page.

### Example
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.RankApi();

var style = 56; // Number | Style ID filter

var game = 56; // Number | Game ID filter

var opts = { 
  'page': 56 // Number | Page api results, Page size is 50.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.rankGet(style, game, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **Number**| Style ID filter | 
 **game** | **Number**| Game ID filter | 
 **page** | **Number**| Page api results, Page size is 50. | [optional] 

### Return type

[**[Rank]**](Rank.md)

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
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.RankApi();

var userId = 56; // Number | User ID filter

var style = 56; // Number | Style ID filter

var game = 56; // Number | Game ID filter


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.rankUserIdGet(userId, style, game, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| User ID filter | 
 **style** | **Number**| Style ID filter | 
 **game** | **Number**| Game ID filter | 

### Return type

[**Rank**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

