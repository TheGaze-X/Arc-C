using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004403 RID: 17411
	[Token(Token = "0x2004403")]
	public class SandboxV2BattleStartRequest
	{
		// Token: 0x0601A9B3 RID: 108979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9B3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BattleStartRequest()
		{
		}

		// Token: 0x04021EA7 RID: 138919
		[Token(Token = "0x4021EA7")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021EA8 RID: 138920
		[Token(Token = "0x4021EA8")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;

		// Token: 0x04021EA9 RID: 138921
		[Token(Token = "0x4021EA9")]
		[FieldOffset(Offset = "0x20")]
		public int squadIdx;
	}
}
