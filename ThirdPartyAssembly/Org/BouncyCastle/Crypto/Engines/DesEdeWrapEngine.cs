using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000331 RID: 817
	[Token(Token = "0x2000331")]
	public class DesEdeWrapEngine : IWrapper
	{
		// Token: 0x06001B78 RID: 7032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x52BA650", Offset = "0x52B9250", VA = "0x1852BA650", Slot = "8")]
		public virtual void Init(bool forWrapping, ICipherParameters parameters)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CF")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001B79")]
			[Address(RVA = "0x52BB670", Offset = "0x52BA270", VA = "0x1852BB670", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7A")]
		[Address(RVA = "0x52BB130", Offset = "0x52B9D30", VA = "0x1852BB130", Slot = "10")]
		public virtual byte[] Wrap(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x52BAC00", Offset = "0x52B9800", VA = "0x1852BAC00", Slot = "11")]
		public virtual byte[] Unwrap(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7C")]
		[Address(RVA = "0x52BA530", Offset = "0x52B9130", VA = "0x1852BA530")]
		private byte[] CalculateCmsKeyChecksum(byte[] key)
		{
			return null;
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0000D410 File Offset: 0x0000B610
		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x52BA620", Offset = "0x52B9220", VA = "0x1852BA620")]
		private bool CheckCmsKeyChecksum(byte[] key, byte[] checksum)
		{
			return default(bool);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x52BB6A0", Offset = "0x52BA2A0", VA = "0x1852BB6A0")]
		private static byte[] reverse(byte[] bs)
		{
			return null;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x52BB5D0", Offset = "0x52BA1D0", VA = "0x1852BB5D0")]
		public DesEdeWrapEngine()
		{
		}

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0x10")]
		private CbcBlockCipher engine;

		// Token: 0x04000EB7 RID: 3767
		[Token(Token = "0x4000EB7")]
		[FieldOffset(Offset = "0x18")]
		private KeyParameter param;

		// Token: 0x04000EB8 RID: 3768
		[Token(Token = "0x4000EB8")]
		[FieldOffset(Offset = "0x20")]
		private ParametersWithIV paramPlusIV;

		// Token: 0x04000EB9 RID: 3769
		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0x28")]
		private byte[] iv;

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x30")]
		private bool forWrapping;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] IV2;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x38")]
		private readonly IDigest sha1;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x40")]
		private readonly byte[] digest;
	}
}
