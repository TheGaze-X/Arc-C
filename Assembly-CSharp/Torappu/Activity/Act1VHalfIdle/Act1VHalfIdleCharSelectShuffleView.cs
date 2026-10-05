using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007706 RID: 30470
	[Token(Token = "0x2007706")]
	public class Act1VHalfIdleCharSelectShuffleView : TemplateCharSelectShuffleViewBase<Act1VHalfIdleCharSelectShuffleViewModel>
	{
		// Token: 0x0602ACEC RID: 175340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACEC")]
		[Address(RVA = "0x269A4D0", Offset = "0x26990D0", VA = "0x18269A4D0", Slot = "11")]
		protected override void OnRenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x0602ACED RID: 175341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACED")]
		[Address(RVA = "0x269A9F0", Offset = "0x26995F0", VA = "0x18269A9F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602ACEE RID: 175342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACEE")]
		[Address(RVA = "0x269A900", Offset = "0x2699500", VA = "0x18269A900")]
		private void _EventOnSetSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x0602ACEF RID: 175343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACEF")]
		[Address(RVA = "0x269A7E0", Offset = "0x26993E0", VA = "0x18269A7E0")]
		private void _EventOnSetFilter(UICharacterProfessionFilterHolder.FilterParam filter)
		{
		}

		// Token: 0x0602ACF0 RID: 175344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACF0")]
		[Address(RVA = "0x269AB80", Offset = "0x2699780", VA = "0x18269AB80")]
		public Act1VHalfIdleCharSelectShuffleView()
		{
		}

		// Token: 0x0403DB03 RID: 252675
		[Token(Token = "0x403DB03")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Avt1VHalfIdleCharDepotShuffleView _shuffleView;

		// Token: 0x0403DB04 RID: 252676
		[Token(Token = "0x403DB04")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x0403DB05 RID: 252677
		[Token(Token = "0x403DB05")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DB06 RID: 252678
		[Token(Token = "0x403DB06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0403DB07 RID: 252679
		[Token(Token = "0x403DB07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DB08 RID: 252680
		[Token(Token = "0x403DB08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnSetSortType;

		// Token: 0x0403DB09 RID: 252681
		[Token(Token = "0x403DB09")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnSetFilter;

		// Token: 0x0403DB0A RID: 252682
		[Token(Token = "0x403DB0A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
