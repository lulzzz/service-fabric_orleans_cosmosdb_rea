﻿#region Using Directives

using System.Threading.Tasks;
using Orleans.Graph.Definition;

#endregion

namespace Orleans.Graph.Test.Definition
{
    [GraphElement(DefaultPartition = "users")]
    public interface IHasProfileEdge : IEdge
    {
        Task<IProfileVertex> AddProfile(IPersonVertex personVertex, ProfileData data);
    }
}