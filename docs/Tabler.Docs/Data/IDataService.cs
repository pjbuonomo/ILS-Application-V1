﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TabBlazor.Components.QuickTables;
using Tabler.Docs.Data;

public interface IDataService
{
    Task<GridItemsProviderResult<Country>> GetCountriesAsync(int startIndex, int? count, string sortBy, bool sortAscending, CancellationToken cancellationToken);

    IQueryable<Country> Countries { get; }
}

/*
public interface IDataService
{
    IQueryable<MarketQuote> MarketQuotes { get; }
    Task<GridItemsProviderResult<MarketQuote>> GetMarketQuotesAsync(int startIndex, int? count, string sortBy, bool sortAscending, CancellationToken cancellationToken);
}
*/