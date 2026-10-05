using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	internal class Curve25519Point : AbstractFpPoint
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001256")]
		[Address(RVA = "0x5227150", Offset = "0x5225D50", VA = "0x185227150")]
		public Curve25519Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x52270B0", Offset = "0x5225CB0", VA = "0x1852270B0")]
		public Curve25519Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal Curve25519Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x5226320", Offset = "0x5224F20", VA = "0x185226320", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125A")]
		[Address(RVA = "0x5226620", Offset = "0x5225220", VA = "0x185226620", Slot = "14")]
		public override ECFieldElement GetZCoord(int index)
		{
			return null;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x5225920", Offset = "0x5224520", VA = "0x185225920", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125C")]
		[Address(RVA = "0x5226FA0", Offset = "0x5225BA0", VA = "0x185226FA0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125D")]
		[Address(RVA = "0x5226EB0", Offset = "0x5225AB0", VA = "0x185226EB0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x52267A0", Offset = "0x52253A0", VA = "0x1852267A0", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x5226670", Offset = "0x5225270", VA = "0x185226670", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x5226100", Offset = "0x5224D00", VA = "0x185226100", Slot = "35")]
		protected virtual Curve25519FieldElement CalculateJacobianModifiedW(Curve25519FieldElement Z, uint[] ZSquared)
		{
			return null;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x5226460", Offset = "0x5225060", VA = "0x185226460", Slot = "36")]
		protected virtual Curve25519FieldElement GetJacobianModifiedW()
		{
			return null;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x5226870", Offset = "0x5225470", VA = "0x185226870", Slot = "37")]
		protected virtual Curve25519Point TwiceJacobianModified(bool calculateW)
		{
			return null;
		}
	}
}
