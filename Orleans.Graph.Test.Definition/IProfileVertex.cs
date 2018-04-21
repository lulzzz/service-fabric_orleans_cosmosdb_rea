﻿#region Using Directives

using System.Threading.Tasks;
using Orleans.Graph.Definition;

#endregion

namespace Orleans.Graph.Test.Definition
{
    [GraphElement(DefaultPartition = "users")]
    public interface IProfileVertex : IVertexGrain
    {
        Task SetProfileData(ProfileData data);

        Task<ProfileData> GetProfileDataAsync();
    }
}