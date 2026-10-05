using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public static class TMPro_ExtensionMethods
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x586CBD0", Offset = "0x586B7D0", VA = "0x18586CBD0")]
		public static int[] ToIntArray(this string text)
		{
			return null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x586C600", Offset = "0x586B200", VA = "0x18586C600")]
		public static string ArrayToString(this char[] chars)
		{
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x586C860", Offset = "0x586B460", VA = "0x18586C860")]
		public static string IntToString(this int[] unicodes)
		{
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x586CC70", Offset = "0x586B870", VA = "0x18586CC70")]
		internal static string UintToString(this List<uint> unicodes)
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x586C8F0", Offset = "0x586B4F0", VA = "0x18586C8F0")]
		public static string IntToString(this int[] unicodes, int start, int length)
		{
			return null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000104")]
		public static int FindInstanceID<T>(this List<T> list, T target) where T : UnityEngine.Object
		{
			return 0;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x586C710", Offset = "0x586B310", VA = "0x18586C710")]
		public static bool Compare(this Color32 a, Color32 b)
		{
			return default(bool);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x586C6E0", Offset = "0x586B2E0", VA = "0x18586C6E0")]
		public static bool CompareRGB(this Color32 a, Color32 b)
		{
			return default(bool);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4E32FB0", Offset = "0x4E31BB0", VA = "0x184E32FB0")]
		public static bool Compare(this Color a, Color b)
		{
			return default(bool);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x57B02D0", Offset = "0x57AEED0", VA = "0x1857B02D0")]
		public static bool CompareRGB(this Color a, Color b)
		{
			return default(bool);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x586CA10", Offset = "0x586B610", VA = "0x18586CA10")]
		public static Color32 Multiply(this Color32 c1, Color32 c2)
		{
			return default(Color32);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x586CA10", Offset = "0x586B610", VA = "0x18586CA10")]
		public static Color32 Tint(this Color32 c1, Color32 c2)
		{
			return default(Color32);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x586CAF0", Offset = "0x586B6F0", VA = "0x18586CAF0")]
		public static Color32 Tint(this Color32 c1, float tint)
		{
			return default(Color32);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x586C9E0", Offset = "0x586B5E0", VA = "0x18586C9E0")]
		public static Color MinAlpha(this Color c1, Color c2)
		{
			return default(Color);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x586C7F0", Offset = "0x586B3F0", VA = "0x18586C7F0")]
		public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy)
		{
			return default(bool);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x586C750", Offset = "0x586B350", VA = "0x18586C750")]
		public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy)
		{
			return default(bool);
		}
	}
}
