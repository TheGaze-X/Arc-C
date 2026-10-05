using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E57 RID: 20055
	[Token(Token = "0x2004E57")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class FireworkUtil
	{
		// Token: 0x0601DED6 RID: 122582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DED6")]
		[Address(RVA = "0x17AEE60", Offset = "0x17ADA60", VA = "0x1817AEE60")]
		public static string GetFireworkUnlockDesc()
		{
			return null;
		}

		// Token: 0x0601DED7 RID: 122583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DED7")]
		[Address(RVA = "0x17AEEE0", Offset = "0x17ADAE0", VA = "0x1817AEEE0")]
		public static string GetFireworkUnlockToast()
		{
			return null;
		}

		// Token: 0x0601DED8 RID: 122584 RVA: 0x000ACEA8 File Offset: 0x000AB0A8
		[Token(Token = "0x601DED8")]
		[Address(RVA = "0x17AE600", Offset = "0x17AD200", VA = "0x1817AE600")]
		public static bool CheckIfFireworkCraftUnlock()
		{
			return default(bool);
		}

		// Token: 0x0601DED9 RID: 122585 RVA: 0x000ACEC0 File Offset: 0x000AB0C0
		[Token(Token = "0x601DED9")]
		[Address(RVA = "0x17AEB80", Offset = "0x17AD780", VA = "0x1817AEB80")]
		public static int GetCurrentAnimalLevel()
		{
			return 0;
		}

		// Token: 0x0601DEDA RID: 122586 RVA: 0x000ACED8 File Offset: 0x000AB0D8
		[Token(Token = "0x601DEDA")]
		[Address(RVA = "0x17AE8E0", Offset = "0x17AD4E0", VA = "0x1817AE8E0")]
		public static int GetAnimalLevel(List<FireworkData.PlateSlotData> slotList)
		{
			return 0;
		}

		// Token: 0x0601DEDB RID: 122587 RVA: 0x000ACEF0 File Offset: 0x000AB0F0
		[Token(Token = "0x601DEDB")]
		[Address(RVA = "0x17AF1B0", Offset = "0x17ADDB0", VA = "0x1817AF1B0")]
		public static int GetPlateContentRank(FireworkData.PlateContent plateContent)
		{
			return 0;
		}

		// Token: 0x0601DEDC RID: 122588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEDC")]
		[Address(RVA = "0x17AEF60", Offset = "0x17ADB60", VA = "0x1817AEF60")]
		public static List<GridPosition> GetGridPositionBySlot(List<FireworkData.PlateSlotData> slotList)
		{
			return null;
		}

		// Token: 0x0601DEDD RID: 122589 RVA: 0x000ACF08 File Offset: 0x000AB108
		[Token(Token = "0x601DEDD")]
		[Address(RVA = "0x17AED70", Offset = "0x17AD970", VA = "0x1817AED70")]
		public static FireworkData.FireworkType GetFireworkTypeByAnimalId(string animalId)
		{
			return FireworkData.FireworkType.RED;
		}

		// Token: 0x0601DEDE RID: 122590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEDE")]
		[Address(RVA = "0x17AEAC0", Offset = "0x17AD6C0", VA = "0x1817AEAC0")]
		public static string GetCurrentAnimalId()
		{
			return null;
		}

		// Token: 0x0601DEDF RID: 122591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEDF")]
		[Address(RVA = "0x17AEA40", Offset = "0x17AD640", VA = "0x1817AEA40")]
		public static string GetCurrentAnimalIcon(FireworkUtil.AnimalIconType iconType)
		{
			return null;
		}

		// Token: 0x0601DEE0 RID: 122592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEE0")]
		[Address(RVA = "0x17AE690", Offset = "0x17AD290", VA = "0x1817AE690")]
		public static string GetAnimalIconId(string animalId, int level, FireworkUtil.AnimalIconType iconType)
		{
			return null;
		}

		// Token: 0x0601DEE1 RID: 122593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEE1")]
		[Address(RVA = "0x17AF730", Offset = "0x17AE330", VA = "0x1817AF730")]
		public static Sprite LoadCraftAnimalIcon(ILoadAsset loadAsset, string iconId)
		{
			return null;
		}

		// Token: 0x0601DEE2 RID: 122594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEE2")]
		[Address(RVA = "0x17AF5A0", Offset = "0x17AE1A0", VA = "0x1817AF5A0")]
		public static Sprite LoadCraftAnimalBkgIcon(ILoadAsset loader, string animId)
		{
			return null;
		}

		// Token: 0x0601DEE3 RID: 122595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEE3")]
		[Address(RVA = "0x17AFCE0", Offset = "0x17AE8E0", VA = "0x1817AFCE0")]
		public static Sprite LoadFireworkPlateIcon(ILoadAsset loader, string plateGroupId)
		{
			return null;
		}

		// Token: 0x0601DEE4 RID: 122596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEE4")]
		[Address(RVA = "0x17B0070", Offset = "0x17AEC70", VA = "0x1817B0070")]
		public static Sprite LoadFireworkSaveBtnIcon(ILoadAsset loader, string iconId)
		{
			return null;
		}

		// Token: 0x0601DEE5 RID: 122597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEE5")]
		[Address(RVA = "0x17B03C0", Offset = "0x17AEFC0", VA = "0x1817B03C0")]
		public static void ShowFireworkPlateToast(ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601DEE6 RID: 122598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEE6")]
		[Address(RVA = "0x17B02B0", Offset = "0x17AEEB0", VA = "0x1817B02B0")]
		public static void ShowFireworkAnimalToast(string toastText, string iconId, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601DEE7 RID: 122599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEE7")]
		public static void ShowNotifyView<ViewType, ParamType>(string viewPath, ParamType param, ILoadAsset loader) where ViewType : UINotifyView<ParamType> where ParamType : NotifyViewParam
		{
		}

		// Token: 0x0601DEE8 RID: 122600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEE8")]
		[Address(RVA = "0x17AFE00", Offset = "0x17AEA00", VA = "0x1817AFE00")]
		public static FireworkPlateViewStyle LoadFireworkPlateViewStyle(ILoadAsset loader, string styleId, bool isMap = false)
		{
			return null;
		}

		// Token: 0x0601DEE9 RID: 122601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEE9")]
		[Address(RVA = "0x17AFB10", Offset = "0x17AE710", VA = "0x1817AFB10")]
		public static FireworkPlateGroupViewStyle LoadFireworkPlateGroupViewStyle(ILoadAsset loader, string styleId)
		{
			return null;
		}

		// Token: 0x0601DEEA RID: 122602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEEA")]
		[Address(RVA = "0x17AFD80", Offset = "0x17AE980", VA = "0x1817AFD80")]
		public static FireworkPlateViewStyle LoadFireworkPlatePuzzleStyle(ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601DEEB RID: 122603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEEB")]
		[Address(RVA = "0x17B0000", Offset = "0x17AEC00", VA = "0x1817B0000")]
		public static FireworkPlateGroupViewStyle LoadFireworkPuzzleGroupViewStyle(ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601DEEC RID: 122604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEEC")]
		[Address(RVA = "0x17AF9F0", Offset = "0x17AE5F0", VA = "0x1817AF9F0")]
		public static GameObject LoadFireworkBgPrefab(ILoadAsset loader, string bgId)
		{
			return null;
		}

		// Token: 0x0601DEED RID: 122605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEED")]
		[Address(RVA = "0x17B0130", Offset = "0x17AED30", VA = "0x1817B0130")]
		public static GameObject LoadPuzzleBgPrefab(ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601DEEE RID: 122606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEEE")]
		[Address(RVA = "0x17AF4B0", Offset = "0x17AE0B0", VA = "0x1817AF4B0")]
		public static GameObject LoadBkgParticleEffect(ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601DEEF RID: 122607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEEF")]
		[Address(RVA = "0x17B05C0", Offset = "0x17AF1C0", VA = "0x1817B05C0")]
		private static Sprite _LoadSpriteFromAutoPackHub(ILoadAsset loader, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601DEF0 RID: 122608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEF0")]
		[Address(RVA = "0x17B04B0", Offset = "0x17AF0B0", VA = "0x1817B04B0")]
		private static string _FormatFireworkStageCode(string format)
		{
			return null;
		}

		// Token: 0x0601DEF1 RID: 122609 RVA: 0x000ACF20 File Offset: 0x000AB120
		[Token(Token = "0x601DEF1")]
		[Address(RVA = "0x17AF400", Offset = "0x17AE000", VA = "0x1817AF400")]
		public static bool IsEqual(this FireworkData.PlateSlotData lhs, FireworkData.PlateSlotData rhs)
		{
			return default(bool);
		}

		// Token: 0x0601DEF2 RID: 122610 RVA: 0x000ACF38 File Offset: 0x000AB138
		[Token(Token = "0x601DEF2")]
		[Address(RVA = "0x17AF320", Offset = "0x17ADF20", VA = "0x1817AF320")]
		public static bool IsEqual(this PlateContentModel lhs, PlateContentModel rhs)
		{
			return default(bool);
		}

		// Token: 0x0601DEF3 RID: 122611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEF3")]
		public static List<TView> CreateFireworkPlateElements<TView>(TView prefab, RectTransform container, FireworkPlateModel plateModel, Vector2 gridSize, Vector2 padding) where TView : MonoBehaviour, IFireworkPlateElementView
		{
			return null;
		}

		// Token: 0x0601DEF4 RID: 122612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEF4")]
		[Address(RVA = "0x17AF090", Offset = "0x17ADC90", VA = "0x1817AF090")]
		public static FireworkData.PlateContent GetPlateContentBySlot(FireworkData.PlateSlotData plateSlot)
		{
			return null;
		}

		// Token: 0x0601DEF5 RID: 122613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DEF5")]
		[Address(RVA = "0x17AF7B0", Offset = "0x17AE3B0", VA = "0x1817AF7B0")]
		public static Sprite LoadCraftPreviewSprite(ILoadAsset assetLoader, string spriteId)
		{
			return null;
		}

		// Token: 0x04027B9D RID: 162717
		[Token(Token = "0x4027B9D")]
		private const string ANIMAL_BKG_FORMAT = "{0}_bkg";

		// Token: 0x04027B9E RID: 162718
		[Token(Token = "0x4027B9E")]
		private const string PLATE_STYLE_FORMAT = "{0}_plate_style";

		// Token: 0x04027B9F RID: 162719
		[Token(Token = "0x4027B9F")]
		private const string PLATE_STYLE_FORMAT_MAP = "{0}_map_plate_style";

		// Token: 0x04027BA0 RID: 162720
		[Token(Token = "0x4027BA0")]
		private const string PLATE_LIST_STYLE_FORMAT = "{0}_plate_list_style";

		// Token: 0x04027BA1 RID: 162721
		[Token(Token = "0x4027BA1")]
		private const string FIREWORK_PNL_BKG_FORMAT = "{0}_pnl_bkg";

		// Token: 0x04027BA2 RID: 162722
		[Token(Token = "0x4027BA2")]
		private const string FIREWORK_SAVE_BTN_ICON_FORMAT = "{0}_save_icon";

		// Token: 0x04027BA3 RID: 162723
		[Token(Token = "0x4027BA3")]
		private const string PUZZLE_ID = "firework_puzzle";

		// Token: 0x04027BA4 RID: 162724
		[Token(Token = "0x4027BA4")]
		private const string BG_PARTICLE_EFFECT = "firework_bkg_particle_effect";

		// Token: 0x04027BA5 RID: 162725
		[Token(Token = "0x4027BA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFireworkUnlockDesc;

		// Token: 0x04027BA6 RID: 162726
		[Token(Token = "0x4027BA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetFireworkUnlockToast;

		// Token: 0x04027BA7 RID: 162727
		[Token(Token = "0x4027BA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfFireworkCraftUnlock;

		// Token: 0x04027BA8 RID: 162728
		[Token(Token = "0x4027BA8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurrentAnimalLevel;

		// Token: 0x04027BA9 RID: 162729
		[Token(Token = "0x4027BA9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetAnimalLevel;

		// Token: 0x04027BAA RID: 162730
		[Token(Token = "0x4027BAA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlateContentRank;

		// Token: 0x04027BAB RID: 162731
		[Token(Token = "0x4027BAB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetGridPositionBySlot;

		// Token: 0x04027BAC RID: 162732
		[Token(Token = "0x4027BAC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetFireworkTypeByAnimalId;

		// Token: 0x04027BAD RID: 162733
		[Token(Token = "0x4027BAD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCurrentAnimalId;

		// Token: 0x04027BAE RID: 162734
		[Token(Token = "0x4027BAE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetCurrentAnimalIcon;

		// Token: 0x04027BAF RID: 162735
		[Token(Token = "0x4027BAF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetAnimalIconId;

		// Token: 0x04027BB0 RID: 162736
		[Token(Token = "0x4027BB0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadCraftAnimalIcon;

		// Token: 0x04027BB1 RID: 162737
		[Token(Token = "0x4027BB1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadCraftAnimalBkgIcon;

		// Token: 0x04027BB2 RID: 162738
		[Token(Token = "0x4027BB2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadFireworkPlateIcon;

		// Token: 0x04027BB3 RID: 162739
		[Token(Token = "0x4027BB3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadFireworkSaveBtnIcon;

		// Token: 0x04027BB4 RID: 162740
		[Token(Token = "0x4027BB4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ShowFireworkPlateToast;

		// Token: 0x04027BB5 RID: 162741
		[Token(Token = "0x4027BB5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ShowFireworkAnimalToast;

		// Token: 0x04027BB6 RID: 162742
		[Token(Token = "0x4027BB6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ShowNotifyView;

		// Token: 0x04027BB7 RID: 162743
		[Token(Token = "0x4027BB7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadFireworkPlateViewStyle;

		// Token: 0x04027BB8 RID: 162744
		[Token(Token = "0x4027BB8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadFireworkPlateGroupViewStyle;

		// Token: 0x04027BB9 RID: 162745
		[Token(Token = "0x4027BB9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadFireworkPlatePuzzleStyle;

		// Token: 0x04027BBA RID: 162746
		[Token(Token = "0x4027BBA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadFireworkPuzzleGroupViewStyle;

		// Token: 0x04027BBB RID: 162747
		[Token(Token = "0x4027BBB")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadFireworkBgPrefab;

		// Token: 0x04027BBC RID: 162748
		[Token(Token = "0x4027BBC")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_LoadPuzzleBgPrefab;

		// Token: 0x04027BBD RID: 162749
		[Token(Token = "0x4027BBD")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadBkgParticleEffect;

		// Token: 0x04027BBE RID: 162750
		[Token(Token = "0x4027BBE")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromAutoPackHub;

		// Token: 0x04027BBF RID: 162751
		[Token(Token = "0x4027BBF")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__FormatFireworkStageCode;

		// Token: 0x04027BC0 RID: 162752
		[Token(Token = "0x4027BC0")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_IsEqual;

		// Token: 0x04027BC1 RID: 162753
		[Token(Token = "0x4027BC1")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix1_IsEqual;

		// Token: 0x04027BC2 RID: 162754
		[Token(Token = "0x4027BC2")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CreateFireworkPlateElements;

		// Token: 0x04027BC3 RID: 162755
		[Token(Token = "0x4027BC3")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetPlateContentBySlot;

		// Token: 0x04027BC4 RID: 162756
		[Token(Token = "0x4027BC4")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_LoadCraftPreviewSprite;

		// Token: 0x02004E58 RID: 20056
		[Token(Token = "0x2004E58")]
		public enum AnimalIconType
		{
			// Token: 0x04027BC6 RID: 162758
			[Token(Token = "0x4027BC6")]
			OUTLINE,
			// Token: 0x04027BC7 RID: 162759
			[Token(Token = "0x4027BC7")]
			NON_OUTLINE_SELECTED,
			// Token: 0x04027BC8 RID: 162760
			[Token(Token = "0x4027BC8")]
			NON_OUTLINE_UNSELECT
		}
	}
}
