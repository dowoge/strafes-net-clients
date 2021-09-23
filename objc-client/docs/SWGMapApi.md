# SWGMapApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mapGet**](SWGMapApi.md#mapget) | **GET** /map | 
[**mapMapIdGet**](SWGMapApi.md#mapmapidget) | **GET** /map/{mapId} | 


# **mapGet**
```objc
-(NSURLSessionTask*) mapGetWithGame: (NSNumber*) game
    page: (NSNumber*) page
        completionHandler: (void (^)(NSArray<NSDictionary*>* output, NSError* error)) handler;
```



Get list of maps.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* game = @56; // Game ID filter (optional)
NSNumber* page = @56; // Page api results. Page size is 200. (optional)

SWGMapApi*apiInstance = [[SWGMapApi alloc] init];

[apiInstance mapGetWithGame:game
              page:page
          completionHandler: ^(NSArray<NSDictionary*>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGMapApi->mapGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **game** | **NSNumber***| Game ID filter | [optional] 
 **page** | **NSNumber***| Page api results. Page size is 200. | [optional] 

### Return type

[**NSArray<NSDictionary*>***](NSDictionary.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mapMapIdGet**
```objc
-(NSURLSessionTask*) mapMapIdGetWithMapId: (NSNumber*) mapId
        completionHandler: (void (^)(NSDictionary* output, NSError* error)) handler;
```



Get map by ID.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* mapId = @56; // Map ID filter

SWGMapApi*apiInstance = [[SWGMapApi alloc] init];

[apiInstance mapMapIdGetWithMapId:mapId
          completionHandler: ^(NSDictionary* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGMapApi->mapMapIdGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mapId** | **NSNumber***| Map ID filter | 

### Return type

[**NSDictionary***](NSDictionary.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

