using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BD0 RID: 11216
	[Token(Token = "0x2002BD0")]
	public class ThreePartOneshotAnimation : AbilityStandard.Behaviour
	{
		// Token: 0x06012F13 RID: 77587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F13")]
		[Address(RVA = "0xAEC2D0", Offset = "0xAEAED0", VA = "0x180AEC2D0", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06012F14 RID: 77588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F14")]
		[Address(RVA = "0xAEC720", Offset = "0xAEB320", VA = "0x180AEC720", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F15 RID: 77589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F15")]
		[Address(RVA = "0xAEC430", Offset = "0xAEB030", VA = "0x180AEC430", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012F16 RID: 77590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F16")]
		[Address(RVA = "0xAEC3B0", Offset = "0xAEAFB0", VA = "0x180AEC3B0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012F17 RID: 77591 RVA: 0x00074178 File Offset: 0x00072378
		[Token(Token = "0x6012F17")]
		[Address(RVA = "0xAEC7B0", Offset = "0xAEB3B0", VA = "0x180AEC7B0", Slot = "14")]
		public override bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float playbackSpeed)
		{
			return default(bool);
		}

		// Token: 0x06012F18 RID: 77592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012F18")]
		[Address(RVA = "0xAEBF40", Offset = "0xAEAB40", VA = "0x180AEBF40")]
		protected IEnumerator DoPlayAnimation(ThreePartOneshotAnimation.AnimationBundle bundle)
		{
			return null;
		}

		// Token: 0x06012F19 RID: 77593 RVA: 0x00074190 File Offset: 0x00072390
		[Token(Token = "0x6012F19")]
		[Address(RVA = "0xAEC030", Offset = "0xAEAC30", VA = "0x180AEC030")]
		protected float InitAnimation()
		{
			return 0f;
		}

		// Token: 0x06012F1A RID: 77594 RVA: 0x000741A8 File Offset: 0x000723A8
		[Token(Token = "0x6012F1A")]
		[Address(RVA = "0xAECA80", Offset = "0xAEB680", VA = "0x180AECA80")]
		private ThreePartOneshotAnimation.AnimationBundle _GetAnimBundle()
		{
			return default(ThreePartOneshotAnimation.AnimationBundle);
		}

		// Token: 0x06012F1B RID: 77595 RVA: 0x000741C0 File Offset: 0x000723C0
		[Token(Token = "0x6012F1B")]
		[Address(RVA = "0xAEC8D0", Offset = "0xAEB4D0", VA = "0x180AEC8D0")]
		private bool _CheckDownAttack()
		{
			return default(bool);
		}

		// Token: 0x06012F1C RID: 77596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F1C")]
		[Address(RVA = "0xAEC980", Offset = "0xAEB580", VA = "0x180AEC980")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x06012F1D RID: 77597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F1D")]
		[Address(RVA = "0xAECBC0", Offset = "0xAEB7C0", VA = "0x180AECBC0")]
		public ThreePartOneshotAnimation()
		{
		}

		// Token: 0x06012F1E RID: 77598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F1E")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x06012F1F RID: 77599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F1F")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012F20 RID: 77600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F20")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012F21 RID: 77601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F21")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012F22 RID: 77602 RVA: 0x000741D8 File Offset: 0x000723D8
		[Token(Token = "0x6012F22")]
		[Address(RVA = "0xAC3FF0", Offset = "0xAC2BF0", VA = "0x180AC3FF0")]
		private bool <>xLuaBaseProxy_UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming P0, out float P1)
		{
			return default(bool);
		}

		// Token: 0x0401560E RID: 87566
		[Token(Token = "0x401560E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _beginAnim;

		// Token: 0x0401560F RID: 87567
		[Token(Token = "0x401560F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _oneshotAnim;

		// Token: 0x04015610 RID: 87568
		[Token(Token = "0x4015610")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _endAnim;

		// Token: 0x04015611 RID: 87569
		[Token(Token = "0x4015611")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _fixAnimWhenCooldownSlow;

		// Token: 0x04015612 RID: 87570
		[Token(Token = "0x4015612")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _overrideDownAnimation;

		// Token: 0x04015613 RID: 87571
		[Token(Token = "0x4015613")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ThreePartOneshotAnimation.AnimationBundle _down;

		// Token: 0x04015614 RID: 87572
		[Token(Token = "0x4015614")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _faceToTarget;

		// Token: 0x04015615 RID: 87573
		[Token(Token = "0x4015615")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _minAnimScale;

		// Token: 0x04015616 RID: 87574
		[Token(Token = "0x4015616")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _maxAnimScale;

		// Token: 0x04015617 RID: 87575
		[Token(Token = "0x4015617")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool _onlyPlayBeginAnimWhenFirstAttack;

		// Token: 0x04015618 RID: 87576
		[Token(Token = "0x4015618")]
		[FieldOffset(Offset = "0x68")]
		private float m_animSpeed;

		// Token: 0x04015619 RID: 87577
		[Token(Token = "0x4015619")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_hasBeginAnim;

		// Token: 0x0401561A RID: 87578
		[Token(Token = "0x401561A")]
		[FieldOffset(Offset = "0x6D")]
		private bool m_hasEndAnim;

		// Token: 0x0401561B RID: 87579
		[Token(Token = "0x401561B")]
		[FieldOffset(Offset = "0x70")]
		private CoroutineId m_coroutine;

		// Token: 0x0401561C RID: 87580
		[Token(Token = "0x401561C")]
		[FieldOffset(Offset = "0x80")]
		private ThreePartOneshotAnimation.AnimationBundle m_default;

		// Token: 0x0401561D RID: 87581
		[Token(Token = "0x401561D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401561E RID: 87582
		[Token(Token = "0x401561E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401561F RID: 87583
		[Token(Token = "0x401561F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015620 RID: 87584
		[Token(Token = "0x4015620")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x04015621 RID: 87585
		[Token(Token = "0x4015621")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x04015622 RID: 87586
		[Token(Token = "0x4015622")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoPlayAnimation;

		// Token: 0x04015623 RID: 87587
		[Token(Token = "0x4015623")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitAnimation;

		// Token: 0x04015624 RID: 87588
		[Token(Token = "0x4015624")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetAnimBundle;

		// Token: 0x04015625 RID: 87589
		[Token(Token = "0x4015625")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckDownAttack;

		// Token: 0x04015626 RID: 87590
		[Token(Token = "0x4015626")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x04015627 RID: 87591
		[Token(Token = "0x4015627")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BD1 RID: 11217
		[Token(Token = "0x2002BD1")]
		[Serializable]
		public struct AnimationBundle
		{
			// Token: 0x04015628 RID: 87592
			[Token(Token = "0x4015628")]
			[FieldOffset(Offset = "0x0")]
			public string beginAnim;

			// Token: 0x04015629 RID: 87593
			[Token(Token = "0x4015629")]
			[FieldOffset(Offset = "0x8")]
			public string oneshotAnim;

			// Token: 0x0401562A RID: 87594
			[Token(Token = "0x401562A")]
			[FieldOffset(Offset = "0x10")]
			public string endAnim;
		}
	}
}
