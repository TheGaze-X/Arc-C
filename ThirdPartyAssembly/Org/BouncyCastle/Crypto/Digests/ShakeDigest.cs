using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	public class ShakeDigest : KeccakDigest, IXof, IDigest
	{
		// Token: 0x06001ED3 RID: 7891 RVA: 0x0000EC88 File Offset: 0x0000CE88
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x5325940", Offset = "0x5324540", VA = "0x185325940")]
		private static int CheckBitLength(int bitLength)
		{
			return 0;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x5326010", Offset = "0x5324C10", VA = "0x185326010")]
		public ShakeDigest()
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x5325F20", Offset = "0x5324B20", VA = "0x185325F20")]
		public ShakeDigest(int bitLength)
		{
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x5326060", Offset = "0x5324C60", VA = "0x185326060")]
		public ShakeDigest(ShakeDigest source)
		{
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000412")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001ED7")]
			[Address(RVA = "0x53260C0", Offset = "0x5324CC0", VA = "0x1853260C0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x5325D70", Offset = "0x5324970", VA = "0x185325D70", Slot = "17")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x5325CE0", Offset = "0x53248E0", VA = "0x185325CE0", Slot = "27")]
		public virtual int DoFinal(byte[] output, int outOff, int outLen)
		{
			return 0;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x5325E10", Offset = "0x5324A10", VA = "0x185325E10", Slot = "28")]
		public virtual int DoOutput(byte[] output, int outOff, int outLen)
		{
			return 0;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x5325C30", Offset = "0x5324830", VA = "0x185325C30", Slot = "18")]
		protected override int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			return 0;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0000ED00 File Offset: 0x0000CF00
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x5325A90", Offset = "0x5324690", VA = "0x185325A90", Slot = "29")]
		protected virtual int DoFinal(byte[] output, int outOff, int outLen, byte partialByte, int partialBits)
		{
			return 0;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x5325A00", Offset = "0x5324600", VA = "0x185325A00", Slot = "23")]
		public override IMemoable Copy()
		{
			return null;
		}
	}
}
