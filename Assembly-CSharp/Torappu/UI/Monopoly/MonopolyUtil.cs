using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004834 RID: 18484
	[Token(Token = "0x2004834")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MonopolyUtil
	{
		// Token: 0x0601BECF RID: 114383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BECF")]
		[Address(RVA = "0x155D6B0", Offset = "0x155C2B0", VA = "0x18155D6B0")]
		public static Act46SideData GetActData(string actId)
		{
			return null;
		}

		// Token: 0x0601BED0 RID: 114384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BED0")]
		[Address(RVA = "0x155D8C0", Offset = "0x155C4C0", VA = "0x18155D8C0")]
		public static Act46SideData.Act46SideMonopolyStageData GetMonopolyStageData(string actId, string stageId)
		{
			return null;
		}

		// Token: 0x0601BED1 RID: 114385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BED1")]
		[Address(RVA = "0x155DBC0", Offset = "0x155C7C0", VA = "0x18155DBC0")]
		public static PlayerActivity.PlayerAct46SideActivity GetPlayerActData(string actId)
		{
			return null;
		}

		// Token: 0x0601BED2 RID: 114386 RVA: 0x000A6A58 File Offset: 0x000A4C58
		[Token(Token = "0x601BED2")]
		[Address(RVA = "0x155DF00", Offset = "0x155CB00", VA = "0x18155DF00")]
		public static bool IsPlayerInMonopolyGame(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601BED3 RID: 114387 RVA: 0x000A6A70 File Offset: 0x000A4C70
		[Token(Token = "0x601BED3")]
		[Address(RVA = "0x155DDB0", Offset = "0x155C9B0", VA = "0x18155DDB0")]
		public static bool IsMonopolyScoreExcellent(string actId, int currScore, int targetScore)
		{
			return default(bool);
		}

		// Token: 0x0601BED4 RID: 114388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BED4")]
		[Address(RVA = "0x155DD40", Offset = "0x155C940", VA = "0x18155DD40")]
		public static PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyGame GetPlayerMonopolyGameData(string actId)
		{
			return null;
		}

		// Token: 0x0601BED5 RID: 114389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BED5")]
		[Address(RVA = "0x155E010", Offset = "0x155CC10", VA = "0x18155E010")]
		public static Sprite LoadCardPointIconSprite(int cardPoint, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601BED6 RID: 114390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BED6")]
		[Address(RVA = "0x155EA00", Offset = "0x155D600", VA = "0x18155EA00")]
		public static Sprite LoadResourceIconSprite(string resourceId, ILoadAsset assetLoader, bool useWhite)
		{
			return null;
		}

		// Token: 0x0601BED7 RID: 114391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BED7")]
		[Address(RVA = "0x155DF80", Offset = "0x155CB80", VA = "0x18155DF80")]
		public static Sprite LoadBuffIconSprite(string buffIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601BED8 RID: 114392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BED8")]
		[Address(RVA = "0x155EAF0", Offset = "0x155D6F0", VA = "0x18155EAF0")]
		public static Sprite LoadSettleCharAvatarSprite(string settleCharAvatarId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601BED9 RID: 114393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BED9")]
		[Address(RVA = "0x155E860", Offset = "0x155D460", VA = "0x18155E860")]
		public static MonopolyMapNodeView LoadMonopolyMapNodePrefab(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601BEDA RID: 114394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEDA")]
		[Address(RVA = "0x155E6C0", Offset = "0x155D2C0", VA = "0x18155E6C0")]
		public static MonopolyMapNodeImageLayerView LoadMonopolyMapNodeImageLayerPrefab(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601BEDB RID: 114395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEDB")]
		[Address(RVA = "0x155E0E0", Offset = "0x155CCE0", VA = "0x18155E0E0")]
		public static MonopolyMapLineView LoadMonopolyMapLinePrefab(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601BEDC RID: 114396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEDC")]
		[Address(RVA = "0x155E280", Offset = "0x155CE80", VA = "0x18155E280")]
		public static MonopolyMapNodeContainer LoadMonopolyMapNodeContainerPrefab(string mapId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601BEDD RID: 114397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEDD")]
		[Address(RVA = "0x155D810", Offset = "0x155C410", VA = "0x18155D810")]
		public static string GetMapNodeIconId(string resourceId, int styleIndex)
		{
			return null;
		}

		// Token: 0x0601BEDE RID: 114398 RVA: 0x000A6A88 File Offset: 0x000A4C88
		[Token(Token = "0x601BEDE")]
		[Address(RVA = "0x155D440", Offset = "0x155C040", VA = "0x18155D440")]
		public static bool CheckHasStageNew(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601BEDF RID: 114399 RVA: 0x000A6AA0 File Offset: 0x000A4CA0
		[Token(Token = "0x601BEDF")]
		[Address(RVA = "0x155E420", Offset = "0x155D020", VA = "0x18155E420")]
		public static SpriteRenderData LoadMonopolyMapNodeIconSprite(string iconId, ILoadAsset assetLoader)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601BEE0 RID: 114400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEE0")]
		[Address(RVA = "0x155EB80", Offset = "0x155D780", VA = "0x18155EB80")]
		public static void TextToast(string toastText)
		{
		}

		// Token: 0x04024686 RID: 149126
		[Token(Token = "0x4024686")]
		private const string CARD_POINT_ICON_SPRITE_FORMAT = "num_icon_{0}";

		// Token: 0x04024687 RID: 149127
		[Token(Token = "0x4024687")]
		private const string RESOURCE_ICON_SPRITE_FORMAT = "resource_{0}";

		// Token: 0x04024688 RID: 149128
		[Token(Token = "0x4024688")]
		private const string RESOURCE_ICON_WHITE_SPRITE_FORMAT = "resource_{0}_white";

		// Token: 0x04024689 RID: 149129
		[Token(Token = "0x4024689")]
		private const string MAP_NODE_ICON_SPRITE_FORMAT = "map_node_{0}_{1}";

		// Token: 0x0402468A RID: 149130
		[Token(Token = "0x402468A")]
		public const float COMMON_TWEEN_INTERVAL = 0.5f;

		// Token: 0x0402468B RID: 149131
		[Token(Token = "0x402468B")]
		public const float CARD_FADE_OUT_DURATION = 0.6f;

		// Token: 0x0402468C RID: 149132
		[Token(Token = "0x402468C")]
		public const float MISSION_COMBO_TIP_DURATION = 0.6166667f;

		// Token: 0x0402468D RID: 149133
		[Token(Token = "0x402468D")]
		public const float MISSION_PROGRESS_INCREASE_DURATION = 0.3f;

		// Token: 0x0402468E RID: 149134
		[Token(Token = "0x402468E")]
		public const float MISSION_HIDE_ANIM_DURATION = 0.8666667f;

		// Token: 0x0402468F RID: 149135
		[Token(Token = "0x402468F")]
		public const float MISSION_COMPLETE_ANIM_DURATION = 1.3166667f;

		// Token: 0x04024690 RID: 149136
		[Token(Token = "0x4024690")]
		public const float SCORE_RANK_UP_1_ANIM_DURATION = 1.8333334f;

		// Token: 0x04024691 RID: 149137
		[Token(Token = "0x4024691")]
		public const float SCORE_RANK_UP_2_ANIM_DURATION = 1.8333334f;

		// Token: 0x04024692 RID: 149138
		[Token(Token = "0x4024692")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActData;

		// Token: 0x04024693 RID: 149139
		[Token(Token = "0x4024693")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMonopolyStageData;

		// Token: 0x04024694 RID: 149140
		[Token(Token = "0x4024694")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPlayerActData;

		// Token: 0x04024695 RID: 149141
		[Token(Token = "0x4024695")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsPlayerInMonopolyGame;

		// Token: 0x04024696 RID: 149142
		[Token(Token = "0x4024696")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsMonopolyScoreExcellent;

		// Token: 0x04024697 RID: 149143
		[Token(Token = "0x4024697")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlayerMonopolyGameData;

		// Token: 0x04024698 RID: 149144
		[Token(Token = "0x4024698")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadCardPointIconSprite;

		// Token: 0x04024699 RID: 149145
		[Token(Token = "0x4024699")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadResourceIconSprite;

		// Token: 0x0402469A RID: 149146
		[Token(Token = "0x402469A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadBuffIconSprite;

		// Token: 0x0402469B RID: 149147
		[Token(Token = "0x402469B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadSettleCharAvatarSprite;

		// Token: 0x0402469C RID: 149148
		[Token(Token = "0x402469C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadMonopolyMapNodePrefab;

		// Token: 0x0402469D RID: 149149
		[Token(Token = "0x402469D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadMonopolyMapNodeImageLayerPrefab;

		// Token: 0x0402469E RID: 149150
		[Token(Token = "0x402469E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadMonopolyMapLinePrefab;

		// Token: 0x0402469F RID: 149151
		[Token(Token = "0x402469F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadMonopolyMapNodeContainerPrefab;

		// Token: 0x040246A0 RID: 149152
		[Token(Token = "0x40246A0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetMapNodeIconId;

		// Token: 0x040246A1 RID: 149153
		[Token(Token = "0x40246A1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckHasStageNew;

		// Token: 0x040246A2 RID: 149154
		[Token(Token = "0x40246A2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadMonopolyMapNodeIconSprite;

		// Token: 0x040246A3 RID: 149155
		[Token(Token = "0x40246A3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TextToast;
	}
}
