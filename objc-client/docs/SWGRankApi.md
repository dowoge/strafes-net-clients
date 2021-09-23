# SWGRankApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rankGet**](SWGRankApi.md#rankget) | **GET** /rank | 
[**rankUserIdGet**](SWGRankApi.md#rankuseridget) | **GET** /rank/{userId} | 


# **rankGet**
```objc
-(NSURLSessionTask*) rankGetWithStyle: (NSNumber*) style
    game: (NSNumber*) game
    page: (NSNumber*) page
        completionHandler: (void (^)(NSArray<SWGRank>* output, NSError* error)) handler;
```



Top ranked players, paged at 50 per page.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* style = @56; // Style ID filter
NSNumber* game = @56; // Game ID filter
NSNumber* page = @56; // Page api results, Page size is 50. (optional)

SWGRankApi*apiInstance = [[SWGRankApi alloc] init];

[apiInstance rankGetWithStyle:style
              game:game
              page:page
          completionHandler: ^(NSArray<SWGRank>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGRankApi->rankGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **NSNumber***| Style ID filter | 
 **game** | **NSNumber***| Game ID filter | 
 **page** | **NSNumber***| Page api results, Page size is 50. | [optional] 

### Return type

[**NSArray<SWGRank>***](SWGRank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rankUserIdGet**
```objc
-(NSURLSessionTask*) rankUserIdGetWithUserId: (NSNumber*) userId
    style: (NSNumber*) style
    game: (NSNumber*) game
        completionHandler: (void (^)(SWGRank* output, NSError* error)) handler;
```



Get rank of user by their id.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* userId = @56; // User ID filter
NSNumber* style = @56; // Style ID filter
NSNumber* game = @56; // Game ID filter

SWGRankApi*apiInstance = [[SWGRankApi alloc] init];

[apiInstance rankUserIdGetWithUserId:userId
              style:style
              game:game
          completionHandler: ^(SWGRank* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGRankApi->rankUserIdGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **NSNumber***| User ID filter | 
 **style** | **NSNumber***| Style ID filter | 
 **game** | **NSNumber***| Game ID filter | 

### Return type

[**SWGRank***](SWGRank.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

