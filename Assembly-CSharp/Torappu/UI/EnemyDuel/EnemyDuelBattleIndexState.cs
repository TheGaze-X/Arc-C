using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FF4 RID: 20468
	[Token(Token = "0x2004FF4")]
	public class EnemyDuelBattleIndexState : State
	{
		// Token: 0x0601E614 RID: 124436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E614")]
		[Address(RVA = "0x1810EE0", Offset = "0x180FAE0", VA = "0x181810EE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E615 RID: 124437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E615")]
		[Address(RVA = "0x1811030", Offset = "0x180FC30", VA = "0x181811030", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601E616 RID: 124438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E616")]
		[Address(RVA = "0x1810FC0", Offset = "0x180FBC0", VA = "0x181810FC0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601E617 RID: 124439 RVA: 0x000AE558 File Offset: 0x000AC758
		[Token(Token = "0x601E617")]
		[Address(RVA = "0x1810F40", Offset = "0x180FB40", VA = "0x181810F40")]
		public static bool NeedRouteToFinish()
		{
			return default(bool);
		}

		// Token: 0x0601E618 RID: 124440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E618")]
		[Address(RVA = "0x18110A0", Offset = "0x180FCA0", VA = "0x1818110A0")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x0601E619 RID: 124441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E619")]
		[Address(RVA = "0x1811340", Offset = "0x180FF40", VA = "0x181811340")]
		private void _RouteToProperState()
		{
		}

		// Token: 0x0601E61A RID: 124442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E61A")]
		[Address(RVA = "0x1811150", Offset = "0x180FD50", VA = "0x181811150")]
		private IEnumerator _CoroutineRouteToProperState()
		{
			return null;
		}

		// Token: 0x0601E61B RID: 124443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E61B")]
		[Address(RVA = "0x1811200", Offset = "0x180FE00", VA = "0x181811200")]
		private Type _GetTargetState()
		{
			return null;
		}

		// Token: 0x0601E61C RID: 124444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E61C")]
		[Address(RVA = "0x1811570", Offset = "0x1810170", VA = "0x181811570")]
		public EnemyDuelBattleIndexState()
		{
		}

		// Token: 0x0601E61D RID: 124445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E61D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601E61E RID: 124446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E61E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x040289DD RID: 166365
		[Token(Token = "0x40289DD")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine m_coroutine;

		// Token: 0x040289DE RID: 166366
		[Token(Token = "0x40289DE")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040289DF RID: 166367
		[Token(Token = "0x40289DF")]
		[FieldOffset(Offset = "0x68")]
		private int m_finishWaitDlg;

		// Token: 0x040289E0 RID: 166368
		[Token(Token = "0x40289E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040289E1 RID: 166369
		[Token(Token = "0x40289E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040289E2 RID: 166370
		[Token(Token = "0x40289E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040289E3 RID: 166371
		[Token(Token = "0x40289E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NeedRouteToFinish;

		// Token: 0x040289E4 RID: 166372
		[Token(Token = "0x40289E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x040289E5 RID: 166373
		[Token(Token = "0x40289E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x040289E6 RID: 166374
		[Token(Token = "0x40289E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CoroutineRouteToProperState;

		// Token: 0x040289E7 RID: 166375
		[Token(Token = "0x40289E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetTargetState;

		// Token: 0x040289E8 RID: 166376
		[Token(Token = "0x40289E8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
