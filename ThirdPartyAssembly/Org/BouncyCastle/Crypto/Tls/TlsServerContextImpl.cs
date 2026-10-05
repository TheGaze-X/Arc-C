using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	internal class TlsServerContextImpl : AbstractTlsContext, TlsServerContext, TlsContext
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x52743B0", Offset = "0x5272FB0", VA = "0x1852743B0")]
		internal TlsServerContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters)
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x17000327")]
		public override bool IsServer
		{
			[Token(Token = "0x60016EC")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}
	}
}
