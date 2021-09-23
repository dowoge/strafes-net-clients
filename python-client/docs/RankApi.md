# swagger_client.RankApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rank_get**](RankApi.md#rank_get) | **GET** /rank | 
[**rank_user_id_get**](RankApi.md#rank_user_id_get) | **GET** /rank/{userId} | 


# **rank_get**
> list[Rank] rank_get(style, game, page=page)



Top ranked players, paged at 50 per page.

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
api_instance = swagger_client.RankApi(swagger_client.ApiClient(configuration))
style = 56 # int | Style ID filter
game = 56 # int | Game ID filter
page = 56 # int | Page api results, Page size is 50. (optional)

try:
    api_response = api_instance.rank_get(style, game, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RankApi->rank_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **int**| Style ID filter | 
 **game** | **int**| Game ID filter | 
 **page** | **int**| Page api results, Page size is 50. | [optional] 

### Return type

[**list[Rank]**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rank_user_id_get**
> Rank rank_user_id_get(user_id, style, game)



Get rank of user by their id.

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
api_instance = swagger_client.RankApi(swagger_client.ApiClient(configuration))
user_id = 56 # int | User ID filter
style = 56 # int | Style ID filter
game = 56 # int | Game ID filter

try:
    api_response = api_instance.rank_user_id_get(user_id, style, game)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RankApi->rank_user_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| User ID filter | 
 **style** | **int**| Style ID filter | 
 **game** | **int**| Game ID filter | 

### Return type

[**Rank**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

