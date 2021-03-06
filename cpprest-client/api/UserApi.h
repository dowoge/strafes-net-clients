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
 * UserApi.h
 *
 * 
 */

#ifndef IO_SWAGGER_CLIENT_API_UserApi_H_
#define IO_SWAGGER_CLIENT_API_UserApi_H_


#include "../ApiClient.h"

#include "Object.h"
#include "User.h"

#include <boost/optional.hpp>

namespace io {
namespace swagger {
namespace client {
namespace api {

using namespace io::swagger::client::model;

class  UserApi
{
public:
    UserApi( std::shared_ptr<ApiClient> apiClient );
    virtual ~UserApi();
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// User from id.
    /// </remarks>
    /// <param name="userId">User ID filter</param>
    pplx::task<std::shared_ptr<User>> userUserIdGet(
        int32_t userId
    );

protected:
    std::shared_ptr<ApiClient> m_ApiClient;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_API_UserApi_H_ */

