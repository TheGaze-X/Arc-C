using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000377 RID: 887
	[Token(Token = "0x2000377")]
	public class MD2Digest : IDigest, IMemoable
	{
		// Token: 0x06001DE8 RID: 7656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x52E2490", Offset = "0x52E1090", VA = "0x1852E2490")]
		public MD2Digest()
		{
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x52E2530", Offset = "0x52E1130", VA = "0x1852E2530")]
		public MD2Digest(MD2Digest t)
		{
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x52E1C00", Offset = "0x52E0800", VA = "0x1852E1C00")]
		private void CopyIn(MD2Digest t)
		{
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000403")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001DEB")]
			[Address(RVA = "0x52E25E0", Offset = "0x52E11E0", VA = "0x1852E25E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "5")]
		public int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "6")]
		public int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0000E400 File Offset: 0x0000C600
		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0x52E1DB0", Offset = "0x52E09B0", VA = "0x1852E1DB0", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEF")]
		[Address(RVA = "0x52E22A0", Offset = "0x52E0EA0", VA = "0x1852E22A0", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0x52E2390", Offset = "0x52E0F90", VA = "0x1852E2390", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF1")]
		[Address(RVA = "0x52E1A70", Offset = "0x52E0670", VA = "0x1852E1A70", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0x52E2030", Offset = "0x52E0C30", VA = "0x1852E2030")]
		internal void ProcessChecksum(byte[] m)
		{
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0x52E1EA0", Offset = "0x52E0AA0", VA = "0x1852E1EA0")]
		internal void ProcessBlock(byte[] m)
		{
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0x52E1CC0", Offset = "0x52E08C0", VA = "0x1852E1CC0", Slot = "11")]
		public IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF5")]
		[Address(RVA = "0x52E2150", Offset = "0x52E0D50", VA = "0x1852E2150", Slot = "12")]
		public void Reset(IMemoable other)
		{
		}

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		private const int DigestLength = 16;

		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		private const int BYTE_LENGTH = 16;

		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x10")]
		private byte[] X;

		// Token: 0x0400102C RID: 4140
		[Token(Token = "0x400102C")]
		[FieldOffset(Offset = "0x18")]
		private int xOff;

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x20")]
		private byte[] M;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x28")]
		private int mOff;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x30")]
		private byte[] C;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x38")]
		private int COff;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] S;
	}
}
