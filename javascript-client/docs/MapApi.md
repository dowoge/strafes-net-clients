# StrafesNetPublicApi.MapApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mapGet**](MapApi.md#mapGet) | **GET** /map | 
[**mapMapIdGet**](MapApi.md#mapMapIdGet) | **GET** /map/{mapId} | 


<a name="mapGet"></a>
# **mapGet**
> [Map] mapGet(opts)



Get list of maps.

### Example
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.MapApi();

var opts = { 
  'game': 56, // Number | Game ID filter
  'page': 56 // Number | Page api results. Page size is 200.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.mapGet(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **game** | **Number**| Game ID filter | [optional] 
 **page** | **Number**| Page api results. Page size is 200. | [optional] 

### Return type

[**[Map]**](Map.md)

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
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.MapApi();

var mapId = 56; // Number | Map ID filter


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.mapMapIdGet(mapId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **Number**| Map ID filter | 

### Return type

[**Map**](Map.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

