using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMapApi
    {
        /// <summary>
        ///  Get list of maps.
        /// </summary>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results. Page size is 200.</param>
        /// <returns>List&lt;Dictionary&gt;</returns>
        List<Dictionary> MapGet (int? game, int? page);
        /// <summary>
        ///  Get map by ID.
        /// </summary>
        /// <param name="mapId">Map ID filter</param>
        /// <returns>Dictionary</returns>
        Dictionary MapMapIdGet (int? mapId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MapApi : IMapApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MapApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MapApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MapApi(String basePath)
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
        ///  Get list of maps.
        /// </summary>
        /// <param name="game">Game ID filter</param> 
        /// <param name="page">Page api results. Page size is 200.</param> 
        /// <returns>List&lt;Dictionary&gt;</returns>            
        public List<Dictionary> MapGet (int? game, int? page)
        {
            
    
            var path = "/map";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (game != null) queryParams.Add("game", ApiClient.ParameterToString(game)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MapGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MapGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Dictionary>) ApiClient.Deserialize(response.Content, typeof(List<Dictionary>), response.Headers);
        }
    
        /// <summary>
        ///  Get map by ID.
        /// </summary>
        /// <param name="mapId">Map ID filter</param> 
        /// <returns>Dictionary</returns>            
        public Dictionary MapMapIdGet (int? mapId)
        {
            
            // verify the required parameter 'mapId' is set
            if (mapId == null) throw new ApiException(400, "Missing required parameter 'mapId' when calling MapMapIdGet");
            
    
            var path = "/map/{mapId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "mapId" + "}", ApiClient.ParameterToString(mapId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MapMapIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MapMapIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary) ApiClient.Deserialize(response.Content, typeof(Dictionary), response.Headers);
        }
    
    }
}
