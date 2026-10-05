using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity
{
	// Token: 0x02004694 RID: 18068
	[Token(Token = "0x2004694")]
	public abstract class RoguelikeTopicActivityEntryComp<T> : RoguelikeTopicActivityEntryComp where T : RoguelikeTopicActivityEntryCompBaseModel
	{
		// Token: 0x0601B6B6 RID: 112310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6B6")]
		public override void Render(RoguelikeTopicActivityEntryCompBaseModel model)
		{
		}

		// Token: 0x0601B6B7 RID: 112311
		[Token(Token = "0x601B6B7")]
		protected abstract void _Render(T model);

		// Token: 0x0601B6B8 RID: 112312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6B8")]
		protected RoguelikeTopicActivityEntryComp()
		{
		}

		// Token: 0x04023787 RID: 145287
		[Token(Token = "0x4023787")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023788 RID: 145288
		[Token(Token = "0x4023788")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
