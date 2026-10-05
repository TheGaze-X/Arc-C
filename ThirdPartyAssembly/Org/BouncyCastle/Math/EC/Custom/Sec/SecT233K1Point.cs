using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	internal class SecT233K1Point : AbstractF2mPoint
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x5216EC0", Offset = "0x5215AC0", VA = "0x185216EC0")]
		public SecT233K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x5216F60", Offset = "0x5215B60", VA = "0x185216F60")]
		public SecT233K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT233K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x5216110", Offset = "0x5214D10", VA = "0x185216110", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000219")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6001083")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x1700021A")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6001084")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x52158F0", Offset = "0x52144F0", VA = "0x1852158F0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x52169F0", Offset = "0x52155F0", VA = "0x1852169F0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x5216440", Offset = "0x5215040", VA = "0x185216440", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x5216250", Offset = "0x5214E50", VA = "0x185216250", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
