using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055FD RID: 22013
	[Token(Token = "0x20055FD")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RL05ResUtil
	{
		// Token: 0x060204EE RID: 132334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204EE")]
		[Address(RVA = "0x1A6CCA0", Offset = "0x1A6B8A0", VA = "0x181A6CCA0")]
		public static RL05CommonCopperItemWithFrameView LoadCommonCopperItemWithFrameView(ILoadAsset loader, string topicId)
		{
			return null;
		}

		// Token: 0x060204EF RID: 132335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204EF")]
		[Address(RVA = "0x1A6D5D0", Offset = "0x1A6C1D0", VA = "0x181A6D5D0")]
		private static Sprite _LoadSpriteFromAutoPackHub(ILoadAsset loader, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x060204F0 RID: 132336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204F0")]
		private static T _LoadPrefabByPath<T>(ILoadAsset loader, string path) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060204F1 RID: 132337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204F1")]
		[Address(RVA = "0x1A6D400", Offset = "0x1A6C000", VA = "0x181A6D400")]
		public static void TriggerRL05CommonToast(ILoadAsset loader, string topicId, RL05CommonToastView.Param param)
		{
		}

		// Token: 0x060204F2 RID: 132338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204F2")]
		[Address(RVA = "0x1A6D230", Offset = "0x1A6BE30", VA = "0x181A6D230")]
		public static void TriggerRL05CandleToast(ILoadAsset loader, string topicId, RL05CandleToastView.Param param)
		{
		}

		// Token: 0x060204F3 RID: 132339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204F3")]
		[Address(RVA = "0x1A6D730", Offset = "0x1A6C330", VA = "0x181A6D730")]
		private static Sprite _LoadSpriteFromMiscHub(ILoadAsset loader, string spriteId, string topicId)
		{
			return null;
		}

		// Token: 0x060204F4 RID: 132340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204F4")]
		[Address(RVA = "0x1A6D020", Offset = "0x1A6BC20", VA = "0x181A6D020")]
		public static Sprite LoadZoneIconSprite(ILoadAsset loader, string topicId, string zoneIconId)
		{
			return null;
		}

		// Token: 0x060204F5 RID: 132341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204F5")]
		[Address(RVA = "0x1A6CED0", Offset = "0x1A6BAD0", VA = "0x181A6CED0")]
		public static Sprite LoadWrathIconSprite(ILoadAsset loader, string topicId, string wrathGroupId)
		{
			return null;
		}

		// Token: 0x060204F6 RID: 132342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204F6")]
		[Address(RVA = "0x1A6D160", Offset = "0x1A6BD60", VA = "0x181A6D160")]
		public static Sprite LoadZoneScopeSprite(ILoadAsset loader, string topicId, string zoneId, bool isLeft)
		{
			return null;
		}

		// Token: 0x060204F7 RID: 132343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204F7")]
		[Address(RVA = "0x1A6D0B0", Offset = "0x1A6BCB0", VA = "0x181A6D0B0")]
		public static Sprite LoadZoneLabelSprite(ILoadAsset loader, string topicId, string zoneId)
		{
			return null;
		}

		// Token: 0x060204F8 RID: 132344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204F8")]
		[Address(RVA = "0x1A6CF60", Offset = "0x1A6BB60", VA = "0x181A6CF60")]
		public static Sprite LoadZoneBgSprite(ILoadAsset loader, string topicId, string zoneId)
		{
			return null;
		}

		// Token: 0x060204F9 RID: 132345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204F9")]
		[Address(RVA = "0x1A6CD30", Offset = "0x1A6B930", VA = "0x181A6CD30")]
		public static RoguelikeMapBossIconHolder LoadRL05EndingDialogBossIconHolder(ILoadAsset loader, string topicId)
		{
			return null;
		}

		// Token: 0x0402BBB1 RID: 179121
		[Token(Token = "0x402BBB1")]
		private const string ZONE_SCOPE_LEFT_FORMAT = "scope_left_{0}";

		// Token: 0x0402BBB2 RID: 179122
		[Token(Token = "0x402BBB2")]
		private const string ZONE_SCOPE_RIGHT_FORMAT = "scope_right_{0}";

		// Token: 0x0402BBB3 RID: 179123
		[Token(Token = "0x402BBB3")]
		private const string ZONE_LABEL_FORMAT = "label_{0}";

		// Token: 0x0402BBB4 RID: 179124
		[Token(Token = "0x402BBB4")]
		private const string ZONE_BG_FORMAT = "bg_{0}";

		// Token: 0x0402BBB5 RID: 179125
		[Token(Token = "0x402BBB5")]
		public const string WRATH_COMMON_ICON_BG = "wrath_icon_bg";

		// Token: 0x0402BBB6 RID: 179126
		[Token(Token = "0x402BBB6")]
		public const string WRATH_HIDDEN_ICON_BG = "wrath_icon_bg_hidden";

		// Token: 0x0402BBB7 RID: 179127
		[Token(Token = "0x402BBB7")]
		public const string WRATH_COMMON_LONG_BG = "wrath_long_bg";

		// Token: 0x0402BBB8 RID: 179128
		[Token(Token = "0x402BBB8")]
		public const string WRATH_HIDDEN_LONG_BG = "wrath_long_bg_hidden";

		// Token: 0x0402BBB9 RID: 179129
		[Token(Token = "0x402BBB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCommonCopperItemWithFrameView;

		// Token: 0x0402BBBA RID: 179130
		[Token(Token = "0x402BBBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromAutoPackHub;

		// Token: 0x0402BBBB RID: 179131
		[Token(Token = "0x402BBBB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadPrefabByPath;

		// Token: 0x0402BBBC RID: 179132
		[Token(Token = "0x402BBBC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerRL05CommonToast;

		// Token: 0x0402BBBD RID: 179133
		[Token(Token = "0x402BBBD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerRL05CandleToast;

		// Token: 0x0402BBBE RID: 179134
		[Token(Token = "0x402BBBE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromMiscHub;

		// Token: 0x0402BBBF RID: 179135
		[Token(Token = "0x402BBBF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadZoneIconSprite;

		// Token: 0x0402BBC0 RID: 179136
		[Token(Token = "0x402BBC0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadWrathIconSprite;

		// Token: 0x0402BBC1 RID: 179137
		[Token(Token = "0x402BBC1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadZoneScopeSprite;

		// Token: 0x0402BBC2 RID: 179138
		[Token(Token = "0x402BBC2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadZoneLabelSprite;

		// Token: 0x0402BBC3 RID: 179139
		[Token(Token = "0x402BBC3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadZoneBgSprite;

		// Token: 0x0402BBC4 RID: 179140
		[Token(Token = "0x402BBC4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadRL05EndingDialogBossIconHolder;
	}
}
