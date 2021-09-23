# swagger_client.TimeApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**time_map_map_id_get**](TimeApi.md#time_map_map_id_get) | **GET** /time/map/{mapId} | 
[**time_map_map_id_wr_get**](TimeApi.md#time_map_map_id_wr_get) | **GET** /time/map/{mapId}/wr | 
[**time_recent_get**](TimeApi.md#time_recent_get) | **GET** /time/recent | 
[**time_recent_wr_get**](TimeApi.md#time_recent_wr_get) | **GET** /time/recent/wr | 
[**time_time_id_get**](TimeApi.md#time_time_id_get) | **GET** /time/{timeId} | 
[**time_time_id_rank_get**](TimeApi.md#time_time_id_rank_get) | **GET** /time/{timeId}/rank | 
[**time_user_user_id_get**](TimeApi.md#time_user_user_id_get) | **GET** /time/user/{userId} | 
[**time_user_user_id_wr_get**](TimeApi.md#time_user_user_id_wr_get) | **GET** /time/user/{userId}/wr | 


# **time_map_map_id_get**
> list[Time] time_map_map_id_get(map_id, style=style, page=page)



Time by map id. Sorted in ascending order.

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
api_instance = swagger_client.TimeApi(swagger_client.ApiClient(configuration))
map_id = 56 # int | Map ID filter
style = 56 # int | Style ID filter (optional)
page = 56 # int | Page api results. Page size is 200. (optional)

try:
    api_response = api_instance.time_map_map_id_get(map_id, style=style, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TimeApi->time_map_map_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map_id** | **int**| Map ID filter | 
 **style** | **int**| Style ID filter | [optional] 
 **page** | **int**| Page api results. Page size is 200. | [optional] 

### Return type

[**list[Time]**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_map_map_id_wr_get**
> Time time_map_map_id_wr_get(map_id, style)



Get WR of map.

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
api_instance = swagger_client.TimeApi(swagger_client.ApiClient(configuration))
map_id = 56 # int | Map ID filter
style = 56 # int | Style ID filter

try:
    api_response = api_instance.time_map_map_id_wr_get(map_id, style)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TimeApi->time_map_map_id_wr_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map_id** | **int**| Map ID filter | 
 **style** | **int**| Style ID filter | 

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_recent_get**
> list[Time] time_recent_get(_date=_date, style=style, game=game, map=map)



50 recent times.

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
api_instance = swagger_client.TimeApi(swagger_client.ApiClient(configuration))
_date = 56 # int | Filter out all times before unix time stamp. (optional)
style = 56 # int | Style ID filter (optional)
game = 56 # int | Game ID filter (optional)
map = 56 # int | Map ID filter (optional)

try:
    api_response = api_instance.time_recent_get(_date=_date, style=style, game=game, map=map)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TimeApi->time_recent_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_date** | **int**| Filter out all times before unix time stamp. | [optional] 
 **style** | **int**| Style ID filter | [optional] 
 **game** | **int**| Game ID filter | [optional] 
 **map** | **int**| Map ID filter | [optional] 

### Return type

[**list[Time]**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_recent_wr_get**
> list[Time] time_recent_wr_get(style, game, whitelist=whitelist)



10 recent world records.

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
api_instance = swagger_client.TimeApi(swagger_client.ApiClient(configuration))
style = 56 # int | Style ID filter
game = 56 # int | Game ID filter
whitelist = true # bool | Filters for only players on the whitelist (optional)

try:
    api_response = api_instance.time_recent_wr_get(style, game, whitelist=whitelist)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TimeApi->time_recent_wr_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **int**| Style ID filter | 
 **game** | **int**| Game ID filter | 
 **whitelist** | **bool**| Filters for only players on the whitelist | [optional] 

### Return type

[**list[Time]**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_time_id_get**
> Time time_time_id_get(time_id)



Time from id.

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
api_instance = swagger_client.TimeApi(swagger_client.ApiClient(configuration))
time_id = 56 # int | Time ID filter

try:
    api_response = api_instance.time_time_id_get(time_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TimeApi->time_time_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **time_id** | **int**| Time ID filter | 

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_time_id_rank_get**
> object time_time_id_rank_get(time_id)



Time rank from id.

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
api_instance = swagger_client.TimeApi(swagger_client.ApiClient(configuration))
time_id = 56 # int | Time ID filter

try:
    api_response = api_instance.time_time_id_rank_get(time_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TimeApi->time_time_id_rank_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **time_id** | **int**| Time ID filter | 

### Return type

**object**

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_user_user_id_get**
> list[Time] time_user_user_id_get(user_id, map=map, style=style, game=game, page=page)



Time by user id.

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
api_instance = swagger_client.TimeApi(swagger_client.ApiClient(configuration))
user_id = 56 # int | User ID filter
map = 56 # int | Map ID filter (optional)
style = 56 # int | Style ID filter (optional)
game = 56 # int | Game ID filter (optional)
page = 56 # int | Page api results. Page size is 200. (optional)

try:
    api_response = api_instance.time_user_user_id_get(user_id, map=map, style=style, game=game, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TimeApi->time_user_user_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| User ID filter | 
 **map** | **int**| Map ID filter | [optional] 
 **style** | **int**| Style ID filter | [optional] 
 **game** | **int**| Game ID filter | [optional] 
 **page** | **int**| Page api results. Page size is 200. | [optional] 

### Return type

[**list[Time]**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_user_user_id_wr_get**
> list[Time] time_user_user_id_wr_get(user_id, game, style)



World records by user id.

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
api_instance = swagger_client.TimeApi(swagger_client.ApiClient(configuration))
user_id = 56 # int | User ID filter
game = 56 # int | Game ID filter
style = 56 # int | Style ID filter

try:
    api_response = api_instance.time_user_user_id_wr_get(user_id, game, style)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TimeApi->time_user_user_id_wr_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| User ID filter | 
 **game** | **int**| Game ID filter | 
 **style** | **int**| Style ID filter | 

### Return type

[**list[Time]**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

