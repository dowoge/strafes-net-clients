#import "SWGTimeApi.h"
#import "SWGQueryParamCollection.h"
#import "SWGApiClient.h"
#import "SWGTime.h"


@interface SWGTimeApi ()

@property (nonatomic, strong, readwrite) NSMutableDictionary *mutableDefaultHeaders;

@end

@implementation SWGTimeApi

NSString* kSWGTimeApiErrorDomain = @"SWGTimeApiErrorDomain";
NSInteger kSWGTimeApiMissingParamErrorCode = 234513;

@synthesize apiClient = _apiClient;

#pragma mark - Initialize methods

- (instancetype) init {
    return [self initWithApiClient:[SWGApiClient sharedClient]];
}


-(instancetype) initWithApiClient:(SWGApiClient *)apiClient {
    self = [super init];
    if (self) {
        _apiClient = apiClient;
        _mutableDefaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

#pragma mark -

-(NSString*) defaultHeaderForKey:(NSString*)key {
    return self.mutableDefaultHeaders[key];
}

-(void) setDefaultHeaderValue:(NSString*) value forKey:(NSString*)key {
    [self.mutableDefaultHeaders setValue:value forKey:key];
}

-(NSDictionary *)defaultHeaders {
    return self.mutableDefaultHeaders;
}

#pragma mark - Api Methods

///
/// 
/// Time by map id. Sorted in ascending order.
///  @param mapId Map ID filter 
///
///  @param style Style ID filter (optional)
///
///  @param page Page api results. Page size is 200. (optional)
///
///  @returns NSArray<SWGTime>*
///
-(NSURLSessionTask*) timeMapMapIdGetWithMapId: (NSNumber*) mapId
    style: (NSNumber*) style
    page: (NSNumber*) page
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler {
    // verify the required parameter 'mapId' is set
    if (mapId == nil) {
        NSParameterAssert(mapId);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"mapId"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/time/map/{mapId}"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (mapId != nil) {
        pathParams[@"mapId"] = mapId;
    }

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (style != nil) {
        queryParams[@"style"] = style;
    }
    if (page != nil) {
        queryParams[@"page"] = page;
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"api-key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSArray<SWGTime>*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSArray<SWGTime>*)data, error);
                                }
                            }];
}

///
/// 
/// Get WR of map.
///  @param mapId Map ID filter 
///
///  @param style Style ID filter 
///
///  @returns SWGTime*
///
-(NSURLSessionTask*) timeMapMapIdWrGetWithMapId: (NSNumber*) mapId
    style: (NSNumber*) style
    completionHandler: (void (^)(SWGTime* output, NSError* error)) handler {
    // verify the required parameter 'mapId' is set
    if (mapId == nil) {
        NSParameterAssert(mapId);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"mapId"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'style' is set
    if (style == nil) {
        NSParameterAssert(style);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"style"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/time/map/{mapId}/wr"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (mapId != nil) {
        pathParams[@"mapId"] = mapId;
    }

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (style != nil) {
        queryParams[@"style"] = style;
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"api-key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SWGTime*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGTime*)data, error);
                                }
                            }];
}

///
/// 
/// 50 recent times.
///  @param date Filter out all times before unix time stamp. (optional)
///
///  @param style Style ID filter (optional)
///
///  @param game Game ID filter (optional)
///
///  @param map Map ID filter (optional)
///
///  @returns NSArray<SWGTime>*
///
-(NSURLSessionTask*) timeRecentGetWithDate: (NSNumber*) date
    style: (NSNumber*) style
    game: (NSNumber*) game
    map: (NSNumber*) map
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler {
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/time/recent"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (date != nil) {
        queryParams[@"date"] = date;
    }
    if (style != nil) {
        queryParams[@"style"] = style;
    }
    if (game != nil) {
        queryParams[@"game"] = game;
    }
    if (map != nil) {
        queryParams[@"map"] = map;
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"api-key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSArray<SWGTime>*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSArray<SWGTime>*)data, error);
                                }
                            }];
}

