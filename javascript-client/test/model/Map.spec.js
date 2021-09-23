/*
 * StrafesNET Public API
 * ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 *
 * OpenAPI spec version: 1.0.0
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.21
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.StrafesNetPublicApi);
  }
}(this, function(expect, StrafesNetPublicApi) {
  'use strict';

  var instance;

  describe('(package)', function() {
    describe('Map', function() {
      beforeEach(function() {
        instance = new StrafesNetPublicApi.Map();
      });

      it('should create an instance of Map', function() {
        // TODO: update the code to test Map
        expect(instance).to.be.a(StrafesNetPublicApi.Map);
      });

      it('should have the property ID (base name: "ID")', function() {
        // TODO: update the code to test the property ID
        expect(instance).to.have.property('ID');
        // expect(instance.ID).to.be(expectedValueLiteral);
      });

      it('should have the property displayName (base name: "DisplayName")', function() {
        // TODO: update the code to test the property displayName
        expect(instance).to.have.property('displayName');
        // expect(instance.displayName).to.be(expectedValueLiteral);
      });

      it('should have the property creator (base name: "Creator")', function() {
        // TODO: update the code to test the property creator
        expect(instance).to.have.property('creator');
        // expect(instance.creator).to.be(expectedValueLiteral);
      });

      it('should have the property game (base name: "Game")', function() {
        // TODO: update the code to test the property game
        expect(instance).to.have.property('game');
        // expect(instance.game).to.be(expectedValueLiteral);
      });

      it('should have the property _date (base name: "Date")', function() {
        // TODO: update the code to test the property _date
        expect(instance).to.have.property('_date');
        // expect(instance._date).to.be(expectedValueLiteral);
      });

      it('should have the property playCount (base name: "PlayCount")', function() {
        // TODO: update the code to test the property playCount
        expect(instance).to.have.property('playCount');
        // expect(instance.playCount).to.be(expectedValueLiteral);
      });

    });
  });

}));
