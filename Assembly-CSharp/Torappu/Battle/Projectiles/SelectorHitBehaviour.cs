using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029AF RID: 10671
	[Token(Token = "0x20029AF")]
	public class SelectorHitBehaviour : Projectile.Behaviour, IEffectSource
	{
		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x06011AB7 RID: 72375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026F3")]
		protected TargetSelector selector
		{
			[Token(Token = "0x6011AB7")]
			[Address(RVA = "0x9865E0", Offset = "0x9851E0", VA = "0x1809865E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x06011AB8 RID: 72376 RVA: 0x0006C540 File Offset: 0x0006A740
		[Token(Token = "0x170026F4")]
		protected bool playAudioWhenSelect
		{
			[Token(Token = "0x6011AB8")]
			[Address(RVA = "0x986520", Offset = "0x985120", VA = "0x180986520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x06011AB9 RID: 72377 RVA: 0x0006C558 File Offset: 0x0006A758
		[Token(Token = "0x170026F5")]
		public bool selectEffectOnGround
		{
			[Token(Token = "0x6011AB9")]
			[Address(RVA = "0x986580", Offset = "0x985180", VA = "0x180986580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x06011ABA RID: 72378 RVA: 0x0006C570 File Offset: 0x0006A770
		[Token(Token = "0x170026F6")]
		protected virtual bool checkHitWhenTick
		{
			[Token(Token = "0x6011ABA")]
			[Address(RVA = "0x9863E0", Offset = "0x984FE0", VA = "0x1809863E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x06011ABB RID: 72379 RVA: 0x0006C588 File Offset: 0x0006A788
		[Token(Token = "0x170026F7")]
		protected bool limitedTimeUsedUp
		{
			[Token(Token = "0x6011ABB")]
			[Address(RVA = "0x9864B0", Offset = "0x9850B0", VA = "0x1809864B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x06011ABC RID: 72380 RVA: 0x0006C5A0 File Offset: 0x0006A7A0
		// (set) Token: 0x06011ABD RID: 72381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170026F8")]
		protected int currentHitTimes
		{
			[Token(Token = "0x6011ABC")]
			[Address(RVA = "0x986450", Offset = "0x985050", VA = "0x180986450")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6011ABD")]
			[Address(RVA = "0x986640", Offset = "0x985240", VA = "0x180986640")]
			set
			{
			}
		}

		// Token: 0x06011ABE RID: 72382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ABE")]
		[Address(RVA = "0x985320", Offset = "0x983F20", VA = "0x180985320", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011ABF RID: 72383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ABF")]
		[Address(RVA = "0x985B70", Offset = "0x984770", VA = "0x180985B70", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011AC0 RID: 72384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AC0")]
		[Address(RVA = "0x984F50", Offset = "0x983B50", VA = "0x180984F50", Slot = "17")]
		protected virtual void DoOnTimerUpdated()
		{
		}

		// Token: 0x06011AC1 RID: 72385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AC1")]
		[Address(RVA = "0x985A10", Offset = "0x984610", VA = "0x180985A10", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011AC2 RID: 72386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AC2")]
		[Address(RVA = "0x985AB0", Offset = "0x9846B0", VA = "0x180985AB0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011AC3 RID: 72387 RVA: 0x0006C5B8 File Offset: 0x0006A7B8
		[Token(Token = "0x6011AC3")]
		[Address(RVA = "0x984E40", Offset = "0x983A40", VA = "0x180984E40", Slot = "18")]
		protected virtual bool DealHitTarget(Entity target, bool force)
		{
			return default(bool);
		}

		// Token: 0x06011AC4 RID: 72388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AC4")]
		[Address(RVA = "0x985280", Offset = "0x983E80", VA = "0x180985280", Slot = "15")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011AC5 RID: 72389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AC5")]
		[Address(RVA = "0x984FF0", Offset = "0x983BF0", VA = "0x180984FF0", Slot = "19")]
		protected virtual void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011AC6 RID: 72390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AC6")]
		[Address(RVA = "0x985FE0", Offset = "0x984BE0", VA = "0x180985FE0")]
		protected void _PlayEffectsWhenSelect()
		{
		}

		// Token: 0x06011AC7 RID: 72391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011AC7")]
		[Address(RVA = "0x985E50", Offset = "0x984A50", VA = "0x180985E50", Slot = "20")]
		protected virtual ReusableList<Entity> _FindTargets_DISPOSE(Vector2 inputPos)
		{
			return null;
		}

		// Token: 0x06011AC8 RID: 72392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AC8")]
		[Address(RVA = "0x986290", Offset = "0x984E90", VA = "0x180986290")]
		public SelectorHitBehaviour()
		{
		}

		// Token: 0x06011AC9 RID: 72393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AC9")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011ACA RID: 72394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ACA")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011ACB RID: 72395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ACB")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x06011ACC RID: 72396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ACC")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013CBC RID: 81084
		[Token(Token = "0x4013CBC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TargetSelector _selector;

		// Token: 0x04013CBD RID: 81085
		[Token(Token = "0x4013CBD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _resetRangeSelectorByBB;

		// Token: 0x04013CBE RID: 81086
		[Token(Token = "0x4013CBE")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _ignoreRangeScale;

		// Token: 0x04013CBF RID: 81087
		[Token(Token = "0x4013CBF")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _interval;

		// Token: 0x04013CC0 RID: 81088
		[Token(Token = "0x4013CC0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _waitFirstPeriod;

		// Token: 0x04013CC1 RID: 81089
		[Token(Token = "0x4013CC1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _firstPeriod;

		// Token: 0x04013CC2 RID: 81090
		[Token(Token = "0x4013CC2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _onlyCheckHitWhenReachTarget;

		// Token: 0x04013CC3 RID: 81091
		[Token(Token = "0x4013CC3")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _onlyCheckHitWhenStop;

		// Token: 0x04013CC4 RID: 81092
		[Token(Token = "0x4013CC4")]
		[FieldOffset(Offset = "0x42")]
		[SerializeField]
		private bool _exceptTraceTarget;

		// Token: 0x04013CC5 RID: 81093
		[Token(Token = "0x4013CC5")]
		[FieldOffset(Offset = "0x43")]
		[SerializeField]
		private bool _hitPasserby;

		// Token: 0x04013CC6 RID: 81094
		[Token(Token = "0x4013CC6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _ignoreSmallEps;

		// Token: 0x04013CC7 RID: 81095
		[Token(Token = "0x4013CC7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _effectsWhenSelectPredict;

		// Token: 0x04013CC8 RID: 81096
		[Token(Token = "0x4013CC8")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _selectEffectOnGround;

		// Token: 0x04013CC9 RID: 81097
		[Token(Token = "0x4013CC9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected string[] _effectsWhenSelect;

		// Token: 0x04013CCA RID: 81098
		[Token(Token = "0x4013CCA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _playAudioWhenSelect;

		// Token: 0x04013CCB RID: 81099
		[Token(Token = "0x4013CCB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _intervalBbKey;

		// Token: 0x04013CCC RID: 81100
		[Token(Token = "0x4013CCC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _limitedHitTimesBbKey;

		// Token: 0x04013CCD RID: 81101
		[Token(Token = "0x4013CCD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _limitedHitTimes;

		// Token: 0x04013CCE RID: 81102
		[Token(Token = "0x4013CCE")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool _stopWhenLimitedHitTimesUsedUp;

		// Token: 0x04013CCF RID: 81103
		[Token(Token = "0x4013CCF")]
		[FieldOffset(Offset = "0x78")]
		private PeriodicTimer m_periodicTimer;

		// Token: 0x04013CD0 RID: 81104
		[Token(Token = "0x4013CD0")]
		[FieldOffset(Offset = "0x80")]
		protected float m_effectsWhenSelectPredict;

		// Token: 0x04013CD1 RID: 81105
		[Token(Token = "0x4013CD1")]
		[FieldOffset(Offset = "0x84")]
		protected bool m_effectsWhenSelectPredictPlayed;

		// Token: 0x04013CD2 RID: 81106
		[Token(Token = "0x4013CD2")]
		[FieldOffset(Offset = "0x88")]
		protected List<string> m_effectsWhenSelect;

		// Token: 0x04013CD3 RID: 81107
		[Token(Token = "0x4013CD3")]
		[FieldOffset(Offset = "0x90")]
		private float m_targetGroundPosZ;

		// Token: 0x04013CD4 RID: 81108
		[Token(Token = "0x4013CD4")]
		[FieldOffset(Offset = "0x94")]
		private int m_limitedHitTimes;

		// Token: 0x04013CD5 RID: 81109
		[Token(Token = "0x4013CD5")]
		[FieldOffset(Offset = "0x98")]
		private int m_currentHitTimes;

		// Token: 0x04013CD6 RID: 81110
		[Token(Token = "0x4013CD6")]
		[FieldOffset(Offset = "0xA0")]
		private ILocatable m_target;

		// Token: 0x04013CD7 RID: 81111
		[Token(Token = "0x4013CD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selector;

		// Token: 0x04013CD8 RID: 81112
		[Token(Token = "0x4013CD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playAudioWhenSelect;

		// Token: 0x04013CD9 RID: 81113
		[Token(Token = "0x4013CD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectEffectOnGround;

		// Token: 0x04013CDA RID: 81114
		[Token(Token = "0x4013CDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_checkHitWhenTick;

		// Token: 0x04013CDB RID: 81115
		[Token(Token = "0x4013CDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_limitedTimeUsedUp;

		// Token: 0x04013CDC RID: 81116
		[Token(Token = "0x4013CDC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentHitTimes;

		// Token: 0x04013CDD RID: 81117
		[Token(Token = "0x4013CDD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_currentHitTimes;

		// Token: 0x04013CDE RID: 81118
		[Token(Token = "0x4013CDE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013CDF RID: 81119
		[Token(Token = "0x4013CDF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013CE0 RID: 81120
		[Token(Token = "0x4013CE0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoOnTimerUpdated;

		// Token: 0x04013CE1 RID: 81121
		[Token(Token = "0x4013CE1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013CE2 RID: 81122
		[Token(Token = "0x4013CE2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013CE3 RID: 81123
		[Token(Token = "0x4013CE3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013CE4 RID: 81124
		[Token(Token = "0x4013CE4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013CE5 RID: 81125
		[Token(Token = "0x4013CE5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013CE6 RID: 81126
		[Token(Token = "0x4013CE6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PlayEffectsWhenSelect;

		// Token: 0x04013CE7 RID: 81127
		[Token(Token = "0x4013CE7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__FindTargets_DISPOSE;

		// Token: 0x04013CE8 RID: 81128
		[Token(Token = "0x4013CE8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
