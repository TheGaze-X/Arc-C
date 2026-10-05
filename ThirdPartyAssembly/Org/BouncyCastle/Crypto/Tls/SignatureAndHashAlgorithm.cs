using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	public class SignatureAndHashAlgorithm
	{
		// Token: 0x06001550 RID: 5456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x5250510", Offset = "0x524F110", VA = "0x185250510")]
		public SignatureAndHashAlgorithm(byte hash, byte signature)
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x17000300")]
		public virtual byte Hash
		{
			[Token(Token = "0x6001551")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x17000301")]
		public virtual byte Signature
		{
			[Token(Token = "0x6001552")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x5250210", Offset = "0x524EE10", VA = "0x185250210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x52503E0", Offset = "0x524EFE0", VA = "0x1852503E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x5250140", Offset = "0x524ED40", VA = "0x185250140", Slot = "6")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x5250460", Offset = "0x524F060", VA = "0x185250460")]
		public static SignatureAndHashAlgorithm Parse(Stream input)
		{
			return null;
		}

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte mHash;

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x11")]
		protected readonly byte mSignature;
	}
}
