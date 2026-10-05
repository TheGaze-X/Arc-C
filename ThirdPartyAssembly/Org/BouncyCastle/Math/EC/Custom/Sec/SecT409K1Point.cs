using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	internal class SecT409K1Point : AbstractF2mPoint
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001197")]
		[Address(RVA = "0x5230D90", Offset = "0x522F990", VA = "0x185230D90")]
		public SecT409K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x5230E30", Offset = "0x522FA30", VA = "0x185230E30")]
		public SecT409K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001199")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT409K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119A")]
		[Address(RVA = "0x522FFE0", Offset = "0x522EBE0", VA = "0x18522FFE0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000266")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x600119B")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x17000267")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x600119C")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119D")]
		[Address(RVA = "0x522F7C0", Offset = "0x522E3C0", VA = "0x18522F7C0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119E")]
		[Address(RVA = "0x52308C0", Offset = "0x522F4C0", VA = "0x1852308C0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119F")]
		[Address(RVA = "0x5230310", Offset = "0x522EF10", VA = "0x185230310", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x5230120", Offset = "0x522ED20", VA = "0x185230120", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
