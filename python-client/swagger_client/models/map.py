# coding: utf-8

"""
    StrafesNET Public API

    ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ```   # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from swagger_client.configuration import Configuration


class Map(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'id': 'int',
        'display_name': 'str',
        'creator': 'str',
        'game': 'int',
        '_date': 'int',
        'play_count': 'int'
    }

    attribute_map = {
        'id': 'ID',
        'display_name': 'DisplayName',
        'creator': 'Creator',
        'game': 'Game',
        '_date': 'Date',
        'play_count': 'PlayCount'
    }

    def __init__(self, id=None, display_name=None, creator=None, game=None, _date=None, play_count=None, _configuration=None):  # noqa: E501
        """Map - a model defined in Swagger"""  # noqa: E501
        if _configuration is None:
            _configuration = Configuration()
        self._configuration = _configuration

        self._id = None
        self._display_name = None
        self._creator = None
        self._game = None
        self.__date = None
        self._play_count = None
        self.discriminator = None

        if id is not None:
            self.id = id
        if display_name is not None:
            self.display_name = display_name
        if creator is not None:
            self.creator = creator
        if game is not None:
            self.game = game
        if _date is not None:
            self._date = _date
        if play_count is not None:
            self.play_count = play_count

    @property
    def id(self):
        """Gets the id of this Map.  # noqa: E501


        :return: The id of this Map.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this Map.


        :param id: The id of this Map.  # noqa: E501
        :type: int
        """

        self._id = id

    @property
    def display_name(self):
        """Gets the display_name of this Map.  # noqa: E501


        :return: The display_name of this Map.  # noqa: E501
        :rtype: str
        """
        return self._display_name

    @display_name.setter
    def display_name(self, display_name):
        """Sets the display_name of this Map.


        :param display_name: The display_name of this Map.  # noqa: E501
        :type: str
        """

        self._display_name = display_name

    @property
    def creator(self):
        """Gets the creator of this Map.  # noqa: E501


        :return: The creator of this Map.  # noqa: E501
        :rtype: str
        """
        return self._creator

    @creator.setter
    def creator(self, creator):
        """Sets the creator of this Map.


        :param creator: The creator of this Map.  # noqa: E501
        :type: str
        """

        self._creator = creator

    @property
    def game(self):
        """Gets the game of this Map.  # noqa: E501


        :return: The game of this Map.  # noqa: E501
        :rtype: int
        """
        return self._game

    @game.setter
    def game(self, game):
        """Sets the game of this Map.


        :param game: The game of this Map.  # noqa: E501
        :type: int
        """

        self._game = game

    @property
    def _date(self):
        """Gets the _date of this Map.  # noqa: E501


        :return: The _date of this Map.  # noqa: E501
        :rtype: int
        """
        return self.__date

    @_date.setter
    def _date(self, _date):
        """Sets the _date of this Map.


        :param _date: The _date of this Map.  # noqa: E501
        :type: int
        """

        self.__date = _date

    @property
    def play_count(self):
        """Gets the play_count of this Map.  # noqa: E501


        :return: The play_count of this Map.  # noqa: E501
        :rtype: int
        """
        return self._play_count

    @play_count.setter
    def play_count(self, play_count):
        """Sets the play_count of this Map.


        :param play_count: The play_count of this Map.  # noqa: E501
        :type: int
        """

        self._play_count = play_count

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(Map, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, Map):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Map):
            return True

        return self.to_dict() != other.to_dict()
