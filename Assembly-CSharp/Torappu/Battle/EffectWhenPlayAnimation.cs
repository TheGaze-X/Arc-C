using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002102 RID: 8450
	[Token(Token = "0x2002102")]
	public class EffectWhenPlayAnimation : UnitAnimator.Behaviour, IEffectSource
	{
		// Token: 0x0600CF1F RID: 53023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF1F")]
		[Address(RVA = "0x350D4E0", Offset = "0x350C0E0", VA = "0x18350D4E0", Slot = "5")]
		public override void OnFinish()
		{
		}

		// Token: 0x0600CF20 RID: 53024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF20")]
		[Address(RVA = "0x350D3D0", Offset = "0x350BFD0", VA = "0x18350D3D0", Slot = "7")]
		public override void OnEvent(UnitAnimator.Behaviour.Event ev, ValueBundle arg)
		{
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF21")]
		[Address(RVA = "0x350D880", Offset = "0x350C480", VA = "0x18350D880")]
		private void _OnPlayAnimation(string animationName, bool isPlay)
		{
		}

		// Token: 0x0600CF22 RID: 53026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF22")]
		[Address(RVA = "0x350DC50", Offset = "0x350C850", VA = "0x18350DC50")]
		private void _PlayEffect(EffectWhenPlayAnimation.AnimationEffectOption option)
		{
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF23")]
		[Address(RVA = "0x350D200", Offset = "0x350BE00", VA = "0x18350D200", Slot = "8")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF24")]
		[Address(RVA = "0x350E0E0", Offset = "0x350CCE0", VA = "0x18350E0E0")]
		public EffectWhenPlayAnimation()
		{
		}

		// Token: 0x0600CF25 RID: 53029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF25")]
		[Address(RVA = "0x35093A0", Offset = "0x3507FA0", VA = "0x1835093A0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600CF26 RID: 53030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF26")]
		[Address(RVA = "0x350D850", Offset = "0x350C450", VA = "0x18350D850")]
		private void <>xLuaBaseProxy_OnEvent(UnitAnimator.Behaviour.Event P0, ValueBundle P1)
		{
		}

		// Token: 0x0400DCE3 RID: 56547
		[Token(Token = "0x400DCE3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<EffectWhenPlayAnimation.AnimationEffectOption> _animationEffectOptions;

		// Token: 0x0400DCE4 RID: 56548
		[Token(Token = "0x400DCE4")]
		[FieldOffset(Offset = "0x28")]
		private string m_lastAnimationName;

		// Token: 0x0400DCE5 RID: 56549
		[Token(Token = "0x400DCE5")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, List<ObjectPtr<Effect>>> m_allEffects;

		// Token: 0x0400DCE6 RID: 56550
		[Token(Token = "0x400DCE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400DCE7 RID: 56551
		[Token(Token = "0x400DCE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0400DCE8 RID: 56552
		[Token(Token = "0x400DCE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnPlayAnimation;

		// Token: 0x0400DCE9 RID: 56553
		[Token(Token = "0x400DCE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEffect;

		// Token: 0x0400DCEA RID: 56554
		[Token(Token = "0x400DCEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400DCEB RID: 56555
		[Token(Token = "0x400DCEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002103 RID: 8451
		[Token(Token = "0x2002103")]
		[Serializable]
		public class AnimationEffectOption : IEffectSource
		{
			// Token: 0x0600CF27 RID: 53031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF27")]
			[Address(RVA = "0x3509470", Offset = "0x3508070", VA = "0x183509470", Slot = "4")]
			public void GatherEffects(List<string> effects)
			{
			}

			// Token: 0x0600CF28 RID: 53032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF28")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AnimationEffectOption()
			{
			}

			// Token: 0x0400DCEC RID: 56556
			[Token(Token = "0x400DCEC")]
			[FieldOffset(Offset = "0x10")]
			public string animationName;

			// Token: 0x0400DCED RID: 56557
			[Token(Token = "0x400DCED")]
			[FieldOffset(Offset = "0x18")]
			public List<string> effects;

			// Token: 0x0400DCEE RID: 56558
			[Token(Token = "0x400DCEE")]
			[FieldOffset(Offset = "0x20")]
			public bool oneShot;
		}
	}
}
