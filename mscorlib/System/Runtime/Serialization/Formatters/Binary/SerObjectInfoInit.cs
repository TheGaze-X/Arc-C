using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000441 RID: 1089
	[Token(Token = "0x2000441")]
	internal sealed class SerObjectInfoInit
	{
		// Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002155")]
		[Address(RVA = "0x4BC5560", Offset = "0x4BC4160", VA = "0x184BC5560")]
		public SerObjectInfoInit()
		{
		}

		// Token: 0x04001256 RID: 4694
		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x10")]
		internal System.Collections.Hashtable seenBeforeTable;

		// Token: 0x04001257 RID: 4695
		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x18")]
		internal int objectInfoIdCount;

		// Token: 0x04001258 RID: 4696
		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x20")]
		internal SerStack oiPool;
	}
}
