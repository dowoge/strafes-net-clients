# coding: utf-8

"""
    StrafesNET Public API

    ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ```   # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from swagger_client.api_client import ApiClient


class MapApi(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def map_get(self, **kwargs):  # noqa: E501
        """map_get  # noqa: E501

        Get list of maps.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.map_get(async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int game: Game ID filter
        :param int page: Page api results. Page size is 200.
        :return: list[Map]
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.map_get_with_http_info(**kwargs)  # noqa: E501
        else:
            (data) = self.map_get_with_http_info(**kwargs)  # noqa: E501
            return data

    def map_get_with_http_info(self, **kwargs):  # noqa: E501
        """map_get  # noqa: E501

        Get list of maps.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.map_get_with_http_info(async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int game: Game ID filter
        :param int page: Page api results. Page size is 200.
        :return: list[Map]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['game', 'page']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method map_get" % key
                )
            params[key] = val
        del params['kwargs']

        collection_formats = {}

        path_params = {}

        query_params = []
        if 'game' in params:
            query_params.append(('game', params['game']))  # noqa: E501
        if 'page' in params:
            query_params.append(('page', params['page']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # Authentication setting
        auth_settings = ['api-key']  # noqa: E501

        return self.api_client.call_api(
            '/map', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='list[Map]',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def map_map_id_get(self, map_id, **kwargs):  # noqa: E501
        """map_map_id_get  # noqa: E501

        Get map by ID.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.map_map_id_get(map_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int map_id: Map ID filter (required)
        :return: Map
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.map_map_id_get_with_http_info(map_id, **kwargs)  # noqa: E501
        else:
            (data) = self.map_map_id_get_with_http_info(map_id, **kwargs)  # noqa: E501
            return data

    def map_map_id_get_with_http_info(self, map_id, **kwargs):  # noqa: E501
        """map_map_id_get  # noqa: E501

        Get map by ID.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.map_map_id_get_with_http_info(map_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int map_id: Map ID filter (required)
        :return: Map
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['map_id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method map_map_id_get" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'map_id' is set
        if self.api_client.client_side_validation and ('map_id' not in params or
                                                       params['map_id'] is None):  # noqa: E501
            raise ValueError("Missing the required parameter `map_id` when calling `map_map_id_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'map_id' in params:
            path_params['mapId'] = params['map_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # Authentication setting
        auth_settings = ['api-key']  # noqa: E501

        return self.api_client.call_api(
            '/map/{mapId}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Map',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)