///
/// 
/// 10 recent world records.
///  @param style Style ID filter 
///
///  @param game Game ID filter 
///
///  @param whitelist Filters for only players on the whitelist (optional)
///
///  @returns NSArray<SWGTime>*
///
-(NSURLSessionTask*) timeRecentWrGetWithStyle: (NSNumber*) style
    game: (NSNumber*) game
    whitelist: (NSNumber*) whitelist
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler {
    // verify the required parameter 'style' is set
    if (style == nil) {
        NSParameterAssert(style);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"style"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'game' is set
    if (game == nil) {
        NSParameterAssert(game);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"game"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/time/recent/wr"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (style != nil) {
        queryParams[@"style"] = style;
    }
    if (game != nil) {
        queryParams[@"game"] = game;
    }
    if (whitelist != nil) {
        queryParams[@"whitelist"] = [whitelist isEqual:@(YES)] ? @"true" : @"false";
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"api-key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSArray<SWGTime>*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSArray<SWGTime>*)data, error);
                                }
                            }];
}

///
/// 
/// Time from id.
///  @param timeId Time ID filter 
///
///  @returns SWGTime*
///
-(NSURLSessionTask*) timeTimeIdGetWithTimeId: (NSNumber*) timeId
    completionHandler: (void (^)(SWGTime* output, NSError* error)) handler {
    // verify the required parameter 'timeId' is set
    if (timeId == nil) {
        NSParameterAssert(timeId);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"timeId"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/time/{timeId}"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (timeId != nil) {
        pathParams[@"timeId"] = timeId;
    }

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"api-key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SWGTime*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGTime*)data, error);
                                }
                            }];
}

///
/// 
/// Time rank from id.
///  @param timeId Time ID filter 
///
///  @returns NSObject*
///
-(NSURLSessionTask*) timeTimeIdRankGetWithTimeId: (NSNumber*) timeId
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler {
    // verify the required parameter 'timeId' is set
    if (timeId == nil) {
        NSParameterAssert(timeId);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"timeId"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/time/{timeId}/rank"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (timeId != nil) {
        pathParams[@"timeId"] = timeId;
    }

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"api-key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSObject*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSObject*)data, error);
                                }
                            }];
}

///
/// 
/// Time by user id.
///  @param userId User ID filter 
///
///  @param map Map ID filter (optional)
///
///  @param style Style ID filter (optional)
///
///  @param game Game ID filter (optional)
///
///  @param page Page api results. Page size is 200. (optional)
///
///  @returns NSArray<SWGTime>*
///
-(NSURLSessionTask*) timeUserUserIdGetWithUserId: (NSNumber*) userId
    map: (NSNumber*) map
    style: (NSNumber*) style
    game: (NSNumber*) game
    page: (NSNumber*) page
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler {
    // verify the required parameter 'userId' is set
    if (userId == nil) {
        NSParameterAssert(userId);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"userId"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/time/user/{userId}"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (userId != nil) {
        pathParams[@"userId"] = userId;
    }

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (map != nil) {
        queryParams[@"map"] = map;
    }
    if (style != nil) {
        queryParams[@"style"] = style;
    }
    if (game != nil) {
        queryParams[@"game"] = game;
    }
    if (page != nil) {
        queryParams[@"page"] = page;
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"api-key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSArray<SWGTime>*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSArray<SWGTime>*)data, error);
                                }
                            }];
}

///
/// 
/// World records by user id.
///  @param userId User ID filter 
///
///  @param game Game ID filter 
///
///  @param style Style ID filter 
///
///  @returns NSArray<SWGTime>*
///
-(NSURLSessionTask*) timeUserUserIdWrGetWithUserId: (NSNumber*) userId
    game: (NSNumber*) game
    style: (NSNumber*) style
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler {
    // verify the required parameter 'userId' is set
    if (userId == nil) {
        NSParameterAssert(userId);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"userId"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'game' is set
    if (game == nil) {
        NSParameterAssert(game);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"game"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'style' is set
    if (style == nil) {
        NSParameterAssert(style);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"style"] };
            NSError* error = [NSError errorWithDomain:kSWGTimeApiErrorDomain code:kSWGTimeApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/time/user/{userId}/wr"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (userId != nil) {
        pathParams[@"userId"] = userId;
    }

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (game != nil) {
        queryParams[@"game"] = game;
    }
    if (style != nil) {
        queryParams[@"style"] = style;
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"api-key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSArray<SWGTime>*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSArray<SWGTime>*)data, error);
                                }
                            }];
}



@end
