using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	public class Poly1305 : IMac
	{
		// Token: 0x06001AB4 RID: 6836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x52AB150", Offset = "0x52A9D50", VA = "0x1852AB150")]
		public Poly1305()
		{
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x52AB040", Offset = "0x52A9C40", VA = "0x1852AB040")]
		public Poly1305(IBlockCipher cipher)
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x52AA650", Offset = "0x52A9250", VA = "0x1852AA650", Slot = "4")]
		public void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x52AAC50", Offset = "0x52A9850", VA = "0x1852AAC50")]
		private void SetKey(byte[] key, byte[] nonce)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BD")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001AB8")]
			[Address(RVA = "0x52AB1E0", Offset = "0x52A9DE0", VA = "0x1852AB1E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0000CF30 File Offset: 0x0000B130
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "6")]
		public int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABA")]
		[Address(RVA = "0x52AAF50", Offset = "0x52A9B50", VA = "0x1852AAF50", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABB")]
		[Address(RVA = "0x52AA320", Offset = "0x52A8F20", VA = "0x1852AA320", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABC")]
		[Address(RVA = "0x52AA940", Offset = "0x52A9540", VA = "0x1852AA940")]
		private void ProcessBlock()
		{
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x6001ABD")]
		[Address(RVA = "0x52AA400", Offset = "0x52A9000", VA = "0x1852AA400", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0x52AAC40", Offset = "0x52A9840", VA = "0x1852AAC40", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0000CF60 File Offset: 0x0000B160
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x4CE1650", Offset = "0x4CE0250", VA = "0x184CE1650")]
		private static ulong mul32x32_64(uint i1, uint i2)
		{
			return 0UL;
		}

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000E11")]
		private const int BlockSize = 16;

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		[FieldOffset(Offset = "0x10")]
		private readonly IBlockCipher cipher;

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000E13")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] singleByte;

		// Token: 0x04000E14 RID: 3604
		[Token(Token = "0x4000E14")]
		[FieldOffset(Offset = "0x20")]
		private uint r0;

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000E15")]
		[FieldOffset(Offset = "0x24")]
		private uint r1;

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000E16")]
		[FieldOffset(Offset = "0x28")]
		private uint r2;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x2C")]
		private uint r3;

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000E18")]
		[FieldOffset(Offset = "0x30")]
		private uint r4;

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		[FieldOffset(Offset = "0x34")]
		private uint s1;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000E1A")]
		[FieldOffset(Offset = "0x38")]
		private uint s2;

		// Token: 0x04000E1B RID: 3611
		[Token(Token = "0x4000E1B")]
		[FieldOffset(Offset = "0x3C")]
		private uint s3;

		// Token: 0x04000E1C RID: 3612
		[Token(Token = "0x4000E1C")]
		[FieldOffset(Offset = "0x40")]
		private uint s4;

		// Token: 0x04000E1D RID: 3613
		[Token(Token = "0x4000E1D")]
		[FieldOffset(Offset = "0x44")]
		private uint k0;

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x48")]
		private uint k1;

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x4C")]
		private uint k2;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x50")]
		private uint k3;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x58")]
		private byte[] currentBlock;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x60")]
		private int currentBlockOffset;

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x64")]
		private uint h0;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x68")]
		private uint h1;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x6C")]
		private uint h2;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x70")]
		private uint h3;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x74")]
		private uint h4;
	}
}
