using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200260E RID: 9742
	[Token(Token = "0x200260E")]
	public class GameCityRouteEnemy : Enemy
	{
		// Token: 0x0600FDF0 RID: 65008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDF0")]
		[Address(RVA = "0x756590", Offset = "0x755190", VA = "0x180756590", Slot = "216")]
		protected override void Init(LevelData.EnemyData data, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route)
		{
		}

		// Token: 0x0600FDF1 RID: 65009 RVA: 0x000602A0 File Offset: 0x0005E4A0
		[Token(Token = "0x600FDF1")]
		[Address(RVA = "0x756790", Offset = "0x755390", VA = "0x180756790", Slot = "217")]
		protected override Vector2 _MoveByRoute(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FDF2 RID: 65010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDF2")]
		[Address(RVA = "0x756670", Offset = "0x755270", VA = "0x180756670", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FDF3 RID: 65011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDF3")]
		[Address(RVA = "0x756A40", Offset = "0x755640", VA = "0x180756A40")]
		private void _TriggerEnemyMove(int cursorIndex)
		{
		}

		// Token: 0x0600FDF4 RID: 65012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDF4")]
		[Address(RVA = "0x756F60", Offset = "0x755B60", VA = "0x180756F60")]
		public GameCityRouteEnemy()
		{
		}

		// Token: 0x0600FDF5 RID: 65013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDF5")]
		[Address(RVA = "0x7536A0", Offset = "0x7522A0", VA = "0x1807536A0")]
		private void <>xLuaBaseProxy_Init(LevelData.EnemyData P0, EnemyHandBookData P1, Scheduler.SchedulerSnapshot P2, Route P3)
		{
		}

		// Token: 0x0600FDF6 RID: 65014 RVA: 0x000602B8 File Offset: 0x0005E4B8
		[Token(Token = "0x600FDF6")]
		[Address(RVA = "0x6F0050", Offset = "0x6EEC50", VA = "0x1806F0050")]
		private Vector2 <>xLuaBaseProxy__MoveByRoute(float P0, out bool P1)
		{
			return default(Vector2);
		}

		// Token: 0x0600FDF7 RID: 65015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDF7")]
		[Address(RVA = "0x6099E0", Offset = "0x6085E0", VA = "0x1806099E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04011A3A RID: 72250
		[Token(Token = "0x4011A3A")]
		[FieldOffset(Offset = "0x528")]
		private int m_cursorIndex;

		// Token: 0x04011A3B RID: 72251
		[Token(Token = "0x4011A3B")]
		[FieldOffset(Offset = "0x530")]
		private PeriodicTimer m_waitTimer;

		// Token: 0x04011A3C RID: 72252
		[Token(Token = "0x4011A3C")]
		[FieldOffset(Offset = "0x538")]
		private List<RouteData.CheckpointData> m_checkpointDatas;

		// Token: 0x04011A3D RID: 72253
		[Token(Token = "0x4011A3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04011A3E RID: 72254
		[Token(Token = "0x4011A3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__MoveByRoute;

		// Token: 0x04011A3F RID: 72255
		[Token(Token = "0x4011A3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011A40 RID: 72256
		[Token(Token = "0x4011A40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TriggerEnemyMove;

		// Token: 0x04011A41 RID: 72257
		[Token(Token = "0x4011A41")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
