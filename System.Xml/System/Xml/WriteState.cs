using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public enum WriteState
	{
		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		Start,
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		Prolog,
		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		Element,
		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		Attribute,
		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		Content,
		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		Closed,
		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		Error
	}
}
