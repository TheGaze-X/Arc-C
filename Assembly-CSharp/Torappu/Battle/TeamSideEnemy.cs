using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using Torappu.Battle.TPhysic2D;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002611 RID: 9745
	[Token(Token = "0x2002611")]
	public class TeamSideEnemy : Enemy, IUseTeamSide, IPtrObject, IUseEnemyTrace
	{
		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x0600FDFE RID: 65022 RVA: 0x000602D0 File Offset: 0x0005E4D0
		[Token(Token = "0x17002239")]
		public SideTypeIndex teamSide
		{
			[Token(Token = "0x600FDFE")]
			[Address(RVA = "0x761F50", Offset = "0x760B50", VA = "0x180761F50", Slot = "222")]
			get
			{
				return SideTypeIndex.ALLY;
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x0600FDFF RID: 65023 RVA: 0x000602E8 File Offset: 0x0005E4E8
		[Token(Token = "0x1700223A")]
		private SideType oppositeSide
		{
			[Token(Token = "0x600FDFF")]
			[Address(RVA = "0x761E30", Offset = "0x760A30", VA = "0x180761E30")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x0600FE00 RID: 65024 RVA: 0x00060300 File Offset: 0x0005E500
		[Token(Token = "0x1700223B")]
		public bool hasTargetInRange
		{
			[Token(Token = "0x600FE00")]
			[Address(RVA = "0x761AF0", Offset = "0x7606F0", VA = "0x180761AF0", Slot = "226")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x0600FE01 RID: 65025 RVA: 0x00060318 File Offset: 0x0005E518
		[Token(Token = "0x1700223C")]
		public bool hasSummoneeAfterDeath
		{
			[Token(Token = "0x600FE01")]
			[Address(RVA = "0x761A90", Offset = "0x760690", VA = "0x180761A90", Slot = "223")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x0600FE02 RID: 65026 RVA: 0x00060330 File Offset: 0x0005E530
		[Token(Token = "0x1700223D")]
		protected override SideTypeIndex sideTypeIndex
		{
			[Token(Token = "0x600FE02")]
			[Address(RVA = "0x761EF0", Offset = "0x760AF0", VA = "0x180761EF0", Slot = "201")]
			get
			{
				return SideTypeIndex.ALLY;
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x0600FE03 RID: 65027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700223E")]
		private DirectionCursor emptyCursor
		{
			[Token(Token = "0x600FE03")]
			[Address(RVA = "0x761850", Offset = "0x760450", VA = "0x180761850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x0600FE04 RID: 65028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700223F")]
		public override DirectionCursor moveCursor
		{
			[Token(Token = "0x600FE04")]
			[Address(RVA = "0x761B50", Offset = "0x760750", VA = "0x180761B50", Slot = "205")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x0600FE05 RID: 65029 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FE06 RID: 65030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002240")]
		public BaseTraceTargetAbility enemyTraceEnemyAbility
		{
			[Token(Token = "0x600FE05")]
			[Address(RVA = "0x761A30", Offset = "0x760630", VA = "0x180761A30", Slot = "224")]
			get
			{
				return null;
			}
			[Token(Token = "0x600FE06")]
			[Address(RVA = "0x762290", Offset = "0x760E90", VA = "0x180762290", Slot = "225")]
			set
			{
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x0600FE07 RID: 65031 RVA: 0x00060348 File Offset: 0x0005E548
		[Token(Token = "0x17002241")]
		public override bool usingTraceCursor
		{
			[Token(Token = "0x600FE07")]
			[Address(RVA = "0x762120", Offset = "0x760D20", VA = "0x180762120", Slot = "206")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x0600FE08 RID: 65032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002242")]
		public override Entity traceTarget
		{
			[Token(Token = "0x600FE08")]
			[Address(RVA = "0x761FB0", Offset = "0x760BB0", VA = "0x180761FB0", Slot = "207")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600FE09 RID: 65033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE09")]
		[Address(RVA = "0x760BE0", Offset = "0x75F7E0", VA = "0x180760BE0", Slot = "227")]
		public void UpdateTargetInRange()
		{
		}

		// Token: 0x0600FE0A RID: 65034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE0A")]
		[Address(RVA = "0x760900", Offset = "0x75F500", VA = "0x180760900", Slot = "216")]
		protected override void Init(LevelData.EnemyData enemyData, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route)
		{
		}

		// Token: 0x0600FE0B RID: 65035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE0B")]
		[Address(RVA = "0x760B20", Offset = "0x75F720", VA = "0x180760B20", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FE0C RID: 65036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE0C")]
		[Address(RVA = "0x761650", Offset = "0x760250", VA = "0x180761650")]
		private void _SetSideData()
		{
		}

		// Token: 0x0600FE0D RID: 65037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE0D")]
		[Address(RVA = "0x761770", Offset = "0x760370", VA = "0x180761770")]
		public TeamSideEnemy()
		{
		}

		// Token: 0x0600FE0E RID: 65038 RVA: 0x00060360 File Offset: 0x0005E560
		[Token(Token = "0x600FE0E")]
		[Address(RVA = "0x760640", Offset = "0x75F240", VA = "0x180760640")]
		private SideTypeIndex <>xLuaBaseProxy_get_sideTypeIndex()
		{
			return SideTypeIndex.ALLY;
		}

		// Token: 0x0600FE0F RID: 65039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FE0F")]
		[Address(RVA = "0x7536F0", Offset = "0x7522F0", VA = "0x1807536F0")]
		private DirectionCursor <>xLuaBaseProxy_get_moveCursor()
		{
			return null;
		}

		// Token: 0x0600FE10 RID: 65040 RVA: 0x00060378 File Offset: 0x0005E578
		[Token(Token = "0x600FE10")]
		[Address(RVA = "0x760BD0", Offset = "0x75F7D0", VA = "0x180760BD0")]
		private bool <>xLuaBaseProxy_get_usingTraceCursor()
		{
			return default(bool);
		}

		// Token: 0x0600FE11 RID: 65041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FE11")]
		[Address(RVA = "0x760BC0", Offset = "0x75F7C0", VA = "0x180760BC0")]
		private Entity <>xLuaBaseProxy_get_traceTarget()
		{
			return null;
		}

		// Token: 0x0600FE12 RID: 65042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE12")]
		[Address(RVA = "0x7536A0", Offset = "0x7522A0", VA = "0x1807536A0")]
		private void <>xLuaBaseProxy_Init(LevelData.EnemyData P0, EnemyHandBookData P1, Scheduler.SchedulerSnapshot P2, Route P3)
		{
		}

		// Token: 0x0600FE13 RID: 65043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE13")]
		[Address(RVA = "0x6099C0", Offset = "0x6085C0", VA = "0x1806099C0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x04011A42 RID: 72258
		[Token(Token = "0x4011A42")]
		[FieldOffset(Offset = "0x528")]
		[SerializeField]
		private bool _hasSummonee;

		// Token: 0x04011A43 RID: 72259
		[Token(Token = "0x4011A43")]
		[FieldOffset(Offset = "0x529")]
		private bool m_hasTargetInRange;

		// Token: 0x04011A44 RID: 72260
		[Token(Token = "0x4011A44")]
		[FieldOffset(Offset = "0x52C")]
		private SideTypeIndex m_teamSide;

		// Token: 0x04011A45 RID: 72261
		[Token(Token = "0x4011A45")]
		[FieldOffset(Offset = "0x530")]
		private BaseTraceTargetAbility m_enemyTraceEnemyAbility;

		// Token: 0x04011A46 RID: 72262
		[Token(Token = "0x4011A46")]
		[FieldOffset(Offset = "0x538")]
		private TracePositionCursor m_emptyCursor;

		// Token: 0x04011A47 RID: 72263
		[Token(Token = "0x4011A47")]
		[FieldOffset(Offset = "0x540")]
		private SideType m_oppositeSide;

		// Token: 0x04011A48 RID: 72264
		[Token(Token = "0x4011A48")]
		[FieldOffset(Offset = "0x544")]
		private TCircle m_blockCircle;

		// Token: 0x04011A49 RID: 72265
		[Token(Token = "0x4011A49")]
		[FieldOffset(Offset = "0x550")]
		private readonly HashSet<ObjectPtr<Entity>> m_oppositeSideEntity;

		// Token: 0x04011A4A RID: 72266
		[Token(Token = "0x4011A4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_teamSide;

		// Token: 0x04011A4B RID: 72267
		[Token(Token = "0x4011A4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_oppositeSide;

		// Token: 0x04011A4C RID: 72268
		[Token(Token = "0x4011A4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasTargetInRange;

		// Token: 0x04011A4D RID: 72269
		[Token(Token = "0x4011A4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasSummoneeAfterDeath;

		// Token: 0x04011A4E RID: 72270
		[Token(Token = "0x4011A4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sideTypeIndex;

		// Token: 0x04011A4F RID: 72271
		[Token(Token = "0x4011A4F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_emptyCursor;

		// Token: 0x04011A50 RID: 72272
		[Token(Token = "0x4011A50")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_moveCursor;

		// Token: 0x04011A51 RID: 72273
		[Token(Token = "0x4011A51")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_enemyTraceEnemyAbility;

		// Token: 0x04011A52 RID: 72274
		[Token(Token = "0x4011A52")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_enemyTraceEnemyAbility;

		// Token: 0x04011A53 RID: 72275
		[Token(Token = "0x4011A53")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_usingTraceCursor;

		// Token: 0x04011A54 RID: 72276
		[Token(Token = "0x4011A54")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_traceTarget;

		// Token: 0x04011A55 RID: 72277
		[Token(Token = "0x4011A55")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateTargetInRange;

		// Token: 0x04011A56 RID: 72278
		[Token(Token = "0x4011A56")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04011A57 RID: 72279
		[Token(Token = "0x4011A57")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011A58 RID: 72280
		[Token(Token = "0x4011A58")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetSideData;

		// Token: 0x04011A59 RID: 72281
		[Token(Token = "0x4011A59")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
