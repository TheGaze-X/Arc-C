using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044CC RID: 17612
	[Token(Token = "0x20044CC")]
	public abstract class RoguelikeTopicEndingPageView<TModel> : RoguelikeTopicEndingPageViewBase where TModel : RoguelikeTopicEndingPageViewModelBase
	{
		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x0601AE48 RID: 110152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FD9")]
		public sealed override Type showType
		{
			[Token(Token = "0x601AE48")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AE49 RID: 110153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE49")]
		public sealed override void DoRender(RoguelikeTopicEndingPageViewModelBase pageModel)
		{
		}

		// Token: 0x0601AE4A RID: 110154
		[Token(Token = "0x601AE4A")]
		protected abstract void Render(TModel viewModel);

		// Token: 0x0601AE4B RID: 110155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE4B")]
		protected RoguelikeTopicEndingPageView()
		{
		}

		// Token: 0x04022764 RID: 141156
		[Token(Token = "0x4022764")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x04022765 RID: 141157
		[Token(Token = "0x4022765")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x04022766 RID: 141158
		[Token(Token = "0x4022766")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
