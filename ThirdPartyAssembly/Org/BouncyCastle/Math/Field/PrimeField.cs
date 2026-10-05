using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	internal class PrimeField : IFiniteField
	{
		// Token: 0x06000A32 RID: 2610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal PrimeField(BigInteger characteristic)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EF")]
		public virtual BigInteger Characteristic
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x170000F0")]
		public virtual int Dimension
		{
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x54B57A0", Offset = "0x54B43A0", VA = "0x1854B57A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x10")]
		protected readonly BigInteger characteristic;
	}
}
