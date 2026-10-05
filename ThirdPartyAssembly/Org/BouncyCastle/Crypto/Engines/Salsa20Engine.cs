using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	public class Salsa20Engine : IStreamCipher
	{
		// Token: 0x06001C62 RID: 7266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C62")]
		[Address(RVA = "0x52D0700", Offset = "0x52CF300", VA = "0x1852D0700")]
		internal void PackTauOrSigma(int keyLength, uint[] state, int stateOffset)
		{
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x52D16C0", Offset = "0x52D02C0", VA = "0x1852D16C0")]
		public Salsa20Engine()
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x52D1810", Offset = "0x52D0410", VA = "0x1852D1810")]
		public Salsa20Engine(int rounds)
		{
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x52D0310", Offset = "0x52CEF10", VA = "0x1852D0310", Slot = "9")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0000DC38 File Offset: 0x0000BE38
		[Token(Token = "0x170003EA")]
		protected virtual int NonceSize
		{
			[Token(Token = "0x6001C66")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EB")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C67")]
			[Address(RVA = "0x52D1920", Offset = "0x52D0520", VA = "0x1852D1920", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0000DC50 File Offset: 0x0000BE50
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x52D0B50", Offset = "0x52CF750", VA = "0x1852D0B50", Slot = "12")]
		public virtual byte ReturnByte(byte input)
		{
			return 0;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x52D0230", Offset = "0x52CEE30", VA = "0x1852D0230", Slot = "13")]
		protected virtual void AdvanceCounter()
		{
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x52D0860", Offset = "0x52CF460", VA = "0x1852D0860", Slot = "14")]
		public virtual void ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x52D0B10", Offset = "0x52CF710", VA = "0x1852D0B10", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x52D0AC0", Offset = "0x52CF6C0", VA = "0x1852D0AC0", Slot = "16")]
		protected virtual void ResetCounter()
		{
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6D")]
		[Address(RVA = "0x52D12F0", Offset = "0x52CFEF0", VA = "0x1852D12F0", Slot = "17")]
		protected virtual void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x52D0270", Offset = "0x52CEE70", VA = "0x1852D0270", Slot = "18")]
		protected virtual void GenerateKeyStream(byte[] output)
		{
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6F")]
		[Address(RVA = "0x52D0C70", Offset = "0x52CF870", VA = "0x1852D0C70")]
		internal static void SalsaCore(int rounds, uint[] input, uint[] x)
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0000DC68 File Offset: 0x0000BE68
		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x4CD7DD0", Offset = "0x4CD69D0", VA = "0x184CD7DD0")]
		internal static uint R(uint x, int y)
		{
			return 0U;
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x52D0B00", Offset = "0x52CF700", VA = "0x1852D0B00")]
		private void ResetLimitCounter()
		{
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0000DC80 File Offset: 0x0000BE80
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x52D06E0", Offset = "0x52CF2E0", VA = "0x1852D06E0")]
		private bool LimitExceeded()
		{
			return default(bool);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x52D06B0", Offset = "0x52CF2B0", VA = "0x1852D06B0")]
		private bool LimitExceeded(uint len)
		{
			return default(bool);
		}

		// Token: 0x04000F4C RID: 3916
		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int DEFAULT_ROUNDS;

		// Token: 0x04000F4D RID: 3917
		[Token(Token = "0x4000F4D")]
		private const int StateSize = 16;

		// Token: 0x04000F4E RID: 3918
		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] TAU_SIGMA;

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x10")]
		[Obsolete]
		protected static readonly byte[] sigma;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x18")]
		[Obsolete]
		protected static readonly byte[] tau;

		// Token: 0x04000F51 RID: 3921
		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x10")]
		protected int rounds;

		// Token: 0x04000F52 RID: 3922
		[Token(Token = "0x4000F52")]
		[FieldOffset(Offset = "0x14")]
		private int index;

		// Token: 0x04000F53 RID: 3923
		[Token(Token = "0x4000F53")]
		[FieldOffset(Offset = "0x18")]
		internal uint[] engineState;

		// Token: 0x04000F54 RID: 3924
		[Token(Token = "0x4000F54")]
		[FieldOffset(Offset = "0x20")]
		internal uint[] x;

		// Token: 0x04000F55 RID: 3925
		[Token(Token = "0x4000F55")]
		[FieldOffset(Offset = "0x28")]
		private byte[] keyStream;

		// Token: 0x04000F56 RID: 3926
		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x30")]
		private bool initialised;

		// Token: 0x04000F57 RID: 3927
		[Token(Token = "0x4000F57")]
		[FieldOffset(Offset = "0x34")]
		private uint cW0;

		// Token: 0x04000F58 RID: 3928
		[Token(Token = "0x4000F58")]
		[FieldOffset(Offset = "0x38")]
		private uint cW1;

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x3C")]
		private uint cW2;
	}
}
