using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043BB RID: 17339
	[Token(Token = "0x20043BB")]
	public class SandboxV2RacingSaveMarkRequest
	{
		// Token: 0x0601A966 RID: 108902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A966")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RacingSaveMarkRequest()
		{
		}

		// Token: 0x04021E36 RID: 138806
		[Token(Token = "0x4021E36")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E37 RID: 138807
		[Token(Token = "0x4021E37")]
		[FieldOffset(Offset = "0x18")]
		public string instId;

		// Token: 0x04021E38 RID: 138808
		[Token(Token = "0x4021E38")]
		[FieldOffset(Offset = "0x20")]
		public bool mark;
	}
}
