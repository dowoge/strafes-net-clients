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
    public interface ITimeApi
    {
        /// <summary>
        ///  Time by map id. Sorted in ascending order.
        /// </summary>
        /// <param name="mapId">Map ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="page">Page api results. Page size is 200.</param>
        /// <returns>List&lt;Time&gt;</returns>
        List<Time> TimeMapMapIdGet (int? mapId, int? style, int? page);
        /// <summary>
        ///  Get WR of map.
        /// </summary>
        /// <param name="mapId">Map ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <returns>Time</returns>
        Time TimeMapMapIdWrGet (int? mapId, int? style);
        /// <summary>
        ///  50 recent times.
        /// </summary>
        /// <param name="date">Filter out all times before unix time stamp.</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="map">Map ID filter</param>
        /// <returns>List&lt;Time&gt;</returns>
        List<Time> TimeRecentGet (int? date, int? style, int? game, int? map);
        /// <summary>
        ///  10 recent world records.
        /// </summary>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="whitelist">Filters for only players on the whitelist</param>
        /// <returns>List&lt;Time&gt;</returns>
        List<Time> TimeRecentWrGet (int? style, int? game, bool? whitelist);
        /// <summary>
        ///  Time from id.
        /// </summary>
        /// <param name="timeId">Time ID filter</param>
        /// <returns>Time</returns>
        Time TimeTimeIdGet (int? timeId);
        /// <summary>
        ///  Time rank from id.
        /// </summary>
        /// <param name="timeId">Time ID filter</param>
        /// <returns>Object</returns>
        Object TimeTimeIdRankGet (int? timeId);
        /// <summary>
        ///  Time by user id.
        /// </summary>
        /// <param name="userId">User ID filter</param>
        /// <param name="map">Map ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="page">Page api results. Page size is 200.</param>
        /// <returns>List&lt;Time&gt;</returns>
        List<Time> TimeUserUserIdGet (int? userId, int? map, int? style, int? game, int? page);
        /// <summary>
        ///  World records by user id.
        /// </summary>
        /// <param name="userId">User ID filter</param>
        /// <param name="game">Game ID filter</param>
        /// <param name="style">Style ID filter</param>
        /// <returns>List&lt;Time&gt;</returns>
        List<Time> TimeUserUserIdWrGet (int? userId, int? game, int? style);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TimeApi : ITimeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TimeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TimeApi(String basePath)
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
        ///  Time by map id. Sorted in ascending order.
        /// </summary>
        /// <param name="mapId">Map ID filter</param> 
        /// <param name="style">Style ID filter</param> 
        /// <param name="page">Page api results. Page size is 200.</param> 
        /// <returns>List&lt;Time&gt;</returns>            
        public List<Time> TimeMapMapIdGet (int? mapId, int? style, int? page)
        {
            
            // verify the required parameter 'mapId' is set
            if (mapId == null) throw new ApiException(400, "Missing required parameter 'mapId' when calling TimeMapMapIdGet");
            
    
            var path = "/time/map/{mapId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "mapId" + "}", ApiClient.ParameterToString(mapId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (style != null) queryParams.Add("style", ApiClient.ParameterToString(style)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeMapMapIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeMapMapIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Time>) ApiClient.Deserialize(response.Content, typeof(List<Time>), response.Headers);
        }
    
        /// <summary>
        ///  Get WR of map.
        /// </summary>
        /// <param name="mapId">Map ID filter</param> 
        /// <param name="style">Style ID filter</param> 
        /// <returns>Time</returns>            
        public Time TimeMapMapIdWrGet (int? mapId, int? style)
        {
            
            // verify the required parameter 'mapId' is set
            if (mapId == null) throw new ApiException(400, "Missing required parameter 'mapId' when calling TimeMapMapIdWrGet");
            
            // verify the required parameter 'style' is set
            if (style == null) throw new ApiException(400, "Missing required parameter 'style' when calling TimeMapMapIdWrGet");
            
    
            var path = "/time/map/{mapId}/wr";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "mapId" + "}", ApiClient.ParameterToString(mapId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (style != null) queryParams.Add("style", ApiClient.ParameterToString(style)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeMapMapIdWrGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeMapMapIdWrGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Time) ApiClient.Deserialize(response.Content, typeof(Time), response.Headers);
        }
    
        /// <summary>
        ///  50 recent times.
        /// </summary>
        /// <param name="date">Filter out all times before unix time stamp.</param> 
        /// <param name="style">Style ID filter</param> 
        /// <param name="game">Game ID filter</param> 
        /// <param name="map">Map ID filter</param> 
        /// <returns>List&lt;Time&gt;</returns>            
        public List<Time> TimeRecentGet (int? date, int? style, int? game, int? map)
        {
            
    
            var path = "/time/recent";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
 if (style != null) queryParams.Add("style", ApiClient.ParameterToString(style)); // query parameter
 if (game != null) queryParams.Add("game", ApiClient.ParameterToString(game)); // query parameter
 if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeRecentGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeRecentGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Time>) ApiClient.Deserialize(response.Content, typeof(List<Time>), response.Headers);
        }
    
        /// <summary>
        ///  10 recent world records.
        /// </summary>
        /// <param name="style">Style ID filter</param> 
        /// <param name="game">Game ID filter</param> 
        /// <param name="whitelist">Filters for only players on the whitelist</param> 
        /// <returns>List&lt;Time&gt;</returns>            
        public List<Time> TimeRecentWrGet (int? style, int? game, bool? whitelist)
        {
            
            // verify the required parameter 'style' is set
            if (style == null) throw new ApiException(400, "Missing required parameter 'style' when calling TimeRecentWrGet");
            
            // verify the required parameter 'game' is set
            if (game == null) throw new ApiException(400, "Missing required parameter 'game' when calling TimeRecentWrGet");
            
    
            var path = "/time/recent/wr";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (style != null) queryParams.Add("style", ApiClient.ParameterToString(style)); // query parameter
 if (game != null) queryParams.Add("game", ApiClient.ParameterToString(game)); // query parameter
 if (whitelist != null) queryParams.Add("whitelist", ApiClient.ParameterToString(whitelist)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeRecentWrGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeRecentWrGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Time>) ApiClient.Deserialize(response.Content, typeof(List<Time>), response.Headers);
        }
    
        /// <summary>
        ///  Time from id.
        /// </summary>
        /// <param name="timeId">Time ID filter</param> 
        /// <returns>Time</returns>            
        public Time TimeTimeIdGet (int? timeId)
        {
            
            // verify the required parameter 'timeId' is set
            if (timeId == null) throw new ApiException(400, "Missing required parameter 'timeId' when calling TimeTimeIdGet");
            
    
            var path = "/time/{timeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "timeId" + "}", ApiClient.ParameterToString(timeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TimeTimeIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeTimeIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Time) ApiClient.Deserialize(response.Content, typeof(Time), response.Headers);
        }
    
        /// <summary>
        ///  Time rank from id.
        /// </summary>
        /// <param name="timeId">Time ID filter</param> 
        /// <returns>Object</returns>            
        public Object TimeTimeIdRankGet (int? timeId)
        {
            
            // verify the required parameter 'timeId' is set
            if (timeId == null) throw new ApiException(400, "Missing required parameter 'timeId' when calling TimeTimeIdRankGet");
            
    
            var path = "/time/{timeId}/rank";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "timeId" + "}", ApiClient.ParameterToString(timeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TimeTimeIdRankGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeTimeIdRankGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Time by user id.
        /// </summary>
        /// <param name="userId">User ID filter</param> 
        /// <param name="map">Map ID filter</param> 
        /// <param name="style">Style ID filter</param> 
        /// <param name="game">Game ID filter</param> 
        /// <param name="page">Page api results. Page size is 200.</param> 
        /// <returns>List&lt;Time&gt;</returns>            
        public List<Time> TimeUserUserIdGet (int? userId, int? map, int? style, int? game, int? page)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling TimeUserUserIdGet");
            
    
            var path = "/time/user/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
 if (style != null) queryParams.Add("style", ApiClient.ParameterToString(style)); // query parameter
 if (game != null) queryParams.Add("game", ApiClient.ParameterToString(game)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeUserUserIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeUserUserIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Time>) ApiClient.Deserialize(response.Content, typeof(List<Time>), response.Headers);
        }
    
        /// <summary>
        ///  World records by user id.
        /// </summary>
        /// <param name="userId">User ID filter</param> 
        /// <param name="game">Game ID filter</param> 
        /// <param name="style">Style ID filter</param> 
        /// <returns>List&lt;Time&gt;</returns>            
        public List<Time> TimeUserUserIdWrGet (int? userId, int? game, int? style)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling TimeUserUserIdWrGet");
            
            // verify the required parameter 'game' is set
            if (game == null) throw new ApiException(400, "Missing required parameter 'game' when calling TimeUserUserIdWrGet");
            
            // verify the required parameter 'style' is set
            if (style == null) throw new ApiException(400, "Missing required parameter 'style' when calling TimeUserUserIdWrGet");
            
    
            var path = "/time/user/{userId}/wr";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (game != null) queryParams.Add("game", ApiClient.ParameterToString(game)); // query parameter
 if (style != null) queryParams.Add("style", ApiClient.ParameterToString(style)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api-key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeUserUserIdWrGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TimeUserUserIdWrGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Time>) ApiClient.Deserialize(response.Content, typeof(List<Time>), response.Headers);
        }
    
    }
}
