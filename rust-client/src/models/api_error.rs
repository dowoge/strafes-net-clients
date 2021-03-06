/* 
 * StrafesNET Public API
 *
 * ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


#[allow(unused_imports)]
use serde_json::Value;

#[derive(Debug, Serialize, Deserialize)]
pub struct ApiError {
  #[serde(rename = "code")]
  code: Option<f32>,
  #[serde(rename = "message")]
  message: Option<String>,
  #[serde(rename = "reference")]
  reference: Option<String>
}

impl ApiError {
  pub fn new() -> ApiError {
    ApiError {
      code: None,
      message: None,
      reference: None
    }
  }

  pub fn set_code(&mut self, code: f32) {
    self.code = Some(code);
  }

  pub fn with_code(mut self, code: f32) -> ApiError {
    self.code = Some(code);
    self
  }

  pub fn code(&self) -> Option<&f32> {
    self.code.as_ref()
  }

  pub fn reset_code(&mut self) {
    self.code = None;
  }

  pub fn set_message(&mut self, message: String) {
    self.message = Some(message);
  }

  pub fn with_message(mut self, message: String) -> ApiError {
    self.message = Some(message);
    self
  }

  pub fn message(&self) -> Option<&String> {
    self.message.as_ref()
  }

  pub fn reset_message(&mut self) {
    self.message = None;
  }

  pub fn set_reference(&mut self, reference: String) {
    self.reference = Some(reference);
  }

  pub fn with_reference(mut self, reference: String) -> ApiError {
    self.reference = Some(reference);
    self
  }

  pub fn reference(&self) -> Option<&String> {
    self.reference.as_ref()
  }

  pub fn reset_reference(&mut self) {
    self.reference = None;
  }

}



