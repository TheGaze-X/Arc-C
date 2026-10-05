using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000376 RID: 886
	[Token(Token = "0x2000376")]
	public abstract class LongDigest : IDigest, IMemoable
	{
		// Token: 0x06001DD0 RID: 7632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x52E1840", Offset = "0x52E0440", VA = "0x1852E1840")]
		internal LongDigest()
		{
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x52E18F0", Offset = "0x52E04F0", VA = "0x1852E18F0")]
		internal LongDigest(LongDigest t)
		{
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0x52E0940", Offset = "0x52DF540", VA = "0x1852E0940")]
		protected void CopyIn(LongDigest t)
		{
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0x52E1740", Offset = "0x52E0340", VA = "0x1852E1740", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0x52E06E0", Offset = "0x52DF2E0", VA = "0x1852E06E0", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0x52E0A20", Offset = "0x52DF620", VA = "0x1852E0A20")]
		public void Finish()
		{
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x52E15E0", Offset = "0x52E01E0", VA = "0x1852E15E0", Slot = "13")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0x52E1560", Offset = "0x52E0160", VA = "0x1852E1560")]
		internal void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0x52E06B0", Offset = "0x52DF2B0", VA = "0x1852E06B0")]
		private void AdjustByteCounts()
		{
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0x52E14F0", Offset = "0x52E00F0", VA = "0x1852E14F0")]
		internal void ProcessLength(long lowW, long hiW)
		{
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0x52E0BE0", Offset = "0x52DF7E0", VA = "0x1852E0BE0")]
		internal void ProcessBlock()
		{
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0000E328 File Offset: 0x0000C528
		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0x4B4BC60", Offset = "0x4B4A860", VA = "0x184B4BC60")]
		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			return 0UL;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0000E340 File Offset: 0x0000C540
		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0x4B4BE10", Offset = "0x4B4AA10", VA = "0x184B4BE10")]
		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			return 0UL;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x0000E358 File Offset: 0x0000C558
		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x52E16C0", Offset = "0x52E02C0", VA = "0x1852E16C0")]
		private static ulong Sum0(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0000E370 File Offset: 0x0000C570
		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0x52E1700", Offset = "0x52E0300", VA = "0x1852E1700")]
		private static ulong Sum1(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0000E388 File Offset: 0x0000C588
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0x52E1660", Offset = "0x52E0260", VA = "0x1852E1660")]
		private static ulong Sigma0(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		[Token(Token = "0x6001DE0")]
		[Address(RVA = "0x52E1690", Offset = "0x52E0290", VA = "0x1852E1690")]
		private static ulong Sigma1(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "6")]
		public int GetByteLength()
		{
			return 0;
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001DE2 RID: 7650
		[Token(Token = "0x17000402")]
		public abstract string AlgorithmName { [Token(Token = "0x6001DE2")] get; }

		// Token: 0x06001DE3 RID: 7651
		[Token(Token = "0x6001DE3")]
		public abstract int GetDigestSize();

		// Token: 0x06001DE4 RID: 7652
		[Token(Token = "0x6001DE4")]
		public abstract int DoFinal(byte[] output, int outOff);

		// Token: 0x06001DE5 RID: 7653
		[Token(Token = "0x6001DE5")]
		public abstract IMemoable Copy();

		// Token: 0x06001DE6 RID: 7654
		[Token(Token = "0x6001DE6")]
		public abstract void Reset(IMemoable t);

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x10")]
		private int MyByteLength;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x18")]
		private byte[] xBuf;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x20")]
		private int xBufOff;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x28")]
		private long byteCount1;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x30")]
		private long byteCount2;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x38")]
		internal ulong H1;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x40")]
		internal ulong H2;

		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x48")]
		internal ulong H3;

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x50")]
		internal ulong H4;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x58")]
		internal ulong H5;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x60")]
		internal ulong H6;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x68")]
		internal ulong H7;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x70")]
		internal ulong H8;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x78")]
		private ulong[] W;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x80")]
		private int wOff;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ulong[] K;
	}
}
