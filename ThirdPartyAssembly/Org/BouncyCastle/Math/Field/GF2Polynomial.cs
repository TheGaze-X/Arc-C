using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	internal class GF2Polynomial : IPolynomial
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x54ACEE0", Offset = "0x54ABAE0", VA = "0x1854ACEE0")]
		internal GF2Polynomial(int[] exponents)
		{
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x170000E8")]
		public virtual int Degree
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x54ACF20", Offset = "0x54ABB20", VA = "0x1854ACF20", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x54ACEC0", Offset = "0x54ABAC0", VA = "0x1854ACEC0", Slot = "7")]
		public virtual int[] GetExponentsPresent()
		{
			return null;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x54ACE00", Offset = "0x54ABA00", VA = "0x1854ACE00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x54ACED0", Offset = "0x54ABAD0", VA = "0x1854ACED0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x10")]
		protected readonly int[] exponents;
	}
}
