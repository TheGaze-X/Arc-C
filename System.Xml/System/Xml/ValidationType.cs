using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public enum ValidationType
	{
		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		None,
		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[Obsolete("Validation type should be specified as DTD or Schema.")]
		Auto,
		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		DTD,
		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
		XDR,
		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		Schema
	}
}
