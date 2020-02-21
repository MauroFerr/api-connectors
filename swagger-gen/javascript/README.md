# bybit_api

BybitApi - JavaScript client for bybit_api
## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
This SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- Package version: 1.0.0
- Build package: io.swagger.codegen.languages.JavascriptClientCodegen

## Installation

### For [Node.js](https://nodejs.org/)

#### npm

To publish the library as a [npm](https://www.npmjs.com/),
please follow the procedure in ["Publishing npm packages"](https://docs.npmjs.com/getting-started/publishing-npm-packages).

Then install it via:

```shell
npm install bybit_api --save
```

##### Local development

To use the library locally without publishing to a remote npm registry, first install the dependencies by changing 
into the directory containing `package.json` (and this README). Let's call this `JAVASCRIPT_CLIENT_DIR`. Then run:

```shell
npm install
```

Next, [link](https://docs.npmjs.com/cli/link) it globally in npm with the following, also from `JAVASCRIPT_CLIENT_DIR`:

```shell
npm link
```

Finally, switch to the directory you want to use your bybit_api from, and run:

```shell
npm link /path/to/<JAVASCRIPT_CLIENT_DIR>
```

You should now be able to `require('bybit_api')` in javascript files from the directory you ran the last 
command above from.

#### git
#
If the library is hosted at a git repository, e.g.
https://github.com/GIT_USER_ID/GIT_REPO_ID
then install it via:

```shell
    npm install GIT_USER_ID/GIT_REPO_ID --save
```

### For browser

The library also works in the browser environment via npm and [browserify](http://browserify.org/). After following
the above steps with Node.js and installing browserify with `npm install -g browserify`,
perform the following (assuming *main.js* is your entry file, that's to say your javascript file where you actually 
use this library):

```shell
browserify main.js > bundle.js
```

Then include *bundle.js* in the HTML pages.

### Webpack Configuration

Using Webpack you may encounter the following error: "Module not found: Error:
Cannot resolve module", most certainly you should disable AMD loader. Add/merge
the following section to your webpack config:

```javascript
module: {
  rules: [
    {
      parser: {
        amd: false
      }
    }
  ]
}
```

## Getting Started

Please follow the [installation](#installation) instruction and execute the following JS code:

```javascript
var BybitApi = require('bybit_api');

var defaultClient = BybitApi.ApiClient.instance;

// Configure API key authorization: apiKey
var apiKey = defaultClient.authentications['apiKey'];
apiKey.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKey.apiKeyPrefix['api_key'] = "Token"

// Configure API key authorization: apiSignature
var apiSignature = defaultClient.authentications['apiSignature'];
apiSignature.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiSignature.apiKeyPrefix['sign'] = "Token"

// Configure API key authorization: timestamp
var timestamp = defaultClient.authentications['timestamp'];
timestamp.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//timestamp.apiKeyPrefix['timestamp'] = "Token"

var api = new BybitApi.APIkeyApi()

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.aPIkeyInfo(callback);

```

## Documentation for API Endpoints

All URIs are relative to *https://api-testnet.bybit.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BybitApi.APIkeyApi* | [**aPIkeyInfo**](docs/APIkeyApi.md#aPIkeyInfo) | **GET** /open-api/api-key | Get account api-key information.
*BybitApi.CommonApi* | [**commonGet**](docs/CommonApi.md#commonGet) | **GET** /v2/public/time | Get bybit server time.
*BybitApi.ConditionalApi* | [**conditionalCancel**](docs/ConditionalApi.md#conditionalCancel) | **POST** /open-api/stop-order/cancel | Cancel conditional order.
*BybitApi.ConditionalApi* | [**conditionalCancelAll**](docs/ConditionalApi.md#conditionalCancelAll) | **POST** /v2/private/stop-order/cancelAll | Cancel conditional order.
*BybitApi.ConditionalApi* | [**conditionalGetOrders**](docs/ConditionalApi.md#conditionalGetOrders) | **GET** /open-api/stop-order/list | Get my conditional order list.
*BybitApi.ConditionalApi* | [**conditionalNew**](docs/ConditionalApi.md#conditionalNew) | **POST** /open-api/stop-order/create | Place a new conditional order.
*BybitApi.ConditionalApi* | [**conditionalReplace**](docs/ConditionalApi.md#conditionalReplace) | **POST** /open-api/stop-order/replace | Replace conditional order. Only incomplete orders can be modified. 
*BybitApi.ExecutionApi* | [**executionGetTrades**](docs/ExecutionApi.md#executionGetTrades) | **GET** /v2/private/execution/list | Get user’s trade records.
*BybitApi.FundingApi* | [**fundingGetRate**](docs/FundingApi.md#fundingGetRate) | **GET** /open-api/funding/prev-funding | Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
*BybitApi.FundingApi* | [**fundingPredicted**](docs/FundingApi.md#fundingPredicted) | **GET** /open-api/funding/predicted-funding | Get predicted funding rate and funding fee.
*BybitApi.FundingApi* | [**fundingPredictedRate**](docs/FundingApi.md#fundingPredictedRate) | **GET** /open-api/funding/prev-funding-rate | Get predicted funding rate and funding fee.
*BybitApi.KlineApi* | [**klineGet**](docs/KlineApi.md#klineGet) | **GET** /v2/public/kline/list | Query historical kline.
*BybitApi.MarketApi* | [**marketOrderbook**](docs/MarketApi.md#marketOrderbook) | **GET** /v2/public/orderBook/L2 | Get the orderbook.
*BybitApi.MarketApi* | [**marketSymbolInfo**](docs/MarketApi.md#marketSymbolInfo) | **GET** /v2/public/tickers | Get the latest information for symbol.
*BybitApi.OrderApi* | [**orderCancel**](docs/OrderApi.md#orderCancel) | **POST** /open-api/order/cancel | Get my active order list.
*BybitApi.OrderApi* | [**orderCancelAll**](docs/OrderApi.md#orderCancelAll) | **POST** /v2/private/order/cancelAll | Get my active order list.
*BybitApi.OrderApi* | [**orderCancelV2**](docs/OrderApi.md#orderCancelV2) | **POST** /v2/private/order/cancel | Get my active order list.
*BybitApi.OrderApi* | [**orderGetOrders**](docs/OrderApi.md#orderGetOrders) | **GET** /open-api/order/list | Get my active order list.
*BybitApi.OrderApi* | [**orderNew**](docs/OrderApi.md#orderNew) | **POST** /open-api/order/create | Place active order
*BybitApi.OrderApi* | [**orderNewV2**](docs/OrderApi.md#orderNewV2) | **POST** /v2/private/order/create | Place active order
*BybitApi.OrderApi* | [**orderQuery**](docs/OrderApi.md#orderQuery) | **GET** /v2/private/order | Get my active order list.
*BybitApi.OrderApi* | [**orderReplace**](docs/OrderApi.md#orderReplace) | **POST** /open-api/order/replace | Replace active order. Only incomplete orders can be modified. 
*BybitApi.PositionsApi* | [**positionsChangeMargin**](docs/PositionsApi.md#positionsChangeMargin) | **POST** /position/change-position-margin | Update margin.
*BybitApi.PositionsApi* | [**positionsMyPosition**](docs/PositionsApi.md#positionsMyPosition) | **GET** /position/list | Get my position list.
*BybitApi.PositionsApi* | [**positionsMyPositionV2**](docs/PositionsApi.md#positionsMyPositionV2) | **GET** /v2/private/position/list | Get my position list.
*BybitApi.PositionsApi* | [**positionsSaveLeverage**](docs/PositionsApi.md#positionsSaveLeverage) | **POST** /user/leverage/save | Change user leverage.
*BybitApi.PositionsApi* | [**positionsTradingStop**](docs/PositionsApi.md#positionsTradingStop) | **POST** /open-api/position/trading-stop | Set Trading-Stop Condition.
*BybitApi.PositionsApi* | [**positionsUserLeverage**](docs/PositionsApi.md#positionsUserLeverage) | **GET** /user/leverage | Get user leverage setting.
*BybitApi.SymbolApi* | [**symbolGet**](docs/SymbolApi.md#symbolGet) | **GET** /v2/public/symbols | Query Symbols.
*BybitApi.WalletApi* | [**walletGetRecords**](docs/WalletApi.md#walletGetRecords) | **GET** /open-api/wallet/fund/records | Get wallet fund records
*BybitApi.WalletApi* | [**walletGetRiskLimit**](docs/WalletApi.md#walletGetRiskLimit) | **GET** /open-api/wallet/risk-limit/list | Get risk limit.
*BybitApi.WalletApi* | [**walletSetRiskLimit**](docs/WalletApi.md#walletSetRiskLimit) | **POST** /open-api/wallet/risk-limit | Set risk limit
*BybitApi.WalletApi* | [**walletWithdraw**](docs/WalletApi.md#walletWithdraw) | **GET** /open-api/wallet/withdraw/list | Get wallet fund records


## Documentation for Models

 - [BybitApi.APIKeyBase](docs/APIKeyBase.md)
 - [BybitApi.APIKeyInfo](docs/APIKeyInfo.md)
 - [BybitApi.ConditionalBase](docs/ConditionalBase.md)
 - [BybitApi.ConditionalCancelAllBase](docs/ConditionalCancelAllBase.md)
 - [BybitApi.ConditionalCancelAllRes](docs/ConditionalCancelAllRes.md)
 - [BybitApi.ConditionalOrdersRes](docs/ConditionalOrdersRes.md)
 - [BybitApi.ConditionalOrdersResBase](docs/ConditionalOrdersResBase.md)
 - [BybitApi.ConditionalRes](docs/ConditionalRes.md)
 - [BybitApi.ExtFields](docs/ExtFields.md)
 - [BybitApi.FundRecordBase](docs/FundRecordBase.md)
 - [BybitApi.FundingFeeBase](docs/FundingFeeBase.md)
 - [BybitApi.FundingFeeRes](docs/FundingFeeRes.md)
 - [BybitApi.FundingPredicted](docs/FundingPredicted.md)
 - [BybitApi.FundingPredictedBase](docs/FundingPredictedBase.md)
 - [BybitApi.FundingRate](docs/FundingRate.md)
 - [BybitApi.FundingRateBase](docs/FundingRateBase.md)
 - [BybitApi.FundingRecords](docs/FundingRecords.md)
 - [BybitApi.GetRiskLimitRes](docs/GetRiskLimitRes.md)
 - [BybitApi.KlineBase](docs/KlineBase.md)
 - [BybitApi.KlineRes](docs/KlineRes.md)
 - [BybitApi.Leverage](docs/Leverage.md)
 - [BybitApi.LeverageInfo](docs/LeverageInfo.md)
 - [BybitApi.LeverageResult](docs/LeverageResult.md)
 - [BybitApi.LotSizeFilter](docs/LotSizeFilter.md)
 - [BybitApi.OderBookRes](docs/OderBookRes.md)
 - [BybitApi.OrderBookBase](docs/OrderBookBase.md)
 - [BybitApi.OrderCancelAllBase](docs/OrderCancelAllBase.md)
 - [BybitApi.OrderCancelAllRes](docs/OrderCancelAllRes.md)
 - [BybitApi.OrderCancelBase](docs/OrderCancelBase.md)
 - [BybitApi.OrderListBase](docs/OrderListBase.md)
 - [BybitApi.OrderListData](docs/OrderListData.md)
 - [BybitApi.OrderRes](docs/OrderRes.md)
 - [BybitApi.OrderResBase](docs/OrderResBase.md)
 - [BybitApi.Position](docs/Position.md)
 - [BybitApi.PositionInfo](docs/PositionInfo.md)
 - [BybitApi.PriceFilter](docs/PriceFilter.md)
 - [BybitApi.QueryOrderBase](docs/QueryOrderBase.md)
 - [BybitApi.QueryOrderRes](docs/QueryOrderRes.md)
 - [BybitApi.ReplaceConditionalBase](docs/ReplaceConditionalBase.md)
 - [BybitApi.ReplaceOrderBase](docs/ReplaceOrderBase.md)
 - [BybitApi.RiskIDRes](docs/RiskIDRes.md)
 - [BybitApi.RiskLimitBase](docs/RiskLimitBase.md)
 - [BybitApi.RiskLimitRes](docs/RiskLimitRes.md)
 - [BybitApi.ServerTime](docs/ServerTime.md)
 - [BybitApi.SetRiskLimitBase](docs/SetRiskLimitBase.md)
 - [BybitApi.SymbolInfo](docs/SymbolInfo.md)
 - [BybitApi.SymbolInfoBase](docs/SymbolInfoBase.md)
 - [BybitApi.SymbolTickInfo](docs/SymbolTickInfo.md)
 - [BybitApi.Symbols](docs/Symbols.md)
 - [BybitApi.TradeRecords](docs/TradeRecords.md)
 - [BybitApi.TradeRecordsBase](docs/TradeRecordsBase.md)
 - [BybitApi.TradeRecordsInfo](docs/TradeRecordsInfo.md)
 - [BybitApi.TradingStopBase](docs/TradingStopBase.md)
 - [BybitApi.TradingStopRes](docs/TradingStopRes.md)
 - [BybitApi.WithdrawRecords](docs/WithdrawRecords.md)
 - [BybitApi.WithdrawResBase](docs/WithdrawResBase.md)


## Documentation for Authorization


### apiKey

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: URL query string

### apiSignature

- **Type**: API key
- **API key parameter name**: sign
- **Location**: URL query string

### timestamp

- **Type**: API key
- **API key parameter name**: timestamp
- **Location**: URL query string
