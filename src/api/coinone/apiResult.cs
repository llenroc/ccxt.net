﻿using Newtonsoft.Json;

namespace CCXT.NET.Coinone
{
    /// <summary>
    /// 
    /// </summary>
    public class CApiResult : ApiResult
    {
        /// <summary>
        /// Request's result
        /// </summary>
        public string result
        {
            get;
            set;
        }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public override int status
        {
            get;
            set;
        }

        /// <summary>
        /// Timestamp
        /// </summary>
        public long timestamp
        {
            get;
            set;
        }
    }
}