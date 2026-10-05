using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200451D RID: 17693
	[Token(Token = "0x200451D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeCommonOuterBuffUtil
	{
		// Token: 0x0601AFA8 RID: 110504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AFA8")]
		[Address(RVA = "0x1424450", Offset = "0x1423050", VA = "0x181424450")]
		public static Sprite LoadOuterBuffIcon(ILoadAsset loader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601AFA9 RID: 110505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AFA9")]
		[Address(RVA = "0x1424310", Offset = "0x1422F10", VA = "0x181424310")]
		public static Sprite LoadOuterBuffDeco(ILoadAsset loader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601AFAA RID: 110506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AFAA")]
		[Address(RVA = "0x14243B0", Offset = "0x1422FB0", VA = "0x1814243B0")]
		public static Sprite LoadOuterBuffHighlightIcon(ILoadAsset loader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601AFAB RID: 110507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AFAB")]
		[Address(RVA = "0x14244F0", Offset = "0x14230F0", VA = "0x1814244F0")]
		public static ListDict<string, RoguelikeTopicDisplayItem> MergeOuterBuffDisplayItems(Dictionary<string, RoguelikeTopicDevToken> developmentTokens, List<RoguelikeTopicDisplayItem> items)
		{
			return null;
		}

		// Token: 0x0601AFAC RID: 110508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AFAC")]
		[Address(RVA = "0x1424950", Offset = "0x1423550", VA = "0x181424950")]
		private static Sprite _LoadAutoPackSprite(ILoadAsset loader, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x04022A47 RID: 141895
		[Token(Token = "0x4022A47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadOuterBuffIcon;

		// Token: 0x04022A48 RID: 141896
		[Token(Token = "0x4022A48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadOuterBuffDeco;

		// Token: 0x04022A49 RID: 141897
		[Token(Token = "0x4022A49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadOuterBuffHighlightIcon;

		// Token: 0x04022A4A RID: 141898
		[Token(Token = "0x4022A4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_MergeOuterBuffDisplayItems;

		// Token: 0x04022A4B RID: 141899
		[Token(Token = "0x4022A4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;
	}
}
