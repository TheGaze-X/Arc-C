using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FE7 RID: 20455
	[Token(Token = "0x2004FE7")]
	public class EnemyDuelBattleDefaultState : EnemyDuelBattleState
	{
		// Token: 0x0601E5D7 RID: 124375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5D7")]
		[Address(RVA = "0x180F910", Offset = "0x180E510", VA = "0x18180F910", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E5D8 RID: 124376 RVA: 0x000AE4C8 File Offset: 0x000AC6C8
		[Token(Token = "0x601E5D8")]
		[Address(RVA = "0x180F970", Offset = "0x180E570", VA = "0x18180F970", Slot = "31")]
		protected override EnemyDuelServiceGameState GetSupportedGameState()
		{
			return EnemyDuelServiceGameState.NONE;
		}

		// Token: 0x0601E5D9 RID: 124377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5D9")]
		[Address(RVA = "0x180FBD0", Offset = "0x180E7D0", VA = "0x18180FBD0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E5DA RID: 124378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5DA")]
		[Address(RVA = "0x180F9D0", Offset = "0x180E5D0", VA = "0x18180F9D0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E5DB RID: 124379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5DB")]
		[Address(RVA = "0x180FD00", Offset = "0x180E900", VA = "0x18180FD00", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E5DC RID: 124380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5DC")]
		[Address(RVA = "0x180FB00", Offset = "0x180E700", VA = "0x18180FB00", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E5DD RID: 124381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5DD")]
		[Address(RVA = "0x180FE30", Offset = "0x180EA30", VA = "0x18180FE30")]
		public EnemyDuelBattleDefaultState()
		{
		}

		// Token: 0x0601E5DE RID: 124382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5DE")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601E5DF RID: 124383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E5DF")]
		[Address(RVA = "0x180FDD0", Offset = "0x180E9D0", VA = "0x18180FDD0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601E5E0 RID: 124384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5E0")]
		[Address(RVA = "0x12B83C0", Offset = "0x12B6FC0", VA = "0x1812B83C0")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0601E5E1 RID: 124385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5E1")]
		[Address(RVA = "0x180FE00", Offset = "0x180EA00", VA = "0x18180FE00")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x040289B4 RID: 166324
		[Token(Token = "0x40289B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040289B5 RID: 166325
		[Token(Token = "0x40289B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSupportedGameState;

		// Token: 0x040289B6 RID: 166326
		[Token(Token = "0x40289B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040289B7 RID: 166327
		[Token(Token = "0x40289B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x040289B8 RID: 166328
		[Token(Token = "0x40289B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x040289B9 RID: 166329
		[Token(Token = "0x40289B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x040289BA RID: 166330
		[Token(Token = "0x40289BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
