use std::rc::Rc;

use hyper;
use super::configuration::Configuration;

pub struct APIClient<C: hyper::client::Connect> {
  configuration: Rc<Configuration<C>>,
  map_api: Box<::apis::MapApi>,
  rank_api: Box<::apis::RankApi>,
  time_api: Box<::apis::TimeApi>,
  user_api: Box<::apis::UserApi>,
}

impl<C: hyper::client::Connect> APIClient<C> {
  pub fn new(configuration: Configuration<C>) -> APIClient<C> {
    let rc = Rc::new(configuration);

    APIClient {
      configuration: rc.clone(),
      map_api: Box::new(::apis::MapApiClient::new(rc.clone())),
      rank_api: Box::new(::apis::RankApiClient::new(rc.clone())),
      time_api: Box::new(::apis::TimeApiClient::new(rc.clone())),
      user_api: Box::new(::apis::UserApiClient::new(rc.clone())),
    }
  }

  pub fn map_api(&self) -> &::apis::MapApi{
    self.map_api.as_ref()
  }

  pub fn rank_api(&self) -> &::apis::RankApi{
    self.rank_api.as_ref()
  }

  pub fn time_api(&self) -> &::apis::TimeApi{
    self.time_api.as_ref()
  }

  pub fn user_api(&self) -> &::apis::UserApi{
    self.user_api.as_ref()
  }


}
