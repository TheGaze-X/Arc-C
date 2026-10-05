using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public static class ColorExtensions
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4E1D1C0", Offset = "0x4E1BDC0", VA = "0x184E1D1C0")]
		public static Color Lerp(this Color[] colors, float t)
		{
			return default(Color);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4E1D2F0", Offset = "0x4E1BEF0", VA = "0x184E1D2F0")]
		public static Color MoveTowards(this Color from, Color to, float maxDelta)
		{
			return default(Color);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4E1DAB0", Offset = "0x4E1C6B0", VA = "0x184E1DAB0")]
		public static bool TryParseString(string colorStr, out Color color)
		{
			return default(bool);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4E1D630", Offset = "0x4E1C230", VA = "0x184E1D630")]
		public static string ToCSharpColor(this Color color)
		{
			return null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4E1D570", Offset = "0x4E1C170", VA = "0x184E1D570")]
		public static Color Pow(this Color color, float factor)
		{
			return default(Color);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4E1D420", Offset = "0x4E1C020", VA = "0x184E1D420")]
		public static Color NormalizeRGB(this Color color)
		{
			return default(Color);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4E1D9E0", Offset = "0x4E1C5E0", VA = "0x184E1D9E0")]
		private static string TrimFloat(float value)
		{
			return null;
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] trimRGBStart;
	}
}
