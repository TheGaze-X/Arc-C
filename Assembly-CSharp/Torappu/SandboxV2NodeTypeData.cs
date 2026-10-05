using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001290 RID: 4752
	[Token(Token = "0x2001290")]
	public class SandboxV2NodeTypeData
	{
		// Token: 0x06007208 RID: 29192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007208")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2NodeTypeData()
		{
		}

		// Token: 0x040068BB RID: 26811
		[Token(Token = "0x40068BB")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2NodeType nodeType;

		// Token: 0x040068BC RID: 26812
		[Token(Token = "0x40068BC")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040068BD RID: 26813
		[Token(Token = "0x40068BD")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;
	}
}
