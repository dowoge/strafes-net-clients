/* 
 * StrafesNET Public API
 *
 * ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMapApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of maps.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="game">Game ID filter (optional)</param>
        /// <param name="page">Page api results. Page size is 200. (optional)</param>
        /// <returns>List&lt;Dictionary&gt;</returns>
        List<Dictionary> MapGet (int? game = null, int? page = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of maps.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="game">Game ID filter (optional)</param>
        /// <param name="page">Page api results. Page size is 200. (optional)</param>
        /// <returns>ApiResponse of List&lt;Dictionary&gt;</returns>
        ApiResponse<List<Dictionary>> MapGetWithHttpInfo (int? game = null, int? page = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get map by ID.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>Dictionary</returns>
        Dictionary MapMapIdGet (int? mapId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get map by ID.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>ApiResponse of Dictionary</returns>
        ApiResponse<Dictionary> MapMapIdGetWithHttpInfo (int? mapId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of maps.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="game">Game ID filter (optional)</param>
        /// <param name="page">Page api results. Page size is 200. (optional)</param>
        /// <returns>Task of List&lt;Dictionary&gt;</returns>
        System.Threading.Tasks.Task<List<Dictionary>> MapGetAsync (int? game = null, int? page = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of maps.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="game">Game ID filter (optional)</param>
        /// <param name="page">Page api results. Page size is 200. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Dictionary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Dictionary>>> MapGetAsyncWithHttpInfo (int? game = null, int? page = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get map by ID.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>Task of Dictionary</returns>
        System.Threading.Tasks.Task<Dictionary> MapMapIdGetAsync (int? mapId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get map by ID.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>Task of ApiResponse (Dictionary)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary>> MapMapIdGetAsyncWithHttpInfo (int? mapId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MapApi : IMapApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MapApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MapApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MapApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Get list of maps.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="game">Game ID filter (optional)</param>
        /// <param name="page">Page api results. Page size is 200. (optional)</param>
        /// <returns>List&lt;Dictionary&gt;</returns>
        public List<Dictionary> MapGet (int? game = null, int? page = null)
        {
             ApiResponse<List<Dictionary>> localVarResponse = MapGetWithHttpInfo(game, page);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get list of maps.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="game">Game ID filter (optional)</param>
        /// <param name="page">Page api results. Page size is 200. (optional)</param>
        /// <returns>ApiResponse of List&lt;Dictionary&gt;</returns>
        public ApiResponse< List<Dictionary> > MapGetWithHttpInfo (int? game = null, int? page = null)
        {

            var localVarPath = "/map";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (game != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "game", game)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MapGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Dictionary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Dictionary>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Dictionary>)));
        }

        /// <summary>
        ///  Get list of maps.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="game">Game ID filter (optional)</param>
        /// <param name="page">Page api results. Page size is 200. (optional)</param>
        /// <returns>Task of List&lt;Dictionary&gt;</returns>
        public async System.Threading.Tasks.Task<List<Dictionary>> MapGetAsync (int? game = null, int? page = null)
        {
             ApiResponse<List<Dictionary>> localVarResponse = await MapGetAsyncWithHttpInfo(game, page);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get list of maps.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="game">Game ID filter (optional)</param>
        /// <param name="page">Page api results. Page size is 200. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Dictionary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Dictionary>>> MapGetAsyncWithHttpInfo (int? game = null, int? page = null)
        {

            var localVarPath = "/map";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (game != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "game", game)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MapGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Dictionary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Dictionary>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Dictionary>)));
        }

        /// <summary>
        ///  Get map by ID.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>Dictionary</returns>
        public Dictionary MapMapIdGet (int? mapId)
        {
             ApiResponse<Dictionary> localVarResponse = MapMapIdGetWithHttpInfo(mapId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get map by ID.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>ApiResponse of Dictionary</returns>
        public ApiResponse< Dictionary > MapMapIdGetWithHttpInfo (int? mapId)
        {
            // verify the required parameter 'mapId' is set
            if (mapId == null)
                throw new ApiException(400, "Missing required parameter 'mapId' when calling MapApi->MapMapIdGet");

            var localVarPath = "/map/{mapId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (mapId != null) localVarPathParams.Add("mapId", this.Configuration.ApiClient.ParameterToString(mapId)); // path parameter

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MapMapIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary)));
        }

        /// <summary>
        ///  Get map by ID.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>Task of Dictionary</returns>
        public async System.Threading.Tasks.Task<Dictionary> MapMapIdGetAsync (int? mapId)
        {
             ApiResponse<Dictionary> localVarResponse = await MapMapIdGetAsyncWithHttpInfo(mapId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get map by ID.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>Task of ApiResponse (Dictionary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary>> MapMapIdGetAsyncWithHttpInfo (int? mapId)
        {
            // verify the required parameter 'mapId' is set
            if (mapId == null)
                throw new ApiException(400, "Missing required parameter 'mapId' when calling MapApi->MapMapIdGet");

            var localVarPath = "/map/{mapId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (mapId != null) localVarPathParams.Add("mapId", this.Configuration.ApiClient.ParameterToString(mapId)); // path parameter

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MapMapIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary)));
        }

    }
}
