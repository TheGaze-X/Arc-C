using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000338 RID: 824
	[Token(Token = "0x2000338")]
	public class IesEngine
	{
		// Token: 0x06001BD0 RID: 7120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x52C29C0", Offset = "0x52C15C0", VA = "0x1852C29C0")]
		public IesEngine(IBasicAgreement agree, IDerivationFunction kdf, IMac mac)
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x52C2A90", Offset = "0x52C1690", VA = "0x1852C2A90")]
		public IesEngine(IBasicAgreement agree, IDerivationFunction kdf, IMac mac, BufferedBlockCipher cipher)
		{
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x52C2650", Offset = "0x52C1250", VA = "0x1852C2650", Slot = "4")]
		public virtual void Init(bool forEncryption, ICipherParameters privParameters, ICipherParameters pubParameters, ICipherParameters iesParameters)
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x52C19E0", Offset = "0x52C05E0", VA = "0x1852C19E0")]
		private byte[] DecryptBlock(byte[] in_enc, int inOff, int inLen, byte[] z)
		{
			return null;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x52C1FA0", Offset = "0x52C0BA0", VA = "0x1852C1FA0")]
		private byte[] EncryptBlock(byte[] input, int inOff, int inLen, byte[] z)
		{
			return null;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x52C2500", Offset = "0x52C1100", VA = "0x1852C2500")]
		private byte[] GenerateKdfBytes(KdfParameters kParam, int length)
		{
			return null;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x52C27B0", Offset = "0x52C13B0", VA = "0x1852C27B0", Slot = "5")]
		public virtual byte[] ProcessBlock(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x04000EF2 RID: 3826
		[Token(Token = "0x4000EF2")]
		[FieldOffset(Offset = "0x10")]
		private readonly IBasicAgreement agree;

		// Token: 0x04000EF3 RID: 3827
		[Token(Token = "0x4000EF3")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDerivationFunction kdf;

		// Token: 0x04000EF4 RID: 3828
		[Token(Token = "0x4000EF4")]
		[FieldOffset(Offset = "0x20")]
		private readonly IMac mac;

		// Token: 0x04000EF5 RID: 3829
		[Token(Token = "0x4000EF5")]
		[FieldOffset(Offset = "0x28")]
		private readonly BufferedBlockCipher cipher;

		// Token: 0x04000EF6 RID: 3830
		[Token(Token = "0x4000EF6")]
		[FieldOffset(Offset = "0x30")]
		private readonly byte[] macBuf;

		// Token: 0x04000EF7 RID: 3831
		[Token(Token = "0x4000EF7")]
		[FieldOffset(Offset = "0x38")]
		private bool forEncryption;

		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x40")]
		private ICipherParameters privParam;

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x48")]
		private ICipherParameters pubParam;

		// Token: 0x04000EFA RID: 3834
		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0x50")]
		private IesParameters param;
	}
}
