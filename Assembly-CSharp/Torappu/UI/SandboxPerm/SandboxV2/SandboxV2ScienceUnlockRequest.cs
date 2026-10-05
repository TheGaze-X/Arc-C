using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043E6 RID: 17382
	[Token(Token = "0x20043E6")]
	public class SandboxV2ScienceUnlockRequest
	{
		// Token: 0x0601A990 RID: 108944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A990")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ScienceUnlockRequest()
		{
		}

		// Token: 0x04021E88 RID: 138888
		[Token(Token = "0x4021E88")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E89 RID: 138889
		[Token(Token = "0x4021E89")]
		[FieldOffset(Offset = "0x18")]
		public string techId;
	}
}
