using System;
using System.IO;
using System.Net.Security;
using Il2CppDummyDll;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono.Unity
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal class UnityTlsStream : MobileAuthenticatedStream
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x4F66880", Offset = "0x4F65480", VA = "0x184F66880")]
		public UnityTlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4F66810", Offset = "0x4F65410", VA = "0x184F66810", Slot = "41")]
		protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options)
		{
			return null;
		}
	}
}
