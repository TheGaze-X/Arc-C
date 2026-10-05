using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	internal class GenericPolynomialExtensionField : IPolynomialExtensionField, IExtensionField, IFiniteField
	{
		// Token: 0x06000A1E RID: 2590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		internal GenericPolynomialExtensionField(IFiniteField subfield, IPolynomial polynomial)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E3")]
		public virtual BigInteger Characteristic
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x54AD120", Offset = "0x54ABD20", VA = "0x1854AD120", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x170000E4")]
		public virtual int Dimension
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x54AD1C0", Offset = "0x54ABDC0", VA = "0x1854AD1C0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E5")]
		public virtual IFiniteField Subfield
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x170000E6")]
		public virtual int Degree
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x54AD170", Offset = "0x54ABD70", VA = "0x1854AD170", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E7")]
		public virtual IPolynomial MinimalPolynomial
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x54ACF50", Offset = "0x54ABB50", VA = "0x1854ACF50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x54AD080", Offset = "0x54ABC80", VA = "0x1854AD080", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IFiniteField subfield;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x18")]
		protected readonly IPolynomial minimalPolynomial;
	}
}
