using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002989 RID: 10633
	[Token(Token = "0x2002989")]
	[RequireComponent(typeof(BouncedAdvancedMovement))]
	public class BounceHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x06011971 RID: 72049 RVA: 0x0006C240 File Offset: 0x0006A440
		[Token(Token = "0x170026DF")]
		protected bool BounceTimesAsDamageTimes
		{
			[Token(Token = "0x6011971")]
			[Address(RVA = "0x969C50", Offset = "0x968850", VA = "0x180969C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x06011972 RID: 72050 RVA: 0x0006C258 File Offset: 0x0006A458
		[Token(Token = "0x170026E0")]
		protected bool DealHitWithOtherSelector
		{
			[Token(Token = "0x6011972")]
			[Address(RVA = "0x969CB0", Offset = "0x9688B0", VA = "0x180969CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011973 RID: 72051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011973")]
		[Address(RVA = "0x968E00", Offset = "0x967A00", VA = "0x180968E00", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011974 RID: 72052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011974")]
		[Address(RVA = "0x968350", Offset = "0x966F50", VA = "0x180968350", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011975 RID: 72053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011975")]
		[Address(RVA = "0x969550", Offset = "0x968150", VA = "0x180969550")]
		private void _ApplyAtkScale()
		{
		}

		// Token: 0x06011976 RID: 72054 RVA: 0x0006C270 File Offset: 0x0006A470
		[Token(Token = "0x6011976")]
		[Address(RVA = "0x969880", Offset = "0x968480", VA = "0x180969880")]
		private bool _StopBounceByTraceTargetValidate()
		{
			return default(bool);
		}

		// Token: 0x06011977 RID: 72055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011977")]
		[Address(RVA = "0x969680", Offset = "0x968280", VA = "0x180969680")]
		private void _DoEndBounce()
		{
		}

		// Token: 0x06011978 RID: 72056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011978")]
		[Address(RVA = "0x969990", Offset = "0x968590", VA = "0x180969990")]
		private void _StopProjectile()
		{
		}

		// Token: 0x06011979 RID: 72057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011979")]
		[Address(RVA = "0x969AC0", Offset = "0x9686C0", VA = "0x180969AC0")]
		public BounceHitBehaviour()
		{
		}

		// Token: 0x0601197B RID: 72059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601197B")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x0601197C RID: 72060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601197C")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x04013AA5 RID: 80549
		[Token(Token = "0x4013AA5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _bounceTimesAsDamageTimes;

		// Token: 0x04013AA6 RID: 80550
		[Token(Token = "0x4013AA6")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Inspect("BounceTimesAsDamageTimes")]
		private float _perDamageInterval;

		// Token: 0x04013AA7 RID: 80551
		[Token(Token = "0x4013AA7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _allowRepetitionIfNoTarget;

		// Token: 0x04013AA8 RID: 80552
		[Token(Token = "0x4013AA8")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _isChainLightingUse;

		// Token: 0x04013AA9 RID: 80553
		[Token(Token = "0x4013AA9")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _atkScaleRatePerBounce;

		// Token: 0x04013AAA RID: 80554
		[Token(Token = "0x4013AAA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _canSelectAllExceptTracetarget;

		// Token: 0x04013AAB RID: 80555
		[Token(Token = "0x4013AAB")]
		[FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool _dealHitWithOtherSelector;

		// Token: 0x04013AAC RID: 80556
		[Token(Token = "0x4013AAC")]
		[FieldOffset(Offset = "0xBA")]
		[SerializeField]
		private bool _hitTraceTargetIfNoOtherTarget;

		// Token: 0x04013AAD RID: 80557
		[Token(Token = "0x4013AAD")]
		[FieldOffset(Offset = "0xBB")]
		[SerializeField]
		private bool _useMapPosIfTargetInvalid;

		// Token: 0x04013AAE RID: 80558
		[Token(Token = "0x4013AAE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Inspect("DealHitWithOtherSelector")]
		private TargetSelector _hitSelector;

		// Token: 0x04013AAF RID: 80559
		[Token(Token = "0x4013AAF")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool _fixAllowRepetitionIfNoTarget;

		// Token: 0x04013AB0 RID: 80560
		[Token(Token = "0x4013AB0")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private TargetValidator _bounceConditionValidator;

		// Token: 0x04013AB1 RID: 80561
		[Token(Token = "0x4013AB1")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private bool _onlyApplyAppendAtkScaleAfterStartBounceOnce;

		// Token: 0x04013AB2 RID: 80562
		[Token(Token = "0x4013AB2")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private string _bounceAtkScaleBlackboard;

		// Token: 0x04013AB3 RID: 80563
		[Token(Token = "0x4013AB3")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool _overWriteAtkScale;

		// Token: 0x04013AB4 RID: 80564
		[Token(Token = "0x4013AB4")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _baseAtkScaleBlackboard;

		// Token: 0x04013AB5 RID: 80565
		[Token(Token = "0x4013AB5")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private string _overwritedMainEffectAfterFirstHit;

		// Token: 0x04013AB6 RID: 80566
		[Token(Token = "0x4013AB6")]
		[FieldOffset(Offset = "0x100")]
		[Inspect]
		[ReadOnly]
		private int m_bounceTimes;

		// Token: 0x04013AB7 RID: 80567
		[Token(Token = "0x4013AB7")]
		[FieldOffset(Offset = "0x104")]
		private bool m_validatorsInited;

		// Token: 0x04013AB8 RID: 80568
		[Token(Token = "0x4013AB8")]
		[FieldOffset(Offset = "0x108")]
		private BouncedAdvancedMovement m_movement;

		// Token: 0x04013AB9 RID: 80569
		[Token(Token = "0x4013AB9")]
		[FieldOffset(Offset = "0x110")]
		private List<ObjectPtr<Entity>> m_targetsList;

		// Token: 0x04013ABA RID: 80570
		[Token(Token = "0x4013ABA")]
		[FieldOffset(Offset = "0x118")]
		private float m_maxBounceDamageDuration;

		// Token: 0x04013ABB RID: 80571
		[Token(Token = "0x4013ABB")]
		[FieldOffset(Offset = "0x120")]
		private List<CoroutineId> m_coroutineIdList;

		// Token: 0x04013ABC RID: 80572
		[Token(Token = "0x4013ABC")]
		[FieldOffset(Offset = "0x128")]
		private int m_allBounceTime;

		// Token: 0x04013ABD RID: 80573
		[Token(Token = "0x4013ABD")]
		[FieldOffset(Offset = "0x130")]
		private FP m_atkScaleRatePerBounce;

		// Token: 0x04013ABE RID: 80574
		[Token(Token = "0x4013ABE")]
		[FieldOffset(Offset = "0x138")]
		private FP m_atkScale;

		// Token: 0x04013ABF RID: 80575
		[Token(Token = "0x4013ABF")]
		[FieldOffset(Offset = "0x140")]
		private bool m_hasStartBounce;

		// Token: 0x04013AC0 RID: 80576
		[Token(Token = "0x4013AC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_BounceTimesAsDamageTimes;

		// Token: 0x04013AC1 RID: 80577
		[Token(Token = "0x4013AC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_DealHitWithOtherSelector;

		// Token: 0x04013AC2 RID: 80578
		[Token(Token = "0x4013AC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013AC3 RID: 80579
		[Token(Token = "0x4013AC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013AC4 RID: 80580
		[Token(Token = "0x4013AC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyAtkScale;

		// Token: 0x04013AC5 RID: 80581
		[Token(Token = "0x4013AC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StopBounceByTraceTargetValidate;

		// Token: 0x04013AC6 RID: 80582
		[Token(Token = "0x4013AC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoEndBounce;

		// Token: 0x04013AC7 RID: 80583
		[Token(Token = "0x4013AC7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StopProjectile;

		// Token: 0x04013AC8 RID: 80584
		[Token(Token = "0x4013AC8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
