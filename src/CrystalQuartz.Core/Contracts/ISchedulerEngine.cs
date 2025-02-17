﻿namespace CrystalQuartz.Core.Contracts
{
    using System.Threading.Tasks;

    public interface ISchedulerEngine
    {
        Task<object> CreateStandardRemoteScheduler(string url);

        Task<SchedulerServices> CreateServices(object scheduler, Options options);
    }
}