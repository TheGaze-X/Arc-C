using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	public class SipHash : IMac
	{
		// Token: 0x06001AC0 RID: 6848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC0")]
		[Address(RVA = "0x52ACAE0", Offset = "0x52AB6E0", VA = "0x1852ACAE0")]
		public SipHash()
		{
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x3629A50", Offset = "0x3628650", VA = "0x183629A50")]
		public SipHash(int c, int d)
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BE")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001AC2")]
			[Address(RVA = "0x52ACB10", Offset = "0x52AB710", VA = "0x1852ACB10", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x6001AC3")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "12")]
		public virtual int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC4")]
		[Address(RVA = "0x52AC7E0", Offset = "0x52AB3E0", VA = "0x1852AC7E0", Slot = "13")]
		public virtual void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x52ACA80", Offset = "0x52AB680", VA = "0x1852ACA80", Slot = "14")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x52AC490", Offset = "0x52AB090", VA = "0x1852AC490", Slot = "15")]
		public virtual void BlockUpdate(byte[] input, int offset, int length)
		{
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x52AC6E0", Offset = "0x52AB2E0", VA = "0x1852AC6E0", Slot = "16")]
		public virtual long DoFinal()
		{
			return 0L;
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0x52AC670", Offset = "0x52AB270", VA = "0x1852AC670", Slot = "17")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x52ACA00", Offset = "0x52AB600", VA = "0x1852ACA00", Slot = "18")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x52AC9A0", Offset = "0x52AB5A0", VA = "0x1852AC9A0", Slot = "19")]
		protected virtual void ProcessMessageWord()
		{
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x52AC3C0", Offset = "0x52AAFC0", VA = "0x1852AC3C0", Slot = "20")]
		protected virtual void ApplySipRounds(int n)
		{
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x52ACA60", Offset = "0x52AB660", VA = "0x1852ACA60")]
		protected static long RotateLeft(long x, int n)
		{
			return 0L;
		}

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x10")]
		protected readonly int c;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x14")]
		protected readonly int d;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x18")]
		protected long k0;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x20")]
		protected long k1;

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x28")]
		protected long v0;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x30")]
		protected long v1;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x38")]
		protected long v2;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x40")]
		protected long v3;

		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000E30")]
		[FieldOffset(Offset = "0x48")]
		protected long m;

		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000E31")]
		[FieldOffset(Offset = "0x50")]
		protected int wordPos;

		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x54")]
		protected int wordCount;
	}
}
