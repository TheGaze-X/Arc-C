using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200657E RID: 25982
	[Token(Token = "0x200657E")]
	public abstract class ArtMagazineDiyDecorGroupModelBase : IArtMagazineDiyRecycleGroupViewModel, IHotfixable
	{
		// Token: 0x17005856 RID: 22614
		// (get) Token: 0x060255DE RID: 153054
		[Token(Token = "0x17005856")]
		public abstract List<IArtMagazineDiyItemViewModel> displayItemList { [Token(Token = "0x60255DE")] get; }

		// Token: 0x17005857 RID: 22615
		// (get) Token: 0x060255DF RID: 153055
		[Token(Token = "0x17005857")]
		public abstract HashSet<string> selectedItem { [Token(Token = "0x60255DF")] get; }

		// Token: 0x17005858 RID: 22616
		// (get) Token: 0x060255E0 RID: 153056
		[Token(Token = "0x17005858")]
		public abstract int itemMaxSelectNum { [Token(Token = "0x60255E0")] get; }

		// Token: 0x17005859 RID: 22617
		// (get) Token: 0x060255E1 RID: 153057
		// (set) Token: 0x060255E2 RID: 153058
		[Token(Token = "0x17005859")]
		public abstract SorterType sorter { [Token(Token = "0x60255E1")] get; [Token(Token = "0x60255E2")] set; }

		// Token: 0x1700585A RID: 22618
		// (get) Token: 0x060255E3 RID: 153059
		[Token(Token = "0x1700585A")]
		public abstract EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> filterDict { [Token(Token = "0x60255E3")] get; }

		// Token: 0x060255E4 RID: 153060
		[Token(Token = "0x60255E4")]
		public abstract bool IsItemSelected(string itemId, ItemType itemType, int templateId);

		// Token: 0x060255E5 RID: 153061
		[Token(Token = "0x60255E5")]
		public abstract void LoadData(string leafId);

		// Token: 0x060255E6 RID: 153062
		[Token(Token = "0x60255E6")]
		public abstract void RefreshData(ArtMagazineLeafData leafData);

		// Token: 0x060255E7 RID: 153063
		[Token(Token = "0x60255E7")]
		public abstract bool SelectItem(string id);

		// Token: 0x060255E8 RID: 153064
		[Token(Token = "0x60255E8")]
		public abstract void SwitchItemByLeafView(string itemId, ItemType itemType, int oldTemplateId, int newTemplateId);

		// Token: 0x060255E9 RID: 153065
		[Token(Token = "0x60255E9")]
		public abstract void SetFilter(FilterGroupType filterGroupType, object filterParam);

		// Token: 0x060255EA RID: 153066
		[Token(Token = "0x60255EA")]
		public abstract void SetSorter(SorterType sorterType);

		// Token: 0x060255EB RID: 153067
		[Token(Token = "0x60255EB")]
		public abstract void UnselectAll();

		// Token: 0x060255EC RID: 153068
		[Token(Token = "0x60255EC")]
		public abstract void UnselectItem(string id);

		// Token: 0x060255ED RID: 153069
		[Token(Token = "0x60255ED")]
		public abstract void UnselectItemByLeafView(string itemId, ItemType itemType, int templateId);

		// Token: 0x060255EE RID: 153070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255EE")]
		[Address(RVA = "0x2043990", Offset = "0x2042590", VA = "0x182043990")]
		protected ArtMagazineDiyDecorGroupModelBase()
		{
		}

		// Token: 0x040346F6 RID: 214774
		[Token(Token = "0x40346F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
