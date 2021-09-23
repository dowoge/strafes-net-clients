# \TimeApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**time_map_map_id_get**](TimeApi.md#time_map_map_id_get) | **Get** /time/map/{mapId} | 
[**time_map_map_id_wr_get**](TimeApi.md#time_map_map_id_wr_get) | **Get** /time/map/{mapId}/wr | 
[**time_recent_get**](TimeApi.md#time_recent_get) | **Get** /time/recent | 
[**time_recent_wr_get**](TimeApi.md#time_recent_wr_get) | **Get** /time/recent/wr | 
[**time_time_id_get**](TimeApi.md#time_time_id_get) | **Get** /time/{timeId} | 
[**time_time_id_rank_get**](TimeApi.md#time_time_id_rank_get) | **Get** /time/{timeId}/rank | 
[**time_user_user_id_get**](TimeApi.md#time_user_user_id_get) | **Get** /time/user/{userId} | 
[**time_user_user_id_wr_get**](TimeApi.md#time_user_user_id_wr_get) | **Get** /time/user/{userId}/wr | 


# **time_map_map_id_get**
> Vec<::models::Time> time_map_map_id_get(ctx, map_id, optional)


Time by map id. Sorted in ascending order.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **map_id** | **i32**| Map ID filter | 
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map_id** | **i32**| Map ID filter | 
 **style** | **i32**| Style ID filter | 
 **page** | **i32**| Page api results. Page size is 200. | 

### Return type

[**Vec<::models::Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_map_map_id_wr_get**
> ::models::Time time_map_map_id_wr_get(ctx, map_id, style)


Get WR of map.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **map_id** | **i32**| Map ID filter | 
  **style** | **i32**| Style ID filter | 

### Return type

[**::models::Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_recent_get**
> Vec<::models::Time> time_recent_get(ctx, optional)


50 recent times.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **i32**| Filter out all times before unix time stamp. | 
 **style** | **i32**| Style ID filter | 
 **game** | **i32**| Game ID filter | 
 **map** | **i32**| Map ID filter | 

### Return type

[**Vec<::models::Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_recent_wr_get**
> Vec<::models::Time> time_recent_wr_get(ctx, style, game, optional)


10 recent world records.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **style** | **i32**| Style ID filter | 
  **game** | **i32**| Game ID filter | 
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **i32**| Style ID filter | 
 **game** | **i32**| Game ID filter | 
 **whitelist** | **bool**| Filters for only players on the whitelist | 

### Return type

[**Vec<::models::Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_time_id_get**
> ::models::Time time_time_id_get(ctx, time_id)


Time from id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **time_id** | **i32**| Time ID filter | 

### Return type

[**::models::Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_time_id_rank_get**
> Value time_time_id_rank_get(ctx, time_id)


Time rank from id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **time_id** | **i32**| Time ID filter | 

### Return type

[**Value**](Value.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_user_user_id_get**
> Vec<::models::Time> time_user_user_id_get(ctx, user_id, optional)


Time by user id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **user_id** | **i32**| User ID filter | 
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **i32**| User ID filter | 
 **map** | **i32**| Map ID filter | 
 **style** | **i32**| Style ID filter | 
 **game** | **i32**| Game ID filter | 
 **page** | **i32**| Page api results. Page size is 200. | 

### Return type

[**Vec<::models::Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **time_user_user_id_wr_get**
> Vec<::models::Time> time_user_user_id_wr_get(ctx, user_id, game, style)


World records by user id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **user_id** | **i32**| User ID filter | 
  **game** | **i32**| Game ID filter | 
  **style** | **i32**| Style ID filter | 

### Return type

[**Vec<::models::Time>**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

