using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.Cookies
{
	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x2000506")]
	public static class CookieJar
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x00012258 File Offset: 0x00010458
		[Token(Token = "0x17000623")]
		public static bool IsSavingSupported
		{
			[Token(Token = "0x6002A6C")]
			[Address(RVA = "0x53C9840", Offset = "0x53C8440", VA = "0x1853C9840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A6E RID: 10862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000624")]
		private static string CookieFolder
		{
			[Token(Token = "0x6002A6D")]
			[Address(RVA = "0x53C97F0", Offset = "0x53C83F0", VA = "0x1853C97F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A6E")]
			[Address(RVA = "0x53C9B00", Offset = "0x53C8700", VA = "0x1853C9B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A70 RID: 10864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000625")]
		private static string LibraryPath
		{
			[Token(Token = "0x6002A6F")]
			[Address(RVA = "0x53C9AB0", Offset = "0x53C86B0", VA = "0x1853C9AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A70")]
			[Address(RVA = "0x53C9B70", Offset = "0x53C8770", VA = "0x1853C9B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A71")]
		[Address(RVA = "0x53C9440", Offset = "0x53C8040", VA = "0x1853C9440")]
		internal static void SetupFolder()
		{
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x53C8FC0", Offset = "0x53C7BC0", VA = "0x1853C8FC0")]
		internal static void Set(HTTPResponse response)
		{
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x53C7F90", Offset = "0x53C6B90", VA = "0x1853C7F90")]
		internal static void Maintain()
		{
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x53C84C0", Offset = "0x53C70C0", VA = "0x1853C84C0")]
		internal static void Persist()
		{
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A75")]
		[Address(RVA = "0x53C78B0", Offset = "0x53C64B0", VA = "0x1853C78B0")]
		internal static void Load()
		{
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A76")]
		[Address(RVA = "0x53C7600", Offset = "0x53C6200", VA = "0x1853C7600")]
		public static List<Cookie> Get(Uri uri)
		{
			return null;
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x53C8F70", Offset = "0x53C7B70", VA = "0x1853C8F70")]
		public static void Set(Uri uri, Cookie cookie)
		{
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A78")]
		[Address(RVA = "0x53C8DB0", Offset = "0x53C79B0", VA = "0x1853C8DB0")]
		public static void Set(Cookie cookie)
		{
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A79")]
		[Address(RVA = "0x53C7500", Offset = "0x53C6100", VA = "0x1853C7500")]
		public static List<Cookie> GetAll()
		{
			return null;
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x53C72B0", Offset = "0x53C5EB0", VA = "0x1853C72B0")]
		public static void Clear()
		{
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x53C6E10", Offset = "0x53C5A10", VA = "0x1853C6E10")]
		public static void Clear(TimeSpan olderThan)
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x53C7070", Offset = "0x53C5C70", VA = "0x1853C7070")]
		public static void Clear(string domain)
		{
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x53C8B30", Offset = "0x53C7730", VA = "0x1853C8B30")]
		public static void Remove(Uri uri, string name)
		{
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x53C73E0", Offset = "0x53C5FE0", VA = "0x1853C73E0")]
		private static Cookie Find(Cookie cookie, out int idx)
		{
			return null;
		}

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		private const int Version = 1;

		// Token: 0x04001829 RID: 6185
		[Token(Token = "0x4001829")]
		[FieldOffset(Offset = "0x0")]
		private static List<Cookie> Cookies;

		// Token: 0x0400182C RID: 6188
		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0x18")]
		private static object Locker;

		// Token: 0x0400182D RID: 6189
		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x20")]
		private static bool _isSavingSupported;

		// Token: 0x0400182E RID: 6190
		[Token(Token = "0x400182E")]
		[FieldOffset(Offset = "0x21")]
		private static bool IsSupportCheckDone;

		// Token: 0x0400182F RID: 6191
		[Token(Token = "0x400182F")]
		[FieldOffset(Offset = "0x22")]
		private static bool Loaded;
	}
}
