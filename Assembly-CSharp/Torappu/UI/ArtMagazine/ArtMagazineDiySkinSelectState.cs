using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006562 RID: 25954
	[Token(Token = "0x2006562")]
	public class ArtMagazineDiySkinSelectState : ArtMagazineDiySidePanelState, IHotfixable
	{
		// Token: 0x06025528 RID: 152872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025528")]
		[Address(RVA = "0x20527A0", Offset = "0x20513A0", VA = "0x1820527A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025529 RID: 152873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025529")]
		[Address(RVA = "0x2052800", Offset = "0x2051400", VA = "0x182052800", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602552A RID: 152874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602552A")]
		[Address(RVA = "0x2052940", Offset = "0x2051540", VA = "0x182052940", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602552B RID: 152875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602552B")]
		[Address(RVA = "0x20528A0", Offset = "0x20514A0", VA = "0x1820528A0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602552C RID: 152876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602552C")]
		[Address(RVA = "0x20529F0", Offset = "0x20515F0", VA = "0x1820529F0")]
		public ArtMagazineDiySkinSelectState()
		{
		}

		// Token: 0x0602552D RID: 152877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602552D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602552E RID: 152878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602552E")]
		[Address(RVA = "0x2045A80", Offset = "0x2044680", VA = "0x182045A80")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0602552F RID: 152879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602552F")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x040345C1 RID: 214465
		[Token(Token = "0x40345C1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ArtMagazineDiySkinSelectView _view;

		// Token: 0x040345C2 RID: 214466
		[Token(Token = "0x40345C2")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040345C3 RID: 214467
		[Token(Token = "0x40345C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040345C4 RID: 214468
		[Token(Token = "0x40345C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040345C5 RID: 214469
		[Token(Token = "0x40345C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040345C6 RID: 214470
		[Token(Token = "0x40345C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040345C7 RID: 214471
		[Token(Token = "0x40345C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
