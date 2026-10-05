using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public struct Extents
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1787730", Offset = "0x1786330", VA = "0x181787730")]
		public Extents(Vector2 min, Vector2 max)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x58803C0", Offset = "0x587EFC0", VA = "0x1858803C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x0")]
		internal static Extents zero;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		internal static Extents uninitialized;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 min;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 max;
	}
}
