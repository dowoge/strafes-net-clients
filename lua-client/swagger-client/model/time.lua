--[[
  StrafesNET Public API
 
  ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 
  OpenAPI spec version: 1.0.0
  
  Generated by: https://github.com/swagger-api/swagger-codegen.git
]]

-- time class
local time = {}
local time_mt = {
	__name = "time";
	__index = time;
}

local function cast_time(t)
	return setmetatable(t, time_mt)
end

local function new_time(ID, time, user, map, date, style, mode, game)
	return cast_time({
		["ID"] = ID;
		["Time"] = time;
		["User"] = user;
		["Map"] = map;
		["Date"] = date;
		["Style"] = style;
		["Mode"] = mode;
		["Game"] = game;
	})
end

return {
	cast = cast_time;
	new = new_time;
}
