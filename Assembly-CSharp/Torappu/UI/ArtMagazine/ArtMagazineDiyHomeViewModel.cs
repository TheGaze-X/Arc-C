using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006583 RID: 25987
	[Token(Token = "0x2006583")]
	public class ArtMagazineDiyHomeViewModel : IHotfixable
	{
		// Token: 0x1700585E RID: 22622
		// (get) Token: 0x06025602 RID: 153090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700585E")]
		public ArtMagazineLeafData cachedLeafData
		{
			[Token(Token = "0x6025602")]
			[Address(RVA = "0x2049CE0", Offset = "0x20488E0", VA = "0x182049CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025603 RID: 153091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025603")]
		[Address(RVA = "0x20479C0", Offset = "0x20465C0", VA = "0x1820479C0")]
		public void LoadData(string leafId)
		{
		}

		// Token: 0x06025604 RID: 153092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025604")]
		[Address(RVA = "0x20487A0", Offset = "0x20473A0", VA = "0x1820487A0")]
		public void RefreshData(string leafId)
		{
		}

		// Token: 0x06025605 RID: 153093 RVA: 0x000C7BA8 File Offset: 0x000C5DA8
		[Token(Token = "0x6025605")]
		[Address(RVA = "0x2047790", Offset = "0x2046390", VA = "0x182047790")]
		public bool ApplyPresetData(string leafId)
		{
			return default(bool);
		}

		// Token: 0x06025606 RID: 153094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025606")]
		[Address(RVA = "0x2049210", Offset = "0x2047E10", VA = "0x182049210")]
		private void _RefreshData(ArtMagazineLeafData leafData, bool needCacheData)
		{
		}

		// Token: 0x06025607 RID: 153095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025607")]
		[Address(RVA = "0x2047900", Offset = "0x2046500", VA = "0x182047900")]
		public IArtMagazineDiyRecycleGroupViewModel GetDiyGroupModelByItemType(ItemType type)
		{
			return null;
		}

		// Token: 0x06025608 RID: 153096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025608")]
		[Address(RVA = "0x2048850", Offset = "0x2047450", VA = "0x182048850")]
		public void SelectItem(IArtMagazineDiyItemViewModel itemModel)
		{
		}

		// Token: 0x06025609 RID: 153097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025609")]
		[Address(RVA = "0x2048AE0", Offset = "0x20476E0", VA = "0x182048AE0")]
		public void SwitchItemByLeafView(string itemId, ItemType itemType, int oldTemplateId, int newTemplateId)
		{
		}

		// Token: 0x0602560A RID: 153098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602560A")]
		[Address(RVA = "0x2049080", Offset = "0x2047C80", VA = "0x182049080")]
		public void UnselectItem(IArtMagazineDiyItemViewModel itemModel)
		{
		}

		// Token: 0x0602560B RID: 153099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602560B")]
		[Address(RVA = "0x2048F10", Offset = "0x2047B10", VA = "0x182048F10")]
		public void UnselectItemByLeafView(string itemId, ItemType itemType, int templateId)
		{
		}

		// Token: 0x0602560C RID: 153100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602560C")]
		[Address(RVA = "0x2049170", Offset = "0x2047D70", VA = "0x182049170")]
		public void UnselectType(ItemType type)
		{
		}

		// Token: 0x0602560D RID: 153101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602560D")]
		[Address(RVA = "0x2048DB0", Offset = "0x20479B0", VA = "0x182048DB0")]
		public void UnselectAll()
		{
		}

		// Token: 0x0602560E RID: 153102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602560E")]
		[Address(RVA = "0x20485B0", Offset = "0x20471B0", VA = "0x1820485B0")]
		public void RecordSkinLayoutInfo(ArtMagazineDiyLeafViewModel.SkinLayoutData info)
		{
		}

		// Token: 0x0602560F RID: 153103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602560F")]
		[Address(RVA = "0x20484A0", Offset = "0x20470A0", VA = "0x1820484A0")]
		public void RecordSelectingSkinId(string skinId, int templateId)
		{
		}

		// Token: 0x06025610 RID: 153104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025610")]
		[Address(RVA = "0x2047540", Offset = "0x2046140", VA = "0x182047540")]
		public void ApplyCacheSelectingSkin()
		{
		}

		// Token: 0x06025611 RID: 153105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025611")]
		[Address(RVA = "0x2049610", Offset = "0x2048210", VA = "0x182049610")]
		private void _RefreshLeafViewSelectedItem()
		{
		}

		// Token: 0x06025612 RID: 153106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025612")]
		[Address(RVA = "0x2049B50", Offset = "0x2048750", VA = "0x182049B50")]
		public ArtMagazineDiyHomeViewModel()
		{
		}

		// Token: 0x04034715 RID: 214805
		[Token(Token = "0x4034715")]
		[FieldOffset(Offset = "0x10")]
		public bool isLeafViewSmallSize;

		// Token: 0x04034716 RID: 214806
		[Token(Token = "0x4034716")]
		[FieldOffset(Offset = "0x14")]
		public int enterSeqNum;

		// Token: 0x04034717 RID: 214807
		[Token(Token = "0x4034717")]
		[FieldOffset(Offset = "0x18")]
		public ArtMagazineDiyDecorTabType selectedTab;

		// Token: 0x04034718 RID: 214808
		[Token(Token = "0x4034718")]
		[FieldOffset(Offset = "0x1C")]
		public ArtMagazineLeafViewDisplayType displayType;

		// Token: 0x04034719 RID: 214809
		[Token(Token = "0x4034719")]
		[FieldOffset(Offset = "0x20")]
		public ArtMagazineDiyLeafViewModel diyLeafViewModel;

		// Token: 0x0403471A RID: 214810
		[Token(Token = "0x403471A")]
		[FieldOffset(Offset = "0x28")]
		public string cacheSelectingSkinId;

		// Token: 0x0403471B RID: 214811
		[Token(Token = "0x403471B")]
		[FieldOffset(Offset = "0x30")]
		public int cacheSelectingSkinTemplateId;

		// Token: 0x0403471C RID: 214812
		[Token(Token = "0x403471C")]
		[FieldOffset(Offset = "0x34")]
		public int leafVersion;

		// Token: 0x0403471D RID: 214813
		[Token(Token = "0x403471D")]
		[FieldOffset(Offset = "0x38")]
		private EnumIntDictionary<ItemType, IArtMagazineDiyRecycleGroupViewModel> m_groupViewModelDict;

		// Token: 0x0403471E RID: 214814
		[Token(Token = "0x403471E")]
		[FieldOffset(Offset = "0x40")]
		private ArtMagazineLeafData m_cachedLeafData;

		// Token: 0x0403471F RID: 214815
		[Token(Token = "0x403471F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cachedLeafData;

		// Token: 0x04034720 RID: 214816
		[Token(Token = "0x4034720")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034721 RID: 214817
		[Token(Token = "0x4034721")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034722 RID: 214818
		[Token(Token = "0x4034722")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyPresetData;

		// Token: 0x04034723 RID: 214819
		[Token(Token = "0x4034723")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x04034724 RID: 214820
		[Token(Token = "0x4034724")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDiyGroupModelByItemType;

		// Token: 0x04034725 RID: 214821
		[Token(Token = "0x4034725")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x04034726 RID: 214822
		[Token(Token = "0x4034726")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SwitchItemByLeafView;

		// Token: 0x04034727 RID: 214823
		[Token(Token = "0x4034727")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UnselectItem;

		// Token: 0x04034728 RID: 214824
		[Token(Token = "0x4034728")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UnselectItemByLeafView;

		// Token: 0x04034729 RID: 214825
		[Token(Token = "0x4034729")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UnselectType;

		// Token: 0x0403472A RID: 214826
		[Token(Token = "0x403472A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UnselectAll;

		// Token: 0x0403472B RID: 214827
		[Token(Token = "0x403472B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RecordSkinLayoutInfo;

		// Token: 0x0403472C RID: 214828
		[Token(Token = "0x403472C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RecordSelectingSkinId;

		// Token: 0x0403472D RID: 214829
		[Token(Token = "0x403472D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ApplyCacheSelectingSkin;

		// Token: 0x0403472E RID: 214830
		[Token(Token = "0x403472E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RefreshLeafViewSelectedItem;

		// Token: 0x0403472F RID: 214831
		[Token(Token = "0x403472F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
