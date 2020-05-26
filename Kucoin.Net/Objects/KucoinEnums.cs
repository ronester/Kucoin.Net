﻿namespace Kucoin.Net.Objects
{
    /// <summary>
    /// The time for each candlestick
    /// </summary>
    public enum KucoinKlineInterval
    {
        /// <summary>
        /// 1m
        /// </summary>
        OneMinute,
        /// <summary>
        /// 3m
        /// </summary>
        ThreeMinutes,
        /// <summary>
        /// 5m
        /// </summary>
        FiveMinutes,
        /// <summary>
        /// 15m
        /// </summary>
        FifteenMinutes,
        /// <summary>
        /// 30m
        /// </summary>
        ThirtyMinutes,
        /// <summary>
        /// 1h
        /// </summary>
        OneHour,
        /// <summary>
        /// 2h
        /// </summary>
        TwoHours,
        /// <summary>
        /// 4h
        /// </summary>
        FourHours,
        /// <summary>
        /// 6h
        /// </summary>
        SixHours,
        /// <summary>
        /// 8h
        /// </summary>
        EightHours,
        /// <summary>
        /// 12h
        /// </summary>
        TwelfHours,
        /// <summary>
        /// 1d
        /// </summary>
        OneDay,
        /// <summary>
        /// 1w
        /// </summary>
        OneWeek
    }

    /// <summary>
    /// Account type
    /// </summary>
    public enum KucoinAccountType
    {
        /// <summary>
        /// Main account
        /// </summary>
        Main,
        /// <summary>
        /// Trade account
        /// </summary>
        Trade,
        /// <summary>
        /// Margin account
        /// </summary>
        Margin
    }

    /// <summary>
    /// 
    /// </summary>
    public enum KucoinTradeType
    {
        /// <summary>
        /// Spot Trade
        /// </summary>
        Trade,
        /// <summary>
        /// Margin Trade
        /// </summary>
        MarginTrade
    }

    /// <summary>
    /// Status of a deposit
    /// </summary>
    public enum KucoinDepositStatus
    {
        /// <summary>
        /// In progress
        /// </summary>
        Processing,
        /// <summary>
        /// Successful
        /// </summary>
        Success,
        /// <summary>
        /// Failed
        /// </summary>
        Failure
    }

    /// <summary>
    /// Status of a withdrawal
    /// </summary>
    public enum KucoinWithdrawalStatus
    {
        /// <summary>
        /// In progress
        /// </summary>
        Processing,
        /// <summary>
        /// In progress
        /// </summary>
        WalletProcessing,
        /// <summary>
        /// Successful
        /// </summary>
        Success,
        /// <summary>
        /// Failed
        /// </summary>
        Failure
    }

    /// <summary>
    /// Order side
    /// </summary>
    public enum KucoinOrderSide
    {
        /// <summary>
        /// Buy order
        /// </summary>
        Buy,
        /// <summary>
        /// Sell order
        /// </summary>
        Sell
    }

    /// <summary>
    /// New order type
    /// </summary>
    public enum KucoinNewOrderType
    {
        /// <summary>
        /// Limit order
        /// </summary>
        Limit,
        /// <summary>
        /// Market order
        /// </summary>
        Market
    }

    /// <summary>
    /// Order type
    /// </summary>
    public enum KucoinOrderType
    {
        /// <summary>
        /// Limit order
        /// </summary>
        Limit,
        /// <summary>
        /// Market order
        /// </summary>
        Market,
        /// <summary>
        /// Limit stop order
        /// </summary>
        LimitStop,
        /// <summary>
        /// Market stop order
        /// </summary>
        MarketStop
    }

    /// <summary>
    /// Time the order is valid for
    /// </summary>
    public enum KucoinTimeInForce
    {
        /// <summary>
        /// Good until cancelled by user
        /// </summary>
        GoodTillCancelled,
        /// <summary>
        /// Good until a certain time
        /// </summary>
        GoodTillTime,
        /// <summary>
        /// Immediately has to be (partially) filled or it will be cancelled
        /// </summary>
        ImmediateOrCancel,
        /// <summary>
        /// Immediately has to be full filled or it will be cancelled
        /// </summary>
        FillOrKill
    }

    /// <summary>
    /// Self trade prevention types
    /// </summary>
    public enum KucoinSelfTradePrevention
    {
        /// <summary>
        /// No self trade prevention
        /// </summary>
        None,
        /// <summary>
        /// Decrease the amount of the existing order by the amount of the new order
        /// </summary>
        DecreaseAndCancel,
        /// <summary>
        /// Cancel the oldest order
        /// </summary>
        CancelOldest,
        /// <summary>
        /// Cancel the newest order
        /// </summary>
        CancelNewest,
        /// <summary>
        /// Cancel both orders
        /// </summary>
        CancelBoth
    }

    /// <summary>
    /// Stop condition
    /// </summary>
    public enum KucoinStopCondition
    {
        /// <summary>
        /// No stop condition
        /// </summary>
        None,
        /// <summary>
        /// Loss condition
        /// </summary>
        Loss,
        /// <summary>
        /// Entry condition
        /// </summary>
        Entry
    }

    /// <summary>
    /// Order status
    /// </summary>
    public enum KucoinOrderStatus
    {
        /// <summary>
        /// Order is active
        /// </summary>
        Active,
        /// <summary>
        /// Order is done
        /// </summary>
        Done
    }

    /// <summary>
    /// Direction
    /// </summary>
    public enum KucoinAccountDirection
    {
        /// <summary>
        /// In
        /// </summary>
        In,
        /// <summary>
        /// Out
        /// </summary>
        Out
    }

    /// <summary>
    /// Liquidity type of a trade
    /// </summary>
    public enum KucoinLiquidityType
    {
        /// <summary>
        /// Maker, order was on the order book and got filled
        /// </summary>
        Maker,
        /// <summary>
        /// Taker, trade filled an existing order on the order book
        /// </summary>
        Taker
    }

    /// <summary>
    /// Order operation type
    /// </summary>
    public enum KucoinOrderOperationType
    {
        /// <summary>
        /// Matched
        /// </summary>
        Deal,
        /// <summary>
        /// Cancelled
        /// </summary>
        Cancel
    }

    /// <summary>
    /// Reason for an update
    /// </summary>
    public enum KucoinMatchUpdateReason
    {
        /// <summary>
        /// Cancelled
        /// </summary>
        Cancelled,
        /// <summary>
        /// Filled
        /// </summary>
        Filled
    }

    /// <summary>
    /// Match update type
    /// </summary>
    public enum KucoinMatchUpdateType
    {
        /// <summary>
        /// Received
        /// </summary>
        Received,
        /// <summary>
        /// Open
        /// </summary>
        Open,
        /// <summary>
        /// Done
        /// </summary>
        Done,
        /// <summary>
        /// Match
        /// </summary>
        Match,
        /// <summary>
        /// Change
        /// </summary>
        Change,
        /// <summary>
        /// Stop
        /// </summary>
        Stop,
        /// <summary>
        /// Activate
        /// </summary>
        Activate
    }
}
