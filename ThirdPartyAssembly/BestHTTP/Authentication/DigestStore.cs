using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.Authentication
{
	// Token: 0x02000511 RID: 1297
	[Token(Token = "0x2000511")]
	internal static class DigestStore
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x53CB710", Offset = "0x53CA310", VA = "0x1853CB710")]
		internal static Digest Get(Uri uri)
		{
			return null;
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0x53CB4B0", Offset = "0x53CA0B0", VA = "0x1853CB4B0")]
		public static Digest GetOrCreate(Uri uri)
		{
			return null;
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0x53CB9C0", Offset = "0x53CA5C0", VA = "0x1853CB9C0")]
		public static void Remove(Uri uri)
		{
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0x53CB260", Offset = "0x53C9E60", VA = "0x1853CB260")]
		public static string FindBest(List<string> authHeaders)
		{
			return null;
		}

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Digest> Digests;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0x8")]
		private static object Locker;

		// Token: 0x04001864 RID: 6244
		[Token(Token = "0x4001864")]
		[FieldOffset(Offset = "0x10")]
		private static string[] SupportedAlgorithms;
	}
}
