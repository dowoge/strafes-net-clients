/*
 * StrafesNET Public API
 *
 * ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */

package swagger

// If a new time is made it will retain the previous time's id.
type Time struct {
	ID int32 `json:"ID,omitempty"`
	Time int32 `json:"Time,omitempty"`
	User int32 `json:"User,omitempty"`
	Map_ int32 `json:"Map,omitempty"`
	Date int32 `json:"Date,omitempty"`
	Style int32 `json:"Style,omitempty"`
	Mode int32 `json:"Mode,omitempty"`
	Game int32 `json:"Game,omitempty"`
}
