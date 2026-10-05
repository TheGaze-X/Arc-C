using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000343 RID: 835
	[Token(Token = "0x2000343")]
	public class RsaBlindedEngine : IAsymmetricBlockCipher
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E9")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C55")]
			[Address(RVA = "0x52CF9E0", Offset = "0x52CE5E0", VA = "0x1852CF9E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x52CF200", Offset = "0x52CDE00", VA = "0x1852CF200", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters param)
		{
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		[Token(Token = "0x6001C57")]
		[Address(RVA = "0x4F24700", Offset = "0x4F23300", VA = "0x184F24700", Slot = "11")]
		public virtual int GetInputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0x4FAEA60", Offset = "0x4FAD660", VA = "0x184FAEA60", Slot = "12")]
		public virtual int GetOutputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x52CF570", Offset = "0x52CE170", VA = "0x1852CF570", Slot = "13")]
		public virtual byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5A")]
		[Address(RVA = "0x52CF970", Offset = "0x52CE570", VA = "0x1852CF970")]
		public RsaBlindedEngine()
		{
		}

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x4000F46")]
		[FieldOffset(Offset = "0x10")]
		private readonly RsaCoreEngine core;

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x18")]
		private RsaKeyParameters key;

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x20")]
		private SecureRandom random;
	}
}
