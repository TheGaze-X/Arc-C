using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006561 RID: 25953
	[Token(Token = "0x2006561")]
	public class ArtMagazineDiySkinEditState : ArtMagazineDiySidePanelState, IHotfixable
	{
		// Token: 0x06025520 RID: 152864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025520")]
		[Address(RVA = "0x204FEF0", Offset = "0x204EAF0", VA = "0x18204FEF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025521 RID: 152865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025521")]
		[Address(RVA = "0x204FF50", Offset = "0x204EB50", VA = "0x18204FF50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025522 RID: 152866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025522")]
		[Address(RVA = "0x2050120", Offset = "0x204ED20", VA = "0x182050120", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06025523 RID: 152867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025523")]
		[Address(RVA = "0x2050080", Offset = "0x204EC80", VA = "0x182050080", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06025524 RID: 152868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025524")]
		[Address(RVA = "0x20501D0", Offset = "0x204EDD0", VA = "0x1820501D0")]
		public ArtMagazineDiySkinEditState()
		{
		}

		// Token: 0x06025525 RID: 152869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025525")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025526 RID: 152870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025526")]
		[Address(RVA = "0x2045A80", Offset = "0x2044680", VA = "0x182045A80")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06025527 RID: 152871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025527")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x040345BA RID: 214458
		[Token(Token = "0x40345BA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ArtMagazineDiySkinEditView _view;

		// Token: 0x040345BB RID: 214459
		[Token(Token = "0x40345BB")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040345BC RID: 214460
		[Token(Token = "0x40345BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040345BD RID: 214461
		[Token(Token = "0x40345BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040345BE RID: 214462
		[Token(Token = "0x40345BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040345BF RID: 214463
		[Token(Token = "0x40345BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040345C0 RID: 214464
		[Token(Token = "0x40345C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
