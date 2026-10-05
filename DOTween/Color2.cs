using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public struct Color2
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x371F730", Offset = "0x371E330", VA = "0x18371F730")]
		public Color2(Color ca, Color cb)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x371F740", Offset = "0x371E340", VA = "0x18371F740")]
		public static Color2 operator +(Color2 c1, Color2 c2)
		{
			return default(Color2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x371F920", Offset = "0x371E520", VA = "0x18371F920")]
		public static Color2 operator -(Color2 c1, Color2 c2)
		{
			return default(Color2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x371F850", Offset = "0x371E450", VA = "0x18371F850")]
		public static Color2 operator *(Color2 c1, float f)
		{
			return default(Color2);
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		public Color ca;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		public Color cb;
	}
}
