/* 
 * StrafesNET Public API
 *
 * ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

use hyper;
use std::collections::HashMap;

pub struct Configuration<C: hyper::client::Connect> {
  pub base_path: String,
  pub user_agent: Option<String>,
  pub client: hyper::client::Client<C>,
  pub basic_auth: Option<BasicAuth>,
  pub oauth_access_token: Option<String>,
  pub api_key: Option<ApiKey>,
  // TODO: take an oauth2 token source, similar to the go one
}

pub type BasicAuth = (String, Option<String>);

pub struct ApiKey {
  pub prefix: Option<String>,
  pub key: String,
}

impl<C: hyper::client::Connect> Configuration<C> {
  pub fn new(client: hyper::client::Client<C>) -> Configuration<C> {
    Configuration {
      base_path: "https://api.strafes.net/v1".to_owned(),
      user_agent: Some("Swagger-Codegen/1.0.0/rust".to_owned()),
      client: client,
      basic_auth: None,
      oauth_access_token: None,
      api_key: None,
    }
  }
}
