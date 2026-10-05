using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000298")]
	public class TlsFatalAlert : IOException
	{
		// Token: 0x06001654 RID: 5716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x526C540", Offset = "0x526B140", VA = "0x18526C540")]
		public TlsFatalAlert(byte alertDescription)
		{
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x526C580", Offset = "0x526B180", VA = "0x18526C580")]
		public TlsFatalAlert(byte alertDescription, Exception alertCause)
		{
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x1700031E")]
		public virtual byte AlertDescription
		{
			[Token(Token = "0x6001656")]
			[Address(RVA = "0x22032F0", Offset = "0x2201EF0", VA = "0x1822032F0", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x90")]
		private readonly byte alertDescription;
	}
}
