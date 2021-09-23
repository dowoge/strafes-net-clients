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
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRankApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Top ranked players, paged at 50 per page.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50. (optional)</param>
        /// <returns>List&lt;Rank&gt;</returns>
        List<Rank> RankGet (int? style, int? game, int? page = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Top ranked players, paged at 50 per page.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50. (optional)</param>
        /// <returns>ApiResponse of List&lt;Rank&gt;</returns>
        ApiResponse<List<Rank>> RankGetWithHttpInfo (int? style, int? game, int? page = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get rank of user by their id.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>Rank</returns>
        Rank RankUserIdGet (int? userId, int? style, int? game);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get rank of user by their id.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>ApiResponse of Rank</returns>
        ApiResponse<Rank> RankUserIdGetWithHttpInfo (int? userId, int? style, int? game);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Top ranked players, paged at 50 per page.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50. (optional)</param>
        /// <returns>Task of List&lt;Rank&gt;</returns>
        System.Threading.Tasks.Task<List<Rank>> RankGetAsync (int? style, int? game, int? page = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Top ranked players, paged at 50 per page.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Rank&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Rank>>> RankGetAsyncWithHttpInfo (int? style, int? game, int? page = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get rank of user by their id.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>Task of Rank</returns>
        System.Threading.Tasks.Task<Rank> RankUserIdGetAsync (int? userId, int? style, int? game);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get rank of user by their id.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>Task of ApiResponse (Rank)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rank>> RankUserIdGetAsyncWithHttpInfo (int? userId, int? style, int? game);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RankApi : IRankApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RankApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RankApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RankApi(IO.Swagger.Client.Configuration configuration = null)
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
        ///  Top ranked players, paged at 50 per page.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50. (optional)</param>
        /// <returns>List&lt;Rank&gt;</returns>
        public List<Rank> RankGet (int? style, int? game, int? page = null)
        {
             ApiResponse<List<Rank>> localVarResponse = RankGetWithHttpInfo(style, game, page);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Top ranked players, paged at 50 per page.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50. (optional)</param>
        /// <returns>ApiResponse of List&lt;Rank&gt;</returns>
        public ApiResponse< List<Rank> > RankGetWithHttpInfo (int? style, int? game, int? page = null)
        {
            // verify the required parameter 'style' is set
            if (style == null)
                throw new ApiException(400, "Missing required parameter 'style' when calling RankApi->RankGet");
            // verify the required parameter 'game' is set
            if (game == null)
                throw new ApiException(400, "Missing required parameter 'game' when calling RankApi->RankGet");

            var localVarPath = "/rank";
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

            if (style != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "style", style)); // query parameter
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
                Exception exception = ExceptionFactory("RankGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Rank>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Rank>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Rank>)));
        }

        /// <summary>
        ///  Top ranked players, paged at 50 per page.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50. (optional)</param>
        /// <returns>Task of List&lt;Rank&gt;</returns>
        public async System.Threading.Tasks.Task<List<Rank>> RankGetAsync (int? style, int? game, int? page = null)
        {
             ApiResponse<List<Rank>> localVarResponse = await RankGetAsyncWithHttpInfo(style, game, page);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Top ranked players, paged at 50 per page.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Rank&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Rank>>> RankGetAsyncWithHttpInfo (int? style, int? game, int? page = null)
        {
            // verify the required parameter 'style' is set
            if (style == null)
                throw new ApiException(400, "Missing required parameter 'style' when calling RankApi->RankGet");
            // verify the required parameter 'game' is set
            if (game == null)
                throw new ApiException(400, "Missing required parameter 'game' when calling RankApi->RankGet");

            var localVarPath = "/rank";
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

            if (style != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "style", style)); // query parameter
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
                Exception exception = ExceptionFactory("RankGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Rank>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Rank>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Rank>)));
        }

        /// <summary>
        ///  Get rank of user by their id.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>Rank</returns>
        public Rank RankUserIdGet (int? userId, int? style, int? game)
        {
             ApiResponse<Rank> localVarResponse = RankUserIdGetWithHttpInfo(userId, style, game);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get rank of user by their id.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>ApiResponse of Rank</returns>
        public ApiResponse< Rank > RankUserIdGetWithHttpInfo (int? userId, int? style, int? game)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RankApi->RankUserIdGet");
            // verify the required parameter 'style' is set
            if (style == null)
                throw new ApiException(400, "Missing required parameter 'style' when calling RankApi->RankUserIdGet");
            // verify the required parameter 'game' is set
            if (game == null)
                throw new ApiException(400, "Missing required parameter 'game' when calling RankApi->RankUserIdGet");

            var localVarPath = "/rank/{userId}";
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

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (style != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "style", style)); // query parameter
            if (game != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "game", game)); // query parameter

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
                Exception exception = ExceptionFactory("RankUserIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Rank>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rank) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rank)));
        }

        /// <summary>
        ///  Get rank of user by their id.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>Task of Rank</returns>
        public async System.Threading.Tasks.Task<Rank> RankUserIdGetAsync (int? userId, int? style, int? game)
        {
             ApiResponse<Rank> localVarResponse = await RankUserIdGetAsyncWithHttpInfo(userId, style, game);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get rank of user by their id.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>Task of ApiResponse (Rank)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rank>> RankUserIdGetAsyncWithHttpInfo (int? userId, int? style, int? game)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RankApi->RankUserIdGet");
            // verify the required parameter 'style' is set
            if (style == null)
                throw new ApiException(400, "Missing required parameter 'style' when calling RankApi->RankUserIdGet");
            // verify the required parameter 'game' is set
            if (game == null)
                throw new ApiException(400, "Missing required parameter 'game' when calling RankApi->RankUserIdGet");

            var localVarPath = "/rank/{userId}";
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

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (style != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "style", style)); // query parameter
            if (game != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "game", game)); // query parameter

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
                Exception exception = ExceptionFactory("RankUserIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Rank>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rank) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Rank)));
        }

    }
}
