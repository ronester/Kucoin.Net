﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Objects;
using Kucoin.Net.Objects;

namespace Kucoin.Net.Interfaces
{
    /// <summary>
    /// Interface for the Kucoin client
    /// </summary>
    public interface IKucoinClient: IRestClient
    {
        /// <summary>
        /// Gets the server time
        /// </summary>
        /// <returns>The time of the server</returns>
        WebCallResult<DateTime> GetServerTime(CancellationToken ct = default);

        /// <summary>
        /// Gets the server time
        /// </summary>
        /// <returns>The time of the server</returns>
        Task<WebCallResult<DateTime>> GetServerTimeAsync(CancellationToken ct = default);

        /// <summary>
        /// Gets a list of symbols supported by the server
        /// </summary>
        /// <param name="symbol">Only get symbols for a specific symbol, for example 'BTC'</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of symbols</returns>
        WebCallResult<IEnumerable<KucoinSymbol>> GetSymbols(string? symbol = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of symbols supported by the server
        /// </summary>
        /// <param name="symbol">Only get symbols for a specific symbol, for example 'BTC'</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of symbols</returns>
        Task<WebCallResult<IEnumerable<KucoinSymbol>>> GetSymbolsAsync(string? symbol = null, CancellationToken ct = default);

        /// <summary>
        /// Gets ticker info of a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get info for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Ticker info</returns>
        WebCallResult<KucoinTick> GetTicker(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Gets ticker info of a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get info for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Ticker info</returns>
        Task<WebCallResult<KucoinTick>> GetTickerAsync(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Gets the ticker for all trading pairs
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of tickers</returns>
        WebCallResult<KucoinTicks> GetTickers(CancellationToken ct = default);

        /// <summary>
        /// Gets the ticker for all trading pairs
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of tickers</returns>
        Task<WebCallResult<KucoinTicks>> GetTickersAsync(CancellationToken ct = default);

        /// <summary>
        /// Gets the 24 hour stats of a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get stats for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>24 hour stats</returns>
        WebCallResult<Kucoin24HourStat> Get24HourStats(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Gets the 24 hour stats of a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get stats for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>24 hour stats</returns>
        Task<WebCallResult<Kucoin24HourStat>> Get24HourStatsAsync(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of supported markets
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of markets</returns>
        WebCallResult<IEnumerable<string>> GetMarkets(CancellationToken ct = default);

        /// <summary>
        /// Gets a list of supported markets
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of markets</returns>
        Task<WebCallResult<IEnumerable<string>>> GetMarketsAsync(CancellationToken ct = default);

        /// <summary>
        /// Get a partial aggregated order book for a symbol. Orders for the same price are combined and amount results are limited.
        /// </summary>
        /// <param name="symbol">The symbol to get order book for</param>
        /// <param name="limit">The limit of results (20 / 100)</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Partial aggregated order book</returns>
        WebCallResult<KucoinOrderBook> GetAggregatedPartialOrderBook(string symbol, int limit, CancellationToken ct = default);

        /// <summary>
        /// Get a partial aggregated order book for a symbol. Orders for the same price are combined and amount results are limited.
        /// </summary>
        /// <param name="symbol">The symbol to get order book for</param>
        /// <param name="limit">The limit of results (20 / 100)</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Partial aggregated order book</returns>
        Task<WebCallResult<KucoinOrderBook>> GetAggregatedPartialOrderBookAsync(string symbol, int limit, CancellationToken ct = default);

        /// <summary>
        /// Get a full aggregated order book for a symbol. Orders for the same price are combined.
        /// </summary>
        /// <param name="symbol">The symbol to get order book for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Full aggregated order book</returns>
        WebCallResult<KucoinOrderBook> GetAggregatedFullOrderBook(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Get a full aggregated order book for a symbol. Orders for the same price are combined.
        /// </summary>
        /// <param name="symbol">The symbol to get order book for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Full aggregated order book</returns>
        Task<WebCallResult<KucoinOrderBook>> GetAggregatedFullOrderBookAsync(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Get a full order book for a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get order book for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Full order book</returns>
        WebCallResult<KucoinFullOrderBook> GetOrderBook(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Get a full order book for a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get order book for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Full order book</returns>
        Task<WebCallResult<KucoinFullOrderBook>> GetOrderBookAsync(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Gets the recent trade history for a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get trade history for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of trades for the symbol</returns>
        WebCallResult<IEnumerable<KucoinTrade>> GetSymbolTrades(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Gets the recent trade history for a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get trade history for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of trades for the symbol</returns>
        Task<WebCallResult<IEnumerable<KucoinTrade>>> GetSymbolTradesAsync(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Get kline data for a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get klines for</param>
        /// <param name="interval">The interval of a kline</param>
        /// <param name="startTime">The start time of the data</param>
        /// <param name="endTime">The end time of the data</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of klines</returns>
        WebCallResult<IEnumerable<KucoinKline>> GetKlines(string symbol, KucoinKlineInterval interval, DateTime startTime, DateTime endTime, CancellationToken ct = default);

        /// <summary>
        /// Get kline data for a symbol
        /// </summary>
        /// <param name="symbol">The symbol to get klines for</param>
        /// <param name="interval">The interval of a kline</param>
        /// <param name="startTime">The start time of the data</param>
        /// <param name="endTime">The end time of the data</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of klines</returns>
        Task<WebCallResult<IEnumerable<KucoinKline>>> GetKlinesAsync(string symbol, KucoinKlineInterval interval, DateTime startTime, DateTime endTime, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of supported currencies
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of currencies</returns>
        WebCallResult<IEnumerable<KucoinCurrency>> GetCurrencies(CancellationToken ct = default);

        /// <summary>
        /// Gets a list of supported currencies
        /// </summary>
        /// <returns>List of currencies</returns>
        Task<WebCallResult<IEnumerable<KucoinCurrency>>> GetCurrenciesAsync(CancellationToken ct = default);

        /// <summary>
        /// Get info on a specific currency
        /// </summary>
        /// <param name="name">The currency to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Currency info</returns>
        WebCallResult<KucoinCurrency> GetCurrency(string name, CancellationToken ct = default);

        /// <summary>
        /// Get info on a specific currency
        /// </summary>
        /// <param name="currency">The currency to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Currency info</returns>
        Task<WebCallResult<KucoinCurrency>> GetCurrencyAsync(string currency, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of prices for all 
        /// </summary>
        /// <param name="fiatBase">The three letter code of the fiat to convert to. Defaults to USD</param>
        /// <param name="currencies">The currencies to get price for. Defaults to all</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of prices</returns>
        WebCallResult<Dictionary<string, decimal>> GetFiatPrices(string? fiatBase = null, CancellationToken ct = default, params string[] currencies);

        /// <summary>
        /// Gets a list of prices for all 
        /// </summary>
        /// <param name="fiatBase">The three letter code of the fiat to convert to. Defaults to USD</param>
        /// <param name="currencies">The currencies to get price for. Defaults to all</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of prices</returns>
        Task<WebCallResult<Dictionary<string, decimal>>> GetFiatPricesAsync(string? fiatBase = null, CancellationToken ct = default, params string[] currencies);

        /// <summary>
        /// Gets a list of sub users
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of sub users</returns>
        WebCallResult<IEnumerable<KucoinSubUser>> GetUserInfo(CancellationToken ct = default);

        /// <summary>
        /// Gets a list of sub users
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of sub users</returns>
        Task<WebCallResult<IEnumerable<KucoinSubUser>>> GetUserInfoAsync(CancellationToken ct = default);

        /// <summary>
        /// Gets a list of accounts
        /// </summary>
        /// <param name="currency">Get the accounts for a specific currency</param>
        /// <param name="accountType">Filter on type of account</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of accounts</returns>
        WebCallResult<IEnumerable<KucoinAccount>> GetAccounts(string? currency = null, KucoinAccountType? accountType = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of accounts
        /// </summary>
        /// <param name="currency">Get the accounts for a specific currency</param>
        /// <param name="accountType">Filter on type of account</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of accounts</returns>
        Task<WebCallResult<IEnumerable<KucoinAccount>>> GetAccountsAsync(string? currency = null, KucoinAccountType? accountType = null, CancellationToken ct = default);

        /// <summary>
        /// Get a specific account
        /// </summary>
        /// <param name="accountId">The id of the account to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Account info</returns>
        WebCallResult<KucoinAccountSingle> GetAccount(string accountId, CancellationToken ct = default);

        /// <summary>
        /// Get a specific account
        /// </summary>
        /// <param name="accountId">The id of the account to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Account info</returns>
        Task<WebCallResult<KucoinAccountSingle>> GetAccountAsync(string accountId, CancellationToken ct = default);

        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="type">The type of the account</param>
        /// <param name="currency">The currency of the account</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>The id of the account</returns>
        WebCallResult<KucoinNewAccount> CreateAccount(KucoinAccountType type, string currency, CancellationToken ct = default);

        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="type">The type of the account</param>
        /// <param name="currency">The currency of the account</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>The id of the account</returns>
        Task<WebCallResult<KucoinNewAccount>> CreateAccountAsync(KucoinAccountType type, string currency, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of account activity
        /// </summary>
        /// <param name="accountId">The account id to get the activities for</param>
        /// <param name="startTime">Filter by start time</param>
        /// <param name="endTime">Filter by end time</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Info on account activity</returns>
        WebCallResult<KucoinPaginated<KucoinAccountActivity>> GetAccountLedger(string accountId, DateTime? startTime = null, DateTime? endTime = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of account activity
        /// </summary>
        /// <param name="accountId">The account id to get the activities for</param>
        /// <param name="startTime">Filter by start time</param>
        /// <param name="endTime">Filter by end time</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Info on account activity</returns>
        Task<WebCallResult<KucoinPaginated<KucoinAccountActivity>>> GetAccountLedgerAsync(string accountId, DateTime? startTime = null, DateTime? endTime = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets hold information
        /// </summary>
        /// <param name="accountId">The account to get info for</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Info on current holds</returns>
        WebCallResult<KucoinPaginated<KucoinHold>> GetHolds(string accountId, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets hold information
        /// </summary>
        /// <param name="accountId">The account to get info for</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Info on current holds</returns>
        Task<WebCallResult<KucoinPaginated<KucoinHold>>> GetHoldsAsync(string accountId, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of deposits
        /// </summary>
        /// <param name="currency">Filter list by currency</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by deposit status</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of deposits</returns>
        WebCallResult<KucoinPaginated<KucoinDeposit>> GetDeposits(string? currency = null, DateTime? startTime = null, DateTime? endTime = null, KucoinDepositStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of deposits
        /// </summary>
        /// <param name="currency">Filter list by currency</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by deposit status</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of deposits</returns>
        Task<WebCallResult<KucoinPaginated<KucoinDeposit>>> GetDepositsAsync(string? currency = null, DateTime? startTime = null, DateTime? endTime = null, KucoinDepositStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of historical deposits
        /// </summary>
        /// <param name="currency">Filter list by currency</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by deposit status</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of historical deposits</returns>
        WebCallResult<KucoinPaginated<KucoinHistoricalDeposit>> GetHistoricalDeposits(string? currency = null, DateTime? startTime = null, DateTime? endTime = null, KucoinDepositStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of historical deposits
        /// </summary>
        /// <param name="currency">Filter list by currency</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by deposit status</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of historical deposits</returns>
        Task<WebCallResult<KucoinPaginated<KucoinHistoricalDeposit>>> GetHistoricalDepositsAsync(string? currency = null, DateTime? startTime = null, DateTime? endTime = null, KucoinDepositStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets the deposit address for a currency
        /// </summary>
        /// <param name="currency">The currency to get the address for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>The deposit address for the currency</returns>
        WebCallResult<KucoinDepositAddress> GetDepositAddress(string currency, CancellationToken ct = default);

        /// <summary>
        /// Gets the deposit address for a currency
        /// </summary>
        /// <param name="currency">The currency to get the address for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>The deposit address for the currency</returns>
        Task<WebCallResult<KucoinDepositAddress>> GetDepositAddressAsync(string currency, CancellationToken ct = default);

        /// <summary>
        /// Creates a new deposit address for a currency
        /// </summary>
        /// <param name="currency">The currency to create the address for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>The address that was created</returns>
        WebCallResult<KucoinDepositAddress> CreateDepositAddress(string currency, CancellationToken ct = default);

        /// <summary>
        /// Creates a new deposit address for a currency
        /// </summary>
        /// <param name="currency">The currency to create the address for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>The address that was created</returns>
        Task<WebCallResult<KucoinDepositAddress>> CreateDepositAddressAsync(string currency, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of withdrawals
        /// </summary>
        /// <param name="currency">Filter list by currency</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by deposit status</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of withdrawals</returns>
        WebCallResult<KucoinPaginated<KucoinWithdrawal>> GetWithdrawals(string? currency = null, DateTime? startTime = null, DateTime? endTime = null, KucoinWithdrawalStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of withdrawals
        /// </summary>
        /// <param name="currency">Filter list by currency</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by deposit status</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of withdrawals</returns>
        Task<WebCallResult<KucoinPaginated<KucoinWithdrawal>>> GetWithdrawalsAsync(string? currency = null, DateTime? startTime = null, DateTime? endTime = null, KucoinWithdrawalStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of historical withdrawals
        /// </summary>
        /// <param name="currency">Filter list by currency</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by deposit status</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of historical withdrawals</returns>
        WebCallResult<KucoinPaginated<KucoinHistoricalWithdrawal>> GetHistoricalWithdrawals(string? currency = null, DateTime? startTime = null, DateTime? endTime = null, KucoinWithdrawalStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of historical withdrawals
        /// </summary>
        /// <param name="currency">Filter list by currency</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by deposit status</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of historical withdrawals</returns>
        Task<WebCallResult<KucoinPaginated<KucoinHistoricalWithdrawal>>> GetHistoricalWithdrawalsAsync(string? currency = null, DateTime? startTime = null, DateTime? endTime = null, KucoinWithdrawalStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Get the withdrawal quota for a currency
        /// </summary>
        /// <param name="currency">The currency to get the quota for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Quota info</returns>
        WebCallResult<KucoinWithdrawalQuota> GetWithdrawalQuotas(string currency, CancellationToken ct = default);

        /// <summary>
        /// Get the withdrawal quota for a currency
        /// </summary>
        /// <param name="currency">The currency to get the quota for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Quota info</returns>
        Task<WebCallResult<KucoinWithdrawalQuota>> GetWithdrawalQuotasAsync(string currency, CancellationToken ct = default);

        /// <summary>
        /// Withdraw a currency to an address
        /// </summary>
        /// <param name="currency">The currency to withdraw</param>
        /// <param name="toAddress">The address to withdraw to</param>
        /// <param name="quantity">The quantity to withdraw</param>
        /// <param name="memo">The note that is left on the withdrawal address. When you withdraw from KuCoin to other platforms, you need to fill in memo(tag). If you don't fill in memo(tag), your withdrawal may not be available.</param>
        /// <param name="isInner">Internal withdrawal or not. Default false.</param>
        /// <param name="remark">Remark for the withdrawal</param>
        /// <param name="chain">The chain name of currency, e.g. The available value for USDT are OMNI, ERC20, TRC20, default is OMNI. This only apply for multi-chain currency, and there is no need for single chain currency.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Id of the withdrawal</returns>
        WebCallResult<KucoinNewWithdrawal> Withdraw(string currency, string toAddress, decimal quantity, string? memo = null, bool isInner = false, string? remark = null, string? chain = null, CancellationToken ct = default);

        /// <summary>
        /// Withdraw a currency to an address
        /// </summary>
        /// <param name="currency">The currency to withdraw</param>
        /// <param name="toAddress">The address to withdraw to</param>
        /// <param name="quantity">The quantity to withdraw</param>
        /// <param name="memo">The note that is left on the withdrawal address. When you withdraw from KuCoin to other platforms, you need to fill in memo(tag). If you don't fill in memo(tag), your withdrawal may not be available.</param>
        /// <param name="isInner">Internal withdrawal or not. Default false.</param>
        /// <param name="remark">Remark for the withdrawal</param>
        /// <param name="chain">The chain name of currency, e.g. The available value for USDT are OMNI, ERC20, TRC20, default is OMNI. This only apply for multi-chain currency, and there is no need for single chain currency.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Id of the withdrawal</returns>
        Task<WebCallResult<KucoinNewWithdrawal>> WithdrawAsync(string currency, string toAddress, decimal quantity, string? memo = null, bool isInner = false, string? remark = null, string? chain = null, CancellationToken ct = default);

        /// <summary>
        /// Cancel a withdrawal
        /// </summary>
        /// <param name="withdrawalId">The id of the withdrawal to cancel</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Null</returns>
        WebCallResult<object> CancelWithdrawal(string withdrawalId, CancellationToken ct = default);

        /// <summary>
        /// Cancel a withdrawal
        /// </summary>
        /// <param name="withdrawalId">The id of the withdrawal to cancel</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Null</returns>
        Task<WebCallResult<object>> CancelWithdrawalAsync(string withdrawalId, CancellationToken ct = default);

        /// <summary>
        /// Places an order
        /// </summary>
        /// <param name="symbol">The symbol the order is for</param>
        /// <param name="side">The side of the order</param>
        /// <param name="type">The type of the order</param>
        /// <param name="tradeType">Spot or margin trade</param>
        /// <param name="price">The price of the order. Only valid for limit orders.</param>
        /// <param name="quantity">The quantity of the order</param>
        /// <param name="funds">The funds to use for the order. Only valid for market orders. If used, quantity needs to be empty</param>
        /// <param name="timeInForce">The time the order is in force</param>
        /// <param name="cancelAfter">Cancel after a time</param>
        /// <param name="postOnly">Order is post only</param>
        /// <param name="hidden">Order is hidden</param>
        /// <param name="iceBerg">Order is an iceberg order</param>
        /// <param name="visibleIceBergSize">The maximum visible size of an iceberg order</param>
        /// <param name="remark">Remark on the order</param>
        /// <param name="stop">Type of stop order</param>
        /// <param name="stopPrice">The price for a stop order</param>
        /// <param name="selfTradePrevention">Self trade prevention setting</param>
        /// <param name="clientOrderId">Client order id</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>The id of the new order</returns>
        WebCallResult<KucoinNewOrder> PlaceOrder(
            string symbol,
            KucoinOrderSide side, 
            KucoinNewOrderType type, 
            KucoinTradeType tradeType,
            decimal? price = null, 
            decimal? quantity = null, 
            decimal? funds = null,
            KucoinTimeInForce? timeInForce = null,
            DateTime? cancelAfter = null,
            bool? postOnly = null,
            bool? hidden = null,
            bool? iceBerg = null,
            decimal? visibleIceBergSize = null,
            string? remark = null,
            KucoinStopCondition? stop = null, 
            decimal? stopPrice = null,
            KucoinSelfTradePrevention? selfTradePrevention = null,
            string? clientOrderId = null, 
            CancellationToken ct = default);

        /// <summary>
        /// Places an order
        /// </summary>
        /// <param name="symbol">The symbol the order is for</param>
        /// <param name="side">The side of the order</param>
        /// <param name="type">The type of the order</param>
        /// <param name="tradeType">Spot or margin trade</param>
        /// <param name="price">The price of the order. Only valid for limit orders.</param>
        /// <param name="quantity">The quantity of the order</param>
        /// <param name="funds">The funds to use for the order. Only valid for market orders. If used, quantity needs to be empty</param>
        /// <param name="timeInForce">The time the order is in force</param>
        /// <param name="cancelAfter">Cancel after a time</param>
        /// <param name="postOnly">Order is post only</param>
        /// <param name="hidden">Order is hidden</param>
        /// <param name="iceBerg">Order is an iceberg order</param>
        /// <param name="visibleIceBergSize">The maximum visible size of an iceberg order</param>
        /// <param name="remark">Remark on the order</param>
        /// <param name="stop">Type of stop order</param>
        /// <param name="stopPrice">The price for a stop order</param>
        /// <param name="selfTradePrevention">Self trade prevention setting</param>
        /// <param name="clientOrderId">Client order id</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>The id of the new order</returns>
        Task<WebCallResult<KucoinNewOrder>> PlaceOrderAsync(
            string symbol,
            KucoinOrderSide side,
            KucoinNewOrderType type,
            KucoinTradeType tradeType,
            decimal? price = null,
            decimal? quantity = null,
            decimal? funds = null,
            KucoinTimeInForce? timeInForce = null,
            DateTime? cancelAfter = null,
            bool? postOnly = null,
            bool? hidden = null,
            bool? iceBerg = null,
            decimal? visibleIceBergSize = null,
            string? remark = null,
            KucoinStopCondition? stop = null,
            decimal? stopPrice = null,
            KucoinSelfTradePrevention? selfTradePrevention = null,
            string? clientOrderId = null, 
            CancellationToken ct = default);

        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="orderId">The id of the order to cancel</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of cancelled orders</returns>
        WebCallResult<KucoinCancelledOrders> CancelOrder(string orderId, CancellationToken ct = default);

        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="orderId">The id of the order to cancel</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of cancelled orders</returns>
        Task<WebCallResult<KucoinCancelledOrders>> CancelOrderAsync(string orderId, CancellationToken ct = default);

        /// <summary>
        /// Cancel all open orders
        /// </summary>
        /// <param name="tradeType">cancel orders on a spot trade account or margin account</param>
        /// <param name="symbol">Only cancel orders for this symbol</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of cancelled orders</returns>
        WebCallResult<KucoinCancelledOrders> CancelAllOrders(KucoinTradeType? tradeType = null, string? symbol = null, CancellationToken ct = default);

        /// <summary>
        /// Cancel all open orders
        /// </summary>
        /// <param name="tradeType">cancel orders on a spot trade account or margin account</param>
        /// <param name="symbol">Only cancel orders for this symbol</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of cancelled orders</returns>
        Task<WebCallResult<KucoinCancelledOrders>> CancelAllOrdersAsync(KucoinTradeType? tradeType = null, string? symbol = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of orders
        /// </summary>
        /// <param name="tradeType">Filter list by spot trade or margin trade</param>
        /// <param name="symbol">Filter list by symbol</param>
        /// <param name="type">Filter list by order type</param>
        /// <param name="side">Filter list by order side</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by order status. Defaults to done</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of orders</returns>
        WebCallResult<KucoinPaginated<KucoinOrder>> GetOrders(KucoinTradeType tradeType, string? symbol = null, KucoinOrderSide? side = null, KucoinOrderType? type = null, DateTime? startTime = null, DateTime? endTime = null, KucoinOrderStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of orders
        /// </summary>
        /// <param name="tradeType">Filter list by spot trade or margin trade</param>
        /// <param name="symbol">Filter list by symbol</param>
        /// <param name="type">Filter list by order type</param>
        /// <param name="side">Filter list by order side</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="status">Filter list by order status. Defaults to done</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of orders</returns>
        Task<WebCallResult<KucoinPaginated<KucoinOrder>>> GetOrdersAsync(KucoinTradeType tradeType, string? symbol = null, KucoinOrderSide? side = null, KucoinOrderType? type = null, DateTime? startTime = null, DateTime? endTime = null, KucoinOrderStatus? status = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of max 1000 orders in the last 24 hours
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of orders</returns>
        WebCallResult<IEnumerable<KucoinOrder>> GetRecentOrders(CancellationToken ct = default);

        /// <summary>
        /// Gets a list of max 1000 orders in the last 24 hours
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of orders</returns>
        Task<WebCallResult<IEnumerable<KucoinOrder>>> GetRecentOrdersAsync(CancellationToken ct = default);

        /// <summary>
        /// Get info on a specific order
        /// </summary>
        /// <param name="orderId">The id of the order</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Order info</returns>
        WebCallResult<KucoinOrder> GetOrder(string orderId, CancellationToken ct = default);

        /// <summary>
        /// Get info on a specific order
        /// </summary>
        /// <param name="orderId">The id of the order</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Order info</returns>
        Task<WebCallResult<KucoinOrder>> GetOrderAsync(string orderId, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of historical orders
        /// </summary>
        /// <param name="symbol">Filter list by symbol</param>
        /// <param name="side">Filter list by order side</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of historical orders</returns>
        WebCallResult<KucoinPaginated<KucoinHistoricalOrder>> GetHistoricalOrders(string? symbol = null, KucoinOrderSide? side = null, DateTime? startTime = null, DateTime? endTime = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of historical orders
        /// </summary>
        /// <param name="symbol">Filter list by symbol</param>
        /// <param name="side">Filter list by order side</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of historical orders</returns>
        Task<WebCallResult<KucoinPaginated<KucoinHistoricalOrder>>> GetHistoricalOrdersAsync(string? symbol = null, KucoinOrderSide? side = null, DateTime? startTime = null, DateTime? endTime = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of fills
        /// </summary>
        /// <param name="tradeType">Filter list by spot trade or margin trade</param>
        /// <param name="symbol">Filter list by symbol</param>
        /// <param name="type">Filter list by order type</param>
        /// <param name="side">Filter list by order side</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="orderId">Filter list by order id</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of fills</returns>
        WebCallResult<KucoinPaginated<KucoinFill>> GetFills(KucoinTradeType tradeType, string? symbol = null, KucoinOrderSide? side = null, KucoinOrderType? type = null, DateTime? startTime = null, DateTime? endTime = null, string? orderId = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of fills
        /// </summary>
        /// <param name="tradeType">Filter list by spot trade or margin trade</param>
        /// <param name="symbol">Filter list by symbol</param>
        /// <param name="type">Filter list by order type</param>
        /// <param name="side">Filter list by order side</param>
        /// <param name="startTime">Filter list by start time</param>
        /// <param name="endTime">Filter list by end time</param>
        /// <param name="orderId">Filter list by order id</param>
        /// <param name="currentPage">The page to retrieve</param>
        /// <param name="pageSize">The amount of results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of fills</returns>
        Task<WebCallResult<KucoinPaginated<KucoinFill>>> GetFillsAsync(KucoinTradeType tradeType, string? symbol = null, KucoinOrderSide? side = null, KucoinOrderType? type = null, DateTime? startTime = null, DateTime? endTime = null, string? orderId = null, int? currentPage = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Gets a list of max 1000 fills in the last 24 hours
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of fills</returns>
        WebCallResult<IEnumerable<KucoinFill>> GetRecentFills(CancellationToken ct = default);

        /// <summary>
        /// Gets a list of max 1000 fills in the last 24 hours
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>List of fills</returns>
        Task<WebCallResult<IEnumerable<KucoinFill>>> GetRecentFillsAsync(CancellationToken ct = default);

    }
}