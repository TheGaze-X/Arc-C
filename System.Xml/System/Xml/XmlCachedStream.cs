using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	internal class XmlCachedStream : MemoryStream
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x4FED600", Offset = "0x4FEC200", VA = "0x184FED600")]
		internal XmlCachedStream(Uri uri, Stream stream)
		{
		}

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x50")]
		private Uri uri;
	}
}
