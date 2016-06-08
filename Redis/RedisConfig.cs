using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Redis
{
    public class RedisConfig : ConfigurationSection
    {
        public static RedisConfig GetRedisConfig()
        {
            RedisConfig config = (RedisConfig)ConfigurationManager.GetSection("RedisConfig");
            return config;
        }
        public static RedisConfig GetRedisConfig(string sectionName)
        {
            RedisConfig config = (RedisConfig)ConfigurationManager.GetSection(sectionName);
            return config;
        }
        //ConfigurationProperty 表示配置元素的一个特性或子级
        [ConfigurationProperty("WriteServerList", IsRequired = true)]
        public string WriteServerList
        {
            get { return (string)base["WriteServerList"]; }
            set { base["WriteServerList"] = value; }
        }
        [ConfigurationProperty("ReadServerList", IsRequired = true)]
        public string ReadServerList
        {
            get { return (string)base["ReadServerList"]; }
            set { base["ReadServerList"] = value; }
        }
        [ConfigurationProperty("MaxWritePoolSize")]
        public int MaxWritePoolSize
        {
            get { return (int)base["MaxWritePoolSize"]; }
            set { base["MaxWritePoolSize"] = value; }
        }
        [ConfigurationProperty("MinWritePoolSize")]
        public int MaxReadPoolSize
        {
            get { return (int)base["MaxReadPoolSize"]; }
            set { base["MaxReadPoolSize"] = value; }
        }
        [ConfigurationProperty("AutoStart")]
        public bool AutoStart
        {
            get { return (bool)base["AutoStart"]; }
            set { base["AutoStart"] = value; }

        }
    }
}
