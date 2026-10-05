using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	public class HMac : IMac
	{
		// Token: 0x06001A9F RID: 6815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x52A84A0", Offset = "0x52A70A0", VA = "0x1852A84A0")]
		public HMac(IDigest digest)
		{
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BB")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001AA0")]
			[Address(RVA = "0x52A8580", Offset = "0x52A7180", VA = "0x1852A8580", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "12")]
		public virtual IDigest GetUnderlyingDigest()
		{
			return null;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x52A7EA0", Offset = "0x52A6AA0", VA = "0x1852A7EA0", Slot = "13")]
		public virtual void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "14")]
		public virtual int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x52A8380", Offset = "0x52A6F80", VA = "0x1852A8380", Slot = "15")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x52A7BC0", Offset = "0x52A67C0", VA = "0x1852A7BC0", Slot = "16")]
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x52A7C40", Offset = "0x52A6840", VA = "0x1852A7C40", Slot = "17")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x52A8300", Offset = "0x52A6F00", VA = "0x1852A8300", Slot = "18")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x52A8460", Offset = "0x52A7060", VA = "0x1852A8460")]
		private static void XorPad(byte[] pad, int len, byte n)
		{
		}

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		private const byte IPAD = 54;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		private const byte OPAD = 92;

		// Token: 0x04000E02 RID: 3586
		[Token(Token = "0x4000E02")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDigest digest;

		// Token: 0x04000E03 RID: 3587
		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x18")]
		private readonly int digestSize;

		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int blockLength;

		// Token: 0x04000E05 RID: 3589
		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x20")]
		private IMemoable ipadState;

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x28")]
		private IMemoable opadState;

		// Token: 0x04000E07 RID: 3591
		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x30")]
		private readonly byte[] inputPad;

		// Token: 0x04000E08 RID: 3592
		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x38")]
		private readonly byte[] outputBuf;
	}
}
