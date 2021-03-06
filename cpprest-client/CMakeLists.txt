#
# StrafesNET Public API
# ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
#
# OpenAPI spec version: 1.0.0
#
# https://github.com/swagger-api/swagger-codegen.git
#
# NOTE: Auto generated by the swagger code generator program.

cmake_minimum_required (VERSION 2.8)

#PROJECT's NAME
project(CppRestSwaggerClient)


# THE LOCATION OF OUTPUT BINARIES
set(CMAKE_LIBRARY_DIR ${PROJECT_SOURCE_DIR}/lib)
set(LIBRARY_OUTPUT_PATH ${CMAKE_LIBRARY_DIR})

set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++11")

if(NOT CMAKE_BUILD_TYPE)
    set(CMAKE_BUILD_TYPE Release)
endif()

# BUILD TYPE
message("A ${CMAKE_BUILD_TYPE} build configuration is detected")

# Update require components as necessary
#find_package(Boost 1.45.0 REQUIRED COMPONENTS ${Boost_THREAD_LIBRARY} ${Boost_SYSTEM_LIBRARY} ${Boost_REGEX_LIBRARY} ${Boost_DATE_TIME_LIBRARY} ${Boost_PROGRAM_OPTIONS_LIBRARY} ${Boost_FILESYSTEM_LIBRARY})

# build and set path to cpp rest sdk
#set(CPPREST_ROOT ${PROJECT_SOURCE_DIR}/../../../developmentTools/3rdParty/cpprest)
set(CPPREST_INCLUDE_DIR ${CPPREST_ROOT}/include)
set(CPPREST_LIBRARY_DIR ${CPPREST_ROOT}/lib)

if( NOT DEFINED CPPREST_ROOT )
    message( FATAL_ERROR "Failed to find cpprest SDK (or missing components). Double check that \"CPPREST_ROOT\" is properly set")
endif( NOT DEFINED CPPREST_ROOT )

include_directories(${PROJECT_SOURCE_DIR} api model ${CPPREST_INCLUDE_DIR})

#SUPPORTING FILES
set(SUPPORTING_FILES  "ApiClient" "ApiConfiguration" "ApiException" "HttpContent" "IHttpBody" "JsonBody" "ModelBase" "MultipartFormData" "Object")
#SOURCE FILES
file(GLOB SOURCE_FILES  "api/*"  "model/*")

add_library(${PROJECT_NAME} ${SUPPORTING_FILES} ${SOURCE_FILES})
