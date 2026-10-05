using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity
{
	// Token: 0x0200469A RID: 18074
	[Token(Token = "0x200469A")]
	public class RoguelikeTopicActivityStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601B6D1 RID: 112337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6D1")]
		[Address(RVA = "0x14B1A40", Offset = "0x14B0640", VA = "0x1814B1A40")]
		public void InitData(string topicId)
		{
		}

		// Token: 0x0601B6D2 RID: 112338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6D2")]
		[Address(RVA = "0x14B1AC0", Offset = "0x14B06C0", VA = "0x1814B1AC0")]
		public RoguelikeTopicActivityStateBean()
		{
		}

		// Token: 0x040237A2 RID: 145314
		[Token(Token = "0x40237A2")]
		[FieldOffset(Offset = "0x10")]
		public string rlActId;

		// Token: 0x040237A3 RID: 145315
		[Token(Token = "0x40237A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040237A4 RID: 145316
		[Token(Token = "0x40237A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
