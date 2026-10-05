using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200655D RID: 25949
	[Token(Token = "0x200655D")]
	public class ArtMagazineDiyInitSkinSelectState : ArtMagazineDiySidePanelState, IHotfixable
	{
		// Token: 0x06025508 RID: 152840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025508")]
		[Address(RVA = "0x204A470", Offset = "0x2049070", VA = "0x18204A470", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025509 RID: 152841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025509")]
		[Address(RVA = "0x204A4D0", Offset = "0x20490D0", VA = "0x18204A4D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602550A RID: 152842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602550A")]
		[Address(RVA = "0x204A610", Offset = "0x2049210", VA = "0x18204A610", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602550B RID: 152843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602550B")]
		[Address(RVA = "0x204A570", Offset = "0x2049170", VA = "0x18204A570", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602550C RID: 152844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602550C")]
		[Address(RVA = "0x204A6C0", Offset = "0x20492C0", VA = "0x18204A6C0")]
		public ArtMagazineDiyInitSkinSelectState()
		{
		}

		// Token: 0x0602550D RID: 152845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602550D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602550E RID: 152846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602550E")]
		[Address(RVA = "0x2045A80", Offset = "0x2044680", VA = "0x182045A80")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0602550F RID: 152847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602550F")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x040345A4 RID: 214436
		[Token(Token = "0x40345A4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ArtMagazineDiyInitSkinSelectView _view;

		// Token: 0x040345A5 RID: 214437
		[Token(Token = "0x40345A5")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040345A6 RID: 214438
		[Token(Token = "0x40345A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040345A7 RID: 214439
		[Token(Token = "0x40345A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040345A8 RID: 214440
		[Token(Token = "0x40345A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040345A9 RID: 214441
		[Token(Token = "0x40345A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040345AA RID: 214442
		[Token(Token = "0x40345AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
