using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029C8 RID: 10696
	[Token(Token = "0x20029C8")]
	public class AdvancedMovement : BasicMovement
	{
		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x06011B76 RID: 72566 RVA: 0x0006C768 File Offset: 0x0006A968
		[Token(Token = "0x17002706")]
		public bool needSpeed
		{
			[Token(Token = "0x6011B76")]
			[Address(RVA = "0x97F7B0", Offset = "0x97E3B0", VA = "0x18097F7B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x06011B77 RID: 72567 RVA: 0x0006C780 File Offset: 0x0006A980
		[Token(Token = "0x17002707")]
		public bool ableAddInertia
		{
			[Token(Token = "0x6011B77")]
			[Address(RVA = "0x97F0A0", Offset = "0x97DCA0", VA = "0x18097F0A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x06011B78 RID: 72568 RVA: 0x0006C798 File Offset: 0x0006A998
		[Token(Token = "0x17002708")]
		public bool addInertia
		{
			[Token(Token = "0x6011B78")]
			[Address(RVA = "0x97F170", Offset = "0x97DD70", VA = "0x18097F170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x06011B79 RID: 72569 RVA: 0x0006C7B0 File Offset: 0x0006A9B0
		[Token(Token = "0x17002709")]
		public bool ableDynamicSpeed
		{
			[Token(Token = "0x6011B79")]
			[Address(RVA = "0x97F100", Offset = "0x97DD00", VA = "0x18097F100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x06011B7A RID: 72570 RVA: 0x0006C7C8 File Offset: 0x0006A9C8
		[Token(Token = "0x1700270A")]
		public bool useDynamicSpeed
		{
			[Token(Token = "0x6011B7A")]
			[Address(RVA = "0x97F9D0", Offset = "0x97E5D0", VA = "0x18097F9D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x06011B7B RID: 72571 RVA: 0x0006C7E0 File Offset: 0x0006A9E0
		[Token(Token = "0x1700270B")]
		public bool needDistance
		{
			[Token(Token = "0x6011B7B")]
			[Address(RVA = "0x97F750", Offset = "0x97E350", VA = "0x18097F750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x06011B7C RID: 72572 RVA: 0x0006C7F8 File Offset: 0x0006A9F8
		[Token(Token = "0x1700270C")]
		public bool isTwoPoint
		{
			[Token(Token = "0x6011B7C")]
			[Address(RVA = "0x97F510", Offset = "0x97E110", VA = "0x18097F510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x06011B7D RID: 72573 RVA: 0x0006C810 File Offset: 0x0006AA10
		[Token(Token = "0x1700270D")]
		public virtual bool comeBack
		{
			[Token(Token = "0x6011B7D")]
			[Address(RVA = "0x97F290", Offset = "0x97DE90", VA = "0x18097F290", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x06011B7E RID: 72574 RVA: 0x0006C828 File Offset: 0x0006AA28
		[Token(Token = "0x1700270E")]
		protected bool clearTraceTargetWhenReached
		{
			[Token(Token = "0x6011B7E")]
			[Address(RVA = "0x97F230", Offset = "0x97DE30", VA = "0x18097F230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x06011B7F RID: 72575 RVA: 0x0006C840 File Offset: 0x0006AA40
		[Token(Token = "0x1700270F")]
		protected bool updateDelayTimeOnlyOnce
		{
			[Token(Token = "0x6011B7F")]
			[Address(RVA = "0x97F970", Offset = "0x97E570", VA = "0x18097F970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x06011B80 RID: 72576 RVA: 0x0006C858 File Offset: 0x0006AA58
		[Token(Token = "0x17002710")]
		protected FP delayAfterReached
		{
			[Token(Token = "0x6011B80")]
			[Address(RVA = "0x97F2F0", Offset = "0x97DEF0", VA = "0x18097F2F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x06011B81 RID: 72577 RVA: 0x0006C870 File Offset: 0x0006AA70
		[Token(Token = "0x17002711")]
		protected bool isComeBack
		{
			[Token(Token = "0x6011B81")]
			[Address(RVA = "0x97F4B0", Offset = "0x97E0B0", VA = "0x18097F4B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x06011B82 RID: 72578 RVA: 0x0006C888 File Offset: 0x0006AA88
		// (set) Token: 0x06011B83 RID: 72579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002712")]
		protected bool alreadyUpdateAfterDelay
		{
			[Token(Token = "0x6011B82")]
			[Address(RVA = "0x97F1D0", Offset = "0x97DDD0", VA = "0x18097F1D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011B83")]
			[Address(RVA = "0x97FA30", Offset = "0x97E630", VA = "0x18097FA30")]
			set
			{
			}
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x06011B84 RID: 72580 RVA: 0x0006C8A0 File Offset: 0x0006AAA0
		[Token(Token = "0x17002713")]
		protected float estimateRatio
		{
			[Token(Token = "0x6011B84")]
			[Address(RVA = "0x97F350", Offset = "0x97DF50", VA = "0x18097F350")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x06011B85 RID: 72581 RVA: 0x0006C8B8 File Offset: 0x0006AAB8
		// (set) Token: 0x06011B86 RID: 72582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002714")]
		protected float speed
		{
			[Token(Token = "0x6011B85")]
			[Address(RVA = "0x97F910", Offset = "0x97E510", VA = "0x18097F910")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6011B86")]
			[Address(RVA = "0x97FAA0", Offset = "0x97E6A0", VA = "0x18097FAA0")]
			set
			{
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x06011B87 RID: 72583 RVA: 0x0006C8D0 File Offset: 0x0006AAD0
		[Token(Token = "0x17002715")]
		protected override float realSpeed
		{
			[Token(Token = "0x6011B87")]
			[Address(RVA = "0x97F820", Offset = "0x97E420", VA = "0x18097F820", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x06011B88 RID: 72584 RVA: 0x0006C8E8 File Offset: 0x0006AAE8
		[Token(Token = "0x17002716")]
		protected AdvancedMovement.MoveType moveType
		{
			[Token(Token = "0x6011B88")]
			[Address(RVA = "0x97F570", Offset = "0x97E170", VA = "0x18097F570")]
			get
			{
				return AdvancedMovement.MoveType.NONE;
			}
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x06011B89 RID: 72585 RVA: 0x0006C900 File Offset: 0x0006AB00
		[Token(Token = "0x17002717")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011B89")]
			[Address(RVA = "0x97F5D0", Offset = "0x97E1D0", VA = "0x18097F5D0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x06011B8A RID: 72586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002718")]
		private AdvancedMovement.MovementCalculator movementCalculator
		{
			[Token(Token = "0x6011B8A")]
			[Address(RVA = "0x97F630", Offset = "0x97E230", VA = "0x18097F630")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011B8B RID: 72587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B8B")]
		[Address(RVA = "0x97D330", Offset = "0x97BF30", VA = "0x18097D330", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011B8C RID: 72588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B8C")]
		[Address(RVA = "0x97DDC0", Offset = "0x97C9C0", VA = "0x18097DDC0", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011B8D RID: 72589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B8D")]
		[Address(RVA = "0x97D0A0", Offset = "0x97BCA0", VA = "0x18097D0A0", Slot = "19")]
		protected override void DoCheckReached()
		{
		}

		// Token: 0x06011B8E RID: 72590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B8E")]
		[Address(RVA = "0x97ECA0", Offset = "0x97D8A0", VA = "0x18097ECA0")]
		protected void _UpdateAfterReach()
		{
		}

		// Token: 0x06011B8F RID: 72591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B8F")]
		[Address(RVA = "0x97D570", Offset = "0x97C170", VA = "0x18097D570", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011B90 RID: 72592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B90")]
		[Address(RVA = "0x97D710", Offset = "0x97C310", VA = "0x18097D710", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011B91 RID: 72593 RVA: 0x0006C918 File Offset: 0x0006AB18
		[Token(Token = "0x6011B91")]
		[Address(RVA = "0x97CF70", Offset = "0x97BB70", VA = "0x18097CF70", Slot = "22")]
		protected override bool DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011B92 RID: 72594 RVA: 0x0006C930 File Offset: 0x0006AB30
		[Token(Token = "0x6011B92")]
		[Address(RVA = "0x97D230", Offset = "0x97BE30", VA = "0x18097D230", Slot = "29")]
		protected virtual float GetLerpRatio(float ratio)
		{
			return 0f;
		}

		// Token: 0x06011B93 RID: 72595 RVA: 0x0006C948 File Offset: 0x0006AB48
		[Token(Token = "0x6011B93")]
		[Address(RVA = "0x97D2A0", Offset = "0x97BEA0", VA = "0x18097D2A0", Slot = "30")]
		protected virtual float GetSpeed(float ratio, float speed)
		{
			return 0f;
		}

		// Token: 0x06011B94 RID: 72596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B94")]
		[Address(RVA = "0x97C980", Offset = "0x97B580", VA = "0x18097C980")]
		protected void Comeback()
		{
		}

		// Token: 0x06011B95 RID: 72597 RVA: 0x0006C960 File Offset: 0x0006AB60
		[Token(Token = "0x6011B95")]
		[Address(RVA = "0x97C8A0", Offset = "0x97B4A0", VA = "0x18097C8A0")]
		protected bool CheckStartTick(float deltaTime)
		{
			return default(bool);
		}

		// Token: 0x06011B96 RID: 72598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B96")]
		[Address(RVA = "0x97EB90", Offset = "0x97D790", VA = "0x18097EB90")]
		public void SetUnReached()
		{
		}

		// Token: 0x06011B97 RID: 72599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B97")]
		[Address(RVA = "0x97EB20", Offset = "0x97D720", VA = "0x18097EB20")]
		public void ResetMoveSpeed()
		{
		}

		// Token: 0x06011B98 RID: 72600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B98")]
		[Address(RVA = "0x97DD10", Offset = "0x97C910", VA = "0x18097DD10", Slot = "25")]
		public override void OnMovementSwitched()
		{
		}

		// Token: 0x06011B99 RID: 72601 RVA: 0x0006C978 File Offset: 0x0006AB78
		[Token(Token = "0x6011B99")]
		[Address(RVA = "0x97EDB0", Offset = "0x97D9B0", VA = "0x18097EDB0")]
		private float _UpdateDynamicSpeed(float lastSpeed, float deltaSpeedPerSec, float finalSpeed, float deltaTime)
		{
			return 0f;
		}

		// Token: 0x06011B9A RID: 72602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B9A")]
		[Address(RVA = "0x97EF50", Offset = "0x97DB50", VA = "0x18097EF50")]
		public AdvancedMovement()
		{
		}

		// Token: 0x06011B9C RID: 72604 RVA: 0x0006C990 File Offset: 0x0006AB90
		[Token(Token = "0x6011B9C")]
		[Address(RVA = "0x97EC70", Offset = "0x97D870", VA = "0x18097EC70")]
		private float <>xLuaBaseProxy_get_realSpeed()
		{
			return 0f;
		}

		// Token: 0x06011B9D RID: 72605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B9D")]
		[Address(RVA = "0x97EC30", Offset = "0x97D830", VA = "0x18097EC30")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011B9E RID: 72606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B9E")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011B9F RID: 72607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B9F")]
		[Address(RVA = "0x97EC20", Offset = "0x97D820", VA = "0x18097EC20")]
		private void <>xLuaBaseProxy_DoCheckReached()
		{
		}

		// Token: 0x06011BA0 RID: 72608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BA0")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x06011BA1 RID: 72609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BA1")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BA2 RID: 72610 RVA: 0x0006C9A8 File Offset: 0x0006ABA8
		[Token(Token = "0x6011BA2")]
		[Address(RVA = "0x97EC10", Offset = "0x97D810", VA = "0x18097EC10")]
		private bool <>xLuaBaseProxy_DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011BA3 RID: 72611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BA3")]
		[Address(RVA = "0x97EC50", Offset = "0x97D850", VA = "0x18097EC50")]
		private void <>xLuaBaseProxy_OnMovementSwitched()
		{
		}

		// Token: 0x04013DD3 RID: 81363
		[Token(Token = "0x4013DD3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AdvancedMovement.MoveType _moveType;

		// Token: 0x04013DD4 RID: 81364
		[Token(Token = "0x4013DD4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private FuncTimeBasedParamData _moveTypeData;

		// Token: 0x04013DD5 RID: 81365
		[Token(Token = "0x4013DD5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Inspect("needSpeed")]
		private float _speed;

		// Token: 0x04013DD6 RID: 81366
		[Token(Token = "0x4013DD6")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Inspect("needDistance")]
		private float _distance;

		// Token: 0x04013DD7 RID: 81367
		[Token(Token = "0x4013DD7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _comeBack;

		// Token: 0x04013DD8 RID: 81368
		[Token(Token = "0x4013DD8")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Inspect("comeBack")]
		private float _comeBackSpeedScale;

		// Token: 0x04013DD9 RID: 81369
		[Token(Token = "0x4013DD9")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _delayToStart;

		// Token: 0x04013DDA RID: 81370
		[Token(Token = "0x4013DDA")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float _delayAfterReached;

		// Token: 0x04013DDB RID: 81371
		[Token(Token = "0x4013DDB")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _delayToReachAfterHit;

		// Token: 0x04013DDC RID: 81372
		[Token(Token = "0x4013DDC")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private bool _clearTraceTargetWhenReached;

		// Token: 0x04013DDD RID: 81373
		[Token(Token = "0x4013DDD")]
		[FieldOffset(Offset = "0xD5")]
		[SerializeField]
		private bool _updateDelayTimeOnlyOnce;

		// Token: 0x04013DDE RID: 81374
		[Token(Token = "0x4013DDE")]
		[FieldOffset(Offset = "0xD6")]
		[SerializeField]
		private bool _skipSmoothLerpDirection;

		// Token: 0x04013DDF RID: 81375
		[Token(Token = "0x4013DDF")]
		[FieldOffset(Offset = "0xD7")]
		[SerializeField]
		[Inspect("ableAddInertia")]
		private bool _addInertia;

		// Token: 0x04013DE0 RID: 81376
		[Token(Token = "0x4013DE0")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Inspect("addInertia")]
		private float _turnSpeed;

		// Token: 0x04013DE1 RID: 81377
		[Token(Token = "0x4013DE1")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[Inspect("ableDynamicSpeed")]
		private bool _useDynamicSpeed;

		// Token: 0x04013DE2 RID: 81378
		[Token(Token = "0x4013DE2")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Inspect("useDynamicSpeed")]
		private float _deltaSpeedPerSec;

		// Token: 0x04013DE3 RID: 81379
		[Token(Token = "0x4013DE3")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Inspect("useDynamicSpeed")]
		private float _finalSpeed;

		// Token: 0x04013DE4 RID: 81380
		[Token(Token = "0x4013DE4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Vector3 _randomOffset;

		// Token: 0x04013DE5 RID: 81381
		[Token(Token = "0x4013DE5")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool _forceUseTargetMountPoint;

		// Token: 0x04013DE6 RID: 81382
		[Token(Token = "0x4013DE6")]
		[FieldOffset(Offset = "0xF5")]
		private bool m_hasTarget;

		// Token: 0x04013DE7 RID: 81383
		[Token(Token = "0x4013DE7")]
		[FieldOffset(Offset = "0xF8")]
		private float m_delayToStart;

		// Token: 0x04013DE8 RID: 81384
		[Token(Token = "0x4013DE8")]
		[FieldOffset(Offset = "0xFC")]
		private float m_estimatedTime;

		// Token: 0x04013DE9 RID: 81385
		[Token(Token = "0x4013DE9")]
		[FieldOffset(Offset = "0x100")]
		private FP m_delayAfterReached;

		// Token: 0x04013DEA RID: 81386
		[Token(Token = "0x4013DEA")]
		[FieldOffset(Offset = "0x108")]
		private bool m_isComeBack;

		// Token: 0x04013DEB RID: 81387
		[Token(Token = "0x4013DEB")]
		[FieldOffset(Offset = "0x110")]
		private FP m_turnSpeed;

		// Token: 0x04013DEC RID: 81388
		[Token(Token = "0x4013DEC")]
		[FieldOffset(Offset = "0x118")]
		private EnumIntDictionary<AdvancedMovement.MoveType, AdvancedMovement.MovementCalculator> m_movementCalculatorDict;

		// Token: 0x04013DED RID: 81389
		[Token(Token = "0x4013DED")]
		[FieldOffset(Offset = "0x120")]
		private bool m_alreadyUpdateAfterDelay;

		// Token: 0x04013DEE RID: 81390
		[Token(Token = "0x4013DEE")]
		[FieldOffset(Offset = "0x128")]
		private CoroutineId m_reachAfterDelayId;

		// Token: 0x04013DEF RID: 81391
		[Token(Token = "0x4013DEF")]
		[FieldOffset(Offset = "0x138")]
		private float m_speed;

		// Token: 0x04013DF0 RID: 81392
		[Token(Token = "0x4013DF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needSpeed;

		// Token: 0x04013DF1 RID: 81393
		[Token(Token = "0x4013DF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ableAddInertia;

		// Token: 0x04013DF2 RID: 81394
		[Token(Token = "0x4013DF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_addInertia;

		// Token: 0x04013DF3 RID: 81395
		[Token(Token = "0x4013DF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_ableDynamicSpeed;

		// Token: 0x04013DF4 RID: 81396
		[Token(Token = "0x4013DF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_useDynamicSpeed;

		// Token: 0x04013DF5 RID: 81397
		[Token(Token = "0x4013DF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_needDistance;

		// Token: 0x04013DF6 RID: 81398
		[Token(Token = "0x4013DF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isTwoPoint;

		// Token: 0x04013DF7 RID: 81399
		[Token(Token = "0x4013DF7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_comeBack;

		// Token: 0x04013DF8 RID: 81400
		[Token(Token = "0x4013DF8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_clearTraceTargetWhenReached;

		// Token: 0x04013DF9 RID: 81401
		[Token(Token = "0x4013DF9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_updateDelayTimeOnlyOnce;

		// Token: 0x04013DFA RID: 81402
		[Token(Token = "0x4013DFA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_delayAfterReached;

		// Token: 0x04013DFB RID: 81403
		[Token(Token = "0x4013DFB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isComeBack;

		// Token: 0x04013DFC RID: 81404
		[Token(Token = "0x4013DFC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_alreadyUpdateAfterDelay;

		// Token: 0x04013DFD RID: 81405
		[Token(Token = "0x4013DFD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_alreadyUpdateAfterDelay;

		// Token: 0x04013DFE RID: 81406
		[Token(Token = "0x4013DFE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_estimateRatio;

		// Token: 0x04013DFF RID: 81407
		[Token(Token = "0x4013DFF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_speed;

		// Token: 0x04013E00 RID: 81408
		[Token(Token = "0x4013E00")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_speed;

		// Token: 0x04013E01 RID: 81409
		[Token(Token = "0x4013E01")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_realSpeed;

		// Token: 0x04013E02 RID: 81410
		[Token(Token = "0x4013E02")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_moveType;

		// Token: 0x04013E03 RID: 81411
		[Token(Token = "0x4013E03")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013E04 RID: 81412
		[Token(Token = "0x4013E04")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_movementCalculator;

		// Token: 0x04013E05 RID: 81413
		[Token(Token = "0x4013E05")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013E06 RID: 81414
		[Token(Token = "0x4013E06")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E07 RID: 81415
		[Token(Token = "0x4013E07")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_DoCheckReached;

		// Token: 0x04013E08 RID: 81416
		[Token(Token = "0x4013E08")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UpdateAfterReach;

		// Token: 0x04013E09 RID: 81417
		[Token(Token = "0x4013E09")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013E0A RID: 81418
		[Token(Token = "0x4013E0A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E0B RID: 81419
		[Token(Token = "0x4013E0B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_DoCheckReachedInternal;

		// Token: 0x04013E0C RID: 81420
		[Token(Token = "0x4013E0C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetLerpRatio;

		// Token: 0x04013E0D RID: 81421
		[Token(Token = "0x4013E0D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetSpeed;

		// Token: 0x04013E0E RID: 81422
		[Token(Token = "0x4013E0E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_Comeback;

		// Token: 0x04013E0F RID: 81423
		[Token(Token = "0x4013E0F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckStartTick;

		// Token: 0x04013E10 RID: 81424
		[Token(Token = "0x4013E10")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SetUnReached;

		// Token: 0x04013E11 RID: 81425
		[Token(Token = "0x4013E11")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ResetMoveSpeed;

		// Token: 0x04013E12 RID: 81426
		[Token(Token = "0x4013E12")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnMovementSwitched;

		// Token: 0x04013E13 RID: 81427
		[Token(Token = "0x4013E13")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__UpdateDynamicSpeed;

		// Token: 0x04013E14 RID: 81428
		[Token(Token = "0x4013E14")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029C9 RID: 10697
		[Token(Token = "0x20029C9")]
		public enum MoveType
		{
			// Token: 0x04013E16 RID: 81430
			[Token(Token = "0x4013E16")]
			NONE,
			// Token: 0x04013E17 RID: 81431
			[Token(Token = "0x4013E17")]
			TRACE_TARGET_WITH_SPEED,
			// Token: 0x04013E18 RID: 81432
			[Token(Token = "0x4013E18")]
			TRACE_TARGET_WITHIN_TIME,
			// Token: 0x04013E19 RID: 81433
			[Token(Token = "0x4013E19")]
			TWO_POINTS,
			// Token: 0x04013E1A RID: 81434
			[Token(Token = "0x4013E1A")]
			FIXED_DIRECTION,
			// Token: 0x04013E1B RID: 81435
			[Token(Token = "0x4013E1B")]
			FIXED_DISTANCE,
			// Token: 0x04013E1C RID: 81436
			[Token(Token = "0x4013E1C")]
			FUNC_ANGLE_AND_TIME
		}

		// Token: 0x020029CA RID: 10698
		[Token(Token = "0x20029CA")]
		public abstract class MovementCalculator : IHotfixable
		{
			// Token: 0x06011BA4 RID: 72612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011BA4")]
			[Address(RVA = "0x99DB80", Offset = "0x99C780", VA = "0x18099DB80")]
			public void Init(AdvancedMovement movement, FuncTimeBasedParamData param, bool isInit = true)
			{
			}

			// Token: 0x06011BA5 RID: 72613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011BA5")]
			[Address(RVA = "0x99DCD0", Offset = "0x99C8D0", VA = "0x18099DCD0")]
			public void OnTick(FP deltaTime)
			{
			}

			// Token: 0x17002719 RID: 10009
			// (get) Token: 0x06011BA6 RID: 72614
			[Token(Token = "0x17002719")]
			public abstract Vector3 direction { [Token(Token = "0x6011BA6")] get; }

			// Token: 0x1700271A RID: 10010
			// (get) Token: 0x06011BA7 RID: 72615
			[Token(Token = "0x1700271A")]
			public abstract Vector3 curPos { [Token(Token = "0x6011BA7")] get; }

			// Token: 0x06011BA8 RID: 72616
			[Token(Token = "0x6011BA8")]
			protected abstract void InitInline(Vector3 pos, Vector3 dir);

			// Token: 0x06011BA9 RID: 72617
			[Token(Token = "0x6011BA9")]
			protected abstract void OnTickInline(FP deltaTime);

			// Token: 0x06011BAA RID: 72618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011BAA")]
			[Address(RVA = "0x99DD70", Offset = "0x99C970", VA = "0x18099DD70")]
			protected MovementCalculator()
			{
			}

			// Token: 0x04013E1D RID: 81437
			[Token(Token = "0x4013E1D")]
			[FieldOffset(Offset = "0x10")]
			protected FuncTimeBasedParamData option;

			// Token: 0x04013E1E RID: 81438
			[Token(Token = "0x4013E1E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04013E1F RID: 81439
			[Token(Token = "0x4013E1F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04013E20 RID: 81440
			[Token(Token = "0x4013E20")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
