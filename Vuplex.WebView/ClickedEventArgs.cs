using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class ClickedEventArgs : EventArgs
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x5BB2F50", Offset = "0x5BB1B50", VA = "0x185BB2F50")]
		public ClickedEventArgs(Vector2 point)
		{
		}

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x10")]
		public readonly Vector2 Point;
	}
}
