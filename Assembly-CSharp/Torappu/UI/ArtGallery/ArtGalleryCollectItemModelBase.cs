using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006627 RID: 26151
	[Token(Token = "0x2006627")]
	public abstract class ArtGalleryCollectItemModelBase : IHotfixable, IComparable<ArtGalleryCollectItemModelBase>
	{
		// Token: 0x170058B9 RID: 22713
		// (get) Token: 0x060258DB RID: 153819 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060258DC RID: 153820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B9")]
		public string itemId
		{
			[Token(Token = "0x60258DB")]
			[Address(RVA = "0x207C600", Offset = "0x207B200", VA = "0x18207C600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60258DC")]
			[Address(RVA = "0x207C8B0", Offset = "0x207B4B0", VA = "0x18207C8B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170058BA RID: 22714
		// (get) Token: 0x060258DD RID: 153821 RVA: 0x000C8388 File Offset: 0x000C6588
		// (set) Token: 0x060258DE RID: 153822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058BA")]
		public ItemType itemType
		{
			[Token(Token = "0x60258DD")]
			[Address(RVA = "0x207C6C0", Offset = "0x207B2C0", VA = "0x18207C6C0")]
			[CompilerGenerated]
			get
			{
				return ItemType.NONE;
			}
			[Token(Token = "0x60258DE")]
			[Address(RVA = "0x207C9B0", Offset = "0x207B5B0", VA = "0x18207C9B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170058BB RID: 22715
		// (get) Token: 0x060258DF RID: 153823 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060258E0 RID: 153824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058BB")]
		public string itemName
		{
			[Token(Token = "0x60258DF")]
			[Address(RVA = "0x207C660", Offset = "0x207B260", VA = "0x18207C660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60258E0")]
			[Address(RVA = "0x207C930", Offset = "0x207B530", VA = "0x18207C930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170058BC RID: 22716
		// (get) Token: 0x060258E1 RID: 153825 RVA: 0x000C83A0 File Offset: 0x000C65A0
		// (set) Token: 0x060258E2 RID: 153826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058BC")]
		public int sortId
		{
			[Token(Token = "0x60258E1")]
			[Address(RVA = "0x207C780", Offset = "0x207B380", VA = "0x18207C780")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60258E2")]
			[Address(RVA = "0x207CAA0", Offset = "0x207B6A0", VA = "0x18207CAA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170058BD RID: 22717
		// (get) Token: 0x060258E3 RID: 153827 RVA: 0x000C83B8 File Offset: 0x000C65B8
		// (set) Token: 0x060258E4 RID: 153828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058BD")]
		public bool unlocked
		{
			[Token(Token = "0x60258E3")]
			[Address(RVA = "0x207C7E0", Offset = "0x207B3E0", VA = "0x18207C7E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60258E4")]
			[Address(RVA = "0x207CB10", Offset = "0x207B710", VA = "0x18207CB10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170058BE RID: 22718
		// (get) Token: 0x060258E5 RID: 153829 RVA: 0x000C83D0 File Offset: 0x000C65D0
		// (set) Token: 0x060258E6 RID: 153830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058BE")]
		public bool canPreview
		{
			[Token(Token = "0x60258E5")]
			[Address(RVA = "0x207C5A0", Offset = "0x207B1A0", VA = "0x18207C5A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60258E6")]
			[Address(RVA = "0x207C840", Offset = "0x207B440", VA = "0x18207C840")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170058BF RID: 22719
		// (get) Token: 0x060258E7 RID: 153831 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060258E8 RID: 153832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058BF")]
		public string relateSetId
		{
			[Token(Token = "0x60258E7")]
			[Address(RVA = "0x207C720", Offset = "0x207B320", VA = "0x18207C720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60258E8")]
			[Address(RVA = "0x207CA20", Offset = "0x207B620", VA = "0x18207CA20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060258E9 RID: 153833 RVA: 0x000C83E8 File Offset: 0x000C65E8
		[Token(Token = "0x60258E9")]
		[Address(RVA = "0x207BF70", Offset = "0x207AB70", VA = "0x18207BF70", Slot = "4")]
		public int CompareTo(ArtGalleryCollectItemModelBase other)
		{
			return 0;
		}

		// Token: 0x060258EA RID: 153834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258EA")]
		[Address(RVA = "0x207C0A0", Offset = "0x207ACA0", VA = "0x18207C0A0")]
		public void LoadData(ArtGalleryCollectItemData data, string setId)
		{
		}

		// Token: 0x060258EB RID: 153835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258EB")]
		[Address(RVA = "0x207C380", Offset = "0x207AF80", VA = "0x18207C380")]
		public void UpdateData()
		{
		}

		// Token: 0x060258EC RID: 153836
		[Token(Token = "0x60258EC")]
		protected abstract void _LoadDataByType();

		// Token: 0x060258ED RID: 153837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258ED")]
		[Address(RVA = "0x207C4E0", Offset = "0x207B0E0", VA = "0x18207C4E0", Slot = "6")]
		protected virtual void _UpdateDataByType()
		{
		}

		// Token: 0x060258EE RID: 153838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258EE")]
		[Address(RVA = "0x207C540", Offset = "0x207B140", VA = "0x18207C540")]
		protected ArtGalleryCollectItemModelBase()
		{
		}

		// Token: 0x04034C30 RID: 216112
		[Token(Token = "0x4034C30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x04034C31 RID: 216113
		[Token(Token = "0x4034C31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemId;

		// Token: 0x04034C32 RID: 216114
		[Token(Token = "0x4034C32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04034C33 RID: 216115
		[Token(Token = "0x4034C33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemType;

		// Token: 0x04034C34 RID: 216116
		[Token(Token = "0x4034C34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_itemName;

		// Token: 0x04034C35 RID: 216117
		[Token(Token = "0x4034C35")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_itemName;

		// Token: 0x04034C36 RID: 216118
		[Token(Token = "0x4034C36")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04034C37 RID: 216119
		[Token(Token = "0x4034C37")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x04034C38 RID: 216120
		[Token(Token = "0x4034C38")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_unlocked;

		// Token: 0x04034C39 RID: 216121
		[Token(Token = "0x4034C39")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_unlocked;

		// Token: 0x04034C3A RID: 216122
		[Token(Token = "0x4034C3A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_canPreview;

		// Token: 0x04034C3B RID: 216123
		[Token(Token = "0x4034C3B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_canPreview;

		// Token: 0x04034C3C RID: 216124
		[Token(Token = "0x4034C3C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_relateSetId;

		// Token: 0x04034C3D RID: 216125
		[Token(Token = "0x4034C3D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_relateSetId;

		// Token: 0x04034C3E RID: 216126
		[Token(Token = "0x4034C3E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04034C3F RID: 216127
		[Token(Token = "0x4034C3F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034C40 RID: 216128
		[Token(Token = "0x4034C40")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04034C41 RID: 216129
		[Token(Token = "0x4034C41")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateDataByType;

		// Token: 0x04034C42 RID: 216130
		[Token(Token = "0x4034C42")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
