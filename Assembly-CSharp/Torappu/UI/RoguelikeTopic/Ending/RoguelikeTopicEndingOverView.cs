using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x02004681 RID: 18049
	[Token(Token = "0x2004681")]
	public class RoguelikeTopicEndingOverView : RoguelikeTopicEndingPageFadeView<RoguelikeTopicEndingOverViewModel>
	{
		// Token: 0x0601B66F RID: 112239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B66F")]
		[Address(RVA = "0x14B5770", Offset = "0x14B4370", VA = "0x1814B5770", Slot = "8")]
		protected override void Render(RoguelikeTopicEndingOverViewModel model)
		{
		}

		// Token: 0x0601B670 RID: 112240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B670")]
		[Address(RVA = "0x14B5AC0", Offset = "0x14B46C0", VA = "0x1814B5AC0")]
		public RoguelikeTopicEndingOverView()
		{
		}

		// Token: 0x040236CE RID: 145102
		[Token(Token = "0x40236CE")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeTopicEndingBpAndGpView m_view;

		// Token: 0x040236CF RID: 145103
		[Token(Token = "0x40236CF")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040236D0 RID: 145104
		[Token(Token = "0x40236D0")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeTopicEndingStyle m_style;

		// Token: 0x040236D1 RID: 145105
		[Token(Token = "0x40236D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040236D2 RID: 145106
		[Token(Token = "0x40236D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
