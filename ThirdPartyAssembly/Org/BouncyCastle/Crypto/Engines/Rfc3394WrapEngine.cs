using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000341 RID: 833
	[Token(Token = "0x2000341")]
	public class Rfc3394WrapEngine : IWrapper
	{
		// Token: 0x06001C35 RID: 7221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x52CBD90", Offset = "0x52CA990", VA = "0x1852CBD90")]
		public Rfc3394WrapEngine(IBlockCipher engine)
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x52CB1C0", Offset = "0x52C9DC0", VA = "0x1852CB1C0", Slot = "8")]
		public virtual void Init(bool forWrapping, ICipherParameters parameters)
		{
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E6")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C37")]
			[Address(RVA = "0x52CBE30", Offset = "0x52CAA30", VA = "0x1852CBE30", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x52CBA30", Offset = "0x52CA630", VA = "0x1852CBA30", Slot = "10")]
		public virtual byte[] Wrap(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C39")]
		[Address(RVA = "0x52CB610", Offset = "0x52CA210", VA = "0x1852CB610", Slot = "11")]
		public virtual byte[] Unwrap(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x10")]
		private readonly IBlockCipher engine;

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x18")]
		private KeyParameter param;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x20")]
		private bool forWrapping;

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x28")]
		private byte[] iv;
	}
}
