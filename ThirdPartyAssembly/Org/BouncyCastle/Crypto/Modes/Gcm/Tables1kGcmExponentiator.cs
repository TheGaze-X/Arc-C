using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	public class Tables1kGcmExponentiator : IGcmExponentiator
	{
		// Token: 0x06001A61 RID: 6753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x52ACF30", Offset = "0x52ABB30", VA = "0x1852ACF30", Slot = "4")]
		public void Init(byte[] x)
		{
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x52ACD90", Offset = "0x52AB990", VA = "0x1852ACD90", Slot = "5")]
		public void ExponentiateX(long pow, byte[] output)
		{
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x52ACBA0", Offset = "0x52AB7A0", VA = "0x1852ACBA0")]
		private void EnsureAvailable(int bit)
		{
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Tables1kGcmExponentiator()
		{
		}

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x10")]
		private IList lookupPowX2;
	}
}
