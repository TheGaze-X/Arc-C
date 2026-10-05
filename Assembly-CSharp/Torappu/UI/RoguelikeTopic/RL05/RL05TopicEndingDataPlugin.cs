using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x020045A5 RID: 17829
	[Token(Token = "0x20045A5")]
	public class RL05TopicEndingDataPlugin : RoguelikeTopicEndingDataPluginBase
	{
		// Token: 0x0601B22F RID: 111151 RVA: 0x000A4760 File Offset: 0x000A2960
		[Token(Token = "0x601B22F")]
		[Address(RVA = "0x1453D40", Offset = "0x1452940", VA = "0x181453D40", Slot = "4")]
		public override bool CheckNeedTopicEnding(string topicId, RoguelikeTopicMode mode, GameSettleOuterInfo settleData)
		{
			return default(bool);
		}

		// Token: 0x0601B230 RID: 111152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B230")]
		[Address(RVA = "0x1453F50", Offset = "0x1452B50", VA = "0x181453F50")]
		public RL05TopicEndingDataPlugin()
		{
		}

		// Token: 0x04022ED7 RID: 143063
		[Token(Token = "0x4022ED7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckNeedTopicEnding;

		// Token: 0x04022ED8 RID: 143064
		[Token(Token = "0x4022ED8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
