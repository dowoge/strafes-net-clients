# \MapApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MapGet**](MapApi.md#MapGet) | **Get** /map | 
[**MapMapIdGet**](MapApi.md#MapMapIdGet) | **Get** /map/{mapId} | 


# **MapGet**
> []ModelMap MapGet(ctx, optional)


Get list of maps.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***MapApiMapGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a MapApiMapGetOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **game** | **optional.Int32**| Game ID filter | 
 **page** | **optional.Int32**| Page api results. Page size is 200. | 

### Return type

[**[]ModelMap**](Map.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **MapMapIdGet**
> ModelMap MapMapIdGet(ctx, mapId)


Get map by ID.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **mapId** | **int32**| Map ID filter | 

### Return type

[**ModelMap**](Map.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

