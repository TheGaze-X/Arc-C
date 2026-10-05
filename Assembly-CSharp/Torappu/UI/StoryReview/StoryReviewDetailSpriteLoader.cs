using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x0200490F RID: 18703
	[Token(Token = "0x200490F")]
	public class StoryReviewDetailSpriteLoader : PageAssetPool<Sprite>
	{
		// Token: 0x0601C33F RID: 115519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C33F")]
		[Address(RVA = "0x15B37B0", Offset = "0x15B23B0", VA = "0x1815B37B0")]
		public Sprite LoadSpriteFromHub(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601C340 RID: 115520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C340")]
		[Address(RVA = "0x15B3850", Offset = "0x15B2450", VA = "0x1815B3850")]
		private Sprite _LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601C341 RID: 115521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C341")]
		[Address(RVA = "0x15B3A90", Offset = "0x15B2690", VA = "0x1815B3A90")]
		private Sprite _LoadSpriteFromAutoPackHubByPage(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601C342 RID: 115522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C342")]
		[Address(RVA = "0x15B3BE0", Offset = "0x15B27E0", VA = "0x1815B3BE0")]
		public StoryReviewDetailSpriteLoader()
		{
		}

		// Token: 0x04024DFA RID: 151034
		[Token(Token = "0x4024DFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromHub;

		// Token: 0x04024DFB RID: 151035
		[Token(Token = "0x4024DFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x04024DFC RID: 151036
		[Token(Token = "0x4024DFC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromAutoPackHubByPage;

		// Token: 0x04024DFD RID: 151037
		[Token(Token = "0x4024DFD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
