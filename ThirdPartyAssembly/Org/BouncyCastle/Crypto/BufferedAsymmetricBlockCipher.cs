using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	public class BufferedAsymmetricBlockCipher : BufferedCipherBase
	{
		// Token: 0x060012A9 RID: 4777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x52206F0", Offset = "0x521F2F0", VA = "0x1852206F0")]
		public BufferedAsymmetricBlockCipher(IAsymmetricBlockCipher cipher)
		{
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
		internal int GetBufferPosition()
		{
			return 0;
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029D")]
		public override string AlgorithmName
		{
			[Token(Token = "0x60012AB")]
			[Address(RVA = "0x5220760", Offset = "0x521F360", VA = "0x185220760", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x5220390", Offset = "0x521EF90", VA = "0x185220390", Slot = "24")]
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x52203E0", Offset = "0x521EFE0", VA = "0x1852203E0", Slot = "25")]
		public override int GetOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "26")]
		public override int GetUpdateOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x5220430", Offset = "0x521F030", VA = "0x185220430", Slot = "23")]
		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x5220510", Offset = "0x521F110", VA = "0x185220510", Slot = "27")]
		public override byte[] ProcessByte(byte input)
		{
			return null;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x52205B0", Offset = "0x521F1B0", VA = "0x1852205B0", Slot = "30")]
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x5220210", Offset = "0x521EE10", VA = "0x185220210", Slot = "33")]
		public override byte[] DoFinal()
		{
			return null;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x5220180", Offset = "0x521ED80", VA = "0x185220180", Slot = "35")]
		public override byte[] DoFinal(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x52206C0", Offset = "0x521F2C0", VA = "0x1852206C0", Slot = "39")]
		public override void Reset()
		{
		}

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAsymmetricBlockCipher cipher;

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x18")]
		private byte[] buffer;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x20")]
		private int bufOff;
	}
}
