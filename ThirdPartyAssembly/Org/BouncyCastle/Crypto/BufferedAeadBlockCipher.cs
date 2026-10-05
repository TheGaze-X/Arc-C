using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Modes;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	public class BufferedAeadBlockCipher : BufferedCipherBase
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x5220070", Offset = "0x521EC70", VA = "0x185220070")]
		public BufferedAeadBlockCipher(IAeadBlockCipher cipher)
		{
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029C")]
		public override string AlgorithmName
		{
			[Token(Token = "0x600129C")]
			[Address(RVA = "0x5220130", Offset = "0x521ED30", VA = "0x185220130", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x521F9E0", Offset = "0x521E5E0", VA = "0x18521F9E0", Slot = "23")]
		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x521F8D0", Offset = "0x521E4D0", VA = "0x18521F8D0", Slot = "24")]
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x521F980", Offset = "0x521E580", VA = "0x18521F980", Slot = "26")]
		public override int GetUpdateOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x521F920", Offset = "0x521E520", VA = "0x18521F920", Slot = "25")]
		public override int GetOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x521FBA0", Offset = "0x521E7A0", VA = "0x18521FBA0", Slot = "28")]
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x521FCA0", Offset = "0x521E8A0", VA = "0x18521FCA0", Slot = "27")]
		public override byte[] ProcessByte(byte input)
		{
			return null;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x521FDB0", Offset = "0x521E9B0", VA = "0x18521FDB0", Slot = "30")]
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x521FF20", Offset = "0x521EB20", VA = "0x18521FF20", Slot = "32")]
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x521F7E0", Offset = "0x521E3E0", VA = "0x18521F7E0", Slot = "33")]
		public override byte[] DoFinal()
		{
			return null;
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x521F540", Offset = "0x521E140", VA = "0x18521F540", Slot = "35")]
		public override byte[] DoFinal(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x521F6E0", Offset = "0x521E2E0", VA = "0x18521F6E0", Slot = "36")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x5220020", Offset = "0x521EC20", VA = "0x185220020", Slot = "39")]
		public override void Reset()
		{
		}

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAeadBlockCipher cipher;
	}
}
