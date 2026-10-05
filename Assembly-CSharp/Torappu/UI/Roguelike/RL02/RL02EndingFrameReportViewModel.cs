using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005760 RID: 22368
	[Token(Token = "0x2005760")]
	public abstract class RL02EndingFrameReportViewModel : IHotfixable
	{
		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x06020C32 RID: 134194
		[Token(Token = "0x17004CCC")]
		public abstract RL02ReportController.ReportViewType viewType { [Token(Token = "0x6020C32")] get; }

		// Token: 0x06020C33 RID: 134195
		[Token(Token = "0x6020C33")]
		protected abstract bool LoadData(string topicId, RL02EndingFrameViewModel dataSource);

		// Token: 0x06020C34 RID: 134196 RVA: 0x000B7120 File Offset: 0x000B5320
		[Token(Token = "0x6020C34")]
		[Address(RVA = "0x1B1FC70", Offset = "0x1B1E870", VA = "0x181B1FC70")]
		public bool DoLoadData(string topicId, RoguelikeTopicCustomizeData topicCustomizeData, RL02EndingFrameViewModel dataSource)
		{
			return default(bool);
		}

		// Token: 0x06020C35 RID: 134197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C35")]
		[Address(RVA = "0x1B1FD60", Offset = "0x1B1E960", VA = "0x181B1FD60")]
		protected RL02EndingFrameReportViewModel()
		{
		}

		// Token: 0x0402C7CA RID: 182218
		[Token(Token = "0x402C7CA")]
		[FieldOffset(Offset = "0x10")]
		public RL02EndingText endingTextConfig;

		// Token: 0x0402C7CB RID: 182219
		[Token(Token = "0x402C7CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoLoadData;

		// Token: 0x0402C7CC RID: 182220
		[Token(Token = "0x402C7CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
