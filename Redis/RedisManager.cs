using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Redis
{
    public static class RedisManager
    {
        private static RedisConfig redisConfig = RedisConfig.GetRedisConfig();
        private static PooledRedisClientManager redisClientManager;

        static RedisManager()
        {
            InitManager();
        }

        static void InitManager()
        {

            redisClientManager = new PooledRedisClientManager(redisConfig.WriteServerList.Split(','), redisConfig.ReadServerList.Split(','), new RedisClientManagerConfig() { MaxReadPoolSize = redisConfig.MaxReadPoolSize, MaxWritePoolSize = redisConfig.MaxWritePoolSize, AutoStart = redisConfig.AutoStart });

        }


        public static IRedisClient GetClient(ClientType type)
        {
            switch (type)
            {
                case ClientType.Pool:
                    if (redisClientManager == null)
                        InitManager();
                    return redisClientManager.GetClient();
                default:
                    RedisClient client = new RedisClient();
                    return client;
            }
        }


    }
    public enum ClientType
    {
        Pool,
        Normal
    }
}
