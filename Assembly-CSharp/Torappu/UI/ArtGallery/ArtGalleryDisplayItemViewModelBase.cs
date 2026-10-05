using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200664F RID: 26191
	[Token(Token = "0x200664F")]
	public abstract class ArtGalleryDisplayItemViewModelBase : IArtGalleryDisplayItemViewModel, IHotfixable
	{
		// Token: 0x170058FF RID: 22783
		// (get) Token: 0x060259B8 RID: 154040 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259B9 RID: 154041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058FF")]
		public string itemId
		{
			[Token(Token = "0x60259B8")]
			[Address(RVA = "0x208B7D0", Offset = "0x208A3D0", VA = "0x18208B7D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60259B9")]
			[Address(RVA = "0x208BC20", Offset = "0x208A820", VA = "0x18208BC20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005900 RID: 22784
		// (get) Token: 0x060259BA RID: 154042 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259BB RID: 154043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005900")]
		public string itemName
		{
			[Token(Token = "0x60259BA")]
			[Address(RVA = "0x208B830", Offset = "0x208A430", VA = "0x18208B830", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60259BB")]
			[Address(RVA = "0x208BCA0", Offset = "0x208A8A0", VA = "0x18208BCA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005901 RID: 22785
		// (get) Token: 0x060259BC RID: 154044 RVA: 0x000C87F0 File Offset: 0x000C69F0
		[Token(Token = "0x17005901")]
		public virtual bool isEmpty
		{
			[Token(Token = "0x60259BC")]
			[Address(RVA = "0x208B540", Offset = "0x208A140", VA = "0x18208B540", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005902 RID: 22786
		// (get) Token: 0x060259BD RID: 154045 RVA: 0x000C8808 File Offset: 0x000C6A08
		// (set) Token: 0x060259BE RID: 154046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005902")]
		public bool isCurSelect
		{
			[Token(Token = "0x60259BD")]
			[Address(RVA = "0x208B4E0", Offset = "0x208A0E0", VA = "0x18208B4E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60259BE")]
			[Address(RVA = "0x208B9D0", Offset = "0x208A5D0", VA = "0x18208B9D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005903 RID: 22787
		// (get) Token: 0x060259BF RID: 154047 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259C0 RID: 154048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005903")]
		public string itemGroupType
		{
			[Token(Token = "0x60259BF")]
			[Address(RVA = "0x208B770", Offset = "0x208A370", VA = "0x18208B770", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60259C0")]
			[Address(RVA = "0x208BBA0", Offset = "0x208A7A0", VA = "0x18208BBA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005904 RID: 22788
		// (get) Token: 0x060259C1 RID: 154049
		[Token(Token = "0x17005904")]
		public abstract ItemType itemType { [Token(Token = "0x60259C1")] get; }

		// Token: 0x17005905 RID: 22789
		// (get) Token: 0x060259C2 RID: 154050 RVA: 0x000C8820 File Offset: 0x000C6A20
		// (set) Token: 0x060259C3 RID: 154051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005905")]
		public int itemSortId
		{
			[Token(Token = "0x60259C2")]
			[Address(RVA = "0x208B890", Offset = "0x208A490", VA = "0x18208B890", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60259C3")]
			[Address(RVA = "0x208BD20", Offset = "0x208A920", VA = "0x18208BD20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005906 RID: 22790
		// (get) Token: 0x060259C4 RID: 154052 RVA: 0x000C8838 File Offset: 0x000C6A38
		// (set) Token: 0x060259C5 RID: 154053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005906")]
		public long availTs
		{
			[Token(Token = "0x60259C4")]
			[Address(RVA = "0x208B420", Offset = "0x208A020", VA = "0x18208B420", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60259C5")]
			[Address(RVA = "0x208B8F0", Offset = "0x208A4F0", VA = "0x18208B8F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005907 RID: 22791
		// (get) Token: 0x060259C6 RID: 154054 RVA: 0x000C8850 File Offset: 0x000C6A50
		// (set) Token: 0x060259C7 RID: 154055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005907")]
		public bool isSecret
		{
			[Token(Token = "0x60259C6")]
			[Address(RVA = "0x208B6B0", Offset = "0x208A2B0", VA = "0x18208B6B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60259C7")]
			[Address(RVA = "0x208BAB0", Offset = "0x208A6B0", VA = "0x18208BAB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005908 RID: 22792
		// (get) Token: 0x060259C8 RID: 154056 RVA: 0x000C8868 File Offset: 0x000C6A68
		// (set) Token: 0x060259C9 RID: 154057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005908")]
		public bool isLimit
		{
			[Token(Token = "0x60259C8")]
			[Address(RVA = "0x208B5F0", Offset = "0x208A1F0", VA = "0x18208B5F0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60259C9")]
			[Address(RVA = "0x208BA40", Offset = "0x208A640", VA = "0x18208BA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005909 RID: 22793
		// (get) Token: 0x060259CA RID: 154058 RVA: 0x000C8880 File Offset: 0x000C6A80
		[Token(Token = "0x17005909")]
		public virtual bool isLocked
		{
			[Token(Token = "0x60259CA")]
			[Address(RVA = "0x208B650", Offset = "0x208A250", VA = "0x18208B650", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700590A RID: 22794
		// (get) Token: 0x060259CB RID: 154059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259CC RID: 154060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700590A")]
		public string itemDesc
		{
			[Token(Token = "0x60259CB")]
			[Address(RVA = "0x208B710", Offset = "0x208A310", VA = "0x18208B710", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60259CC")]
			[Address(RVA = "0x208BB20", Offset = "0x208A720", VA = "0x18208BB20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700590B RID: 22795
		// (get) Token: 0x060259CD RID: 154061 RVA: 0x000C8898 File Offset: 0x000C6A98
		// (set) Token: 0x060259CE RID: 154062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700590B")]
		protected long cachedCurTs
		{
			[Token(Token = "0x60259CD")]
			[Address(RVA = "0x208B480", Offset = "0x208A080", VA = "0x18208B480")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60259CE")]
			[Address(RVA = "0x208B960", Offset = "0x208A560", VA = "0x18208B960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060259CF RID: 154063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259CF")]
		[Address(RVA = "0x208B020", Offset = "0x2089C20", VA = "0x18208B020", Slot = "21")]
		public virtual void LoadData(ArtGalleryItemData itemData, IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x060259D0 RID: 154064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259D0")]
		[Address(RVA = "0x208B270", Offset = "0x2089E70", VA = "0x18208B270", Slot = "22")]
		public virtual void RefreshData(IArtGalleryDisplayItemViewModel.ItemRefreshParam itemRefreshParam)
		{
		}

		// Token: 0x060259D1 RID: 154065 RVA: 0x000C88B0 File Offset: 0x000C6AB0
		[Token(Token = "0x60259D1")]
		[Address(RVA = "0x208AE90", Offset = "0x2089A90", VA = "0x18208AE90", Slot = "23")]
		protected virtual bool IsItemLegal()
		{
			return default(bool);
		}

		// Token: 0x060259D2 RID: 154066 RVA: 0x000C88C8 File Offset: 0x000C6AC8
		[Token(Token = "0x60259D2")]
		[Address(RVA = "0x208AD40", Offset = "0x2089940", VA = "0x18208AD40", Slot = "17")]
		public bool CheckCanItemShow(ArtGalleryDisplayViewModel.ArtGalleryShuffleRule shuffleRule)
		{
			return default(bool);
		}

		// Token: 0x060259D3 RID: 154067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259D3")]
		[Address(RVA = "0x208B3C0", Offset = "0x2089FC0", VA = "0x18208B3C0")]
		protected ArtGalleryDisplayItemViewModelBase()
		{
		}

		// Token: 0x04034D67 RID: 216423
		[Token(Token = "0x4034D67")]
		[FieldOffset(Offset = "0x42")]
		public bool hasItem;

		// Token: 0x04034D6A RID: 216426
		[Token(Token = "0x4034D6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x04034D6B RID: 216427
		[Token(Token = "0x4034D6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemId;

		// Token: 0x04034D6C RID: 216428
		[Token(Token = "0x4034D6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemName;

		// Token: 0x04034D6D RID: 216429
		[Token(Token = "0x4034D6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemName;

		// Token: 0x04034D6E RID: 216430
		[Token(Token = "0x4034D6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04034D6F RID: 216431
		[Token(Token = "0x4034D6F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isCurSelect;

		// Token: 0x04034D70 RID: 216432
		[Token(Token = "0x4034D70")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_isCurSelect;

		// Token: 0x04034D71 RID: 216433
		[Token(Token = "0x4034D71")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_itemGroupType;

		// Token: 0x04034D72 RID: 216434
		[Token(Token = "0x4034D72")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_itemGroupType;

		// Token: 0x04034D73 RID: 216435
		[Token(Token = "0x4034D73")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_itemSortId;

		// Token: 0x04034D74 RID: 216436
		[Token(Token = "0x4034D74")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_itemSortId;

		// Token: 0x04034D75 RID: 216437
		[Token(Token = "0x4034D75")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_availTs;

		// Token: 0x04034D76 RID: 216438
		[Token(Token = "0x4034D76")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_availTs;

		// Token: 0x04034D77 RID: 216439
		[Token(Token = "0x4034D77")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isSecret;

		// Token: 0x04034D78 RID: 216440
		[Token(Token = "0x4034D78")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_isSecret;

		// Token: 0x04034D79 RID: 216441
		[Token(Token = "0x4034D79")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isLimit;

		// Token: 0x04034D7A RID: 216442
		[Token(Token = "0x4034D7A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_isLimit;

		// Token: 0x04034D7B RID: 216443
		[Token(Token = "0x4034D7B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x04034D7C RID: 216444
		[Token(Token = "0x4034D7C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_itemDesc;

		// Token: 0x04034D7D RID: 216445
		[Token(Token = "0x4034D7D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_itemDesc;

		// Token: 0x04034D7E RID: 216446
		[Token(Token = "0x4034D7E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_cachedCurTs;

		// Token: 0x04034D7F RID: 216447
		[Token(Token = "0x4034D7F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_cachedCurTs;

		// Token: 0x04034D80 RID: 216448
		[Token(Token = "0x4034D80")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034D81 RID: 216449
		[Token(Token = "0x4034D81")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034D82 RID: 216450
		[Token(Token = "0x4034D82")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_IsItemLegal;

		// Token: 0x04034D83 RID: 216451
		[Token(Token = "0x4034D83")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CheckCanItemShow;

		// Token: 0x04034D84 RID: 216452
		[Token(Token = "0x4034D84")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
