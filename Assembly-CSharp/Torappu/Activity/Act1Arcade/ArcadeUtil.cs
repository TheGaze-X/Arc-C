using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200791E RID: 31006
	[Token(Token = "0x200791E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ArcadeUtil
	{
		// Token: 0x0602B7F2 RID: 178162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7F2")]
		[Address(RVA = "0x277B6B0", Offset = "0x277A2B0", VA = "0x18277B6B0")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0602B7F3 RID: 178163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7F3")]
		[Address(RVA = "0x277B460", Offset = "0x277A060", VA = "0x18277B460")]
		public static Act1ArcadeTopMenu CreateArcadeTopMenu(string actId, ILoadAsset assetLoader, RectTransform container, Action onClickBack)
		{
			return null;
		}

		// Token: 0x0602B7F4 RID: 178164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7F4")]
		[Address(RVA = "0x277B830", Offset = "0x277A430", VA = "0x18277B830")]
		public static ActArcadeData GetActArcadeData(string actId)
		{
			return null;
		}

		// Token: 0x0602B7F5 RID: 178165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7F5")]
		[Address(RVA = "0x277B910", Offset = "0x277A510", VA = "0x18277B910")]
		public static PlayerActivity.PlayerArcadeActivity GetArcadePlayerData(string actId)
		{
			return null;
		}

		// Token: 0x0602B7F6 RID: 178166 RVA: 0x000DC3E0 File Offset: 0x000DA5E0
		[Token(Token = "0x602B7F6")]
		[Address(RVA = "0x277AE50", Offset = "0x2779A50", VA = "0x18277AE50")]
		public static int CalculateArcadeAllZoneScore(PlayerActivity.PlayerArcadeActivity playerData)
		{
			return 0;
		}

		// Token: 0x0602B7F7 RID: 178167 RVA: 0x000DC3F8 File Offset: 0x000DA5F8
		[Token(Token = "0x602B7F7")]
		[Address(RVA = "0x277B290", Offset = "0x2779E90", VA = "0x18277B290")]
		public static int CalculateArcadeZoneScore(PlayerActivity.PlayerArcadeActivity playerData, string zoneId)
		{
			return 0;
		}

		// Token: 0x0602B7F8 RID: 178168 RVA: 0x000DC410 File Offset: 0x000DA610
		[Token(Token = "0x602B7F8")]
		[Address(RVA = "0x277C9A0", Offset = "0x277B5A0", VA = "0x18277C9A0")]
		public static bool TryGetArcadeStageMaxScore(string actId, string stageId, out int maxScore)
		{
			return default(bool);
		}

		// Token: 0x0602B7F9 RID: 178169 RVA: 0x000DC428 File Offset: 0x000DA628
		[Token(Token = "0x602B7F9")]
		[Address(RVA = "0x277C050", Offset = "0x277AC50", VA = "0x18277C050")]
		public static long GetStageStartTime(string stageId)
		{
			return 0L;
		}

		// Token: 0x0602B7FA RID: 178170 RVA: 0x000DC440 File Offset: 0x000DA640
		[Token(Token = "0x602B7FA")]
		[Address(RVA = "0x277BA40", Offset = "0x277A640", VA = "0x18277BA40")]
		public static bool GetIsZoneAvail(string actId, string zoneId, out string unlockDes)
		{
			return default(bool);
		}

		// Token: 0x0602B7FB RID: 178171 RVA: 0x000DC458 File Offset: 0x000DA658
		[Token(Token = "0x602B7FB")]
		[Address(RVA = "0x277B0A0", Offset = "0x2779CA0", VA = "0x18277B0A0")]
		public static int CalculateArcadeZoneMaxScore(string actId, string zoneId)
		{
			return 0;
		}

		// Token: 0x0602B7FC RID: 178172 RVA: 0x000DC470 File Offset: 0x000DA670
		[Token(Token = "0x602B7FC")]
		[Address(RVA = "0x277BCE0", Offset = "0x277A8E0", VA = "0x18277BCE0")]
		public static int GetMaxCompletedTierIndexOfBadge(string actId, string badgeId)
		{
			return 0;
		}

		// Token: 0x0602B7FD RID: 178173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7FD")]
		[Address(RVA = "0x277C360", Offset = "0x277AF60", VA = "0x18277C360")]
		public static Sprite GetZoneEntrySprite(string actId, string picId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602B7FE RID: 178174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7FE")]
		[Address(RVA = "0x277C290", Offset = "0x277AE90", VA = "0x18277C290")]
		public static Sprite GetZoneEntryLockedSprite(string actId, string picId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602B7FF RID: 178175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7FF")]
		[Address(RVA = "0x277C410", Offset = "0x277B010", VA = "0x18277C410")]
		public static GameObject GetZoneInfoGameObject(string actId, string infoId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602B800 RID: 178176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B800")]
		[Address(RVA = "0x277C1F0", Offset = "0x277ADF0", VA = "0x18277C1F0")]
		public static GameObject GetTopMenuGameObject(string actId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602B801 RID: 178177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B801")]
		[Address(RVA = "0x277C130", Offset = "0x277AD30", VA = "0x18277C130")]
		public static GameObject GetStatusViewGameObject(string actId, string prefabId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602B802 RID: 178178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B802")]
		[Address(RVA = "0x277BF80", Offset = "0x277AB80", VA = "0x18277BF80")]
		public static Sprite GetRankSmallSprite(string actId, string rankStr, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602B803 RID: 178179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B803")]
		[Address(RVA = "0x277BEB0", Offset = "0x277AAB0", VA = "0x18277BEB0")]
		public static Sprite GetRankBigSprite(string actId, string rankStr, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602B804 RID: 178180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B804")]
		[Address(RVA = "0x277C690", Offset = "0x277B290", VA = "0x18277C690")]
		public static GameObject LoadBadgeBookItemEffect(ILoadAsset iLoadAsset, string actId, string effectId)
		{
			return null;
		}

		// Token: 0x0602B805 RID: 178181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B805")]
		[Address(RVA = "0x277C5A0", Offset = "0x277B1A0", VA = "0x18277C5A0")]
		public static Sprite LoadBadgeBookBadgeLockedIcon(ILoadAsset iLoadAsset, string actId, string badgeId)
		{
			return null;
		}

		// Token: 0x0602B806 RID: 178182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B806")]
		[Address(RVA = "0x277C4D0", Offset = "0x277B0D0", VA = "0x18277C4D0")]
		public static Sprite LoadBadgeBookBadgeIcon(ILoadAsset iLoadAsset, string actId, string iconId)
		{
			return null;
		}

		// Token: 0x0602B807 RID: 178183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B807")]
		[Address(RVA = "0x277C750", Offset = "0x277B350", VA = "0x18277C750")]
		public static Sprite LoadBadgeBookTierIcon(ILoadAsset iLoadAsset, string actId, int tier)
		{
			return null;
		}

		// Token: 0x0602B808 RID: 178184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B808")]
		[Address(RVA = "0x277C860", Offset = "0x277B460", VA = "0x18277C860")]
		public static Sprite LoadBadgeBookTierTitleIcon(ILoadAsset iLoadAsset, string actId, int tier, bool showAsPreserved)
		{
			return null;
		}

		// Token: 0x0602B809 RID: 178185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B809")]
		[Address(RVA = "0x277CB30", Offset = "0x277B730", VA = "0x18277CB30")]
		private static Sprite _GetSpriteByAutoPackSpriteHub(ILoadAsset iLoadAsset, AutoPackSpriteHub hub, string spriteId)
		{
			return null;
		}

		// Token: 0x0403EE33 RID: 257587
		[Token(Token = "0x403EE33")]
		public const string KEY_BUNDLE_PREF_SELECT_STAGE_ID = "key_pref_select_stage_id";

		// Token: 0x0403EE34 RID: 257588
		[Token(Token = "0x403EE34")]
		public const string EMPTY_STATUS_VIEW_ID = "empty_view";

		// Token: 0x0403EE35 RID: 257589
		[Token(Token = "0x403EE35")]
		public const string ENTRY_STATUS_VIEW_ID = "entry_view";

		// Token: 0x0403EE36 RID: 257590
		[Token(Token = "0x403EE36")]
		public const string BADGE_BOOK_BADGE_LOCKED_ICON_FORMAT = "{0}_0";

		// Token: 0x0403EE37 RID: 257591
		[Token(Token = "0x403EE37")]
		public const string BADGE_BOOK_TIER_ICON_FORMAT = "tier_{0}";

		// Token: 0x0403EE38 RID: 257592
		[Token(Token = "0x403EE38")]
		private const string BADGE_BOOK_TIER_TITLE_ICON_FORMAT = "tier_title_{0}";

		// Token: 0x0403EE39 RID: 257593
		[Token(Token = "0x403EE39")]
		private const string BADGE_BOOK_TIER_TITLE_ICON_ARROW = "tier_title_preserved";

		// Token: 0x0403EE3A RID: 257594
		[Token(Token = "0x403EE3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0403EE3B RID: 257595
		[Token(Token = "0x403EE3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateArcadeTopMenu;

		// Token: 0x0403EE3C RID: 257596
		[Token(Token = "0x403EE3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetActArcadeData;

		// Token: 0x0403EE3D RID: 257597
		[Token(Token = "0x403EE3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetArcadePlayerData;

		// Token: 0x0403EE3E RID: 257598
		[Token(Token = "0x403EE3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CalculateArcadeAllZoneScore;

		// Token: 0x0403EE3F RID: 257599
		[Token(Token = "0x403EE3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalculateArcadeZoneScore;

		// Token: 0x0403EE40 RID: 257600
		[Token(Token = "0x403EE40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryGetArcadeStageMaxScore;

		// Token: 0x0403EE41 RID: 257601
		[Token(Token = "0x403EE41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetStageStartTime;

		// Token: 0x0403EE42 RID: 257602
		[Token(Token = "0x403EE42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetIsZoneAvail;

		// Token: 0x0403EE43 RID: 257603
		[Token(Token = "0x403EE43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CalculateArcadeZoneMaxScore;

		// Token: 0x0403EE44 RID: 257604
		[Token(Token = "0x403EE44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetMaxCompletedTierIndexOfBadge;

		// Token: 0x0403EE45 RID: 257605
		[Token(Token = "0x403EE45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetZoneEntrySprite;

		// Token: 0x0403EE46 RID: 257606
		[Token(Token = "0x403EE46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetZoneEntryLockedSprite;

		// Token: 0x0403EE47 RID: 257607
		[Token(Token = "0x403EE47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetZoneInfoGameObject;

		// Token: 0x0403EE48 RID: 257608
		[Token(Token = "0x403EE48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetTopMenuGameObject;

		// Token: 0x0403EE49 RID: 257609
		[Token(Token = "0x403EE49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetStatusViewGameObject;

		// Token: 0x0403EE4A RID: 257610
		[Token(Token = "0x403EE4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetRankSmallSprite;

		// Token: 0x0403EE4B RID: 257611
		[Token(Token = "0x403EE4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetRankBigSprite;

		// Token: 0x0403EE4C RID: 257612
		[Token(Token = "0x403EE4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadBadgeBookItemEffect;

		// Token: 0x0403EE4D RID: 257613
		[Token(Token = "0x403EE4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadBadgeBookBadgeLockedIcon;

		// Token: 0x0403EE4E RID: 257614
		[Token(Token = "0x403EE4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadBadgeBookBadgeIcon;

		// Token: 0x0403EE4F RID: 257615
		[Token(Token = "0x403EE4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadBadgeBookTierIcon;

		// Token: 0x0403EE50 RID: 257616
		[Token(Token = "0x403EE50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadBadgeBookTierTitleIcon;

		// Token: 0x0403EE51 RID: 257617
		[Token(Token = "0x403EE51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetSpriteByAutoPackSpriteHub;
	}
}
