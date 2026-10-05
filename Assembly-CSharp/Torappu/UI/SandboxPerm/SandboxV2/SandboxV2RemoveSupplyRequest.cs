using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043EA RID: 17386
	[Token(Token = "0x20043EA")]
	public class SandboxV2RemoveSupplyRequest
	{
		// Token: 0x0601A994 RID: 108948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A994")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RemoveSupplyRequest()
		{
		}

		// Token: 0x04021E8C RID: 138892
		[Token(Token = "0x4021E8C")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E8D RID: 138893
		[Token(Token = "0x4021E8D")]
		[FieldOffset(Offset = "0x18")]
		public int charInstId;
	}
}
