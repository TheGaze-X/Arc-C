using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000346 RID: 838
	[Token(Token = "0x2000346")]
	public class SeedEngine : IBlockCipher
	{
		// Token: 0x06001C75 RID: 7285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x52D1B90", Offset = "0x52D0790", VA = "0x1852D1B90", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EC")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C76")]
			[Address(RVA = "0x52D2490", Offset = "0x52D1090", VA = "0x1852D2490", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x170003ED")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001C77")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x52D1CF0", Offset = "0x52D08F0", VA = "0x1852D1CF0", Slot = "14")]
		public virtual int ProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x52D2230", Offset = "0x52D0E30", VA = "0x1852D2230")]
		private int[] createWorkingKey(byte[] inKey)
		{
			return null;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x21DABC0", Offset = "0x21D97C0", VA = "0x1821DABC0")]
		private int extractW1(long lVal)
		{
			return 0;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x52D2480", Offset = "0x52D1080", VA = "0x1852D2480")]
		private int extractW0(long lVal)
		{
			return 0;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x52D25C0", Offset = "0x52D11C0", VA = "0x1852D25C0")]
		private long rotateLeft8(long x)
		{
			return 0L;
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x52D25D0", Offset = "0x52D11D0", VA = "0x1852D25D0")]
		private long rotateRight8(long x)
		{
			return 0L;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[Token(Token = "0x6001C80")]
		[Address(RVA = "0x52D21E0", Offset = "0x52D0DE0", VA = "0x1852D21E0")]
		private long bytesToLong(byte[] src, int srcOff)
		{
			return 0L;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x52D24C0", Offset = "0x52D10C0", VA = "0x1852D24C0")]
		private void longToBytes(byte[] dest, int destOff, long value)
		{
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x52D1AB0", Offset = "0x52D06B0", VA = "0x1852D1AB0")]
		private int G(int x)
		{
			return 0;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0000DD88 File Offset: 0x0000BF88
		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x52D19E0", Offset = "0x52D05E0", VA = "0x1852D19E0")]
		private long F(int ki0, int ki1, long r)
		{
			return 0L;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x52D2510", Offset = "0x52D1110", VA = "0x1852D2510")]
		private int phaseCalc1(int r0, int ki0, int r1, int ki1)
		{
			return 0;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x52D2550", Offset = "0x52D1150", VA = "0x1852D2550")]
		private int phaseCalc2(int r0, int ki0, int r1, int ki1)
		{
			return 0;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SeedEngine()
		{
		}

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		private const int BlockSize = 16;

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] SS0;

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] SS1;

		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly uint[] SS2;

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x18")]
		private static readonly uint[] SS3;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly uint[] KC;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x10")]
		private int[] wKey;

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0x18")]
		private bool forEncryption;
	}
}
