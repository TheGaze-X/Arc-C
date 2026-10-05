using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	internal class Curve25519 : AbstractFpCurve
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001220")]
		[Address(RVA = "0x5227690", Offset = "0x5226290", VA = "0x185227690")]
		public Curve25519()
		{
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001221")]
		[Address(RVA = "0x52271F0", Offset = "0x5225DF0", VA = "0x1852271F0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x52275F0", Offset = "0x52261F0", VA = "0x1852275F0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028F")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6001223")]
			[Address(RVA = "0x5227970", Offset = "0x5226570", VA = "0x185227970", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000290")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6001224")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x17000291")]
		public override int FieldSize
		{
			[Token(Token = "0x6001225")]
			[Address(RVA = "0x5227910", Offset = "0x5226510", VA = "0x185227910", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x52273F0", Offset = "0x5225FF0", VA = "0x1852273F0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x5227240", Offset = "0x5225E40", VA = "0x185227240", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x5227340", Offset = "0x5225F40", VA = "0x185227340", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		private const int Curve25519_DEFAULT_COORDS = 4;

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x50")]
		protected readonly Curve25519Point m_infinity;
	}
}
