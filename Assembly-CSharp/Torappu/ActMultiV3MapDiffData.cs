using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E47 RID: 3655
	[Token(Token = "0x2000E47")]
	public class ActMultiV3MapDiffData
	{
		// Token: 0x06006B15 RID: 27413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B15")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3MapDiffData()
		{
		}

		// Token: 0x04004C25 RID: 19493
		[Token(Token = "0x4004C25")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3MapDiffType diffType;

		// Token: 0x04004C26 RID: 19494
		[Token(Token = "0x4004C26")]
		[FieldOffset(Offset = "0x18")]
		public string name;
	}
}
