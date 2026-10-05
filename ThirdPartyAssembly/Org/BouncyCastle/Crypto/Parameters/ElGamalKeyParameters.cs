using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	public class ElGamalKeyParameters : AsymmetricKeyParameter
	{
		// Token: 0x060018C9 RID: 6345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x52859E0", Offset = "0x52845E0", VA = "0x1852859E0")]
		protected ElGamalKeyParameters(bool isPrivate, ElGamalParameters parameters)
		{
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000366")]
		public ElGamalParameters Parameters
		{
			[Token(Token = "0x60018CA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0000C168 File Offset: 0x0000A368
		[Token(Token = "0x60018CB")]
		[Address(RVA = "0x528AB70", Offset = "0x5289770", VA = "0x18528AB70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x5282E00", Offset = "0x5281A00", VA = "0x185282E00")]
		protected bool Equals(ElGamalKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x5282E60", Offset = "0x5281A60", VA = "0x185282E60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D1D RID: 3357
		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0x18")]
		private readonly ElGamalParameters parameters;
	}
}
