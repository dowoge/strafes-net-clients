# swagger_client.UserApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**user_user_id_get**](UserApi.md#user_user_id_get) | **GET** /user/{userId} | 


# **user_user_id_get**
> User user_user_id_get(user_id)



User from id.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: api-key
configuration = swagger_client.Configuration()
configuration.api_key['api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.UserApi(swagger_client.ApiClient(configuration))
user_id = 56 # int | User ID filter

try:
    api_response = api_instance.user_user_id_get(user_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->user_user_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| User ID filter | 

### Return type

[**User**](User.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

