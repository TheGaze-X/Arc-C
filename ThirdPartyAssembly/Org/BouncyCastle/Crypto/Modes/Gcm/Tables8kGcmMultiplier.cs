using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	public class Tables8kGcmMultiplier : IGcmMultiplier
	{
		// Token: 0x06001A65 RID: 6757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x52AD0A0", Offset = "0x52ABCA0", VA = "0x1852AD0A0", Slot = "4")]
		public void Init(byte[] H)
		{
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x52ADE70", Offset = "0x52ACA70", VA = "0x1852ADE70", Slot = "5")]
		public void MultiplyH(byte[] x)
		{
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Tables8kGcmMultiplier()
		{
		}

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x10")]
		private byte[] H;

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x18")]
		private uint[][][] M;
	}
}
