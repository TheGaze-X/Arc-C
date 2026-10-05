using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043E8 RID: 17384
	[Token(Token = "0x20043E8")]
	public class SandboxV2SetSupplyRequest
	{
		// Token: 0x0601A992 RID: 108946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A992")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2SetSupplyRequest()
		{
		}

		// Token: 0x04021E8A RID: 138890
		[Token(Token = "0x4021E8A")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E8B RID: 138891
		[Token(Token = "0x4021E8B")]
		[FieldOffset(Offset = "0x18")]
		public List<int> charList;
	}
}
