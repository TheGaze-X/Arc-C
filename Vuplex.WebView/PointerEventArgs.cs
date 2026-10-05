using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public class PointerEventArgs : EventArgs
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x5BBA3A0", Offset = "0x5BB8FA0", VA = "0x185BBA3A0")]
		public PointerOptions ToPointerOptions(bool preventStealingFocus)
		{
			return null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x5BBA420", Offset = "0x5BB9020", VA = "0x185BBA420")]
		public PointerEventArgs()
		{
		}

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x10")]
		public MouseButton Button;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x14")]
		public int ClickCount;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 Point;
	}
}
