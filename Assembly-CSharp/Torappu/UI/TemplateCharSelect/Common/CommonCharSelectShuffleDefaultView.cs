using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C10 RID: 23568
	[Token(Token = "0x2005C10")]
	public class CommonCharSelectShuffleDefaultView : TemplateCharSelectShuffleViewBase<CommonCharSelectShuffleDefaultViewModel>
	{
		// Token: 0x060222B3 RID: 139955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B3")]
		[Address(RVA = "0x1CAF860", Offset = "0x1CAE460", VA = "0x181CAF860", Slot = "11")]
		protected override void OnRenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x060222B4 RID: 139956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B4")]
		[Address(RVA = "0x1CAFF50", Offset = "0x1CAEB50", VA = "0x181CAFF50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060222B5 RID: 139957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B5")]
		[Address(RVA = "0x1CAFE50", Offset = "0x1CAEA50", VA = "0x181CAFE50")]
		private void _EventOnStartMarkTopToggle()
		{
		}

		// Token: 0x060222B6 RID: 139958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B6")]
		[Address(RVA = "0x1CAFCF0", Offset = "0x1CAE8F0", VA = "0x181CAFCF0")]
		private void _EventOnSetSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x060222B7 RID: 139959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B7")]
		[Address(RVA = "0x1CAFA50", Offset = "0x1CAE650", VA = "0x181CAFA50")]
		private void _EventOnSetCustomSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x060222B8 RID: 139960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B8")]
		[Address(RVA = "0x1CAFB60", Offset = "0x1CAE760", VA = "0x181CAFB60")]
		private void _EventOnSetFilter(UICharacterProfessionFilterHolder.FilterParam filter)
		{
		}

		// Token: 0x060222B9 RID: 139961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B9")]
		[Address(RVA = "0x1CAFDE0", Offset = "0x1CAE9E0", VA = "0x181CAFDE0")]
		private void _EventOnShowSortPanel()
		{
		}

		// Token: 0x060222BA RID: 139962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222BA")]
		[Address(RVA = "0x1CB0200", Offset = "0x1CAEE00", VA = "0x181CB0200")]
		public CommonCharSelectShuffleDefaultView()
		{
		}

		// Token: 0x0402EDBE RID: 191934
		[Token(Token = "0x402EDBE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICharacterStarMarkTopSortItem _startMark;

		// Token: 0x0402EDBF RID: 191935
		[Token(Token = "0x402EDBF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICharacterSortTypeGroup _sortTypeGrp;

		// Token: 0x0402EDC0 RID: 191936
		[Token(Token = "0x402EDC0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICharacterSortFilterPanel _sortFilterPanel;

		// Token: 0x0402EDC1 RID: 191937
		[Token(Token = "0x402EDC1")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0402EDC2 RID: 191938
		[Token(Token = "0x402EDC2")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402EDC3 RID: 191939
		[Token(Token = "0x402EDC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0402EDC4 RID: 191940
		[Token(Token = "0x402EDC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EDC5 RID: 191941
		[Token(Token = "0x402EDC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnStartMarkTopToggle;

		// Token: 0x0402EDC6 RID: 191942
		[Token(Token = "0x402EDC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnSetSortType;

		// Token: 0x0402EDC7 RID: 191943
		[Token(Token = "0x402EDC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnSetCustomSortType;

		// Token: 0x0402EDC8 RID: 191944
		[Token(Token = "0x402EDC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnSetFilter;

		// Token: 0x0402EDC9 RID: 191945
		[Token(Token = "0x402EDC9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnShowSortPanel;

		// Token: 0x0402EDCA RID: 191946
		[Token(Token = "0x402EDCA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
