using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class ScrolledEventArgs : EventArgs
	{
		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x5BBA740", Offset = "0x5BB9340", VA = "0x185BBA740")]
		public ScrolledEventArgs(Vector2 scrollDelta, Vector2 point)
		{
		}

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x10")]
		public readonly Vector2 ScrollDelta;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x18")]
		public readonly Vector2 Point;
	}
}
