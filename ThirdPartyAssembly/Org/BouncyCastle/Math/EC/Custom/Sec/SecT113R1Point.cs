using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	internal class SecT113R1Point : AbstractF2mPoint
	{
		// Token: 0x06000ED5 RID: 3797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x51FC580", Offset = "0x51FB180", VA = "0x1851FC580")]
		public SecT113R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x51FC4E0", Offset = "0x51FB0E0", VA = "0x1851FC4E0")]
		public SecT113R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT113R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x51FB670", Offset = "0x51FA270", VA = "0x1851FB670", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019B")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6000ED9")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x000088F8 File Offset: 0x00006AF8
		[Token(Token = "0x1700019C")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000EDA")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x51FAE10", Offset = "0x51F9A10", VA = "0x1851FAE10", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x51FBFC0", Offset = "0x51FABC0", VA = "0x1851FBFC0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x51FB9A0", Offset = "0x51FA5A0", VA = "0x1851FB9A0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x51FB7B0", Offset = "0x51FA3B0", VA = "0x1851FB7B0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
