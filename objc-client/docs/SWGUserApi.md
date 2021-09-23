# SWGUserApi

All URIs are relative to *https://api.strafes.net/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userUserIdGet**](SWGUserApi.md#useruseridget) | **GET** /user/{userId} | 


# **userUserIdGet**
```objc
-(NSURLSessionTask*) userUserIdGetWithUserId: (NSNumber*) userId
        completionHandler: (void (^)(SWGUser* output, NSError* error)) handler;
```



User from id.

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api-key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"api-key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"api-key"];


NSNumber* userId = @56; // User ID filter

SWGUserApi*apiInstance = [[SWGUserApi alloc] init];

[apiInstance userUserIdGetWithUserId:userId
          completionHandler: ^(SWGUser* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGUserApi->userUserIdGet: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **NSNumber***| User ID filter | 

### Return type

[**SWGUser***](SWGUser.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

