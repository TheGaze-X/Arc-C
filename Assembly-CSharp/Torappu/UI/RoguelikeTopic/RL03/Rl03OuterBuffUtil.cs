using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045E9 RID: 17897
	[Token(Token = "0x20045E9")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Rl03OuterBuffUtil
	{
		// Token: 0x0601B347 RID: 111431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B347")]
		[Address(RVA = "0x146BA50", Offset = "0x146A650", VA = "0x18146BA50")]
		public static Sprite LoadOuterBuffIcon(ILoadAsset loader, string iconId)
		{
			return null;
		}

		// Token: 0x0601B348 RID: 111432 RVA: 0x000A49E8 File Offset: 0x000A2BE8
		[Token(Token = "0x601B348")]
		[Address(RVA = "0x146B980", Offset = "0x146A580", VA = "0x18146B980")]
		public static SpriteRenderData LoadDecoIcon(ILoadAsset loader, string topicId, string buffId)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601B349 RID: 111433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B349")]
		[Address(RVA = "0x146B8E0", Offset = "0x146A4E0", VA = "0x18146B8E0")]
		public static Sprite LoadBuffHightlightIcon(ILoadAsset loader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601B34A RID: 111434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B34A")]
		[Address(RVA = "0x146B800", Offset = "0x146A400", VA = "0x18146B800")]
		public static string GetDifficultyBuffSummaryDecoId(string nodeId)
		{
			return null;
		}

		// Token: 0x0601B34B RID: 111435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B34B")]
		[Address(RVA = "0x146B870", Offset = "0x146A470", VA = "0x18146B870")]
		public static string GetDiificultyBuffHightlightIconId(string nodeId)
		{
			return null;
		}

		// Token: 0x0601B34C RID: 111436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B34C")]
		[Address(RVA = "0x146BAD0", Offset = "0x146A6D0", VA = "0x18146BAD0")]
		public static ListDict<string, RoguelikeTopicDisplayItem> MergeOuterBuffDisplayItems(Dictionary<string, RoguelikeTopicDevToken> developmentTokens, List<RoguelikeTopicDisplayItem> items)
		{
			return null;
		}

		// Token: 0x0601B34D RID: 111437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B34D")]
		[Address(RVA = "0x146BF30", Offset = "0x146AB30", VA = "0x18146BF30")]
		private static Sprite _LoadAutoPackSprite(ILoadAsset loader, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601B34E RID: 111438 RVA: 0x000A4A00 File Offset: 0x000A2C00
		[Token(Token = "0x601B34E")]
		[Address(RVA = "0x146C2B0", Offset = "0x146AEB0", VA = "0x18146C2B0")]
		private static SpriteRenderData _LoadSpriteRenderData(ILoadAsset loader, string spriteId, string atlasPath)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x04023121 RID: 143649
		[Token(Token = "0x4023121")]
		private const string BUFF_SUMMARY_DECO_FORMAT = "{0}_deco";

		// Token: 0x04023122 RID: 143650
		[Token(Token = "0x4023122")]
		private const string BUFF_HIGH_LIGHT_FORMAT = "{0}_light";

		// Token: 0x04023123 RID: 143651
		[Token(Token = "0x4023123")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadOuterBuffIcon;

		// Token: 0x04023124 RID: 143652
		[Token(Token = "0x4023124")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDecoIcon;

		// Token: 0x04023125 RID: 143653
		[Token(Token = "0x4023125")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadBuffHightlightIcon;

		// Token: 0x04023126 RID: 143654
		[Token(Token = "0x4023126")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDifficultyBuffSummaryDecoId;

		// Token: 0x04023127 RID: 143655
		[Token(Token = "0x4023127")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDiificultyBuffHightlightIconId;

		// Token: 0x04023128 RID: 143656
		[Token(Token = "0x4023128")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MergeOuterBuffDisplayItems;

		// Token: 0x04023129 RID: 143657
		[Token(Token = "0x4023129")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x0402312A RID: 143658
		[Token(Token = "0x402312A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadSpriteRenderData;
	}
}
