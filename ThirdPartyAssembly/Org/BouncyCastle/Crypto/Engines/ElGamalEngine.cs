using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	public class ElGamalEngine : IAsymmetricBlockCipher
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D2")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001B8C")]
			[Address(RVA = "0x52BD570", Offset = "0x52BC170", VA = "0x1852BD570", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x52BCAD0", Offset = "0x52BB6D0", VA = "0x1852BCAD0", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0000D470 File Offset: 0x0000B670
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x52BCA70", Offset = "0x52BB670", VA = "0x1852BCA70", Slot = "11")]
		public virtual int GetInputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0000D488 File Offset: 0x0000B688
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x52BCAA0", Offset = "0x52BB6A0", VA = "0x1852BCAA0", Slot = "12")]
		public virtual int GetOutputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x52BCFD0", Offset = "0x52BBBD0", VA = "0x1852BCFD0", Slot = "13")]
		public virtual byte[] ProcessBlock(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ElGamalEngine()
		{
		}

		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000ECD")]
		[FieldOffset(Offset = "0x10")]
		private ElGamalKeyParameters key;

		// Token: 0x04000ECE RID: 3790
		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x18")]
		private SecureRandom random;

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x20")]
		private bool forEncryption;

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x24")]
		private int bitSize;
	}
}
