# swagger-java-client

StrafesNET Public API
- API version: 1.0.0
  - Build date: 2021-09-23T01:26:26.652Z

### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 


*Automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen)*


## Requirements

Building the API client library requires:
1. Java 1.7+
2. Maven/Gradle

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn clean install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn clean deploy
```

Refer to the [OSSRH Guide](http://central.sonatype.org/pages/ossrh-guide.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
  <groupId>io.swagger</groupId>
  <artifactId>swagger-java-client</artifactId>
  <version>1.0.0</version>
  <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "io.swagger:swagger-java-client:1.0.0"
```

### Others

At first generate the JAR by executing:

```shell
mvn clean package
```

Then manually install the following JARs:

* `target/swagger-java-client-1.0.0.jar`
* `target/lib/*.jar`

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import io.swagger.client.*;
import io.swagger.client.auth.*;
import io.swagger.client.model.*;
import io.swagger.client.api.MapApi;

import java.io.File;
import java.util.*;

public class MapApiExample {

    public static void main(String[] args) {
        ApiClient defaultClient = Configuration.getDefaultApiClient();
        
        // Configure API key authorization: api-key
        ApiKeyAuth api-key = (ApiKeyAuth) defaultClient.getAuthentication("api-key");
        api-key.setApiKey("YOUR API KEY");
        // Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
        //api-key.setApiKeyPrefix("Token");

        MapApi apiInstance = new MapApi();
        Integer game = 56; // Integer | Game ID filter
        Integer page = 56; // Integer | Page api results. Page size is 200.
        try {
            List<Map> result = apiInstance.mapGet(game, page);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling MapApi#mapGet");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://api.strafes.net/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*MapApi* | [**mapGet**](docs/MapApi.md#mapGet) | **GET** /map | 
*MapApi* | [**mapMapIdGet**](docs/MapApi.md#mapMapIdGet) | **GET** /map/{mapId} | 
*RankApi* | [**rankGet**](docs/RankApi.md#rankGet) | **GET** /rank | 
*RankApi* | [**rankUserIdGet**](docs/RankApi.md#rankUserIdGet) | **GET** /rank/{userId} | 
*TimeApi* | [**timeMapMapIdGet**](docs/TimeApi.md#timeMapMapIdGet) | **GET** /time/map/{mapId} | 
*TimeApi* | [**timeMapMapIdWrGet**](docs/TimeApi.md#timeMapMapIdWrGet) | **GET** /time/map/{mapId}/wr | 
*TimeApi* | [**timeRecentGet**](docs/TimeApi.md#timeRecentGet) | **GET** /time/recent | 
*TimeApi* | [**timeRecentWrGet**](docs/TimeApi.md#timeRecentWrGet) | **GET** /time/recent/wr | 
*TimeApi* | [**timeTimeIdGet**](docs/TimeApi.md#timeTimeIdGet) | **GET** /time/{timeId} | 
*TimeApi* | [**timeTimeIdRankGet**](docs/TimeApi.md#timeTimeIdRankGet) | **GET** /time/{timeId}/rank | 
*TimeApi* | [**timeUserUserIdGet**](docs/TimeApi.md#timeUserUserIdGet) | **GET** /time/user/{userId} | 
*TimeApi* | [**timeUserUserIdWrGet**](docs/TimeApi.md#timeUserUserIdWrGet) | **GET** /time/user/{userId}/wr | 
*UserApi* | [**userUserIdGet**](docs/UserApi.md#userUserIdGet) | **GET** /user/{userId} | 


## Documentation for Models

 - [ApiError](docs/ApiError.md)
 - [Map](docs/Map.md)
 - [Rank](docs/Rank.md)
 - [Time](docs/Time.md)
 - [User](docs/User.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### api-key

- **Type**: API key
- **API key parameter name**: api-key
- **Location**: HTTP header


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author



