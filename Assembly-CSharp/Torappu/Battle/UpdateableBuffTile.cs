using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023B2 RID: 9138
	[Token(Token = "0x20023B2")]
	public class UpdateableBuffTile : BuffTile, IUpdateable
	{
		// Token: 0x0600E847 RID: 59463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E847")]
		[Address(RVA = "0x5E93B0", Offset = "0x5E7FB0", VA = "0x1805E93B0", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E848 RID: 59464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E848")]
		[Address(RVA = "0x5E9750", Offset = "0x5E8350", VA = "0x1805E9750", Slot = "48")]
		public void OnFixedUpdate(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600E849 RID: 59465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E849")]
		[Address(RVA = "0x5E9910", Offset = "0x5E8510", VA = "0x1805E9910")]
		private void _UpdateEnemy()
		{
		}

		// Token: 0x0600E84A RID: 59466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E84A")]
		[Address(RVA = "0x5E97F0", Offset = "0x5E83F0", VA = "0x1805E97F0", Slot = "45")]
		public override void OnInvalidEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E84B RID: 59467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E84B")]
		[Address(RVA = "0x5E9540", Offset = "0x5E8140", VA = "0x1805E9540", Slot = "32")]
		protected override void OnEnemyLeave(Enemy enemy)
		{
		}

		// Token: 0x0600E84C RID: 59468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E84C")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8220", VA = "0x1805E9620", Slot = "46")]
		public override void OnEnemyValid(Enemy enemy)
		{
		}

		// Token: 0x0600E84D RID: 59469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E84D")]
		[Address(RVA = "0x5E9460", Offset = "0x5E8060", VA = "0x1805E9460", Slot = "47")]
		public override void OnEnemyInvalid(Enemy enemy)
		{
		}

		// Token: 0x0600E84E RID: 59470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E84E")]
		[Address(RVA = "0x5E9D00", Offset = "0x5E8900", VA = "0x1805E9D00")]
		public UpdateableBuffTile()
		{
		}

		// Token: 0x0600E84F RID: 59471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E84F")]
		[Address(RVA = "0x5E98D0", Offset = "0x5E84D0", VA = "0x1805E98D0")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0600E850 RID: 59472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E850")]
		[Address(RVA = "0x5E9900", Offset = "0x5E8500", VA = "0x1805E9900")]
		private void <>xLuaBaseProxy_OnInvalidEnemyEnter(Enemy P0)
		{
		}

		// Token: 0x0600E851 RID: 59473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E851")]
		[Address(RVA = "0x5D2FD0", Offset = "0x5D1BD0", VA = "0x1805D2FD0")]
		private void <>xLuaBaseProxy_OnEnemyLeave(Enemy P0)
		{
		}

		// Token: 0x0600E852 RID: 59474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E852")]
		[Address(RVA = "0x5E98F0", Offset = "0x5E84F0", VA = "0x1805E98F0")]
		private void <>xLuaBaseProxy_OnEnemyValid(Enemy P0)
		{
		}

		// Token: 0x0600E853 RID: 59475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E853")]
		[Address(RVA = "0x5E98E0", Offset = "0x5E84E0", VA = "0x1805E98E0")]
		private void <>xLuaBaseProxy_OnEnemyInvalid(Enemy P0)
		{
		}

		// Token: 0x0400FFE2 RID: 65506
		[Token(Token = "0x400FFE2")]
		[FieldOffset(Offset = "0x1B0")]
		private ListSet<ObjectPtr<Enemy>> m_invalidEnemy;

		// Token: 0x0400FFE3 RID: 65507
		[Token(Token = "0x400FFE3")]
		[FieldOffset(Offset = "0x1B8")]
		private ListSet<ObjectPtr<Enemy>> m_validEnemy;

		// Token: 0x0400FFE4 RID: 65508
		[Token(Token = "0x400FFE4")]
		private const int TRIGGER_TICK = 10;

		// Token: 0x0400FFE5 RID: 65509
		[Token(Token = "0x400FFE5")]
		[FieldOffset(Offset = "0x1C0")]
		private PeriodicTicker m_triggerTicker;

		// Token: 0x0400FFE6 RID: 65510
		[Token(Token = "0x400FFE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FFE7 RID: 65511
		[Token(Token = "0x400FFE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0400FFE8 RID: 65512
		[Token(Token = "0x400FFE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateEnemy;

		// Token: 0x0400FFE9 RID: 65513
		[Token(Token = "0x400FFE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInvalidEnemyEnter;

		// Token: 0x0400FFEA RID: 65514
		[Token(Token = "0x400FFEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnemyLeave;

		// Token: 0x0400FFEB RID: 65515
		[Token(Token = "0x400FFEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnemyValid;

		// Token: 0x0400FFEC RID: 65516
		[Token(Token = "0x400FFEC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnemyInvalid;

		// Token: 0x0400FFED RID: 65517
		[Token(Token = "0x400FFED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
