using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	public class AlgorithmIdentifier : Asn1Encodable
	{
		// Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x532A510", Offset = "0x5329110", VA = "0x18532A510")]
		public static AlgorithmIdentifier GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x532A3D0", Offset = "0x5328FD0", VA = "0x18532A3D0")]
		public static AlgorithmIdentifier GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public AlgorithmIdentifier(DerObjectIdentifier algorithm)
		{
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D7")]
		[Address(RVA = "0x532A6C0", Offset = "0x53292C0", VA = "0x18532A6C0")]
		[Obsolete("Use version taking a DerObjectIdentifier")]
		public AlgorithmIdentifier(string algorithm)
		{
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D8")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public AlgorithmIdentifier(DerObjectIdentifier algorithm, Asn1Encodable parameters)
		{
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D9")]
		[Address(RVA = "0x532A750", Offset = "0x5329350", VA = "0x18532A750")]
		internal AlgorithmIdentifier(Asn1Sequence seq)
		{
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000459")]
		public virtual DerObjectIdentifier Algorithm
		{
			[Token(Token = "0x60021DA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045A")]
		[Obsolete("Use 'Algorithm' property instead")]
		public virtual DerObjectIdentifier ObjectID
		{
			[Token(Token = "0x60021DB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045B")]
		public virtual Asn1Encodable Parameters
		{
			[Token(Token = "0x60021DC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DD")]
		[Address(RVA = "0x532A530", Offset = "0x5329130", VA = "0x18532A530", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerObjectIdentifier algorithm;

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x18")]
		private readonly Asn1Encodable parameters;
	}
}
