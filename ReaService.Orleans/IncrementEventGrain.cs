﻿#region Using Directives

using Orleans.Graph;
using ReaService.Orleans.Definition;

#endregion

namespace ReaService.Orleans
{
    public class IncrementEventGrain : VertexGrain, IIncrementEvent { }
}