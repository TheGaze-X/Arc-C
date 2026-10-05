using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000344 RID: 836
	[Token(Token = "0x2000344")]
	internal class RsaCoreEngine
	{
		// Token: 0x06001C5B RID: 7259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5B")]
		[Address(RVA = "0x52CFCB0", Offset = "0x52CE8B0", VA = "0x1852CFCB0", Slot = "4")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0000DC08 File Offset: 0x0000BE08
		[Token(Token = "0x6001C5C")]
		[Address(RVA = "0x52CFC50", Offset = "0x52CE850", VA = "0x1852CFC50", Slot = "5")]
		public virtual int GetInputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[Token(Token = "0x6001C5D")]
		[Address(RVA = "0x52CFC80", Offset = "0x52CE880", VA = "0x1852CFC80", Slot = "6")]
		public virtual int GetOutputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C5E")]
		[Address(RVA = "0x52CFA10", Offset = "0x52CE610", VA = "0x1852CFA10", Slot = "7")]
		public virtual BigInteger ConvertInput(byte[] inBuf, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C5F")]
		[Address(RVA = "0x52CFB90", Offset = "0x52CE790", VA = "0x1852CFB90", Slot = "8")]
		public virtual byte[] ConvertOutput(BigInteger result)
		{
			return null;
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C60")]
		[Address(RVA = "0x52D0000", Offset = "0x52CEC00", VA = "0x1852D0000", Slot = "9")]
		public virtual BigInteger ProcessBlock(BigInteger input)
		{
			return null;
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C61")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RsaCoreEngine()
		{
		}

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x10")]
		private RsaKeyParameters key;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x18")]
		private bool forEncryption;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x1C")]
		private int bitSize;
	}
}
