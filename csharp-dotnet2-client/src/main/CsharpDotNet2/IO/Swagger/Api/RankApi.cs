using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRankApi
    {
        /// <summary>
        ///  Top ranked players, paged at 50 per page.
        /// </summary>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results, Page size is 50.</param>
        /// <returns>List&lt;Rank&gt;</returns>
        List<Rank> RankGet (int? style, int? game, int? page);
        /// <summary>
        ///  Get rank of user by their id.
        /// </summary>
        /// <param name="userId">User ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <returns>Rank</returns>
        Rank RankUserIdGet (int? userId, int? style, int? game);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RankApi : IRankApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RankApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RankApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RankApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Top ranked players, paged at 50 per page.
        /// </summary>
        /// <param name="style">Style ID filter</param> 
        /// <param name="game">Game ID filter</param> 
        /// <param name="page">Page api results, Page size is 50.</param> 
        /// <returns>List&lt;Rank&gt;</returns>            
        public List<Rank> RankGet (int? style, int? game, int? page)
        {
            
            // verify the required parameter 'style' is set
            if (style == null) throw new ApiException(400, "Missing required parameter 'style' when calling RankGet");
            
            // verify the required parameter 'game' is set
            if (game == null) throw new ApiException(400, "Missing required parameter 'game' when calling RankGet");
            
    
            var path = "/rank";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (style != null) queryParams.Add("style", ApiClient.ParameterToString(style)); // query parameter
 if (game != null) queryParams.Add("game", ApiClient.ParameterToString(game)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RankGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RankGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Rank>) ApiClient.Deserialize(response.Content, typeof(List<Rank>), response.Headers);
        }
    
        /// <summary>
        ///  Get rank of user by their id.
        /// </summary>
        /// <param name="userId">User ID filter</param> 
        /// <param name="style">Style ID filter</param> 
        /// <param name="game">Game ID filter</param> 
        /// <returns>Rank</returns>            
        public Rank RankUserIdGet (int? userId, int? style, int? game)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling RankUserIdGet");
            
            // verify the required parameter 'style' is set
            if (style == null) throw new ApiException(400, "Missing required parameter 'style' when calling RankUserIdGet");
            
            // verify the required parameter 'game' is set
            if (game == null) throw new ApiException(400, "Missing required parameter 'game' when calling RankUserIdGet");
            
    
            var path = "/rank/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (style != null) queryParams.Add("style", ApiClient.ParameterToString(style)); // query parameter
 if (game != null) queryParams.Add("game", ApiClient.ParameterToString(game)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RankUserIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RankUserIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Rank) ApiClient.Deserialize(response.Content, typeof(Rank), response.Headers);
        }
    
    }
}
