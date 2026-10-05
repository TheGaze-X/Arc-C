using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043EC RID: 17388
	[Token(Token = "0x20043EC")]
	public class SandboxV2ReadArchiveRequest
	{
		// Token: 0x0601A996 RID: 108950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A996")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ReadArchiveRequest()
		{
		}

		// Token: 0x04021E8E RID: 138894
		[Token(Token = "0x4021E8E")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E8F RID: 138895
		[Token(Token = "0x4021E8F")]
		[FieldOffset(Offset = "0x18")]
		public int day;
	}
}
