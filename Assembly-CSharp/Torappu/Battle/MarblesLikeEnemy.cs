using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002604 RID: 9732
	[Token(Token = "0x2002604")]
	public class MarblesLikeEnemy : BounceEnemy
	{
		// Token: 0x0600FD6F RID: 64879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD6F")]
		[Address(RVA = "0x75A780", Offset = "0x759380", VA = "0x18075A780", Slot = "216")]
		protected override void Init(LevelData.EnemyData data, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route)
		{
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x0600FD70 RID: 64880 RVA: 0x0005FE08 File Offset: 0x0005E008
		[Token(Token = "0x17002214")]
		public FP maxMoveSpeed
		{
			[Token(Token = "0x600FD70")]
			[Address(RVA = "0x75B970", Offset = "0x75A570", VA = "0x18075B970")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x0600FD71 RID: 64881 RVA: 0x0005FE20 File Offset: 0x0005E020
		[Token(Token = "0x17002215")]
		public float maxUnbanlanceSpeed
		{
			[Token(Token = "0x600FD71")]
			[Address(RVA = "0x75BA60", Offset = "0x75A660", VA = "0x18075BA60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x0600FD72 RID: 64882 RVA: 0x0005FE38 File Offset: 0x0005E038
		[Token(Token = "0x17002216")]
		[Inspect]
		[Group("MarblesLikeEnemy")]
		[ReadOnly]
		public FP marblesMoveSpeed
		{
			[Token(Token = "0x600FD72")]
			[Address(RVA = "0x75B8F0", Offset = "0x75A4F0", VA = "0x18075B8F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x0600FD73 RID: 64883 RVA: 0x0005FE50 File Offset: 0x0005E050
		[Token(Token = "0x17002217")]
		[Group("MarblesLikeEnemy")]
		[ReadOnly]
		[Inspect]
		public FP accelerationFactor
		{
			[Token(Token = "0x600FD73")]
			[Address(RVA = "0x75B7A0", Offset = "0x75A3A0", VA = "0x18075B7A0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x0600FD74 RID: 64884 RVA: 0x0005FE68 File Offset: 0x0005E068
		[Token(Token = "0x17002218")]
		[ReadOnly]
		[Inspect]
		[Group("MarblesLikeEnemy")]
		public FP speedLossFactor
		{
			[Token(Token = "0x600FD74")]
			[Address(RVA = "0x75BBE0", Offset = "0x75A7E0", VA = "0x18075BBE0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x0600FD75 RID: 64885 RVA: 0x0005FE80 File Offset: 0x0005E080
		[Token(Token = "0x17002219")]
		[ReadOnly]
		[Inspect]
		[Group("MarblesLikeEnemy")]
		public FP velocityLossFactor
		{
			[Token(Token = "0x600FD75")]
			[Address(RVA = "0x75BD90", Offset = "0x75A990", VA = "0x18075BD90")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x0600FD76 RID: 64886 RVA: 0x0005FE98 File Offset: 0x0005E098
		[Token(Token = "0x1700221A")]
		[Group("VelocityClearForce")]
		[ReadOnly]
		[Inspect]
		public int velocityClearForce
		{
			[Token(Token = "0x600FD76")]
			[Address(RVA = "0x75BCD0", Offset = "0x75A8D0", VA = "0x18075BCD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x0600FD77 RID: 64887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700221B")]
		public override DirectionCursor cursor
		{
			[Token(Token = "0x600FD77")]
			[Address(RVA = "0x75B890", Offset = "0x75A490", VA = "0x18075B890", Slot = "204")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x0600FD78 RID: 64888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700221C")]
		public override DirectionCursor moveCursor
		{
			[Token(Token = "0x600FD78")]
			[Address(RVA = "0x75BB20", Offset = "0x75A720", VA = "0x18075BB20", Slot = "205")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x0600FD79 RID: 64889 RVA: 0x0005FEB0 File Offset: 0x0005E0B0
		[Token(Token = "0x1700221D")]
		protected override bool onlyCollideWhenUnbalance
		{
			[Token(Token = "0x600FD79")]
			[Address(RVA = "0x75BB80", Offset = "0x75A780", VA = "0x18075BB80", Slot = "195")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x0600FD7A RID: 64890 RVA: 0x0005FEC8 File Offset: 0x0005E0C8
		[Token(Token = "0x1700221E")]
		public override Vector2 velocity
		{
			[Token(Token = "0x600FD7A")]
			[Address(RVA = "0x75BE80", Offset = "0x75AA80", VA = "0x18075BE80", Slot = "202")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600FD7B RID: 64891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD7B")]
		[Address(RVA = "0x75AAF0", Offset = "0x7596F0", VA = "0x18075AAF0", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FD7C RID: 64892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD7C")]
		[Address(RVA = "0x75A930", Offset = "0x759530", VA = "0x18075A930", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FD7D RID: 64893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD7D")]
		[Address(RVA = "0x75AB80", Offset = "0x759780", VA = "0x18075AB80")]
		public void UpdatePhysicalParams(MarblesLikeEnemy.MarblesPhysicsMaterialParam pparams)
		{
		}

		// Token: 0x0600FD7E RID: 64894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD7E")]
		[Address(RVA = "0x75A550", Offset = "0x759150", VA = "0x18075A550")]
		public void DoCollisionSpeedLoss(int force)
		{
		}

		// Token: 0x0600FD7F RID: 64895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD7F")]
		[Address(RVA = "0x75B470", Offset = "0x75A070", VA = "0x18075B470")]
		private void _UpdateMoveVelocity(int force)
		{
		}

		// Token: 0x0600FD80 RID: 64896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD80")]
		[Address(RVA = "0x75AFB0", Offset = "0x759BB0", VA = "0x18075AFB0")]
		private void _UpdateMoveSpeed(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FD81 RID: 64897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD81")]
		[Address(RVA = "0x75ACD0", Offset = "0x7598D0", VA = "0x18075ACD0")]
		private void _TryUpdateAttribute(AttributeType attributeType, FP value)
		{
		}

		// Token: 0x0600FD82 RID: 64898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD82")]
		[Address(RVA = "0x75ADF0", Offset = "0x7599F0", VA = "0x18075ADF0")]
		private void _UpdateAnimation(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FD83 RID: 64899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD83")]
		[Address(RVA = "0x75B740", Offset = "0x75A340", VA = "0x18075B740")]
		public MarblesLikeEnemy()
		{
		}

		// Token: 0x0600FD84 RID: 64900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD84")]
		[Address(RVA = "0x7536A0", Offset = "0x7522A0", VA = "0x1807536A0")]
		private void <>xLuaBaseProxy_Init(LevelData.EnemyData P0, EnemyHandBookData P1, Scheduler.SchedulerSnapshot P2, Route P3)
		{
		}

		// Token: 0x0600FD85 RID: 64901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FD85")]
		[Address(RVA = "0x7536E0", Offset = "0x7522E0", VA = "0x1807536E0")]
		private DirectionCursor <>xLuaBaseProxy_get_cursor()
		{
			return null;
		}

		// Token: 0x0600FD86 RID: 64902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FD86")]
		[Address(RVA = "0x7536F0", Offset = "0x7522F0", VA = "0x1807536F0")]
		private DirectionCursor <>xLuaBaseProxy_get_moveCursor()
		{
			return null;
		}

		// Token: 0x0600FD87 RID: 64903 RVA: 0x0005FEE0 File Offset: 0x0005E0E0
		[Token(Token = "0x600FD87")]
		[Address(RVA = "0x609AA0", Offset = "0x6086A0", VA = "0x180609AA0")]
		private bool <>xLuaBaseProxy_get_onlyCollideWhenUnbalance()
		{
			return default(bool);
		}

		// Token: 0x0600FD88 RID: 64904 RVA: 0x0005FEF8 File Offset: 0x0005E0F8
		[Token(Token = "0x600FD88")]
		[Address(RVA = "0x609AC0", Offset = "0x6086C0", VA = "0x180609AC0")]
		private Vector2 <>xLuaBaseProxy_get_velocity()
		{
			return default(Vector2);
		}

		// Token: 0x0600FD89 RID: 64905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD89")]
		[Address(RVA = "0x6099E0", Offset = "0x6085E0", VA = "0x1806099E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600FD8A RID: 64906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD8A")]
		[Address(RVA = "0x6099B0", Offset = "0x6085B0", VA = "0x1806099B0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x040119C0 RID: 72128
		[Token(Token = "0x40119C0")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		[Group("Marbles")]
		private string _moveLeftAnimKey;

		// Token: 0x040119C1 RID: 72129
		[Token(Token = "0x40119C1")]
		[FieldOffset(Offset = "0x538")]
		[SerializeField]
		[Group("Marbles")]
		private string _moveRightAnimKey;

		// Token: 0x040119C2 RID: 72130
		[Token(Token = "0x40119C2")]
		[FieldOffset(Offset = "0x540")]
		private MarblesCursor m_marblesCursor;

		// Token: 0x040119C3 RID: 72131
		[Token(Token = "0x40119C3")]
		[FieldOffset(Offset = "0x548")]
		private MarblesMoveController m_marblesMoveController;

		// Token: 0x040119C4 RID: 72132
		[Token(Token = "0x40119C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040119C5 RID: 72133
		[Token(Token = "0x40119C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxMoveSpeed;

		// Token: 0x040119C6 RID: 72134
		[Token(Token = "0x40119C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxUnbanlanceSpeed;

		// Token: 0x040119C7 RID: 72135
		[Token(Token = "0x40119C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_marblesMoveSpeed;

		// Token: 0x040119C8 RID: 72136
		[Token(Token = "0x40119C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_accelerationFactor;

		// Token: 0x040119C9 RID: 72137
		[Token(Token = "0x40119C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_speedLossFactor;

		// Token: 0x040119CA RID: 72138
		[Token(Token = "0x40119CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_velocityLossFactor;

		// Token: 0x040119CB RID: 72139
		[Token(Token = "0x40119CB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_velocityClearForce;

		// Token: 0x040119CC RID: 72140
		[Token(Token = "0x40119CC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_cursor;

		// Token: 0x040119CD RID: 72141
		[Token(Token = "0x40119CD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_moveCursor;

		// Token: 0x040119CE RID: 72142
		[Token(Token = "0x40119CE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_onlyCollideWhenUnbalance;

		// Token: 0x040119CF RID: 72143
		[Token(Token = "0x40119CF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_velocity;

		// Token: 0x040119D0 RID: 72144
		[Token(Token = "0x40119D0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040119D1 RID: 72145
		[Token(Token = "0x40119D1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x040119D2 RID: 72146
		[Token(Token = "0x40119D2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdatePhysicalParams;

		// Token: 0x040119D3 RID: 72147
		[Token(Token = "0x40119D3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DoCollisionSpeedLoss;

		// Token: 0x040119D4 RID: 72148
		[Token(Token = "0x40119D4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateMoveVelocity;

		// Token: 0x040119D5 RID: 72149
		[Token(Token = "0x40119D5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateMoveSpeed;

		// Token: 0x040119D6 RID: 72150
		[Token(Token = "0x40119D6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryUpdateAttribute;

		// Token: 0x040119D7 RID: 72151
		[Token(Token = "0x40119D7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateAnimation;

		// Token: 0x040119D8 RID: 72152
		[Token(Token = "0x40119D8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002605 RID: 9733
		[Token(Token = "0x2002605")]
		public class MarblesPhysicsMaterialParam : IHotfixable
		{
			// Token: 0x0600FD8B RID: 64907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FD8B")]
			[Address(RVA = "0x75BF80", Offset = "0x75AB80", VA = "0x18075BF80")]
			public MarblesPhysicsMaterialParam()
			{
			}

			// Token: 0x040119D9 RID: 72153
			[Token(Token = "0x40119D9")]
			[FieldOffset(Offset = "0x10")]
			public float bounciness;

			// Token: 0x040119DA RID: 72154
			[Token(Token = "0x40119DA")]
			[FieldOffset(Offset = "0x14")]
			public float friction;

			// Token: 0x040119DB RID: 72155
			[Token(Token = "0x40119DB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
