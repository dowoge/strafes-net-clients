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



#include "Map.h"

namespace io {
namespace swagger {
namespace client {
namespace model {

Map::Map()
{
    m_ID = 0;
    m_IDIsSet = false;
    m_DisplayName = utility::conversions::to_string_t("");
    m_DisplayNameIsSet = false;
    m_Creator = utility::conversions::to_string_t("");
    m_CreatorIsSet = false;
    m_Game = 0;
    m_GameIsSet = false;
    m_Date = 0;
    m_DateIsSet = false;
    m_PlayCount = 0;
    m_PlayCountIsSet = false;
}

Map::~Map()
{
}

void Map::validate()
{
    // TODO: implement validation
}

web::json::value Map::toJson() const
{
    web::json::value val = web::json::value::object();

    if(m_IDIsSet)
    {
        val[utility::conversions::to_string_t("ID")] = ModelBase::toJson(m_ID);
    }
    if(m_DisplayNameIsSet)
    {
        val[utility::conversions::to_string_t("DisplayName")] = ModelBase::toJson(m_DisplayName);
    }
    if(m_CreatorIsSet)
    {
        val[utility::conversions::to_string_t("Creator")] = ModelBase::toJson(m_Creator);
    }
    if(m_GameIsSet)
    {
        val[utility::conversions::to_string_t("Game")] = ModelBase::toJson(m_Game);
    }
    if(m_DateIsSet)
    {
        val[utility::conversions::to_string_t("Date")] = ModelBase::toJson(m_Date);
    }
    if(m_PlayCountIsSet)
    {
        val[utility::conversions::to_string_t("PlayCount")] = ModelBase::toJson(m_PlayCount);
    }

    return val;
}

void Map::fromJson(web::json::value& val)
{
    if(val.has_field(utility::conversions::to_string_t("ID")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("ID")];
        if(!fieldValue.is_null())
        {
            setID(ModelBase::int32_tFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("DisplayName")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("DisplayName")];
        if(!fieldValue.is_null())
        {
            setDisplayName(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("Creator")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("Creator")];
        if(!fieldValue.is_null())
        {
            setCreator(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("Game")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("Game")];
        if(!fieldValue.is_null())
        {
            setGame(ModelBase::int32_tFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("Date")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("Date")];
        if(!fieldValue.is_null())
        {
            setDate(ModelBase::int32_tFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("PlayCount")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("PlayCount")];
        if(!fieldValue.is_null())
        {
            setPlayCount(ModelBase::int32_tFromJson(fieldValue));
        }
    }
}

void Map::toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix) const
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
    if(m_DisplayNameIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("DisplayName"), m_DisplayName));
        
    }
    if(m_CreatorIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("Creator"), m_Creator));
        
    }
    if(m_GameIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("Game"), m_Game));
    }
    if(m_DateIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("Date"), m_Date));
    }
    if(m_PlayCountIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("PlayCount"), m_PlayCount));
    }
}

void Map::fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix)
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
    if(multipart->hasContent(utility::conversions::to_string_t("DisplayName")))
    {
        setDisplayName(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("DisplayName"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("Creator")))
    {
        setCreator(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("Creator"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("Game")))
    {
        setGame(ModelBase::int32_tFromHttpContent(multipart->getContent(utility::conversions::to_string_t("Game"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("Date")))
    {
        setDate(ModelBase::int32_tFromHttpContent(multipart->getContent(utility::conversions::to_string_t("Date"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("PlayCount")))
    {
        setPlayCount(ModelBase::int32_tFromHttpContent(multipart->getContent(utility::conversions::to_string_t("PlayCount"))));
    }
}

int32_t Map::getID() const
{
    return m_ID;
}


void Map::setID(int32_t value)
{
    m_ID = value;
    m_IDIsSet = true;
}
bool Map::iDIsSet() const
{
    return m_IDIsSet;
}

void Map::unsetID()
{
    m_IDIsSet = false;
}

utility::string_t Map::getDisplayName() const
{
    return m_DisplayName;
}


void Map::setDisplayName(utility::string_t value)
{
    m_DisplayName = value;
    m_DisplayNameIsSet = true;
}
bool Map::displayNameIsSet() const
{
    return m_DisplayNameIsSet;
}

void Map::unsetDisplayName()
{
    m_DisplayNameIsSet = false;
}

utility::string_t Map::getCreator() const
{
    return m_Creator;
}


void Map::setCreator(utility::string_t value)
{
    m_Creator = value;
    m_CreatorIsSet = true;
}
bool Map::creatorIsSet() const
{
    return m_CreatorIsSet;
}

void Map::unsetCreator()
{
    m_CreatorIsSet = false;
}

int32_t Map::getGame() const
{
    return m_Game;
}


void Map::setGame(int32_t value)
{
    m_Game = value;
    m_GameIsSet = true;
}
bool Map::gameIsSet() const
{
    return m_GameIsSet;
}

void Map::unsetGame()
{
    m_GameIsSet = false;
}

int32_t Map::getDate() const
{
    return m_Date;
}


void Map::setDate(int32_t value)
{
    m_Date = value;
    m_DateIsSet = true;
}
bool Map::dateIsSet() const
{
    return m_DateIsSet;
}

void Map::unsetDate()
{
    m_DateIsSet = false;
}

int32_t Map::getPlayCount() const
{
    return m_PlayCount;
}


void Map::setPlayCount(int32_t value)
{
    m_PlayCount = value;
    m_PlayCountIsSet = true;
}
bool Map::playCountIsSet() const
{
    return m_PlayCountIsSet;
}

void Map::unsetPlayCount()
{
    m_PlayCountIsSet = false;
}

}
}
}
}

