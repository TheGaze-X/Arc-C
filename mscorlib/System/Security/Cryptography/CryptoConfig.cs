using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class CryptoConfig
	{
		// Token: 0x06001B1D RID: 6941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x4B3B960", Offset = "0x4B3A560", VA = "0x184B3B960")]
		public static void AddOID(string oid, params string[] names)
		{
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x4B3D810", Offset = "0x4B3C410", VA = "0x184B3D810")]
		public static object CreateFromName(string name)
		{
			return null;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x4B3B9B0", Offset = "0x4B3A5B0", VA = "0x184B3B9B0")]
		public static object CreateFromName(string name, params object[] args)
		{
			return null;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x4B3DF70", Offset = "0x4B3CB70", VA = "0x184B3DF70")]
		internal static string MapNameToOID(string name, object arg)
		{
			return null;
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x4B3DFC0", Offset = "0x4B3CBC0", VA = "0x184B3DFC0")]
		public static string MapNameToOID(string name)
		{
			return null;
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x4B3DE50", Offset = "0x4B3CA50", VA = "0x184B3DE50")]
		private static void Initialize()
		{
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x4B3B470", Offset = "0x4B3A070", VA = "0x184B3B470")]
		public static void AddAlgorithm(System.Type algorithm, params string[] names)
		{
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x4B3DA00", Offset = "0x4B3C600", VA = "0x184B3DA00")]
		public static byte[] EncodeOID(string str)
		{
			return null;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x4B3D860", Offset = "0x4B3C460", VA = "0x184B3D860")]
		private static byte[] EncodeLongNumber(long x)
		{
			return null;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x000125A0 File Offset: 0x000107A0
		[Token(Token = "0x170002F3")]
		[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
		public static bool AllowOnlyFipsAlgorithms
		{
			[Token(Token = "0x6001B26")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CryptoConfig()
		{
		}

		// Token: 0x04000EA5 RID: 3749
		[Token(Token = "0x4000EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object lockObject;

		// Token: 0x04000EA6 RID: 3750
		[Token(Token = "0x4000EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Collections.Generic.Dictionary<string, System.Type> algorithms;
	}
}
