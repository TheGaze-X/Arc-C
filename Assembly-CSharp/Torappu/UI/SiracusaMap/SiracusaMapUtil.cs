using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F6B RID: 16235
	[Token(Token = "0x2003F6B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SiracusaMapUtil
	{
		// Token: 0x06019310 RID: 103184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019310")]
		[Address(RVA = "0x11F4470", Offset = "0x11F3070", VA = "0x1811F4470")]
		public static string GetAvgStateDescByType(SIRACUSA_MAP_AVG_TYPE avgType)
		{
			return null;
		}

		// Token: 0x06019311 RID: 103185 RVA: 0x0009D338 File Offset: 0x0009B538
		[Token(Token = "0x6019311")]
		[Address(RVA = "0x11F45D0", Offset = "0x11F31D0", VA = "0x1811F45D0")]
		public static bool IsOperaAllRelease()
		{
			return default(bool);
		}

		// Token: 0x06019312 RID: 103186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019312")]
		[Address(RVA = "0x11F4560", Offset = "0x11F3160", VA = "0x1811F4560")]
		public static string GetItalyNameId(string charId)
		{
			return null;
		}

		// Token: 0x06019313 RID: 103187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019313")]
		[Address(RVA = "0x11F48A0", Offset = "0x11F34A0", VA = "0x1811F48A0")]
		public static Sprite LoadSiracusaHeadIcon(string operaId, UIPage page)
		{
			return null;
		}

		// Token: 0x06019314 RID: 103188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019314")]
		[Address(RVA = "0x11F4780", Offset = "0x11F3380", VA = "0x1811F4780")]
		public static Sprite LoadSiracusaCharCardIconByPage(string charCardId, UIPage page)
		{
			return null;
		}

		// Token: 0x06019315 RID: 103189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019315")]
		[Address(RVA = "0x11F4810", Offset = "0x11F3410", VA = "0x1811F4810")]
		public static Sprite LoadSiracusaCharCardItemIconByPage(string itemIconId, UIPage page)
		{
			return null;
		}

		// Token: 0x06019316 RID: 103190 RVA: 0x0009D350 File Offset: 0x0009B550
		[Token(Token = "0x6019316")]
		[Address(RVA = "0x11F4150", Offset = "0x11F2D50", VA = "0x1811F4150")]
		public static bool CheckIfShowCharCardTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x06019317 RID: 103191 RVA: 0x0009D368 File Offset: 0x0009B568
		[Token(Token = "0x6019317")]
		[Address(RVA = "0x11F4290", Offset = "0x11F2E90", VA = "0x1811F4290")]
		public static bool CheckIfSkipRecordStage(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06019318 RID: 103192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019318")]
		[Address(RVA = "0x11F49E0", Offset = "0x11F35E0", VA = "0x1811F49E0")]
		private static string _GenCharCardItemTrackKey(string charCardId)
		{
			return null;
		}

		// Token: 0x06019319 RID: 103193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019319")]
		[Address(RVA = "0x11F4930", Offset = "0x11F3530", VA = "0x1811F4930")]
		public static void TrackCharCardItem(string charCardId)
		{
		}

		// Token: 0x0601931A RID: 103194 RVA: 0x0009D380 File Offset: 0x0009B580
		[Token(Token = "0x601931A")]
		[Address(RVA = "0x11F40A0", Offset = "0x11F2CA0", VA = "0x1811F40A0")]
		public static bool CheckCharCardItemTrack(string charCardId)
		{
			return default(bool);
		}

		// Token: 0x0601931B RID: 103195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601931B")]
		[Address(RVA = "0x11F43C0", Offset = "0x11F2FC0", VA = "0x1811F43C0")]
		public static void ConsumeCharCardItemTrack(string charCardId)
		{
		}

		// Token: 0x0401F3C7 RID: 127943
		[Token(Token = "0x401F3C7")]
		private const string ITALY_NAME_PREFIX = "name_{0}";

		// Token: 0x0401F3C8 RID: 127944
		[Token(Token = "0x401F3C8")]
		private const string CHAR_CARD_ITEM_TRACK_KEY = "char_card_item_{0}";

		// Token: 0x0401F3C9 RID: 127945
		[Token(Token = "0x401F3C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAvgStateDescByType;

		// Token: 0x0401F3CA RID: 127946
		[Token(Token = "0x401F3CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsOperaAllRelease;

		// Token: 0x0401F3CB RID: 127947
		[Token(Token = "0x401F3CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetItalyNameId;

		// Token: 0x0401F3CC RID: 127948
		[Token(Token = "0x401F3CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadSiracusaHeadIcon;

		// Token: 0x0401F3CD RID: 127949
		[Token(Token = "0x401F3CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadSiracusaCharCardIconByPage;

		// Token: 0x0401F3CE RID: 127950
		[Token(Token = "0x401F3CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadSiracusaCharCardItemIconByPage;

		// Token: 0x0401F3CF RID: 127951
		[Token(Token = "0x401F3CF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIfShowCharCardTrackPoint;

		// Token: 0x0401F3D0 RID: 127952
		[Token(Token = "0x401F3D0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfSkipRecordStage;

		// Token: 0x0401F3D1 RID: 127953
		[Token(Token = "0x401F3D1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenCharCardItemTrackKey;

		// Token: 0x0401F3D2 RID: 127954
		[Token(Token = "0x401F3D2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TrackCharCardItem;

		// Token: 0x0401F3D3 RID: 127955
		[Token(Token = "0x401F3D3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckCharCardItemTrack;

		// Token: 0x0401F3D4 RID: 127956
		[Token(Token = "0x401F3D4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ConsumeCharCardItemTrack;
	}
}
