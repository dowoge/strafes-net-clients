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
 * MapApi.h
 *
 * 
 */

#ifndef IO_SWAGGER_CLIENT_API_MapApi_H_
#define IO_SWAGGER_CLIENT_API_MapApi_H_


#include "../ApiClient.h"

#include "Map.h"
#include "Object.h"

#include <boost/optional.hpp>

namespace io {
namespace swagger {
namespace client {
namespace api {

using namespace io::swagger::client::model;

class  MapApi
{
public:
    MapApi( std::shared_ptr<ApiClient> apiClient );
    virtual ~MapApi();
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Get list of maps.
    /// </remarks>
    /// <param name="game">Game ID filter (optional)</param>
    /// <param name="page">Page api results. Page size is 200. (optional)</param>
    pplx::task<std::vector<std::shared_ptr<Map>>> mapGet(
        boost::optional<int32_t> game,
        boost::optional<int32_t> page
    );
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Get map by ID.
    /// </remarks>
    /// <param name="mapId">Map ID filter</param>
    pplx::task<std::shared_ptr<Map>> mapMapIdGet(
        int32_t mapId
    );

protected:
    std::shared_ptr<ApiClient> m_ApiClient;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_API_MapApi_H_ */

