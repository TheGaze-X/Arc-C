using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044CE RID: 17614
	[Token(Token = "0x20044CE")]
	public abstract class RoguelikeTopicEndingPageAnimatedView<TModel> : RoguelikeTopicEndingPageView<TModel> where TModel : RoguelikeTopicEndingPageViewModelBase
	{
		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x0601AE4F RID: 110159
		[Token(Token = "0x17003FDA")]
		protected abstract UIAnimationLocation showAnimation { [Token(Token = "0x601AE4F")] get; }

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x0601AE50 RID: 110160
		[Token(Token = "0x17003FDB")]
		protected abstract UIAnimationLocation hideAnimation { [Token(Token = "0x601AE50")] get; }

		// Token: 0x0601AE51 RID: 110161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE51")]
		public sealed override void RestVisibilityHide()
		{
		}

		// Token: 0x0601AE52 RID: 110162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE52")]
		public sealed override void OnVisibilityUpdate(bool visible)
		{
		}

		// Token: 0x0601AE53 RID: 110163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE53")]
		protected RoguelikeTopicEndingPageAnimatedView()
		{
		}

		// Token: 0x0402276B RID: 141163
		[Token(Token = "0x402276B")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isVisible;

		// Token: 0x0402276C RID: 141164
		[Token(Token = "0x402276C")]
		[FieldOffset(Offset = "0x0")]
		private UIAnimationTween m_animationTween;

		// Token: 0x0402276D RID: 141165
		[Token(Token = "0x402276D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RestVisibilityHide;

		// Token: 0x0402276E RID: 141166
		[Token(Token = "0x402276E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnVisibilityUpdate;

		// Token: 0x0402276F RID: 141167
		[Token(Token = "0x402276F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
