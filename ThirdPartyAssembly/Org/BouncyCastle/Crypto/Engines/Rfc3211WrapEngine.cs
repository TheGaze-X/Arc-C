using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	public class Rfc3211WrapEngine : IWrapper
	{
		// Token: 0x06001C30 RID: 7216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x52CB0C0", Offset = "0x52C9CC0", VA = "0x1852CB0C0")]
		public Rfc3211WrapEngine(IBlockCipher engine)
		{
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x52CA670", Offset = "0x52C9270", VA = "0x1852CA670", Slot = "8")]
		public virtual void Init(bool forWrapping, ICipherParameters param)
		{
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E5")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C32")]
			[Address(RVA = "0x52CB150", Offset = "0x52C9D50", VA = "0x1852CB150", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x52CAE30", Offset = "0x52C9A30", VA = "0x1852CAE30", Slot = "10")]
		public virtual byte[] Wrap(byte[] inBytes, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x52CA9A0", Offset = "0x52C95A0", VA = "0x1852CA9A0", Slot = "11")]
		public virtual byte[] Unwrap(byte[] inBytes, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0x10")]
		private CbcBlockCipher engine;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x18")]
		private ParametersWithIV param;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x20")]
		private bool forWrapping;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x28")]
		private SecureRandom rand;
	}
}
