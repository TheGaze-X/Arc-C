using System;
using System.Security.Authentication;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public abstract class MonoTlsProvider
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal MonoTlsProvider()
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000153 RID: 339
		[Token(Token = "0x17000065")]
		public abstract Guid ID { [Token(Token = "0x6000153")] get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000154 RID: 340
		[Token(Token = "0x17000066")]
		public abstract string Name { [Token(Token = "0x6000154")] get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000155 RID: 341
		[Token(Token = "0x17000067")]
		public abstract bool SupportsSslStream { [Token(Token = "0x6000155")] get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000156 RID: 342
		[Token(Token = "0x17000068")]
		public abstract bool SupportsConnectionInfo { [Token(Token = "0x6000156")] get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000157 RID: 343
		[Token(Token = "0x17000069")]
		public abstract bool SupportsMonoExtensions { [Token(Token = "0x6000157")] get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000158 RID: 344
		[Token(Token = "0x1700006A")]
		public abstract SslProtocols SupportedProtocols { [Token(Token = "0x6000158")] get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000159 RID: 345
		[Token(Token = "0x1700006B")]
		internal abstract bool SupportsCleanShutdown { [Token(Token = "0x6000159")] get; }
	}
}
