using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044CD RID: 17613
	[Token(Token = "0x20044CD")]
	public abstract class RoguelikeTopicEndingPageFadeView<TModel> : RoguelikeTopicEndingPageView<TModel> where TModel : RoguelikeTopicEndingPageViewModelBase
	{
		// Token: 0x0601AE4C RID: 110156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE4C")]
		public sealed override void OnVisibilityUpdate(bool visible)
		{
		}

		// Token: 0x0601AE4D RID: 110157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE4D")]
		public sealed override void RestVisibilityHide()
		{
		}

		// Token: 0x0601AE4E RID: 110158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE4E")]
		protected RoguelikeTopicEndingPageFadeView()
		{
		}

		// Token: 0x04022767 RID: 141159
		[Token(Token = "0x4022767")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UIFadeFloatPanel _fadePanel;

		// Token: 0x04022768 RID: 141160
		[Token(Token = "0x4022768")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnVisibilityUpdate;

		// Token: 0x04022769 RID: 141161
		[Token(Token = "0x4022769")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RestVisibilityHide;

		// Token: 0x0402276A RID: 141162
		[Token(Token = "0x402276A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
