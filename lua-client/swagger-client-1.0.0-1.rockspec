package = "swagger-client"
version = "1.0.0-1"
source = {
	url = "https://github.com/YOUR_GIT_USERNAME/YOUR_GIT_REPO.git"
}

description = {
	summary = "API client genreated by Swagger Codegen",
	detailed = [[
### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` ]],
	homepage = "https://github.com/swagger-api/swagger-codegen",
	license = "Unlicense",
	maintainer = "Swagger Codegen contributors",
}

dependencies = {
	"lua >= 5.2",
	"http",
	"dkjson",
	"basexx"
}

build = {
	type = "builtin",
	modules = {
		["swagger-client.api.map_api"] = "swagger-client/api/map_api.lua";
		["swagger-client.api.rank_api"] = "swagger-client/api/rank_api.lua";
		["swagger-client.api.time_api"] = "swagger-client/api/time_api.lua";
		["swagger-client.api.user_api"] = "swagger-client/api/user_api.lua";
		["swagger-client.model.api_error"] = "swagger-client/model/api_error.lua";
		["swagger-client.model.map"] = "swagger-client/model/map.lua";
		["swagger-client.model.rank"] = "swagger-client/model/rank.lua";
		["swagger-client.model.time"] = "swagger-client/model/time.lua";
		["swagger-client.model.user"] = "swagger-client/model/user.lua";
	}
}
