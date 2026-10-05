using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200478D RID: 18317
	[Token(Token = "0x200478D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RecalRuneUtil
	{
		// Token: 0x0601BBB8 RID: 113592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BBB8")]
		[Address(RVA = "0x1514F50", Offset = "0x1513B50", VA = "0x181514F50")]
		public static Sprite LoadRuneIcon(ILoadAsset iLoadAsset, string iconId)
		{
			return null;
		}

		// Token: 0x0601BBB9 RID: 113593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BBB9")]
		[Address(RVA = "0x1514DE0", Offset = "0x15139E0", VA = "0x181514DE0")]
		public static Sprite LoadFixedRuneIcon(ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x0601BBBA RID: 113594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BBBA")]
		[Address(RVA = "0x1515070", Offset = "0x1513C70", VA = "0x181515070")]
		public static Sprite LoadSeasonPic(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x0601BBBB RID: 113595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BBBB")]
		[Address(RVA = "0x1514BA0", Offset = "0x15137A0", VA = "0x181514BA0")]
		public static string GetSeasonPicPath(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x0601BBBC RID: 113596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BBBC")]
		[Address(RVA = "0x1515190", Offset = "0x1513D90", VA = "0x181515190")]
		public static Sprite LoadStageIconPic(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x0601BBBD RID: 113597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BBBD")]
		[Address(RVA = "0x1514890", Offset = "0x1513490", VA = "0x181514890")]
		public static string GetRuneDescription(RuneTable.PackedRuneData packedRuneData)
		{
			return null;
		}

		// Token: 0x0601BBBE RID: 113598 RVA: 0x000A5F90 File Offset: 0x000A4190
		[Token(Token = "0x601BBBE")]
		[Address(RVA = "0x15143E0", Offset = "0x1512FE0", VA = "0x1815143E0")]
		public static bool CheckSeasonCanClaimReward(RecalRuneConstData constData, RecalRuneSeasonData seasonData, PlayerRecalRuneSeason playerSeason)
		{
			return default(bool);
		}

		// Token: 0x0601BBBF RID: 113599 RVA: 0x000A5FA8 File Offset: 0x000A41A8
		[Token(Token = "0x601BBBF")]
		[Address(RVA = "0x1514260", Offset = "0x1512E60", VA = "0x181514260")]
		public static bool CheckPlayerUnlock(RecalRuneConstData constData)
		{
			return default(bool);
		}

		// Token: 0x0601BBC0 RID: 113600 RVA: 0x000A5FC0 File Offset: 0x000A41C0
		[Token(Token = "0x601BBC0")]
		[Address(RVA = "0x15141D0", Offset = "0x1512DD0", VA = "0x1815141D0")]
		public static bool CheckHasNewSeasonTrack()
		{
			return default(bool);
		}

		// Token: 0x0601BBC1 RID: 113601 RVA: 0x000A5FD8 File Offset: 0x000A41D8
		[Token(Token = "0x601BBC1")]
		[Address(RVA = "0x1514730", Offset = "0x1513330", VA = "0x181514730")]
		public static bool CheckSeasonTrack(string seasonId)
		{
			return default(bool);
		}

		// Token: 0x0601BBC2 RID: 113602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBC2")]
		[Address(RVA = "0x15147E0", Offset = "0x15133E0", VA = "0x1815147E0")]
		public static void ConsumeSeasonTrack(string seasonId)
		{
		}

		// Token: 0x040240B3 RID: 147635
		[Token(Token = "0x40240B3")]
		private const string FIXED_RUNE_ICON_ID = "fixed_rune_icon";

		// Token: 0x040240B4 RID: 147636
		[Token(Token = "0x40240B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadRuneIcon;

		// Token: 0x040240B5 RID: 147637
		[Token(Token = "0x40240B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadFixedRuneIcon;

		// Token: 0x040240B6 RID: 147638
		[Token(Token = "0x40240B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadSeasonPic;

		// Token: 0x040240B7 RID: 147639
		[Token(Token = "0x40240B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSeasonPicPath;

		// Token: 0x040240B8 RID: 147640
		[Token(Token = "0x40240B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadStageIconPic;

		// Token: 0x040240B9 RID: 147641
		[Token(Token = "0x40240B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRuneDescription;

		// Token: 0x040240BA RID: 147642
		[Token(Token = "0x40240BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckSeasonCanClaimReward;

		// Token: 0x040240BB RID: 147643
		[Token(Token = "0x40240BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckPlayerUnlock;

		// Token: 0x040240BC RID: 147644
		[Token(Token = "0x40240BC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckHasNewSeasonTrack;

		// Token: 0x040240BD RID: 147645
		[Token(Token = "0x40240BD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckSeasonTrack;

		// Token: 0x040240BE RID: 147646
		[Token(Token = "0x40240BE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ConsumeSeasonTrack;
	}
}
