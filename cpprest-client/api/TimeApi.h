/**
 * StrafesNET Public API
 * ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator 2.4.21.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/*
 * TimeApi.h
 *
 * 
 */

#ifndef IO_SWAGGER_CLIENT_API_TimeApi_H_
#define IO_SWAGGER_CLIENT_API_TimeApi_H_


#include "../ApiClient.h"

#include "Object.h"
#include "Time.h"

#include <boost/optional.hpp>

namespace io {
namespace swagger {
namespace client {
namespace api {

using namespace io::swagger::client::model;

class  TimeApi
{
public:
    TimeApi( std::shared_ptr<ApiClient> apiClient );
    virtual ~TimeApi();
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Time by map id. Sorted in ascending order.
    /// </remarks>
    /// <param name="mapId">Map ID filter</param>
    /// <param name="style">Style ID filter (optional)</param>
    /// <param name="page">Page api results. Page size is 200. (optional)</param>
    pplx::task<std::vector<std::shared_ptr<Time>>> timeMapMapIdGet(
        int32_t mapId,
        boost::optional<int32_t> style,
        boost::optional<int32_t> page
    );
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Get WR of map.
    /// </remarks>
    /// <param name="mapId">Map ID filter</param>
    /// <param name="style">Style ID filter</param>
    pplx::task<std::shared_ptr<Time>> timeMapMapIdWrGet(
        int32_t mapId,
        int32_t style
    );
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 50 recent times.
    /// </remarks>
    /// <param name="date">Filter out all times before unix time stamp. (optional)</param>
    /// <param name="style">Style ID filter (optional)</param>
    /// <param name="game">Game ID filter (optional)</param>
    /// <param name="map">Map ID filter (optional)</param>
    pplx::task<std::vector<std::shared_ptr<Time>>> timeRecentGet(
        boost::optional<int32_t> date,
        boost::optional<int32_t> style,
        boost::optional<int32_t> game,
        boost::optional<int32_t> map
    );
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 10 recent world records.
    /// </remarks>
    /// <param name="style">Style ID filter</param>
    /// <param name="game">Game ID filter</param>
    /// <param name="whitelist">Filters for only players on the whitelist (optional)</param>
    pplx::task<std::vector<std::shared_ptr<Time>>> timeRecentWrGet(
        int32_t style,
        int32_t game,
        boost::optional<bool> whitelist
    );
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Time from id.
    /// </remarks>
    /// <param name="timeId">Time ID filter</param>
    pplx::task<std::shared_ptr<Time>> timeTimeIdGet(
        int32_t timeId
    );
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Time rank from id.
    /// </remarks>
    /// <param name="timeId">Time ID filter</param>
    pplx::task<std::shared_ptr<Object>> timeTimeIdRankGet(
        int32_t timeId
    );
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Time by user id.
    /// </remarks>
    /// <param name="userId">User ID filter</param>
    /// <param name="map">Map ID filter (optional)</param>
    /// <param name="style">Style ID filter (optional)</param>
    /// <param name="game">Game ID filter (optional)</param>
    /// <param name="page">Page api results. Page size is 200. (optional)</param>
    pplx::task<std::vector<std::shared_ptr<Time>>> timeUserUserIdGet(
        int32_t userId,
        boost::optional<int32_t> map,
        boost::optional<int32_t> style,
        boost::optional<int32_t> game,
        boost::optional<int32_t> page
    );
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// World records by user id.
    /// </remarks>
    /// <param name="userId">User ID filter</param>
    /// <param name="game">Game ID filter</param>
    /// <param name="style">Style ID filter</param>
    pplx::task<std::vector<std::shared_ptr<Time>>> timeUserUserIdWrGet(
        int32_t userId,
        int32_t game,
        int32_t style
    );

protected:
    std::shared_ptr<ApiClient> m_ApiClient;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_API_TimeApi_H_ */

