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

  beforeEach(function() {
    instance = new StrafesNetPublicApi.MapApi();
  });

  describe('(package)', function() {
    describe('MapApi', function() {
      describe('mapGet', function() {
        it('should call mapGet successfully', function(done) {
          // TODO: uncomment, update parameter values for mapGet call and complete the assertions
          /*
          var opts = {};
          opts.game = 56;
          opts.page = 56;

          instance.mapGet(opts, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            let dataCtr = data;
            expect(dataCtr).to.be.an(Array);
            expect(dataCtr).to.not.be.empty();
            for (let p in dataCtr) {
              let data = dataCtr[p];
              expect(data).to.be.a(StrafesNetPublicApi.Map);
              expect(data.ID).to.be.a('number');
              expect(data.ID).to.be(0);
              expect(data.displayName).to.be.a('string');
              expect(data.displayName).to.be("");
              expect(data.creator).to.be.a('string');
              expect(data.creator).to.be("");
              expect(data.game).to.be.a('number');
              expect(data.game).to.be(0);
              expect(data._date).to.be.a('number');
              expect(data._date).to.be(0);
              expect(data.playCount).to.be.a('number');
              expect(data.playCount).to.be(0);
            }

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('mapMapIdGet', function() {
        it('should call mapMapIdGet successfully', function(done) {
          // TODO: uncomment, update parameter values for mapMapIdGet call and complete the assertions
          /*
          var mapId = 56;

          instance.mapMapIdGet(mapId, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(StrafesNetPublicApi.Map);
            expect(data.ID).to.be.a('number');
            expect(data.ID).to.be(0);
            expect(data.displayName).to.be.a('string');
            expect(data.displayName).to.be("");
            expect(data.creator).to.be.a('string');
            expect(data.creator).to.be("");
            expect(data.game).to.be.a('number');
            expect(data.game).to.be(0);
            expect(data._date).to.be.a('number');
            expect(data._date).to.be(0);
            expect(data.playCount).to.be.a('number');
            expect(data.playCount).to.be(0);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
    });
  });

}));
