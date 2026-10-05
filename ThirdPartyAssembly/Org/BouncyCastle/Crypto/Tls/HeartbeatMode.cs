using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	public abstract class HeartbeatMode
	{
		// Token: 0x060014D8 RID: 5336 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x5249FD0", Offset = "0x5248BD0", VA = "0x185249FD0")]
		public static bool IsValid(byte heartbeatMode)
		{
			return default(bool);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected HeartbeatMode()
		{
		}

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		public const byte peer_allowed_to_send = 1;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		public const byte peer_not_allowed_to_send = 2;
	}
}
