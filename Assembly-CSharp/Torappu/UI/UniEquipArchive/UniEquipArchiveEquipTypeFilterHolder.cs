using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BC5 RID: 15301
	[Token(Token = "0x2003BC5")]
	public class UniEquipArchiveEquipTypeFilterHolder : UICharacterFilterHolder
	{
		// Token: 0x06017F57 RID: 98135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F57")]
		[Address(RVA = "0x1063190", Offset = "0x1061D90", VA = "0x181063190")]
		protected void OnCreate()
		{
		}

		// Token: 0x06017F58 RID: 98136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F58")]
		[Address(RVA = "0x1063360", Offset = "0x1061F60", VA = "0x181063360")]
		public void OnTypeFilterClick()
		{
		}

		// Token: 0x06017F59 RID: 98137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F59")]
		[Address(RVA = "0x1063470", Offset = "0x1062070", VA = "0x181063470")]
		public void ResetData()
		{
		}

		// Token: 0x06017F5A RID: 98138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F5A")]
		[Address(RVA = "0x10635A0", Offset = "0x10621A0", VA = "0x1810635A0")]
		private void _ApplyData()
		{
		}

		// Token: 0x06017F5B RID: 98139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F5B")]
		[Address(RVA = "0x1063760", Offset = "0x1062360", VA = "0x181063760")]
		private void _OnFilterTypeItemClick(string type)
		{
		}

		// Token: 0x06017F5C RID: 98140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F5C")]
		[Address(RVA = "0x1063840", Offset = "0x1062440", VA = "0x181063840")]
		private void _OnTypeFilterBgClick()
		{
		}

		// Token: 0x06017F5D RID: 98141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F5D")]
		[Address(RVA = "0x1063950", Offset = "0x1062550", VA = "0x181063950")]
		public UniEquipArchiveEquipTypeFilterHolder()
		{
		}

		// Token: 0x0401CFDD RID: 118749
		[Token(Token = "0x401CFDD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UniEquipArchiveEquipTypeFilterView _filterView;

		// Token: 0x0401CFDE RID: 118750
		[Token(Token = "0x401CFDE")]
		[FieldOffset(Offset = "0x30")]
		private UniEquipArchiveModuleTypeFilterViewProperty m_prop;

		// Token: 0x0401CFDF RID: 118751
		[Token(Token = "0x401CFDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401CFE0 RID: 118752
		[Token(Token = "0x401CFE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTypeFilterClick;

		// Token: 0x0401CFE1 RID: 118753
		[Token(Token = "0x401CFE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetData;

		// Token: 0x0401CFE2 RID: 118754
		[Token(Token = "0x401CFE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyData;

		// Token: 0x0401CFE3 RID: 118755
		[Token(Token = "0x401CFE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnFilterTypeItemClick;

		// Token: 0x0401CFE4 RID: 118756
		[Token(Token = "0x401CFE4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnTypeFilterBgClick;

		// Token: 0x0401CFE5 RID: 118757
		[Token(Token = "0x401CFE5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BC6 RID: 15302
		[Token(Token = "0x2003BC6")]
		public class FilterParam : IHotfixable
		{
			// Token: 0x06017F5E RID: 98142 RVA: 0x00098C28 File Offset: 0x00096E28
			[Token(Token = "0x6017F5E")]
			[Address(RVA = "0x105EF30", Offset = "0x105DB30", VA = "0x18105EF30")]
			public bool IsIncludeByTypeFilter(string typeName)
			{
				return default(bool);
			}

			// Token: 0x06017F5F RID: 98143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F5F")]
			[Address(RVA = "0x105F040", Offset = "0x105DC40", VA = "0x18105F040")]
			public FilterParam()
			{
			}

			// Token: 0x0401CFE6 RID: 118758
			[Token(Token = "0x401CFE6")]
			[FieldOffset(Offset = "0x10")]
			public UniEquipArchiveModuleTYpeFilterItemInfoData infoData;

			// Token: 0x0401CFE7 RID: 118759
			[Token(Token = "0x401CFE7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsIncludeByTypeFilter;

			// Token: 0x0401CFE8 RID: 118760
			[Token(Token = "0x401CFE8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003BC7 RID: 15303
		[Token(Token = "0x2003BC7")]
		public struct Builder
		{
			// Token: 0x06017F60 RID: 98144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017F60")]
			[Address(RVA = "0x105E490", Offset = "0x105D090", VA = "0x18105E490")]
			public UniEquipArchiveEquipTypeFilterHolder Build()
			{
				return null;
			}

			// Token: 0x0401CFE9 RID: 118761
			[Token(Token = "0x401CFE9")]
			[FieldOffset(Offset = "0x0")]
			public UniEquipArchiveEquipTypeFilterHolder prefab;

			// Token: 0x0401CFEA RID: 118762
			[Token(Token = "0x401CFEA")]
			[FieldOffset(Offset = "0x8")]
			public RectTransform container;

			// Token: 0x0401CFEB RID: 118763
			[Token(Token = "0x401CFEB")]
			[FieldOffset(Offset = "0x10")]
			public ILoadAsset assetLoader;

			// Token: 0x0401CFEC RID: 118764
			[Token(Token = "0x401CFEC")]
			[FieldOffset(Offset = "0x18")]
			public UICharacterFilterHolder.IFilterHandler filterHandler;
		}
	}
}
