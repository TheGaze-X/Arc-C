using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	public class RC2WrapEngine : IWrapper
	{
		// Token: 0x06001BF3 RID: 7155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x52C5500", Offset = "0x52C4100", VA = "0x1852C5500", Slot = "8")]
		public virtual void Init(bool forWrapping, ICipherParameters parameters)
		{
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DD")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0x52C66F0", Offset = "0x52C52F0", VA = "0x1852C66F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x52C60C0", Offset = "0x52C4CC0", VA = "0x1852C60C0", Slot = "10")]
		public virtual byte[] Wrap(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x52C59F0", Offset = "0x52C45F0", VA = "0x1852C59F0", Slot = "11")]
		public virtual byte[] Unwrap(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x52C52D0", Offset = "0x52C3ED0", VA = "0x1852C52D0")]
		private byte[] CalculateCmsKeyChecksum(byte[] key)
		{
			return null;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0000D860 File Offset: 0x0000BA60
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x52C54D0", Offset = "0x52C40D0", VA = "0x1852C54D0")]
		private bool CheckCmsKeyChecksum(byte[] key, byte[] checksum)
		{
			return default(bool);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x52C6650", Offset = "0x52C5250", VA = "0x1852C6650")]
		public RC2WrapEngine()
		{
		}

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x10")]
		private CbcBlockCipher engine;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x18")]
		private ICipherParameters parameters;

		// Token: 0x04000F09 RID: 3849
		[Token(Token = "0x4000F09")]
		[FieldOffset(Offset = "0x20")]
		private ParametersWithIV paramPlusIV;

		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x28")]
		private byte[] iv;

		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x30")]
		private bool forWrapping;

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x38")]
		private SecureRandom sr;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] IV2;

		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x40")]
		private IDigest sha1;

		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		[FieldOffset(Offset = "0x48")]
		private byte[] digest;
	}
}
