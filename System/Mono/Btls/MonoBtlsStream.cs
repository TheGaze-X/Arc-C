using System;
using System.IO;
using System.Net.Security;
using Il2CppDummyDll;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono.Btls
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	internal class MonoBtlsStream : MobileAuthenticatedStream
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x50D3040", Offset = "0x50D1C40", VA = "0x1850D3040")]
		public MonoBtlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x50D2FD0", Offset = "0x50D1BD0", VA = "0x1850D2FD0", Slot = "41")]
		protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options)
		{
			return null;
		}
	}
}
