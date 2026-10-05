using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001A9 RID: 425
	[Token(Token = "0x20001A9")]
	internal class SecP160R2Curve : AbstractFpCurve
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x54C0660", Offset = "0x54BF260", VA = "0x1854C0660")]
		public SecP160R2Curve()
		{
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x54C0330", Offset = "0x54BEF30", VA = "0x1854C0330", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x54C0950", Offset = "0x54BF550", VA = "0x1854C0950", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014C")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x1700014D")]
		public override int FieldSize
		{
			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x54C08F0", Offset = "0x54BF4F0", VA = "0x1854C08F0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x54C0530", Offset = "0x54BF130", VA = "0x1854C0530", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x54C0430", Offset = "0x54BF030", VA = "0x1854C0430", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x54C0380", Offset = "0x54BEF80", VA = "0x1854C0380", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		private const int SecP160R2_DEFAULT_COORDS = 2;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP160R2Point m_infinity;
	}
}
