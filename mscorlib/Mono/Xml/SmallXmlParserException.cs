using System;
using Il2CppDummyDll;

namespace Mono.Xml
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	internal class SmallXmlParserException : System.SystemException
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4AB7BE0", Offset = "0x4AB67E0", VA = "0x184AB7BE0")]
		public SmallXmlParserException(string msg, int line, int column)
		{
		}

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x90")]
		private int line;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x94")]
		private int column;
	}
}
