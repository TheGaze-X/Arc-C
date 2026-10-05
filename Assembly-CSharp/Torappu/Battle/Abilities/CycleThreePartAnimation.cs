using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BC7 RID: 11207
	[Token(Token = "0x2002BC7")]
	public class CycleThreePartAnimation : AbilityStandard.Behaviour
	{
		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x06012ED1 RID: 77521 RVA: 0x00073FB0 File Offset: 0x000721B0
		// (set) Token: 0x06012ED2 RID: 77522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170029BC")]
		private int curAnimIndex
		{
			[Token(Token = "0x6012ED1")]
			[Address(RVA = "0xAC4530", Offset = "0xAC3130", VA = "0x180AC4530")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6012ED2")]
			[Address(RVA = "0xAC45B0", Offset = "0xAC31B0", VA = "0x180AC45B0")]
			set
			{
			}
		}

		// Token: 0x06012ED3 RID: 77523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ED3")]
		[Address(RVA = "0xAC3F50", Offset = "0xAC2B50", VA = "0x180AC3F50", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012ED4 RID: 77524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ED4")]
		[Address(RVA = "0xAC3C60", Offset = "0xAC2860", VA = "0x180AC3C60", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012ED5 RID: 77525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ED5")]
		[Address(RVA = "0xAC3BE0", Offset = "0xAC27E0", VA = "0x180AC3BE0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012ED6 RID: 77526 RVA: 0x00073FC8 File Offset: 0x000721C8
		[Token(Token = "0x6012ED6")]
		[Address(RVA = "0xAC4000", Offset = "0xAC2C00", VA = "0x180AC4000", Slot = "14")]
		public override bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float playbackSpeed)
		{
			return default(bool);
		}

		// Token: 0x06012ED7 RID: 77527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012ED7")]
		[Address(RVA = "0xAC3870", Offset = "0xAC2470", VA = "0x180AC3870")]
		protected IEnumerator DoPlayAnimation(CycleThreePartAnimation.AnimationBundle bundle)
		{
			return null;
		}

		// Token: 0x06012ED8 RID: 77528 RVA: 0x00073FE0 File Offset: 0x000721E0
		[Token(Token = "0x6012ED8")]
		[Address(RVA = "0xAC3960", Offset = "0xAC2560", VA = "0x180AC3960")]
		protected float InitAnimation()
		{
			return 0f;
		}

		// Token: 0x06012ED9 RID: 77529 RVA: 0x00073FF8 File Offset: 0x000721F8
		[Token(Token = "0x6012ED9")]
		[Address(RVA = "0xAC42D0", Offset = "0xAC2ED0", VA = "0x180AC42D0")]
		private CycleThreePartAnimation.AnimationBundle _GetAnimBundle()
		{
			return default(CycleThreePartAnimation.AnimationBundle);
		}

		// Token: 0x06012EDA RID: 77530 RVA: 0x00074010 File Offset: 0x00072210
		[Token(Token = "0x6012EDA")]
		[Address(RVA = "0xAC4120", Offset = "0xAC2D20", VA = "0x180AC4120")]
		private bool _CheckDownAttack()
		{
			return default(bool);
		}

		// Token: 0x06012EDB RID: 77531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EDB")]
		[Address(RVA = "0xAC41D0", Offset = "0xAC2DD0", VA = "0x180AC41D0")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x06012EDC RID: 77532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EDC")]
		[Address(RVA = "0xAC44C0", Offset = "0xAC30C0", VA = "0x180AC44C0")]
		public CycleThreePartAnimation()
		{
		}

		// Token: 0x06012EDD RID: 77533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EDD")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012EDE RID: 77534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EDE")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012EDF RID: 77535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EDF")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012EE0 RID: 77536 RVA: 0x00074028 File Offset: 0x00072228
		[Token(Token = "0x6012EE0")]
		[Address(RVA = "0xAC3FF0", Offset = "0xAC2BF0", VA = "0x180AC3FF0")]
		private bool <>xLuaBaseProxy_UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming P0, out float P1)
		{
			return default(bool);
		}

		// Token: 0x040155AD RID: 87469
		[Token(Token = "0x40155AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CycleThreePartAnimation.AnimationGroup[] _animGroups;

		// Token: 0x040155AE RID: 87470
		[Token(Token = "0x40155AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _faceToTarget;

		// Token: 0x040155AF RID: 87471
		[Token(Token = "0x40155AF")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _fixAnimWhenCooldownSlow;

		// Token: 0x040155B0 RID: 87472
		[Token(Token = "0x40155B0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minAnimScale;

		// Token: 0x040155B1 RID: 87473
		[Token(Token = "0x40155B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxAnimScale;

		// Token: 0x040155B2 RID: 87474
		[Token(Token = "0x40155B2")]
		[FieldOffset(Offset = "0x34")]
		private float m_animSpeed;

		// Token: 0x040155B3 RID: 87475
		[Token(Token = "0x40155B3")]
		[FieldOffset(Offset = "0x38")]
		private CoroutineId m_coroutine;

		// Token: 0x040155B4 RID: 87476
		[Token(Token = "0x40155B4")]
		[FieldOffset(Offset = "0x48")]
		private int m_curAnimIndex;

		// Token: 0x040155B5 RID: 87477
		[Token(Token = "0x40155B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curAnimIndex;

		// Token: 0x040155B6 RID: 87478
		[Token(Token = "0x40155B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_curAnimIndex;

		// Token: 0x040155B7 RID: 87479
		[Token(Token = "0x40155B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040155B8 RID: 87480
		[Token(Token = "0x40155B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040155B9 RID: 87481
		[Token(Token = "0x40155B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040155BA RID: 87482
		[Token(Token = "0x40155BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x040155BB RID: 87483
		[Token(Token = "0x40155BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoPlayAnimation;

		// Token: 0x040155BC RID: 87484
		[Token(Token = "0x40155BC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitAnimation;

		// Token: 0x040155BD RID: 87485
		[Token(Token = "0x40155BD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetAnimBundle;

		// Token: 0x040155BE RID: 87486
		[Token(Token = "0x40155BE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckDownAttack;

		// Token: 0x040155BF RID: 87487
		[Token(Token = "0x40155BF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x040155C0 RID: 87488
		[Token(Token = "0x40155C0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BC8 RID: 11208
		[Token(Token = "0x2002BC8")]
		[Serializable]
		public struct AnimationBundle
		{
			// Token: 0x040155C1 RID: 87489
			[Token(Token = "0x40155C1")]
			[FieldOffset(Offset = "0x0")]
			public string beginAnim;

			// Token: 0x040155C2 RID: 87490
			[Token(Token = "0x40155C2")]
			[FieldOffset(Offset = "0x8")]
			public string attackAnim;

			// Token: 0x040155C3 RID: 87491
			[Token(Token = "0x40155C3")]
			[FieldOffset(Offset = "0x10")]
			public string endAnim;
		}

		// Token: 0x02002BC9 RID: 11209
		[Token(Token = "0x2002BC9")]
		[Serializable]
		public struct AnimationGroup
		{
			// Token: 0x040155C4 RID: 87492
			[Token(Token = "0x40155C4")]
			[FieldOffset(Offset = "0x0")]
			public CycleThreePartAnimation.AnimationBundle normal;

			// Token: 0x040155C5 RID: 87493
			[Token(Token = "0x40155C5")]
			[FieldOffset(Offset = "0x18")]
			public bool _overrideDownAnimation;

			// Token: 0x040155C6 RID: 87494
			[Token(Token = "0x40155C6")]
			[FieldOffset(Offset = "0x20")]
			public CycleThreePartAnimation.AnimationBundle down;
		}
	}
}
