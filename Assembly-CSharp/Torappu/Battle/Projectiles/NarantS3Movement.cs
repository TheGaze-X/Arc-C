using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029E7 RID: 10727
	[Token(Token = "0x20029E7")]
	public class NarantS3Movement : BasicMovement
	{
		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x06011C8F RID: 72847 RVA: 0x0006CE88 File Offset: 0x0006B088
		[Token(Token = "0x17002737")]
		public bool comeBack
		{
			[Token(Token = "0x6011C8F")]
			[Address(RVA = "0x9A46F0", Offset = "0x9A32F0", VA = "0x1809A46F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x06011C90 RID: 72848 RVA: 0x0006CEA0 File Offset: 0x0006B0A0
		// (set) Token: 0x06011C91 RID: 72849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002738")]
		protected float speed
		{
			[Token(Token = "0x6011C90")]
			[Address(RVA = "0x9A48A0", Offset = "0x9A34A0", VA = "0x1809A48A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6011C91")]
			[Address(RVA = "0x9A4900", Offset = "0x9A3500", VA = "0x1809A4900")]
			set
			{
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x06011C92 RID: 72850 RVA: 0x0006CEB8 File Offset: 0x0006B0B8
		[Token(Token = "0x17002739")]
		protected override float realSpeed
		{
			[Token(Token = "0x6011C92")]
			[Address(RVA = "0x9A47B0", Offset = "0x9A33B0", VA = "0x1809A47B0", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x06011C93 RID: 72851 RVA: 0x0006CED0 File Offset: 0x0006B0D0
		[Token(Token = "0x1700273A")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011C93")]
			[Address(RVA = "0x9A4750", Offset = "0x9A3350", VA = "0x1809A4750", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011C94 RID: 72852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C94")]
		[Address(RVA = "0x9A3840", Offset = "0x9A2440", VA = "0x1809A3840", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011C95 RID: 72853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C95")]
		[Address(RVA = "0x9A3970", Offset = "0x9A2570", VA = "0x1809A3970", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011C96 RID: 72854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C96")]
		[Address(RVA = "0x9A38F0", Offset = "0x9A24F0", VA = "0x1809A38F0", Slot = "20")]
		protected override void OnInitPose()
		{
		}

		// Token: 0x06011C97 RID: 72855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C97")]
		[Address(RVA = "0x9A3DC0", Offset = "0x9A29C0", VA = "0x1809A3DC0", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011C98 RID: 72856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C98")]
		[Address(RVA = "0x9A3690", Offset = "0x9A2290", VA = "0x1809A3690", Slot = "28")]
		protected new virtual void DoCheckReached()
		{
		}

		// Token: 0x06011C99 RID: 72857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C99")]
		[Address(RVA = "0x9A4580", Offset = "0x9A3180", VA = "0x1809A4580")]
		private void _UpdateAfterReach()
		{
		}

		// Token: 0x06011C9A RID: 72858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C9A")]
		[Address(RVA = "0x9A3010", Offset = "0x9A1C10", VA = "0x1809A3010")]
		protected void Comeback()
		{
		}

		// Token: 0x06011C9B RID: 72859 RVA: 0x0006CEE8 File Offset: 0x0006B0E8
		[Token(Token = "0x6011C9B")]
		[Address(RVA = "0x9A3580", Offset = "0x9A2180", VA = "0x1809A3580", Slot = "22")]
		protected override bool DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011C9C RID: 72860 RVA: 0x0006CF00 File Offset: 0x0006B100
		[Token(Token = "0x6011C9C")]
		[Address(RVA = "0x9A3F20", Offset = "0x9A2B20", VA = "0x1809A3F20")]
		private Vector3 _CalculateNextPosition(float deltaTime, bool forceToResetDir)
		{
			return default(Vector3);
		}

		// Token: 0x06011C9D RID: 72861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C9D")]
		[Address(RVA = "0x9A3CF0", Offset = "0x9A28F0", VA = "0x1809A3CF0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011C9E RID: 72862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C9E")]
		[Address(RVA = "0x9A4660", Offset = "0x9A3260", VA = "0x1809A4660")]
		public NarantS3Movement()
		{
		}

		// Token: 0x06011CA0 RID: 72864 RVA: 0x0006CF18 File Offset: 0x0006B118
		[Token(Token = "0x6011CA0")]
		[Address(RVA = "0x97EC70", Offset = "0x97D870", VA = "0x18097EC70")]
		private float <>xLuaBaseProxy_get_realSpeed()
		{
			return 0f;
		}

		// Token: 0x06011CA1 RID: 72865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CA1")]
		[Address(RVA = "0x97EC30", Offset = "0x97D830", VA = "0x18097EC30")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011CA2 RID: 72866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CA2")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011CA3 RID: 72867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CA3")]
		[Address(RVA = "0x998A00", Offset = "0x997600", VA = "0x180998A00")]
		private void <>xLuaBaseProxy_OnInitPose()
		{
		}

		// Token: 0x06011CA4 RID: 72868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CA4")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011CA5 RID: 72869 RVA: 0x0006CF30 File Offset: 0x0006B130
		[Token(Token = "0x6011CA5")]
		[Address(RVA = "0x97EC10", Offset = "0x97D810", VA = "0x18097EC10")]
		private bool <>xLuaBaseProxy_DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011CA6 RID: 72870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CA6")]
		[Address(RVA = "0x9973C0", Offset = "0x995FC0", VA = "0x1809973C0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013F80 RID: 81792
		[Token(Token = "0x4013F80")]
		private const float DIRECTION_ZERO_TOLERANCE = 0.01f;

		// Token: 0x04013F81 RID: 81793
		[Token(Token = "0x4013F81")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _speed;

		// Token: 0x04013F82 RID: 81794
		[Token(Token = "0x4013F82")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _curveHeight;

		// Token: 0x04013F83 RID: 81795
		[Token(Token = "0x4013F83")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _pitchOffsetBound;

		// Token: 0x04013F84 RID: 81796
		[Token(Token = "0x4013F84")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _timeWhenReachMaxHeight;

		// Token: 0x04013F85 RID: 81797
		[Token(Token = "0x4013F85")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _delayAfterReached;

		// Token: 0x04013F86 RID: 81798
		[Token(Token = "0x4013F86")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _delayTime;

		// Token: 0x04013F87 RID: 81799
		[Token(Token = "0x4013F87")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _updateDelayTimeOnlyOnce;

		// Token: 0x04013F88 RID: 81800
		[Token(Token = "0x4013F88")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _noCurveHeightThreshold;

		// Token: 0x04013F89 RID: 81801
		[Token(Token = "0x4013F89")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool _comeBack;

		// Token: 0x04013F8A RID: 81802
		[Token(Token = "0x4013F8A")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[Inspect("comeBack")]
		private float _comeBackSpeedScale;

		// Token: 0x04013F8B RID: 81803
		[Token(Token = "0x4013F8B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool _clockwiseOffset;

		// Token: 0x04013F8C RID: 81804
		[Token(Token = "0x4013F8C")]
		[FieldOffset(Offset = "0xD1")]
		private bool m_clockwiseOffset;

		// Token: 0x04013F8D RID: 81805
		[Token(Token = "0x4013F8D")]
		[FieldOffset(Offset = "0xD2")]
		private bool m_reachedLimit;

		// Token: 0x04013F8E RID: 81806
		[Token(Token = "0x4013F8E")]
		[FieldOffset(Offset = "0xD4")]
		private float m_delayAfterReached;

		// Token: 0x04013F8F RID: 81807
		[Token(Token = "0x4013F8F")]
		[FieldOffset(Offset = "0xD8")]
		private float m_velocityPitchRise;

		// Token: 0x04013F90 RID: 81808
		[Token(Token = "0x4013F90")]
		[FieldOffset(Offset = "0xDC")]
		private float m_velocityPitchFall;

		// Token: 0x04013F91 RID: 81809
		[Token(Token = "0x4013F91")]
		[FieldOffset(Offset = "0xE0")]
		private float m_pitchProgress;

		// Token: 0x04013F92 RID: 81810
		[Token(Token = "0x4013F92")]
		[FieldOffset(Offset = "0xE4")]
		private float m_speed;

		// Token: 0x04013F93 RID: 81811
		[Token(Token = "0x4013F93")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isComeBack;

		// Token: 0x04013F94 RID: 81812
		[Token(Token = "0x4013F94")]
		[FieldOffset(Offset = "0xE9")]
		private bool m_alreadyUpdateAfterDelay;

		// Token: 0x04013F95 RID: 81813
		[Token(Token = "0x4013F95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_comeBack;

		// Token: 0x04013F96 RID: 81814
		[Token(Token = "0x4013F96")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_speed;

		// Token: 0x04013F97 RID: 81815
		[Token(Token = "0x4013F97")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_speed;

		// Token: 0x04013F98 RID: 81816
		[Token(Token = "0x4013F98")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_realSpeed;

		// Token: 0x04013F99 RID: 81817
		[Token(Token = "0x4013F99")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013F9A RID: 81818
		[Token(Token = "0x4013F9A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013F9B RID: 81819
		[Token(Token = "0x4013F9B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013F9C RID: 81820
		[Token(Token = "0x4013F9C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInitPose;

		// Token: 0x04013F9D RID: 81821
		[Token(Token = "0x4013F9D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013F9E RID: 81822
		[Token(Token = "0x4013F9E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoCheckReached;

		// Token: 0x04013F9F RID: 81823
		[Token(Token = "0x4013F9F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateAfterReach;

		// Token: 0x04013FA0 RID: 81824
		[Token(Token = "0x4013FA0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Comeback;

		// Token: 0x04013FA1 RID: 81825
		[Token(Token = "0x4013FA1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoCheckReachedInternal;

		// Token: 0x04013FA2 RID: 81826
		[Token(Token = "0x4013FA2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CalculateNextPosition;

		// Token: 0x04013FA3 RID: 81827
		[Token(Token = "0x4013FA3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013FA4 RID: 81828
		[Token(Token = "0x4013FA4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
