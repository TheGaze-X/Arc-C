using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.Caching
{
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	public sealed class HTTPCacheMaintananceParams
	{
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x00012390 File Offset: 0x00010590
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000633")]
		public TimeSpan DeleteOlder
		{
			[Token(Token = "0x6002AAF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002AB0")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000123A8 File Offset: 0x000105A8
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000634")]
		public ulong MaxCacheSize
		{
			[Token(Token = "0x6002AB1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002AB2")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x3707440", Offset = "0x3706040", VA = "0x183707440")]
		public HTTPCacheMaintananceParams(TimeSpan deleteOlder, ulong maxCacheSize)
		{
		}
	}
}
