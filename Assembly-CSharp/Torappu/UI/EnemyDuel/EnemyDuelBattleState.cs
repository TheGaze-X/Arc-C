using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FFB RID: 20475
	[Token(Token = "0x2004FFB")]
	public abstract class EnemyDuelBattleState : PopupFadeState
	{
		// Token: 0x0601E642 RID: 124482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E642")]
		[Address(RVA = "0x1812F30", Offset = "0x1811B30", VA = "0x181812F30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E643 RID: 124483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E643")]
		[Address(RVA = "0x1812D80", Offset = "0x1811980", VA = "0x181812D80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E644 RID: 124484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E644")]
		[Address(RVA = "0x1812EC0", Offset = "0x1811AC0", VA = "0x181812EC0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601E645 RID: 124485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E645")]
		[Address(RVA = "0x18130D0", Offset = "0x1811CD0", VA = "0x1818130D0")]
		private void _OnBattleRoundStateChanged(object args)
		{
		}

		// Token: 0x0601E646 RID: 124486 RVA: 0x000AE5A0 File Offset: 0x000AC7A0
		[Token(Token = "0x601E646")]
		[Address(RVA = "0x1812FF0", Offset = "0x1811BF0", VA = "0x181812FF0")]
		private bool _NeedRouteToIndexState()
		{
			return default(bool);
		}

		// Token: 0x0601E647 RID: 124487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E647")]
		[Address(RVA = "0x1813260", Offset = "0x1811E60", VA = "0x181813260")]
		private void _TryRouteToPropState()
		{
		}

		// Token: 0x0601E648 RID: 124488
		[Token(Token = "0x601E648")]
		protected abstract EnemyDuelServiceGameState GetSupportedGameState();

		// Token: 0x0601E649 RID: 124489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E649")]
		[Address(RVA = "0x1813540", Offset = "0x1812140", VA = "0x181813540")]
		protected EnemyDuelBattleState()
		{
		}

		// Token: 0x0601E64A RID: 124490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E64A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E64B RID: 124491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E64B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04028A16 RID: 166422
		[Token(Token = "0x4028A16")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isBaseInited;

		// Token: 0x04028A17 RID: 166423
		[Token(Token = "0x4028A17")]
		[FieldOffset(Offset = "0x74")]
		private int m_cachedRoundIndex;

		// Token: 0x04028A18 RID: 166424
		[Token(Token = "0x4028A18")]
		[FieldOffset(Offset = "0x78")]
		private int m_finishWaitDlg;

		// Token: 0x04028A19 RID: 166425
		[Token(Token = "0x4028A19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028A1A RID: 166426
		[Token(Token = "0x4028A1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028A1B RID: 166427
		[Token(Token = "0x4028A1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04028A1C RID: 166428
		[Token(Token = "0x4028A1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBattleRoundStateChanged;

		// Token: 0x04028A1D RID: 166429
		[Token(Token = "0x4028A1D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NeedRouteToIndexState;

		// Token: 0x04028A1E RID: 166430
		[Token(Token = "0x4028A1E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryRouteToPropState;

		// Token: 0x04028A1F RID: 166431
		[Token(Token = "0x4028A1F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
