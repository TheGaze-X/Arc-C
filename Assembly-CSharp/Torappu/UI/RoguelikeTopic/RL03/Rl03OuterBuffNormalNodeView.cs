using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045D3 RID: 17875
	[Token(Token = "0x20045D3")]
	public class Rl03OuterBuffNormalNodeView : Rl03OuterBuffNodeBaseView<Rl03OuterBuffNormalNodeViewModel>, IHotfixable
	{
		// Token: 0x0601B308 RID: 111368 RVA: 0x000A4928 File Offset: 0x000A2B28
		[Token(Token = "0x601B308")]
		[Address(RVA = "0x1458380", Offset = "0x1456F80", VA = "0x181458380", Slot = "4")]
		public override Rl03OuterBuffViewType GetType()
		{
			return Rl03OuterBuffViewType.NORMAL;
		}

		// Token: 0x0601B309 RID: 111369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B309")]
		[Address(RVA = "0x14583E0", Offset = "0x1456FE0", VA = "0x1814583E0", Slot = "7")]
		public override void Init(Rl03OuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601B30A RID: 111370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B30A")]
		[Address(RVA = "0x1458860", Offset = "0x1457460", VA = "0x181458860", Slot = "8")]
		public override void Render(string selectedBuffId, Rl03OuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601B30B RID: 111371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B30B")]
		[Address(RVA = "0x14589C0", Offset = "0x14575C0", VA = "0x1814589C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B30C RID: 111372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B30C")]
		[Address(RVA = "0x1458C30", Offset = "0x1457830", VA = "0x181458C30")]
		private void _InitNodeStatus(Rl03OuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601B30D RID: 111373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B30D")]
		[Address(RVA = "0x1458AC0", Offset = "0x14576C0", VA = "0x181458AC0")]
		private void _InitLightStatus(Rl03OuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601B30E RID: 111374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B30E")]
		[Address(RVA = "0x1458D70", Offset = "0x1457970", VA = "0x181458D70")]
		private void _PlayActiveAnim(Rl03OuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601B30F RID: 111375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B30F")]
		[Address(RVA = "0x1458FD0", Offset = "0x1457BD0", VA = "0x181458FD0")]
		private void _PlayUnlockAnim(Rl03OuterBuffNormalNodeViewModel model)
		{
		}

		// Token: 0x0601B310 RID: 111376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B310")]
		[Address(RVA = "0x14587E0", Offset = "0x14573E0", VA = "0x1814587E0")]
		public void OnClick()
		{
		}

		// Token: 0x0601B311 RID: 111377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B311")]
		[Address(RVA = "0x1459190", Offset = "0x1457D90", VA = "0x181459190")]
		public Rl03OuterBuffNormalNodeView()
		{
		}

		// Token: 0x04023083 RID: 143491
		[Token(Token = "0x4023083")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04023084 RID: 143492
		[Token(Token = "0x4023084")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04023085 RID: 143493
		[Token(Token = "0x4023085")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _unlockLightAnim;

		// Token: 0x04023086 RID: 143494
		[Token(Token = "0x4023086")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x04023087 RID: 143495
		[Token(Token = "0x4023087")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _activeLightAnim;

		// Token: 0x04023088 RID: 143496
		[Token(Token = "0x4023088")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _activeAnimDelay;

		// Token: 0x04023089 RID: 143497
		[Token(Token = "0x4023089")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _unlockAnimDelay;

		// Token: 0x0402308A RID: 143498
		[Token(Token = "0x402308A")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0402308B RID: 143499
		[Token(Token = "0x402308B")]
		[FieldOffset(Offset = "0x90")]
		private string m_buffId;

		// Token: 0x0402308C RID: 143500
		[Token(Token = "0x402308C")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isUnlock;

		// Token: 0x0402308D RID: 143501
		[Token(Token = "0x402308D")]
		[FieldOffset(Offset = "0x99")]
		private bool m_isActive;

		// Token: 0x0402308E RID: 143502
		[Token(Token = "0x402308E")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_nodeTween;

		// Token: 0x0402308F RID: 143503
		[Token(Token = "0x402308F")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_lightTween;

		// Token: 0x04023090 RID: 143504
		[Token(Token = "0x4023090")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023091 RID: 143505
		[Token(Token = "0x4023091")]
		[FieldOffset(Offset = "0xC0")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x04023092 RID: 143506
		[Token(Token = "0x4023092")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetType;

		// Token: 0x04023093 RID: 143507
		[Token(Token = "0x4023093")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023094 RID: 143508
		[Token(Token = "0x4023094")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023095 RID: 143509
		[Token(Token = "0x4023095")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023096 RID: 143510
		[Token(Token = "0x4023096")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitNodeStatus;

		// Token: 0x04023097 RID: 143511
		[Token(Token = "0x4023097")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitLightStatus;

		// Token: 0x04023098 RID: 143512
		[Token(Token = "0x4023098")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayActiveAnim;

		// Token: 0x04023099 RID: 143513
		[Token(Token = "0x4023099")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayUnlockAnim;

		// Token: 0x0402309A RID: 143514
		[Token(Token = "0x402309A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402309B RID: 143515
		[Token(Token = "0x402309B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
