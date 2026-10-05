using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	// Token: 0x02000205 RID: 517
	[Token(Token = "0x2000205")]
	internal class Curve25519FieldElement : ECFieldElement
	{
		// Token: 0x0600123F RID: 4671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x5224340", Offset = "0x5222F40", VA = "0x185224340")]
		public Curve25519FieldElement(BigInteger x)
		{
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001240")]
		[Address(RVA = "0x51E9DF0", Offset = "0x51E89F0", VA = "0x1851E9DF0")]
		public Curve25519FieldElement()
		{
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		protected internal Curve25519FieldElement(uint[] x)
		{
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x17000292")]
		public override bool IsZero
		{
			[Token(Token = "0x6001242")]
			[Address(RVA = "0x51E9EC0", Offset = "0x51E8AC0", VA = "0x1851E9EC0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x17000293")]
		public override bool IsOne
		{
			[Token(Token = "0x6001243")]
			[Address(RVA = "0x51E9EB0", Offset = "0x51E8AB0", VA = "0x1851E9EB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x51E9B60", Offset = "0x51E8760", VA = "0x1851E9B60", Slot = "24")]
		public override bool TestBitZero()
		{
			return default(bool);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x51E9B80", Offset = "0x51E8780", VA = "0x1851E9B80", Slot = "4")]
		public override BigInteger ToBigInteger()
		{
			return null;
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		public override string FieldName
		{
			[Token(Token = "0x6001246")]
			[Address(RVA = "0x5224500", Offset = "0x5223100", VA = "0x185224500", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x17000295")]
		public override int FieldSize
		{
			[Token(Token = "0x6001247")]
			[Address(RVA = "0x5224530", Offset = "0x5223130", VA = "0x185224530", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x5223330", Offset = "0x5221F30", VA = "0x185223330", Slot = "7")]
		public override ECFieldElement Add(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x52231C0", Offset = "0x5221DC0", VA = "0x1852231C0", Slot = "8")]
		public override ECFieldElement AddOne()
		{
			return null;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124A")]
		[Address(RVA = "0x52240B0", Offset = "0x5222CB0", VA = "0x1852240B0", Slot = "9")]
		public override ECFieldElement Subtract(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x5223AA0", Offset = "0x52226A0", VA = "0x185223AA0", Slot = "10")]
		public override ECFieldElement Multiply(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x5223590", Offset = "0x5222190", VA = "0x185223590", Slot = "11")]
		public override ECFieldElement Divide(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x5223C40", Offset = "0x5222840", VA = "0x185223C40", Slot = "12")]
		public override ECFieldElement Negate()
		{
			return null;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124E")]
		[Address(RVA = "0x5224000", Offset = "0x5222C00", VA = "0x185224000", Slot = "13")]
		public override ECFieldElement Square()
		{
			return null;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124F")]
		[Address(RVA = "0x52239B0", Offset = "0x52225B0", VA = "0x1852239B0", Slot = "14")]
		public override ECFieldElement Invert()
		{
			return null;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001250")]
		[Address(RVA = "0x5223CF0", Offset = "0x52228F0", VA = "0x185223CF0", Slot = "15")]
		public override ECFieldElement Sqrt()
		{
			return null;
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x5223840", Offset = "0x5222440", VA = "0x185223840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x5223780", Offset = "0x5222380", VA = "0x185223780", Slot = "25")]
		public override bool Equals(ECFieldElement other)
		{
			return default(bool);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x51E9030", Offset = "0x51E7C30", VA = "0x1851E9030", Slot = "27")]
		public virtual bool Equals(Curve25519FieldElement other)
		{
			return default(bool);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x5223900", Offset = "0x5222500", VA = "0x185223900", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger Q;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] PRECOMP_POW2;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x10")]
		protected internal readonly uint[] x;
	}
}
