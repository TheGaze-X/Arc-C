using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BCD RID: 11213
	[Token(Token = "0x2002BCD")]
	public class ThreePartChannelingAnimation : AbilityStandard.Behaviour
	{
		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06012EF8 RID: 77560 RVA: 0x000740A0 File Offset: 0x000722A0
		[Token(Token = "0x170029C1")]
		private bool waitForAttackFinishEvent
		{
			[Token(Token = "0x6012EF8")]
			[Address(RVA = "0xACFFA0", Offset = "0xACEBA0", VA = "0x180ACFFA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06012EF9 RID: 77561 RVA: 0x000740B8 File Offset: 0x000722B8
		[Token(Token = "0x170029C2")]
		protected bool fireAttackFinishEvent
		{
			[Token(Token = "0x6012EF9")]
			[Address(RVA = "0xACFF40", Offset = "0xACEB40", VA = "0x180ACFF40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x06012EFA RID: 77562 RVA: 0x000740D0 File Offset: 0x000722D0
		[Token(Token = "0x170029C3")]
		protected bool delayToFireAttackSkillEvent
		{
			[Token(Token = "0x6012EFA")]
			[Address(RVA = "0xACFEE0", Offset = "0xACEAE0", VA = "0x180ACFEE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x06012EFB RID: 77563 RVA: 0x000740E8 File Offset: 0x000722E8
		[Token(Token = "0x170029C4")]
		protected bool delayToAnimateEndAnimation
		{
			[Token(Token = "0x6012EFB")]
			[Address(RVA = "0xACFE80", Offset = "0xACEA80", VA = "0x180ACFE80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012EFC RID: 77564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EFC")]
		[Address(RVA = "0xACF450", Offset = "0xACE050", VA = "0x180ACF450", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012EFD RID: 77565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EFD")]
		[Address(RVA = "0xACF160", Offset = "0xACDD60", VA = "0x180ACF160", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012EFE RID: 77566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EFE")]
		[Address(RVA = "0xACFCA0", Offset = "0xACE8A0", VA = "0x180ACFCA0")]
		private void _OnStunned(object arg)
		{
		}

		// Token: 0x06012EFF RID: 77567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EFF")]
		[Address(RVA = "0xACF990", Offset = "0xACE590", VA = "0x180ACF990")]
		private void _OnFrozen(object arg)
		{
		}

		// Token: 0x06012F00 RID: 77568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F00")]
		[Address(RVA = "0xACFAE0", Offset = "0xACE6E0", VA = "0x180ACFAE0")]
		private void _OnLevitate(object arg)
		{
		}

		// Token: 0x06012F01 RID: 77569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F01")]
		[Address(RVA = "0xACEF50", Offset = "0xACDB50", VA = "0x180ACEF50", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012F02 RID: 77570 RVA: 0x00074100 File Offset: 0x00072300
		[Token(Token = "0x6012F02")]
		[Address(RVA = "0xACF4F0", Offset = "0xACE0F0", VA = "0x180ACF4F0", Slot = "14")]
		public override bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float playbackSpeed)
		{
			return default(bool);
		}

		// Token: 0x06012F03 RID: 77571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012F03")]
		[Address(RVA = "0xACEE60", Offset = "0xACDA60", VA = "0x180ACEE60")]
		protected IEnumerator DoPlayAnimation(ThreePartChannelingAnimation.AnimationBundle bundle)
		{
			return null;
		}

		// Token: 0x06012F04 RID: 77572 RVA: 0x00074118 File Offset: 0x00072318
		[Token(Token = "0x6012F04")]
		[Address(RVA = "0xACF8B0", Offset = "0xACE4B0", VA = "0x180ACF8B0")]
		private ThreePartChannelingAnimation.AnimationBundle _GetAnimBundle()
		{
			return default(ThreePartChannelingAnimation.AnimationBundle);
		}

		// Token: 0x06012F05 RID: 77573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F05")]
		[Address(RVA = "0xACFC30", Offset = "0xACE830", VA = "0x180ACFC30")]
		private void _OnReceiveAttackFinishEvent(object arg)
		{
		}

		// Token: 0x06012F06 RID: 77574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F06")]
		[Address(RVA = "0xACF7B0", Offset = "0xACE3B0", VA = "0x180ACF7B0")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x06012F07 RID: 77575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F07")]
		[Address(RVA = "0xACFDF0", Offset = "0xACE9F0", VA = "0x180ACFDF0")]
		public ThreePartChannelingAnimation()
		{
		}

		// Token: 0x06012F09 RID: 77577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F09")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012F0A RID: 77578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F0A")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012F0B RID: 77579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F0B")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012F0C RID: 77580 RVA: 0x00074148 File Offset: 0x00072348
		[Token(Token = "0x6012F0C")]
		[Address(RVA = "0xAC3FF0", Offset = "0xAC2BF0", VA = "0x180AC3FF0")]
		private bool <>xLuaBaseProxy_UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming P0, out float P1)
		{
			return default(bool);
		}

		// Token: 0x040155DB RID: 87515
		[Token(Token = "0x40155DB")]
		private const float MAX_CHANNELING_TIME = 360f;

		// Token: 0x040155DC RID: 87516
		[Token(Token = "0x40155DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ThreePartChannelingAnimation.AnimationBundle _default;

		// Token: 0x040155DD RID: 87517
		[Token(Token = "0x40155DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _overrideDownAnimation;

		// Token: 0x040155DE RID: 87518
		[Token(Token = "0x40155DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ThreePartChannelingAnimation.AnimationBundle _down;

		// Token: 0x040155DF RID: 87519
		[Token(Token = "0x40155DF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _overrideUpAnimation;

		// Token: 0x040155E0 RID: 87520
		[Token(Token = "0x40155E0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ThreePartChannelingAnimation.AnimationBundle _up;

		// Token: 0x040155E1 RID: 87521
		[Token(Token = "0x40155E1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _faceToFront;

		// Token: 0x040155E2 RID: 87522
		[Token(Token = "0x40155E2")]
		[FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool _faceToDefault;

		// Token: 0x040155E3 RID: 87523
		[Token(Token = "0x40155E3")]
		[FieldOffset(Offset = "0x7A")]
		[SerializeField]
		private bool _waitForAttachFinishEvent;

		// Token: 0x040155E4 RID: 87524
		[Token(Token = "0x40155E4")]
		[FieldOffset(Offset = "0x7B")]
		[SerializeField]
		[Inspect("waitForAttackFinishEvent")]
		private bool _earlyFinishEndIdleAnimation;

		// Token: 0x040155E5 RID: 87525
		[Token(Token = "0x40155E5")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool _fireAttackFinishEvent;

		// Token: 0x040155E6 RID: 87526
		[Token(Token = "0x40155E6")]
		[FieldOffset(Offset = "0x7D")]
		[SerializeField]
		[Inspect("fireAttackFinishEvent", Condition = true)]
		private bool _delayToFireAttackSkillEvent;

		// Token: 0x040155E7 RID: 87527
		[Token(Token = "0x40155E7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Inspect("delayToFireAttackSkillEvent", Condition = true)]
		private float _delaySecond;

		// Token: 0x040155E8 RID: 87528
		[Token(Token = "0x40155E8")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool _fireAnimEndEvent;

		// Token: 0x040155E9 RID: 87529
		[Token(Token = "0x40155E9")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		private bool _dontPlayBeginAnimFromInterrupted;

		// Token: 0x040155EA RID: 87530
		[Token(Token = "0x40155EA")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		private bool _onlyPlayBeginAnimWhenFirstAttack;

		// Token: 0x040155EB RID: 87531
		[Token(Token = "0x40155EB")]
		[FieldOffset(Offset = "0x87")]
		[SerializeField]
		private bool _delayToAnimateEndAnimation;

		// Token: 0x040155EC RID: 87532
		[Token(Token = "0x40155EC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Inspect("delayToAnimateEndAnimation", true)]
		private float _delayToAnimateEndAnimationTime;

		// Token: 0x040155ED RID: 87533
		[Token(Token = "0x40155ED")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private bool _playIdleAnimInTheEnd;

		// Token: 0x040155EE RID: 87534
		[Token(Token = "0x40155EE")]
		[FieldOffset(Offset = "0x90")]
		private float m_beginAndEndAnimScale;

		// Token: 0x040155EF RID: 87535
		[Token(Token = "0x40155EF")]
		[FieldOffset(Offset = "0x94")]
		private float m_loopTime;

		// Token: 0x040155F0 RID: 87536
		[Token(Token = "0x40155F0")]
		[FieldOffset(Offset = "0x98")]
		private FP m_earlyFinishLoopTime;

		// Token: 0x040155F1 RID: 87537
		[Token(Token = "0x40155F1")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasBeginAnim;

		// Token: 0x040155F2 RID: 87538
		[Token(Token = "0x40155F2")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_hasEndAnim;

		// Token: 0x040155F3 RID: 87539
		[Token(Token = "0x40155F3")]
		[FieldOffset(Offset = "0xA2")]
		private bool m_receivedAttackFinishEvent;

		// Token: 0x040155F4 RID: 87540
		[Token(Token = "0x40155F4")]
		[FieldOffset(Offset = "0xA3")]
		private bool m_recoverFromInterrupted;

		// Token: 0x040155F5 RID: 87541
		[Token(Token = "0x40155F5")]
		[FieldOffset(Offset = "0xA8")]
		private CoroutineId m_coroutine;

		// Token: 0x040155F6 RID: 87542
		[Token(Token = "0x40155F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_waitForAttackFinishEvent;

		// Token: 0x040155F7 RID: 87543
		[Token(Token = "0x40155F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fireAttackFinishEvent;

		// Token: 0x040155F8 RID: 87544
		[Token(Token = "0x40155F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_delayToFireAttackSkillEvent;

		// Token: 0x040155F9 RID: 87545
		[Token(Token = "0x40155F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_delayToAnimateEndAnimation;

		// Token: 0x040155FA RID: 87546
		[Token(Token = "0x40155FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040155FB RID: 87547
		[Token(Token = "0x40155FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040155FC RID: 87548
		[Token(Token = "0x40155FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnStunned;

		// Token: 0x040155FD RID: 87549
		[Token(Token = "0x40155FD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnFrozen;

		// Token: 0x040155FE RID: 87550
		[Token(Token = "0x40155FE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnLevitate;

		// Token: 0x040155FF RID: 87551
		[Token(Token = "0x40155FF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x04015600 RID: 87552
		[Token(Token = "0x4015600")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x04015601 RID: 87553
		[Token(Token = "0x4015601")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoPlayAnimation;

		// Token: 0x04015602 RID: 87554
		[Token(Token = "0x4015602")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetAnimBundle;

		// Token: 0x04015603 RID: 87555
		[Token(Token = "0x4015603")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnReceiveAttackFinishEvent;

		// Token: 0x04015604 RID: 87556
		[Token(Token = "0x4015604")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x04015605 RID: 87557
		[Token(Token = "0x4015605")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BCE RID: 11214
		[Token(Token = "0x2002BCE")]
		[Serializable]
		public struct AnimationBundle
		{
			// Token: 0x04015606 RID: 87558
			[Token(Token = "0x4015606")]
			[FieldOffset(Offset = "0x0")]
			public string beginAnim;

			// Token: 0x04015607 RID: 87559
			[Token(Token = "0x4015607")]
			[FieldOffset(Offset = "0x8")]
			public string loopAnim;

			// Token: 0x04015608 RID: 87560
			[Token(Token = "0x4015608")]
			[FieldOffset(Offset = "0x10")]
			public string endAnim;
		}
	}
}
