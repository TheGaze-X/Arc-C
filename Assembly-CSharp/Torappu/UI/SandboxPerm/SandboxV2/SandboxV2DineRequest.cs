using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043C9 RID: 17353
	[Token(Token = "0x20043C9")]
	public class SandboxV2DineRequest
	{
		// Token: 0x0601A974 RID: 108916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A974")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DineRequest()
		{
		}

		// Token: 0x04021E4D RID: 138829
		[Token(Token = "0x4021E4D")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E4E RID: 138830
		[Token(Token = "0x4021E4E")]
		[FieldOffset(Offset = "0x18")]
		public int charInstId;

		// Token: 0x04021E4F RID: 138831
		[Token(Token = "0x4021E4F")]
		[FieldOffset(Offset = "0x20")]
		public string foodInstId;
	}
}
