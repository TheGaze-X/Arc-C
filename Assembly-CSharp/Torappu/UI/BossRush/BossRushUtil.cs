using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006181 RID: 24961
	[Token(Token = "0x2006181")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BossRushUtil
	{
		// Token: 0x06024016 RID: 147478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024016")]
		[Address(RVA = "0x1EACCA0", Offset = "0x1EAB8A0", VA = "0x181EACCA0")]
		public static Sprite LoadRelicIcon(string spriteId, string actId, string pageName)
		{
			return null;
		}

		// Token: 0x06024017 RID: 147479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024017")]
		[Address(RVA = "0x1EACD70", Offset = "0x1EAB970", VA = "0x181EACD70")]
		public static Sprite LoadRewardImage(string actId)
		{
			return null;
		}

		// Token: 0x06024018 RID: 147480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024018")]
		[Address(RVA = "0x1EACC10", Offset = "0x1EAB810", VA = "0x181EACC10")]
		public static Sprite LoadMapPreview(string spriteId, string actId)
		{
			return null;
		}

		// Token: 0x06024019 RID: 147481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024019")]
		[Address(RVA = "0x1EACF30", Offset = "0x1EABB30", VA = "0x181EACF30")]
		public static Sprite LoadTeamIcon(int teamIconNo, string actId)
		{
			return null;
		}

		// Token: 0x0602401A RID: 147482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602401A")]
		[Address(RVA = "0x1EACE90", Offset = "0x1EABA90", VA = "0x181EACE90")]
		public static Sprite LoadTeamBuff(string spriteId, string actId, string pageName)
		{
			return null;
		}

		// Token: 0x0602401B RID: 147483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602401B")]
		[Address(RVA = "0x1EACE00", Offset = "0x1EABA00", VA = "0x181EACE00")]
		public static Sprite LoadStageMapPreview(string mapId, string actId)
		{
			return null;
		}

		// Token: 0x0602401C RID: 147484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602401C")]
		[Address(RVA = "0x1EAC7B0", Offset = "0x1EAB3B0", VA = "0x181EAC7B0")]
		public static ActivityBossRushData GetBossRushData(string actId)
		{
			return null;
		}

		// Token: 0x0602401D RID: 147485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602401D")]
		[Address(RVA = "0x1EAC880", Offset = "0x1EAB480", VA = "0x181EAC880")]
		public static string GetBossRushStageTypeName(ActivityBossRushData.BossRushStageType stageType)
		{
			return null;
		}

		// Token: 0x0602401E RID: 147486 RVA: 0x000C2BE0 File Offset: 0x000C0DE0
		[Token(Token = "0x602401E")]
		[Address(RVA = "0x1EAC9A0", Offset = "0x1EAB5A0", VA = "0x181EAC9A0")]
		public static MilestoneStruct GetMilestoneStructByItemCount(string actId, int itemCount)
		{
			return default(MilestoneStruct);
		}

		// Token: 0x0602401F RID: 147487 RVA: 0x000C2BF8 File Offset: 0x000C0DF8
		[Token(Token = "0x602401F")]
		[Address(RVA = "0x1EAC300", Offset = "0x1EAAF00", VA = "0x181EAC300")]
		public static bool CheckIfHasMilestoneItemNotReceive(string actId)
		{
			return default(bool);
		}

		// Token: 0x06024020 RID: 147488 RVA: 0x000C2C10 File Offset: 0x000C0E10
		[Token(Token = "0x6024020")]
		[Address(RVA = "0x1EABF50", Offset = "0x1EAAB50", VA = "0x181EABF50")]
		public static bool CheckIfExistRelicCanUpgrade(string actId)
		{
			return default(bool);
		}

		// Token: 0x06024021 RID: 147489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024021")]
		[Address(RVA = "0x1EAD010", Offset = "0x1EABC10", VA = "0x181EAD010")]
		public static void LogRelicAchieved(string actId, string relicId)
		{
		}

		// Token: 0x06024022 RID: 147490 RVA: 0x000C2C28 File Offset: 0x000C0E28
		[Token(Token = "0x6024022")]
		[Address(RVA = "0x1EABE60", Offset = "0x1EAAA60", VA = "0x181EABE60")]
		public static bool CheckHasRelicUnlockTrack(string actId, List<string> relicIdList)
		{
			return default(bool);
		}

		// Token: 0x06024023 RID: 147491 RVA: 0x000C2C40 File Offset: 0x000C0E40
		[Token(Token = "0x6024023")]
		[Address(RVA = "0x1EAC620", Offset = "0x1EAB220", VA = "0x181EAC620")]
		public static bool CheckRelicUnlockTrack(string actId, string relicId)
		{
			return default(bool);
		}

		// Token: 0x06024024 RID: 147492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024024")]
		[Address(RVA = "0x1EAC6F0", Offset = "0x1EAB2F0", VA = "0x181EAC6F0")]
		public static void ConsumeRelicUnlockTrack(string actId, string relicId)
		{
		}

		// Token: 0x06024025 RID: 147493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024025")]
		[Address(RVA = "0x1EAD0D0", Offset = "0x1EABCD0", VA = "0x181EAD0D0")]
		private static string _GenRelicTrackKey(string actId, string relicId)
		{
			return null;
		}

		// Token: 0x04032058 RID: 204888
		[Token(Token = "0x4032058")]
		public const string FORMAT_MAP_PREVIEW_SPRITE_ID = "map_{0}_{1:D2}";

		// Token: 0x04032059 RID: 204889
		[Token(Token = "0x4032059")]
		public const string FORMAT_STAGE_MAP_PREVIEW_SPRITE_ID = "stage_{0}_{1:D2}";

		// Token: 0x0403205A RID: 204890
		[Token(Token = "0x403205A")]
		private const string TEAM_ICON_SPRITE_ID_FORMAT = "img_team_icon_{0:D2}";

		// Token: 0x0403205B RID: 204891
		[Token(Token = "0x403205B")]
		private const string RELIC_TRACK_KEY = "{0}_{1}";

		// Token: 0x0403205C RID: 204892
		[Token(Token = "0x403205C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadRelicIcon;

		// Token: 0x0403205D RID: 204893
		[Token(Token = "0x403205D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadRewardImage;

		// Token: 0x0403205E RID: 204894
		[Token(Token = "0x403205E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadMapPreview;

		// Token: 0x0403205F RID: 204895
		[Token(Token = "0x403205F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadTeamIcon;

		// Token: 0x04032060 RID: 204896
		[Token(Token = "0x4032060")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadTeamBuff;

		// Token: 0x04032061 RID: 204897
		[Token(Token = "0x4032061")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadStageMapPreview;

		// Token: 0x04032062 RID: 204898
		[Token(Token = "0x4032062")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetBossRushData;

		// Token: 0x04032063 RID: 204899
		[Token(Token = "0x4032063")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetBossRushStageTypeName;

		// Token: 0x04032064 RID: 204900
		[Token(Token = "0x4032064")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetMilestoneStructByItemCount;

		// Token: 0x04032065 RID: 204901
		[Token(Token = "0x4032065")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfHasMilestoneItemNotReceive;

		// Token: 0x04032066 RID: 204902
		[Token(Token = "0x4032066")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfExistRelicCanUpgrade;

		// Token: 0x04032067 RID: 204903
		[Token(Token = "0x4032067")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LogRelicAchieved;

		// Token: 0x04032068 RID: 204904
		[Token(Token = "0x4032068")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckHasRelicUnlockTrack;

		// Token: 0x04032069 RID: 204905
		[Token(Token = "0x4032069")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckRelicUnlockTrack;

		// Token: 0x0403206A RID: 204906
		[Token(Token = "0x403206A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ConsumeRelicUnlockTrack;

		// Token: 0x0403206B RID: 204907
		[Token(Token = "0x403206B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenRelicTrackKey;
	}
}
