using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200260D RID: 9741
	[Token(Token = "0x200260D")]
	public class ControllableEnemy : Enemy
	{
		// Token: 0x0600FDE2 RID: 64994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDE2")]
		[Address(RVA = "0x7534E0", Offset = "0x7520E0", VA = "0x1807534E0", Slot = "216")]
		protected override void Init(LevelData.EnemyData data, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route)
		{
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600FDE3 RID: 64995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002232")]
		public override DirectionCursor cursor
		{
			[Token(Token = "0x600FDE3")]
			[Address(RVA = "0x753AE0", Offset = "0x7526E0", VA = "0x180753AE0", Slot = "204")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x0600FDE4 RID: 64996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002233")]
		public override DirectionCursor moveCursor
		{
			[Token(Token = "0x600FDE4")]
			[Address(RVA = "0x753B40", Offset = "0x752740", VA = "0x180753B40", Slot = "205")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x0600FDE5 RID: 64997 RVA: 0x00060228 File Offset: 0x0005E428
		[Token(Token = "0x17002234")]
		protected override bool onlyCollideWhenUnbalance
		{
			[Token(Token = "0x600FDE5")]
			[Address(RVA = "0x753BA0", Offset = "0x7527A0", VA = "0x180753BA0", Slot = "195")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FDE6 RID: 64998 RVA: 0x00060240 File Offset: 0x0005E440
		[Token(Token = "0x600FDE6")]
		[Address(RVA = "0x7539C0", Offset = "0x7525C0", VA = "0x1807539C0", Slot = "217")]
		protected override Vector2 _MoveByRoute(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FDE7 RID: 64999 RVA: 0x00060258 File Offset: 0x0005E458
		[Token(Token = "0x600FDE7")]
		[Address(RVA = "0x753700", Offset = "0x752300", VA = "0x180753700")]
		private Vector2 _MoveByController(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FDE8 RID: 65000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDE8")]
		[Address(RVA = "0x753380", Offset = "0x751F80", VA = "0x180753380", Slot = "167")]
		public override void GatherHudPluginTypes(List<string> pluginNames)
		{
		}

		// Token: 0x0600FDE9 RID: 65001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDE9")]
		[Address(RVA = "0x753A60", Offset = "0x752660", VA = "0x180753A60")]
		public ControllableEnemy()
		{
		}

		// Token: 0x0600FDEA RID: 65002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDEA")]
		[Address(RVA = "0x7536A0", Offset = "0x7522A0", VA = "0x1807536A0")]
		private void <>xLuaBaseProxy_Init(LevelData.EnemyData P0, EnemyHandBookData P1, Scheduler.SchedulerSnapshot P2, Route P3)
		{
		}

		// Token: 0x0600FDEB RID: 65003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FDEB")]
		[Address(RVA = "0x7536E0", Offset = "0x7522E0", VA = "0x1807536E0")]
		private DirectionCursor <>xLuaBaseProxy_get_cursor()
		{
			return null;
		}

		// Token: 0x0600FDEC RID: 65004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FDEC")]
		[Address(RVA = "0x7536F0", Offset = "0x7522F0", VA = "0x1807536F0")]
		private DirectionCursor <>xLuaBaseProxy_get_moveCursor()
		{
			return null;
		}

		// Token: 0x0600FDED RID: 65005 RVA: 0x00060270 File Offset: 0x0005E470
		[Token(Token = "0x600FDED")]
		[Address(RVA = "0x609AA0", Offset = "0x6086A0", VA = "0x180609AA0")]
		private bool <>xLuaBaseProxy_get_onlyCollideWhenUnbalance()
		{
			return default(bool);
		}

		// Token: 0x0600FDEE RID: 65006 RVA: 0x00060288 File Offset: 0x0005E488
		[Token(Token = "0x600FDEE")]
		[Address(RVA = "0x6F0050", Offset = "0x6EEC50", VA = "0x1806F0050")]
		private Vector2 <>xLuaBaseProxy__MoveByRoute(float P0, out bool P1)
		{
			return default(Vector2);
		}

		// Token: 0x0600FDEF RID: 65007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDEF")]
		[Address(RVA = "0x753690", Offset = "0x752290", VA = "0x180753690")]
		private void <>xLuaBaseProxy_GatherHudPluginTypes(List<string> P0)
		{
		}

		// Token: 0x04011A30 RID: 72240
		[Token(Token = "0x4011A30")]
		[FieldOffset(Offset = "0x528")]
		private Act6FunEmptyCursor m_emptyCursor;

		// Token: 0x04011A31 RID: 72241
		[Token(Token = "0x4011A31")]
		private const string CONTROLLABLE_ENEMY_HP_SLIDER = "controllable_enemy_hp_slider";

		// Token: 0x04011A32 RID: 72242
		[Token(Token = "0x4011A32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04011A33 RID: 72243
		[Token(Token = "0x4011A33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cursor;

		// Token: 0x04011A34 RID: 72244
		[Token(Token = "0x4011A34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_moveCursor;

		// Token: 0x04011A35 RID: 72245
		[Token(Token = "0x4011A35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onlyCollideWhenUnbalance;

		// Token: 0x04011A36 RID: 72246
		[Token(Token = "0x4011A36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__MoveByRoute;

		// Token: 0x04011A37 RID: 72247
		[Token(Token = "0x4011A37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__MoveByController;

		// Token: 0x04011A38 RID: 72248
		[Token(Token = "0x4011A38")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherHudPluginTypes;

		// Token: 0x04011A39 RID: 72249
		[Token(Token = "0x4011A39")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
