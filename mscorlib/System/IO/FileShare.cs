using System;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200064D RID: 1613
	[Token(Token = "0x200064D")]
	[System.Flags]
	public enum FileShare
	{
		// Token: 0x04001AB9 RID: 6841
		[Token(Token = "0x4001AB9")]
		None = 0,
		// Token: 0x04001ABA RID: 6842
		[Token(Token = "0x4001ABA")]
		Read = 1,
		// Token: 0x04001ABB RID: 6843
		[Token(Token = "0x4001ABB")]
		Write = 2,
		// Token: 0x04001ABC RID: 6844
		[Token(Token = "0x4001ABC")]
		ReadWrite = 3,
		// Token: 0x04001ABD RID: 6845
		[Token(Token = "0x4001ABD")]
		Delete = 4,
		// Token: 0x04001ABE RID: 6846
		[Token(Token = "0x4001ABE")]
		Inheritable = 16
	}
}
