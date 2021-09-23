# \TimeApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimeMapMapIdGet**](TimeApi.md#TimeMapMapIdGet) | **Get** /time/map/{mapId} | 
[**TimeMapMapIdWrGet**](TimeApi.md#TimeMapMapIdWrGet) | **Get** /time/map/{mapId}/wr | 
[**TimeRecentGet**](TimeApi.md#TimeRecentGet) | **Get** /time/recent | 
[**TimeRecentWrGet**](TimeApi.md#TimeRecentWrGet) | **Get** /time/recent/wr | 
[**TimeTimeIdGet**](TimeApi.md#TimeTimeIdGet) | **Get** /time/{timeId} | 
[**TimeTimeIdRankGet**](TimeApi.md#TimeTimeIdRankGet) | **Get** /time/{timeId}/rank | 
[**TimeUserUserIdGet**](TimeApi.md#TimeUserUserIdGet) | **Get** /time/user/{userId} | 
[**TimeUserUserIdWrGet**](TimeApi.md#TimeUserUserIdWrGet) | **Get** /time/user/{userId}/wr | 


# **TimeMapMapIdGet**
> []Time TimeMapMapIdGet(ctx, mapId, optional)


Time by map id. Sorted in ascending order.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **mapId** | **int32**| Map ID filter | 
 **optional** | ***TimeApiTimeMapMapIdGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a TimeApiTimeMapMapIdGetOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **style** | **optional.Int32**| Style ID filter | 
 **page** | **optional.Int32**| Page api results. Page size is 200. | 

### Return type

[**[]Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TimeMapMapIdWrGet**
> Time TimeMapMapIdWrGet(ctx, mapId, style)


Get WR of map.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **mapId** | **int32**| Map ID filter | 
  **style** | **int32**| Style ID filter | 

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TimeRecentGet**
> []Time TimeRecentGet(ctx, optional)


50 recent times.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TimeApiTimeRecentGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a TimeApiTimeRecentGetOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **optional.Int32**| Filter out all times before unix time stamp. | 
 **style** | **optional.Int32**| Style ID filter | 
 **game** | **optional.Int32**| Game ID filter | 
 **map_** | **optional.Int32**| Map ID filter | 

### Return type

[**[]Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TimeRecentWrGet**
> []Time TimeRecentWrGet(ctx, style, game, optional)


10 recent world records.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **style** | **int32**| Style ID filter | 
  **game** | **int32**| Game ID filter | 
 **optional** | ***TimeApiTimeRecentWrGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a TimeApiTimeRecentWrGetOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **whitelist** | **optional.Bool**| Filters for only players on the whitelist | 

### Return type

[**[]Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TimeTimeIdGet**
> Time TimeTimeIdGet(ctx, timeId)


Time from id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **timeId** | **int32**| Time ID filter | 

### Return type

[**Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TimeTimeIdRankGet**
> interface{} TimeTimeIdRankGet(ctx, timeId)


Time rank from id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **timeId** | **int32**| Time ID filter | 

### Return type

**interface{}**

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TimeUserUserIdGet**
> []Time TimeUserUserIdGet(ctx, userId, optional)


Time by user id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **userId** | **int32**| User ID filter | 
 **optional** | ***TimeApiTimeUserUserIdGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a TimeApiTimeUserUserIdGetOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **map_** | **optional.Int32**| Map ID filter | 
 **style** | **optional.Int32**| Style ID filter | 
 **game** | **optional.Int32**| Game ID filter | 
 **page** | **optional.Int32**| Page api results. Page size is 200. | 

### Return type

[**[]Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TimeUserUserIdWrGet**
> []Time TimeUserUserIdWrGet(ctx, userId, game, style)


World records by user id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **userId** | **int32**| User ID filter | 
  **game** | **int32**| Game ID filter | 
  **style** | **int32**| Style ID filter | 

### Return type

[**[]Time**](Time.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

