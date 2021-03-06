/*
 * StrafesNET Public API
 * ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 *
 * OpenAPI spec version: 1.0.0
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.21
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.StrafesNetPublicApi) {
      root.StrafesNetPublicApi = {};
    }
    root.StrafesNetPublicApi.ApiError = factory(root.StrafesNetPublicApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ApiError model module.
   * @module model/ApiError
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>ApiError</code>.
   * @alias module:model/ApiError
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>ApiError</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ApiError} obj Optional instance to populate.
   * @return {module:model/ApiError} The populated <code>ApiError</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('code'))
        obj.code = ApiClient.convertToType(data['code'], 'Number');
      if (data.hasOwnProperty('message'))
        obj.message = ApiClient.convertToType(data['message'], 'String');
      if (data.hasOwnProperty('reference'))
        obj.reference = ApiClient.convertToType(data['reference'], 'String');
    }
    return obj;
  }

  /**
   * @member {Number} code
   */
  exports.prototype.code = undefined;

  /**
   * @member {String} message
   */
  exports.prototype.message = undefined;

  /**
   * @member {String} reference
   */
  exports.prototype.reference = undefined;


  return exports;

}));
