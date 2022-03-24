﻿namespace GreatLeaderXiBot.Common.Configuration;

public class ExchangeConfiguration
{
    public string ExchangeHost { get; init; } = null!;

    public string ExchangeUsername { get; init; } = null!;

    public string ExchangePassword { get; init; } = null!;

    public int UserUtcOffset { get; init; }

    public int AppointmentsUtcOffset { get; init; }
}
