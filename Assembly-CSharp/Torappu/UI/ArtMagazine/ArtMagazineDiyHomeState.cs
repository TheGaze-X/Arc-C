using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200655C RID: 25948
	[Token(Token = "0x200655C")]
	public class ArtMagazineDiyHomeState : ArtMagazineDiySidePanelState, IHotfixable
	{
		// Token: 0x06025500 RID: 152832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025500")]
		[Address(RVA = "0x2047240", Offset = "0x2045E40", VA = "0x182047240", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025501 RID: 152833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025501")]
		[Address(RVA = "0x20472A0", Offset = "0x2045EA0", VA = "0x1820472A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025502 RID: 152834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025502")]
		[Address(RVA = "0x20473E0", Offset = "0x2045FE0", VA = "0x1820473E0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06025503 RID: 152835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025503")]
		[Address(RVA = "0x2047340", Offset = "0x2045F40", VA = "0x182047340", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06025504 RID: 152836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025504")]
		[Address(RVA = "0x2047490", Offset = "0x2046090", VA = "0x182047490")]
		public ArtMagazineDiyHomeState()
		{
		}

		// Token: 0x06025505 RID: 152837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025505")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025506 RID: 152838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025506")]
		[Address(RVA = "0x2045A80", Offset = "0x2044680", VA = "0x182045A80")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06025507 RID: 152839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025507")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403459D RID: 214429
		[Token(Token = "0x403459D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ArtMagazineDiyHomeView _view;

		// Token: 0x0403459E RID: 214430
		[Token(Token = "0x403459E")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403459F RID: 214431
		[Token(Token = "0x403459F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040345A0 RID: 214432
		[Token(Token = "0x40345A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040345A1 RID: 214433
		[Token(Token = "0x40345A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040345A2 RID: 214434
		[Token(Token = "0x40345A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040345A3 RID: 214435
		[Token(Token = "0x40345A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
