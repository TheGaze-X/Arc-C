using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000286 RID: 646
	[Token(Token = "0x2000286")]
	internal class TlsClientContextImpl : AbstractTlsContext, TlsClientContext, TlsContext
	{
		// Token: 0x06001593 RID: 5523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x52532C0", Offset = "0x5251EC0", VA = "0x1852532C0")]
		internal TlsClientContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters)
		{
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0000B0E8 File Offset: 0x000092E8
		[Token(Token = "0x1700030B")]
		public override bool IsServer
		{
			[Token(Token = "0x6001594")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}
	}
}
