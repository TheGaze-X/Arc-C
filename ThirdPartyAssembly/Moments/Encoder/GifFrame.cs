using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Moments.Encoder
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public class GifFrame
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GifFrame()
		{
		}

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x10")]
		public int Width;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x14")]
		public int Height;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x18")]
		public Color32[] Data;
	}
}
