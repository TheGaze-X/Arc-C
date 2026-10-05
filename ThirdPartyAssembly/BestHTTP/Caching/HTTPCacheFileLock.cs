using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.Caching
{
	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x2000508")]
	internal sealed class HTTPCacheFileLock
	{
		// Token: 0x06002AAA RID: 10922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x53CF510", Offset = "0x53CE110", VA = "0x1853CF510")]
		internal static object Acquire(Uri uri)
		{
			return null;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x53CF800", Offset = "0x53CE400", VA = "0x1853CF800")]
		internal static void Remove(Uri uri)
		{
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x53CF6F0", Offset = "0x53CE2F0", VA = "0x1853CF6F0")]
		internal static void Clear()
		{
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HTTPCacheFileLock()
		{
		}

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Uri, object> FileLocks;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x8")]
		private static object SyncRoot;
	}
}
