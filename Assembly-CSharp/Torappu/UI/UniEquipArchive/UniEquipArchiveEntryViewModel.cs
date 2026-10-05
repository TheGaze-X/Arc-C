using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003C00 RID: 15360
	[Token(Token = "0x2003C00")]
	public class UniEquipArchiveEntryViewModel : IHotfixable
	{
		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0601804A RID: 98378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003946")]
		public List<UniEquipArchiveEntryCollectionInfoItemViewModel> infoItemViewModels
		{
			[Token(Token = "0x601804A")]
			[Address(RVA = "0x107FF80", Offset = "0x107EB80", VA = "0x18107FF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0601804B RID: 98379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003947")]
		public List<UniEquipArchiveEntryCollectionNewEditionItemViewModel> newEditionItemViewModels
		{
			[Token(Token = "0x601804B")]
			[Address(RVA = "0x107FFE0", Offset = "0x107EBE0", VA = "0x18107FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0601804C RID: 98380 RVA: 0x00098F28 File Offset: 0x00097128
		// (set) Token: 0x0601804D RID: 98381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003948")]
		public bool showCollectionsTotalInfo
		{
			[Token(Token = "0x601804C")]
			[Address(RVA = "0x10800B0", Offset = "0x107ECB0", VA = "0x1810800B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601804D")]
			[Address(RVA = "0x1080110", Offset = "0x107ED10", VA = "0x181080110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0601804E RID: 98382 RVA: 0x00098F40 File Offset: 0x00097140
		[Token(Token = "0x17003949")]
		public int newEditionUniEquipCount
		{
			[Token(Token = "0x601804E")]
			[Address(RVA = "0x1080040", Offset = "0x107EC40", VA = "0x181080040")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0601804F RID: 98383 RVA: 0x00098F58 File Offset: 0x00097158
		[Token(Token = "0x1700394A")]
		public int enterSeq
		{
			[Token(Token = "0x601804F")]
			[Address(RVA = "0x107FF20", Offset = "0x107EB20", VA = "0x18107FF20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06018050 RID: 98384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018050")]
		[Address(RVA = "0x107E9B0", Offset = "0x107D5B0", VA = "0x18107E9B0")]
		public void LoadData()
		{
		}

		// Token: 0x06018051 RID: 98385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018051")]
		[Address(RVA = "0x107EA70", Offset = "0x107D670", VA = "0x18107EA70")]
		public void RefreshData()
		{
		}

		// Token: 0x06018052 RID: 98386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018052")]
		[Address(RVA = "0x107EB00", Offset = "0x107D700", VA = "0x18107EB00")]
		public void RefreshShowCollectionsTotalInfo(bool showTotalInfo)
		{
		}

		// Token: 0x06018053 RID: 98387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018053")]
		[Address(RVA = "0x107ECD0", Offset = "0x107D8D0", VA = "0x18107ECD0")]
		public UniEquipArchiveEntryCollectionNewEditionItemViewModel TryGetNewEditionItemViewModel(string uniEquipId)
		{
			return null;
		}

		// Token: 0x06018054 RID: 98388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018054")]
		[Address(RVA = "0x107F060", Offset = "0x107DC60", VA = "0x18107F060")]
		private void _LoadBasicInfoItemViewModels()
		{
		}

		// Token: 0x06018055 RID: 98389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018055")]
		[Address(RVA = "0x107F700", Offset = "0x107E300", VA = "0x18107F700")]
		private void _RefreshBasicInfoItemViewModels()
		{
		}

		// Token: 0x06018056 RID: 98390 RVA: 0x00098F70 File Offset: 0x00097170
		[Token(Token = "0x6018056")]
		[Address(RVA = "0x107EE10", Offset = "0x107DA10", VA = "0x18107EE10")]
		private UniEquipArchiveEntryCollectionInfoData _GenInfoDataByType(UniEquipArchiveCollectionInfoType collectionInfoType)
		{
			return default(UniEquipArchiveEntryCollectionInfoData);
		}

		// Token: 0x06018057 RID: 98391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018057")]
		[Address(RVA = "0x107F280", Offset = "0x107DE80", VA = "0x18107F280")]
		private void _LoadNewEditionItemList()
		{
		}

		// Token: 0x06018058 RID: 98392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018058")]
		[Address(RVA = "0x107F930", Offset = "0x107E530", VA = "0x18107F930")]
		private void _RefreshNewEditionItemListState()
		{
		}

		// Token: 0x06018059 RID: 98393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018059")]
		[Address(RVA = "0x107FD40", Offset = "0x107E940", VA = "0x18107FD40")]
		public UniEquipArchiveEntryViewModel()
		{
		}

		// Token: 0x0401D1DF RID: 119263
		[Token(Token = "0x401D1DF")]
		[FieldOffset(Offset = "0x18")]
		private List<UniEquipArchiveEntryCollectionInfoItemViewModel> m_infoItemViewModelList;

		// Token: 0x0401D1E0 RID: 119264
		[Token(Token = "0x401D1E0")]
		[FieldOffset(Offset = "0x20")]
		private List<UniEquipArchiveEntryCollectionNewEditionItemViewModel> m_newEditionItemViewModelList;

		// Token: 0x0401D1E1 RID: 119265
		[Token(Token = "0x401D1E1")]
		[FieldOffset(Offset = "0x28")]
		private UniEquipArchiveCollectionInfoViewModel m_collectionInfoViewModel;

		// Token: 0x0401D1E2 RID: 119266
		[Token(Token = "0x401D1E2")]
		[FieldOffset(Offset = "0x30")]
		private int m_enterSeq;

		// Token: 0x0401D1E3 RID: 119267
		[Token(Token = "0x401D1E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_infoItemViewModels;

		// Token: 0x0401D1E4 RID: 119268
		[Token(Token = "0x401D1E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_newEditionItemViewModels;

		// Token: 0x0401D1E5 RID: 119269
		[Token(Token = "0x401D1E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showCollectionsTotalInfo;

		// Token: 0x0401D1E6 RID: 119270
		[Token(Token = "0x401D1E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_showCollectionsTotalInfo;

		// Token: 0x0401D1E7 RID: 119271
		[Token(Token = "0x401D1E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_newEditionUniEquipCount;

		// Token: 0x0401D1E8 RID: 119272
		[Token(Token = "0x401D1E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x0401D1E9 RID: 119273
		[Token(Token = "0x401D1E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D1EA RID: 119274
		[Token(Token = "0x401D1EA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401D1EB RID: 119275
		[Token(Token = "0x401D1EB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshShowCollectionsTotalInfo;

		// Token: 0x0401D1EC RID: 119276
		[Token(Token = "0x401D1EC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetNewEditionItemViewModel;

		// Token: 0x0401D1ED RID: 119277
		[Token(Token = "0x401D1ED")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadBasicInfoItemViewModels;

		// Token: 0x0401D1EE RID: 119278
		[Token(Token = "0x401D1EE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RefreshBasicInfoItemViewModels;

		// Token: 0x0401D1EF RID: 119279
		[Token(Token = "0x401D1EF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenInfoDataByType;

		// Token: 0x0401D1F0 RID: 119280
		[Token(Token = "0x401D1F0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadNewEditionItemList;

		// Token: 0x0401D1F1 RID: 119281
		[Token(Token = "0x401D1F1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RefreshNewEditionItemListState;

		// Token: 0x0401D1F2 RID: 119282
		[Token(Token = "0x401D1F2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
