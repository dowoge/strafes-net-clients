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



#include "User.h"

namespace io {
namespace swagger {
namespace client {
namespace model {

User::User()
{
    m_ID = 0;
    m_IDIsSet = false;
    m_Username = utility::conversions::to_string_t("");
    m_UsernameIsSet = false;
    m_State = 0;
    m_StateIsSet = false;
}

User::~User()
{
}

void User::validate()
{
    // TODO: implement validation
}

web::json::value User::toJson() const
{
    web::json::value val = web::json::value::object();

    if(m_IDIsSet)
    {
        val[utility::conversions::to_string_t("ID")] = ModelBase::toJson(m_ID);
    }
    if(m_UsernameIsSet)
    {
        val[utility::conversions::to_string_t("Username")] = ModelBase::toJson(m_Username);
    }
    if(m_StateIsSet)
    {
        val[utility::conversions::to_string_t("State")] = ModelBase::toJson(m_State);
    }

    return val;
}

void User::fromJson(web::json::value& val)
{
    if(val.has_field(utility::conversions::to_string_t("ID")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("ID")];
        if(!fieldValue.is_null())
        {
            setID(ModelBase::int32_tFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("Username")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("Username")];
        if(!fieldValue.is_null())
        {
            setUsername(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("State")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("State")];
        if(!fieldValue.is_null())
        {
            setState(ModelBase::int32_tFromJson(fieldValue));
        }
    }
}

void User::toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix) const
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(m_IDIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("ID"), m_ID));
    }
    if(m_UsernameIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("Username"), m_Username));
        
    }
    if(m_StateIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("State"), m_State));
    }
}

void User::fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix)
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(multipart->hasContent(utility::conversions::to_string_t("ID")))
    {
        setID(ModelBase::int32_tFromHttpContent(multipart->getContent(utility::conversions::to_string_t("ID"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("Username")))
    {
        setUsername(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("Username"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("State")))
    {
        setState(ModelBase::int32_tFromHttpContent(multipart->getContent(utility::conversions::to_string_t("State"))));
    }
}

int32_t User::getID() const
{
    return m_ID;
}


void User::setID(int32_t value)
{
    m_ID = value;
    m_IDIsSet = true;
}
bool User::iDIsSet() const
{
    return m_IDIsSet;
}

void User::unsetID()
{
    m_IDIsSet = false;
}

utility::string_t User::getUsername() const
{
    return m_Username;
}


void User::setUsername(utility::string_t value)
{
    m_Username = value;
    m_UsernameIsSet = true;
}
bool User::usernameIsSet() const
{
    return m_UsernameIsSet;
}

void User::unsetUsername()
{
    m_UsernameIsSet = false;
}

int32_t User::getState() const
{
    return m_State;
}


void User::setState(int32_t value)
{
    m_State = value;
    m_StateIsSet = true;
}
bool User::stateIsSet() const
{
    return m_StateIsSet;
}

void User::unsetState()
{
    m_StateIsSet = false;
}

}
}
}
}

