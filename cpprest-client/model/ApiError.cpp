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



#include "ApiError.h"

namespace io {
namespace swagger {
namespace client {
namespace model {

ApiError::ApiError()
{
    m_Code = 0.0;
    m_CodeIsSet = false;
    m_Message = utility::conversions::to_string_t("");
    m_MessageIsSet = false;
    m_Reference = utility::conversions::to_string_t("");
    m_ReferenceIsSet = false;
}

ApiError::~ApiError()
{
}

void ApiError::validate()
{
    // TODO: implement validation
}

web::json::value ApiError::toJson() const
{
    web::json::value val = web::json::value::object();

    if(m_CodeIsSet)
    {
        val[utility::conversions::to_string_t("code")] = ModelBase::toJson(m_Code);
    }
    if(m_MessageIsSet)
    {
        val[utility::conversions::to_string_t("message")] = ModelBase::toJson(m_Message);
    }
    if(m_ReferenceIsSet)
    {
        val[utility::conversions::to_string_t("reference")] = ModelBase::toJson(m_Reference);
    }

    return val;
}

void ApiError::fromJson(web::json::value& val)
{
    if(val.has_field(utility::conversions::to_string_t("code")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("code")];
        if(!fieldValue.is_null())
        {
            setCode(ModelBase::doubleFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("message")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("message")];
        if(!fieldValue.is_null())
        {
            setMessage(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("reference")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("reference")];
        if(!fieldValue.is_null())
        {
            setReference(ModelBase::stringFromJson(fieldValue));
        }
    }
}

void ApiError::toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix) const
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(m_CodeIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("code"), m_Code));
    }
    if(m_MessageIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("message"), m_Message));
        
    }
    if(m_ReferenceIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("reference"), m_Reference));
        
    }
}

void ApiError::fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix)
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(multipart->hasContent(utility::conversions::to_string_t("code")))
    {
        setCode(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("code"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("message")))
    {
        setMessage(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("message"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("reference")))
    {
        setReference(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("reference"))));
    }
}

double ApiError::getCode() const
{
    return m_Code;
}


void ApiError::setCode(double value)
{
    m_Code = value;
    m_CodeIsSet = true;
}
bool ApiError::codeIsSet() const
{
    return m_CodeIsSet;
}

void ApiError::unsetCode()
{
    m_CodeIsSet = false;
}

utility::string_t ApiError::getMessage() const
{
    return m_Message;
}


void ApiError::setMessage(utility::string_t value)
{
    m_Message = value;
    m_MessageIsSet = true;
}
bool ApiError::messageIsSet() const
{
    return m_MessageIsSet;
}

void ApiError::unsetMessage()
{
    m_MessageIsSet = false;
}

utility::string_t ApiError::getReference() const
{
    return m_Reference;
}


void ApiError::setReference(utility::string_t value)
{
    m_Reference = value;
    m_ReferenceIsSet = true;
}
bool ApiError::referenceIsSet() const
{
    return m_ReferenceIsSet;
}

void ApiError::unsetReference()
{
    m_ReferenceIsSet = false;
}

}
}
}
}

