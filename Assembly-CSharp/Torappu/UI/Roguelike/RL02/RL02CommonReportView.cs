using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200574A RID: 22346
	[Token(Token = "0x200574A")]
	public abstract class RL02CommonReportView<TModel> : RL02CommonReportViewBase where TModel : RL02EndingFrameReportViewModel
	{
		// Token: 0x06020BEA RID: 134122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BEA")]
		public sealed override void Show(RL02EndingFrameReportViewModel viewModel, bool isForward)
		{
		}

		// Token: 0x06020BEB RID: 134123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020BEB")]
		public sealed override IEnumerator Hide()
		{
			return null;
		}

		// Token: 0x06020BEC RID: 134124
		[Token(Token = "0x6020BEC")]
		protected abstract string GetShowAnimName();

		// Token: 0x06020BED RID: 134125
		[Token(Token = "0x6020BED")]
		protected abstract void Render(TModel viewModel);

		// Token: 0x06020BEE RID: 134126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BEE")]
		protected RL02CommonReportView()
		{
		}

		// Token: 0x0402C73F RID: 182079
		[Token(Token = "0x402C73F")]
		private const float FADE_ANIM_DURATION = 0.16f;

		// Token: 0x0402C740 RID: 182080
		[Token(Token = "0x402C740")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402C741 RID: 182081
		[Token(Token = "0x402C741")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private AnimationWrapper _showAnimWrapper;

		// Token: 0x0402C742 RID: 182082
		[Token(Token = "0x402C742")]
		[FieldOffset(Offset = "0x0")]
		private bool m_hasPlayedAnim;

		// Token: 0x0402C743 RID: 182083
		[Token(Token = "0x402C743")]
		[FieldOffset(Offset = "0x0")]
		private Tween m_cacheTween;

		// Token: 0x0402C744 RID: 182084
		[Token(Token = "0x402C744")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0402C745 RID: 182085
		[Token(Token = "0x402C745")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0402C746 RID: 182086
		[Token(Token = "0x402C746")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
