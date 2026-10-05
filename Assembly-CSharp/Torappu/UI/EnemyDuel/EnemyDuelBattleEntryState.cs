using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FEA RID: 20458
	[Token(Token = "0x2004FEA")]
	public class EnemyDuelBattleEntryState : EnemyDuelBattleState
	{
		// Token: 0x0601E5EE RID: 124398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5EE")]
		[Address(RVA = "0x180FED0", Offset = "0x180EAD0", VA = "0x18180FED0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E5EF RID: 124399 RVA: 0x000AE510 File Offset: 0x000AC710
		[Token(Token = "0x601E5EF")]
		[Address(RVA = "0x180FF30", Offset = "0x180EB30", VA = "0x18180FF30", Slot = "31")]
		protected override EnemyDuelServiceGameState GetSupportedGameState()
		{
			return EnemyDuelServiceGameState.NONE;
		}

		// Token: 0x0601E5F0 RID: 124400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5F0")]
		[Address(RVA = "0x1810190", Offset = "0x180ED90", VA = "0x181810190", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E5F1 RID: 124401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5F1")]
		[Address(RVA = "0x180FF90", Offset = "0x180EB90", VA = "0x18180FF90", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E5F2 RID: 124402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5F2")]
		[Address(RVA = "0x18102C0", Offset = "0x180EEC0", VA = "0x1818102C0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E5F3 RID: 124403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5F3")]
		[Address(RVA = "0x18100C0", Offset = "0x180ECC0", VA = "0x1818100C0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E5F4 RID: 124404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5F4")]
		[Address(RVA = "0x1810390", Offset = "0x180EF90", VA = "0x181810390")]
		public EnemyDuelBattleEntryState()
		{
		}

		// Token: 0x0601E5F5 RID: 124405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5F5")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601E5F6 RID: 124406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5F6")]
		[Address(RVA = "0x180FDD0", Offset = "0x180E9D0", VA = "0x18180FDD0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601E5F7 RID: 124407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5F7")]
		[Address(RVA = "0x12B83C0", Offset = "0x12B6FC0", VA = "0x1812B83C0")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0601E5F8 RID: 124408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5F8")]
		[Address(RVA = "0x180FE00", Offset = "0x180EA00", VA = "0x18180FE00")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x040289BF RID: 166335
		[Token(Token = "0x40289BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040289C0 RID: 166336
		[Token(Token = "0x40289C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSupportedGameState;

		// Token: 0x040289C1 RID: 166337
		[Token(Token = "0x40289C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040289C2 RID: 166338
		[Token(Token = "0x40289C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x040289C3 RID: 166339
		[Token(Token = "0x40289C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x040289C4 RID: 166340
		[Token(Token = "0x40289C4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x040289C5 RID: 166341
		[Token(Token = "0x40289C5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
