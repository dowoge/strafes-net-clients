# \RankApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RankGet**](RankApi.md#RankGet) | **Get** /rank | 
[**RankUserIdGet**](RankApi.md#RankUserIdGet) | **Get** /rank/{userId} | 


# **RankGet**
> []Rank RankGet(ctx, style, game, optional)


Top ranked players, paged at 50 per page.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **style** | **int32**| Style ID filter | 
  **game** | **int32**| Game ID filter | 
 **optional** | ***RankApiRankGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a RankApiRankGetOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **page** | **optional.Int32**| Page api results, Page size is 50. | 

### Return type

[**[]Rank**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **RankUserIdGet**
> Rank RankUserIdGet(ctx, userId, style, game)


Get rank of user by their id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **userId** | **int32**| User ID filter | 
  **style** | **int32**| Style ID filter | 
  **game** | **int32**| Game ID filter | 

### Return type

[**Rank**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

