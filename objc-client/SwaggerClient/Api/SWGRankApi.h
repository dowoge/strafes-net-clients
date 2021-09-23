#import <Foundation/Foundation.h>
#import "SWGRank.h"
#import "SWGApi.h"

/**
* StrafesNET Public API
* ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
*
* OpenAPI spec version: 1.0.0
* 
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/



@interface SWGRankApi: NSObject <SWGApi>

extern NSString* kSWGRankApiErrorDomain;
extern NSInteger kSWGRankApiMissingParamErrorCode;

-(instancetype) initWithApiClient:(SWGApiClient *)apiClient NS_DESIGNATED_INITIALIZER;

/// 
/// Top ranked players, paged at 50 per page.
///
/// @param style Style ID filter
/// @param game Game ID filter
/// @param page Page api results, Page size is 50. (optional)
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return NSArray<SWGRank>*
-(NSURLSessionTask*) rankGetWithStyle: (NSNumber*) style
    game: (NSNumber*) game
    page: (NSNumber*) page
    completionHandler: (void (^)(NSArray<SWGRank>* output, NSError* error)) handler;


/// 
/// Get rank of user by their id.
///
/// @param userId User ID filter
/// @param style Style ID filter
/// @param game Game ID filter
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return SWGRank*
-(NSURLSessionTask*) rankUserIdGetWithUserId: (NSNumber*) userId
    style: (NSNumber*) style
    game: (NSNumber*) game
    completionHandler: (void (^)(SWGRank* output, NSError* error)) handler;



@end
