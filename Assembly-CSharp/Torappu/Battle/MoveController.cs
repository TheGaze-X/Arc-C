using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023C5 RID: 9157
	[Token(Token = "0x20023C5")]
	public class MoveController : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x0600E8E2 RID: 59618 RVA: 0x00055260 File Offset: 0x00053460
		[Token(Token = "0x17001D75")]
		public virtual float moveSpeed
		{
			[Token(Token = "0x600E8E2")]
			[Address(RVA = "0x5F6360", Offset = "0x5F4F60", VA = "0x1805F6360", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x0600E8E3 RID: 59619 RVA: 0x00055278 File Offset: 0x00053478
		// (set) Token: 0x0600E8E4 RID: 59620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D76")]
		public Vector2 velocity
		{
			[Token(Token = "0x600E8E3")]
			[Address(RVA = "0x5F6440", Offset = "0x5F5040", VA = "0x1805F6440")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600E8E4")]
			[Address(RVA = "0x5F6520", Offset = "0x5F5120", VA = "0x1805F6520")]
			set
			{
			}
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x0600E8E5 RID: 59621 RVA: 0x00055290 File Offset: 0x00053490
		// (set) Token: 0x0600E8E6 RID: 59622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D77")]
		public float steeringFactor
		{
			[Token(Token = "0x600E8E5")]
			[Address(RVA = "0x5F63E0", Offset = "0x5F4FE0", VA = "0x1805F63E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600E8E6")]
			[Address(RVA = "0x5F64B0", Offset = "0x5F50B0", VA = "0x1805F64B0")]
			set
			{
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x0600E8E7 RID: 59623 RVA: 0x000552A8 File Offset: 0x000534A8
		[Token(Token = "0x17001D78")]
		public Vector2 footOffset
		{
			[Token(Token = "0x600E8E7")]
			[Address(RVA = "0x5F6290", Offset = "0x5F4E90", VA = "0x1805F6290")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x0600E8E8 RID: 59624 RVA: 0x000552C0 File Offset: 0x000534C0
		[Token(Token = "0x17001D79")]
		public float halfBodyWidth
		{
			[Token(Token = "0x600E8E8")]
			[Address(RVA = "0x5F6300", Offset = "0x5F4F00", VA = "0x1805F6300")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8E9")]
		[Address(RVA = "0x5F56B0", Offset = "0x5F42B0", VA = "0x1805F56B0")]
		public void Reset(IMovable target)
		{
		}

		// Token: 0x0600E8EA RID: 59626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8EA")]
		[Address(RVA = "0x5F55E0", Offset = "0x5F41E0", VA = "0x1805F55E0", Slot = "5")]
		public virtual void OnStart()
		{
		}

		// Token: 0x0600E8EB RID: 59627 RVA: 0x000552D8 File Offset: 0x000534D8
		[Token(Token = "0x600E8EB")]
		[Address(RVA = "0x5F50D0", Offset = "0x5F3CD0", VA = "0x1805F50D0", Slot = "6")]
		public virtual Vector2 CalculateMoveDelta(Vector2 direction, float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600E8EC RID: 59628 RVA: 0x000552F0 File Offset: 0x000534F0
		[Token(Token = "0x600E8EC")]
		[Address(RVA = "0x5F52F0", Offset = "0x5F3EF0", VA = "0x1805F52F0")]
		private Vector2 CalculateTotalForce(Vector2 direction, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600E8ED RID: 59629 RVA: 0x00055308 File Offset: 0x00053508
		[Token(Token = "0x600E8ED")]
		[Address(RVA = "0x5F5F10", Offset = "0x5F4B10", VA = "0x1805F5F10", Slot = "7")]
		protected virtual Vector2 _CalculateSteeringForce(Vector2 moveForce, Vector2 direction)
		{
			return default(Vector2);
		}

		// Token: 0x0600E8EE RID: 59630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8EE")]
		[Address(RVA = "0x5F4E20", Offset = "0x5F3A20", VA = "0x1805F4E20", Slot = "8")]
		protected virtual void CalculateIsHanging(Vector2 direction, ref Vector2 resultForce)
		{
		}

		// Token: 0x0600E8EF RID: 59631 RVA: 0x00055320 File Offset: 0x00053520
		[Token(Token = "0x600E8EF")]
		[Address(RVA = "0x5F5820", Offset = "0x5F4420", VA = "0x1805F5820")]
		private Vector2 _CalculateObstacleAvoidForce(Vector2 mapPos, Vector2 footPos, MotionMode motionMode)
		{
			return default(Vector2);
		}

		// Token: 0x0600E8F0 RID: 59632 RVA: 0x00055338 File Offset: 0x00053538
		[Token(Token = "0x600E8F0")]
		[Address(RVA = "0x5F60F0", Offset = "0x5F4CF0", VA = "0x1805F60F0")]
		private Vector2 _GetFootMapPosition()
		{
			return default(Vector2);
		}

		// Token: 0x0600E8F1 RID: 59633 RVA: 0x00055350 File Offset: 0x00053550
		[Token(Token = "0x600E8F1")]
		[Address(RVA = "0x5F5500", Offset = "0x5F4100", VA = "0x1805F5500")]
		public Vector2 GetBodyEdgeOffset(Vector2 direction)
		{
			return default(Vector2);
		}

		// Token: 0x0600E8F2 RID: 59634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8F2")]
		[Address(RVA = "0x5F6190", Offset = "0x5F4D90", VA = "0x1805F6190")]
		public MoveController()
		{
		}

		// Token: 0x040100C6 RID: 65734
		[Token(Token = "0x40100C6")]
		private const int OBSTACLE_AVOID_TICK_PERIOD = 3;

		// Token: 0x040100C7 RID: 65735
		[Token(Token = "0x40100C7")]
		private const float OBSTACLE_AVOID_FORCE_FACTOR = 1f;

		// Token: 0x040100C8 RID: 65736
		[Token(Token = "0x40100C8")]
		private const float MIN_OBSTACLE_AVOID_INFLUENCE_FACTOR = 0.5f;

		// Token: 0x040100C9 RID: 65737
		[Token(Token = "0x40100C9")]
		private const int SEPARATION_TICK_PERIOD = 3;

		// Token: 0x040100CA RID: 65738
		[Token(Token = "0x40100CA")]
		private const float SEPARATION_FORCE_FACTOR = 3f;

		// Token: 0x040100CB RID: 65739
		[Token(Token = "0x40100CB")]
		private const float SEPARATION_RADIUS = 0.25f;

		// Token: 0x040100CC RID: 65740
		[Token(Token = "0x40100CC")]
		private const float MIN_SEPARATION_SUM_DELTA = 0.05f;

		// Token: 0x040100CD RID: 65741
		[Token(Token = "0x40100CD")]
		private const float TILE_NEAR_THRESHOLD = 0.25f;

		// Token: 0x040100CE RID: 65742
		[Token(Token = "0x40100CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _steeringFactor;

		// Token: 0x040100CF RID: 65743
		[Token(Token = "0x40100CF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected float _maxSteeringForce;

		// Token: 0x040100D0 RID: 65744
		[Token(Token = "0x40100D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _halfBodyWidth;

		// Token: 0x040100D1 RID: 65745
		[Token(Token = "0x40100D1")]
		[FieldOffset(Offset = "0x24")]
		protected float m_steeringFactor;

		// Token: 0x040100D2 RID: 65746
		[Token(Token = "0x40100D2")]
		[FieldOffset(Offset = "0x28")]
		protected IMovable m_target;

		// Token: 0x040100D3 RID: 65747
		[Token(Token = "0x40100D3")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 m_footOffset;

		// Token: 0x040100D4 RID: 65748
		[Token(Token = "0x40100D4")]
		[FieldOffset(Offset = "0x38")]
		protected Vector2 m_lastVelocity;

		// Token: 0x040100D5 RID: 65749
		[Token(Token = "0x40100D5")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 m_lastObstacleAvoidForce;

		// Token: 0x040100D6 RID: 65750
		[Token(Token = "0x40100D6")]
		[FieldOffset(Offset = "0x48")]
		protected Vector2 m_lastSeparationForce;

		// Token: 0x040100D7 RID: 65751
		[Token(Token = "0x40100D7")]
		[FieldOffset(Offset = "0x50")]
		protected PeriodicTicker m_obstacleAvoidTicker;

		// Token: 0x040100D8 RID: 65752
		[Token(Token = "0x40100D8")]
		[FieldOffset(Offset = "0x58")]
		protected PeriodicTicker m_separationTicker;

		// Token: 0x040100D9 RID: 65753
		[Token(Token = "0x40100D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moveSpeed;

		// Token: 0x040100DA RID: 65754
		[Token(Token = "0x40100DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_velocity;

		// Token: 0x040100DB RID: 65755
		[Token(Token = "0x40100DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_velocity;

		// Token: 0x040100DC RID: 65756
		[Token(Token = "0x40100DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_steeringFactor;

		// Token: 0x040100DD RID: 65757
		[Token(Token = "0x40100DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_steeringFactor;

		// Token: 0x040100DE RID: 65758
		[Token(Token = "0x40100DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_footOffset;

		// Token: 0x040100DF RID: 65759
		[Token(Token = "0x40100DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_halfBodyWidth;

		// Token: 0x040100E0 RID: 65760
		[Token(Token = "0x40100E0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040100E1 RID: 65761
		[Token(Token = "0x40100E1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040100E2 RID: 65762
		[Token(Token = "0x40100E2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CalculateMoveDelta;

		// Token: 0x040100E3 RID: 65763
		[Token(Token = "0x40100E3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CalculateTotalForce;

		// Token: 0x040100E4 RID: 65764
		[Token(Token = "0x40100E4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CalculateSteeringForce;

		// Token: 0x040100E5 RID: 65765
		[Token(Token = "0x40100E5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CalculateIsHanging;

		// Token: 0x040100E6 RID: 65766
		[Token(Token = "0x40100E6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CalculateObstacleAvoidForce;

		// Token: 0x040100E7 RID: 65767
		[Token(Token = "0x40100E7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetFootMapPosition;

		// Token: 0x040100E8 RID: 65768
		[Token(Token = "0x40100E8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetBodyEdgeOffset;

		// Token: 0x040100E9 RID: 65769
		[Token(Token = "0x40100E9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
