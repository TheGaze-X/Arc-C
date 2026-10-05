using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007CAB RID: 31915
	[Token(Token = "0x2007CAB")]
	public static class fiUtility
	{
		// Token: 0x0602C93D RID: 182589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C93D")]
		[Address(RVA = "0x2874230", Offset = "0x2872E30", VA = "0x182874230")]
		public static string CombinePaths(string a, string b)
		{
			return null;
		}

		// Token: 0x0602C93E RID: 182590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C93E")]
		[Address(RVA = "0x28740E0", Offset = "0x2872CE0", VA = "0x1828740E0")]
		public static string CombinePaths(string a, string b, string c)
		{
			return null;
		}

		// Token: 0x0602C93F RID: 182591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C93F")]
		[Address(RVA = "0x2874180", Offset = "0x2872D80", VA = "0x182874180")]
		public static string CombinePaths(string a, string b, string c, string d)
		{
			return null;
		}

		// Token: 0x0602C940 RID: 182592 RVA: 0x000E0EC8 File Offset: 0x000DF0C8
		[Token(Token = "0x602C940")]
		[Address(RVA = "0x2874480", Offset = "0x2873080", VA = "0x182874480")]
		public static bool NearlyEqual(float a, float b)
		{
			return default(bool);
		}

		// Token: 0x0602C941 RID: 182593 RVA: 0x000E0EE0 File Offset: 0x000DF0E0
		[Token(Token = "0x602C941")]
		[Address(RVA = "0x28743B0", Offset = "0x2872FB0", VA = "0x1828743B0")]
		public static bool NearlyEqual(float a, float b, float epsilon)
		{
			return default(bool);
		}

		// Token: 0x0602C942 RID: 182594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C942")]
		[Address(RVA = "0x2874330", Offset = "0x2872F30", VA = "0x182874330")]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		// Token: 0x0602C943 RID: 182595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C943")]
		public static void DestroyObject<T>(ref T obj) where T : UnityEngine.Object
		{
		}

		// Token: 0x0602C944 RID: 182596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C944")]
		[Address(RVA = "0x2874560", Offset = "0x2873160", VA = "0x182874560")]
		public static string StripLeadingWhitespace(this string s)
		{
			return null;
		}

		// Token: 0x17006853 RID: 26707
		// (get) Token: 0x0602C945 RID: 182597 RVA: 0x000E0EF8 File Offset: 0x000DF0F8
		[Token(Token = "0x17006853")]
		public static bool IsEditor
		{
			[Token(Token = "0x602C945")]
			[Address(RVA = "0x2874600", Offset = "0x2873200", VA = "0x182874600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006854 RID: 26708
		// (get) Token: 0x0602C946 RID: 182598 RVA: 0x000E0F10 File Offset: 0x000DF110
		[Token(Token = "0x17006854")]
		public static bool IsMainThread
		{
			[Token(Token = "0x602C946")]
			[Address(RVA = "0x2874720", Offset = "0x2873320", VA = "0x182874720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006855 RID: 26709
		// (get) Token: 0x0602C947 RID: 182599 RVA: 0x000E0F28 File Offset: 0x000DF128
		[Token(Token = "0x17006855")]
		public static bool IsUnity4
		{
			[Token(Token = "0x602C947")]
			[Address(RVA = "0x28747B0", Offset = "0x28733B0", VA = "0x1828747B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C948 RID: 182600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C948")]
		public static Dictionary<TKey, TValue> CreateDictionary<TKey, TValue>(IList<TKey> keys, IList<TValue> values)
		{
			return null;
		}

		// Token: 0x0602C949 RID: 182601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C949")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		// Token: 0x040403D2 RID: 263122
		[Token(Token = "0x40403D2")]
		[FieldOffset(Offset = "0x0")]
		private static bool? _cachedIsEditor;

		// Token: 0x040403D3 RID: 263123
		[Token(Token = "0x40403D3")]
		[FieldOffset(Offset = "0x2")]
		private static bool? _isUnity4;
	}
}
