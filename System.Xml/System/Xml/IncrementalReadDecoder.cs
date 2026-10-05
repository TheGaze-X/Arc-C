using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	internal abstract class IncrementalReadDecoder
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B1 RID: 177
		[Token(Token = "0x17000031")]
		internal abstract bool IsFull { [Token(Token = "0x60000B1")] get; }

		// Token: 0x060000B2 RID: 178
		[Token(Token = "0x60000B2")]
		internal abstract int Decode(char[] chars, int startPos, int len);

		// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected IncrementalReadDecoder()
		{
		}
	}
}
