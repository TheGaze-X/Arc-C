using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A50 RID: 27216
	[Token(Token = "0x2006A50")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MixStoryUtil
	{
		// Token: 0x06026E5C RID: 159324 RVA: 0x000CC9D8 File Offset: 0x000CABD8
		[Token(Token = "0x6026E5C")]
		[Address(RVA = "0x21FC520", Offset = "0x21FB120", VA = "0x1821FC520")]
		public static int GetCurrentRetroCoinMax()
		{
			return 0;
		}

		// Token: 0x06026E5D RID: 159325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E5D")]
		[Address(RVA = "0x21FC1F0", Offset = "0x21FADF0", VA = "0x1821FC1F0")]
		public static void CheckLocationPresentedAndUnlocked(StorylineLocationData location, out bool presented, out bool unlocked)
		{
		}

		// Token: 0x06026E5E RID: 159326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E5E")]
		[Address(RVA = "0x21FC340", Offset = "0x21FAF40", VA = "0x1821FC340")]
		public static void CheckStorySetPresentedAndBlocked(StorylineStorySetData storySet, out bool presented, out bool blocked)
		{
		}

		// Token: 0x06026E5F RID: 159327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E5F")]
		[Address(RVA = "0x21FC730", Offset = "0x21FB330", VA = "0x1821FC730")]
		public static string GetTitleIconIdByRetroId(string retroId)
		{
			return null;
		}

		// Token: 0x06026E60 RID: 159328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E60")]
		[Address(RVA = "0x21FC920", Offset = "0x21FB520", VA = "0x1821FC920")]
		public static Sprite LoadMainlineZoneSpriteByZoneId(string zoneId)
		{
			return null;
		}

		// Token: 0x06026E61 RID: 159329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E61")]
		[Address(RVA = "0x21FCE70", Offset = "0x21FBA70", VA = "0x1821FCE70")]
		public static Sprite LoadMixStoryArtSprite(ILoadAsset iLoadAsset, MixStoryUtil.MixStoryArtSpriteType spriteType, string iconId)
		{
			return null;
		}

		// Token: 0x06026E62 RID: 159330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E62")]
		[Address(RVA = "0x21FCBB0", Offset = "0x21FB7B0", VA = "0x1821FCBB0")]
		public static string LoadMixStoryArtSpritePath(ILoadAsset iLoadAsset, MixStoryUtil.MixStoryArtSpriteType spriteType, string iconId)
		{
			return null;
		}

		// Token: 0x06026E63 RID: 159331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E63")]
		[Address(RVA = "0x21FD050", Offset = "0x21FBC50", VA = "0x1821FD050")]
		private static string _GetTargetHubPathBySpriteType(MixStoryUtil.MixStoryArtSpriteType spriteType)
		{
			return null;
		}

		// Token: 0x0403701F RID: 225311
		[Token(Token = "0x403701F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCurrentRetroCoinMax;

		// Token: 0x04037020 RID: 225312
		[Token(Token = "0x4037020")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckLocationPresentedAndUnlocked;

		// Token: 0x04037021 RID: 225313
		[Token(Token = "0x4037021")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckStorySetPresentedAndBlocked;

		// Token: 0x04037022 RID: 225314
		[Token(Token = "0x4037022")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTitleIconIdByRetroId;

		// Token: 0x04037023 RID: 225315
		[Token(Token = "0x4037023")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadMainlineZoneSpriteByZoneId;

		// Token: 0x04037024 RID: 225316
		[Token(Token = "0x4037024")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadMixStoryArtSprite;

		// Token: 0x04037025 RID: 225317
		[Token(Token = "0x4037025")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadMixStoryArtSpritePath;

		// Token: 0x04037026 RID: 225318
		[Token(Token = "0x4037026")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetTargetHubPathBySpriteType;

		// Token: 0x02006A51 RID: 27217
		[Token(Token = "0x2006A51")]
		public enum MixStoryArtSpriteType
		{
			// Token: 0x04037028 RID: 225320
			[Token(Token = "0x4037028")]
			NONE,
			// Token: 0x04037029 RID: 225321
			[Token(Token = "0x4037029")]
			ABBR,
			// Token: 0x0403702A RID: 225322
			[Token(Token = "0x403702A")]
			BACKGROUND,
			// Token: 0x0403702B RID: 225323
			[Token(Token = "0x403702B")]
			DECO,
			// Token: 0x0403702C RID: 225324
			[Token(Token = "0x403702C")]
			KV,
			// Token: 0x0403702D RID: 225325
			[Token(Token = "0x403702D")]
			BRIEF_BKG,
			// Token: 0x0403702E RID: 225326
			[Token(Token = "0x403702E")]
			SPLIT,
			// Token: 0x0403702F RID: 225327
			[Token(Token = "0x403702F")]
			TITLE,
			// Token: 0x04037030 RID: 225328
			[Token(Token = "0x4037030")]
			LOGO
		}
	}
}
