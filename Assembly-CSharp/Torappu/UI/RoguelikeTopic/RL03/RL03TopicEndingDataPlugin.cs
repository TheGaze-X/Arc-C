using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045F7 RID: 17911
	[Token(Token = "0x20045F7")]
	public class RL03TopicEndingDataPlugin : RoguelikeTopicEndingDataPluginBase
	{
		// Token: 0x0601B3AB RID: 111531 RVA: 0x000A4B98 File Offset: 0x000A2D98
		[Token(Token = "0x601B3AB")]
		[Address(RVA = "0x1465F20", Offset = "0x1464B20", VA = "0x181465F20", Slot = "4")]
		public override bool CheckNeedTopicEnding(string topicId, RoguelikeTopicMode mode, GameSettleOuterInfo settleData)
		{
			return default(bool);
		}

		// Token: 0x0601B3AC RID: 111532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3AC")]
		[Address(RVA = "0x1466120", Offset = "0x1464D20", VA = "0x181466120")]
		public RL03TopicEndingDataPlugin()
		{
		}

		// Token: 0x040231D2 RID: 143826
		[Token(Token = "0x40231D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckNeedTopicEnding;

		// Token: 0x040231D3 RID: 143827
		[Token(Token = "0x40231D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
