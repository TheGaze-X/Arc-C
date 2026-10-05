using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006518 RID: 25880
	[Token(Token = "0x2006518")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ArtMagazineUtils
	{
		// Token: 0x060252F8 RID: 152312 RVA: 0x000C6E28 File Offset: 0x000C5028
		[Token(Token = "0x60252F8")]
		[Address(RVA = "0x203E890", Offset = "0x203D490", VA = "0x18203E890")]
		public static bool TryCalculateIllustSizeBound(UICharacterIllust illustView, out float normalizedSizeMin, out float normalizedSizeMax)
		{
			return default(bool);
		}

		// Token: 0x060252F9 RID: 152313 RVA: 0x000C6E40 File Offset: 0x000C5040
		[Token(Token = "0x60252F9")]
		[Address(RVA = "0x203C6A0", Offset = "0x203B2A0", VA = "0x18203C6A0")]
		public static float ClampIllustNormalizedSize(UICharacterIllust illustView, float normalizedSize)
		{
			return 0f;
		}

		// Token: 0x060252FA RID: 152314 RVA: 0x000C6E58 File Offset: 0x000C5058
		[Token(Token = "0x60252FA")]
		[Address(RVA = "0x203CB60", Offset = "0x203B760", VA = "0x18203CB60")]
		public static float GetIllustDftNormalizedSize(UICharacterIllust illustView)
		{
			return 0f;
		}

		// Token: 0x060252FB RID: 152315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60252FB")]
		[Address(RVA = "0x203CCD0", Offset = "0x203B8D0", VA = "0x18203CCD0")]
		public static MagazineLeafItemData GetLeafData(string leafId)
		{
			return null;
		}

		// Token: 0x060252FC RID: 152316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60252FC")]
		[Address(RVA = "0x203CE90", Offset = "0x203BA90", VA = "0x18203CE90")]
		public static MagazineLeafTypeData GetLeafTypeData(MagazineLeafType leafType)
		{
			return null;
		}

		// Token: 0x060252FD RID: 152317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60252FD")]
		[Address(RVA = "0x203D070", Offset = "0x203BC70", VA = "0x18203D070")]
		public static PlayerArtMagazineLeafData GetPlayerLeafData(string leafId)
		{
			return null;
		}

		// Token: 0x060252FE RID: 152318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60252FE")]
		[Address(RVA = "0x203D1F0", Offset = "0x203BDF0", VA = "0x18203D1F0")]
		public static StickerItemData GetStickerData(string stickerId)
		{
			return null;
		}

		// Token: 0x060252FF RID: 152319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60252FF")]
		[Address(RVA = "0x203CA10", Offset = "0x203B610", VA = "0x18203CA10")]
		public static string GetDecorIconByType(ItemType type, bool isSmall)
		{
			return null;
		}

		// Token: 0x06025300 RID: 152320 RVA: 0x000C6E70 File Offset: 0x000C5070
		[Token(Token = "0x6025300")]
		[Address(RVA = "0x203CDC0", Offset = "0x203B9C0", VA = "0x18203CDC0")]
		public static int GetLeafInMagazineSquadIndex(string leafId)
		{
			return 0;
		}

		// Token: 0x06025301 RID: 152321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025301")]
		[Address(RVA = "0x203CFB0", Offset = "0x203BBB0", VA = "0x18203CFB0")]
		public static string GetMagazineSquadLeafId(int index)
		{
			return null;
		}

		// Token: 0x06025302 RID: 152322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025302")]
		[Address(RVA = "0x203DCD0", Offset = "0x203C8D0", VA = "0x18203DCD0")]
		public static Sprite LoadDecorIconFromHub(string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06025303 RID: 152323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025303")]
		[Address(RVA = "0x203DE60", Offset = "0x203CA60", VA = "0x18203DE60")]
		public static Sprite LoadLeafDefaultThumbnailFromHub(string leafId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06025304 RID: 152324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025304")]
		[Address(RVA = "0x203DEF0", Offset = "0x203CAF0", VA = "0x18203DEF0")]
		public static Sprite LoadLeafElementSprite(string itemId, ItemType itemType, int tmplId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06025305 RID: 152325 RVA: 0x000C6E88 File Offset: 0x000C5088
		[Token(Token = "0x6025305")]
		[Address(RVA = "0x203D140", Offset = "0x203BD40", VA = "0x18203D140")]
		public static ItemType GetRelateItemTypeByDecorTabType(ArtMagazineDiyDecorTabType tabType)
		{
			return ItemType.NONE;
		}

		// Token: 0x06025306 RID: 152326 RVA: 0x000C6EA0 File Offset: 0x000C50A0
		[Token(Token = "0x6025306")]
		[Address(RVA = "0x203D550", Offset = "0x203C150", VA = "0x18203D550")]
		public static bool HasMagazineFirstRewardCanClaim()
		{
			return default(bool);
		}

		// Token: 0x06025307 RID: 152327 RVA: 0x000C6EB8 File Offset: 0x000C50B8
		[Token(Token = "0x6025307")]
		[Address(RVA = "0x203D2E0", Offset = "0x203BEE0", VA = "0x18203D2E0")]
		public static int GetTotalTemplateCount(string itemId, ItemType itemType)
		{
			return 0;
		}

		// Token: 0x06025308 RID: 152328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025308")]
		[Address(RVA = "0x203DD60", Offset = "0x203C960", VA = "0x18203DD60")]
		public static Sprite LoadHomeBackgroundPic(string spriteId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06025309 RID: 152329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025309")]
		[Address(RVA = "0x203DDE0", Offset = "0x203C9E0", VA = "0x18203DDE0")]
		public static Sprite LoadHomeThemePic(string spriteId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602530A RID: 152330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602530A")]
		[Address(RVA = "0x203E540", Offset = "0x203D140", VA = "0x18203E540")]
		public static Sprite LoadNameCardSkinShortBgPic(string skinId, int skinTmpl, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602530B RID: 152331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602530B")]
		[Address(RVA = "0x203E650", Offset = "0x203D250", VA = "0x18203E650")]
		public static Sprite LoadPlayerAvatarPic(string spriteId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602530C RID: 152332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602530C")]
		[Address(RVA = "0x203E6D0", Offset = "0x203D2D0", VA = "0x18203E6D0")]
		public static Sprite LoadStickerPic(string spriteId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602530D RID: 152333 RVA: 0x000C6ED0 File Offset: 0x000C50D0
		[Token(Token = "0x602530D")]
		[Address(RVA = "0x203D8E0", Offset = "0x203C4E0", VA = "0x18203D8E0")]
		public static bool IsLeafDataSimilar(ArtMagazineLeafData a, ArtMagazineLeafData b)
		{
			return default(bool);
		}

		// Token: 0x0602530E RID: 152334 RVA: 0x000C6EE8 File Offset: 0x000C50E8
		[Token(Token = "0x602530E")]
		[Address(RVA = "0x203DAA0", Offset = "0x203C6A0", VA = "0x18203DAA0")]
		public static bool IsLeafElemDataSimilar(ArtMagazineLeafElementData a, ArtMagazineLeafElementData b)
		{
			return default(bool);
		}

		// Token: 0x0602530F RID: 152335 RVA: 0x000C6F00 File Offset: 0x000C5100
		[Token(Token = "0x602530F")]
		[Address(RVA = "0x203D5F0", Offset = "0x203C1F0", VA = "0x18203D5F0")]
		public static bool IfLeafHasTimeValidPreset(string leafId)
		{
			return default(bool);
		}

		// Token: 0x06025310 RID: 152336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025310")]
		[Address(RVA = "0x203E440", Offset = "0x203D040", VA = "0x18203E440")]
		public static Sprite LoadLeafTypeIcon(string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06025311 RID: 152337 RVA: 0x000C6F18 File Offset: 0x000C5118
		[Token(Token = "0x6025311")]
		[Address(RVA = "0x203D780", Offset = "0x203C380", VA = "0x18203D780")]
		public static bool IsBannedInDiy(string itemId, ItemType itemType)
		{
			return default(bool);
		}

		// Token: 0x06025312 RID: 152338 RVA: 0x000C6F30 File Offset: 0x000C5130
		[Token(Token = "0x6025312")]
		[Address(RVA = "0x203EB50", Offset = "0x203D750", VA = "0x18203EB50")]
		public static bool TryGetLeafTemplateData(string leafId, out ArtMagazineLeafData ret)
		{
			return default(bool);
		}

		// Token: 0x06025313 RID: 152339 RVA: 0x000C6F48 File Offset: 0x000C5148
		[Token(Token = "0x6025313")]
		[Address(RVA = "0x203EDA0", Offset = "0x203D9A0", VA = "0x18203EDA0")]
		private static int _GetHomeThemeTotalTemplateCount(string itemId)
		{
			return 0;
		}

		// Token: 0x06025314 RID: 152340 RVA: 0x000C6F60 File Offset: 0x000C5160
		[Token(Token = "0x6025314")]
		[Address(RVA = "0x203ECF0", Offset = "0x203D8F0", VA = "0x18203ECF0")]
		private static int _GetHomeBackgroundTotalTemplateCount(string itemId)
		{
			return 0;
		}

		// Token: 0x06025315 RID: 152341 RVA: 0x000C6F78 File Offset: 0x000C5178
		[Token(Token = "0x6025315")]
		[Address(RVA = "0x203EE50", Offset = "0x203DA50", VA = "0x18203EE50")]
		private static int _GetNameCardTotalTemplateCount(string itemId)
		{
			return 0;
		}

		// Token: 0x06025316 RID: 152342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025316")]
		[Address(RVA = "0x203F050", Offset = "0x203DC50", VA = "0x18203F050")]
		private static Sprite _LoadLeafElementHomeThemeSprite(string itemId, int tmplId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06025317 RID: 152343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025317")]
		[Address(RVA = "0x203EEF0", Offset = "0x203DAF0", VA = "0x18203EEF0")]
		private static Sprite _LoadLeafElementHomeBackgroundSprite(string itemId, int tmplId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06025318 RID: 152344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025318")]
		[Address(RVA = "0x203F1B0", Offset = "0x203DDB0", VA = "0x18203F1B0")]
		private static Sprite _LoadLeafElementNameCardSprite(string itemId, int tmplId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06025319 RID: 152345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025319")]
		[Address(RVA = "0x203F320", Offset = "0x203DF20", VA = "0x18203F320")]
		private static Sprite _LoadLeafElementPlayerAvatarSprite(string itemId, int tmplId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602531A RID: 152346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602531A")]
		[Address(RVA = "0x203F460", Offset = "0x203E060", VA = "0x18203F460")]
		private static Sprite _LoadLeafElementStickerSprite(string itemId, int tmplId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602531B RID: 152347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602531B")]
		[Address(RVA = "0x203F5B0", Offset = "0x203E1B0", VA = "0x18203F5B0")]
		private static Sprite _LoadSpriteFromAutoPackSpriteHub(string spriteId, string hubPath, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602531C RID: 152348 RVA: 0x000C6F90 File Offset: 0x000C5190
		[Token(Token = "0x602531C")]
		[Address(RVA = "0x203C560", Offset = "0x203B160", VA = "0x18203C560")]
		public static bool CheckLeafNewGetTrack(string leafId)
		{
			return default(bool);
		}

		// Token: 0x0602531D RID: 152349 RVA: 0x000C6FA8 File Offset: 0x000C51A8
		[Token(Token = "0x602531D")]
		[Address(RVA = "0x203C440", Offset = "0x203B040", VA = "0x18203C440")]
		public static bool CheckAllLeafNewGetTrack()
		{
			return default(bool);
		}

		// Token: 0x0602531E RID: 152350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602531E")]
		[Address(RVA = "0x203C8D0", Offset = "0x203B4D0", VA = "0x18203C8D0")]
		public static void ConsumeLeafNewGetTrack(string leafId)
		{
		}

		// Token: 0x0602531F RID: 152351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602531F")]
		[Address(RVA = "0x203C7B0", Offset = "0x203B3B0", VA = "0x18203C7B0")]
		public static void ConsumeAllLeafNewGetTrack()
		{
		}

		// Token: 0x06025320 RID: 152352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025320")]
		[Address(RVA = "0x203E750", Offset = "0x203D350", VA = "0x18203E750")]
		public static void RecordLeafNewGetTrack(string leafId)
		{
		}

		// Token: 0x06025321 RID: 152353 RVA: 0x000C6FC0 File Offset: 0x000C51C0
		[Token(Token = "0x6025321")]
		[Address(RVA = "0x203C600", Offset = "0x203B200", VA = "0x18203C600")]
		public static bool CheckStickerNewGetTrack(string stickerId)
		{
			return default(bool);
		}

		// Token: 0x06025322 RID: 152354 RVA: 0x000C6FD8 File Offset: 0x000C51D8
		[Token(Token = "0x6025322")]
		[Address(RVA = "0x203C4D0", Offset = "0x203B0D0", VA = "0x18203C4D0")]
		public static bool CheckAllStickerNewGetTrack()
		{
			return default(bool);
		}

		// Token: 0x06025323 RID: 152355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025323")]
		[Address(RVA = "0x203C970", Offset = "0x203B570", VA = "0x18203C970")]
		public static void ConsumeStickerNewGetTrack(string stickerId)
		{
		}

		// Token: 0x06025324 RID: 152356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025324")]
		[Address(RVA = "0x203C840", Offset = "0x203B440", VA = "0x18203C840")]
		public static void ConsumeAllStickerNewGetTrack()
		{
		}

		// Token: 0x06025325 RID: 152357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025325")]
		[Address(RVA = "0x203E7F0", Offset = "0x203D3F0", VA = "0x18203E7F0")]
		public static void RecordStickerNewGetTrack(string stickerId)
		{
		}

		// Token: 0x0403427D RID: 213629
		[Token(Token = "0x403427D")]
		private const string ART_MAGAZINE_NAME_CARD_ITEM_FORMAT = "{0}_{1}";

		// Token: 0x0403427E RID: 213630
		[Token(Token = "0x403427E")]
		public const int SKIN_MAX_SELECT_NUM = 1;

		// Token: 0x0403427F RID: 213631
		[Token(Token = "0x403427F")]
		private const float ART_MAGAZINE_ILLUST_MIN_SIZE = 630f;

		// Token: 0x04034280 RID: 213632
		[Token(Token = "0x4034280")]
		public const float ART_MAGAZINE_ILLUST_NORMALIZE_UNIT = 1024f;

		// Token: 0x04034281 RID: 213633
		[Token(Token = "0x4034281")]
		public const float ART_MAGAZINE_LEAF_HEIGHT = 720f;

		// Token: 0x04034282 RID: 213634
		[Token(Token = "0x4034282")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryCalculateIllustSizeBound;

		// Token: 0x04034283 RID: 213635
		[Token(Token = "0x4034283")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClampIllustNormalizedSize;

		// Token: 0x04034284 RID: 213636
		[Token(Token = "0x4034284")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetIllustDftNormalizedSize;

		// Token: 0x04034285 RID: 213637
		[Token(Token = "0x4034285")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetLeafData;

		// Token: 0x04034286 RID: 213638
		[Token(Token = "0x4034286")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLeafTypeData;

		// Token: 0x04034287 RID: 213639
		[Token(Token = "0x4034287")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlayerLeafData;

		// Token: 0x04034288 RID: 213640
		[Token(Token = "0x4034288")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetStickerData;

		// Token: 0x04034289 RID: 213641
		[Token(Token = "0x4034289")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDecorIconByType;

		// Token: 0x0403428A RID: 213642
		[Token(Token = "0x403428A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLeafInMagazineSquadIndex;

		// Token: 0x0403428B RID: 213643
		[Token(Token = "0x403428B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetMagazineSquadLeafId;

		// Token: 0x0403428C RID: 213644
		[Token(Token = "0x403428C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadDecorIconFromHub;

		// Token: 0x0403428D RID: 213645
		[Token(Token = "0x403428D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadLeafDefaultThumbnailFromHub;

		// Token: 0x0403428E RID: 213646
		[Token(Token = "0x403428E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadLeafElementSprite;

		// Token: 0x0403428F RID: 213647
		[Token(Token = "0x403428F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetRelateItemTypeByDecorTabType;

		// Token: 0x04034290 RID: 213648
		[Token(Token = "0x4034290")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HasMagazineFirstRewardCanClaim;

		// Token: 0x04034291 RID: 213649
		[Token(Token = "0x4034291")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetTotalTemplateCount;

		// Token: 0x04034292 RID: 213650
		[Token(Token = "0x4034292")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadHomeBackgroundPic;

		// Token: 0x04034293 RID: 213651
		[Token(Token = "0x4034293")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadHomeThemePic;

		// Token: 0x04034294 RID: 213652
		[Token(Token = "0x4034294")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadNameCardSkinShortBgPic;

		// Token: 0x04034295 RID: 213653
		[Token(Token = "0x4034295")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadPlayerAvatarPic;

		// Token: 0x04034296 RID: 213654
		[Token(Token = "0x4034296")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadStickerPic;

		// Token: 0x04034297 RID: 213655
		[Token(Token = "0x4034297")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsLeafDataSimilar;

		// Token: 0x04034298 RID: 213656
		[Token(Token = "0x4034298")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_IsLeafElemDataSimilar;

		// Token: 0x04034299 RID: 213657
		[Token(Token = "0x4034299")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_IfLeafHasTimeValidPreset;

		// Token: 0x0403429A RID: 213658
		[Token(Token = "0x403429A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadLeafTypeIcon;

		// Token: 0x0403429B RID: 213659
		[Token(Token = "0x403429B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_IsBannedInDiy;

		// Token: 0x0403429C RID: 213660
		[Token(Token = "0x403429C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TryGetLeafTemplateData;

		// Token: 0x0403429D RID: 213661
		[Token(Token = "0x403429D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetHomeThemeTotalTemplateCount;

		// Token: 0x0403429E RID: 213662
		[Token(Token = "0x403429E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__GetHomeBackgroundTotalTemplateCount;

		// Token: 0x0403429F RID: 213663
		[Token(Token = "0x403429F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetNameCardTotalTemplateCount;

		// Token: 0x040342A0 RID: 213664
		[Token(Token = "0x40342A0")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__LoadLeafElementHomeThemeSprite;

		// Token: 0x040342A1 RID: 213665
		[Token(Token = "0x40342A1")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__LoadLeafElementHomeBackgroundSprite;

		// Token: 0x040342A2 RID: 213666
		[Token(Token = "0x40342A2")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__LoadLeafElementNameCardSprite;

		// Token: 0x040342A3 RID: 213667
		[Token(Token = "0x40342A3")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__LoadLeafElementPlayerAvatarSprite;

		// Token: 0x040342A4 RID: 213668
		[Token(Token = "0x40342A4")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__LoadLeafElementStickerSprite;

		// Token: 0x040342A5 RID: 213669
		[Token(Token = "0x40342A5")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromAutoPackSpriteHub;

		// Token: 0x040342A6 RID: 213670
		[Token(Token = "0x40342A6")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckLeafNewGetTrack;

		// Token: 0x040342A7 RID: 213671
		[Token(Token = "0x40342A7")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckAllLeafNewGetTrack;

		// Token: 0x040342A8 RID: 213672
		[Token(Token = "0x40342A8")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_ConsumeLeafNewGetTrack;

		// Token: 0x040342A9 RID: 213673
		[Token(Token = "0x40342A9")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_ConsumeAllLeafNewGetTrack;

		// Token: 0x040342AA RID: 213674
		[Token(Token = "0x40342AA")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_RecordLeafNewGetTrack;

		// Token: 0x040342AB RID: 213675
		[Token(Token = "0x40342AB")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CheckStickerNewGetTrack;

		// Token: 0x040342AC RID: 213676
		[Token(Token = "0x40342AC")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_CheckAllStickerNewGetTrack;

		// Token: 0x040342AD RID: 213677
		[Token(Token = "0x40342AD")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_ConsumeStickerNewGetTrack;

		// Token: 0x040342AE RID: 213678
		[Token(Token = "0x40342AE")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_ConsumeAllStickerNewGetTrack;

		// Token: 0x040342AF RID: 213679
		[Token(Token = "0x40342AF")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_RecordStickerNewGetTrack;
	}
}
