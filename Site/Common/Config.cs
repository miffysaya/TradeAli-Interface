using AgileFramework;
using AgileFramework.Configuration;

namespace WebProject.TemplateApi.Site.Common
{
    public static class Config
    {
        /// <summary>
        /// 运行状态：Develope=开发,Publish=发布
        /// </summary>
        public static AgileRunState RunState
        {
            get
            {
                return AgileConfig.GetValue<AgileRunState>("RunState");
            }
        }

        /// <summary>
        /// 版本
        /// </summary>
        public static string Version
        {
            get
            {
                return AgileConfig.GetValue<string>("Version");
            }
        }

        /// <summary>
        /// 登录Url
        /// </summary>
        public static string LoginUrl
        {
            get
            {
                return AgileConfig.GetValue<string>("LoginUrl");
            }
        }

        /// <summary>
        /// 标题前缀
        /// </summary>
        public static string TitlePrefix
        {
            get
            {
                return AgileConfig.GetValue<string>("TitlePrefix");
            }
        }

        /// <summary>
        /// Cookie前缀
        /// </summary>
        public static string CookiePrefix
        {
            get
            {
                return AgileConfig.GetValue<string>("CookiePrefix");
            }
        }

        /// <summary>
        /// PDA接口服务地址
        /// </summary>
        public static string PDAUrl
        {
            get
            {
                return AgileConfig.GetValue<string>("PDAUrl");
            }
        }

        /// <summary>
        /// 系统使用加密解密算法的Key
        /// </summary>
        public static string SecurityKey
        {
            get
            {
                return AgileConfig.GetValue<string>("SecurityKey");
            }
        }

        /// <summary>
        /// 脚本路径
        /// </summary>
        public static string ScriptPath
        {
            get
            {
                return AgileConfig.GetValue<string>("ScriptPath");
            }
        }

        /// <summary>
        /// 数据库读取
        /// </summary>
        public static string ConnectionString_Read
        {
            get
            {
                return AgileConfig.GetValue<string>("ConnectionString_Read");
            }
        }

        /// <summary>
        /// 数据库写入
        /// </summary>
        public static string ConnectionString_Write
        {
            get
            {
                return AgileConfig.GetValue<string>("ConnectionString_Write");
            }
        }
    }
}