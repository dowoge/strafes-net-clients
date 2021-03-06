--[[
  StrafesNET Public API
 
  ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 
  OpenAPI spec version: 1.0.0
  
  Generated by: https://github.com/swagger-api/swagger-codegen.git
]]

--package swagger-client

local http_request = require "http.request"
local http_util = require "http.util"
local dkjson = require "dkjson"
local basexx = require "basexx"

-- model import
local swagger_client_rank = require "swagger-client.model.rank"
local swagger_client_todo_object_mapping = require "swagger-client.model.todo_object_mapping"

local rank_api = {}
local rank_api_mt = {
	__name = "rank_api";
	__index = rank_api;
}

local function new_rank_api(host, basePath, schemes)
	local schemes_map = {}
	for _,v in ipairs(schemes) do
		schemes_map[v] = v
	end
	local default_scheme = schemes_map.https or schemes_map.http
	return setmetatable({
		host = host;
		basePath = basePath or "https://api.strafes.net/v1";
		schemes = schemes_map;
		default_scheme = default_scheme;
		http_username = nil;
		http_password = nil;
		api_key = {};
		access_token = nil;
	}, rank_api_mt)
end

function rank_api:rank_get(style, game, page)
	local req = http_request.new_from_uri({
		scheme = self.default_scheme;
		host = self.host;
		path = string.format("%s/rank?style=%s&game=%s&page=%s",
			self.basePath, http_util.encodeURIComponent(style), http_util.encodeURIComponent(game), http_util.encodeURIComponent(page));
	})

	-- set HTTP verb
	req.headers:upsert(":method", "GET")
	-- api key in headers 'api-key'
	if self.api_key['api-key'] then
		req.headers:upsert("api-key", self.api_key['api-key'])
	end

	-- make the HTTP call
	local headers, stream, errno = req:go()
	if not headers then
		return nil, stream, errno
	end
	local http_status = headers:get(":status")
	if http_status:sub(1,1) == "2" then
		local body, err, errno2 = stream:get_body_as_string()
		-- exception when getting the HTTP body
		if not body then
			return nil, err, errno2
		end
		stream:shutdown()
		local result, _, err3 = dkjson.decode(body)
		-- exception when decoding the HTTP body
		if result == nil then
			return nil, err3
		end
		for _, ob in ipairs(result) do
			swagger_client_rank.cast(ob)
		end
		return result, headers
	else
		local body, err, errno2 = stream:get_body_as_string()
		if not body then
			return nil, err, errno2
		end
		stream:shutdown()
		-- return the error message (http body)
		return nil, http_status, body
	end
end

function rank_api:rank_user_id_get(user_id, style, game)
	local req = http_request.new_from_uri({
		scheme = self.default_scheme;
		host = self.host;
		path = string.format("%s/rank/%s?style=%s&game=%s",
			self.basePath, user_id, http_util.encodeURIComponent(style), http_util.encodeURIComponent(game));
	})

	-- set HTTP verb
	req.headers:upsert(":method", "GET")
	-- api key in headers 'api-key'
	if self.api_key['api-key'] then
		req.headers:upsert("api-key", self.api_key['api-key'])
	end

	-- make the HTTP call
	local headers, stream, errno = req:go()
	if not headers then
		return nil, stream, errno
	end
	local http_status = headers:get(":status")
	if http_status:sub(1,1) == "2" then
		local body, err, errno2 = stream:get_body_as_string()
		-- exception when getting the HTTP body
		if not body then
			return nil, err, errno2
		end
		stream:shutdown()
		local result, _, err3 = dkjson.decode(body)
		-- exception when decoding the HTTP body
		if result == nil then
			return nil, err3
		end
		return swagger_client_rank.cast(result), headers
	else
		local body, err, errno2 = stream:get_body_as_string()
		if not body then
			return nil, err, errno2
		end
		stream:shutdown()
		-- return the error message (http body)
		return nil, http_status, body
	end
end

return {
	new = new_rank_api;
}

