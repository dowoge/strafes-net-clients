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
 * ApiConfiguration.h
 *
 * This class represents a single item of a multipart-formdata request.
 */

#ifndef IO_SWAGGER_CLIENT_API_ApiConfiguration_H_
#define IO_SWAGGER_CLIENT_API_ApiConfiguration_H_



#include <map>

#include <cpprest/details/basic_types.h>
#include <cpprest/http_client.h>
namespace io {
namespace swagger {
namespace client {
namespace api {

class  ApiConfiguration
{
public:
    ApiConfiguration();
    virtual ~ApiConfiguration();

    web::http::client::http_client_config& getHttpConfig();
    void setHttpConfig( web::http::client::http_client_config& value );

    utility::string_t getBaseUrl() const;
    void setBaseUrl( const utility::string_t value );

    utility::string_t getUserAgent() const;
    void setUserAgent( const utility::string_t value );

    std::map<utility::string_t, utility::string_t>& getDefaultHeaders();

    utility::string_t getApiKey( const utility::string_t& prefix) const;
    void setApiKey( const utility::string_t& prefix, const utility::string_t& apiKey );

protected:
    utility::string_t m_BaseUrl;
    std::map<utility::string_t, utility::string_t> m_DefaultHeaders;
    std::map<utility::string_t, utility::string_t> m_ApiKeys;
    web::http::client::http_client_config m_HttpConfig;
    utility::string_t m_UserAgent;
};

}
}
}
}
#endif /* IO_SWAGGER_CLIENT_API_ApiConfiguration_H_ */
