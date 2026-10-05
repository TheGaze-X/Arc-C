using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	internal class SecT131R2Point : AbstractF2mPoint
	{
		// Token: 0x06000F51 RID: 3921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x5204970", Offset = "0x5203570", VA = "0x185204970")]
		public SecT131R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x52048D0", Offset = "0x52034D0", VA = "0x1852048D0")]
		public SecT131R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT131R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x5203A60", Offset = "0x5202660", VA = "0x185203A60", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6000F55")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x170001C3")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x5203200", Offset = "0x5201E00", VA = "0x185203200", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x52043B0", Offset = "0x5202FB0", VA = "0x1852043B0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x5203D90", Offset = "0x5202990", VA = "0x185203D90", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x5203BA0", Offset = "0x52027A0", VA = "0x185203BA0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
