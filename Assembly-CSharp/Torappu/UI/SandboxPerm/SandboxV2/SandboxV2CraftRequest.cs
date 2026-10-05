using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043CB RID: 17355
	[Token(Token = "0x20043CB")]
	public class SandboxV2CraftRequest
	{
		// Token: 0x0601A976 RID: 108918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A976")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2CraftRequest()
		{
		}

		// Token: 0x04021E50 RID: 138832
		[Token(Token = "0x4021E50")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E51 RID: 138833
		[Token(Token = "0x4021E51")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04021E52 RID: 138834
		[Token(Token = "0x4021E52")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x04021E53 RID: 138835
		[Token(Token = "0x4021E53")]
		[FieldOffset(Offset = "0x24")]
		public bool autoSquad;
	}
}
