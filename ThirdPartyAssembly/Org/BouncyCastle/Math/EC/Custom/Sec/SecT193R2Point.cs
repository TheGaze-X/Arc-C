using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	internal class SecT193R2Point : AbstractF2mPoint
	{
		// Token: 0x06001032 RID: 4146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x52129D0", Offset = "0x52115D0", VA = "0x1852129D0")]
		public SecT193R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x5212930", Offset = "0x5211530", VA = "0x185212930")]
		public SecT193R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT193R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x5211AC0", Offset = "0x52106C0", VA = "0x185211AC0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000206")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6001036")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x17000207")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6001037")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x5211260", Offset = "0x520FE60", VA = "0x185211260", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001039")]
		[Address(RVA = "0x5212410", Offset = "0x5211010", VA = "0x185212410", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103A")]
		[Address(RVA = "0x5211DF0", Offset = "0x52109F0", VA = "0x185211DF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x5211C00", Offset = "0x5210800", VA = "0x185211C00", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
