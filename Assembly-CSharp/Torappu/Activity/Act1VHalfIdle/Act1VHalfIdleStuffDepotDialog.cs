using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007779 RID: 30585
	[Token(Token = "0x2007779")]
	public class Act1VHalfIdleStuffDepotDialog : UICompDialog<Act1VHalfIdleStuffDepotDialog.Option>
	{
		// Token: 0x0602AF5B RID: 175963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF5B")]
		[Address(RVA = "0x26D3980", Offset = "0x26D2580", VA = "0x1826D3980", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleStuffDepotDialog.Option input)
		{
		}

		// Token: 0x0602AF5C RID: 175964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF5C")]
		[Address(RVA = "0x26D3CD0", Offset = "0x26D28D0", VA = "0x1826D3CD0")]
		private void _EventOnShowItemDetail(Act1VHalfIdleStuffDepotItemViewModel itemViewModel)
		{
		}

		// Token: 0x0602AF5D RID: 175965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF5D")]
		[Address(RVA = "0x26D3EE0", Offset = "0x26D2AE0", VA = "0x1826D3EE0")]
		public Act1VHalfIdleStuffDepotDialog()
		{
		}

		// Token: 0x0403DFCD RID: 253901
		[Token(Token = "0x403DFCD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfIdleStuffDepotMainView _mainView;

		// Token: 0x0403DFCE RID: 253902
		[Token(Token = "0x403DFCE")]
		[FieldOffset(Offset = "0x78")]
		private Act1VHalfIdleStuffDepotViewModel m_viewModel;

		// Token: 0x0403DFCF RID: 253903
		[Token(Token = "0x403DFCF")]
		[FieldOffset(Offset = "0x80")]
		private Act1VHalfIdleStuffDepotDialog.Option m_cachedInput;

		// Token: 0x0403DFD0 RID: 253904
		[Token(Token = "0x403DFD0")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DFD1 RID: 253905
		[Token(Token = "0x403DFD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403DFD2 RID: 253906
		[Token(Token = "0x403DFD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EventOnShowItemDetail;

		// Token: 0x0403DFD3 RID: 253907
		[Token(Token = "0x403DFD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200777A RID: 30586
		[Token(Token = "0x200777A")]
		public class Option
		{
			// Token: 0x0602AF5E RID: 175966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AF5E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403DFD4 RID: 253908
			[Token(Token = "0x403DFD4")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
