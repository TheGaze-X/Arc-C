using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004406 RID: 17414
	[Token(Token = "0x2004406")]
	public class SandboxV2RacingBattleStartRequest
	{
		// Token: 0x0601A9BC RID: 108988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9BC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RacingBattleStartRequest()
		{
		}

		// Token: 0x04021EB5 RID: 138933
		[Token(Token = "0x4021EB5")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021EB6 RID: 138934
		[Token(Token = "0x4021EB6")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;

		// Token: 0x04021EB7 RID: 138935
		[Token(Token = "0x4021EB7")]
		[FieldOffset(Offset = "0x20")]
		public string instId;
	}
}
