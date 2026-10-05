using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	// Token: 0x02000204 RID: 516
	[Token(Token = "0x2000204")]
	internal class Curve25519Field
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x5224910", Offset = "0x5223510", VA = "0x185224910")]
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122B")]
		[Address(RVA = "0x5224590", Offset = "0x5223190", VA = "0x185224590")]
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x5224650", Offset = "0x5223250", VA = "0x185224650")]
		public static void AddOne(uint[] x, uint[] z)
		{
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122D")]
		[Address(RVA = "0x5224A10", Offset = "0x5223610", VA = "0x185224A10")]
		public static uint[] FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x5224AD0", Offset = "0x52236D0", VA = "0x185224AD0")]
		public static void Half(uint[] x, uint[] z)
		{
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x5224C60", Offset = "0x5223860", VA = "0x185224C60")]
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x5224BA0", Offset = "0x52237A0", VA = "0x185224BA0")]
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x5224CF0", Offset = "0x52238F0", VA = "0x185224CF0")]
		public static void Negate(uint[] x, uint[] z)
		{
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001232")]
		[Address(RVA = "0x5224EB0", Offset = "0x5223AB0", VA = "0x185224EB0")]
		public static void Reduce(uint[] xx, uint[] z)
		{
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001233")]
		[Address(RVA = "0x5224D80", Offset = "0x5223980", VA = "0x185224D80")]
		public static void Reduce27(uint x, uint[] z)
		{
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x5225260", Offset = "0x5223E60", VA = "0x185225260")]
		public static void Square(uint[] x, uint[] z)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x5225030", Offset = "0x5223C30", VA = "0x185225030")]
		public static void SquareN(uint[] x, int n, uint[] z)
		{
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x5225660", Offset = "0x5224260", VA = "0x185225660")]
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x52254B0", Offset = "0x52240B0", VA = "0x1852254B0")]
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001238")]
		[Address(RVA = "0x5225730", Offset = "0x5224330", VA = "0x185225730")]
		public static void Twice(uint[] x, uint[] z)
		{
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x52248A0", Offset = "0x52234A0", VA = "0x1852248A0")]
		private static uint AddPTo(uint[] z)
		{
			return 0U;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x5224740", Offset = "0x5223340", VA = "0x185224740")]
		private static uint AddPExtTo(uint[] zz)
		{
			return 0U;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x5225440", Offset = "0x5224040", VA = "0x185225440")]
		private static int SubPFrom(uint[] z)
		{
			return 0;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x52252E0", Offset = "0x5223EE0", VA = "0x1852252E0")]
		private static int SubPExtFrom(uint[] zz)
		{
			return 0;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Curve25519Field()
		{
		}

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly uint[] P;

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		private const uint P7 = 2147483647U;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] PExt;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		private const uint PInv = 19U;
	}
}
