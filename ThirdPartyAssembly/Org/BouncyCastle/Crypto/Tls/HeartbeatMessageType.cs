using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2000262")]
	public abstract class HeartbeatMessageType
	{
		// Token: 0x060014D6 RID: 5334 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x5249FD0", Offset = "0x5248BD0", VA = "0x185249FD0")]
		public static bool IsValid(byte heartbeatMessageType)
		{
			return default(bool);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected HeartbeatMessageType()
		{
		}

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		public const byte heartbeat_request = 1;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		public const byte heartbeat_response = 2;
	}
}
