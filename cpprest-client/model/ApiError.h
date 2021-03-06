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
 * ApiError.h
 *
 * 
 */

#ifndef IO_SWAGGER_CLIENT_MODEL_ApiError_H_
#define IO_SWAGGER_CLIENT_MODEL_ApiError_H_


#include "../ModelBase.h"

#include <cpprest/details/basic_types.h>

namespace io {
namespace swagger {
namespace client {
namespace model {

/// <summary>
/// 
/// </summary>
class  ApiError
    : public ModelBase
{
public:
    ApiError();
    virtual ~ApiError();

    /////////////////////////////////////////////
    /// ModelBase overrides

    void validate() override;

    web::json::value toJson() const override;
    void fromJson(web::json::value& json) override;

    void toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) const override;
    void fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) override;

    /////////////////////////////////////////////
    /// ApiError members

    /// <summary>
    /// 
    /// </summary>
    double getCode() const;
    bool codeIsSet() const;
    void unsetCode();
    void setCode(double value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getMessage() const;
    bool messageIsSet() const;
    void unsetMessage();
    void setMessage(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getReference() const;
    bool referenceIsSet() const;
    void unsetReference();
    void setReference(utility::string_t value);

protected:
    double m_Code;
    bool m_CodeIsSet;
    utility::string_t m_Message;
    bool m_MessageIsSet;
    utility::string_t m_Reference;
    bool m_ReferenceIsSet;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_MODEL_ApiError_H_ */
