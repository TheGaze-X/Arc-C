using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043DA RID: 17370
	[Token(Token = "0x20043DA")]
	public class SandboxV2RiftSetDifficultyRequest
	{
		// Token: 0x0601A984 RID: 108932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A984")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RiftSetDifficultyRequest()
		{
		}

		// Token: 0x04021E7D RID: 138877
		[Token(Token = "0x4021E7D")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E7E RID: 138878
		[Token(Token = "0x4021E7E")]
		[FieldOffset(Offset = "0x18")]
		public string difficulty;
	}
}
