using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	public class DHValidationParameters
	{
		// Token: 0x06001873 RID: 6259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001873")]
		[Address(RVA = "0x5284210", Offset = "0x5282E10", VA = "0x185284210")]
		public DHValidationParameters(byte[] seed, int counter)
		{
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x5284190", Offset = "0x5282D90", VA = "0x185284190")]
		public byte[] GetSeed()
		{
			return null;
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x0000BE38 File Offset: 0x0000A038
		[Token(Token = "0x1700034F")]
		public int Counter
		{
			[Token(Token = "0x6001875")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x5284040", Offset = "0x5282C40", VA = "0x185284040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0000BE68 File Offset: 0x0000A068
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x5284110", Offset = "0x5282D10", VA = "0x185284110")]
		protected bool Equals(DHValidationParameters other)
		{
			return default(bool);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x5284150", Offset = "0x5282D50", VA = "0x185284150", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] seed;

		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0x18")]
		private readonly int counter;
	}
}
