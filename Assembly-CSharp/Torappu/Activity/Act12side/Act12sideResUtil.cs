using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A57 RID: 31319
	[Token(Token = "0x2007A57")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act12sideResUtil
	{
		// Token: 0x0602BDFB RID: 179707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BDFB")]
		[Address(RVA = "0x27C32E0", Offset = "0x27C1EE0", VA = "0x1827C32E0")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0602BDFC RID: 179708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BDFC")]
		[Address(RVA = "0x27C3970", Offset = "0x27C2570", VA = "0x1827C3970")]
		public static PlayerActivity.PlayerAct12sideActivity GetPlayerActData(string activityId)
		{
			return null;
		}

		// Token: 0x0602BDFD RID: 179709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BDFD")]
		[Address(RVA = "0x27C3900", Offset = "0x27C2500", VA = "0x1827C3900")]
		public static PlayerActivity.PlayerAct12sideActivity.MilestoneInfo GetMilestoneInfo(string activityId)
		{
			return null;
		}

		// Token: 0x0602BDFE RID: 179710 RVA: 0x000DD790 File Offset: 0x000DB990
		[Token(Token = "0x602BDFE")]
		[Address(RVA = "0x27C3A50", Offset = "0x27C2650", VA = "0x1827C3A50")]
		public static int GetShopCointCount(string activityId)
		{
			return 0;
		}

		// Token: 0x0602BDFF RID: 179711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDFF")]
		[Address(RVA = "0x27C3430", Offset = "0x27C2030", VA = "0x1827C3430")]
		public static void FetchMissionCompletion(string actId, out int missionCompleteCount, out int missionTotalCount)
		{
		}

		// Token: 0x0602BE00 RID: 179712 RVA: 0x000DD7A8 File Offset: 0x000DB9A8
		[Token(Token = "0x602BE00")]
		[Address(RVA = "0x27C3F70", Offset = "0x27C2B70", VA = "0x1827C3F70")]
		public static bool IsZoneAccessed(string activityId, string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0602BE01 RID: 179713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE01")]
		[Address(RVA = "0x27C4430", Offset = "0x27C3030", VA = "0x1827C4430")]
		public static void SetZoneAccessed(string activityId, string zoneId)
		{
		}

		// Token: 0x0602BE02 RID: 179714 RVA: 0x000DD7C0 File Offset: 0x000DB9C0
		[Token(Token = "0x602BE02")]
		[Address(RVA = "0x27C3E80", Offset = "0x27C2A80", VA = "0x1827C3E80")]
		public static bool IsStageAccessed(string activityId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602BE03 RID: 179715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE03")]
		[Address(RVA = "0x27C4260", Offset = "0x27C2E60", VA = "0x1827C4260")]
		public static void SetStageAccessed(string activityId, List<string> stageIdList)
		{
		}

		// Token: 0x0602BE04 RID: 179716 RVA: 0x000DD7D8 File Offset: 0x000DB9D8
		[Token(Token = "0x602BE04")]
		[Address(RVA = "0x27C3D60", Offset = "0x27C2960", VA = "0x1827C3D60")]
		public static bool IsMissionChecked(string activityId, string missionId)
		{
			return default(bool);
		}

		// Token: 0x0602BE05 RID: 179717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE05")]
		[Address(RVA = "0x27C4000", Offset = "0x27C2C00", VA = "0x1827C4000")]
		public static void SetMissionChecked(string activityId, List<string> missionIdList)
		{
		}

		// Token: 0x0602BE06 RID: 179718 RVA: 0x000DD7F0 File Offset: 0x000DB9F0
		[Token(Token = "0x602BE06")]
		[Address(RVA = "0x27C3DF0", Offset = "0x27C29F0", VA = "0x1827C3DF0")]
		public static bool IsPhotoChecked(string activityId, string photoId)
		{
			return default(bool);
		}

		// Token: 0x0602BE07 RID: 179719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE07")]
		[Address(RVA = "0x27C41D0", Offset = "0x27C2DD0", VA = "0x1827C41D0")]
		public static void SetPhotoChecked(string activityId, string photoId)
		{
		}

		// Token: 0x0602BE08 RID: 179720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE08")]
		[Address(RVA = "0x27C44C0", Offset = "0x27C30C0", VA = "0x1827C44C0")]
		private static string _GenerateActLocalCacheKey(string prefix, string activityId, string id)
		{
			return null;
		}

		// Token: 0x0602BE09 RID: 179721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE09")]
		[Address(RVA = "0x27C3650", Offset = "0x27C2250", VA = "0x1827C3650")]
		public static Act12SideData GetActivityData(string actId)
		{
			return null;
		}

		// Token: 0x0602BE0A RID: 179722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE0A")]
		[Address(RVA = "0x27C3740", Offset = "0x27C2340", VA = "0x1827C3740")]
		public static PlayerActivity.PlayerAct12sideActivity GetActivityStatus(string actId)
		{
			return null;
		}

		// Token: 0x0602BE0B RID: 179723 RVA: 0x000DD808 File Offset: 0x000DBA08
		[Token(Token = "0x602BE0B")]
		[Address(RVA = "0x27C3CC0", Offset = "0x27C28C0", VA = "0x1827C3CC0")]
		public static bool IsCharmUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602BE0C RID: 179724 RVA: 0x000DD820 File Offset: 0x000DBA20
		[Token(Token = "0x602BE0C")]
		[Address(RVA = "0x27C3BB0", Offset = "0x27C27B0", VA = "0x1827C3BB0")]
		public static bool IsActStageClosed(string activityId)
		{
			return default(bool);
		}

		// Token: 0x0602BE0D RID: 179725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE0D")]
		[Address(RVA = "0x27C3820", Offset = "0x27C2420", VA = "0x1827C3820")]
		public static string GetCharmUnlockHint(string actId)
		{
			return null;
		}

		// Token: 0x0602BE0E RID: 179726 RVA: 0x000DD838 File Offset: 0x000DBA38
		[Token(Token = "0x602BE0E")]
		[Address(RVA = "0x27C3F10", Offset = "0x27C2B10", VA = "0x1827C3F10")]
		public static bool IsStageUnlock(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602BE0F RID: 179727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE0F")]
		[Address(RVA = "0x27C3AC0", Offset = "0x27C26C0", VA = "0x1827C3AC0")]
		public static string GetUiSpineAnimationKey(Act12SideData.RecycleAnimationState eState)
		{
			return null;
		}

		// Token: 0x0403F8A0 RID: 260256
		[Token(Token = "0x403F8A0")]
		public const string ACT_LOCAL_CACHE_PREFIX_ACCESSED_ZONE_ID = "accessed_zone_id";

		// Token: 0x0403F8A1 RID: 260257
		[Token(Token = "0x403F8A1")]
		public const string ACT_LOCAL_CACHE_PREFIX_ACCESSED_STAGE_ID = "accessed_stage_id";

		// Token: 0x0403F8A2 RID: 260258
		[Token(Token = "0x403F8A2")]
		public const string ACT_LOCAL_CACHE_PREFIX_MISSION_CHECK = "act12side_mission_check_status";

		// Token: 0x0403F8A3 RID: 260259
		[Token(Token = "0x403F8A3")]
		public const string ACT_LOCAL_CACHE_PREFIX_PHOTO_CHECK = "act12side_photo_check_status";

		// Token: 0x0403F8A4 RID: 260260
		[Token(Token = "0x403F8A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0403F8A5 RID: 260261
		[Token(Token = "0x403F8A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlayerActData;

		// Token: 0x0403F8A6 RID: 260262
		[Token(Token = "0x403F8A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMilestoneInfo;

		// Token: 0x0403F8A7 RID: 260263
		[Token(Token = "0x403F8A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetShopCointCount;

		// Token: 0x0403F8A8 RID: 260264
		[Token(Token = "0x403F8A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FetchMissionCompletion;

		// Token: 0x0403F8A9 RID: 260265
		[Token(Token = "0x403F8A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsZoneAccessed;

		// Token: 0x0403F8AA RID: 260266
		[Token(Token = "0x403F8AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetZoneAccessed;

		// Token: 0x0403F8AB RID: 260267
		[Token(Token = "0x403F8AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsStageAccessed;

		// Token: 0x0403F8AC RID: 260268
		[Token(Token = "0x403F8AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetStageAccessed;

		// Token: 0x0403F8AD RID: 260269
		[Token(Token = "0x403F8AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsMissionChecked;

		// Token: 0x0403F8AE RID: 260270
		[Token(Token = "0x403F8AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetMissionChecked;

		// Token: 0x0403F8AF RID: 260271
		[Token(Token = "0x403F8AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsPhotoChecked;

		// Token: 0x0403F8B0 RID: 260272
		[Token(Token = "0x403F8B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetPhotoChecked;

		// Token: 0x0403F8B1 RID: 260273
		[Token(Token = "0x403F8B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenerateActLocalCacheKey;

		// Token: 0x0403F8B2 RID: 260274
		[Token(Token = "0x403F8B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetActivityData;

		// Token: 0x0403F8B3 RID: 260275
		[Token(Token = "0x403F8B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetActivityStatus;

		// Token: 0x0403F8B4 RID: 260276
		[Token(Token = "0x403F8B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsCharmUnlock;

		// Token: 0x0403F8B5 RID: 260277
		[Token(Token = "0x403F8B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_IsActStageClosed;

		// Token: 0x0403F8B6 RID: 260278
		[Token(Token = "0x403F8B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetCharmUnlockHint;

		// Token: 0x0403F8B7 RID: 260279
		[Token(Token = "0x403F8B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsStageUnlock;

		// Token: 0x0403F8B8 RID: 260280
		[Token(Token = "0x403F8B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetUiSpineAnimationKey;

		// Token: 0x02007A58 RID: 31320
		[Token(Token = "0x2007A58")]
		public static class Act12SideUiSpineAnimation
		{
			// Token: 0x0403F8B9 RID: 260281
			[Token(Token = "0x403F8B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static string NORMAL_KEY;

			// Token: 0x0403F8BA RID: 260282
			[Token(Token = "0x403F8BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static string SMILE_KEY;
		}
	}
}
