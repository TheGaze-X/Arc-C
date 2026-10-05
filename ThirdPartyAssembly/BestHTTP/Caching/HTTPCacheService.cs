using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.Caching
{
	// Token: 0x0200050B RID: 1291
	[Token(Token = "0x200050B")]
	public static class HTTPCacheService
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x000123F0 File Offset: 0x000105F0
		[Token(Token = "0x17000635")]
		public static bool IsSupported
		{
			[Token(Token = "0x6002AB7")]
			[Address(RVA = "0x53D3650", Offset = "0x53D2250", VA = "0x1853D3650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000636")]
		private static Dictionary<Uri, HTTPCacheFileInfo> Library
		{
			[Token(Token = "0x6002AB8")]
			[Address(RVA = "0x53D3910", Offset = "0x53D2510", VA = "0x1853D3910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002ABA RID: 10938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000637")]
		internal static string CacheFolder
		{
			[Token(Token = "0x6002AB9")]
			[Address(RVA = "0x53D3600", Offset = "0x53D2200", VA = "0x1853D3600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ABA")]
			[Address(RVA = "0x53D3970", Offset = "0x53D2570", VA = "0x1853D3970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000638")]
		private static string LibraryPath
		{
			[Token(Token = "0x6002ABB")]
			[Address(RVA = "0x53D38C0", Offset = "0x53D24C0", VA = "0x1853D38C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ABC")]
			[Address(RVA = "0x53D39E0", Offset = "0x53D25E0", VA = "0x1853D39E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0x53CFD90", Offset = "0x53CE990", VA = "0x1853CFD90")]
		internal static void CheckSetup()
		{
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x53D2DA0", Offset = "0x53D19A0", VA = "0x1853D2DA0")]
		internal static void SetupCacheFolder()
		{
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x53D0DE0", Offset = "0x53CF9E0", VA = "0x1853D0DE0")]
		internal static ulong GetNameIdx()
		{
			return 0UL;
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x53D0FB0", Offset = "0x53CFBB0", VA = "0x1853D0FB0")]
		internal static bool HasEntity(Uri uri)
		{
			return default(bool);
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x53CFF40", Offset = "0x53CEB40", VA = "0x1853CFF40")]
		internal static bool DeleteEntity(Uri uri, bool removeFromLibrary = true)
		{
			return default(bool);
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x53D1450", Offset = "0x53D0050", VA = "0x1853D1450")]
		internal static bool IsCachedEntityExpiresInTheFuture(HTTPRequest request)
		{
			return default(bool);
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x53D2AE0", Offset = "0x53D16E0", VA = "0x1853D2AE0")]
		internal static void SetHeaders(HTTPRequest request)
		{
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0x53D0A00", Offset = "0x53CF600", VA = "0x1853D0A00")]
		internal static HTTPCacheFileInfo GetEntity(Uri uri)
		{
			return null;
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0x53D0BC0", Offset = "0x53CF7C0", VA = "0x1853D0BC0")]
		internal static HTTPResponse GetFullResponse(HTTPRequest request)
		{
			return null;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0x53D1170", Offset = "0x53CFD70", VA = "0x1853D1170")]
		internal static bool IsCacheble(Uri uri, HTTPMethods method, HTTPResponse response)
		{
			return default(bool);
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x53D31A0", Offset = "0x53D1DA0", VA = "0x1853D31A0")]
		internal static HTTPCacheFileInfo Store(Uri uri, HTTPMethods method, HTTPResponse response)
		{
			return null;
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x53D1E90", Offset = "0x53D0A90", VA = "0x1853D1E90")]
		internal static Stream PrepareStreamed(Uri uri, HTTPResponse response)
		{
			return null;
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x53CFA60", Offset = "0x53CE660", VA = "0x1853CFA60")]
		public static void BeginClear()
		{
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0x53CFE00", Offset = "0x53CEA00", VA = "0x1853CFE00")]
		private static void ClearImpl(object param)
		{
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACC")]
		[Address(RVA = "0x53CFBF0", Offset = "0x53CE7F0", VA = "0x1853CFBF0")]
		public static void BeginMaintainence(HTTPCacheMaintananceParams maintananceParam)
		{
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0x53D0550", Offset = "0x53CF150", VA = "0x1853D0550")]
		public static int GetCacheEntityCount()
		{
			return 0;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0x53D0710", Offset = "0x53CF310", VA = "0x1853D0710")]
		public static ulong GetCacheSize()
		{
			return 0UL;
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ACF")]
		[Address(RVA = "0x53D1660", Offset = "0x53D0260", VA = "0x1853D1660")]
		private static void LoadLibrary()
		{
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0x53D21C0", Offset = "0x53D0DC0", VA = "0x1853D21C0")]
		internal static void SaveLibrary()
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x53D27B0", Offset = "0x53D13B0", VA = "0x1853D27B0")]
		internal static void SetBodyLength(Uri uri, int bodyLength)
		{
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x53D0290", Offset = "0x53CEE90", VA = "0x1853D0290")]
		private static void DeleteUnusedFiles()
		{
		}

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		private const int LibraryVersion = 2;

		// Token: 0x04001842 RID: 6210
		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0x0")]
		private static bool isSupported;

		// Token: 0x04001843 RID: 6211
		[Token(Token = "0x4001843")]
		[FieldOffset(Offset = "0x1")]
		private static bool IsSupportCheckDone;

		// Token: 0x04001844 RID: 6212
		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Uri, HTTPCacheFileInfo> library;

		// Token: 0x04001845 RID: 6213
		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<ulong, HTTPCacheFileInfo> UsedIndexes;

		// Token: 0x04001848 RID: 6216
		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x28")]
		private static bool InClearThread;

		// Token: 0x04001849 RID: 6217
		[Token(Token = "0x4001849")]
		[FieldOffset(Offset = "0x29")]
		private static bool InMaintainenceThread;

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x30")]
		private static ulong NextNameIDX;
	}
}
