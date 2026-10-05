using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	public class ElGamalPrivateKeyParameters : ElGamalKeyParameters
	{
		// Token: 0x060018D6 RID: 6358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x528B320", Offset = "0x5289F20", VA = "0x18528B320")]
		public ElGamalPrivateKeyParameters(BigInteger x, ElGamalParameters parameters)
		{
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036A")]
		public BigInteger X
		{
			[Token(Token = "0x60018D7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0000C210 File Offset: 0x0000A410
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x528B1E0", Offset = "0x5289DE0", VA = "0x18528B1E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0000C228 File Offset: 0x0000A428
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x528B140", Offset = "0x5289D40", VA = "0x18528B140")]
		protected bool Equals(ElGamalPrivateKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0000C240 File Offset: 0x0000A440
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x5286290", Offset = "0x5284E90", VA = "0x185286290", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger x;
	}
}
