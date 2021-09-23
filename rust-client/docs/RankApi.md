# \RankApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rank_get**](RankApi.md#rank_get) | **Get** /rank | 
[**rank_user_id_get**](RankApi.md#rank_user_id_get) | **Get** /rank/{userId} | 


# **rank_get**
> Vec<::models::Rank> rank_get(ctx, style, game, optional)


Top ranked players, paged at 50 per page.

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
 **page** | **i32**| Page api results, Page size is 50. | 

### Return type

[**Vec<::models::Rank>**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rank_user_id_get**
> ::models::Rank rank_user_id_get(ctx, user_id, style, game)


Get rank of user by their id.

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **user_id** | **i32**| User ID filter | 
  **style** | **i32**| Style ID filter | 
  **game** | **i32**| Game ID filter | 

### Return type

[**::models::Rank**](Rank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

