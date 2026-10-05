using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065CE RID: 26062
	[Token(Token = "0x20065CE")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ArtGalleryUtils
	{
		// Token: 0x0602573D RID: 153405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602573D")]
		[Address(RVA = "0x2060340", Offset = "0x205EF40", VA = "0x182060340")]
		public static Sprite LoadCollectSetPic(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x0602573E RID: 153406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602573E")]
		[Address(RVA = "0x20604C0", Offset = "0x205F0C0", VA = "0x1820604C0")]
		public static Sprite LoadCollectTypePic(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x0602573F RID: 153407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602573F")]
		[Address(RVA = "0x20603C0", Offset = "0x205EFC0", VA = "0x1820603C0")]
		public static Sprite LoadCollectTypeFilterEnglishNamePic(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x06025740 RID: 153408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025740")]
		[Address(RVA = "0x2060440", Offset = "0x205F040", VA = "0x182060440")]
		public static Sprite LoadCollectTypeFilterIconPic(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x06025741 RID: 153409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025741")]
		[Address(RVA = "0x20605C0", Offset = "0x205F1C0", VA = "0x1820605C0")]
		public static Sprite LoadHomeThemePic(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x06025742 RID: 153410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025742")]
		[Address(RVA = "0x2060540", Offset = "0x205F140", VA = "0x182060540")]
		public static Sprite LoadHomeBackgroundPic(ILoadAsset iLoadAsset, string picId)
		{
			return null;
		}

		// Token: 0x06025743 RID: 153411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025743")]
		[Address(RVA = "0x2060D90", Offset = "0x205F990", VA = "0x182060D90")]
		private static Sprite _LoadSprite(ILoadAsset iLoadAsset, string picId, string hubPath)
		{
			return null;
		}

		// Token: 0x06025744 RID: 153412 RVA: 0x000C7F20 File Offset: 0x000C6120
		[Token(Token = "0x6025744")]
		[Address(RVA = "0x20602A0", Offset = "0x205EEA0", VA = "0x1820602A0")]
		public static ItemType GetItemTypeByTabType(ArtGalleryTabType tabType)
		{
			return ItemType.NONE;
		}

		// Token: 0x06025745 RID: 153413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025745")]
		[Address(RVA = "0x205F6D0", Offset = "0x205E2D0", VA = "0x18205F6D0")]
		public static ArtGalleryCollectData GetArtGalleryCollectData()
		{
			return null;
		}

		// Token: 0x06025746 RID: 153414 RVA: 0x000C7F38 File Offset: 0x000C6138
		[Token(Token = "0x6025746")]
		[Address(RVA = "0x2060070", Offset = "0x205EC70", VA = "0x182060070")]
		public static long GetItemStartTime(string itemId, ItemType itemType)
		{
			return 0L;
		}

		// Token: 0x06025747 RID: 153415 RVA: 0x000C7F50 File Offset: 0x000C6150
		[Token(Token = "0x6025747")]
		[Address(RVA = "0x205FBE0", Offset = "0x205E7E0", VA = "0x18205FBE0")]
		public static int GetCollectSetItemsGotCnt(ArtGalleryCollectSetData setData)
		{
			return 0;
		}

		// Token: 0x06025748 RID: 153416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025748")]
		[Address(RVA = "0x205F930", Offset = "0x205E530", VA = "0x18205F930")]
		public static List<string> GetCollectSetClaimedMissionIdList(ArtGalleryCollectSetData setData)
		{
			return null;
		}

		// Token: 0x06025749 RID: 153417 RVA: 0x000C7F68 File Offset: 0x000C6168
		[Token(Token = "0x6025749")]
		[Address(RVA = "0x205EF10", Offset = "0x205DB10", VA = "0x18205EF10")]
		public static bool CollectSetsMissionHasRewardsCanClaim()
		{
			return default(bool);
		}

		// Token: 0x0602574A RID: 153418 RVA: 0x000C7F80 File Offset: 0x000C6180
		[Token(Token = "0x602574A")]
		[Address(RVA = "0x205EEA0", Offset = "0x205DAA0", VA = "0x18205EEA0")]
		public static bool CollectSetMissionHasRewardsCanClaim(string setId)
		{
			return default(bool);
		}

		// Token: 0x0602574B RID: 153419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602574B")]
		[Address(RVA = "0x205ED00", Offset = "0x205D900", VA = "0x18205ED00")]
		public static void CollectSetConsumeNewTracksByType()
		{
		}

		// Token: 0x0602574C RID: 153420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602574C")]
		[Address(RVA = "0x205EC30", Offset = "0x205D830", VA = "0x18205EC30")]
		public static void CollectSetConsumeNewTrack(string setId)
		{
		}

		// Token: 0x0602574D RID: 153421 RVA: 0x000C7F98 File Offset: 0x000C6198
		[Token(Token = "0x602574D")]
		[Address(RVA = "0x205EDC0", Offset = "0x205D9C0", VA = "0x18205EDC0")]
		public static bool CollectSetHasNewTrack(string setId)
		{
			return default(bool);
		}

		// Token: 0x0602574E RID: 153422 RVA: 0x000C7FB0 File Offset: 0x000C61B0
		[Token(Token = "0x602574E")]
		[Address(RVA = "0x205FDE0", Offset = "0x205E9E0", VA = "0x18205FDE0")]
		public static ArtGalleryUtils.CollectSetMissionRewardsState GetCollectSetMissionRewardsState(string setId)
		{
			return ArtGalleryUtils.CollectSetMissionRewardsState.NONE;
		}

		// Token: 0x0602574F RID: 153423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602574F")]
		[Address(RVA = "0x205F7A0", Offset = "0x205E3A0", VA = "0x18205F7A0")]
		public static ArtGalleryCollectItemModelBase GetCollectItemModelByType(ItemType itemType)
		{
			return null;
		}

		// Token: 0x06025750 RID: 153424 RVA: 0x000C7FC8 File Offset: 0x000C61C8
		[Token(Token = "0x6025750")]
		[Address(RVA = "0x205EB60", Offset = "0x205D760", VA = "0x18205EB60")]
		public static bool CheckCollectHasNewTrack()
		{
			return default(bool);
		}

		// Token: 0x06025751 RID: 153425 RVA: 0x000C7FE0 File Offset: 0x000C61E0
		[Token(Token = "0x6025751")]
		[Address(RVA = "0x20607A0", Offset = "0x205F3A0", VA = "0x1820607A0")]
		private static ArtGalleryUtils.CollectSetMissionRewardsState _GetCollectSetNotClaimedMissionState(ArtGalleryCollectSetData setData, List<string> claimedMissionIdList)
		{
			return ArtGalleryUtils.CollectSetMissionRewardsState.NONE;
		}

		// Token: 0x06025752 RID: 153426 RVA: 0x000C7FF8 File Offset: 0x000C61F8
		[Token(Token = "0x6025752")]
		[Address(RVA = "0x205F0E0", Offset = "0x205DCE0", VA = "0x18205F0E0")]
		public static float CurrentPercent(ItemType itemType)
		{
			return 0f;
		}

		// Token: 0x06025753 RID: 153427 RVA: 0x000C8010 File Offset: 0x000C6210
		[Token(Token = "0x6025753")]
		[Address(RVA = "0x2060A70", Offset = "0x205F670", VA = "0x182060A70")]
		private static int _GetHomeThemePublicCount()
		{
			return 0;
		}

		// Token: 0x06025754 RID: 153428 RVA: 0x000C8028 File Offset: 0x000C6228
		[Token(Token = "0x6025754")]
		[Address(RVA = "0x2060910", Offset = "0x205F510", VA = "0x182060910")]
		private static int _GetHomeBackgroundPublicCount()
		{
			return 0;
		}

		// Token: 0x06025755 RID: 153429 RVA: 0x000C8040 File Offset: 0x000C6240
		[Token(Token = "0x6025755")]
		[Address(RVA = "0x2060640", Offset = "0x205F240", VA = "0x182060640")]
		private static int _GetAvatarPublicCount()
		{
			return 0;
		}

		// Token: 0x06025756 RID: 153430 RVA: 0x000C8058 File Offset: 0x000C6258
		[Token(Token = "0x6025756")]
		[Address(RVA = "0x2060BD0", Offset = "0x205F7D0", VA = "0x182060BD0")]
		private static int _GetNameCardPublicCount()
		{
			return 0;
		}

		// Token: 0x04034909 RID: 215305
		[Token(Token = "0x4034909")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCollectSetPic;

		// Token: 0x0403490A RID: 215306
		[Token(Token = "0x403490A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadCollectTypePic;

		// Token: 0x0403490B RID: 215307
		[Token(Token = "0x403490B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadCollectTypeFilterEnglishNamePic;

		// Token: 0x0403490C RID: 215308
		[Token(Token = "0x403490C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadCollectTypeFilterIconPic;

		// Token: 0x0403490D RID: 215309
		[Token(Token = "0x403490D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadHomeThemePic;

		// Token: 0x0403490E RID: 215310
		[Token(Token = "0x403490E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadHomeBackgroundPic;

		// Token: 0x0403490F RID: 215311
		[Token(Token = "0x403490F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x04034910 RID: 215312
		[Token(Token = "0x4034910")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetItemTypeByTabType;

		// Token: 0x04034911 RID: 215313
		[Token(Token = "0x4034911")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetArtGalleryCollectData;

		// Token: 0x04034912 RID: 215314
		[Token(Token = "0x4034912")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetItemStartTime;

		// Token: 0x04034913 RID: 215315
		[Token(Token = "0x4034913")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCollectSetItemsGotCnt;

		// Token: 0x04034914 RID: 215316
		[Token(Token = "0x4034914")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCollectSetClaimedMissionIdList;

		// Token: 0x04034915 RID: 215317
		[Token(Token = "0x4034915")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CollectSetsMissionHasRewardsCanClaim;

		// Token: 0x04034916 RID: 215318
		[Token(Token = "0x4034916")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CollectSetMissionHasRewardsCanClaim;

		// Token: 0x04034917 RID: 215319
		[Token(Token = "0x4034917")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CollectSetConsumeNewTracksByType;

		// Token: 0x04034918 RID: 215320
		[Token(Token = "0x4034918")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CollectSetConsumeNewTrack;

		// Token: 0x04034919 RID: 215321
		[Token(Token = "0x4034919")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CollectSetHasNewTrack;

		// Token: 0x0403491A RID: 215322
		[Token(Token = "0x403491A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetCollectSetMissionRewardsState;

		// Token: 0x0403491B RID: 215323
		[Token(Token = "0x403491B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetCollectItemModelByType;

		// Token: 0x0403491C RID: 215324
		[Token(Token = "0x403491C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckCollectHasNewTrack;

		// Token: 0x0403491D RID: 215325
		[Token(Token = "0x403491D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetCollectSetNotClaimedMissionState;

		// Token: 0x0403491E RID: 215326
		[Token(Token = "0x403491E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CurrentPercent;

		// Token: 0x0403491F RID: 215327
		[Token(Token = "0x403491F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetHomeThemePublicCount;

		// Token: 0x04034920 RID: 215328
		[Token(Token = "0x4034920")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetHomeBackgroundPublicCount;

		// Token: 0x04034921 RID: 215329
		[Token(Token = "0x4034921")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetAvatarPublicCount;

		// Token: 0x04034922 RID: 215330
		[Token(Token = "0x4034922")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GetNameCardPublicCount;

		// Token: 0x020065CF RID: 26063
		[Token(Token = "0x20065CF")]
		public enum CollectSetMissionRewardsState
		{
			// Token: 0x04034924 RID: 215332
			[Token(Token = "0x4034924")]
			NONE,
			// Token: 0x04034925 RID: 215333
			[Token(Token = "0x4034925")]
			CANT_CLAIM,
			// Token: 0x04034926 RID: 215334
			[Token(Token = "0x4034926")]
			CAN_CLAIM,
			// Token: 0x04034927 RID: 215335
			[Token(Token = "0x4034927")]
			CLAIMED
		}
	}
}
