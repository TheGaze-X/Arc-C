using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	internal class SecT283K1Point : AbstractF2mPoint
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x522A4A0", Offset = "0x52290A0", VA = "0x18522A4A0")]
		public SecT283K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x522A540", Offset = "0x5229140", VA = "0x18522A540")]
		public SecT283K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT283K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x52296F0", Offset = "0x52282F0", VA = "0x1852296F0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000249")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6001136")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00009AF8 File Offset: 0x00007CF8
		[Token(Token = "0x1700024A")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6001137")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x5228ED0", Offset = "0x5227AD0", VA = "0x185228ED0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001139")]
		[Address(RVA = "0x5229FD0", Offset = "0x5228BD0", VA = "0x185229FD0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x5229A20", Offset = "0x5228620", VA = "0x185229A20", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x5229830", Offset = "0x5228430", VA = "0x185229830", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
