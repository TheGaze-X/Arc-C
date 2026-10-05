using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	internal class SecT193R1Point : AbstractF2mPoint
	{
		// Token: 0x0600101A RID: 4122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x5210D00", Offset = "0x520F900", VA = "0x185210D00")]
		public SecT193R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x5210C60", Offset = "0x520F860", VA = "0x185210C60")]
		public SecT193R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT193R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x520FDF0", Offset = "0x520E9F0", VA = "0x18520FDF0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FC")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x600101E")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x170001FD")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x600101F")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001020")]
		[Address(RVA = "0x520F590", Offset = "0x520E190", VA = "0x18520F590", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x5210740", Offset = "0x520F340", VA = "0x185210740", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x5210120", Offset = "0x520ED20", VA = "0x185210120", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x520FF30", Offset = "0x520EB30", VA = "0x18520FF30", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
