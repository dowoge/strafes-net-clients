--[[
  StrafesNET Public API
 
  ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 
  OpenAPI spec version: 1.0.0
  
  Generated by: https://github.com/swagger-api/swagger-codegen.git
]]

-- api_error class
local api_error = {}
local api_error_mt = {
	__name = "api_error";
	__index = api_error;
}

local function cast_api_error(t)
	return setmetatable(t, api_error_mt)
end

local function new_api_error(code, message, reference)
	return cast_api_error({
		["code"] = code;
		["message"] = message;
		["reference"] = reference;
	})
end

return {
	cast = cast_api_error;
	new = new_api_error;
}
