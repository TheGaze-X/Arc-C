using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050D5 RID: 20693
	[Token(Token = "0x20050D5")]
	[Serializable]
	public class GOPositionHolder
	{
		// Token: 0x0601E99D RID: 125341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E99D")]
		[Address(RVA = "0x184C7F0", Offset = "0x184B3F0", VA = "0x18184C7F0")]
		public GOPositionHolder()
		{
		}

		// Token: 0x0402901C RID: 167964
		[Token(Token = "0x402901C")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly GOPositionHolder DEFAULT;

		// Token: 0x0402901D RID: 167965
		[Token(Token = "0x402901D")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 pos;

		// Token: 0x0402901E RID: 167966
		[Token(Token = "0x402901E")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 anchorsMin;

		// Token: 0x0402901F RID: 167967
		[Token(Token = "0x402901F")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 anchorsMax;
	}
}
