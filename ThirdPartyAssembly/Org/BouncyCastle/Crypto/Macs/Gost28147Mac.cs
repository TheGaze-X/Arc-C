using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	public class Gost28147Mac : IMac
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x52A7530", Offset = "0x52A6130", VA = "0x1852A7530")]
		public Gost28147Mac()
		{
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x52A7680", Offset = "0x52A6280", VA = "0x1852A7680")]
		private static int[] generateWorkingKey(byte[] userKey)
		{
			return null;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x52A6FA0", Offset = "0x52A5BA0", VA = "0x1852A6FA0", Slot = "4")]
		public void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BA")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001A94")]
			[Address(RVA = "0x52A77C0", Offset = "0x52A63C0", VA = "0x1852A77C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0000CE70 File Offset: 0x0000B070
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "6")]
		public int GetMacSize()
		{
			return 0;
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0000CE88 File Offset: 0x0000B088
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x52A7A00", Offset = "0x52A6600", VA = "0x1852A7A00")]
		private int gost28147_mainStep(int n1, int key)
		{
			return 0;
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x52A77F0", Offset = "0x52A63F0", VA = "0x1852A77F0")]
		private void gost28147MacFunc(int[] workingKey, byte[] input, int inOff, byte[] output, int outOff)
		{
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x52A7600", Offset = "0x52A6200", VA = "0x1852A7600")]
		private static int bytesToint(byte[] input, int inOff)
		{
			return 0;
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x52A7B50", Offset = "0x52A6750", VA = "0x1852A7B50")]
		private static void intTobytes(int num, byte[] output, int outOff)
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x52A6CA0", Offset = "0x52A58A0", VA = "0x1852A6CA0")]
		private static byte[] CM5func(byte[] buf, int bufOff, byte[] mac)
		{
			return null;
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x52A7410", Offset = "0x52A6010", VA = "0x1852A7410", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x52A6A10", Offset = "0x52A5610", VA = "0x1852A6A10", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x52A6D80", Offset = "0x52A5980", VA = "0x1852A6D80", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x52A73D0", Offset = "0x52A5FD0", VA = "0x1852A73D0", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		private const int blockSize = 8;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		private const int macSize = 4;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x10")]
		private int bufOff;

		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x18")]
		private byte[] buf;

		// Token: 0x04000DFC RID: 3580
		[Token(Token = "0x4000DFC")]
		[FieldOffset(Offset = "0x20")]
		private byte[] mac;

		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000DFD")]
		[FieldOffset(Offset = "0x28")]
		private bool firstStep;

		// Token: 0x04000DFE RID: 3582
		[Token(Token = "0x4000DFE")]
		[FieldOffset(Offset = "0x30")]
		private int[] workingKey;

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x38")]
		private byte[] S;
	}
}
