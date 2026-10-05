using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003C0E RID: 15374
	[Token(Token = "0x2003C0E")]
	public class UniEquipArchiveModuleCollectionViewModel : IHotfixable
	{
		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x060180A7 RID: 98471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700396C")]
		public List<UniEquipArchiveModuleCollectionItemViewModel> sortedEquipItemViewModels
		{
			[Token(Token = "0x60180A7")]
			[Address(RVA = "0x1084720", Offset = "0x1083320", VA = "0x181084720")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x060180A8 RID: 98472 RVA: 0x000991C8 File Offset: 0x000973C8
		[Token(Token = "0x1700396D")]
		public UniEquipSortType sortType
		{
			[Token(Token = "0x60180A8")]
			[Address(RVA = "0x10846C0", Offset = "0x10832C0", VA = "0x1810846C0")]
			get
			{
				return UniEquipSortType.BY_LEVEL_UP;
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x060180A9 RID: 98473 RVA: 0x000991E0 File Offset: 0x000973E0
		[Token(Token = "0x1700396E")]
		public UniEquipArchiveModuleTYpeFilterItemInfoData selectedFilterItemData
		{
			[Token(Token = "0x60180A9")]
			[Address(RVA = "0x10845A0", Offset = "0x10831A0", VA = "0x1810845A0")]
			get
			{
				return default(UniEquipArchiveModuleTYpeFilterItemInfoData);
			}
		}

		// Token: 0x060180AA RID: 98474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180AA")]
		[Address(RVA = "0x1083E90", Offset = "0x1082A90", VA = "0x181083E90")]
		public void LoadData()
		{
		}

		// Token: 0x060180AB RID: 98475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180AB")]
		[Address(RVA = "0x1084130", Offset = "0x1082D30", VA = "0x181084130")]
		public void RefreshData()
		{
		}

		// Token: 0x060180AC RID: 98476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60180AC")]
		[Address(RVA = "0x1084260", Offset = "0x1082E60", VA = "0x181084260")]
		public UniEquipArchiveModuleCollectionItemViewModel TryGetCollectionItemViewModel(string uniEquipId)
		{
			return null;
		}

		// Token: 0x060180AD RID: 98477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180AD")]
		[Address(RVA = "0x1083AF0", Offset = "0x10826F0", VA = "0x181083AF0")]
		public void ApplyEquipOwnFilterParam(UniEquipArchiveFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x060180AE RID: 98478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180AE")]
		[Address(RVA = "0x1083B70", Offset = "0x1082770", VA = "0x181083B70")]
		public void ApplyEquipTypeFilterParam(UniEquipArchiveEquipTypeFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x060180AF RID: 98479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180AF")]
		[Address(RVA = "0x1083E10", Offset = "0x1082A10", VA = "0x181083E10")]
		public void ApplySortType(UniEquipSortType type)
		{
		}

		// Token: 0x060180B0 RID: 98480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180B0")]
		[Address(RVA = "0x1083BF0", Offset = "0x10827F0", VA = "0x181083BF0")]
		public void ApplySortFilter()
		{
		}

		// Token: 0x060180B1 RID: 98481 RVA: 0x000991F8 File Offset: 0x000973F8
		[Token(Token = "0x60180B1")]
		[Address(RVA = "0x10843A0", Offset = "0x1082FA0", VA = "0x1810843A0")]
		private int _SortViewModel(UniEquipArchiveModuleCollectionItemViewModel a, UniEquipArchiveModuleCollectionItemViewModel b)
		{
			return 0;
		}

		// Token: 0x060180B2 RID: 98482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180B2")]
		[Address(RVA = "0x10844B0", Offset = "0x10830B0", VA = "0x1810844B0")]
		public UniEquipArchiveModuleCollectionViewModel()
		{
		}

		// Token: 0x0401D282 RID: 119426
		[Token(Token = "0x401D282")]
		[FieldOffset(Offset = "0x10")]
		private List<UniEquipArchiveModuleCollectionItemViewModel> m_equipItemViewModels;

		// Token: 0x0401D283 RID: 119427
		[Token(Token = "0x401D283")]
		[FieldOffset(Offset = "0x18")]
		private List<UniEquipArchiveModuleCollectionItemViewModel> m_sortedEquipItemViewModels;

		// Token: 0x0401D284 RID: 119428
		[Token(Token = "0x401D284")]
		[FieldOffset(Offset = "0x20")]
		private UniEquipArchiveFilterHolder.FilterParam m_equipOwnFilterParam;

		// Token: 0x0401D285 RID: 119429
		[Token(Token = "0x401D285")]
		[FieldOffset(Offset = "0x28")]
		private UniEquipArchiveEquipTypeFilterHolder.FilterParam m_equipTypeFilterParam;

		// Token: 0x0401D286 RID: 119430
		[Token(Token = "0x401D286")]
		[FieldOffset(Offset = "0x30")]
		private UniEquipSortType m_sortType;

		// Token: 0x0401D287 RID: 119431
		[Token(Token = "0x401D287")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortedEquipItemViewModels;

		// Token: 0x0401D288 RID: 119432
		[Token(Token = "0x401D288")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sortType;

		// Token: 0x0401D289 RID: 119433
		[Token(Token = "0x401D289")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedFilterItemData;

		// Token: 0x0401D28A RID: 119434
		[Token(Token = "0x401D28A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D28B RID: 119435
		[Token(Token = "0x401D28B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401D28C RID: 119436
		[Token(Token = "0x401D28C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetCollectionItemViewModel;

		// Token: 0x0401D28D RID: 119437
		[Token(Token = "0x401D28D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyEquipOwnFilterParam;

		// Token: 0x0401D28E RID: 119438
		[Token(Token = "0x401D28E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ApplyEquipTypeFilterParam;

		// Token: 0x0401D28F RID: 119439
		[Token(Token = "0x401D28F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplySortType;

		// Token: 0x0401D290 RID: 119440
		[Token(Token = "0x401D290")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplySortFilter;

		// Token: 0x0401D291 RID: 119441
		[Token(Token = "0x401D291")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SortViewModel;

		// Token: 0x0401D292 RID: 119442
		[Token(Token = "0x401D292")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
