using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	internal class WebConnectionTunnel
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000525")]
		public HttpWebRequest Request
		{
			[Token(Token = "0x6001785")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000526")]
		public Uri ConnectUri
		{
			[Token(Token = "0x6001786")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
		{
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000527")]
		public bool Success
		{
			[Token(Token = "0x6001788")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001789")]
			[Address(RVA = "0x4EF620", Offset = "0x4EE220", VA = "0x1804EF620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000528")]
		public bool CloseConnection
		{
			[Token(Token = "0x600178A")]
			[Address(RVA = "0x106F290", Offset = "0x106DE90", VA = "0x18106F290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600178B")]
			[Address(RVA = "0x106F2A0", Offset = "0x106DEA0", VA = "0x18106F2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0000AC08 File Offset: 0x00008E08
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000529")]
		public int StatusCode
		{
			[Token(Token = "0x600178C")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600178D")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700052A RID: 1322
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052A")]
		private string StatusDescription
		{
			[Token(Token = "0x600178E")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052B")]
		public string[] Challenge
		{
			[Token(Token = "0x600178F")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001790")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052C")]
		public WebHeaderCollection Headers
		{
			[Token(Token = "0x6001791")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001792")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052D")]
		public Version ProxyVersion
		{
			[Token(Token = "0x6001793")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001794")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052E")]
		public byte[] Data
		{
			[Token(Token = "0x6001795")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001796")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x50971A0", Offset = "0x5095DA0", VA = "0x1850971A0")]
		internal Task Initialize(Stream stream, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001798")]
		[Address(RVA = "0x50972C0", Offset = "0x5095EC0", VA = "0x1850972C0")]
		private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x50970F0", Offset = "0x5095CF0", VA = "0x1850970F0")]
		private void FlushContents(Stream stream, int contentLength)
		{
		}

		// Token: 0x04000D82 RID: 3458
		[Token(Token = "0x4000D82")]
		[FieldOffset(Offset = "0x20")]
		private HttpWebRequest connectRequest;

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x28")]
		private WebConnectionTunnel.NtlmAuthState ntlmAuthState;

		// Token: 0x02000348 RID: 840
		[Token(Token = "0x2000348")]
		private enum NtlmAuthState
		{
			// Token: 0x04000D8D RID: 3469
			[Token(Token = "0x4000D8D")]
			None,
			// Token: 0x04000D8E RID: 3470
			[Token(Token = "0x4000D8E")]
			Challenge,
			// Token: 0x04000D8F RID: 3471
			[Token(Token = "0x4000D8F")]
			Response
		}
	}
}
