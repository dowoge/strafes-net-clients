# swagger_client.MapApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**map_get**](MapApi.md#map_get) | **GET** /map | 
[**map_map_id_get**](MapApi.md#map_map_id_get) | **GET** /map/{mapId} | 


# **map_get**
> list[Map] map_get(game=game, page=page)



Get list of maps.

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
api_instance = swagger_client.MapApi(swagger_client.ApiClient(configuration))
game = 56 # int | Game ID filter (optional)
page = 56 # int | Page api results. Page size is 200. (optional)

try:
    api_response = api_instance.map_get(game=game, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MapApi->map_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **game** | **int**| Game ID filter | [optional] 
 **page** | **int**| Page api results. Page size is 200. | [optional] 

### Return type

[**list[Map]**](Map.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **map_map_id_get**
> Map map_map_id_get(map_id)



Get map by ID.

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
api_instance = swagger_client.MapApi(swagger_client.ApiClient(configuration))
map_id = 56 # int | Map ID filter

try:
    api_response = api_instance.map_map_id_get(map_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MapApi->map_map_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map_id** | **int**| Map ID filter | 

### Return type

[**Map**](Map.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

