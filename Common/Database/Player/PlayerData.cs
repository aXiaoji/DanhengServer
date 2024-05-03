﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Database.Account;
using EggLink.DanhengServer.Database.Avatar;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Proto;
using EggLink.DanhengServer.Util;
using SqlSugar;

namespace EggLink.DanhengServer.Database.Player
{
    [SugarTable("Player")]
    public class PlayerData : BaseDatabaseData
    {
        public string? Name { get; set; } = "无名客";
        public string? Signature { get; set; } = "";
        public int Birthday { get; set; } = 0;
        public int CurBasicType { get; set; } = 8001;
        public int HeadIcon { get; set; } = 208001;
        public int PhoneTheme { get; set; } = 221000;
        public int ChatBubble { get; set; } = 222000;
        public int CurrentBgm { get; set; } = 210007;
        public Gender CurrentGender { get; set; } = Gender.Man;
        public int Level { get; set; } = 1;
        public int Exp { get; set; } = 0;
        public int WorldLevel { get; set; } = 0;
        public int Scoin { get; set; } = 0; // Credits
        public int Hcoin { get; set; } = 0; // Jade
        public int Mcoin { get; set; } = 0; // Crystals
        public int TalentPoints { get; set; } = 0; // Rogue talent points

        public int Stamina { get; set; } = 240;
        public double StaminaReserve { get; set; } = 0;
        public long NextStaminaRecover { get; set; } = 0;

        [SugarColumn(IsNullable = true, IsJson = true)]
        public Position? Pos { get; set; }
        [SugarColumn(IsNullable = true, IsJson = true)]
        public Position? Rot { get; set; }
        [SugarColumn(IsNullable = true)]
        public int PlaneId { get; set; } 
        [SugarColumn(IsNullable = true)]
        public int FloorId { get; set; }
        [SugarColumn(IsNullable = true)]
        public int EntryId { get; set; }

        [SugarColumn(IsNullable = true)]
        public long LastActiveTime { get; set; }

        public static PlayerData? GetPlayerByUid(long uid)
        {
            PlayerData? result = DatabaseHelper.Instance?.GetInstance<PlayerData>(uid);
            return result;
        }

        public PlayerBasicInfo ToProto()
        {
            return new()
            {
                Nickname = Name,
                Level = (uint)Level,
                Exp = (uint)Exp,
                WorldLevel = (uint)WorldLevel,
                Scoin = (uint)Scoin,
                Hcoin = (uint)Hcoin,
                Mcoin = (uint)Mcoin,
                Stamina = (uint)Stamina,
            };
        }

        public PlayerSimpleInfo ToSimpleProto(FriendOnlineStatus status)
        {
            var AvatarInfo = DatabaseHelper.Instance!.GetInstance<AvatarData>(Uid)!;

            foreach (var avatar in AvatarInfo.Avatars)
            {
                avatar.PlayerData = this;
                avatar.Excel = GameData.AvatarConfigData[avatar.AvatarId];
            }

            var info = new PlayerSimpleInfo()
            {
                Nickname = Name,
                Level = (uint)Level,
                Signature = Signature,
                Uid = (uint)Uid,
                OnlineStatus = status,
                HeadIcon = (uint)HeadIcon,
                Platform = PlatformType.Pc,
                LastActiveTime = LastActiveTime,
            };

            var pos = 0;
            foreach (var assist in AvatarInfo.AssistAvatars)
            {
                var avatar = AvatarInfo.Avatars.Find(x => x.AvatarId == assist)!;
                info.AssistInfo.Add(new AssistSimpleInfo()
                {
                    AvatarId = (uint)avatar.AvatarId,
                    Level = (uint)avatar.Level,
                    Pos = (uint)pos++
                });
            }

            return info;
        }

        public PlayerDetailInfo ToDetailProto()
        {
            var info = new PlayerDetailInfo()
            {
                Nickname = Name,
                Level = (uint)Level,
                Signature = Signature,
                IsBanned = false,
                HeadIcon = (uint)HeadIcon,
                Platform = PlatformType.Pc,
                Uid = (uint)Uid,
                WorldLevel = (uint)WorldLevel,
                RecordInfo = new(),
            };

            var AvatarInfo = DatabaseHelper.Instance!.GetInstance<AvatarData>(Uid);

            if (AvatarInfo != null)
            {
                foreach (var avatar in AvatarInfo.Avatars)
                {
                    avatar.PlayerData = this;
                    avatar.Excel = GameData.AvatarConfigData[avatar.AvatarId];
                }
                var pos = 0;
                foreach (var assist in AvatarInfo.AssistAvatars)
                {
                    var avatar = AvatarInfo.Avatars.Find(x => x.AvatarId == assist)!;
                    info.AssistAvatarList.Add(avatar.ToDetailProto(pos++));
                }

                pos = 0;
                foreach (var display in AvatarInfo.DisplayAvatars)
                {
                    var avatar = AvatarInfo.Avatars.Find(x => x.AvatarId == display)!;
                    info.DisplayAvatarList.Add(avatar.ToDetailProto(pos++));
                }
            }

            return info;
        }
    }
}
