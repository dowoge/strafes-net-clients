# coding: utf-8

"""
    StrafesNET Public API

    ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ```   # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.rank_api import RankApi  # noqa: E501
from swagger_client.rest import ApiException


class TestRankApi(unittest.TestCase):
    """RankApi unit test stubs"""

    def setUp(self):
        self.api = swagger_client.api.rank_api.RankApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_rank_get(self):
        """Test case for rank_get

        """
        pass

    def test_rank_user_id_get(self):
        """Test case for rank_user_id_get

        """
        pass


if __name__ == '__main__':
    unittest.main()
