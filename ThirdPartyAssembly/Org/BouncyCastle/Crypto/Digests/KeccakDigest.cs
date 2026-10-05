using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000375 RID: 885
	[Token(Token = "0x2000375")]
	public class KeccakDigest : IDigest, IMemoable
	{
		// Token: 0x06001DAB RID: 7595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAB")]
		[Address(RVA = "0x52DF020", Offset = "0x52DDC20", VA = "0x1852DF020")]
		private static ulong[] KeccakInitializeRoundConstants()
		{
			return null;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x52DEF10", Offset = "0x52DDB10", VA = "0x1852DEF10")]
		private static int[] KeccakInitializeRhoOffsets()
		{
			return null;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x52DE540", Offset = "0x52DD140", VA = "0x1852DE540")]
		private void ClearDataQueueSection(int off, int len)
		{
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAE")]
		[Address(RVA = "0x52E0460", Offset = "0x52DF060", VA = "0x1852E0460")]
		public KeccakDigest()
		{
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0x52E0360", Offset = "0x52DEF60", VA = "0x1852E0360")]
		public KeccakDigest(int bitLength)
		{
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x52E0560", Offset = "0x52DF160", VA = "0x1852E0560")]
		public KeccakDigest(KeccakDigest source)
		{
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0x52DE580", Offset = "0x52DD180", VA = "0x1852DE580")]
		private void CopyIn(KeccakDigest source)
		{
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000401")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001DB2")]
			[Address(RVA = "0x52E0660", Offset = "0x52DF260", VA = "0x1852E0660", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0x52DEAC0", Offset = "0x52DD6C0", VA = "0x1852DEAC0", Slot = "14")]
		public virtual int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0x52E00C0", Offset = "0x52DECC0", VA = "0x1852E00C0", Slot = "15")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0x52DE3A0", Offset = "0x52DCFA0", VA = "0x1852DE3A0", Slot = "16")]
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x52DE790", Offset = "0x52DD390", VA = "0x1852DE790", Slot = "17")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[Token(Token = "0x6001DB7")]
		[Address(RVA = "0x52DE850", Offset = "0x52DD450", VA = "0x1852DE850", Slot = "18")]
		protected virtual int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			return 0;
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB8")]
		[Address(RVA = "0x52DFC20", Offset = "0x52DE820", VA = "0x1852DFC20", Slot = "19")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0000E310 File Offset: 0x0000C510
		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0x52DEAB0", Offset = "0x52DD6B0", VA = "0x1852DEAB0", Slot = "20")]
		public virtual int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0x52DEC70", Offset = "0x52DD870", VA = "0x1852DEC70")]
		private void Init(int bitLength)
		{
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0x52DEAD0", Offset = "0x52DD6D0", VA = "0x1852DEAD0")]
		private void InitSponge(int rate, int capacity)
		{
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBC")]
		[Address(RVA = "0x52DDFF0", Offset = "0x52DCBF0", VA = "0x1852DDFF0")]
		private void AbsorbQueue()
		{
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBD")]
		[Address(RVA = "0x52DE070", Offset = "0x52DCC70", VA = "0x1852DE070", Slot = "21")]
		protected virtual void Absorb(byte[] data, int off, long databitlen)
		{
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBE")]
		[Address(RVA = "0x52DF7C0", Offset = "0x52DE3C0", VA = "0x1852DF7C0")]
		private void PadAndSwitchToSqueezingPhase()
		{
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x52DFDA0", Offset = "0x52DE9A0", VA = "0x1852DFDA0", Slot = "22")]
		protected virtual void Squeeze(byte[] output, int offset, long outputLength)
		{
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x52DE980", Offset = "0x52DD580", VA = "0x1852DE980")]
		private static void FromBytesToWords(ulong[] stateAsWords, byte[] state)
		{
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0x52DEA20", Offset = "0x52DD620", VA = "0x1852DEA20")]
		private static void FromWordsToBytes(byte[] state, ulong[] stateAsWords)
		{
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x52DF620", Offset = "0x52DE220", VA = "0x1852DF620")]
		private void KeccakPermutation(byte[] state)
		{
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x52DEE50", Offset = "0x52DDA50", VA = "0x1852DEE50")]
		private void KeccakPermutationAfterXor(byte[] state, byte[] data, int dataLengthInBytes)
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x52DF0F0", Offset = "0x52DDCF0", VA = "0x1852DF0F0")]
		private void KeccakPermutationOnWords(ulong[] state)
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x52DFF50", Offset = "0x52DEB50", VA = "0x1852DFF50")]
		private void Theta(ulong[] A)
		{
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x52DFC30", Offset = "0x52DE830", VA = "0x1852DFC30")]
		private void Rho(ulong[] A)
		{
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x52DF9C0", Offset = "0x52DE5C0", VA = "0x1852DF9C0")]
		private void Pi(ulong[] A)
		{
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x52DE410", Offset = "0x52DD010", VA = "0x1852DE410")]
		private void Chi(ulong[] A)
		{
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0x52DEDB0", Offset = "0x52DD9B0", VA = "0x1852DEDB0")]
		private static void Iota(ulong[] A, int indexRound)
		{
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x52DEE50", Offset = "0x52DDA50", VA = "0x1852DEE50")]
		private void KeccakAbsorb(byte[] byteState, byte[] data, int dataInBytes)
		{
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0x52DEEB0", Offset = "0x52DDAB0", VA = "0x1852DEEB0")]
		private void KeccakExtract1024bits(byte[] byteState, byte[] data)
		{
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0x52DEEE0", Offset = "0x52DDAE0", VA = "0x1852DEEE0")]
		private void KeccakExtract(byte[] byteState, byte[] data, int laneCount)
		{
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0x52DE650", Offset = "0x52DD250", VA = "0x1852DE650", Slot = "23")]
		public virtual IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0x52DFAB0", Offset = "0x52DE6B0", VA = "0x1852DFAB0", Slot = "24")]
		public virtual void Reset(IMemoable other)
		{
		}

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ulong[] KeccakRoundConstants;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] KeccakRhoOffsets;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0x10")]
		protected byte[] state;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x18")]
		protected byte[] dataQueue;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x20")]
		protected int rate;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x24")]
		protected int bitsInQueue;

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x28")]
		protected int fixedOutputLength;

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x2C")]
		protected bool squeezing;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x30")]
		protected int bitsAvailableForSqueezing;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x38")]
		protected byte[] chunk;

		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x40")]
		protected byte[] oneByte;

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		[FieldOffset(Offset = "0x48")]
		private ulong[] C;

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x50")]
		private ulong[] tempA;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x58")]
		private ulong[] chiC;
	}
}
