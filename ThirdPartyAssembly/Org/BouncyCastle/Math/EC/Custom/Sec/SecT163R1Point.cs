using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001DE RID: 478
	[Token(Token = "0x20001DE")]
	internal class SecT163R1Point : AbstractF2mPoint
	{
		// Token: 0x06000FB6 RID: 4022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x520AB10", Offset = "0x5209710", VA = "0x18520AB10")]
		public SecT163R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x520AA70", Offset = "0x5209670", VA = "0x18520AA70")]
		public SecT163R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT163R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x5209C00", Offset = "0x5208800", VA = "0x185209C00", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DF")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x170001E0")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x52093A0", Offset = "0x5207FA0", VA = "0x1852093A0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x520A550", Offset = "0x5209150", VA = "0x18520A550", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x5209F30", Offset = "0x5208B30", VA = "0x185209F30", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x5209D40", Offset = "0x5208940", VA = "0x185209D40", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
