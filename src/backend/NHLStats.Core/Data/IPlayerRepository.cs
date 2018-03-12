﻿
using System.Threading.Tasks;
using NHLStats.Core.Models;

namespace NHLStats.Core.Data
{
    public interface IPlayerRepository
    {
        Task<Player> Get(int id);
    }
}
