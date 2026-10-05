using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200048C RID: 1164
	[Token(Token = "0x200048C")]
	internal class WriterContext
	{
		// Token: 0x060025AA RID: 9642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WriterContext()
		{
		}

		// Token: 0x040014FE RID: 5374
		[Token(Token = "0x40014FE")]
		[FieldOffset(Offset = "0x10")]
		public int Count;

		// Token: 0x040014FF RID: 5375
		[Token(Token = "0x40014FF")]
		[FieldOffset(Offset = "0x14")]
		public bool InArray;

		// Token: 0x04001500 RID: 5376
		[Token(Token = "0x4001500")]
		[FieldOffset(Offset = "0x15")]
		public bool InObject;

		// Token: 0x04001501 RID: 5377
		[Token(Token = "0x4001501")]
		[FieldOffset(Offset = "0x16")]
		public bool ExpectingValue;

		// Token: 0x04001502 RID: 5378
		[Token(Token = "0x4001502")]
		[FieldOffset(Offset = "0x18")]
		public int Padding;
	}
}
