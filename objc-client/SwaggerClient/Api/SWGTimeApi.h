#import <Foundation/Foundation.h>
#import "SWGTime.h"
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



@interface SWGTimeApi: NSObject <SWGApi>

extern NSString* kSWGTimeApiErrorDomain;
extern NSInteger kSWGTimeApiMissingParamErrorCode;

-(instancetype) initWithApiClient:(SWGApiClient *)apiClient NS_DESIGNATED_INITIALIZER;

/// 
/// Time by map id. Sorted in ascending order.
///
/// @param mapId Map ID filter
/// @param style Style ID filter (optional)
/// @param page Page api results. Page size is 200. (optional)
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return NSArray<SWGTime>*
-(NSURLSessionTask*) timeMapMapIdGetWithMapId: (NSNumber*) mapId
    style: (NSNumber*) style
    page: (NSNumber*) page
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;


/// 
/// Get WR of map.
///
/// @param mapId Map ID filter
/// @param style Style ID filter
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return SWGTime*
-(NSURLSessionTask*) timeMapMapIdWrGetWithMapId: (NSNumber*) mapId
    style: (NSNumber*) style
    completionHandler: (void (^)(SWGTime* output, NSError* error)) handler;


/// 
/// 50 recent times.
///
/// @param date Filter out all times before unix time stamp. (optional)
/// @param style Style ID filter (optional)
/// @param game Game ID filter (optional)
/// @param map Map ID filter (optional)
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return NSArray<SWGTime>*
-(NSURLSessionTask*) timeRecentGetWithDate: (NSNumber*) date
    style: (NSNumber*) style
    game: (NSNumber*) game
    map: (NSNumber*) map
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;


/// 
/// 10 recent world records.
///
/// @param style Style ID filter
/// @param game Game ID filter
/// @param whitelist Filters for only players on the whitelist (optional)
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return NSArray<SWGTime>*
-(NSURLSessionTask*) timeRecentWrGetWithStyle: (NSNumber*) style
    game: (NSNumber*) game
    whitelist: (NSNumber*) whitelist
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;


/// 
/// Time from id.
///
/// @param timeId Time ID filter
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return SWGTime*
-(NSURLSessionTask*) timeTimeIdGetWithTimeId: (NSNumber*) timeId
    completionHandler: (void (^)(SWGTime* output, NSError* error)) handler;


/// 
/// Time rank from id.
///
/// @param timeId Time ID filter
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return NSObject*
-(NSURLSessionTask*) timeTimeIdRankGetWithTimeId: (NSNumber*) timeId
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;


/// 
/// Time by user id.
///
/// @param userId User ID filter
/// @param map Map ID filter (optional)
/// @param style Style ID filter (optional)
/// @param game Game ID filter (optional)
/// @param page Page api results. Page size is 200. (optional)
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return NSArray<SWGTime>*
-(NSURLSessionTask*) timeUserUserIdGetWithUserId: (NSNumber*) userId
    map: (NSNumber*) map
    style: (NSNumber*) style
    game: (NSNumber*) game
    page: (NSNumber*) page
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;


/// 
/// World records by user id.
///
/// @param userId User ID filter
/// @param game Game ID filter
/// @param style Style ID filter
/// 
///  code:200 message:"Expected response to a valid request",
///  code:0 message:"unexpected error"
///
/// @return NSArray<SWGTime>*
-(NSURLSessionTask*) timeUserUserIdWrGetWithUserId: (NSNumber*) userId
    game: (NSNumber*) game
    style: (NSNumber*) style
    completionHandler: (void (^)(NSArray<SWGTime>* output, NSError* error)) handler;



@end
