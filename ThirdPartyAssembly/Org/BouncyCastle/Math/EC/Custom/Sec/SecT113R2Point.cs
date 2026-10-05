using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	internal class SecT113R2Point : AbstractF2mPoint
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x51FE480", Offset = "0x51FD080", VA = "0x1851FE480")]
		public SecT113R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x51FE3E0", Offset = "0x51FCFE0", VA = "0x1851FE3E0")]
		public SecT113R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT113R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x51FD570", Offset = "0x51FC170", VA = "0x1851FD570", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A5")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6000EF1")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x000089D0 File Offset: 0x00006BD0
		[Token(Token = "0x170001A6")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000EF2")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x51FCD10", Offset = "0x51FB910", VA = "0x1851FCD10", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x51FDEC0", Offset = "0x51FCAC0", VA = "0x1851FDEC0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x51FD8A0", Offset = "0x51FC4A0", VA = "0x1851FD8A0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x51FD6B0", Offset = "0x51FC2B0", VA = "0x1851FD6B0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
