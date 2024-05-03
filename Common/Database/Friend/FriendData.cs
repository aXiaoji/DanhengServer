﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Database.Friend
{
    [SugarTable("Friend")]
    public class FriendData : BaseDatabaseData
    {
        [SugarColumn(IsJson = true)]
        public List<int> FriendList { get; set; } = [];

        [SugarColumn(IsJson = true)]
        public List<int> BlackList { get; set; } = [];

        [SugarColumn(IsJson = true)]
        public List<int> SendApplyList { get; set; } = [];

        [SugarColumn(IsJson = true)]
        public List<int> ReceiveApplyList { get; set; } = [];

        [SugarColumn(IsJson = true)]
        public Dictionary<int, FriendChatHistory> ChatHistory { get; set; } = [];  // key: friend uid
    }

    public class FriendChatHistory
    {
        public List<FriendChatData> MessageList { get; set; } = [];
    }

    public class FriendChatData
    {
        public long SendTime { get; set; }
        public string Message { get; set; } = "";
        public int ExtraId { get; set; }
        public int SendUid { get; set; }
        public int ReceiveUid { get; set; }
    }
}
