using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	public class VmpcEngine : IStreamCipher
	{
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F6")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001CDC")]
			[Address(RVA = "0x52EFF60", Offset = "0x52EEB60", VA = "0x1852EFF60", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x52EF920", Offset = "0x52EE520", VA = "0x1852EF920", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x52EF6F0", Offset = "0x52EE2F0", VA = "0x1852EF6F0", Slot = "11")]
		protected virtual void InitKey(byte[] keyBytes, byte[] ivBytes)
		{
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x52EFC90", Offset = "0x52EE890", VA = "0x1852EFC90", Slot = "12")]
		public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x52EFE40", Offset = "0x52EEA40", VA = "0x1852EFE40", Slot = "13")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0000E100 File Offset: 0x0000C300
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x52EFEA0", Offset = "0x52EEAA0", VA = "0x1852EFEA0", Slot = "14")]
		public virtual byte ReturnByte(byte input)
		{
			return 0;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VmpcEngine()
		{
		}

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0x10")]
		protected byte n;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x18")]
		protected byte[] P;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x20")]
		protected byte s;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x28")]
		protected byte[] workingIV;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x30")]
		protected byte[] workingKey;
	}
}
