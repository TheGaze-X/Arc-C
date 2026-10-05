using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public abstract class XmlNameTable
	{
		// Token: 0x06000791 RID: 1937
		[Token(Token = "0x6000791")]
		public abstract string Get(string array);

		// Token: 0x06000792 RID: 1938
		[Token(Token = "0x6000792")]
		public abstract string Add(char[] array, int offset, int length);

		// Token: 0x06000793 RID: 1939
		[Token(Token = "0x6000793")]
		public abstract string Add(string array);

		// Token: 0x06000794 RID: 1940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XmlNameTable()
		{
		}
	}
}
