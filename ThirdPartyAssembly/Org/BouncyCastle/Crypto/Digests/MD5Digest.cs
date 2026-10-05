using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000379 RID: 889
	[Token(Token = "0x2000379")]
	public class MD5Digest : GeneralDigest
	{
		// Token: 0x06001E08 RID: 7688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x52E4E10", Offset = "0x52E3A10", VA = "0x1852E4E10")]
		public MD5Digest()
		{
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x52E4D90", Offset = "0x52E3990", VA = "0x1852E4D90")]
		public MD5Digest(MD5Digest t)
		{
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x52E2610", Offset = "0x52E1210", VA = "0x1852E2610")]
		private void CopyIn(MD5Digest t)
		{
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000405")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x52E4ED0", Offset = "0x52E3AD0", VA = "0x1852E4ED0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		[Token(Token = "0x6001E0C")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x52E4A40", Offset = "0x52E3640", VA = "0x1852E4A40", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x52E4970", Offset = "0x52E3570", VA = "0x1852E4970", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x52E3830", Offset = "0x52E2430", VA = "0x1852E3830", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x52E3500", Offset = "0x52E2100", VA = "0x1852E3500", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x4CD7DD0", Offset = "0x4CD69D0", VA = "0x184CD7DD0")]
		private static uint RotateLeft(uint x, int n)
		{
			return 0U;
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x4B3E7C0", Offset = "0x4B3D3C0", VA = "0x184B3E7C0")]
		private static uint F(uint u, uint v, uint w)
		{
			return 0U;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0x4B3E800", Offset = "0x4B3D400", VA = "0x184B3E800")]
		private static uint G(uint u, uint v, uint w)
		{
			return 0U;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0000E520 File Offset: 0x0000C720
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x4B3E7B0", Offset = "0x4B3D3B0", VA = "0x184B3E7B0")]
		private static uint H(uint u, uint v, uint w)
		{
			return 0U;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x52E38D0", Offset = "0x52E24D0", VA = "0x1852E38D0")]
		private static uint K(uint u, uint v, uint w)
		{
			return 0U;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x52E38E0", Offset = "0x52E24E0", VA = "0x1852E38E0", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x52E3780", Offset = "0x52E2380", VA = "0x1852E3780", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x52E4AD0", Offset = "0x52E36D0", VA = "0x1852E4AD0", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		private const int DigestLength = 16;

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x28")]
		private uint H1;

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x2C")]
		private uint H2;

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0x30")]
		private uint H3;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0x34")]
		private uint H4;

		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		[FieldOffset(Offset = "0x38")]
		private uint[] X;

		// Token: 0x0400104B RID: 4171
		[Token(Token = "0x400104B")]
		[FieldOffset(Offset = "0x40")]
		private int xOff;

		// Token: 0x0400104C RID: 4172
		[Token(Token = "0x400104C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int S11;

		// Token: 0x0400104D RID: 4173
		[Token(Token = "0x400104D")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int S12;

		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int S13;

		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int S14;

		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int S21;

		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int S22;

		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int S23;

		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int S24;

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int S31;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int S32;

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int S33;

		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int S34;

		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int S41;

		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int S42;

		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int S43;

		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int S44;
	}
}
