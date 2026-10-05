using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D9 RID: 729
	[Token(Token = "0x20002D9")]
	public class ElGamalPublicKeyParameters : ElGamalKeyParameters
	{
		// Token: 0x060018DB RID: 6363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x528B510", Offset = "0x528A110", VA = "0x18528B510")]
		public ElGamalPublicKeyParameters(BigInteger y, ElGamalParameters parameters)
		{
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036B")]
		public BigInteger Y
		{
			[Token(Token = "0x60018DC")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x528B3D0", Offset = "0x5289FD0", VA = "0x18528B3D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x52861F0", Offset = "0x5284DF0", VA = "0x1852861F0")]
		protected bool Equals(ElGamalPublicKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x5286290", Offset = "0x5284E90", VA = "0x185286290", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D22 RID: 3362
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger y;
	}
}
