using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	internal class SecT409R1Point : AbstractF2mPoint
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x5232970", Offset = "0x5231570", VA = "0x185232970")]
		public SecT409R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B0")]
		[Address(RVA = "0x5232A10", Offset = "0x5231610", VA = "0x185232A10")]
		public SecT409R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT409R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x5231BC0", Offset = "0x52307C0", VA = "0x185231BC0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000270")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x60011B3")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x17000271")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x60011B4")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x5231360", Offset = "0x522FF60", VA = "0x185231360", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x52324C0", Offset = "0x52310C0", VA = "0x1852324C0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B7")]
		[Address(RVA = "0x5231EF0", Offset = "0x5230AF0", VA = "0x185231EF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x5231D00", Offset = "0x5230900", VA = "0x185231D00", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
