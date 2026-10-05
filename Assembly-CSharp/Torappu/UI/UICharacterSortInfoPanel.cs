using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200354B RID: 13643
	[Token(Token = "0x200354B")]
	public class UICharacterSortInfoPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015BD9 RID: 89049 RVA: 0x0008DA68 File Offset: 0x0008BC68
		[Token(Token = "0x6015BD9")]
		[Address(RVA = "0xE53BC0", Offset = "0xE527C0", VA = "0x180E53BC0")]
		public bool RenderSortInfo(CharacterCardViewModel viewModel, CharacterSortType sortType)
		{
			return default(bool);
		}

		// Token: 0x06015BDA RID: 89050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BDA")]
		[Address(RVA = "0xE545A0", Offset = "0xE531A0", VA = "0x180E545A0")]
		private void _RenderCustomStyle(CharacterSortType sortType, CharCardSortInfoStyleData style)
		{
		}

		// Token: 0x06015BDB RID: 89051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BDB")]
		[Address(RVA = "0xE54750", Offset = "0xE53350", VA = "0x180E54750")]
		private void _RenderDefault(CharacterSortType sortType)
		{
		}

		// Token: 0x06015BDC RID: 89052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BDC")]
		[Address(RVA = "0xE54800", Offset = "0xE53400", VA = "0x180E54800")]
		private void _RenderHandBookStageStyle(CharacterSortType sortType, CharCardSortInfoStyleData style)
		{
		}

		// Token: 0x06015BDD RID: 89053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BDD")]
		[Address(RVA = "0xE54A80", Offset = "0xE53680", VA = "0x180E54A80")]
		private void _SetHandBookCustomTextColor(Color textColor)
		{
		}

		// Token: 0x06015BDE RID: 89054 RVA: 0x0008DA80 File Offset: 0x0008BC80
		[Token(Token = "0x6015BDE")]
		[Address(RVA = "0xE54410", Offset = "0xE53010", VA = "0x180E54410")]
		private Color _GetHandBookCustomMaskColor(CharacterHandbookStageStatus status, CharCardSortInfoStyleData style)
		{
			return default(Color);
		}

		// Token: 0x06015BDF RID: 89055 RVA: 0x0008DA98 File Offset: 0x0008BC98
		[Token(Token = "0x6015BDF")]
		[Address(RVA = "0xE54B80", Offset = "0xE53780", VA = "0x180E54B80")]
		private CharCardSortInfoStyleData _TryGetSortInfoStyle(CharacterSortType sortType)
		{
			return default(CharCardSortInfoStyleData);
		}

		// Token: 0x06015BE0 RID: 89056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BE0")]
		[Address(RVA = "0xE54520", Offset = "0xE53120", VA = "0x180E54520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015BE1 RID: 89057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015BE1")]
		[Address(RVA = "0xE54090", Offset = "0xE52C90", VA = "0x180E54090")]
		private string _GetAttrValueBySortType(CharacterSortType sortType)
		{
			return null;
		}

		// Token: 0x06015BE2 RID: 89058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BE2")]
		[Address(RVA = "0xE54D20", Offset = "0xE53920", VA = "0x180E54D20")]
		public UICharacterSortInfoPanel()
		{
		}

		// Token: 0x0401A210 RID: 107024
		[Token(Token = "0x401A210")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _maskColor;

		// Token: 0x0401A211 RID: 107025
		[Token(Token = "0x401A211")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _attrIcon;

		// Token: 0x0401A212 RID: 107026
		[Token(Token = "0x401A212")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x0401A213 RID: 107027
		[Token(Token = "0x401A213")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _attrValue;

		// Token: 0x0401A214 RID: 107028
		[Token(Token = "0x401A214")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Info data")]
		private CharCardSortInfoStyleData[] _infoStyles;

		// Token: 0x0401A215 RID: 107029
		[Token(Token = "0x401A215")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0401A216 RID: 107030
		[Token(Token = "0x401A216")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401A217 RID: 107031
		[Token(Token = "0x401A217")]
		[FieldOffset(Offset = "0x50")]
		private CharacterCardViewModel m_cachedViewModel;

		// Token: 0x0401A218 RID: 107032
		[Token(Token = "0x401A218")]
		[FieldOffset(Offset = "0x58")]
		private CharacterHandbookStageStatus m_cachedStageStatus;

		// Token: 0x0401A219 RID: 107033
		[Token(Token = "0x401A219")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401A21A RID: 107034
		[Token(Token = "0x401A21A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSortInfo;

		// Token: 0x0401A21B RID: 107035
		[Token(Token = "0x401A21B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCustomStyle;

		// Token: 0x0401A21C RID: 107036
		[Token(Token = "0x401A21C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDefault;

		// Token: 0x0401A21D RID: 107037
		[Token(Token = "0x401A21D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderHandBookStageStyle;

		// Token: 0x0401A21E RID: 107038
		[Token(Token = "0x401A21E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetHandBookCustomTextColor;

		// Token: 0x0401A21F RID: 107039
		[Token(Token = "0x401A21F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetHandBookCustomMaskColor;

		// Token: 0x0401A220 RID: 107040
		[Token(Token = "0x401A220")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryGetSortInfoStyle;

		// Token: 0x0401A221 RID: 107041
		[Token(Token = "0x401A221")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A222 RID: 107042
		[Token(Token = "0x401A222")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetAttrValueBySortType;

		// Token: 0x0401A223 RID: 107043
		[Token(Token = "0x401A223")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
