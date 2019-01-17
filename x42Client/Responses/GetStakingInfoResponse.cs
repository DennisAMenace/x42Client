﻿namespace x42Client.x42.Responses
{
    public class GetStakingInfoResponse
    {
        public bool enabled { get; set; }
        public bool staking { get; set; }
        public object errors { get; set; }
        public int currentBlockSize { get; set; }
        public int currentBlockTx { get; set; }
        public int pooledTx { get; set; }
        public float difficulty { get; set; }
        public int searchInterval { get; set; }
        public long weight { get; set; }
        public long netStakeWeight { get; set; }
        public int expectedTime { get; set; }
    }
}


