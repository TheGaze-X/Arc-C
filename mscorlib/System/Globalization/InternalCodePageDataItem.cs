using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000593 RID: 1427
	[Token(Token = "0x2000593")]
	internal struct InternalCodePageDataItem
	{
		// Token: 0x040018CB RID: 6347
		[Token(Token = "0x40018CB")]
		[FieldOffset(Offset = "0x0")]
		internal ushort codePage;

		// Token: 0x040018CC RID: 6348
		[Token(Token = "0x40018CC")]
		[FieldOffset(Offset = "0x2")]
		internal ushort uiFamilyCodePage;

		// Token: 0x040018CD RID: 6349
		[Token(Token = "0x40018CD")]
		[FieldOffset(Offset = "0x4")]
		internal uint flags;

		// Token: 0x040018CE RID: 6350
		[Token(Token = "0x40018CE")]
		[FieldOffset(Offset = "0x8")]
		internal string Names;
	}
}
