using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001F6 RID: 502
	[Token(Token = "0x20001F6")]
	internal class SecT283R1Point : AbstractF2mPoint
	{
		// Token: 0x0600114A RID: 4426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x522C120", Offset = "0x522AD20", VA = "0x18522C120")]
		public SecT283R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x522C080", Offset = "0x522AC80", VA = "0x18522C080")]
		public SecT283R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT283R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114D")]
		[Address(RVA = "0x522B2D0", Offset = "0x5229ED0", VA = "0x18522B2D0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000253")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x600114E")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[Token(Token = "0x17000254")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x600114F")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x522AA70", Offset = "0x5229670", VA = "0x18522AA70", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x522BBD0", Offset = "0x522A7D0", VA = "0x18522BBD0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x522B600", Offset = "0x522A200", VA = "0x18522B600", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x522B410", Offset = "0x522A010", VA = "0x18522B410", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
