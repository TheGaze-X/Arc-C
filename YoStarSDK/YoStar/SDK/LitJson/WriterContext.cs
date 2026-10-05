using System;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	internal class WriterContext
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WriterContext()
		{
		}

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x10")]
		public int Count;

		// Token: 0x04000E3C RID: 3644
		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0x14")]
		public bool InArray;

		// Token: 0x04000E3D RID: 3645
		[Token(Token = "0x4000E3D")]
		[FieldOffset(Offset = "0x15")]
		public bool InObject;

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000E3E")]
		[FieldOffset(Offset = "0x16")]
		public bool ExpectingValue;

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0x18")]
		public int Padding;
	}
}
