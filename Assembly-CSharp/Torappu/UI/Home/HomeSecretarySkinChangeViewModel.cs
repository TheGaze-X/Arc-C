using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B78 RID: 19320
	[Token(Token = "0x2004B78")]
	public class HomeSecretarySkinChangeViewModel : IHotfixable
	{
		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x0601D147 RID: 119111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004463")]
		public string displaySkinTag
		{
			[Token(Token = "0x601D147")]
			[Address(RVA = "0x16A84D0", Offset = "0x16A70D0", VA = "0x1816A84D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004464 RID: 17508
		// (get) Token: 0x0601D148 RID: 119112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004464")]
		public List<HomeSecretarySkinItemModel> filterdSkinList
		{
			[Token(Token = "0x601D148")]
			[Address(RVA = "0x16A8540", Offset = "0x16A7140", VA = "0x1816A8540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004465 RID: 17509
		// (get) Token: 0x0601D149 RID: 119113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004465")]
		public HomeSecretarySkinItemModel displaySkinModel
		{
			[Token(Token = "0x601D149")]
			[Address(RVA = "0x16A83B0", Offset = "0x16A6FB0", VA = "0x1816A83B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D14A RID: 119114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D14A")]
		[Address(RVA = "0x16A63B0", Offset = "0x16A4FB0", VA = "0x1816A63B0")]
		public void LoadData(List<string> charIdList, List<string> selectedSkinIdList, string presetInstId, bool showSelectCharBtn)
		{
		}

		// Token: 0x0601D14B RID: 119115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D14B")]
		[Address(RVA = "0x16A68D0", Offset = "0x16A54D0", VA = "0x1816A68D0")]
		public void SelectSkin(string skinTag)
		{
		}

		// Token: 0x0601D14C RID: 119116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D14C")]
		[Address(RVA = "0x16A67D0", Offset = "0x16A53D0", VA = "0x1816A67D0")]
		public void RemoveSkin(string skinTag)
		{
		}

		// Token: 0x0601D14D RID: 119117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D14D")]
		[Address(RVA = "0x16A5A70", Offset = "0x16A4670", VA = "0x1816A5A70")]
		public void CleanAllSelect()
		{
		}

		// Token: 0x0601D14E RID: 119118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D14E")]
		[Address(RVA = "0x16A69D0", Offset = "0x16A55D0", VA = "0x1816A69D0")]
		public void SetFilter(HomeSecretarySkinChangeViewModel.FilterType type, bool flag)
		{
		}

		// Token: 0x0601D14F RID: 119119 RVA: 0x000AA4C0 File Offset: 0x000A86C0
		[Token(Token = "0x601D14F")]
		[Address(RVA = "0x16A6340", Offset = "0x16A4F40", VA = "0x1816A6340")]
		public bool GetFilterStatusByType(HomeSecretarySkinChangeViewModel.FilterType type)
		{
			return default(bool);
		}

		// Token: 0x0601D150 RID: 119120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D150")]
		[Address(RVA = "0x16A5B30", Offset = "0x16A4730", VA = "0x1816A5B30")]
		public List<CharRotationUpdatePresetRequest.Slot> GenerateSelectedSlots()
		{
			return null;
		}

		// Token: 0x0601D151 RID: 119121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D151")]
		[Address(RVA = "0x16A6C90", Offset = "0x16A5890", VA = "0x1816A6C90")]
		private void _ClearData()
		{
		}

		// Token: 0x0601D152 RID: 119122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D152")]
		[Address(RVA = "0x16A7780", Offset = "0x16A6380", VA = "0x1816A7780")]
		private void _LoadSkinInfo(List<string> charIdList)
		{
		}

		// Token: 0x0601D153 RID: 119123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D153")]
		[Address(RVA = "0x16A7550", Offset = "0x16A6150", VA = "0x1816A7550")]
		private void _LoadGameDataConsts()
		{
		}

		// Token: 0x0601D154 RID: 119124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D154")]
		[Address(RVA = "0x16A81D0", Offset = "0x16A6DD0", VA = "0x1816A81D0")]
		private void _UpdateSelectedSkinInfo(List<string> selectedSkinTagsList)
		{
		}

		// Token: 0x0601D155 RID: 119125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D155")]
		[Address(RVA = "0x16A7F60", Offset = "0x16A6B60", VA = "0x1816A7F60")]
		private void _UpdateDisplaySkinInfo()
		{
		}

		// Token: 0x0601D156 RID: 119126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D156")]
		[Address(RVA = "0x16A6DA0", Offset = "0x16A59A0", VA = "0x1816A6DA0")]
		private List<HomeSecretarySkinItemModel> _GenerateFilterdSkinList()
		{
			return null;
		}

		// Token: 0x0601D157 RID: 119127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D157")]
		[Address(RVA = "0x16A75D0", Offset = "0x16A61D0", VA = "0x1816A75D0")]
		private void _LoadSecretarySkin(string presetInstId)
		{
		}

		// Token: 0x0601D158 RID: 119128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D158")]
		[Address(RVA = "0x16A7130", Offset = "0x16A5D30", VA = "0x1816A7130")]
		private static List<HomeSecretarySkinChangeViewModel.SkinItemFilterFunc> _GetSkinFiltersByType(HomeSecretarySkinChangeViewModel.FilterType type)
		{
			return null;
		}

		// Token: 0x0601D159 RID: 119129 RVA: 0x000AA4D8 File Offset: 0x000A86D8
		[Token(Token = "0x601D159")]
		[Address(RVA = "0x16A6B40", Offset = "0x16A5740", VA = "0x1816A6B40")]
		private static bool _CheckIfEvolveTwoSkin(HomeSecretarySkinItemModel model)
		{
			return default(bool);
		}

		// Token: 0x0601D15A RID: 119130 RVA: 0x000AA4F0 File Offset: 0x000A86F0
		[Token(Token = "0x601D15A")]
		[Address(RVA = "0x16A6BB0", Offset = "0x16A57B0", VA = "0x1816A6BB0")]
		private static bool _CheckIfShopSkin(HomeSecretarySkinItemModel model)
		{
			return default(bool);
		}

		// Token: 0x0601D15B RID: 119131 RVA: 0x000AA508 File Offset: 0x000A8708
		[Token(Token = "0x601D15B")]
		[Address(RVA = "0x16A6AD0", Offset = "0x16A56D0", VA = "0x1816A6AD0")]
		private static bool _CheckIfDynSkin(HomeSecretarySkinItemModel model)
		{
			return default(bool);
		}

		// Token: 0x0601D15C RID: 119132 RVA: 0x000AA520 File Offset: 0x000A8720
		[Token(Token = "0x601D15C")]
		[Address(RVA = "0x16A6C20", Offset = "0x16A5820", VA = "0x1816A6C20")]
		private static bool _CheckIfSpDynIllust(HomeSecretarySkinItemModel model)
		{
			return default(bool);
		}

		// Token: 0x0601D15D RID: 119133 RVA: 0x000AA538 File Offset: 0x000A8738
		[Token(Token = "0x601D15D")]
		[Address(RVA = "0x16A7390", Offset = "0x16A5F90", VA = "0x1816A7390")]
		private static bool _IsEvolveSkin(ListDict<int, string> evolveSkinDict, string skinId, out EvolvePhase phase)
		{
			return default(bool);
		}

		// Token: 0x0601D15E RID: 119134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D15E")]
		[Address(RVA = "0x16A8260", Offset = "0x16A6E60", VA = "0x1816A8260")]
		public HomeSecretarySkinChangeViewModel()
		{
		}

		// Token: 0x04026291 RID: 156305
		[Token(Token = "0x4026291")]
		[FieldOffset(Offset = "0x10")]
		public HashSet<string> selectedSkinTags;

		// Token: 0x04026292 RID: 156306
		[Token(Token = "0x4026292")]
		[FieldOffset(Offset = "0x18")]
		public int maxSelectSkinNum;

		// Token: 0x04026293 RID: 156307
		[Token(Token = "0x4026293")]
		[FieldOffset(Offset = "0x20")]
		public string presetInstId;

		// Token: 0x04026294 RID: 156308
		[Token(Token = "0x4026294")]
		[FieldOffset(Offset = "0x28")]
		public List<string> selectedCharIds;

		// Token: 0x04026295 RID: 156309
		[Token(Token = "0x4026295")]
		[FieldOffset(Offset = "0x30")]
		public CharUISkinStruct secretarySkin;

		// Token: 0x04026296 RID: 156310
		[Token(Token = "0x4026296")]
		[FieldOffset(Offset = "0x48")]
		public bool showSelectCharBtn;

		// Token: 0x04026297 RID: 156311
		[Token(Token = "0x4026297")]
		[FieldOffset(Offset = "0x50")]
		private ListDict<string, HomeSecretarySkinItemModel> m_skinDict;

		// Token: 0x04026298 RID: 156312
		[Token(Token = "0x4026298")]
		[FieldOffset(Offset = "0x58")]
		private List<string> m_playerSelectRecords;

		// Token: 0x04026299 RID: 156313
		[Token(Token = "0x4026299")]
		[FieldOffset(Offset = "0x60")]
		private string m_displaySkinTag;

		// Token: 0x0402629A RID: 156314
		[Token(Token = "0x402629A")]
		[FieldOffset(Offset = "0x68")]
		private List<HomeSecretarySkinItemModel> m_filterdSkinList;

		// Token: 0x0402629B RID: 156315
		[Token(Token = "0x402629B")]
		[FieldOffset(Offset = "0x70")]
		private HomeSecretarySkinChangeViewModel.FilterType m_skinFilterFlag;

		// Token: 0x0402629C RID: 156316
		[Token(Token = "0x402629C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displaySkinTag;

		// Token: 0x0402629D RID: 156317
		[Token(Token = "0x402629D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_filterdSkinList;

		// Token: 0x0402629E RID: 156318
		[Token(Token = "0x402629E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_displaySkinModel;

		// Token: 0x0402629F RID: 156319
		[Token(Token = "0x402629F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040262A0 RID: 156320
		[Token(Token = "0x40262A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectSkin;

		// Token: 0x040262A1 RID: 156321
		[Token(Token = "0x40262A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RemoveSkin;

		// Token: 0x040262A2 RID: 156322
		[Token(Token = "0x40262A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CleanAllSelect;

		// Token: 0x040262A3 RID: 156323
		[Token(Token = "0x40262A3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetFilter;

		// Token: 0x040262A4 RID: 156324
		[Token(Token = "0x40262A4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetFilterStatusByType;

		// Token: 0x040262A5 RID: 156325
		[Token(Token = "0x40262A5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GenerateSelectedSlots;

		// Token: 0x040262A6 RID: 156326
		[Token(Token = "0x40262A6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearData;

		// Token: 0x040262A7 RID: 156327
		[Token(Token = "0x40262A7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadSkinInfo;

		// Token: 0x040262A8 RID: 156328
		[Token(Token = "0x40262A8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadGameDataConsts;

		// Token: 0x040262A9 RID: 156329
		[Token(Token = "0x40262A9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateSelectedSkinInfo;

		// Token: 0x040262AA RID: 156330
		[Token(Token = "0x40262AA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateDisplaySkinInfo;

		// Token: 0x040262AB RID: 156331
		[Token(Token = "0x40262AB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateFilterdSkinList;

		// Token: 0x040262AC RID: 156332
		[Token(Token = "0x40262AC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadSecretarySkin;

		// Token: 0x040262AD RID: 156333
		[Token(Token = "0x40262AD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetSkinFiltersByType;

		// Token: 0x040262AE RID: 156334
		[Token(Token = "0x40262AE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckIfEvolveTwoSkin;

		// Token: 0x040262AF RID: 156335
		[Token(Token = "0x40262AF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CheckIfShopSkin;

		// Token: 0x040262B0 RID: 156336
		[Token(Token = "0x40262B0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckIfDynSkin;

		// Token: 0x040262B1 RID: 156337
		[Token(Token = "0x40262B1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CheckIfSpDynIllust;

		// Token: 0x040262B2 RID: 156338
		[Token(Token = "0x40262B2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__IsEvolveSkin;

		// Token: 0x040262B3 RID: 156339
		[Token(Token = "0x40262B3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B79 RID: 19321
		[Token(Token = "0x2004B79")]
		private class CharModelForSort : IComparable<HomeSecretarySkinChangeViewModel.CharModelForSort>
		{
			// Token: 0x0601D15F RID: 119135 RVA: 0x000AA550 File Offset: 0x000A8750
			[Token(Token = "0x601D15F")]
			[Address(RVA = "0x1699490", Offset = "0x1698090", VA = "0x181699490", Slot = "4")]
			public int CompareTo(HomeSecretarySkinChangeViewModel.CharModelForSort other)
			{
				return 0;
			}

			// Token: 0x0601D160 RID: 119136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D160")]
			[Address(RVA = "0x1699590", Offset = "0x1698190", VA = "0x181699590")]
			public CharModelForSort()
			{
			}

			// Token: 0x040262B4 RID: 156340
			[Token(Token = "0x40262B4")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x040262B5 RID: 156341
			[Token(Token = "0x40262B5")]
			[FieldOffset(Offset = "0x18")]
			public RarityRank charRarity;

			// Token: 0x040262B6 RID: 156342
			[Token(Token = "0x40262B6")]
			[FieldOffset(Offset = "0x20")]
			public List<string> skinTags;
		}

		// Token: 0x02004B7A RID: 19322
		[Token(Token = "0x2004B7A")]
		[Flags]
		public enum FilterType
		{
			// Token: 0x040262B8 RID: 156344
			[Token(Token = "0x40262B8")]
			NONE = 0,
			// Token: 0x040262B9 RID: 156345
			[Token(Token = "0x40262B9")]
			EVOLVE_TWO_SKIN = 1,
			// Token: 0x040262BA RID: 156346
			[Token(Token = "0x40262BA")]
			SHOP_SKIN = 2,
			// Token: 0x040262BB RID: 156347
			[Token(Token = "0x40262BB")]
			DYN_SKIN = 4,
			// Token: 0x040262BC RID: 156348
			[Token(Token = "0x40262BC")]
			SHOW_SELECTED = 8,
			// Token: 0x040262BD RID: 156349
			[Token(Token = "0x40262BD")]
			SP_DYN_SKIN = 16
		}

		// Token: 0x02004B7B RID: 19323
		[Token(Token = "0x2004B7B")]
		public class FilterParam
		{
			// Token: 0x0601D161 RID: 119137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D161")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FilterParam()
			{
			}

			// Token: 0x040262BE RID: 156350
			[Token(Token = "0x40262BE")]
			[FieldOffset(Offset = "0x10")]
			public HomeSecretarySkinChangeViewModel.FilterType filterType;

			// Token: 0x040262BF RID: 156351
			[Token(Token = "0x40262BF")]
			[FieldOffset(Offset = "0x14")]
			public bool selected;
		}

		// Token: 0x02004B7C RID: 19324
		// (Invoke) Token: 0x0601D163 RID: 119139
		[Token(Token = "0x2004B7C")]
		private delegate bool SkinItemFilterFunc(HomeSecretarySkinItemModel model);
	}
}
