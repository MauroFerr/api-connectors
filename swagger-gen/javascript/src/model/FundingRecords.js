/**
 * Bybit API
 * ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.8
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.BybitApi) {
      root.BybitApi = {};
    }
    root.BybitApi.FundingRecords = factory(root.BybitApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The FundingRecords model module.
   * @module model/FundingRecords
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>FundingRecords</code>.
   * Get funding record response
   * @alias module:model/FundingRecords
   * @class
   */
  var exports = function() {
    var _this = this;












  };

  /**
   * Constructs a <code>FundingRecords</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/FundingRecords} obj Optional instance to populate.
   * @return {module:model/FundingRecords} The populated <code>FundingRecords</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Number');
      }
      if (data.hasOwnProperty('user_id')) {
        obj['user_id'] = ApiClient.convertToType(data['user_id'], 'Number');
      }
      if (data.hasOwnProperty('coin')) {
        obj['coin'] = ApiClient.convertToType(data['coin'], 'String');
      }
      if (data.hasOwnProperty('wallet_id')) {
        obj['wallet_id'] = ApiClient.convertToType(data['wallet_id'], 'Number');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('amount')) {
        obj['amount'] = ApiClient.convertToType(data['amount'], 'String');
      }
      if (data.hasOwnProperty('tx_id')) {
        obj['tx_id'] = ApiClient.convertToType(data['tx_id'], 'String');
      }
      if (data.hasOwnProperty('address')) {
        obj['address'] = ApiClient.convertToType(data['address'], 'String');
      }
      if (data.hasOwnProperty('wallet_balance')) {
        obj['wallet_balance'] = ApiClient.convertToType(data['wallet_balance'], 'String');
      }
      if (data.hasOwnProperty('exec_time')) {
        obj['exec_time'] = ApiClient.convertToType(data['exec_time'], 'String');
      }
      if (data.hasOwnProperty('cross_seq')) {
        obj['cross_seq'] = ApiClient.convertToType(data['cross_seq'], 'Number');
      }
    }
    return obj;
  }

  /**
   * @member {Number} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {Number} user_id
   */
  exports.prototype['user_id'] = undefined;
  /**
   * @member {String} coin
   */
  exports.prototype['coin'] = undefined;
  /**
   * @member {Number} wallet_id
   */
  exports.prototype['wallet_id'] = undefined;
  /**
   * @member {String} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {String} amount
   */
  exports.prototype['amount'] = undefined;
  /**
   * @member {String} tx_id
   */
  exports.prototype['tx_id'] = undefined;
  /**
   * @member {String} address
   */
  exports.prototype['address'] = undefined;
  /**
   * @member {String} wallet_balance
   */
  exports.prototype['wallet_balance'] = undefined;
  /**
   * @member {String} exec_time
   */
  exports.prototype['exec_time'] = undefined;
  /**
   * @member {Number} cross_seq
   */
  exports.prototype['cross_seq'] = undefined;



  return exports;
}));


