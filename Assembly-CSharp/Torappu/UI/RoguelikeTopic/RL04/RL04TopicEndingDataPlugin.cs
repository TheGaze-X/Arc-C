using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046D9 RID: 18137
	[Token(Token = "0x20046D9")]
	public class RL04TopicEndingDataPlugin : RoguelikeTopicEndingDataPluginBase
	{
		// Token: 0x0601B800 RID: 112640 RVA: 0x000A5630 File Offset: 0x000A3830
		[Token(Token = "0x601B800")]
		[Address(RVA = "0x14CE2F0", Offset = "0x14CCEF0", VA = "0x1814CE2F0", Slot = "4")]
		public override bool CheckNeedTopicEnding(string topicId, RoguelikeTopicMode mode, GameSettleOuterInfo settleData)
		{
			return default(bool);
		}

		// Token: 0x0601B801 RID: 112641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B801")]
		[Address(RVA = "0x14CE4F0", Offset = "0x14CD0F0", VA = "0x1814CE4F0")]
		public RL04TopicEndingDataPlugin()
		{
		}

		// Token: 0x040239EE RID: 145902
		[Token(Token = "0x40239EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckNeedTopicEnding;

		// Token: 0x040239EF RID: 145903
		[Token(Token = "0x40239EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
