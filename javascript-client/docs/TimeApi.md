# StrafesNetPublicApi.TimeApi

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
> [Time] timeMapMapIdGet(mapId, opts)



Time by map id. Sorted in ascending order.

### Example
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.TimeApi();

var mapId = 56; // Number | Map ID filter

var opts = { 
  'style': 56, // Number | Style ID filter
  'page': 56 // Number | Page api results. Page size is 200.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.timeMapMapIdGet(mapId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **Number**| Map ID filter | 
 **style** | **Number**| Style ID filter | [optional] 
 **page** | **Number**| Page api results. Page size is 200. | [optional] 

### Return type

[**[Time]**](Time.md)

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
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.TimeApi();

var mapId = 56; // Number | Map ID filter

var style = 56; // Number | Style ID filter


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.timeMapMapIdWrGet(mapId, style, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **Number**| Map ID filter | 
 **style** | **Number**| Style ID filter | 

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeRecentGet"></a>
# **timeRecentGet**
> [Time] timeRecentGet(opts)



50 recent times.

### Example
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.TimeApi();

var opts = { 
  '_date': 56, // Number | Filter out all times before unix time stamp.
  'style': 56, // Number | Style ID filter
  'game': 56, // Number | Game ID filter
  'map': 56 // Number | Map ID filter
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.timeRecentGet(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_date** | **Number**| Filter out all times before unix time stamp. | [optional] 
 **style** | **Number**| Style ID filter | [optional] 
 **game** | **Number**| Game ID filter | [optional] 
 **map** | **Number**| Map ID filter | [optional] 

### Return type

[**[Time]**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeRecentWrGet"></a>
# **timeRecentWrGet**
> [Time] timeRecentWrGet(style, game, opts)



10 recent world records.

### Example
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.TimeApi();

var style = 56; // Number | Style ID filter

var game = 56; // Number | Game ID filter

var opts = { 
  'whitelist': true // Boolean | Filters for only players on the whitelist
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.timeRecentWrGet(style, game, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **Number**| Style ID filter | 
 **game** | **Number**| Game ID filter | 
 **whitelist** | **Boolean**| Filters for only players on the whitelist | [optional] 

### Return type

[**[Time]**](Time.md)

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
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.TimeApi();

var timeId = 56; // Number | Time ID filter


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.timeTimeIdGet(timeId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeId** | **Number**| Time ID filter | 

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
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.TimeApi();

var timeId = 56; // Number | Time ID filter


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.timeTimeIdRankGet(timeId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeId** | **Number**| Time ID filter | 

### Return type

**Object**

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeUserUserIdGet"></a>
# **timeUserUserIdGet**
> [Time] timeUserUserIdGet(userId, opts)



Time by user id.

### Example
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.TimeApi();

var userId = 56; // Number | User ID filter

var opts = { 
  'map': 56, // Number | Map ID filter
  'style': 56, // Number | Style ID filter
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
apiInstance.timeUserUserIdGet(userId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| User ID filter | 
 **map** | **Number**| Map ID filter | [optional] 
 **style** | **Number**| Style ID filter | [optional] 
 **game** | **Number**| Game ID filter | [optional] 
 **page** | **Number**| Page api results. Page size is 200. | [optional] 

### Return type

[**[Time]**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="timeUserUserIdWrGet"></a>
# **timeUserUserIdWrGet**
> [Time] timeUserUserIdWrGet(userId, game, style)



World records by user id.

### Example
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.TimeApi();

var userId = 56; // Number | User ID filter

var game = 56; // Number | Game ID filter

var style = 56; // Number | Style ID filter


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.timeUserUserIdWrGet(userId, game, style, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| User ID filter | 
 **game** | **Number**| Game ID filter | 
 **style** | **Number**| Style ID filter | 

### Return type

[**[Time]**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

