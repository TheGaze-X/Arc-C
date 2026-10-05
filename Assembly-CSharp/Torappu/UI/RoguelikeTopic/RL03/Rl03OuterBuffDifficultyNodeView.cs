using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045CB RID: 17867
	[Token(Token = "0x20045CB")]
	public class Rl03OuterBuffDifficultyNodeView : Rl03OuterBuffNodeBaseView<Rl03OuterBuffDifficultyNodeViewModel>, IHotfixable
	{
		// Token: 0x0601B2E8 RID: 111336 RVA: 0x000A48F8 File Offset: 0x000A2AF8
		[Token(Token = "0x601B2E8")]
		[Address(RVA = "0x1456F60", Offset = "0x1455B60", VA = "0x181456F60", Slot = "4")]
		public override Rl03OuterBuffViewType GetType()
		{
			return Rl03OuterBuffViewType.NORMAL;
		}

		// Token: 0x0601B2E9 RID: 111337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2E9")]
		[Address(RVA = "0x1456FC0", Offset = "0x1455BC0", VA = "0x181456FC0", Slot = "7")]
		public override void Init(Rl03OuterBuffDifficultyNodeViewModel model)
		{
		}

		// Token: 0x0601B2EA RID: 111338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2EA")]
		[Address(RVA = "0x14572C0", Offset = "0x1455EC0", VA = "0x1814572C0", Slot = "8")]
		public override void Render(string selectedBuffId, Rl03OuterBuffDifficultyNodeViewModel model)
		{
		}

		// Token: 0x0601B2EB RID: 111339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2EB")]
		[Address(RVA = "0x1457450", Offset = "0x1456050", VA = "0x181457450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B2EC RID: 111340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2EC")]
		[Address(RVA = "0x1457540", Offset = "0x1456140", VA = "0x181457540")]
		private void _PlayActiveAnim(Rl03OuterBuffDifficultyNodeViewModel model)
		{
		}

		// Token: 0x0601B2ED RID: 111341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2ED")]
		[Address(RVA = "0x1457250", Offset = "0x1455E50", VA = "0x181457250")]
		public void OnClick()
		{
		}

		// Token: 0x0601B2EE RID: 111342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2EE")]
		[Address(RVA = "0x14576F0", Offset = "0x14562F0", VA = "0x1814576F0")]
		public Rl03OuterBuffDifficultyNodeView()
		{
		}

		// Token: 0x0402304B RID: 143435
		[Token(Token = "0x402304B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402304C RID: 143436
		[Token(Token = "0x402304C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0402304D RID: 143437
		[Token(Token = "0x402304D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x0402304E RID: 143438
		[Token(Token = "0x402304E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _animDelay;

		// Token: 0x0402304F RID: 143439
		[Token(Token = "0x402304F")]
		[FieldOffset(Offset = "0x64")]
		private bool m_isInited;

		// Token: 0x04023050 RID: 143440
		[Token(Token = "0x4023050")]
		[FieldOffset(Offset = "0x68")]
		private string m_buffId;

		// Token: 0x04023051 RID: 143441
		[Token(Token = "0x4023051")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isActive;

		// Token: 0x04023052 RID: 143442
		[Token(Token = "0x4023052")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_tween;

		// Token: 0x04023053 RID: 143443
		[Token(Token = "0x4023053")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023054 RID: 143444
		[Token(Token = "0x4023054")]
		[FieldOffset(Offset = "0x90")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x04023055 RID: 143445
		[Token(Token = "0x4023055")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetType;

		// Token: 0x04023056 RID: 143446
		[Token(Token = "0x4023056")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023057 RID: 143447
		[Token(Token = "0x4023057")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023058 RID: 143448
		[Token(Token = "0x4023058")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023059 RID: 143449
		[Token(Token = "0x4023059")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayActiveAnim;

		// Token: 0x0402305A RID: 143450
		[Token(Token = "0x402305A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402305B RID: 143451
		[Token(Token = "0x402305B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
