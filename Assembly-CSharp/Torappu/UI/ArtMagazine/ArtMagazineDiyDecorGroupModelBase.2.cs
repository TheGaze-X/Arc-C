using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200657F RID: 25983
	[Token(Token = "0x200657F")]
	public abstract class ArtMagazineDiyDecorGroupModelBase<T> : ArtMagazineDiyDecorGroupModelBase where T : ArtMagazineDiyItemModelBase
	{
		// Token: 0x1700585B RID: 22619
		// (get) Token: 0x060255EF RID: 153071
		[Token(Token = "0x1700585B")]
		protected abstract ListDict<string, T> totalItemDict { [Token(Token = "0x60255EF")] get; }

		// Token: 0x1700585C RID: 22620
		// (get) Token: 0x060255F0 RID: 153072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700585C")]
		public override List<IArtMagazineDiyItemViewModel> displayItemList
		{
			[Token(Token = "0x60255F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700585D RID: 22621
		// (get) Token: 0x060255F1 RID: 153073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700585D")]
		public override HashSet<string> selectedItem
		{
			[Token(Token = "0x60255F1")]
			get
			{
				return null;
			}
		}

		// Token: 0x060255F2 RID: 153074
		[Token(Token = "0x60255F2")]
		protected abstract Comparison<T> GetComparisonBySortType(SorterType type);

		// Token: 0x060255F3 RID: 153075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255F3")]
		protected void RegenerateDisplayItemList()
		{
		}

		// Token: 0x060255F4 RID: 153076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255F4")]
		protected void SelectByLeafData(ArtMagazineLeafData leafData, ItemType itemType)
		{
		}

		// Token: 0x060255F5 RID: 153077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255F5")]
		public override void SetFilter(FilterGroupType filterGroupType, object filterParam)
		{
		}

		// Token: 0x060255F6 RID: 153078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255F6")]
		public override void SetSorter(SorterType sorterType)
		{
		}

		// Token: 0x060255F7 RID: 153079 RVA: 0x000C7B30 File Offset: 0x000C5D30
		[Token(Token = "0x60255F7")]
		public override bool IsItemSelected(string itemId, ItemType itemType, int templateId)
		{
			return default(bool);
		}

		// Token: 0x060255F8 RID: 153080 RVA: 0x000C7B48 File Offset: 0x000C5D48
		[Token(Token = "0x60255F8")]
		public override bool SelectItem(string id)
		{
			return default(bool);
		}

		// Token: 0x060255F9 RID: 153081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255F9")]
		public override void SwitchItemByLeafView(string itemId, ItemType itemType, int templateId, int newTemplateId)
		{
		}

		// Token: 0x060255FA RID: 153082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255FA")]
		public override void UnselectAll()
		{
		}

		// Token: 0x060255FB RID: 153083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255FB")]
		public override void UnselectItem(string id)
		{
		}

		// Token: 0x060255FC RID: 153084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255FC")]
		public override void UnselectItemByLeafView(string itemId, ItemType itemType, int templateId)
		{
		}

		// Token: 0x060255FD RID: 153085 RVA: 0x000C7B60 File Offset: 0x000C5D60
		[Token(Token = "0x60255FD")]
		private bool _SelectBySingleMode(string id)
		{
			return default(bool);
		}

		// Token: 0x060255FE RID: 153086 RVA: 0x000C7B78 File Offset: 0x000C5D78
		[Token(Token = "0x60255FE")]
		private bool _SelectByMultiMode(string validId)
		{
			return default(bool);
		}

		// Token: 0x060255FF RID: 153087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255FF")]
		protected ArtMagazineDiyDecorGroupModelBase()
		{
		}

		// Token: 0x040346F7 RID: 214775
		[Token(Token = "0x40346F7")]
		[FieldOffset(Offset = "0x0")]
		private List<IArtMagazineDiyItemViewModel> m_displayItemList;

		// Token: 0x040346F8 RID: 214776
		[Token(Token = "0x40346F8")]
		[FieldOffset(Offset = "0x0")]
		private HashSet<string> m_selectedItem;

		// Token: 0x040346F9 RID: 214777
		[Token(Token = "0x40346F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayItemList;

		// Token: 0x040346FA RID: 214778
		[Token(Token = "0x40346FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x040346FB RID: 214779
		[Token(Token = "0x40346FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegenerateDisplayItemList;

		// Token: 0x040346FC RID: 214780
		[Token(Token = "0x40346FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SelectByLeafData;

		// Token: 0x040346FD RID: 214781
		[Token(Token = "0x40346FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetFilter;

		// Token: 0x040346FE RID: 214782
		[Token(Token = "0x40346FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSorter;

		// Token: 0x040346FF RID: 214783
		[Token(Token = "0x40346FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsItemSelected;

		// Token: 0x04034700 RID: 214784
		[Token(Token = "0x4034700")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x04034701 RID: 214785
		[Token(Token = "0x4034701")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SwitchItemByLeafView;

		// Token: 0x04034702 RID: 214786
		[Token(Token = "0x4034702")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UnselectAll;

		// Token: 0x04034703 RID: 214787
		[Token(Token = "0x4034703")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UnselectItem;

		// Token: 0x04034704 RID: 214788
		[Token(Token = "0x4034704")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UnselectItemByLeafView;

		// Token: 0x04034705 RID: 214789
		[Token(Token = "0x4034705")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SelectBySingleMode;

		// Token: 0x04034706 RID: 214790
		[Token(Token = "0x4034706")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SelectByMultiMode;

		// Token: 0x04034707 RID: 214791
		[Token(Token = "0x4034707")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
