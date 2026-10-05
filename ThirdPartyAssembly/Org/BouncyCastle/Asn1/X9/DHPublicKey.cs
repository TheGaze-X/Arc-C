using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003DE RID: 990
	[Token(Token = "0x20003DE")]
	public class DHPublicKey : Asn1Encodable
	{
		// Token: 0x06002139 RID: 8505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002139")]
		[Address(RVA = "0x53308F0", Offset = "0x532F4F0", VA = "0x1853308F0")]
		public static DHPublicKey GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x5330650", Offset = "0x532F250", VA = "0x185330650")]
		public static DHPublicKey GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x5330910", Offset = "0x532F510", VA = "0x185330910")]
		public DHPublicKey(DerInteger y)
		{
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000443")]
		public DerInteger Y
		{
			[Token(Token = "0x600213C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerInteger y;
	}
}
