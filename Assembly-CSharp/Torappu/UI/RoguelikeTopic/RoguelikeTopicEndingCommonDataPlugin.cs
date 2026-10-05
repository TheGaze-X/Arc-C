using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044C7 RID: 17607
	[Token(Token = "0x20044C7")]
	public class RoguelikeTopicEndingCommonDataPlugin : RoguelikeTopicEndingDataPluginBase, IHotfixable
	{
		// Token: 0x0601AE2B RID: 110123 RVA: 0x000A3938 File Offset: 0x000A1B38
		[Token(Token = "0x601AE2B")]
		[Address(RVA = "0x140AFD0", Offset = "0x1409BD0", VA = "0x18140AFD0", Slot = "4")]
		public override bool CheckNeedTopicEnding(string topicId, RoguelikeTopicMode mode, GameSettleOuterInfo settleData)
		{
			return default(bool);
		}

		// Token: 0x0601AE2C RID: 110124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE2C")]
		[Address(RVA = "0x140B1D0", Offset = "0x1409DD0", VA = "0x18140B1D0")]
		public RoguelikeTopicEndingCommonDataPlugin()
		{
		}

		// Token: 0x0402274A RID: 141130
		[Token(Token = "0x402274A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckNeedTopicEnding;

		// Token: 0x0402274B RID: 141131
		[Token(Token = "0x402274B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
