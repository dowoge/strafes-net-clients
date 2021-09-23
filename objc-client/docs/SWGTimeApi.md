# SWGTimeApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**timeMapMapIdGet**](SWGTimeApi.md#timemapmapidget) | **GET** /time/map/{mapId} | 
[**timeMapMapIdWrGet**](SWGTimeApi.md#timemapmapidwrget) | **GET** /time/map/{mapId}/wr | 
[**timeRecentGet**](SWGTimeApi.md#timerecentget) | **GET** /time/recent | 
[**timeRecentWrGet**](SWGTimeApi.md#timerecentwrget) | **GET** /time/recent/wr | 
[**timeTimeIdGet**](SWGTimeApi.md#timetimeidget) | **GET** /time/{timeId} | 
[**timeTimeIdRankGet**](SWGTimeApi.md#timetimeidrankget) | **GET** /time/{timeId}/rank | 
[**timeUserUserIdGet**](SWGTimeApi.md#timeuseruseridget) | **GET** /time/user/{userId} | 
[**timeUserUserIdWrGet**](SWGTimeApi.md#timeuseruseridwrget) | **GET** /time/user/{userId}/wr | 


# **timeMapMapIdGet**
```objc
-(NSURLSessionTask*) timeMapMapIdGetWithMapId: (NSNumber*) mapId
    style: (NSNumber*) style
    page: (NSNumber*) page
        completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;
```



Time by map id. Sorted in ascending order.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* mapId = @56; // Map ID filter
NSNumber* style = @56; // Style ID filter (optional)
NSNumber* page = @56; // Page api results. Page size is 200. (optional)

SWGTimeApi*apiInstance = [[SWGTimeApi alloc] init];

[apiInstance timeMapMapIdGetWithMapId:mapId
              style:style
              page:page
          completionHandler: ^(NSArray<SWGTime>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTimeApi->timeMapMapIdGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **NSNumber***| Map ID filter | 
 **style** | **NSNumber***| Style ID filter | [optional] 
 **page** | **NSNumber***| Page api results. Page size is 200. | [optional] 

### Return type

[**NSArray<SWGTime>***](SWGTime.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **timeMapMapIdWrGet**
```objc
-(NSURLSessionTask*) timeMapMapIdWrGetWithMapId: (NSNumber*) mapId
    style: (NSNumber*) style
        completionHandler: (void (^)(SWGTime* output, NSError* error)) handler;
```



Get WR of map.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* mapId = @56; // Map ID filter
NSNumber* style = @56; // Style ID filter

SWGTimeApi*apiInstance = [[SWGTimeApi alloc] init];

[apiInstance timeMapMapIdWrGetWithMapId:mapId
              style:style
          completionHandler: ^(SWGTime* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTimeApi->timeMapMapIdWrGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **NSNumber***| Map ID filter | 
 **style** | **NSNumber***| Style ID filter | 

### Return type

[**SWGTime***](SWGTime.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **timeRecentGet**
```objc
-(NSURLSessionTask*) timeRecentGetWithDate: (NSNumber*) date
    style: (NSNumber*) style
    game: (NSNumber*) game
    map: (NSNumber*) map
        completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;
```



50 recent times.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* date = @56; // Filter out all times before unix time stamp. (optional)
NSNumber* style = @56; // Style ID filter (optional)
NSNumber* game = @56; // Game ID filter (optional)
NSNumber* map = @56; // Map ID filter (optional)

SWGTimeApi*apiInstance = [[SWGTimeApi alloc] init];

[apiInstance timeRecentGetWithDate:date
              style:style
              game:game
              map:map
          completionHandler: ^(NSArray<SWGTime>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTimeApi->timeRecentGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **NSNumber***| Filter out all times before unix time stamp. | [optional] 
 **style** | **NSNumber***| Style ID filter | [optional] 
 **game** | **NSNumber***| Game ID filter | [optional] 
 **map** | **NSNumber***| Map ID filter | [optional] 

### Return type

[**NSArray<SWGTime>***](SWGTime.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **timeRecentWrGet**
```objc
-(NSURLSessionTask*) timeRecentWrGetWithStyle: (NSNumber*) style
    game: (NSNumber*) game
    whitelist: (NSNumber*) whitelist
        completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;
```



10 recent world records.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* style = @56; // Style ID filter
NSNumber* game = @56; // Game ID filter
NSNumber* whitelist = @true; // Filters for only players on the whitelist (optional)

SWGTimeApi*apiInstance = [[SWGTimeApi alloc] init];

[apiInstance timeRecentWrGetWithStyle:style
              game:game
              whitelist:whitelist
          completionHandler: ^(NSArray<SWGTime>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTimeApi->timeRecentWrGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **style** | **NSNumber***| Style ID filter | 
 **game** | **NSNumber***| Game ID filter | 
 **whitelist** | **NSNumber***| Filters for only players on the whitelist | [optional] 

### Return type

[**NSArray<SWGTime>***](SWGTime.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **timeTimeIdGet**
```objc
-(NSURLSessionTask*) timeTimeIdGetWithTimeId: (NSNumber*) timeId
        completionHandler: (void (^)(SWGTime* output, NSError* error)) handler;
```



Time from id.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* timeId = @56; // Time ID filter

SWGTimeApi*apiInstance = [[SWGTimeApi alloc] init];

[apiInstance timeTimeIdGetWithTimeId:timeId
          completionHandler: ^(SWGTime* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTimeApi->timeTimeIdGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeId** | **NSNumber***| Time ID filter | 

### Return type

[**SWGTime***](SWGTime.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **timeTimeIdRankGet**
```objc
-(NSURLSessionTask*) timeTimeIdRankGetWithTimeId: (NSNumber*) timeId
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```



Time rank from id.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* timeId = @56; // Time ID filter

SWGTimeApi*apiInstance = [[SWGTimeApi alloc] init];

[apiInstance timeTimeIdRankGetWithTimeId:timeId
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTimeApi->timeTimeIdRankGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeId** | **NSNumber***| Time ID filter | 

### Return type

**NSObject***

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **timeUserUserIdGet**
```objc
-(NSURLSessionTask*) timeUserUserIdGetWithUserId: (NSNumber*) userId
    map: (NSNumber*) map
    style: (NSNumber*) style
    game: (NSNumber*) game
    page: (NSNumber*) page
        completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;
```



Time by user id.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* userId = @56; // User ID filter
NSNumber* map = @56; // Map ID filter (optional)
NSNumber* style = @56; // Style ID filter (optional)
NSNumber* game = @56; // Game ID filter (optional)
NSNumber* page = @56; // Page api results. Page size is 200. (optional)

SWGTimeApi*apiInstance = [[SWGTimeApi alloc] init];

[apiInstance timeUserUserIdGetWithUserId:userId
              map:map
              style:style
              game:game
              page:page
          completionHandler: ^(NSArray<SWGTime>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTimeApi->timeUserUserIdGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **NSNumber***| User ID filter | 
 **map** | **NSNumber***| Map ID filter | [optional] 
 **style** | **NSNumber***| Style ID filter | [optional] 
 **game** | **NSNumber***| Game ID filter | [optional] 
 **page** | **NSNumber***| Page api results. Page size is 200. | [optional] 

### Return type

[**NSArray<SWGTime>***](SWGTime.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **timeUserUserIdWrGet**
```objc
-(NSURLSessionTask*) timeUserUserIdWrGetWithUserId: (NSNumber*) userId
    game: (NSNumber*) game
    style: (NSNumber*) style
        completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;
```



World records by user id.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* userId = @56; // User ID filter
NSNumber* game = @56; // Game ID filter
NSNumber* style = @56; // Style ID filter

SWGTimeApi*apiInstance = [[SWGTimeApi alloc] init];

[apiInstance timeUserUserIdWrGetWithUserId:userId
              game:game
              style:style
          completionHandler: ^(NSArray<SWGTime>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTimeApi->timeUserUserIdWrGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **NSNumber***| User ID filter | 
 **game** | **NSNumber***| Game ID filter | 
 **style** | **NSNumber***| Style ID filter | 

### Return type

[**NSArray<SWGTime>***](SWGTime.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

