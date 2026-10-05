using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004401 RID: 17409
	[Token(Token = "0x2004401")]
	public class SandboxV2ExploreModeRequest
	{
		// Token: 0x0601A9AF RID: 108975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9AF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ExploreModeRequest()
		{
		}

		// Token: 0x04021E9F RID: 138911
		[Token(Token = "0x4021E9F")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021EA0 RID: 138912
		[Token(Token = "0x4021EA0")]
		[FieldOffset(Offset = "0x18")]
		public int mode;
	}
}
