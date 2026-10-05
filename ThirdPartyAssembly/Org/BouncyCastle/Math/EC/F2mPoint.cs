using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	public class F2mPoint : AbstractF2mPoint
	{
		// Token: 0x06000B52 RID: 2898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x54A5530", Offset = "0x54A4130", VA = "0x1854A5530")]
		public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x54A5610", Offset = "0x54A4210", VA = "0x1854A5610")]
		public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x5498500", Offset = "0x5497100", VA = "0x185498500")]
		internal F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x54A56F0", Offset = "0x54A42F0", VA = "0x1854A56F0")]
		[Obsolete("Use ECCurve.Infinity property")]
		public F2mPoint(ECCurve curve)
		{
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x54A3E40", Offset = "0x54A2A40", VA = "0x1854A3E40", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000126")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x54A58A0", Offset = "0x54A44A0", VA = "0x1854A58A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x17000127")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x54A5720", Offset = "0x54A4320", VA = "0x1854A5720", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x54A2F70", Offset = "0x54A1B70", VA = "0x1854A2F70", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x54A4A70", Offset = "0x54A3670", VA = "0x1854A4A70", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x54A4420", Offset = "0x54A3020", VA = "0x1854A4420", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x54A3F90", Offset = "0x54A2B90", VA = "0x1854A3F90", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
