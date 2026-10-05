using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072A5 RID: 29349
	[Token(Token = "0x20072A5")]
	public class Act46SideMapDecorTrapPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x060298D8 RID: 170200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298D8")]
		[Address(RVA = "0x24FE6B0", Offset = "0x24FD2B0", VA = "0x1824FE6B0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x060298D9 RID: 170201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298D9")]
		[Address(RVA = "0x24FE520", Offset = "0x24FD120", VA = "0x1824FE520")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x060298DA RID: 170202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298DA")]
		[Address(RVA = "0x24FE8A0", Offset = "0x24FD4A0", VA = "0x1824FE8A0")]
		public Act46SideMapDecorTrapPlugin()
		{
		}

		// Token: 0x0403B67D RID: 243325
		[Token(Token = "0x403B67D")]
		private const string TRAP_SMALL_ICON_NAME = "{0}_small";

		// Token: 0x0403B67E RID: 243326
		[Token(Token = "0x403B67E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgTrapIcon;

		// Token: 0x0403B67F RID: 243327
		[Token(Token = "0x403B67F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403B680 RID: 243328
		[Token(Token = "0x403B680")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelAvailable;

		// Token: 0x0403B681 RID: 243329
		[Token(Token = "0x403B681")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403B682 RID: 243330
		[Token(Token = "0x403B682")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedTrapId;

		// Token: 0x0403B683 RID: 243331
		[Token(Token = "0x403B683")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedActId;

		// Token: 0x0403B684 RID: 243332
		[Token(Token = "0x403B684")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedDomainId;

		// Token: 0x0403B685 RID: 243333
		[Token(Token = "0x403B685")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403B686 RID: 243334
		[Token(Token = "0x403B686")]
		[FieldOffset(Offset = "0x70")]
		private bool m_cachedIsUnlock;

		// Token: 0x0403B687 RID: 243335
		[Token(Token = "0x403B687")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedLockedToast;

		// Token: 0x0403B688 RID: 243336
		[Token(Token = "0x403B688")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403B689 RID: 243337
		[Token(Token = "0x403B689")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x0403B68A RID: 243338
		[Token(Token = "0x403B68A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
