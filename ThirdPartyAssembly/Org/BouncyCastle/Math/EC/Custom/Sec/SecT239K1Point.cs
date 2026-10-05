using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	internal class SecT239K1Point : AbstractF2mPoint
	{
		// Token: 0x060010E4 RID: 4324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x521CED0", Offset = "0x521BAD0", VA = "0x18521CED0")]
		public SecT239K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x521CF70", Offset = "0x521BB70", VA = "0x18521CF70")]
		public SecT239K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT239K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x521C120", Offset = "0x521AD20", VA = "0x18521C120", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000236")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x60010E8")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x17000237")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x521B900", Offset = "0x521A500", VA = "0x18521B900", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x521CA00", Offset = "0x521B600", VA = "0x18521CA00", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EC")]
		[Address(RVA = "0x521C450", Offset = "0x521B050", VA = "0x18521C450", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010ED")]
		[Address(RVA = "0x521C260", Offset = "0x521AE60", VA = "0x18521C260", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
