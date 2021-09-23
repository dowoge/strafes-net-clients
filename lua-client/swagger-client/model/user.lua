--[[
  StrafesNET Public API
 
  ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 
  OpenAPI spec version: 1.0.0
  
  Generated by: https://github.com/swagger-api/swagger-codegen.git
]]

-- user class
local user = {}
local user_mt = {
	__name = "user";
	__index = user;
}

local function cast_user(t)
	return setmetatable(t, user_mt)
end

local function new_user(ID, username, state)
	return cast_user({
		["ID"] = ID;
		["Username"] = username;
		["State"] = state;
	})
end

return {
	cast = cast_user;
	new = new_user;
}
