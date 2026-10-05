using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023A2 RID: 9122
	[Token(Token = "0x20023A2")]
	public class IceTile : BuffTile
	{
		// Token: 0x0600E76F RID: 59247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E76F")]
		[Address(RVA = "0x5D4D00", Offset = "0x5D3900", VA = "0x1805D4D00")]
		private void _CheckFrozen(object rawTarget)
		{
		}

		// Token: 0x0600E770 RID: 59248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E770")]
		[Address(RVA = "0x5D4F60", Offset = "0x5D3B60", VA = "0x1805D4F60")]
		private void _StopCheck(Enemy enemy)
		{
		}

		// Token: 0x0600E771 RID: 59249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E771")]
		[Address(RVA = "0x5D4B10", Offset = "0x5D3710", VA = "0x1805D4B10", Slot = "31")]
		protected override void OnEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E772 RID: 59250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E772")]
		[Address(RVA = "0x5D4C70", Offset = "0x5D3870", VA = "0x1805D4C70", Slot = "32")]
		protected override void OnEnemyLeave(Enemy enemy)
		{
		}

		// Token: 0x0600E773 RID: 59251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E773")]
		[Address(RVA = "0x5D5060", Offset = "0x5D3C60", VA = "0x1805D5060")]
		public IceTile()
		{
		}

		// Token: 0x0600E774 RID: 59252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E774")]
		[Address(RVA = "0x5D2FC0", Offset = "0x5D1BC0", VA = "0x1805D2FC0")]
		private void <>xLuaBaseProxy_OnEnemyEnter(Enemy P0)
		{
		}

		// Token: 0x0600E775 RID: 59253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E775")]
		[Address(RVA = "0x5D2FD0", Offset = "0x5D1BD0", VA = "0x1805D2FD0")]
		private void <>xLuaBaseProxy_OnEnemyLeave(Enemy P0)
		{
		}

		// Token: 0x0400FEE9 RID: 65257
		[Token(Token = "0x400FEE9")]
		private const float FRICTION_FACTOR = 0.5f;

		// Token: 0x0400FEEA RID: 65258
		[Token(Token = "0x400FEEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckFrozen;

		// Token: 0x0400FEEB RID: 65259
		[Token(Token = "0x400FEEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__StopCheck;

		// Token: 0x0400FEEC RID: 65260
		[Token(Token = "0x400FEEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnemyEnter;

		// Token: 0x0400FEED RID: 65261
		[Token(Token = "0x400FEED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnemyLeave;

		// Token: 0x0400FEEE RID: 65262
		[Token(Token = "0x400FEEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
