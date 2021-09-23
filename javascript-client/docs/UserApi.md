# StrafesNetPublicApi.UserApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userUserIdGet**](UserApi.md#userUserIdGet) | **GET** /user/{userId} | 


<a name="userUserIdGet"></a>
# **userUserIdGet**
> User userUserIdGet(userId)



User from id.

### Example
```javascript
var StrafesNetPublicApi = require('strafes_net_public_api');
var defaultClient = StrafesNetPublicApi.ApiClient.instance;

// Configure API key authorization: api-key
var api-key = defaultClient.authentications['api-key'];
api-key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api-key.apiKeyPrefix = 'Token';

var apiInstance = new StrafesNetPublicApi.UserApi();

var userId = 56; // Number | User ID filter


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.userUserIdGet(userId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| User ID filter | 

### Return type

[**User**](User.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

