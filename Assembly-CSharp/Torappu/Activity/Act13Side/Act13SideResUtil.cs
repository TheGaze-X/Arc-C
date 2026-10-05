using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079CE RID: 31182
	[Token(Token = "0x20079CE")]
	public class Act13SideResUtil : IHotfixable
	{
		// Token: 0x1700668D RID: 26253
		// (get) Token: 0x0602BBBC RID: 179132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700668D")]
		public static string activityId
		{
			[Token(Token = "0x602BBBC")]
			[Address(RVA = "0x2799A50", Offset = "0x2798650", VA = "0x182799A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BBBD RID: 179133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBBD")]
		[Address(RVA = "0x2798490", Offset = "0x2797090", VA = "0x182798490")]
		public static Act13SideData GetActDBData(string actId)
		{
			return null;
		}

		// Token: 0x0602BBBE RID: 179134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBBE")]
		[Address(RVA = "0x2798970", Offset = "0x2797570", VA = "0x182798970")]
		public static string GetPrestigeRankName(string actId, Act13SideData.PrestigeRank prestigeRank)
		{
			return null;
		}

		// Token: 0x0602BBBF RID: 179135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBBF")]
		[Address(RVA = "0x2798640", Offset = "0x2797240", VA = "0x182798640")]
		public static Act13SideData.OrgData GetOrgData(string actId, string orgId)
		{
			return null;
		}

		// Token: 0x0602BBC0 RID: 179136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBC0")]
		[Address(RVA = "0x2798720", Offset = "0x2797320", VA = "0x182798720")]
		public static string GetOrgName(string actId, string orgId)
		{
			return null;
		}

		// Token: 0x0602BBC1 RID: 179137 RVA: 0x000DD130 File Offset: 0x000DB330
		[Token(Token = "0x602BBC1")]
		[Address(RVA = "0x2798890", Offset = "0x2797490", VA = "0x182798890")]
		public static int GetPrestigeMax(Act13SideData.OrgData orgData)
		{
			return 0;
		}

		// Token: 0x0602BBC2 RID: 179138 RVA: 0x000DD148 File Offset: 0x000DB348
		[Token(Token = "0x602BBC2")]
		[Address(RVA = "0x2798EC0", Offset = "0x2797AC0", VA = "0x182798EC0")]
		public static bool IsOrgOpen(string actId, string orgId)
		{
			return default(bool);
		}

		// Token: 0x0602BBC3 RID: 179139 RVA: 0x000DD160 File Offset: 0x000DB360
		[Token(Token = "0x602BBC3")]
		[Address(RVA = "0x2798200", Offset = "0x2796E00", VA = "0x182798200")]
		public static bool CheckDailyMissionCommitable(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602BBC4 RID: 179140 RVA: 0x000DD178 File Offset: 0x000DB378
		[Token(Token = "0x602BBC4")]
		[Address(RVA = "0x27987D0", Offset = "0x27973D0", VA = "0x1827987D0")]
		public static int GetPrestigeCount(Act13SideData.OrgData orgData)
		{
			return 0;
		}

		// Token: 0x0602BBC5 RID: 179141 RVA: 0x000DD190 File Offset: 0x000DB390
		[Token(Token = "0x602BBC5")]
		[Address(RVA = "0x2798A20", Offset = "0x2797620", VA = "0x182798A20")]
		public static Act13SideData.PrestigeRank GetPrestigeRank(Act13SideData.OrgData orgData, int prestigeCount)
		{
			return Act13SideData.PrestigeRank.D;
		}

		// Token: 0x0602BBC6 RID: 179142 RVA: 0x000DD1A8 File Offset: 0x000DB3A8
		[Token(Token = "0x602BBC6")]
		[Address(RVA = "0x27983A0", Offset = "0x2796FA0", VA = "0x1827983A0")]
		public static bool CheckDailyMissionFlag(string activityId)
		{
			return default(bool);
		}

		// Token: 0x0602BBC7 RID: 179143 RVA: 0x000DD1C0 File Offset: 0x000DB3C0
		[Token(Token = "0x602BBC7")]
		[Address(RVA = "0x2798110", Offset = "0x2796D10", VA = "0x182798110")]
		public static bool CheckDailyAgendaFlag(string activityId)
		{
			return default(bool);
		}

		// Token: 0x0602BBC8 RID: 179144 RVA: 0x000DD1D8 File Offset: 0x000DB3D8
		[Token(Token = "0x602BBC8")]
		[Address(RVA = "0x2798560", Offset = "0x2797160", VA = "0x182798560")]
		public static int GetAgendaCount(string activityId)
		{
			return 0;
		}

		// Token: 0x0602BBC9 RID: 179145 RVA: 0x000DD1F0 File Offset: 0x000DB3F0
		[Token(Token = "0x602BBC9")]
		[Address(RVA = "0x2798C00", Offset = "0x2797800", VA = "0x182798C00")]
		public static bool IsBoardFull(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602BBCA RID: 179146 RVA: 0x000DD208 File Offset: 0x000DB408
		[Token(Token = "0x602BBCA")]
		[Address(RVA = "0x2798B10", Offset = "0x2797710", VA = "0x182798B10")]
		public static bool IsBattleEnd(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602BBCB RID: 179147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBCB")]
		[Address(RVA = "0x27994A0", Offset = "0x27980A0", VA = "0x1827994A0")]
		public static Sprite LoadOrgLogo(string actId, string orgId)
		{
			return null;
		}

		// Token: 0x0602BBCC RID: 179148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBCC")]
		[Address(RVA = "0x2799550", Offset = "0x2798150", VA = "0x182799550")]
		public static Sprite LoadOrgTitle(string actId, string orgId)
		{
			return null;
		}

		// Token: 0x0602BBCD RID: 179149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBCD")]
		[Address(RVA = "0x2799600", Offset = "0x2798200", VA = "0x182799600")]
		public static Sprite LoadPrestigeEmoji(string actId, Act13SideData.PrestigeRank prestigeRank)
		{
			return null;
		}

		// Token: 0x0602BBCE RID: 179150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBCE")]
		[Address(RVA = "0x2799290", Offset = "0x2797E90", VA = "0x182799290")]
		public static Sprite LoadLeftBar(string actId, string groupId)
		{
			return null;
		}

		// Token: 0x0602BBCF RID: 179151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBCF")]
		[Address(RVA = "0x27996D0", Offset = "0x27982D0", VA = "0x1827996D0")]
		public static Sprite LoadUpTitle(string actId, string groupId)
		{
			return null;
		}

		// Token: 0x0602BBD0 RID: 179152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBD0")]
		[Address(RVA = "0x2799340", Offset = "0x2797F40", VA = "0x182799340")]
		public static Sprite LoadMissionAvatar(string actId, string principalId)
		{
			return null;
		}

		// Token: 0x0602BBD1 RID: 179153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBD1")]
		[Address(RVA = "0x27993F0", Offset = "0x2797FF0", VA = "0x1827993F0")]
		public static Sprite LoadMissionPrincipalBg(string actId, string principalId)
		{
			return null;
		}

		// Token: 0x0602BBD2 RID: 179154 RVA: 0x000DD220 File Offset: 0x000DB420
		[Token(Token = "0x602BBD2")]
		[Address(RVA = "0x2798F80", Offset = "0x2797B80", VA = "0x182798F80")]
		public static bool IsSearchHintChecked(string activityId)
		{
			return default(bool);
		}

		// Token: 0x0602BBD3 RID: 179155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBD3")]
		[Address(RVA = "0x2799830", Offset = "0x2798430", VA = "0x182799830")]
		public static void SetSearchHintChecked(string activityId)
		{
		}

		// Token: 0x0602BBD4 RID: 179156 RVA: 0x000DD238 File Offset: 0x000DB438
		[Token(Token = "0x602BBD4")]
		[Address(RVA = "0x2799020", Offset = "0x2797C20", VA = "0x182799020")]
		public static bool IsThirdOrgOpenAndMissionChecked(string activityId)
		{
			return default(bool);
		}

		// Token: 0x0602BBD5 RID: 179157 RVA: 0x000DD250 File Offset: 0x000DB450
		[Token(Token = "0x602BBD5")]
		[Address(RVA = "0x2798E20", Offset = "0x2797A20", VA = "0x182798E20")]
		public static bool IsMissionChecked(string activityId)
		{
			return default(bool);
		}

		// Token: 0x0602BBD6 RID: 179158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBD6")]
		[Address(RVA = "0x2799780", Offset = "0x2798380", VA = "0x182799780")]
		public static void SetMissionChecked(string activityId)
		{
		}

		// Token: 0x0602BBD7 RID: 179159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBD7")]
		[Address(RVA = "0x27998D0", Offset = "0x27984D0", VA = "0x1827998D0")]
		private static string _GenerateActLocalCacheKey(string prefix, string activityId, string id)
		{
			return null;
		}

		// Token: 0x0602BBD8 RID: 179160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BBD8")]
		[Address(RVA = "0x2799980", Offset = "0x2798580", VA = "0x182799980")]
		private static string _GetSpriteHubPath(string actId)
		{
			return null;
		}

		// Token: 0x0602BBD9 RID: 179161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBD9")]
		[Address(RVA = "0x27999F0", Offset = "0x27985F0", VA = "0x1827999F0")]
		public Act13SideResUtil()
		{
		}

		// Token: 0x0403F44E RID: 259150
		[Token(Token = "0x403F44E")]
		public const string ACT_LOCAL_CACHE_SEARCH_HINT = "daily_search_hint";

		// Token: 0x0403F44F RID: 259151
		[Token(Token = "0x403F44F")]
		public const string ACT_VISIT_MISSION_AFTER_NEW_FLAG = "mission_new_flag";

		// Token: 0x0403F450 RID: 259152
		[Token(Token = "0x403F450")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403F451 RID: 259153
		[Token(Token = "0x403F451")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActDBData;

		// Token: 0x0403F452 RID: 259154
		[Token(Token = "0x403F452")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPrestigeRankName;

		// Token: 0x0403F453 RID: 259155
		[Token(Token = "0x403F453")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetOrgData;

		// Token: 0x0403F454 RID: 259156
		[Token(Token = "0x403F454")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetOrgName;

		// Token: 0x0403F455 RID: 259157
		[Token(Token = "0x403F455")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPrestigeMax;

		// Token: 0x0403F456 RID: 259158
		[Token(Token = "0x403F456")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsOrgOpen;

		// Token: 0x0403F457 RID: 259159
		[Token(Token = "0x403F457")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckDailyMissionCommitable;

		// Token: 0x0403F458 RID: 259160
		[Token(Token = "0x403F458")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetPrestigeCount;

		// Token: 0x0403F459 RID: 259161
		[Token(Token = "0x403F459")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetPrestigeRank;

		// Token: 0x0403F45A RID: 259162
		[Token(Token = "0x403F45A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckDailyMissionFlag;

		// Token: 0x0403F45B RID: 259163
		[Token(Token = "0x403F45B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckDailyAgendaFlag;

		// Token: 0x0403F45C RID: 259164
		[Token(Token = "0x403F45C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetAgendaCount;

		// Token: 0x0403F45D RID: 259165
		[Token(Token = "0x403F45D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsBoardFull;

		// Token: 0x0403F45E RID: 259166
		[Token(Token = "0x403F45E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsBattleEnd;

		// Token: 0x0403F45F RID: 259167
		[Token(Token = "0x403F45F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadOrgLogo;

		// Token: 0x0403F460 RID: 259168
		[Token(Token = "0x403F460")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadOrgTitle;

		// Token: 0x0403F461 RID: 259169
		[Token(Token = "0x403F461")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadPrestigeEmoji;

		// Token: 0x0403F462 RID: 259170
		[Token(Token = "0x403F462")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadLeftBar;

		// Token: 0x0403F463 RID: 259171
		[Token(Token = "0x403F463")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadUpTitle;

		// Token: 0x0403F464 RID: 259172
		[Token(Token = "0x403F464")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadMissionAvatar;

		// Token: 0x0403F465 RID: 259173
		[Token(Token = "0x403F465")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadMissionPrincipalBg;

		// Token: 0x0403F466 RID: 259174
		[Token(Token = "0x403F466")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_IsSearchHintChecked;

		// Token: 0x0403F467 RID: 259175
		[Token(Token = "0x403F467")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetSearchHintChecked;

		// Token: 0x0403F468 RID: 259176
		[Token(Token = "0x403F468")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_IsThirdOrgOpenAndMissionChecked;

		// Token: 0x0403F469 RID: 259177
		[Token(Token = "0x403F469")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_IsMissionChecked;

		// Token: 0x0403F46A RID: 259178
		[Token(Token = "0x403F46A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SetMissionChecked;

		// Token: 0x0403F46B RID: 259179
		[Token(Token = "0x403F46B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GenerateActLocalCacheKey;

		// Token: 0x0403F46C RID: 259180
		[Token(Token = "0x403F46C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__GetSpriteHubPath;

		// Token: 0x0403F46D RID: 259181
		[Token(Token = "0x403F46D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
